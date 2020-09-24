using DataModel;
using DataModel.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Queries.Auth;
using CCG.AspNetCore.Data.Auth.Model;
using Xunit;
using Xunit.Abstractions;
using Xunit.Extensions.AssertExtensions;

namespace Business.Queries.Tests.Auth
{
    public class GetAllUsersQueryHandlerTests : IDisposable
    {
        private readonly ITestOutputHelper _output;
        private readonly DbHelper<ExampleDbContext> _dbHelper;
        private readonly ExampleDbContext _handlerDbContext;
        private readonly GetAllUsersQueryHandler<ExampleDbContext> _handler;

        public GetAllUsersQueryHandlerTests(ITestOutputHelper output)
        {
            _output = output;
            _dbHelper = new DbHelper<ExampleDbContext>().RunMigrations();
            _handlerDbContext = _dbHelper.GetDbContext();
            _handler = new GetAllUsersQueryHandler<ExampleDbContext>(_handlerDbContext);
        }

        public void Dispose()
        {
            _handlerDbContext.Dispose();
        }

        [Fact]
        public async Task ShouldBeEmptyWhenNoUsers()
        {
            var users = await _handler.HandleAsync();
            users.ShouldBeEmpty();
        }

        [Fact]
        public async Task ShouldContainActiveUser()
        {
            var user = new User()
            {
                Id = Guid.NewGuid(),
                IsActive = true,
                NameIdentifier = "1",
                SystemRoleId = DataModel.Lookup.Auth.SystemRoles.Single(e => e.Code == "User").Id,
                UserClaims = new List<UserClaim>()
                {
                    new UserClaim() { Type = ClaimTypes.Email, Value = "A" },
                    new UserClaim() { Type = ClaimTypes.GivenName, Value = "B" },
                    new UserClaim() { Type = ClaimTypes.Surname, Value = "a@example.com" }
                }

            };

            using (var db = _dbHelper.GetDbContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }

            var users = (await _handler.HandleAsync()).ToList();
            users.ShouldNotBeEmpty();
            users.Select(e => e.Id).ShouldContain(user.Id);
        }

        [Fact]
        public async Task ShouldContainInactiveUser()
        {
            var user = new User()
            {
                Id = Guid.NewGuid(),
                IsActive = false,
                NameIdentifier = "1",
                SystemRoleId = DataModel.Lookup.Auth.SystemRoles.Single(e => e.Code == "User").Id,
                UserClaims = new List<UserClaim>()
                {
                    new UserClaim() { Type = ClaimTypes.Email, Value = "A" },
                    new UserClaim() { Type = ClaimTypes.GivenName, Value = "B" },
                    new UserClaim() { Type = ClaimTypes.Surname, Value = "a@example.com" }
                }

            };

            using (var db = _dbHelper.GetDbContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }

            var users = (await _handler.HandleAsync()).ToList();
            users.ShouldNotBeEmpty();
            users.Select(e => e.Id).ShouldContain(user.Id);
        }

        [Fact]
        public async Task ShouldContainFullName()
        {
            var user = new User()
            {
                Id = Guid.NewGuid(),
                IsActive = false,
                NameIdentifier = "1",
                SystemRoleId = DataModel.Lookup.Auth.SystemRoles.Single(e => e.Code == "User").Id,
                UserClaims = new List<UserClaim>()
                {
                    new UserClaim() { Type = ClaimTypes.Email, Value = "A" },
                    new UserClaim() { Type = ClaimTypes.GivenName, Value = "B" },
                    new UserClaim() { Type = ClaimTypes.Surname, Value = "a@example.com" }
                }

            };

            using (var db = _dbHelper.GetDbContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }

            var users = (await _handler.HandleAsync()).ToList();
            users.Single().FullName.ShouldEqual($"{user.UserClaims.Where(c=> c.Type == ClaimTypes.GivenName).Select(c => c.Value).SingleOrDefault()} {user.UserClaims.Where(c => c.Type == ClaimTypes.Surname).Select(c => c.Value).SingleOrDefault()}");
        }

    }
}
