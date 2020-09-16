using System;
using System.Linq;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Queries.Auth;
using CCG.AspNetCore.Data.Auth.Model;
using DataModel;
using DataModel.Tests;
using Xunit;
using Xunit.Abstractions;
using Xunit.Extensions.AssertExtensions;

namespace Business.Queries.Tests.Auth
{
    public class GetAssignmentsQueryHandlerTests : IDisposable
    {
        private readonly ITestOutputHelper _output;
        private readonly DbHelper<ExampleDbContext> _dbHelper;
        private readonly ExampleDbContext _handlerDbContext;
        private readonly TestHttpContextAccessor _httpContextAccessor;
        private readonly GetAssignmentsQueryHandler<ExampleDbContext> _handler;

        public GetAssignmentsQueryHandlerTests(ITestOutputHelper output)
        {
            _output = output;
            _dbHelper = new DbHelper<ExampleDbContext>().RunMigrations();
            _handlerDbContext = _dbHelper.GetDbContext();
            _httpContextAccessor = new TestHttpContextAccessor();
            _handler = new GetAssignmentsQueryHandler<ExampleDbContext>(_handlerDbContext);
        }

        public void Dispose()
        {
            _handlerDbContext.Dispose();
        }

        [Fact]
        public async Task ShouldBeEmpty()
        {
            RemoveAllRolesAndPrivileges();

            var results = await _handler.HandleAsync();
            results.Privileges.ShouldBeEmpty();
            results.Roles.ShouldBeEmpty();
        }

        [Fact]
        public async Task ShouldNotShowInactive()
        {
            using (var db = _dbHelper.GetDbContext())
            {
                db.SystemRoles.ShouldNotBeEmpty();
                foreach (var role in db.SystemRoles)
                {
                    role.IsActive = false;
                }

                db.Privileges.ShouldNotBeEmpty();
                foreach (var privilege in db.Privileges)
                {
                    privilege.IsActive = false;
                }

                db.SaveChanges();
            }

            var results = await _handler.HandleAsync();
            results.Privileges.ShouldBeEmpty();
            results.Roles.ShouldBeEmpty();
        }

        [Fact]
        public async Task ShouldShowActive()
        {
            using (var db = _dbHelper.GetDbContext())
            {
                db.SystemRoles.ShouldNotBeEmpty();
                foreach (var role in db.SystemRoles)
                {
                    role.IsActive = true;
                }

                db.Privileges.ShouldNotBeEmpty();
                foreach (var privilege in db.Privileges)
                {
                    privilege.IsActive = true;
                }

                db.SaveChanges();
            }

            var results = await _handler.HandleAsync();
            results.Privileges.ShouldNotBeEmpty();
            results.Roles.ShouldNotBeEmpty();
        }

        [Fact]
        public async Task ShouldNotShowAssignmentsForInactiveRoles()
        {
            RemoveAllRolesAndPrivileges();

            var role = new SystemRole() { Id = Guid.NewGuid(), Code = "A", IsActive = false };
            var privilege = new Privilege() { Id = Guid.NewGuid(), Code = "B", IsActive = true };

            using (var db = _dbHelper.GetDbContext())
            {
                db.SystemRoles.Add(role);
                db.Privileges.Add(privilege);
                db.SystemRolePrivileges.Add(new SystemRolePrivilege() { Id = Guid.NewGuid(), PrivilegeId = privilege.Id, SystemRoleId = role.Id });
                db.SaveChanges();
            }

            var results = await _handler.HandleAsync();
            results.Privileges.ShouldNotBeEmpty();
            results.Roles.ShouldBeEmpty();
            results.Privileges.Single().RoleAssignments.ShouldBeEmpty();
        }

        [Fact]
        public async Task ShouldShowAssignments()
        {
            RemoveAllRolesAndPrivileges();

            var role = new SystemRole() { Id = Guid.NewGuid(), Code = "A", IsActive = true };
            var privilege = new Privilege() { Id = Guid.NewGuid(), Code = "B", IsActive = true };

            using (var db = _dbHelper.GetDbContext())
            {
                db.SystemRoles.Add(role);
                db.Privileges.Add(privilege);
                db.SystemRolePrivileges.Add(new SystemRolePrivilege() { Id = Guid.NewGuid(), PrivilegeId = privilege.Id, SystemRoleId = role.Id });
                db.SaveChanges();
            }

            var results = await _handler.HandleAsync();
            results.Privileges.ShouldNotBeEmpty();
            results.Roles.ShouldNotBeEmpty();
            results.Privileges.Single().RoleAssignments.ShouldNotBeEmpty();
            results.Privileges.Single().RoleAssignments.ContainsKey(role.Id).ShouldBeTrue();

        }

        private void RemoveAllRolesAndPrivileges()
        {
            using (var db = _dbHelper.GetDbContext())
            {
                db.SystemRolePrivileges.RemoveRange(db.SystemRolePrivileges);
                db.SystemRoles.RemoveRange(db.SystemRoles);
                db.Privileges.RemoveRange(db.Privileges);
                db.SaveChanges();
            }
        }
    }
}
