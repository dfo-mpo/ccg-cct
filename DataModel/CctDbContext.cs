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
        public DbSet<JobRolePositionCompetency> JobRolePositionCompetencies { get; set; }


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
                           new JobKeyTaskPerLevel() { Id = 1, DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFra" },
                           new JobKeyTaskPerLevel() { Id = 2, DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFra" },
                           new JobKeyTaskPerLevel() { Id = 3, DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFra" },
                           new JobKeyTaskPerLevel() { Id = 4, DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFra" }
                           );
            builder.Entity<JobCategory>().HasData(
                           new JobCategory() { Id = 1, ValueEng = "Seagoing", ValueFre = "En mer" },
                           new JobCategory() { Id = 2, ValueEng = "non-seagoing", ValueFre = "sur terre" }
                           );

            builder.Entity<JobRole>().HasData(
                            new JobRole() { JobGroupId = 1, JobGroupLevelId = 1 },
                            new JobRole() { JobGroupId = 2, JobGroupLevelId = 1 },
                            new JobRole() { JobGroupId = 3, JobGroupLevelId = 3 },
                            new JobRole() { JobGroupId = 3, JobGroupLevelId = 2 }
                            );
            builder.Entity<JobLocationRegion>().HasData(
                            new JobLocationRegion() { Id = 1, NameEng = "Atlantic", NameFre = "Quebec" },
                            new JobLocationRegion() { Id = 2, NameEng = "Western", NameFre = "Ouest" },
                            new JobLocationRegion() { Id = 3, NameEng = "Arctic", NameFre = "Artique" },
                            new JobLocationRegion() { Id = 4, NameEng = "National Headquarters", NameFre = "siège national" }
                            );

            builder.Entity<JobGroupPosition>().HasData(
                            new JobGroupPosition() { JobGroupId = 1, JobGroupLevelId = 1, JobPositionId = 1, JobLocationRegionId = 1, JobKeyTaskPerLevelId = 1, JobCategoryId = 1 },
                            new JobGroupPosition() { JobGroupId = 2, JobGroupLevelId = 2, JobPositionId = 2, JobLocationRegionId = 2, JobKeyTaskPerLevelId = 2, JobCategoryId = 1 },
                            new JobGroupPosition() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 3, JobLocationRegionId = 3, JobKeyTaskPerLevelId = 4, JobCategoryId = 2 },
                            new JobGroupPosition() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 4, JobLocationRegionId = 4, JobKeyTaskPerLevelId = 4, JobCategoryId = 2 }
                            );

            builder.Entity<CompetencyRatingLevel>().HasData(
                            new CompetencyRatingLevel() { Id = 1, Value = 1, NameEng = "Fundamental Awareness", NameFre = "activité fondamentale de sensibilisation", DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFra" },
                            new CompetencyRatingLevel() { Id = 2, Value = 2, NameEng = "Novice", NameFre = "Niveau debutant(e)", DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFra" },
                            new CompetencyRatingLevel() { Id = 3, Value = 3, NameEng = "Intermediate", NameFre = "Niveau intermediaire", DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFra" },
                            new CompetencyRatingLevel() { Id = 4, Value = 4, NameEng = "Advanced", NameFre = "Niveau avancé", DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFre" },
                            new CompetencyRatingLevel() { Id = 5, Value = 5, NameEng = "Expert", NameFre = "Niveau expert", DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFre" }
                            );

            builder.Entity<Competency>().HasData(
                           new Competency() { Id = 1, NameEng = "Organizational Knowledge", NameFre = "Connaissances organisationnelles", DescEng = "lorem ipus", DescFre = "lorem ipus" },
                           new Competency() { Id = 2, NameEng = "Materiel and Supply Chain Management", NameFre = "Matériel et chaîne d'approvisionnement Gestion", DescEng = "lorem ipus", DescFre = "lorem ipus" },
                           new Competency() { Id = 3, NameEng = "Planning and Prioritizing", NameFre = "Planification et établissement des priorités", DescEng = "lorem ipus", DescFre = "lorem ipus" },
                           new Competency() { Id = 4, NameEng = "Life-Cycle Asset Management", NameFre = "Gestion du cycle de vie des actifs", DescEng = "lorem ipus", DescFre = "lorem ipus" },
                           new Competency() { Id = 5, NameEng = "Inventory Management Systems", NameFre = "Gestion du cycle de vie des actifs", DescEng = "lorem ipus", DescFre = "lorem ipus" },
                           new Competency() { Id = 6, NameEng = "Master 1505 GT", NameFre = "Master 1505 GT", DescEng = "lorem ipus", DescFre = "lorem ipus" },
                           new Competency() { Id = 7, NameEng = "Master 1500 GT", NameFre = "Master 1500 GT", DescEng = "lorem ipus", DescFre = "lorem ipus" }

                           );

            builder.Entity<CompetencyType>().HasData(
                           new CompetencyType() { Id = 1, NameEng = "Knowledge Elements", NameFre = "Éléments de connaissance" },
                           new CompetencyType() { Id = 2, NameEng = "Technical Elements", NameFre = "Éléments techniques" },
                           new CompetencyType() { Id = 3, NameEng = "Behavioural Elements", NameFre = "Éléments comportementaux" },
                           new CompetencyType() { Id = 4, NameEng = "Certificates", NameFre = "Certificats" }
                           );

            builder.Entity<Certificate>().HasData(
                          (new Certificate()
                          {
                              Id = 1,
                              CompetencyId = 6,
                              RequireIndicatorEng = "lorem ipsum",
                              RequireIndicatorFre = "lorem ipsum",
                          }),

                          (new Certificate()
                          {
                              Id = 2,
                              CompetencyId = 7,
                              RequireIndicatorEng = "lorem ipsum",
                              RequireIndicatorFre = "lorem ipsum",
                          })
                           ) ;


            builder.Entity<CompetencyTypeGroup>().HasData(
                           new CompetencyTypeGroup() { CompetencyId = 1, CompetencyTypeId = 1 },
                           new CompetencyTypeGroup() { CompetencyId = 2, CompetencyTypeId = 2 },
                           new CompetencyTypeGroup() { CompetencyId = 3, CompetencyTypeId = 2 },
                           new CompetencyTypeGroup() { CompetencyId = 4, CompetencyTypeId = 3 },
                           new CompetencyTypeGroup() { CompetencyId = 5, CompetencyTypeId = 3 },
                           new CompetencyTypeGroup() { CompetencyId = 6, CompetencyTypeId = 4 },
                           new CompetencyTypeGroup() { CompetencyId = 7, CompetencyTypeId = 4 }
                           );

            builder.Entity<JobPositionCompetency>().HasData(
                           new JobPositionCompetency() { JobPositionId = 1, CompetencyId = 1 },
                           new JobPositionCompetency() { JobPositionId = 1, CompetencyId = 2 },
                           new JobPositionCompetency() { JobPositionId = 1, CompetencyId = 3 },
                           new JobPositionCompetency() { JobPositionId = 1, CompetencyId = 6 },
                           new JobPositionCompetency() { JobPositionId = 2, CompetencyId = 4 },
                           new JobPositionCompetency() { JobPositionId = 2, CompetencyId = 5 },
                           new JobPositionCompetency() { JobPositionId = 3, CompetencyId = 7 },
                           new JobPositionCompetency() { JobPositionId = 3, CompetencyId = 4 },
                           new JobPositionCompetency() { JobPositionId = 4, CompetencyId = 5 },
                           new JobPositionCompetency() { JobPositionId = 4, CompetencyId = 7 }

                           );

            builder.Entity<JobRolePositionCompetency>().HasData(
                           new JobRolePositionCompetency() { JobGroupId = 1, JobGroupLevelId = 1, JobPositionId = 1, CompetencyId = 1 },
                           new JobRolePositionCompetency() { JobGroupId = 1, JobGroupLevelId = 1, JobPositionId = 1, CompetencyId = 2 },
                           new JobRolePositionCompetency() { JobGroupId = 1, JobGroupLevelId = 1, JobPositionId = 1, CompetencyId = 3 },
                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 3, JobPositionId = 1, CompetencyId = 6 },
                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 3, JobPositionId = 2, CompetencyId = 4 },
                           new JobRolePositionCompetency() { JobGroupId = 3, JobGroupLevelId = 2, JobPositionId = 2, CompetencyId = 5 },
                           new JobRolePositionCompetency() { JobGroupId = 3, JobGroupLevelId = 2, JobPositionId = 3, CompetencyId = 7 },
                           new JobRolePositionCompetency() { JobGroupId = 3, JobGroupLevelId = 2, JobPositionId = 3, CompetencyId = 4 },
                           new JobRolePositionCompetency() { JobGroupId = 3, JobGroupLevelId = 2, JobPositionId = 4, CompetencyId = 5 },
                           new JobRolePositionCompetency() { JobGroupId = 3, JobGroupLevelId = 2, JobPositionId = 4, CompetencyId = 7 }
                           );

            builder.Entity<CompetencyRatingGroup>().HasData(
                           new CompetencyRatingGroup() { CompetencyId = 1, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 1 },
                           new CompetencyRatingGroup() { CompetencyId = 1, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 2 },
                           new CompetencyRatingGroup() { CompetencyId = 1, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                           new CompetencyRatingGroup() { CompetencyId = 1, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 4 },
                           new CompetencyRatingGroup() { CompetencyId = 1, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 5 },
                           new CompetencyRatingGroup() { CompetencyId = 2, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 1 },
                           new CompetencyRatingGroup() { CompetencyId = 2, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 2 },
                           new CompetencyRatingGroup() { CompetencyId = 2, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                           new CompetencyRatingGroup() { CompetencyId = 2, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 4 },
                           new CompetencyRatingGroup() { CompetencyId = 2, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 5 },
                           new CompetencyRatingGroup() { CompetencyId = 3, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 1 },
                           new CompetencyRatingGroup() { CompetencyId = 3, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 2 },
                           new CompetencyRatingGroup() { CompetencyId = 3, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                           new CompetencyRatingGroup() { CompetencyId = 3, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 4 },
                           new CompetencyRatingGroup() { CompetencyId = 3, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 5 },
                           new CompetencyRatingGroup() { CompetencyId = 4, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 1 },
                           new CompetencyRatingGroup() { CompetencyId = 4, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 2 },
                           new CompetencyRatingGroup() { CompetencyId = 4, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                           new CompetencyRatingGroup() { CompetencyId = 4, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 4 },
                           new CompetencyRatingGroup() { CompetencyId = 4, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 5 },
                           new CompetencyRatingGroup() { CompetencyId = 5, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 1 },
                           new CompetencyRatingGroup() { CompetencyId = 5, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 2 },
                           new CompetencyRatingGroup() { CompetencyId = 5, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                           new CompetencyRatingGroup() { CompetencyId = 5, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 4 },
                           new CompetencyRatingGroup() { CompetencyId = 5, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 5 }
                           );

            builder.Entity<CompetencyLevelRequirement>().HasData(
                              new CompetencyLevelRequirement() { Id = 1, DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFre" },
                              new CompetencyLevelRequirement() { Id = 2, DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFre" },
                              new CompetencyLevelRequirement() { Id = 3, DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFre" },
                              new CompetencyLevelRequirement() { Id = 4, DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFre" },
                              new CompetencyLevelRequirement() { Id = 5, DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFre" }
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
