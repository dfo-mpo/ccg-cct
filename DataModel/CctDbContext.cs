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
        public DbSet<JobGroup> JobGroups { get; set; }
        public DbSet<SubJobGroup> SubJobGroups { get; set; }
        public DbSet<JobGroupLevel> JobGroupLevels { get; set; }
        public DbSet<JobRole> JobRoles { get; set; }
        public DbSet<JobPosition> JobPositions { get; set; }

        public DbSet<Competency> Competencies { get; set; }
        public DbSet<CompetencyTypeGroup> CompetencyTypeGroups { get; set; }
        public DbSet<CompetencyLevelRequirement> CompetencyLevelRequirements { get; set; }
        public DbSet<CompetencyRatingLevel> CompetencyRatingLevels { get; set; }
        public DbSet<CompetencyRatingGroup> CompetencyRatingGroups { get; set; }
        public DbSet<CompetencyType> CompetencyTypes { get; set; }
        public DbSet<JobHLCategory> JobHLCategories { get; set; }
        public DbSet<JobLocationRegion> JobLocationRegions { get; set; }

        public DbSet<JobGroupPosition> JobGroupPositions { get; set; }
        public DbSet<JobPositionCompetency> JobPositionCompetencies { get; set; }
        public DbSet<JobRolePositionCompetency> JobRolePositionCompetencies { get; set; }
        public DbSet<JobRolePositionCompetencyRating> JobRolePositionCompetencyRatings { get; set; }
        public DbSet<JobRolePositionLocation> JobRolePositionLocations { get; set; }
        public DbSet<JobRolePositionHLCategory> JobRolePositionHLCategories { get; set; }


        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<CertificateDescription> CertificateDescriptions { get; set; }
        public DbSet<JobRolePositionCertificate> JobRolePositionCertificates { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(CctDbContext).Assembly);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-81CBV0VK\\SQLEXPRESS;Database=CCT4;Trusted_Connection=True;");
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}