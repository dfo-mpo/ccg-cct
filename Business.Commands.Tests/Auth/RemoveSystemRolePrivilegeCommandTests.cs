using System;
using System.Collections.Generic;
using System.Linq;
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
    public class RemoveSystemRolePrivilegeCommandTests : IDisposable
    {
        private readonly ITestOutputHelper _output;
        private readonly DbHelper<ExampleDbContext> _dbHelper;
        private readonly ExampleDbContext _handlerDbContext;
        private readonly RemoveSystemRolePrivilegeCommandHandler<ExampleDbContext> _handler;
        private readonly RemoveSystemRolePrivilegeCommandValidator<ExampleDbContext> _validator;

        public RemoveSystemRolePrivilegeCommandTests(ITestOutputHelper output)
        {
            _output = output;
            _dbHelper = new DbHelper<ExampleDbContext>().RunMigrations();
            _handlerDbContext = _dbHelper.GetDbContext();
            _handler = new RemoveSystemRolePrivilegeCommandHandler<ExampleDbContext>(_handlerDbContext);
            _validator = new RemoveSystemRolePrivilegeCommandValidator<ExampleDbContext>(_handlerDbContext);
        }

        public void Dispose()
        {
            _handlerDbContext.Dispose();
        }

        public static IEnumerable<object[]> ValidatorData =>
            new List<object[]>
            {
                new object[] { Guid.Empty, Guid.Empty, false },
                new object[] { Guid.NewGuid(), Guid.NewGuid(), false },
            };

        [Theory]
        [MemberData(nameof(ValidatorData))]
        public void Validator(Guid systemRoleId, Guid privilegeId, bool isValid)
        {
            var command = new RemoveSystemRolePrivilegeCommand()
                { SystemRoleId = systemRoleId, PrivilegeId = privilegeId};

            var result = _validator.Validate(command);
            result.IsValid.ShouldEqual(isValid);
        }

        [Fact]
        public void ValidatorValid()
        {
            RemoveSystemRolePrivilegeCommand command;
            using (var db = _dbHelper.GetDbContext())
            {
                command = new RemoveSystemRolePrivilegeCommand()
                    { SystemRoleId = db.SystemRoles.First().Id, PrivilegeId = db.Privileges.First().Id };
            }

            var result = _validator.Validate(command);
            result.IsValid.ShouldBeTrue();
        }

        [Fact]
        public async Task ExecuteRemoveWhenNotExists()
        {
            RemoveSystemRolePrivilegeCommand command;
            using (var db = _dbHelper.GetDbContext())
            {
                db.SystemRolePrivileges.RemoveRange(db.SystemRolePrivileges);
                command = new RemoveSystemRolePrivilegeCommand()
                    { SystemRoleId = db.SystemRoles.First().Id, PrivilegeId = db.Privileges.First().Id };
                db.SaveChanges();

            }

            await _handler.ExecuteAsync(command);
            using (var db = _dbHelper.GetDbContext())
            {
                db.SystemRolePrivileges.Any().ShouldBeFalse();
            }
        }

        [Fact]
        public async Task ExecuteRemoveWhenExists()
        {
            RemoveSystemRolePrivilegeCommand command;
            using (var db = _dbHelper.GetDbContext())
            {
                db.SystemRolePrivileges.RemoveRange(db.SystemRolePrivileges);
                command = new RemoveSystemRolePrivilegeCommand()
                    { SystemRoleId = db.SystemRoles.First().Id, PrivilegeId = db.Privileges.First().Id };
                db.SystemRolePrivileges.Add(new SystemRolePrivilege()
                {
                    PrivilegeId = command.PrivilegeId, SystemRoleId = command.SystemRoleId
                });
                db.SaveChanges();

            }
            using (var db = _dbHelper.GetDbContext())
            {
                db.SystemRolePrivileges.Count().ShouldEqual(1);
            }
            await _handler.ExecuteAsync(command);
            using (var db = _dbHelper.GetDbContext())
            {
                db.SystemRolePrivileges.Any().ShouldBeFalse();
            }
        }
    }
}
