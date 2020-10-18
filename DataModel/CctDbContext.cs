using DataModel.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DataModel
{
    public class CctDbContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

                public CctDbContext(DbContextOptions<CctDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
            AzureAccessTokenService.AddAccessToken(Database.GetDbConnection() as SqlConnection);
        }
        public DbSet<Certificate> Certificate { get; set; }
        public DbSet<Competency> Competency { get; set; }
        public DbSet<CompetencyGroupsRatings> CompetencyGroupsRatings { get; set; }
        public DbSet<CompetencyGroupsTypes> CompetencyGroupsTypes { get; set; }
        public DbSet<CompetencyLevelRequirements> CompetencyLevelRequirements { get; set; }
        public DbSet<CompetencyRatingLevel> CompetencyRatingLevel { get; set; }
        public DbSet<CompetencyType> CompetencyType { get; set; }
        public DbSet<JobCategory> JobCategory { get; set; }
        public DbSet<JobGroup> JobGroup { get; set; }
        public DbSet<JobGroupLevel> JobGroupLevel { get; set; }
        public DbSet<JobPosition> JobGroupPosition { get; set; }
        public DbSet<JobKeyTaskPerLevel> JobKeyTaskPerLevel { get; set; }
        public DbSet<JobLocationRegion> JobLocationRegion { get; set; }
        public DbSet<JobGroupPosition> JobPosition { get; set; }
        public DbSet<JobPositionCompetency> JobPositionCompetency { get; set; }
        public DbSet<JobRoles> JobRoles { get; set; }
        public DbSet<JobRolesPositionCompetency> JobRolesPositionCompetency { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(CctDbContext).Assembly);

            // configure one-many, many-one, many-many relationships Entity Framework Core
            builder.Entity<CompetencyGroupsRatings>().HasKey(cgr => new { cgr.CompetencyId, cgr.CompetencyRatingLevelId, cgr.CompetencyLevelRequirementsId });
            builder.Entity<CompetencyGroupsTypes>().HasKey(cgt => new { cgt.CompetencyId, cgt.CompetencyTypeid });
            builder.Entity<JobGroupPosition>().HasKey(jp => new { jp.JobGroupId, jp.JobGroupLevelId, jp.JobCategoryId, jp.JobPositionId, jp.JobKeyTaskPerLevelId, jp.JobLocationRegionId });
            builder.Entity<JobPositionCompetency>().HasKey(jpc => new { jpc.JobPositionId, jpc.CompetencyId });
            builder.Entity<JobRoles>().HasKey(jr => new { jr.JobGroupId, jr.JobGroupLevelId });
            builder.Entity<JobRolesPositionCompetency>().HasKey(jgrpc => new { jgrpc.JobGroupId, jgrpc.JobGroupLevelId, jgrpc.JobPositionId, jgrpc.CompetencyId });
        }

        private void SeedData(ModelBuilder builder)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CCT;Trusted_Connection=True;");
            optionsBuilder.EnableSensitiveDataLogging();
        }

    }
}
