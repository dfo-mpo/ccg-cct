using DataModel;
using DataModel.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Queries.Auth;
using CCG.AspNetCore.Common.Lookup;
using CCG.AspNetCore.Data.Auth.Model;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Xunit.Abstractions;
using Xunit.Extensions.AssertExtensions;

namespace Business.Queries.Tests.Auth
{
    public class GetUserClaimsQueryHandlerTests : IDisposable
    {
        private readonly ITestOutputHelper _output;
        private readonly DbHelper<ExampleDbContext> _dbHelper;
        private readonly ExampleDbContext _handlerDbContext;
        private readonly TestHttpContextAccessor _httpContextAccessor;
        private readonly GetUserClaimsQueryHandler<ExampleDbContext> _handler;

        public GetUserClaimsQueryHandlerTests(ITestOutputHelper output)
        {
            _output = output;
            _dbHelper = new DbHelper<ExampleDbContext>().RunMigrations();
            _handlerDbContext = _dbHelper.GetDbContext();
            _httpContextAccessor = new TestHttpContextAccessor();
            _handler = new GetUserClaimsQueryHandler<ExampleDbContext>(_handlerDbContext, _httpContextAccessor);
        }

        public void Dispose()
        {
            _handlerDbContext.Dispose();
        }

        [Fact]
        public async Task EmptyWhenNoUser()
        {
            var result = await _handler.HandleAsync();
            result.ShouldBeEmpty();
        }

        [Fact]
        public async Task EmptyWhenUserHasNoId()
        {
            _httpContextAccessor.SetUser(new List<Claim>());
            var result = await _handler.HandleAsync();
            result.ShouldBeEmpty();
        }

        [Fact]
        public async Task EmptyWhenUserHasIdButNoDb()
        {
            _httpContextAccessor.SetUser(new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, Guid.NewGuid().ToString())
            });
            var result = await _handler.HandleAsync();
            result.ShouldBeEmpty();
        }

        [Fact]
        public async Task EmptyWhenUserInactive()
        {
            using (var db = _dbHelper.GetDbContext())
            {
                db.Users.Add(new User()
                {
                    Id = Guid.NewGuid(),
                    IsActive = false,
                    NameIdentifier = Guid.NewGuid().ToString(),
                    SystemRoleId = DataModel.Lookup.Auth.SystemRoles.Single(e => e.Code == "User").Id,
                    UserClaims = new List<UserClaim>()
                    {
                        new UserClaim() { Type = ClaimTypes.Email, Value = "A" },
                        new UserClaim() { Type = ClaimTypes.GivenName, Value = "B" },
                        new UserClaim() { Type = ClaimTypes.Surname, Value = "a@example.com" }
                    }

                });
                db.SaveChanges();
            }

            using (var db = _dbHelper.GetDbContext())
            {
                _httpContextAccessor.SetUser(db.Users.Single());
            }

            var result = await _handler.HandleAsync();
            result.ShouldBeEmpty();
        }

        [Fact]
        public async Task ClaimsWhenUserActive()
        {
            using (var db = _dbHelper.GetDbContext())
            {
                db.Users.Add(new User()
                {
                    Id = Guid.NewGuid(),
                    IsActive = true,
                    NameIdentifier = Guid.NewGuid().ToString(),
                    SystemRoleId = CCG.AspNetCore.Data.Auth.Lookup.SystemRoles.Single(e => e.Code == "Guest").Id,
                    UserClaims = new List<UserClaim>()
                    {
                        new UserClaim() { Type = ClaimTypes.Email, Value = "A" },
                        new UserClaim() { Type = ClaimTypes.GivenName, Value = "B" },
                        new UserClaim() { Type = ClaimTypes.Surname, Value = "a@example.com" }
                    }

                });
                await db.SaveChangesAsync();
            }

            using (var db = _dbHelper.GetDbContext())
            {
                _httpContextAccessor.SetUser(await db.Users.SingleAsync());
            }

            var result = (await _handler.HandleAsync()).ToList();
            result.ShouldNotBeEmpty();
            result.Where(e => e.Type == ClaimTypes.Role).ShouldNotBeEmpty();
            result.Where(e => e.Type == CustomClaimTypes.Privilege).ShouldNotBeEmpty();
        }

        [Fact]
        public async Task NoPrivilegeClaimWhenPrivilegeInactive()
        {
            using (var db = _dbHelper.GetDbContext())
            {
                db.Users.Add(new User()
                {
                    Id = Guid.NewGuid(),
                    IsActive = true,
                    NameIdentifier = Guid.NewGuid().ToString(),
                    SystemRoleId = DataModel.Lookup.Auth.SystemRoles.Single(e => e.Code == "User").Id,
                    UserClaims = new List<UserClaim>()
                    {
                        new UserClaim() { Type = ClaimTypes.Email, Value = "A" },
                        new UserClaim() { Type = ClaimTypes.GivenName, Value = "B" },
                        new UserClaim() { Type = ClaimTypes.Surname, Value = "a@example.com" }
                    }

                });
                foreach (var priv in db.Privileges)
                {
                    priv.IsActive = false;
                }
                db.SaveChanges();
            }

            using (var db = _dbHelper.GetDbContext())
            {
                _httpContextAccessor.SetUser(db.Users.Single());
            }

            var result = await _handler.HandleAsync();
            result.Where(e => e.Type == CustomClaimTypes.Privilege).ShouldBeEmpty();
        }

        [Fact]
        public async Task NoRoleOrPrivilegeClaimsWhenRoleInactive()
        {
            using (var db = _dbHelper.GetDbContext())
            {
                db.Users.Add(new User()
                {
                    Id = Guid.NewGuid(),
                    IsActive = true,
                    NameIdentifier = Guid.NewGuid().ToString(),
                    SystemRoleId = DataModel.Lookup.Auth.SystemRoles.Single(e => e.Code == "User").Id,
                    UserClaims = new List<UserClaim>()
                    {
                        new UserClaim() { Type = ClaimTypes.Email, Value = "A" },
                        new UserClaim() { Type = ClaimTypes.GivenName, Value = "B" },
                        new UserClaim() { Type = ClaimTypes.Surname, Value = "a@example.com" }
                    }

                });
                foreach (var role in db.SystemRoles)
                {
                    role.IsActive = false;
                }
                db.SaveChanges();
            }

            using (var db = _dbHelper.GetDbContext())
            {
                _httpContextAccessor.SetUser(db.Users.Single());
            }

            var result = (await _handler.HandleAsync()).ToList();
            result.Where(e => e.Type == ClaimTypes.Role).ShouldBeEmpty();
            result.Where(e => e.Type == CustomClaimTypes.Privilege).ShouldBeEmpty();
        }
    }
}
