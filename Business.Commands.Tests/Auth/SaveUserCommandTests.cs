using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Commands.Auth;
using CCG.AspNetCore.Data.Auth.Model;
using DataModel;
using DataModel.Tests;
using Xunit;
using Xunit.Abstractions;
using Xunit.Extensions.AssertExtensions;

namespace Business.Commands.Tests.Auth
{
    public class SaveUserCommandTests : IDisposable
    {
        private readonly ITestOutputHelper _output;
        private readonly DbHelper<ExampleDbContext> _dbHelper;
        private readonly ExampleDbContext _handlerDbContext;
        private readonly SaveUserCommandHandler<ExampleDbContext> _handler;
        private readonly SaveUserCommandValidator<ExampleDbContext> _validator;

        public SaveUserCommandTests(ITestOutputHelper output)
        {
            _output = output;
            _dbHelper = new DbHelper<ExampleDbContext>().RunMigrations();
            _handlerDbContext = _dbHelper.GetDbContext();
            _handler = new SaveUserCommandHandler<ExampleDbContext>(_handlerDbContext);
            _validator = new SaveUserCommandValidator<ExampleDbContext>(_handlerDbContext);
        }

        public void Dispose()
        {
            _handlerDbContext.Dispose();
        }

        public static IEnumerable<object[]> ValidatorData =>
            new List<object[]>
            {
                new object[] { Guid.Empty, true, Guid.Empty, false },
                new object[] { Guid.NewGuid(), true, Guid.NewGuid(), false },
            };

        [Theory]
        [MemberData(nameof(ValidatorData))]
        public void Validator(Guid id, bool isActive, Guid systemRoleId, bool isValid)
        {
            var command = new SaveUserCommand()
                { Id = id,  SystemRoleId = systemRoleId, IsActive = isActive};

            var result = _validator.Validate(command);
            result.IsValid.ShouldEqual(isValid);
        }

        [Fact]
        public void ValidatorValid()
        {
            SetupNewUser();

            SaveUserCommand command;
            using (var db = _dbHelper.GetDbContext())
            {
                command = new SaveUserCommand()
                    { Id = db.Users.First().Id, SystemRoleId = db.SystemRoles.First().Id, IsActive = true };
            }

            var result = _validator.Validate(command);
            result.IsValid.ShouldBeTrue();
        }

        [Fact]
        public async Task UpdateUser()
        {
            SetupNewUser();

            SaveUserCommand command;
            using (var db = _dbHelper.GetDbContext())
            {
                var dbUser = db.Users.First();
                command = new SaveUserCommand()
                    { Id = dbUser.Id, SystemRoleId = dbUser.SystemRoleId, IsActive = !dbUser.IsActive };
            }

            await _handler.ExecuteAsync(command);
            using (var db = _dbHelper.GetDbContext())
            {
                db.Users.Single(e => e.Id == command.Id).IsActive.ShouldEqual(command.IsActive);
            }
        }

        private void SetupNewUser()
        {
            using (var db = _dbHelper.GetDbContext())
            {
                db.Users.RemoveRange(db.Users);
                db.Users.Add(new User()
                {
                    Id = Guid.NewGuid(),
                    NameIdentifier = "123",
                    SystemRoleId = db.SystemRoles.First().Id,
                    UserClaims = new List<UserClaim>()
                    {
                        new UserClaim() { Type = ClaimTypes.Email, Value = "A" },
                        new UserClaim() { Type = ClaimTypes.GivenName, Value = "B" },
                        new UserClaim() { Type = ClaimTypes.Surname, Value = "a@example.com" }
                    }

                });
                db.SaveChanges();
            }
        }
    }
}
