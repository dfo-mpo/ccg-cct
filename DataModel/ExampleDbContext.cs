using DataModel.CodeTables;
using Audit.EntityFramework;
using CCG.AspNetCore.Data;
using CCG.AspNetCore.Data.Audit;
using CCG.AspNetCore.Data.Auth.Model;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using DataModel.Tracking;
using System.Linq;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DataModel
{
    public class ExampleDbContext : AuditDbContext, IAuthDbContext
    {
        private IHttpContextAccessor ReferenceHttpContextAccessor { get; set; }        
        public ExampleDbContext(DbContextOptions<ExampleDbContext> options, IHttpContextAccessor provider) : base(options)
        {
            ReferenceHttpContextAccessor = provider;
        }


        // code tables
        public DbSet<Status> Statuses { get; set; }

        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<EventLog> EventLogs { get; set; }
        // auth
        public virtual DbSet<Privilege> Privileges { get; set; }
        public virtual DbSet<SystemRolePrivilege> SystemRolePrivileges { get; set; }
        public virtual DbSet<SystemRole> SystemRoles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserClaim> UserClaims { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.AddAuthConfiguration();
            builder.ApplyConfigurationsFromAssembly(typeof(ExampleDbContext).Assembly);
            SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            //auth
            builder.Entity<Privilege>().HasData(Lookup.Auth.Privileges);
            builder.Entity<SystemRole>().HasData(Lookup.Auth.SystemRoles);
            builder.Entity<SystemRolePrivilege>().HasData(Lookup.Auth.SystemRolePrivileges);
            //codes
            builder.Entity<Status>().HasData(Lookup.CodeTables.Statuses);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CcgApiTemplate;Trusted_Connection=True;");
            //optionsBuilder.UseSqlite("Data Source=app.db");
            optionsBuilder.EnableSensitiveDataLogging();
        }
        private void SetTracking(EntityEntry entry)
        {
            if (!(entry.Entity is ITrackingEntity entity)) return;
            var LastUpdateEntityStatesList = new List<EntityState>() { EntityState.Modified, EntityState.Added };
            if (entry.Entity is ITrackEntityOnUnchanged)
            {
                LastUpdateEntityStatesList.Add(EntityState.Unchanged);
            }
            var userNameIdentifier = ReferenceHttpContextAccessor?.HttpContext?.User?.Claims?.FirstOrDefault(x => x.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", StringComparison.InvariantCultureIgnoreCase))?.Value;
            var user = Users.FirstOrDefault(x => x.NameIdentifier == userNameIdentifier);

            if (entry.State == EntityState.Added && entity.CreatedBy == null && entity.CreatedDate == DateTime.MinValue)
            {
                entity.CreatedDate = DateTime.UtcNow;
                entity.CreatedBy = user;
            }

            if (LastUpdateEntityStatesList.Contains(entry.State))
            {
                entity.LastModifiedDate = DateTime.UtcNow;
                entity.LastModifiedBy = user;
            }
        }
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            OnBeforeSaving();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            OnBeforeSaving();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void OnBeforeSaving()
        {
            var entries = ChangeTracker.Entries().ToList();
            entries.ForEach(Entry => {
                SetTracking(Entry);
            });
        }
    }
}
