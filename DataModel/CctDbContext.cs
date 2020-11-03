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

            // configure one-many, many-one, many-many relationships Entity Framework Core
             SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            builder.Entity<JobGroup>().HasData(
              new JobGroup() { Id = 1, AcrEng = "GT", AcrFre="TG", NameEng= "General Technical", NameFre= "Technique générale" },
              new JobGroup() { Id = 2, AcrEng = "L", AcrFre = "GP", NameEng = "Lightkeepers", NameFre = "Les gardiens de phare" },
              new JobGroup() { Id = 3, AcrEng = "GS", AcrFre = "SG", NameEng = "General Services", NameFre = "Services généraux" },
              new JobGroup() { Id = 4, AcrEng = "CS", AcrFre = "SI", NameEng = "Computer Systems", NameFre = "Systèmes informatiques" },
              new JobGroup() { Id = 5, AcrEng = "ES", AcrFre = "ATS", NameEng = "Engineering and Scientific Support", NameFre = "Assistance technique et scientifique" },
              new JobGroup() { Id = 6, AcrEng = "PS", AcrFre = "AA", NameEng = "Purchasing and Supply", NameFre = "Achat et approvisionnement" },
              new JobGroup() { Id = 7, AcrEng = "GL", AcrFre = "TGM", NameEng = "General Labour and Trades", NameFre = "Travail général et métiers" },
              new JobGroup() { Id = 8, AcrEng = "SC", AcrFre = "EN", NameEng = "Ships' Crews", NameFre = "Équipages de navires" },
              new JobGroup() { Id = 9, AcrEng = "SO", AcrFre = "ON", NameEng = "Ships' Officers", NameFre = "Officiers de navire" }

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
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-81CBV0VK;Database=CCTData;Trusted_Connection=True;");
            optionsBuilder.EnableSensitiveDataLogging();
        }

    }
}
