using DataModel.Configurations;
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
		
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Competency> Competencys { get; set; }
        public DbSet<CompetencyGroupsRating> CompetencyGroupsRatings { get; set; }
        public DbSet<CompetencyGroupsType> CompetencyGroupsTypes { get; set; }
        public DbSet<CompetencyLevelRequirement> CompetencyLevelRequirements { get; set; }
        public DbSet<CompetencyRatingLevel> CompetencyRatingLevels { get; set; }
        public DbSet<CompetencyType> CompetencyTypes { get; set; }
        public DbSet<JobCategory> JobCategorys { get; set; }
        public DbSet<JobGroup> JobGroups { get; set; }
        public DbSet<JobGroupLevel> JobGroupLevels { get; set; }
        public DbSet<JobPosition> JobPositions { get; set; }
        public DbSet<JobKeyTaskPerLevel> JobKeyTaskPerLevels { get; set; }
        public DbSet<JobLocationRegion> JobLocationRegions { get; set; }
        public DbSet<JobGroupPosition> JobGroupPositions { get; set; }
        public DbSet<JobPositionCompetency> JobPositionCompetencys { get; set; }
        public DbSet<JobRole> JobRoles { get; set; }
        public DbSet<JobRolesPositionCompetency> JobRolesPositionCompetencys { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CompetencyGroupsRatingConfiguration());
            builder.ApplyConfiguration(new CompetencyGroupsTypeConfiguration());
            builder.ApplyConfiguration(new JobGroupPositionConfiguration());
            builder.ApplyConfiguration(new JobPositionCompetencyConfiguration());
            builder.ApplyConfiguration(new JobRoleConfiguration());
            builder.ApplyConfiguration(new JobRolesPositionCompetencyConfiguration());
           
            builder.ApplyConfigurationsFromAssembly(typeof(CctDbContext).Assembly);

           SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            builder.Entity<JobGroup>().HasData(
                          new JobGroup() { Id = 1, ClassificationName = "GT" },
                          new JobGroup() { Id = 2, ClassificationName = "PG" },
                          new JobGroup() { Id = 3, ClassificationName = "SO-MAO" }
                          );

            builder.Entity<JobGroupLevel>().HasData(
                            new JobGroupLevel() { Id = 1, ClassificationLevel = "01" },
                            new JobGroupLevel() { Id = 2, ClassificationLevel = "02" },
                            new JobGroupLevel() { Id = 3, ClassificationLevel = "03" }
                            );

            builder.Entity<JobPosition>().HasData(
                            new JobPosition() { Id = 1, PositionNameEng = "Manager", PositionNameFre = "Gestionnaire" },
                            new JobPosition() { Id = 2, PositionNameEng = "Technical Advisor", PositionNameFre = "Conseiller technique" },
                            new JobPosition() { Id = 3, PositionNameEng = "Business Architect", PositionNameFre = "Architecte d'affaires" },
                            new JobPosition() { Id = 4, PositionNameEng = "Project Officer", PositionNameFre = "Agent de projets" },
                            new JobPosition() { Id = 5, PositionNameEng = "Project Manager", PositionNameFre = "Gestionnaire de projets" }
                            ); 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CCT;Trusted_Connection=True;");
            optionsBuilder.EnableSensitiveDataLogging();
        }

    }
}
