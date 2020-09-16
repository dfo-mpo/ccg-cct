using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CCG.AspNetCore.Business;
using CCG.AspNetCore.Business.Commands.Auth;
using CCG.AspNetCore.Common.Configuration;
using CCG.AspNetCore.Common.Resources;
using CCG.AspNetCore.Data.Auth.Model;
using CCG.AspNetCore.Data.Services.Models;
using DataModel;
using DataModel.Tests;
using DataModel.Tests.Services;
using Microsoft.Extensions.Options;
using Xunit;
using Xunit.Extensions.AssertExtensions;

namespace Business.Commands.Tests.Auth
{
    public class InviteNewUserAccountCommandTests : IDisposable
    {
        private readonly DbHelper<ExampleDbContext> _dbHelper;
        private readonly ExampleDbContext _handlerDbContext;
        private readonly TestEmailSender _emailSender;
        private readonly TestHttpContextAccessor _httpContextAccessor;
        private readonly TestUserService _testUserService;
        private readonly InviteNewUserAccountCommandHandler<ExampleDbContext> _handler;
        private readonly InviteNewUserAccountCommandValidator<ExampleDbContext> _validator;

        public InviteNewUserAccountCommandTests()
        {
            _dbHelper = new DbHelper<ExampleDbContext>().RunMigrations();
            _handlerDbContext = _dbHelper.GetDbContext();

            _emailSender = new TestEmailSender();
            _httpContextAccessor = new TestHttpContextAccessor();
            _testUserService = new TestUserService();

            var authEmailSender = new AuthEmailSender(_httpContextAccessor, _emailSender, GetIdentityProviderConfiguration(), GetApplicationConfiguration());

            _handler = new InviteNewUserAccountCommandHandler<ExampleDbContext>(_handlerDbContext, authEmailSender, _testUserService);
            _validator = new InviteNewUserAccountCommandValidator<ExampleDbContext>(_handlerDbContext);
        }

        private static CcgAccountClientConfiguration GetIdentityProviderConfiguration()
        {
            return new CcgAccountClientConfiguration()
            {
                Client = "http://client.local",
                ApiName = "VocApi",
                Authority = "http://authority.local"
            };
        }

        private static ApplicationConfiguration GetApplicationConfiguration()
        {
            return new ApplicationConfiguration()
            {
                NameEn = "VOC Name English", NameFr = "VOC Name French"
            };
        }

        public void Dispose()
        {
            _handlerDbContext.Dispose();
        }

        public static IEnumerable<object[]> ValidatorData =>
            new List<object[]>
            {
                new object[] { null, null, null, Guid.Empty, false }, // null
                new object[] { "", "", "", Guid.Empty, false }, // empty
                new object[] { "asdf", "asdf", "asdf", null, false }, // email format
                new object[] { "asdf", "asdf", StringHelper.Generate(250)+"@abc.ca", null, false }, // email length
                new object[] { "asdf", StringHelper.Generate(51), "a@abc.ca", null, false }, // surname length
                new object[] { StringHelper.Generate(51),  "asdf",  "a@abc.ca", null, false }, // givenname length
                new object[] { "asdf", "asdf", "a@abc.ca", null, true }, // valid
            };

        [Theory]
        [MemberData(nameof(ValidatorData))]
        public void Validator(string givenName, string surname, string email, Guid? systemRoleId, bool isValid)
        {
            if (!systemRoleId.HasValue)
            {
                using (var db = _dbHelper.GetDbContext())
                {
                    systemRoleId = db.SystemRoles.First(e => e.IsActive).Id;
                }
            }
            var command = new InviteNewUserAccountCommand()
            { GivenName = givenName, Surname = surname, Email = email, SystemRoleId = systemRoleId.Value };

            var result = _validator.Validate(command);
            result.IsValid.ShouldEqual(isValid);
        }

        [Fact]
        public void ValidatorSystemRoleId()
        {
            
            var command = new InviteNewUserAccountCommand()
                { GivenName = "asf", Surname = "asdf", Email = "abc@abc.ca", SystemRoleId = Guid.NewGuid() };

            var result = _validator.Validate(command);
            result.IsValid.ShouldEqual(false);
        }

        [Fact]
        public void ValidatorUniqueEmail()
        {
            User user;
            using (var db = _dbHelper.GetDbContext())
            {
                user = new User()
                {
                    Id = Guid.NewGuid(),
                    IsActive = true,
                    NameIdentifier = "123",
                    UserClaims = new List<UserClaim>()
                    {
                        new UserClaim() { Type = ClaimTypes.Email, Value = "A" },
                        new UserClaim() { Type = ClaimTypes.GivenName, Value = "B" },
                        new UserClaim() { Type = ClaimTypes.Surname, Value = "a@example.com" }
                    },

                    SystemRoleId = db.SystemRoles.First(e => e.IsActive).Id
                };
                db.Users.Add(user);
                db.SaveChanges();
            }
            var command = new InviteNewUserAccountCommand()
            {
                Email = user.UserClaims.Where(c => c.Type == ClaimTypes.Email).Select(c => c.Value).SingleOrDefault(),
                GivenName = user.UserClaims.Where(c => c.Type == ClaimTypes.GivenName).Select(c => c.Value).SingleOrDefault(),
                Surname = user.UserClaims.Where(c => c.Type == ClaimTypes.Surname).Select(c => c.Value).SingleOrDefault(),
                SystemRoleId = user.SystemRoleId
            };

            var result = _validator.Validate(command);
            result.IsValid.ShouldEqual(false);
        }

        [Fact]
        public async Task ShouldAddNewUserFromIdentityProvider()
        {
            var userResult = new CcgAccountUser()
                {id = Guid.NewGuid().ToString(), name = "Test"};
            _testUserService.SetUserResult(userResult);

            InviteNewUserAccountCommand command;
            using (var db = _dbHelper.GetDbContext())
            {
                command = new InviteNewUserAccountCommand()
                {
                    Email = "a@abc.ca",
                    GivenName = "asdf",
                    Surname = "asdf",
                    SystemRoleId = db.SystemRoles.First(e => e.IsActive).Id
                };
            }

            await _handler.ExecuteAsync(command);

            using (var db = _dbHelper.GetDbContext())
            {
                var user = db.Users.Single();
                user.ShouldNotBeNull();
                user.NameIdentifier.ShouldEqual(userResult.id);
                user.IsActive.ShouldBeTrue();
                user.SystemRoleId.ShouldEqual(command.SystemRoleId);
                _emailSender.SentMessages.ShouldNotBeEmpty();
                _emailSender.SentMessages.Count().ShouldEqual(1);
                _emailSender.SentMessages.Any(e => e.Subject.Contains(Email.AccessTitle)).ShouldBeTrue();
            }
        }

        [Fact]
        public async Task ShouldAddNewUserNotFromIdentityProvider()
        {
            _testUserService.SetUserResult(null);

            InviteNewUserAccountCommand command;
            using (var db = _dbHelper.GetDbContext())
            {
                command = new InviteNewUserAccountCommand()
                {
                    Email = "a@abc.ca",
                    GivenName = "asdf",
                    Surname = "asdf",
                    SystemRoleId = db.SystemRoles.First(e => e.IsActive).Id
                };
            }

            await _handler.ExecuteAsync(command);

            using (var db = _dbHelper.GetDbContext())
            {
                var user = db.Users.Single();
                user.ShouldNotBeNull();
                user.IsActive.ShouldBeTrue();
                user.SystemRoleId.ShouldEqual(command.SystemRoleId);
                _emailSender.SentMessages.ShouldNotBeEmpty();
                _emailSender.SentMessages.Count().ShouldEqual(1);
                _emailSender.SentMessages.Any(e => e.Subject.Contains(Email.InvitationTitle)).ShouldBeTrue();
            }
        }

    }
}
