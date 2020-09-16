using DataModel;
using DataModel.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Queries.Auth;
using CCG.AspNetCore.Data.Auth.Model;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Xunit.Abstractions;
using Xunit.Extensions.AssertExtensions;

namespace Business.Queries.Tests.Auth
{
    public class CheckUserHasPrivilegeQueryHandlerTests : IDisposable
    {
        private readonly ITestOutputHelper _output;
        private readonly DbHelper<ExampleDbContext> _dbHelper;
        private readonly ExampleDbContext _handlerDbContext;
        private readonly TestHttpContextAccessor _httpContextAccessor;
        private readonly CheckUserHasPrivilegeQueryHandler<ExampleDbContext> _handler;

        public CheckUserHasPrivilegeQueryHandlerTests(ITestOutputHelper output)
        {
            _output = output;
            _dbHelper = new DbHelper<ExampleDbContext>().RunMigrations();
            _handlerDbContext = _dbHelper.GetDbContext();
            _httpContextAccessor = new TestHttpContextAccessor();
            _handler = new CheckUserHasPrivilegeQueryHandler<ExampleDbContext>(_handlerDbContext, _httpContextAccessor);
        }

        public void Dispose()
        {
            _handlerDbContext.Dispose();
        }

        [Fact]
        public async Task NoUser()
        {
            var result = await _handler.HandleAsync(new CheckUserHasPrivilegeQuery()
            {
                Codes = new [] { DataModel.Lookup.Auth.Privileges.First().Code }
            });
            result.ShouldEqual(false);
        }

        [Fact]
        public async Task UserNull()
        {
            _httpContextAccessor.SetUser(new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, Guid.NewGuid().ToString())
            });

            var result = await _handler.HandleAsync(new CheckUserHasPrivilegeQuery()
            {
                Codes = new[] { DataModel.Lookup.Auth.Privileges.First().Code }
            });

            result.ShouldEqual(false);
        }

        [Fact]
        public async Task UserInactive()
        {
            var privilege = "";

            using (var db = _dbHelper.GetDbContext())
            {
                db.Users.Add(new User()
                {
                    Id = Guid.NewGuid(),
                    IsActive = false,
                    NameIdentifier = Guid.NewGuid().ToString(),
                    SystemRoleId = CCG.AspNetCore.Data.Auth.Lookup.SystemRoles.Single(e => e.Code == "Guest").Id,
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
                var user = db.Users.Include(e => e.SystemRole.SystemRolePrivileges).ThenInclude(e => e.Privilege).Single();
                privilege = user.SystemRole.SystemRolePrivileges.First(e => e.Privilege.IsActive).Privilege.Code;
                _httpContextAccessor.SetUser(db.Users.Single());
            }

            var result = await _handler.HandleAsync(new CheckUserHasPrivilegeQuery()
            {
                Codes = new [] { DataModel.Lookup.Auth.Privileges.First().Code }
            });

            result.ShouldEqual(false);
        }

        [Fact]
        public async Task RoleInactive()
        {
            Privilege privilege;
            using (var db = _dbHelper.GetDbContext())
            {
                var roleId = CCG.AspNetCore.Data.Auth.Lookup.SystemRoles.Single(systemRole => systemRole.Code == "Guest").Id;
                var role = db.SystemRoles.Single(e => e.Id == roleId);
                role.IsActive = false;

                db.Users.Add(new User()
                {
                    Id = Guid.NewGuid(),
                    IsActive = true,
                    NameIdentifier = Guid.NewGuid().ToString(),
                    SystemRoleId = roleId,
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
                var user = db.Users.Include(e => e.SystemRole.SystemRolePrivileges).ThenInclude(e => e.Privilege).Single();
                privilege = user.SystemRole.SystemRolePrivileges.First(e => e.Privilege.IsActive).Privilege;
                _httpContextAccessor.SetUser(db.Users.Single());
            }

            var result = await _handler.HandleAsync(new CheckUserHasPrivilegeQuery()
            {
                Codes = new []{ privilege.Code }
            });

            result.ShouldEqual(false);
        }

        [Fact]
        public async Task PrivilegeInactive()
        {
            Privilege privilege;
            using (var db = _dbHelper.GetDbContext())
            {
                db.Users.Add(new User()
                {
                    Id = Guid.NewGuid(),
                    IsActive = true,
                    NameIdentifier = Guid.NewGuid().ToString(),
                    SystemRoleId = CCG.AspNetCore.Data.Auth.Lookup.SystemRoles.Single(systemRole => systemRole.Code == "Guest").Id,
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
                var user = db.Users.Include(e => e.SystemRole.SystemRolePrivileges).ThenInclude(e => e.Privilege).Single();
                privilege = user.SystemRole.SystemRolePrivileges.First(e => e.Privilege.IsActive).Privilege;
                privilege.IsActive = false;
                db.SaveChanges();

                _httpContextAccessor.SetUser(db.Users.Single());
            }

            var result = await _handler.HandleAsync(new CheckUserHasPrivilegeQuery()
            {
                Codes = new [] { privilege.Code }
            });

            result.ShouldEqual(false);
        }

        [Fact]
        public async Task PrivilegeNotExist()
        {
            Privilege privilege = new Privilege(){Id = Guid.NewGuid(), Code = Guid.NewGuid().ToString(), IsActive = true};
            using (var db = _dbHelper.GetDbContext())
            {
                db.Entry(privilege).State = EntityState.Added;

                db.Users.Add(new User()
                {
                    Id = Guid.NewGuid(),
                    IsActive = true,
                    NameIdentifier = Guid.NewGuid().ToString(),
                    SystemRoleId = DataModel.Lookup.Auth.SystemRoles.First(e => e.IsActive).Id,
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
                var user = db.Users.Single();
                _httpContextAccessor.SetUser(db.Users.Single());
            }

            var result = await _handler.HandleAsync(new CheckUserHasPrivilegeQuery()
            {
                Codes = new []{ privilege.Code }
            });

            result.ShouldEqual(false);
        }

        [Fact]
        public async Task PrivilegeNotAssignToRole()
        {
            using (var db = _dbHelper.GetDbContext())
            {
                var role = db.SystemRoles.First();
                role.IsActive = false;

                db.Users.Add(new User()
                {
                    Id = Guid.NewGuid(),
                    IsActive = true,
                    NameIdentifier = Guid.NewGuid().ToString(),
                    SystemRoleId = role.Id,
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
                var user = db.Users.Single();
                _httpContextAccessor.SetUser(db.Users.Single());
            }

            var result = await _handler.HandleAsync(new CheckUserHasPrivilegeQuery()
            {
                Codes = new []{ Guid.NewGuid().ToString() }
            });

            result.ShouldEqual(false);
        }

        [Fact]
        public async Task AllActive()
        {
            Privilege privilege;
            using (var db = _dbHelper.GetDbContext())
            {
                db.Users.Add(new User()
                {
                    Id = Guid.NewGuid(),
                    IsActive = true,
                    NameIdentifier = Guid.NewGuid().ToString(),
                    SystemRoleId = CCG.AspNetCore.Data.Auth.Lookup.SystemRoles.Single(systemRole => systemRole.Code == "Guest").Id,
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
                var user = db.Users.Include(e => e.SystemRole.SystemRolePrivileges).ThenInclude(e => e.Privilege).Single();
                privilege = user.SystemRole.SystemRolePrivileges.First(e => e.Privilege.IsActive).Privilege;
                _httpContextAccessor.SetUser(db.Users.Single());
            }

            var result = await _handler.HandleAsync(new CheckUserHasPrivilegeQuery()
            {
                Codes = new []{ privilege.Code }
            });

            result.ShouldEqual(true);
        }


        [Fact]
        public async Task HasOneOfTwo()
        {
            Privilege privilege1, privilege2;
            using (var db = _dbHelper.GetDbContext())
            {
                db.Users.Add(new User()
                {
                    Id = Guid.NewGuid(),
                    IsActive = true,
                    NameIdentifier = Guid.NewGuid().ToString(),
                    SystemRoleId = CCG.AspNetCore.Data.Auth.Lookup.SystemRoles.Single(systemRole => systemRole.Code == "Guest").Id,
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
                var user = db.Users.Include(e => e.SystemRole.SystemRolePrivileges).ThenInclude(e => e.Privilege).Single();
                privilege1 = user.SystemRole.SystemRolePrivileges.First(e => e.Privilege.IsActive).Privilege;
                privilege2 = user.SystemRole.SystemRolePrivileges.Skip(1).First(e => e.Privilege.IsActive).Privilege;
                db.SystemRolePrivileges.Remove(user.SystemRole.SystemRolePrivileges.Single(e => e.PrivilegeId == privilege2.Id));
                db.SaveChanges();
                _httpContextAccessor.SetUser(db.Users.Single());
            }

            var result = await _handler.HandleAsync(new CheckUserHasPrivilegeQuery()
            {
                Codes = new[] { privilege1.Code, privilege2.Code }
            });

            result.ShouldEqual(true);
        }

    }
}
