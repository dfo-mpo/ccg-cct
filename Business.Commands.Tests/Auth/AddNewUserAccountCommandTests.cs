using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Commands.Auth;
using CCG.AspNetCore.Data.Auth.Model;
using DataModel;
using DataModel.Tests;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Xunit.Abstractions;
using Xunit.Extensions.AssertExtensions;

namespace Business.Commands.Tests.Auth
{
    public class AddNewUserAccountCommandTests : IDisposable
    {
        private readonly ITestOutputHelper _output;
        private readonly DbHelper<ExampleDbContext> _dbHelper;
        private readonly ExampleDbContext _handlerDbContext;
        private readonly AddNewUserAccountCommandHandler<ExampleDbContext> _handler;
        private readonly AddNewUserAccountCommandValidator<ExampleDbContext> _validator;

        public AddNewUserAccountCommandTests(ITestOutputHelper output)
        {
            _output = output;
            _dbHelper = new DbHelper<ExampleDbContext>().RunMigrations();
            _handlerDbContext = _dbHelper.GetDbContext();
            _handler = new AddNewUserAccountCommandHandler<ExampleDbContext>(_handlerDbContext);
            _validator = new AddNewUserAccountCommandValidator<ExampleDbContext>(_handlerDbContext);
        }

        public void Dispose()
        {
            _handlerDbContext.Dispose();
        }

        public static IEnumerable<object[]> ValidatorData =>
            new List<object[]>
            {
                new object[] { null, null, null, null, false },
                new object[] { "", "", "", "", false },
                new object[] { StringHelper.Generate(51), StringHelper.Generate(51), StringHelper.Generate(51), StringHelper.Generate(251), false }, // max length
                new object[] { StringHelper.Generate(5), StringHelper.Generate(5), StringHelper.Generate(5), StringHelper.Generate(15), false }, // not email
                new object[] { "123", "A", "B", "test@test.com", true },
            };

        [Theory]
        [MemberData(nameof(ValidatorData))]
        public void Validator(string nameIdentifier, string givenName, string surname, string email, bool isValid)
        {
            var command = new AddNewUserAccountCommand()
                {Email = email, NameIdentifier = nameIdentifier, GivenName = givenName, Surname = surname};

            var result = _validator.Validate(command);
            result.IsValid.ShouldEqual(isValid);
        }

        [Fact]
        public void InvalidWhenAddingExistingUser()
        {

            var user = new User()
            {
                Id = Guid.NewGuid(),
                IsActive = true,
                NameIdentifier = "123",
                UserClaims = new List<UserClaim>()
                {
                    new UserClaim() { Type = ClaimTypes.Email, Value = "A" },
                    new UserClaim() { Type = ClaimTypes.GivenName, Value = "B" },
                    new UserClaim() { Type = ClaimTypes.Surname, Value = "a@example.com" }
                }
            };
            using (var db = _dbHelper.GetDbContext())
            {
                user.SystemRoleId = db.SystemRoles.First().Id;
                db.Attach(user).State = EntityState.Added;
                db.SaveChanges();
            }
            var command = new AddNewUserAccountCommand()
            {
                NameIdentifier = user.NameIdentifier,
                Email = user.UserClaims.Where(c => c.Type == ClaimTypes.Email).Select(c => c.Value).SingleOrDefault(),
                GivenName = user.UserClaims.Where(c => c.Type == ClaimTypes.GivenName).Select(c => c.Value).SingleOrDefault(),
                Surname = user.UserClaims.Where(c => c.Type == ClaimTypes.Surname).Select(c => c.Value).SingleOrDefault()
            };
            var result = _validator.Validate(command);
            result.IsValid.ShouldBeFalse();
        }

        [Fact]
        public async Task Execute()
        {
            using (var db = _dbHelper.GetDbContext())
            {
                db.Users.RemoveRange(db.Users);
                db.SaveChanges();
            }

            var command = new AddNewUserAccountCommand() { Email = "A@example.com", GivenName = "A", NameIdentifier = "123", Surname = "A" };
            await _handler.ExecuteAsync(command);

            using (var db = _dbHelper.GetDbContext())
            {
                db.Users.Single().NameIdentifier.ShouldEqual(command.NameIdentifier);
            }
        }

    }
}
