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
           builder.ApplyConfigurationsFromAssembly(typeof(CctDbContext).Assembly);

           SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            builder.Entity<JobGroup>().HasData(
                          new JobGroup() { Id = 1, Code = "GT", NameEng = "General Technician", NameFre = "Technicien general" },
                          new JobGroup() { Id = 2, Code = "AS", NameEng = "Admin. Services", NameFre = "Services Admin" },
                          new JobGroup() { Id = 3, Code = "CS", NameEng = "Computer Science", NameFre = "Sciences informatiques" }
                          );

            builder.Entity<JobGroupLevel>().HasData(
                            new JobGroupLevel() { Id = 1, LevelValue = "01" },
                            new JobGroupLevel() { Id = 2, LevelValue = "02" },
                            new JobGroupLevel() { Id = 3, LevelValue = "03" }
                            );

            builder.Entity<JobPosition>().HasData(
                            new JobPosition() { Id = 1, TitleEng = "Manager", TitleFre = "Gestionnaire" },
                            new JobPosition() { Id = 2, TitleEng = "Technical Advisor", TitleFre = "Conseiller technique" },
                            new JobPosition() { Id = 3, TitleEng = "Business Architect", TitleFre = "Architecte d'affaires" },
                            new JobPosition() { Id = 4, TitleEng = "Project Officer", TitleFre = "Agent de projets" }
                           
                            );
            builder.Entity<JobKeyTaskPerLevel>().HasData(
                           new JobKeyTaskPerLevel() { Id = 1, DescEng = "It is a long established fact that a reader will be distracted", DescFre = "Lorem ipsum dolor sit amet, consectetur adipiscing elit" },
                           new JobKeyTaskPerLevel() { Id = 2, DescEng = "or avoids pleasure itself, because it is pleasure", DescFre = "Nemo enim ipsam voluptatem quia voluptas sit" },
                           new JobKeyTaskPerLevel() { Id = 3, DescEng = " but because occasionally circumstances occur in which toil and pain can procure", DescFre = "dolore magnam aliquam quaerat voluptatem." },
                           new JobKeyTaskPerLevel() { Id = 4, DescEng = "To take a trivial example", DescFre = "Nam libero tempore, cum soluta nobis est eligendi" }
                           );
            builder.Entity<JobCategory>().HasData(
                           new JobCategory() { Id = 1, ValueEng = "Seagoing", ValueFre = "En mer" },
                           new JobCategory() { Id = 2, ValueEng = "non-seagoing", ValueFre = "non maritime" }
                           );

            builder.Entity<JobRole>().HasData(
                            new JobRole() { JobGroupId = 1, JobGroupLevelId = 1 },
                            new JobRole() { JobGroupId = 2, JobGroupLevelId = 1},
                            new JobRole() { JobGroupId = 3, JobGroupLevelId = 3 },
                            new JobRole() { JobGroupId = 3, JobGroupLevelId = 2}
                            );
            builder.Entity<JobLocationRegion>().HasData(
                            new JobLocationRegion() { Id = 1, NameEng = "Atlantic", NameFre = "Quebec" },
                            new JobLocationRegion() { Id = 2, NameEng = "Western", NameFre = "Ouest" },
                            new JobLocationRegion() { Id = 3, NameEng = "Arctic", NameFre = "Artique" },
                            new JobLocationRegion() { Id = 4, NameEng = "National Headquarters", NameFre = "siège national" }
                            );

            builder.Entity<JobGroupPosition>().HasData(
                            new JobGroupPosition() { JobGroupId = 1, JobGroupLevelId = 1, JobPositionId = 2, JobLocationRegionId = 1, JobKeyTaskPerLevelId = 1, JobCategoryId = 1 },
                            new JobGroupPosition() { JobGroupId = 2, JobGroupLevelId = 2, JobPositionId = 2, JobLocationRegionId = 2, JobKeyTaskPerLevelId = 2, JobCategoryId = 1 },
                            new JobGroupPosition() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 2, JobLocationRegionId = 3, JobKeyTaskPerLevelId = 4, JobCategoryId = 2 },
                            new JobGroupPosition() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 2, JobLocationRegionId = 4, JobKeyTaskPerLevelId = 4, JobCategoryId = 2 }
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
