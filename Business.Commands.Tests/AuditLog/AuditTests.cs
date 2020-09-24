using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Audit.Core;
using CCG.AspNetCore.Business.Commands.Audits;
using CCG.AspNetCore.Data.Auth.Model;
using DataModel;
using DataModel.Tests;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Xunit.Abstractions;
using Xunit.Extensions.AssertExtensions;

namespace Business.Commands.Tests.AuditLog
{
    public class AuditTests
    {
        private readonly ITestOutputHelper _output;
        private readonly DbHelper<ExampleDbContext> _dbHelper;
        private readonly TestHttpContextAccessor _httpContextAccessor;

        public AuditTests(ITestOutputHelper output)
        {
            _output = output;
            _dbHelper = new DbHelper<ExampleDbContext>().RunMigrations();
            _httpContextAccessor = new TestHttpContextAccessor();
            Configuration.AuditDisabled = true;
        }

        [Fact]
        public void ShouldBeEmpty()
        {
            using (var db = _dbHelper.GetDbContext())
            {
                db.AuditLogs.ShouldBeEmpty();
            }
        }

        [Fact]
        public void NoAudit()
        {
            using (var db = _dbHelper.GetDbContext())
            {
                var vessel = new Privilege()
                {
                    Code = "A", DescFre = "A", DescEng = "A", IsActive = true
                };
                db.Privileges.Add(vessel);
                db.SaveChanges();
            }

            using (var db = _dbHelper.GetDbContext())
            {
                db.AuditLogs.ShouldBeEmpty();
            }

        }

        [Fact]
        public void AddAudit()
        {
            SetupAuditing();

            using (var db = _dbHelper.GetDbContext())
            {
                var vessel = new Privilege()
                {
                    Code = "A",
                    DescFre = "A",
                    DescEng = "A",
                    IsActive = true
                };
                db.Privileges.Add(vessel);
                db.SaveChanges();
            }

            using (var db = _dbHelper.GetDbContext())
            {
                db.AuditLogs.ShouldNotBeEmpty();
                var log = db.AuditLogs.Single();
                _output.WriteLine("Audit user: " + log.AuditUser);
                log.AuditUser.ShouldBeNull();

            }

        }

        [Fact]
        public async Task AddAuditWithUser()
        {
            await SetupNewUser();

            using (var db = _dbHelper.GetDbContext())
            {
                _httpContextAccessor.SetUser(db.Users.First());
                await db.SaveChangesAsync();
                SetupAuditing();
            }

            using (var db = _dbHelper.GetDbContext())
            {
                db.AuditLogs.ShouldBeEmpty();
                var vessel = new Privilege()
                {
                    Code = "A",
                    DescFre = "A",
                    DescEng = "A",
                    IsActive = true
                };
                db.Privileges.Add(vessel);
                db.SaveChanges();
            }

            using (var db = _dbHelper.GetDbContext())
            {
                db.AuditLogs.ShouldNotBeEmpty();
                var hasUser = await db.AuditLogs.Where(e => e.AuditUser != null).AnyAsync();
                _output.WriteLine("has user: " + hasUser);
                hasUser.ShouldBeTrue();
            }

        }

        private void SetupAuditing()
        {
            Configuration.AuditDisabled = false;
            Audit.Core.Configuration.Setup()
                .UseEntityFramework(_ => _
                    .AuditTypeMapper(t => typeof(CCG.AspNetCore.Data.Audit.AuditLog))
                    .AuditEntityAction<CCG.AspNetCore.Data.Audit.AuditLog>(async (ev, entry, entity) =>
                    {
                        _output.WriteLine("user: " + _httpContextAccessor.HttpContext.User.Identity.IsAuthenticated);
                        await new AddAuditLogCommandHandler(_httpContextAccessor).ExecuteAsync(new AddAuditLogCommand()
                        {
                            Entity = entity,
                            Entry = entry
                        });
                    })
                    .IgnoreMatchedProperties());
        }

        private async Task SetupNewUser()
        {
            using (var db = _dbHelper.GetDbContext())
            {
                db.Users.RemoveRange(db.Users);
                await db.Users.AddAsync(new User()
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
                await db.SaveChangesAsync();
            }
        }

    }
}
