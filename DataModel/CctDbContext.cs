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
        public DbSet<JobRolePositionCertificate> JobRolePositionCertificates { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {           
           builder.ApplyConfigurationsFromAssembly(typeof(CctDbContext).Assembly);

           SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            builder.Entity<JobGroup>().HasData(
                          new JobGroup() { Id = 1, Code = "AS", NameEng = "Admin. Services", NameFre = "Admin. Services" },
                          new JobGroup() { Id = 2, Code = "CS", NameEng = "Computer Sciences", NameFre = "Sciences Informatiques" },
                          new JobGroup() { Id = 3, Code = "SO-MAO", NameEng = "Ships' Officers", NameFre = "Officiers et officières de navire" }
                         
                          );

            builder.Entity<JobGroupLevel>().HasData(
                            new JobGroupLevel() { Id = 1, LevelValue = "01" },
                            new JobGroupLevel() { Id = 2, LevelValue = "02" },
                            new JobGroupLevel() { Id = 3, LevelValue = "03" },
                            new JobGroupLevel() { Id = 4, LevelValue = "04" },
                            new JobGroupLevel() { Id = 5, LevelValue = "05" },
                            new JobGroupLevel() { Id = 6, LevelValue = "06" }
                           
                            );

            builder.Entity<JobPosition>().HasData(
                            new JobPosition() { Id = 1, TitleEng = "Administrative assistant", TitleFre = "Adjointe administrative" },
                            new JobPosition() { Id = 2, TitleEng = "Manager", TitleFre = "Gestionnaire" },
                            new JobPosition() { Id = 3, TitleEng = "Technical Advisor", TitleFre = "Conseiller technique" },
                            new JobPosition() { Id = 4, TitleEng = "Business Architect", TitleFre = "Architecte d'affaires" },
                            new JobPosition() { Id = 5, TitleEng = "Project Officer", TitleFre = "Agent de projets" },
                            new JobPosition() { Id = 6, TitleEng = "Supervisor", TitleFre = "Superviseur" },
                            new JobPosition() { Id = 7, TitleEng = "Analyst", TitleFre = "Analyste" },
                            new JobPosition() { Id = 8, TitleEng = "Director", TitleFre = "Directeur" },
                            new JobPosition() { Id = 9, TitleEng = "Cook", TitleFre = "Cuisinier" },
                            new JobPosition() { Id = 10, TitleEng = " Supervisor: Search and Rescue", TitleFre = "Superviseur(se) : Recherche et sauvetage" },
                            new JobPosition() { Id = 11, TitleEng = " Marine officer", TitleFre = "Officier de marine" }
                            );
            
            builder.Entity<JobHLCategory>().HasData(
                           new JobHLCategory() { Id = 1, ValueEng = "Seagoing", ValueFre = "En mer" },
                           new JobHLCategory() { Id = 2, ValueEng = "Shoreside", ValueFre = "Sur terre" }
                           );

            builder.Entity<JobLocationRegion>().HasData(
                           new JobLocationRegion() { Id = 1, NameEng = "Atlantic", NameFre = "Atlantique" },
                           new JobLocationRegion() { Id = 2, NameEng = "Western", NameFre = "Ouest" },
                           new JobLocationRegion() { Id = 3, NameEng = "Arctic", NameFre = "Arctique" },
                           new JobLocationRegion() { Id = 4, NameEng = "National Headquarters", NameFre = "Siège national" },
                           new JobLocationRegion() { Id = 5, NameEng = "Central and Arctic", NameFre = "Centre et Arctique" },
                           new JobLocationRegion() { Id = 6, NameEng = "CCG College", NameFre = "Collège de la GCC" },
                           new JobLocationRegion() { Id = 7, NameEng = "All Regions", NameFre = "Toutes les régions" }
                           );

            builder.Entity<JobRole>().HasData(
                            new JobRole() { JobGroupId = 1, JobGroupLevelId = 1 },
                            new JobRole() { JobGroupId = 1, JobGroupLevelId = 2 },
                            new JobRole() { JobGroupId = 1, JobGroupLevelId = 3 },
                            new JobRole() { JobGroupId = 1, JobGroupLevelId = 4 },
                        
                            new JobRole() { JobGroupId = 2, JobGroupLevelId = 1 },
                            new JobRole() { JobGroupId = 2, JobGroupLevelId = 2 },
                            new JobRole() { JobGroupId = 2, JobGroupLevelId = 3 },
                            new JobRole() { JobGroupId = 2, JobGroupLevelId = 4 },
                           
                            new JobRole() { JobGroupId = 3, JobGroupLevelId = 1 },
                            new JobRole() { JobGroupId = 3, JobGroupLevelId = 2 },
                            new JobRole() { JobGroupId = 3, JobGroupLevelId = 3 },
                            new JobRole() { JobGroupId = 3, JobGroupLevelId = 4 }    
                           
                            );

            builder.Entity<JobGroupPosition>().HasData(
                            
                            new JobGroupPosition() { JobGroupId = 1, JobGroupLevelId = 2, JobPositionId = 1 },
                            new JobGroupPosition() { JobGroupId = 1, JobGroupLevelId = 5, JobPositionId = 2 },
                            new JobGroupPosition() { JobGroupId = 1, JobGroupLevelId = 3, JobPositionId = 5 },
                            new JobGroupPosition() { JobGroupId = 1, JobGroupLevelId = 4, JobPositionId = 6 },
                            new JobGroupPosition() { JobGroupId = 2, JobGroupLevelId = 3, JobPositionId = 3 },
                            new JobGroupPosition() { JobGroupId = 2, JobGroupLevelId = 2, JobPositionId = 4 },
                            new JobGroupPosition() { JobGroupId = 2, JobGroupLevelId = 4, JobPositionId = 7 },
                            new JobGroupPosition() { JobGroupId = 2, JobGroupLevelId = 5, JobPositionId = 8 },
                            new JobGroupPosition() { JobGroupId = 3, JobGroupLevelId = 1, JobPositionId = 9 },
                            new JobGroupPosition() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 10 },
                            new JobGroupPosition() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 11 }
                            );

            builder.Entity<Competency>().HasData(
                           new Competency() { Id = 1, NameEng = "Organizational Knowledge", NameFre = "Connaissances organisationnelles", DescEng = "lorem ipus", DescFre = "lorem ipus" },
                           new Competency() { Id = 2, NameEng = "Materiel and Supply Chain Management", NameFre = "Matériel et chaîne d'approvisionnement Gestion", DescEng = "lorem ipus", DescFre = "lorem ipus" },
                           new Competency() { Id = 3, NameEng = "Planning and Prioritizing", NameFre = "Planification et établissement des priorités", DescEng = "lorem ipus", DescFre = "lorem ipus" },
                           new Competency() { Id = 4, NameEng = "Life-Cycle Asset Management", NameFre = "Gestion du cycle de vie des actifs", DescEng = "lorem ipus", DescFre = "lorem ipus" },
                           new Competency() { Id = 5, NameEng = "Inventory Management Systems", NameFre = "Gestion du cycle de vie des actifs", DescEng = "lorem ipus", DescFre = "lorem ipus" },
                           new Competency() { Id = 6, NameEng = "Control and procurement", NameFre = "Controlle et approvisionnement", DescEng = "lorem ipus", DescFre = "lorem ipus" }
                           );

            builder.Entity<CompetencyRatingLevel>().HasData(
                            new CompetencyRatingLevel() { Id = 1, Value = 1, NameEng = "Fundamental Awareness", NameFre = "activité fondamentale de sensibilisation", DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFra" },
                            new CompetencyRatingLevel() { Id = 2, Value = 2, NameEng = "Novice", NameFre = "Niveau debutant(e)", DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFra" },
                            new CompetencyRatingLevel() { Id = 3, Value = 3, NameEng = "Intermediate", NameFre = "Niveau intermediaire", DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFra" },
                            new CompetencyRatingLevel() { Id = 4, Value = 4, NameEng = "Advanced", NameFre = "Niveau avancé", DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFre" },
                            new CompetencyRatingLevel() { Id = 5, Value = 5, NameEng = "Expert", NameFre = "Niveau expert", DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFre" }
                            );

            builder.Entity<CompetencyType>().HasData(
                           new CompetencyType() { Id = 1, NameEng = "Knowledge Elements", NameFre = "Éléments de connaissance" },
                           new CompetencyType() { Id = 2, NameEng = "Technical Elements", NameFre = "Éléments techniques" },
                           new CompetencyType() { Id = 3, NameEng = "Behavioural Elements", NameFre = "Éléments comportementaux" }
                           );

            builder.Entity<Certificate>().HasData(
                          (new Certificate()
                          {
                              Id = 1,
                              NameEng = "Master 1500 GT",
                              NameFre = "Master 1500 GT",
                              DescEng = "lorem ipsum",
                              DescFre = "lorem ipsum",
                              RequireIndicatorEng = "lorem ipsum",
                              RequireIndicatorFre = "lorem ipsum",
                          }),

                          (new Certificate()
                          {
                              Id = 2,
                              NameEng = "Master 1600A GT",
                              NameFre = "Master 1600A GT",
                              DescEng = "lorem ipsum",
                              DescFre = "lorem ipsum",
                              RequireIndicatorEng = "lorem ipsum",
                              RequireIndicatorFre = "lorem ipsum",
                          }),

                           (new Certificate()
                           {
                               Id = 3,
                               NameEng = "Z Alpha MDX",
                               NameFre = "Z Alpha MDX",
                               DescEng = "lorem ipsum",
                               DescFre = "lorem ipsum",
                               RequireIndicatorEng = "lorem ipsum",
                               RequireIndicatorFre = "lorem ipsum",
                           }),

                           (new Certificate()
                           {
                               Id = 4,
                               NameEng = "V Delta MKZ",
                               NameFre = "V Delta MKZ",
                               DescEng = "lorem ipsum",
                               DescFre = "lorem ipsum",
                               RequireIndicatorEng = "lorem ipsum",
                               RequireIndicatorFre = "lorem ipsum",
                           }),

                           (new Certificate()
                           {
                               Id = 5,
                               NameEng = "six Sigma",
                               NameFre = "six Sigma",
                               DescEng = "lorem ipsum",
                               DescFre = "lorem ipsum",
                               RequireIndicatorEng = "lorem ipsum",
                               RequireIndicatorFre = "lorem ipsum",
                           }),

                           (new Certificate()
                           {
                               Id = 6,
                               NameEng = "Gamma v9",
                               NameFre = "Gamma v9",
                               DescEng = "lorem ipsum",
                               DescFre = "lorem ipsum",
                               RequireIndicatorEng = "lorem ipsum",
                               RequireIndicatorFre = "lorem ipsum",
                           })
                           );


            builder.Entity<CompetencyTypeGroup>().HasData(
                           new CompetencyTypeGroup() { CompetencyId = 1, CompetencyTypeId = 1 },
                           new CompetencyTypeGroup() { CompetencyId = 2, CompetencyTypeId = 1 },
                           new CompetencyTypeGroup() { CompetencyId = 3, CompetencyTypeId = 2 },
                           new CompetencyTypeGroup() { CompetencyId = 4, CompetencyTypeId = 2 },
                           new CompetencyTypeGroup() { CompetencyId = 5, CompetencyTypeId = 3 },
                           new CompetencyTypeGroup() { CompetencyId = 6, CompetencyTypeId = 3 }

                           );

            builder.Entity<CompetencyLevelRequirement>().HasData(
                              new CompetencyLevelRequirement() { Id = 1, DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFre" },
                              new CompetencyLevelRequirement() { Id = 2, DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFre" },
                              new CompetencyLevelRequirement() { Id = 3, DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFre" },
                              new CompetencyLevelRequirement() { Id = 4, DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFre" },
                              new CompetencyLevelRequirement() { Id = 5, DescEng = "Lorem ipsumEng", DescFre = "Lorem ipsumFre" }
                              );

            builder.Entity<CompetencyRatingGroup>().HasData(
                           new CompetencyRatingGroup() { CompetencyId = 1, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 1 },
                           new CompetencyRatingGroup() { CompetencyId = 1, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 2 },
                           new CompetencyRatingGroup() { CompetencyId = 1, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                           new CompetencyRatingGroup() { CompetencyId = 1, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 4 },
                           new CompetencyRatingGroup() { CompetencyId = 1, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 5 },
                           new CompetencyRatingGroup() { CompetencyId = 2, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 6 },
                           new CompetencyRatingGroup() { CompetencyId = 2, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 7 },
                           new CompetencyRatingGroup() { CompetencyId = 2, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 8 },
                           new CompetencyRatingGroup() { CompetencyId = 2, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 9 },
                           new CompetencyRatingGroup() { CompetencyId = 2, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 10 },
                           new CompetencyRatingGroup() { CompetencyId = 3, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 12 },
                           new CompetencyRatingGroup() { CompetencyId = 3, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 13 },
                           new CompetencyRatingGroup() { CompetencyId = 3, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 14 },
                           new CompetencyRatingGroup() { CompetencyId = 3, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 15 },
                           new CompetencyRatingGroup() { CompetencyId = 3, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 16 },
                           new CompetencyRatingGroup() { CompetencyId = 4, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 17 },
                           new CompetencyRatingGroup() { CompetencyId = 4, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 18 },
                           new CompetencyRatingGroup() { CompetencyId = 4, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 19 },
                           new CompetencyRatingGroup() { CompetencyId = 4, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 20 },
                           new CompetencyRatingGroup() { CompetencyId = 4, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 21 },
                           new CompetencyRatingGroup() { CompetencyId = 5, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 22 },
                           new CompetencyRatingGroup() { CompetencyId = 5, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 23 },
                           new CompetencyRatingGroup() { CompetencyId = 5, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 24 },
                           new CompetencyRatingGroup() { CompetencyId = 5, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 25 },
                           new CompetencyRatingGroup() { CompetencyId = 5, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 26 },
                           new CompetencyRatingGroup() { CompetencyId = 6, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 27 },
                           new CompetencyRatingGroup() { CompetencyId = 6, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 28 },
                           new CompetencyRatingGroup() { CompetencyId = 6, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 29 },
                           new CompetencyRatingGroup() { CompetencyId = 6, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 30 },
                           new CompetencyRatingGroup() { CompetencyId = 6, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 31 },
                           new CompetencyRatingGroup() { CompetencyId = 7, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 32 },
                           new CompetencyRatingGroup() { CompetencyId = 7, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 33 },
                           new CompetencyRatingGroup() { CompetencyId = 7, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 34 },
                           new CompetencyRatingGroup() { CompetencyId = 7, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 35 },
                           new CompetencyRatingGroup() { CompetencyId = 7, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 36 },
                           new CompetencyRatingGroup() { CompetencyId = 8, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 37 },
                           new CompetencyRatingGroup() { CompetencyId = 8, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 38 },
                           new CompetencyRatingGroup() { CompetencyId = 8, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 39 },
                           new CompetencyRatingGroup() { CompetencyId = 8, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 40 },
                           new CompetencyRatingGroup() { CompetencyId = 8, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 41 },
                           new CompetencyRatingGroup() { CompetencyId = 9, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 42 },
                           new CompetencyRatingGroup() { CompetencyId = 9, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 43 },
                           new CompetencyRatingGroup() { CompetencyId = 9, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 44 },
                           new CompetencyRatingGroup() { CompetencyId = 9, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 45 },
                           new CompetencyRatingGroup() { CompetencyId = 9, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 46 },
                           new CompetencyRatingGroup() { CompetencyId = 10, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 47 },
                           new CompetencyRatingGroup() { CompetencyId = 10, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 48 },
                           new CompetencyRatingGroup() { CompetencyId = 10, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 49 },
                           new CompetencyRatingGroup() { CompetencyId = 10, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 50 },
                           new CompetencyRatingGroup() { CompetencyId = 10, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 51 },
                           new CompetencyRatingGroup() { CompetencyId = 11, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 52 },
                           new CompetencyRatingGroup() { CompetencyId = 11, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 53 },
                           new CompetencyRatingGroup() { CompetencyId = 11, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 54 },
                           new CompetencyRatingGroup() { CompetencyId = 11, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 55 },
                           new CompetencyRatingGroup() { CompetencyId = 11, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 56 },
                           new CompetencyRatingGroup() { CompetencyId = 12, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 57 },
                           new CompetencyRatingGroup() { CompetencyId = 12, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 58 },
                           new CompetencyRatingGroup() { CompetencyId = 12, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 59 },
                           new CompetencyRatingGroup() { CompetencyId = 12, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 60 },
                           new CompetencyRatingGroup() { CompetencyId = 12, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 61 },
                           new CompetencyRatingGroup() { CompetencyId = 13, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 62 },
                           new CompetencyRatingGroup() { CompetencyId = 13, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 63 },
                           new CompetencyRatingGroup() { CompetencyId = 13, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 64 },
                           new CompetencyRatingGroup() { CompetencyId = 13, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 65 },
                           new CompetencyRatingGroup() { CompetencyId = 13, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 66 },
                           new CompetencyRatingGroup() { CompetencyId = 14, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 67 },
                           new CompetencyRatingGroup() { CompetencyId = 14, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 68 },
                           new CompetencyRatingGroup() { CompetencyId = 14, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 69 },
                           new CompetencyRatingGroup() { CompetencyId = 14, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 70 },
                           new CompetencyRatingGroup() { CompetencyId = 14, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 71 },
                           new CompetencyRatingGroup() { CompetencyId = 15, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 72 },
                           new CompetencyRatingGroup() { CompetencyId = 15, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 73 },
                           new CompetencyRatingGroup() { CompetencyId = 15, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 74 },
                           new CompetencyRatingGroup() { CompetencyId = 15, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 75 },
                           new CompetencyRatingGroup() { CompetencyId = 15, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 76 },
                           new CompetencyRatingGroup() { CompetencyId = 16, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 77 },
                           new CompetencyRatingGroup() { CompetencyId = 16, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 78 },
                           new CompetencyRatingGroup() { CompetencyId = 16, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 79 },
                           new CompetencyRatingGroup() { CompetencyId = 16, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 80 },
                           new CompetencyRatingGroup() { CompetencyId = 16, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 81 },
                           new CompetencyRatingGroup() { CompetencyId = 17, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 82 },
                           new CompetencyRatingGroup() { CompetencyId = 17, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 83 },
                           new CompetencyRatingGroup() { CompetencyId = 17, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 84 },
                           new CompetencyRatingGroup() { CompetencyId = 17, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 85 },
                           new CompetencyRatingGroup() { CompetencyId = 17, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 86 },
                           new CompetencyRatingGroup() { CompetencyId = 18, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 87 },
                           new CompetencyRatingGroup() { CompetencyId = 18, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 88 },
                           new CompetencyRatingGroup() { CompetencyId = 18, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 89 },
                           new CompetencyRatingGroup() { CompetencyId = 18, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 90 },
                           new CompetencyRatingGroup() { CompetencyId = 18, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 91 },
                           new CompetencyRatingGroup() { CompetencyId = 19, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 92 },
                           new CompetencyRatingGroup() { CompetencyId = 19, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 93 },
                           new CompetencyRatingGroup() { CompetencyId = 19, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 94 },
                           new CompetencyRatingGroup() { CompetencyId = 19, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 95 },
                           new CompetencyRatingGroup() { CompetencyId = 19, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 96 },
                           new CompetencyRatingGroup() { CompetencyId = 20, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 97 },
                           new CompetencyRatingGroup() { CompetencyId = 20, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 98 },
                           new CompetencyRatingGroup() { CompetencyId = 20, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 99 },
                           new CompetencyRatingGroup() { CompetencyId = 20, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 100 },
                           new CompetencyRatingGroup() { CompetencyId = 20, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 101 },
                           new CompetencyRatingGroup() { CompetencyId = 21, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 102 },
                           new CompetencyRatingGroup() { CompetencyId = 21, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 103 },
                           new CompetencyRatingGroup() { CompetencyId = 21, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 104 },
                           new CompetencyRatingGroup() { CompetencyId = 21, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 105 },
                           new CompetencyRatingGroup() { CompetencyId = 21, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 106 },
                           new CompetencyRatingGroup() { CompetencyId = 22, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 107 },
                           new CompetencyRatingGroup() { CompetencyId = 22, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 108 },
                           new CompetencyRatingGroup() { CompetencyId = 22, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 109 },
                           new CompetencyRatingGroup() { CompetencyId = 22, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 110 },
                           new CompetencyRatingGroup() { CompetencyId = 22, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 111 },
                           new CompetencyRatingGroup() { CompetencyId = 23, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 112 },
                           new CompetencyRatingGroup() { CompetencyId = 23, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 113 },
                           new CompetencyRatingGroup() { CompetencyId = 23, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 114 },
                           new CompetencyRatingGroup() { CompetencyId = 23, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 115 },
                           new CompetencyRatingGroup() { CompetencyId = 23, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 116 },
                           new CompetencyRatingGroup() { CompetencyId = 24, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 117 },
                           new CompetencyRatingGroup() { CompetencyId = 24, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 118 },
                           new CompetencyRatingGroup() { CompetencyId = 24, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 119 },
                           new CompetencyRatingGroup() { CompetencyId = 24, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 120 },
                           new CompetencyRatingGroup() { CompetencyId = 24, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 121 },
                           new CompetencyRatingGroup() { CompetencyId = 25, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 122 },
                           new CompetencyRatingGroup() { CompetencyId = 25, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 123 },
                           new CompetencyRatingGroup() { CompetencyId = 25, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 124 },
                           new CompetencyRatingGroup() { CompetencyId = 25, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 125 },
                           new CompetencyRatingGroup() { CompetencyId = 25, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 126 },
                           new CompetencyRatingGroup() { CompetencyId = 26, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 127 },
                           new CompetencyRatingGroup() { CompetencyId = 26, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 128 },
                           new CompetencyRatingGroup() { CompetencyId = 26, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 129 },
                           new CompetencyRatingGroup() { CompetencyId = 26, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 130 },
                           new CompetencyRatingGroup() { CompetencyId = 26, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 131 },
                           new CompetencyRatingGroup() { CompetencyId = 27, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 132 },
                           new CompetencyRatingGroup() { CompetencyId = 27, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 133 },
                           new CompetencyRatingGroup() { CompetencyId = 27, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 134 },
                           new CompetencyRatingGroup() { CompetencyId = 27, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 135 },
                           new CompetencyRatingGroup() { CompetencyId = 27, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 136 },
                           new CompetencyRatingGroup() { CompetencyId = 28, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 137 },
                           new CompetencyRatingGroup() { CompetencyId = 28, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 138 },
                           new CompetencyRatingGroup() { CompetencyId = 28, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 139 },
                           new CompetencyRatingGroup() { CompetencyId = 28, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 140 },
                           new CompetencyRatingGroup() { CompetencyId = 28, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 141 },
                           new CompetencyRatingGroup() { CompetencyId = 33, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 142 },
                           new CompetencyRatingGroup() { CompetencyId = 33, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 143 },
                           new CompetencyRatingGroup() { CompetencyId = 33, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 144 },
                           new CompetencyRatingGroup() { CompetencyId = 33, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 145 },
                           new CompetencyRatingGroup() { CompetencyId = 33, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 146 },
                           new CompetencyRatingGroup() { CompetencyId = 34, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 147 },
                           new CompetencyRatingGroup() { CompetencyId = 34, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 148 },
                           new CompetencyRatingGroup() { CompetencyId = 34, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 149 },
                           new CompetencyRatingGroup() { CompetencyId = 34, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 150 },
                           new CompetencyRatingGroup() { CompetencyId = 34, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 151 },
                           new CompetencyRatingGroup() { CompetencyId = 36, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 152 },
                           new CompetencyRatingGroup() { CompetencyId = 36, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 153 },
                           new CompetencyRatingGroup() { CompetencyId = 36, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 154 },
                           new CompetencyRatingGroup() { CompetencyId = 36, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 155 },
                           new CompetencyRatingGroup() { CompetencyId = 36, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 156 },
                           new CompetencyRatingGroup() { CompetencyId = 37, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 157 },
                           new CompetencyRatingGroup() { CompetencyId = 37, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 158 },
                           new CompetencyRatingGroup() { CompetencyId = 37, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 159 },
                           new CompetencyRatingGroup() { CompetencyId = 37, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 160 },
                           new CompetencyRatingGroup() { CompetencyId = 37, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 161 }
                           );


            builder.Entity<JobPositionCompetency>().HasData(

                           new JobPositionCompetency() { JobPositionId = 1, CompetencyId = 1, CompetencyTypeId = 1},
                           new JobPositionCompetency() { JobPositionId = 1, CompetencyId = 2, CompetencyTypeId = 1 },
                           new JobPositionCompetency() { JobPositionId = 5, CompetencyId = 1, CompetencyTypeId = 1 },
                           new JobPositionCompetency() { JobPositionId = 5, CompetencyId = 2, CompetencyTypeId = 1 },
                           new JobPositionCompetency() { JobPositionId = 5, CompetencyId = 3, CompetencyTypeId = 2 },
                           new JobPositionCompetency() { JobPositionId = 2, CompetencyId = 1, CompetencyTypeId = 1 },
                           new JobPositionCompetency() { JobPositionId = 2, CompetencyId = 2, CompetencyTypeId = 1 },
                           new JobPositionCompetency() { JobPositionId = 2, CompetencyId = 3, CompetencyTypeId = 2 },
                           new JobPositionCompetency() { JobPositionId = 2, CompetencyId = 4, CompetencyTypeId = 3 },
                           new JobPositionCompetency() { JobPositionId = 6, CompetencyId = 1, CompetencyTypeId = 1 },
                           new JobPositionCompetency() { JobPositionId = 6, CompetencyId = 2, CompetencyTypeId = 2 },
                           new JobPositionCompetency() { JobPositionId = 6, CompetencyId = 3, CompetencyTypeId = 2 },
                           new JobPositionCompetency() { JobPositionId = 6, CompetencyId = 4, CompetencyTypeId = 3 },
                           new JobPositionCompetency() { JobPositionId = 6, CompetencyId = 5, CompetencyTypeId = 3 },
                           new JobPositionCompetency() { JobPositionId = 3, CompetencyId = 1, CompetencyTypeId = 1 },
                           new JobPositionCompetency() { JobPositionId = 3, CompetencyId = 2, CompetencyTypeId = 1 },
                           new JobPositionCompetency() { JobPositionId = 3, CompetencyId = 3, CompetencyTypeId = 2 },
                           new JobPositionCompetency() { JobPositionId = 3, CompetencyId = 4, CompetencyTypeId = 2 },
                           new JobPositionCompetency() { JobPositionId = 3, CompetencyId = 5, CompetencyTypeId = 3 },
                           new JobPositionCompetency() { JobPositionId = 4, CompetencyId = 1, CompetencyTypeId = 1 },
                           new JobPositionCompetency() { JobPositionId = 4, CompetencyId = 2, CompetencyTypeId = 1 },
                           new JobPositionCompetency() { JobPositionId = 4, CompetencyId = 3, CompetencyTypeId = 2 },
                           new JobPositionCompetency() { JobPositionId = 4, CompetencyId = 4, CompetencyTypeId = 2 },
                           new JobPositionCompetency() { JobPositionId = 4, CompetencyId = 5, CompetencyTypeId = 3 },
                           new JobPositionCompetency() { JobPositionId = 7, CompetencyId = 1, CompetencyTypeId = 1 },
                           new JobPositionCompetency() { JobPositionId = 7, CompetencyId = 2, CompetencyTypeId = 1 },
                           new JobPositionCompetency() { JobPositionId = 7, CompetencyId = 3, CompetencyTypeId = 2 },
                           new JobPositionCompetency() { JobPositionId = 7, CompetencyId = 4, CompetencyTypeId = 2 },
                           new JobPositionCompetency() { JobPositionId = 7, CompetencyId = 5, CompetencyTypeId = 3 },
                           new JobPositionCompetency() { JobPositionId = 7, CompetencyId = 6, CompetencyTypeId = 3 },
                           new JobPositionCompetency() { JobPositionId = 8, CompetencyId = 1, CompetencyTypeId = 1 },
                           new JobPositionCompetency() { JobPositionId = 8, CompetencyId = 2, CompetencyTypeId = 1 },
                           new JobPositionCompetency() { JobPositionId = 8, CompetencyId = 3, CompetencyTypeId = 2 },
                           new JobPositionCompetency() { JobPositionId = 8, CompetencyId = 4, CompetencyTypeId = 2 },
                           new JobPositionCompetency() { JobPositionId = 8, CompetencyId = 5, CompetencyTypeId = 3 },
                           new JobPositionCompetency() { JobPositionId = 8, CompetencyId = 6, CompetencyTypeId = 3 },
                           new JobPositionCompetency() { JobPositionId = 9, CompetencyId = 1, CompetencyTypeId = 1 },
                           new JobPositionCompetency() { JobPositionId = 9, CompetencyId = 2, CompetencyTypeId = 2 },
                           new JobPositionCompetency() { JobPositionId = 9, CompetencyId = 3, CompetencyTypeId = 2 },                          
                           new JobPositionCompetency() { JobPositionId = 11, CompetencyId = 1, CompetencyTypeId = 1 },
                           new JobPositionCompetency() { JobPositionId = 11, CompetencyId = 2, CompetencyTypeId = 2 },
                           new JobPositionCompetency() { JobPositionId = 11, CompetencyId = 3, CompetencyTypeId = 2 },
                           new JobPositionCompetency() { JobPositionId = 11, CompetencyId = 4, CompetencyTypeId = 3 },
                           new JobPositionCompetency() { JobPositionId = 10, CompetencyId = 1, CompetencyTypeId = 1 },
                           new JobPositionCompetency() { JobPositionId = 10, CompetencyId = 2, CompetencyTypeId = 2 },
                           new JobPositionCompetency() { JobPositionId = 10, CompetencyId = 3, CompetencyTypeId = 2 },
                           new JobPositionCompetency() { JobPositionId = 10, CompetencyId = 4, CompetencyTypeId = 3 }
                           );

            

            builder.Entity<JobRolePositionCompetency>().HasData(

                           new JobRolePositionCompetency() { JobGroupId = 1, JobGroupLevelId = 2, JobPositionId = 1, CompetencyId = 1, CompetencyTypeId = 1 },
                           new JobRolePositionCompetency() { JobGroupId = 1, JobGroupLevelId = 2, JobPositionId = 1, CompetencyId = 2, CompetencyTypeId = 1 },

                           new JobRolePositionCompetency() { JobGroupId = 1, JobGroupLevelId = 3, JobPositionId = 5, CompetencyId = 1, CompetencyTypeId = 1 },
                           new JobRolePositionCompetency() { JobGroupId = 1, JobGroupLevelId = 3, JobPositionId = 5, CompetencyId = 2, CompetencyTypeId = 1 },
                           new JobRolePositionCompetency() { JobGroupId = 1, JobGroupLevelId = 3, JobPositionId = 5, CompetencyId = 3, CompetencyTypeId = 2 },

                           new JobRolePositionCompetency() { JobGroupId = 1, JobGroupLevelId = 5, JobPositionId = 2, CompetencyId = 1, CompetencyTypeId = 1 },
                           new JobRolePositionCompetency() { JobGroupId = 1, JobGroupLevelId = 5, JobPositionId = 2, CompetencyId = 2, CompetencyTypeId = 1 },
                           new JobRolePositionCompetency() { JobGroupId = 1, JobGroupLevelId = 5, JobPositionId = 2, CompetencyId = 3, CompetencyTypeId = 2 },
                           new JobRolePositionCompetency() { JobGroupId = 1, JobGroupLevelId = 5, JobPositionId = 2, CompetencyId = 4, CompetencyTypeId = 3 },

                           new JobRolePositionCompetency() { JobGroupId = 1, JobGroupLevelId = 4, JobPositionId = 6, CompetencyId = 1, CompetencyTypeId = 1 },
                           new JobRolePositionCompetency() { JobGroupId = 1, JobGroupLevelId = 4, JobPositionId = 6, CompetencyId = 2, CompetencyTypeId = 2 },
                           new JobRolePositionCompetency() { JobGroupId = 1, JobGroupLevelId = 4, JobPositionId = 6, CompetencyId = 3, CompetencyTypeId = 2 },
                           new JobRolePositionCompetency() { JobGroupId = 1, JobGroupLevelId = 4, JobPositionId = 6, CompetencyId = 4, CompetencyTypeId = 3 },
                           new JobRolePositionCompetency() { JobGroupId = 1, JobGroupLevelId = 4, JobPositionId = 6, CompetencyId = 5, CompetencyTypeId = 3 },

                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 3, JobPositionId = 3, CompetencyId = 1, CompetencyTypeId = 1 },
                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 3, JobPositionId = 3, CompetencyId = 2, CompetencyTypeId = 1 },
                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 3, JobPositionId = 3, CompetencyId = 3, CompetencyTypeId = 2 },
                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 3, JobPositionId = 3, CompetencyId = 4, CompetencyTypeId = 2 },
                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 3, JobPositionId = 3, CompetencyId = 5, CompetencyTypeId = 3 },

                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 2, JobPositionId = 4, CompetencyId = 1, CompetencyTypeId = 1 },
                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 2, JobPositionId = 4, CompetencyId = 2, CompetencyTypeId = 1 },
                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 2, JobPositionId = 4, CompetencyId = 3, CompetencyTypeId = 2 },
                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 2, JobPositionId = 4, CompetencyId = 4, CompetencyTypeId = 2 },
                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 2, JobPositionId = 4, CompetencyId = 5, CompetencyTypeId = 3 },


                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 4, JobPositionId = 7, CompetencyId = 1, CompetencyTypeId = 1 },
                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 4, JobPositionId = 7, CompetencyId = 2, CompetencyTypeId = 1 },
                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 4, JobPositionId = 7, CompetencyId = 3, CompetencyTypeId = 2 },
                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 4, JobPositionId = 7, CompetencyId = 4, CompetencyTypeId = 2 },
                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 4, JobPositionId = 7, CompetencyId = 5, CompetencyTypeId = 3 },
                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 4, JobPositionId = 7, CompetencyId = 6, CompetencyTypeId = 3 },


                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 5, JobPositionId = 8, CompetencyId = 1, CompetencyTypeId = 1 },
                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 5, JobPositionId = 8, CompetencyId = 2, CompetencyTypeId = 1 },
                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 5, JobPositionId = 8, CompetencyId = 3, CompetencyTypeId = 2 },
                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 5, JobPositionId = 8, CompetencyId = 4, CompetencyTypeId = 2 },
                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 5, JobPositionId = 8, CompetencyId = 5, CompetencyTypeId = 3 },
                           new JobRolePositionCompetency() { JobGroupId = 2, JobGroupLevelId = 5, JobPositionId = 8, CompetencyId = 6, CompetencyTypeId = 3 },

                           new JobRolePositionCompetency() { JobGroupId = 3, JobGroupLevelId = 1, JobPositionId = 9, CompetencyId = 1, CompetencyTypeId = 1 },
                           new JobRolePositionCompetency() { JobGroupId = 3, JobGroupLevelId = 1, JobPositionId = 9, CompetencyId = 2, CompetencyTypeId = 2 },
                           new JobRolePositionCompetency() { JobGroupId = 3, JobGroupLevelId = 1, JobPositionId = 9, CompetencyId = 3, CompetencyTypeId = 2 },

                           new JobRolePositionCompetency() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 10, CompetencyId = 1, CompetencyTypeId = 1 },
                           new JobRolePositionCompetency() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 10, CompetencyId = 2, CompetencyTypeId = 2 },
                           new JobRolePositionCompetency() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 10, CompetencyId = 3, CompetencyTypeId = 2 },
                           new JobRolePositionCompetency() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 10, CompetencyId = 4, CompetencyTypeId = 3 },

                           new JobRolePositionCompetency() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 11, CompetencyId = 1, CompetencyTypeId = 1 },
                           new JobRolePositionCompetency() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 11, CompetencyId = 2, CompetencyTypeId = 2 },
                           new JobRolePositionCompetency() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 11, CompetencyId = 3, CompetencyTypeId = 2 },
                           new JobRolePositionCompetency() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 11, CompetencyId = 4, CompetencyTypeId = 3 }
                           );

            builder.Entity<JobRolePositionCertificate>().HasData(
                            new JobRolePositionCertificate() { JobGroupId = 1, JobGroupLevelId = 3, JobPositionId = 5, CertificateId = 1 }
                            );

            builder.Entity<JobRolePositionCompetencyRating>().HasData(

                            new JobRolePositionCompetencyRating() { JobGroupId = 1, JobGroupLevelId = 2, JobPositionId = 1, CompetencyId = 1, CompetencyTypeId = 1, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 1 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 1, JobGroupLevelId = 2, JobPositionId = 1, CompetencyId = 2, CompetencyTypeId = 1, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 2 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 1, JobGroupLevelId = 3, JobPositionId = 5, CompetencyId = 1, CompetencyTypeId = 1, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 2 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 1, JobGroupLevelId = 3, JobPositionId = 5, CompetencyId = 2, CompetencyTypeId = 1, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 1, JobGroupLevelId = 3, JobPositionId = 5, CompetencyId = 3, CompetencyTypeId = 2, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 2 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 1, JobGroupLevelId = 5, JobPositionId = 2, CompetencyId = 1, CompetencyTypeId = 1, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 1, JobGroupLevelId = 5, JobPositionId = 2, CompetencyId = 2, CompetencyTypeId = 1, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 1, JobGroupLevelId = 5, JobPositionId = 2, CompetencyId = 3, CompetencyTypeId = 2, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 1, JobGroupLevelId = 5, JobPositionId = 2, CompetencyId = 4, CompetencyTypeId = 3, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 2 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 1, JobGroupLevelId = 4, JobPositionId = 6, CompetencyId = 1, CompetencyTypeId = 1, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 4 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 1, JobGroupLevelId = 4, JobPositionId = 6, CompetencyId = 2, CompetencyTypeId = 1, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 1, JobGroupLevelId = 4, JobPositionId = 6, CompetencyId = 3, CompetencyTypeId = 2, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 1, JobGroupLevelId = 4, JobPositionId = 6, CompetencyId = 4, CompetencyTypeId = 3, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 1, JobGroupLevelId = 4, JobPositionId = 6, CompetencyId = 5, CompetencyTypeId = 3, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 5 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 3, JobPositionId = 3, CompetencyId = 1, CompetencyTypeId = 1, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 3, JobPositionId = 3, CompetencyId = 2, CompetencyTypeId = 1, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 2 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 3, JobPositionId = 3, CompetencyId = 3, CompetencyTypeId = 2, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 3, JobPositionId = 3, CompetencyId = 4, CompetencyTypeId = 3, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 2 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 3, JobPositionId = 3, CompetencyId = 5, CompetencyTypeId = 3, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 1 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 2, JobPositionId = 4, CompetencyId = 1, CompetencyTypeId = 1, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 2, JobPositionId = 4, CompetencyId = 2, CompetencyTypeId = 1, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 2, JobPositionId = 4, CompetencyId = 3, CompetencyTypeId = 2, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 2, JobPositionId = 4, CompetencyId = 4, CompetencyTypeId = 2, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 2, JobPositionId = 4, CompetencyId = 5, CompetencyTypeId = 3, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 2 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 4, JobPositionId = 7, CompetencyId = 1, CompetencyTypeId = 1, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 4 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 4, JobPositionId = 7, CompetencyId = 2, CompetencyTypeId = 1, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 4 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 4, JobPositionId = 7, CompetencyId = 3, CompetencyTypeId = 2, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 4, JobPositionId = 7, CompetencyId = 4, CompetencyTypeId = 2, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 4 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 4, JobPositionId = 7, CompetencyId = 5, CompetencyTypeId = 3, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 4, JobPositionId = 7, CompetencyId = 6, CompetencyTypeId = 3, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 2 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 5, JobPositionId = 8, CompetencyId = 1, CompetencyTypeId = 1, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 5 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 5, JobPositionId = 8, CompetencyId = 2, CompetencyTypeId = 1, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 5 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 5, JobPositionId = 8, CompetencyId = 3, CompetencyTypeId = 2, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 4 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 5, JobPositionId = 8, CompetencyId = 4, CompetencyTypeId = 2, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 5, JobPositionId = 8, CompetencyId = 5, CompetencyTypeId = 3, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 4 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 2, JobGroupLevelId = 5, JobPositionId = 8, CompetencyId = 6, CompetencyTypeId = 3, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 4 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 3, JobGroupLevelId = 1, JobPositionId = 9, CompetencyId = 1, CompetencyTypeId = 1, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 1 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 3, JobGroupLevelId = 1, JobPositionId = 9, CompetencyId = 2, CompetencyTypeId = 2, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 2 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 3, JobGroupLevelId = 1, JobPositionId = 9, CompetencyId = 3, CompetencyTypeId = 2, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 1 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 11, CompetencyId = 1, CompetencyTypeId = 1, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 2 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 11, CompetencyId = 2, CompetencyTypeId = 2, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 11, CompetencyId = 3, CompetencyTypeId = 2, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 2 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 11, CompetencyId = 4, CompetencyTypeId = 3, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 2 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 10, CompetencyId = 1, CompetencyTypeId = 1, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 2 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 10, CompetencyId = 2, CompetencyTypeId = 2, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 10, CompetencyId = 3, CompetencyTypeId = 2, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3 },
                            new JobRolePositionCompetencyRating() { JobGroupId = 3, JobGroupLevelId = 3, JobPositionId = 10, CompetencyId = 4, CompetencyTypeId = 3, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 4 }
                           );

            builder.Entity<JobRolePositionLocation>().HasData(
                            new JobRolePositionLocation() { JobGroupId = 2, JobGroupLevelId = 1, JobPositionId = 1, JobLocationRegionId = 1 }
                            );

            builder.Entity<JobRolePositionHLCategory>().HasData(
                            new JobRolePositionHLCategory() { JobGroupId = 2, JobGroupLevelId = 1, JobPositionId = 1, JobHLCategoryId = 2 }
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
