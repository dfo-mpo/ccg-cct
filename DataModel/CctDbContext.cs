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
        public DbSet<Competency> Competencies { get; set; }
        public DbSet<CompetencyRatingGroup> CompetencyRatingGroups { get; set; }
        public DbSet<CompetencyTypeGroup> CompetencyTypeGroups { get; set; }
        public DbSet<CompetencyLevelRequirement> CompetencyLevelRequirements { get; set; }
        public DbSet<CompetencyRatingLevel> CompetencyRatingLevels { get; set; }
        public DbSet<CompetencyType> CompetencyTypes { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<JobGroup> JobGroups { get; set; }
        public DbSet<JobGroupLevel> JobGroupLevels { get; set; }
        public DbSet<JobPosition> JobPositions { get; set; }
        public DbSet<JobKeyTaskPerLevel> JobKeyTaskPerLevels { get; set; }
        public DbSet<JobLocationRegion> JobLocationRegions { get; set; }
        public DbSet<JobGroupPosition> JobGroupPositions { get; set; }
        public DbSet<JobPositionCompetency> JobPositionCompetencies { get; set; }
        public DbSet<JobRole> JobRoles { get; set; }
        public DbSet<JobRolePositionCompetency> JobRolesPositionCompetencies { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CertificateConfiguration());
            builder.ApplyConfiguration(new CompetencyConfiguration());
            builder.ApplyConfiguration(new CompetencyLevelRequirementConfiguration());
            builder.ApplyConfiguration(new CompetencyRatingGroupConfiguration());
            builder.ApplyConfiguration(new CompetencyRatingLevelConfiguration());
            builder.ApplyConfiguration(new CompetencyTypeConfiguration());
            builder.ApplyConfiguration(new CompetencyTypeGroupConfiguration());
            builder.ApplyConfiguration(new JobCategoryConfiguration());
            builder.ApplyConfiguration(new JobGroupConfiguration());
            builder.ApplyConfiguration(new JobGroupLevelConfiguration());
            builder.ApplyConfiguration(new JobGroupPositionConfiguration());
            builder.ApplyConfiguration(new JobKeyTaskPerLevelConfiguration());
            builder.ApplyConfiguration(new JobLocationRegionConfiguration());
            builder.ApplyConfiguration(new JobPositionCompetencyConfiguration());
            builder.ApplyConfiguration(new JobPositionConfiguration());
            builder.ApplyConfiguration(new JobRoleConfiguration());
            builder.ApplyConfiguration(new JobRolePositionCompetencyConfiguration());
           
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
                            new JobGroupLevel() { Id = 1, Value = "01" },
                            new JobGroupLevel() { Id = 2, Value = "02" },
                            new JobGroupLevel() { Id = 3, Value = "03" }
                            );

            builder.Entity<JobPosition>().HasData(
                            new JobPosition() { Id = 1, TitleEng = "Manager", TitleFre = "Gestionnaire" },
                            new JobPosition() { Id = 2, TitleEng = "Technical Advisor", TitleFre = "Conseiller technique" },
                            new JobPosition() { Id = 3, TitleEng = "Business Architect", TitleFre = "Architecte d'affaires" },
                            new JobPosition() { Id = 4, TitleEng = "Project Officer", TitleFre = "Agent de projets" },
                            new JobPosition() { Id = 5, TitleEng = "Project Manager", TitleFre = "Gestionnaire de projets" }
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
