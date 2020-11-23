using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace DataModel.Migrations
{
    public partial class addalltables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NameEng = table.Column<string>(maxLength: 500, nullable: true),
                    NameFre = table.Column<string>(maxLength: 500, nullable: true),
                    DescEng = table.Column<string>(maxLength: 500, nullable: true),
                    DescFre = table.Column<string>(maxLength: 500, nullable: true),
                    RequireIndicatorEng = table.Column<string>(maxLength: 500, nullable: true),
                    RequireIndicatorFre = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Competencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NameEng = table.Column<string>(maxLength: 250, nullable: false),
                    NameFre = table.Column<string>(maxLength: 250, nullable: false),
                    DescEng = table.Column<string>(maxLength: 250, nullable: false),
                    DescFre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyLevelRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DescEng = table.Column<string>(maxLength: 250, nullable: true),
                    DescFre = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyLevelRequirements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyRatingLevels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<int>(nullable: false),
                    NameEng = table.Column<string>(maxLength: 250, nullable: false),
                    NameFre = table.Column<string>(maxLength: 250, nullable: false),
                    DescEng = table.Column<string>(maxLength: 250, nullable: true),
                    DescFre = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyRatingLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NameEng = table.Column<string>(maxLength: 250, nullable: false),
                    NameFre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ValueEng = table.Column<string>(maxLength: 250, nullable: false),
                    ValueFre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobGroupLevels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    LevelValue = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobGroupLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CodeEng = table.Column<string>(maxLength: 250, nullable: false),
                    CodeFre = table.Column<string>(maxLength: 250, nullable: false),
                    NameEng = table.Column<string>(maxLength: 250, nullable: false),
                    NameFre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobKeyTaskPerLevels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DescEng = table.Column<string>(maxLength: 250, nullable: true),
                    DescFre = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobKeyTaskPerLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobLocationRegions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NameEng = table.Column<string>(maxLength: 250, nullable: false),
                    NameFre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobLocationRegions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobPositions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TitleEng = table.Column<string>(maxLength: 250, nullable: false),
                    TitleFre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyTypeGroups",
                columns: table => new
                {
                    CompetencyId = table.Column<int>(nullable: false),
                    CompetencyTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyTypeGroups", x => new { x.CompetencyId, x.CompetencyTypeId });
                    table.ForeignKey(
                        name: "FK_CompetencyTypeGroups_Competencies_CompetencyId",
                        column: x => x.CompetencyId,
                        principalTable: "Competencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetencyTypeGroups_CompetencyTypes_CompetencyTypeId",
                        column: x => x.CompetencyTypeId,
                        principalTable: "CompetencyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobRoles",
                columns: table => new
                {
                    JobGroupId = table.Column<int>(nullable: false),
                    JobGroupLevelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRoles", x => new { x.JobGroupId, x.JobGroupLevelId });
                    table.ForeignKey(
                        name: "FK_JobRoles_JobGroups_JobGroupId",
                        column: x => x.JobGroupId,
                        principalTable: "JobGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRoles_JobGroupLevels_JobGroupLevelId",
                        column: x => x.JobGroupLevelId,
                        principalTable: "JobGroupLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobGroupPositions",
                columns: table => new
                {
                    JobGroupId = table.Column<int>(nullable: false),
                    JobGroupLevelId = table.Column<int>(nullable: false),
                    JobPositionId = table.Column<int>(nullable: false),
                    JobLocationRegionId = table.Column<int>(nullable: false),
                    JobKeyTaskPerLevelId = table.Column<int>(nullable: false),
                    JobCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobGroupPositions", x => new { x.JobGroupId, x.JobGroupLevelId, x.JobPositionId });
                    table.ForeignKey(
                        name: "FK_JobGroupPositions_JobCategories_JobCategoryId",
                        column: x => x.JobCategoryId,
                        principalTable: "JobCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobGroupPositions_JobGroups_JobGroupId",
                        column: x => x.JobGroupId,
                        principalTable: "JobGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobGroupPositions_JobGroupLevels_JobGroupLevelId",
                        column: x => x.JobGroupLevelId,
                        principalTable: "JobGroupLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobGroupPositions_JobKeyTaskPerLevels_JobKeyTaskPerLevelId",
                        column: x => x.JobKeyTaskPerLevelId,
                        principalTable: "JobKeyTaskPerLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobGroupPositions_JobLocationRegions_JobLocationRegionId",
                        column: x => x.JobLocationRegionId,
                        principalTable: "JobLocationRegions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobGroupPositions_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobPositionCertificates",
                columns: table => new
                {
                    JobPositionId = table.Column<int>(nullable: false),
                    CertificateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPositionCertificates", x => new { x.JobPositionId, x.CertificateId });
                    table.ForeignKey(
                        name: "FK_JobPositionCertificates_Certificates_CertificateId",
                        column: x => x.CertificateId,
                        principalTable: "Certificates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPositionCertificates_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobPositionCompetencies",
                columns: table => new
                {
                    JobPositionId = table.Column<int>(nullable: false),
                    CompetencyId = table.Column<int>(nullable: false),
                    CompetencyTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPositionCompetencies", x => new { x.JobPositionId, x.CompetencyId });
                    table.ForeignKey(
                        name: "FK_JobPositionCompetencies_Competencies_CompetencyId",
                        column: x => x.CompetencyId,
                        principalTable: "Competencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPositionCompetencies_CompetencyTypes_CompetencyTypeId",
                        column: x => x.CompetencyTypeId,
                        principalTable: "CompetencyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPositionCompetencies_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobRolePositionCertificates",
                columns: table => new
                {
                    JobGroupId = table.Column<int>(nullable: false),
                    JobGroupLevelId = table.Column<int>(nullable: false),
                    JobPositionId = table.Column<int>(nullable: false),
                    CertificateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRolePositionCertificates", x => new { x.JobGroupId, x.JobGroupLevelId, x.JobPositionId, x.CertificateId });
                    table.ForeignKey(
                        name: "FK_JobRolePositionCertificates_Certificates_CertificateId",
                        column: x => x.CertificateId,
                        principalTable: "Certificates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCertificates_JobGroups_JobGroupId",
                        column: x => x.JobGroupId,
                        principalTable: "JobGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCertificates_JobGroupLevels_JobGroupLevelId",
                        column: x => x.JobGroupLevelId,
                        principalTable: "JobGroupLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCertificates_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobRolePositionCompetencies",
                columns: table => new
                {
                    JobGroupId = table.Column<int>(nullable: false),
                    JobGroupLevelId = table.Column<int>(nullable: false),
                    JobPositionId = table.Column<int>(nullable: false),
                    CompetencyId = table.Column<int>(nullable: false),
                    CompetencyTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRolePositionCompetencies", x => new { x.JobGroupId, x.JobGroupLevelId, x.JobPositionId, x.CompetencyId, x.CompetencyTypeId });
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencies_Competencies_CompetencyId",
                        column: x => x.CompetencyId,
                        principalTable: "Competencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencies_CompetencyTypes_CompetencyTypeId",
                        column: x => x.CompetencyTypeId,
                        principalTable: "CompetencyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencies_JobGroups_JobGroupId",
                        column: x => x.JobGroupId,
                        principalTable: "JobGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencies_JobGroupLevels_JobGroupLevelId",
                        column: x => x.JobGroupLevelId,
                        principalTable: "JobGroupLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencies_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobRolePositionCompetencyRatings",
                columns: table => new
                {
                    JobGroupId = table.Column<int>(nullable: false),
                    JobGroupLevelId = table.Column<int>(nullable: false),
                    JobPositionId = table.Column<int>(nullable: false),
                    CompetencyId = table.Column<int>(nullable: false),
                    CompetencyTypeId = table.Column<int>(nullable: false),
                    CompetencyRatingLevelId = table.Column<int>(nullable: false),
                    CompetencyLevelReqId = table.Column<int>(nullable: false),
                    CompetencyLevelRequirementId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRolePositionCompetencyRatings", x => new { x.JobGroupId, x.JobGroupLevelId, x.JobPositionId, x.CompetencyId, x.CompetencyTypeId });
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencyRatings_Competencies_CompetencyId",
                        column: x => x.CompetencyId,
                        principalTable: "Competencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencyRatings_CompetencyLevelRequirements~",
                        column: x => x.CompetencyLevelRequirementId,
                        principalTable: "CompetencyLevelRequirements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencyRatings_CompetencyRatingLevels_Comp~",
                        column: x => x.CompetencyRatingLevelId,
                        principalTable: "CompetencyRatingLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencyRatings_CompetencyTypes_CompetencyT~",
                        column: x => x.CompetencyTypeId,
                        principalTable: "CompetencyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencyRatings_JobGroups_JobGroupId",
                        column: x => x.JobGroupId,
                        principalTable: "JobGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencyRatings_JobGroupLevels_JobGroupLeve~",
                        column: x => x.JobGroupLevelId,
                        principalTable: "JobGroupLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencyRatings_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "DescEng", "DescFre", "NameEng", "NameFre", "RequireIndicatorEng", "RequireIndicatorFre" },
                values: new object[,]
                {
                    { 1, "lorem ipsum", "lorem ipsum", "Master 1500 GT", "Master 1500 GT", "lorem ipsum", "lorem ipsum" },
                    { 2, "lorem ipsum", "lorem ipsum", "Master 1600A GT", "Master 1600A GT", "lorem ipsum", "lorem ipsum" },
                    { 3, "lorem ipsum", "lorem ipsum", "Z Alpha MDX", "Z Alpha MDX", "lorem ipsum", "lorem ipsum" },
                    { 4, "lorem ipsum", "lorem ipsum", "V Delta MKZ", "V Delta MKZ", "lorem ipsum", "lorem ipsum" },
                    { 5, "lorem ipsum", "lorem ipsum", "six Sigma", "six Sigma", "lorem ipsum", "lorem ipsum" },
                    { 6, "lorem ipsum", "lorem ipsum", "Gamma v9", "Gamma v9", "lorem ipsum", "lorem ipsum" }
                });

            migrationBuilder.InsertData(
                table: "Competencies",
                columns: new[] { "Id", "DescEng", "DescFre", "NameEng", "NameFre" },
                values: new object[,]
                {
                    { 1, "lorem ipus", "lorem ipus", "Organizational Knowledge", "Connaissances organisationnelles" },
                    { 2, "lorem ipus", "lorem ipus", "Materiel and Supply Chain Management", "Matériel et chaîne d'approvisionnement Gestion" },
                    { 3, "lorem ipus", "lorem ipus", "Planning and Prioritizing", "Planification et établissement des priorités" },
                    { 4, "lorem ipus", "lorem ipus", "Life-Cycle Asset Management", "Gestion du cycle de vie des actifs" },
                    { 5, "lorem ipus", "lorem ipus", "Inventory Management Systems", "Gestion du cycle de vie des actifs" },
                    { 6, "lorem ipus", "lorem ipus", "Control and procurement", "Controlle et approvisionnement" }
                });

            migrationBuilder.InsertData(
                table: "CompetencyLevelRequirements",
                columns: new[] { "Id", "DescEng", "DescFre" },
                values: new object[,]
                {
                    { 5, "Lorem ipsumEng", "Lorem ipsumFre" },
                    { 4, "Lorem ipsumEng", "Lorem ipsumFre" },
                    { 1, "Lorem ipsumEng", "Lorem ipsumFre" },
                    { 2, "Lorem ipsumEng", "Lorem ipsumFre" },
                    { 3, "Lorem ipsumEng", "Lorem ipsumFre" }
                });

            migrationBuilder.InsertData(
                table: "CompetencyRatingLevels",
                columns: new[] { "Id", "DescEng", "DescFre", "NameEng", "NameFre", "Value" },
                values: new object[,]
                {
                    { 1, "Lorem ipsumEng", "Lorem ipsumFra", "Fundamental Awareness", "activité fondamentale de sensibilisation", 1 },
                    { 2, "Lorem ipsumEng", "Lorem ipsumFra", "Novice", "Niveau debutant(e)", 2 },
                    { 3, "Lorem ipsumEng", "Lorem ipsumFra", "Intermediate", "Niveau intermediaire", 3 },
                    { 4, "Lorem ipsumEng", "Lorem ipsumFre", "Advanced", "Niveau avancé", 4 },
                    { 5, "Lorem ipsumEng", "Lorem ipsumFre", "Expert", "Niveau expert", 5 }
                });

            migrationBuilder.InsertData(
                table: "CompetencyTypes",
                columns: new[] { "Id", "NameEng", "NameFre" },
                values: new object[,]
                {
                    { 2, "Technical Elements", "Éléments techniques" },
                    { 1, "Knowledge Elements", "Éléments de connaissance" },
                    { 3, "Behavioural Elements", "Éléments comportementaux" }
                });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "Id", "ValueEng", "ValueFre" },
                values: new object[,]
                {
                    { 2, "non-seagoing", "sur terre" },
                    { 1, "Seagoing", "En mer" }
                });

            migrationBuilder.InsertData(
                table: "JobGroupLevels",
                columns: new[] { "Id", "LevelValue" },
                values: new object[,]
                {
                    { 3, "03" },
                    { 2, "02" },
                    { 1, "01" }
                });

            migrationBuilder.InsertData(
                table: "JobGroups",
                columns: new[] { "Id", "CodeEng", "CodeFre", "NameEng", "NameFre" },
                values: new object[,]
                {
                    { 4, "GS", "SG", "General Services", "Services généraux" },
                    { 3, "GT", "TG", "General Technical", "Technique générale" },
                    { 2, "CS", "SI", "Computer Systems", "Systèmes informatiques" },
                    { 10, "SO", "ON", "Ships' Officers", "Officiers de navire" },
                    { 9, "SC", "EN", "Ships' Crews", "Équipages de navires" },
                    { 1, "AS", "SA", "Administrative Services", "Services Administratif" },
                    { 7, "PS", "AA", "Purchasing and Supply", "Achat et approvisionnement" },
                    { 6, "ES", "TS", "Engineering and Scientific Support", "Assistance technique et scientifique" },
                    { 5, "L", "GP", "Lightkeepers", "Les gardiens de phare" },
                    { 8, "GL", "GM", "General Labour and Trades", "Travail général et métiers" }
                });

            migrationBuilder.InsertData(
                table: "JobKeyTaskPerLevels",
                columns: new[] { "Id", "DescEng", "DescFre" },
                values: new object[,]
                {
                    { 1, "Lorem ipsumEng", "Lorem ipsumFra" },
                    { 2, "Lorem ipsumEng", "Lorem ipsumFra" },
                    { 3, "Lorem ipsumEng", "Lorem ipsumFra" },
                    { 4, "Lorem ipsumEng", "Lorem ipsumFra" }
                });

            migrationBuilder.InsertData(
                table: "JobLocationRegions",
                columns: new[] { "Id", "NameEng", "NameFre" },
                values: new object[,]
                {
                    { 1, "Atlantic", "Quebec" },
                    { 2, "Western", "Ouest" },
                    { 3, "Arctic", "Artique" },
                    { 4, "National Headquarters", "siège national" }
                });

            migrationBuilder.InsertData(
                table: "JobPositions",
                columns: new[] { "Id", "TitleEng", "TitleFre" },
                values: new object[,]
                {
                    { 4, "Project Officer", "Agent de projets" },
                    { 3, "Business Architect", "Architecte d'affaires" },
                    { 5, "cooker", "cuisiner" },
                    { 1, "Manager", "Gestionnaire" },
                    { 2, "Technical Advisor", "Conseiller technique" },
                    { 6, "Major", "Major" }
                });

            migrationBuilder.InsertData(
                table: "CompetencyTypeGroups",
                columns: new[] { "CompetencyId", "CompetencyTypeId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 3 },
                    { 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "JobGroupPositions",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "JobCategoryId", "JobKeyTaskPerLevelId", "JobLocationRegionId" },
                values: new object[,]
                {
                    { 2, 1, 3, 2, 4, 3 },
                    { 1, 1, 1, 1, 1, 1 },
                    { 3, 2, 6, 2, 4, 4 },
                    { 1, 2, 2, 1, 2, 2 },
                    { 3, 1, 5, 2, 4, 3 },
                    { 2, 2, 4, 2, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "JobPositionCompetencies",
                columns: new[] { "JobPositionId", "CompetencyId", "CompetencyTypeId" },
                values: new object[,]
                {
                    { 3, 4, 3 },
                    { 4, 4, 3 },
                    { 3, 3, 2 },
                    { 3, 2, 2 },
                    { 5, 2, 2 },
                    { 2, 2, 2 },
                    { 4, 2, 2 },
                    { 5, 1, 1 },
                    { 3, 6, 3 },
                    { 2, 1, 1 },
                    { 6, 1, 1 },
                    { 6, 2, 2 },
                    { 1, 1, 1 },
                    { 1, 2, 2 },
                    { 1, 3, 2 },
                    { 4, 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "JobRolePositionCertificates",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId" },
                values: new object[,]
                {
                    { 1, 2, 2, 1 },
                    { 2, 2, 4, 2 },
                    { 2, 2, 4, 3 },
                    { 3, 2, 6, 6 },
                    { 2, 3, 3, 5 },
                    { 1, 3, 1, 2 },
                    { 2, 3, 3, 2 },
                    { 3, 3, 5, 6 },
                    { 2, 3, 3, 3 },
                    { 1, 3, 1, 3 },
                    { 1, 3, 1, 1 },
                    { 3, 3, 5, 1 },
                    { 3, 3, 5, 2 },
                    { 3, 3, 5, 4 },
                    { 1, 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "JobRolePositionCompetencies",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId", "CompetencyTypeId" },
                values: new object[,]
                {
                    { 3, 3, 5, 4, 3 },
                    { 3, 3, 5, 1, 1 },
                    { 3, 2, 6, 1, 1 },
                    { 2, 2, 4, 4, 3 },
                    { 2, 2, 4, 3, 2 },
                    { 2, 2, 4, 2, 2 },
                    { 3, 2, 6, 2, 2 },
                    { 3, 2, 6, 6, 3 },
                    { 3, 3, 5, 6, 3 },
                    { 3, 3, 5, 2, 2 },
                    { 2, 3, 3, 3, 2 },
                    { 1, 3, 1, 1, 1 },
                    { 2, 3, 3, 6, 3 },
                    { 2, 3, 3, 4, 3 },
                    { 2, 3, 3, 2, 2 },
                    { 1, 3, 1, 2, 2 },
                    { 1, 3, 1, 3, 2 },
                    { 1, 2, 2, 2, 2 },
                    { 1, 2, 2, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "JobRolePositionCompetencyRatings",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId", "CompetencyTypeId", "CompetencyLevelReqId", "CompetencyLevelRequirementId", "CompetencyRatingLevelId" },
                values: new object[,]
                {
                    { 2, 3, 3, 4, 3, 3, null, 3 },
                    { 3, 3, 6, 1, 1, 3, null, 3 },
                    { 3, 3, 5, 6, 3, 4, null, 4 },
                    { 3, 3, 5, 4, 3, 5, null, 5 },
                    { 3, 3, 5, 2, 2, 4, null, 4 },
                    { 3, 3, 5, 1, 1, 4, null, 4 },
                    { 2, 3, 3, 6, 3, 4, null, 4 },
                    { 1, 3, 1, 1, 1, 1, null, 1 },
                    { 1, 3, 1, 3, 2, 3, null, 3 },
                    { 2, 3, 3, 3, 2, 2, null, 2 },
                    { 1, 3, 1, 2, 2, 2, null, 2 },
                    { 2, 3, 3, 2, 2, 1, null, 1 },
                    { 2, 2, 4, 2, 2, 5, null, 5 },
                    { 3, 3, 6, 6, 3, 3, null, 3 },
                    { 2, 2, 4, 4, 3, 2, null, 2 },
                    { 3, 3, 6, 2, 2, 4, null, 4 },
                    { 1, 2, 2, 2, 2, 5, null, 5 },
                    { 1, 2, 2, 1, 1, 4, null, 4 },
                    { 2, 2, 4, 3, 2, 1, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "JobRoles",
                columns: new[] { "JobGroupId", "JobGroupLevelId" },
                values: new object[,]
                {
                    { 2, 2 },
                    { 1, 2 },
                    { 3, 1 },
                    { 2, 1 },
                    { 1, 1 },
                    { 3, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompetencyTypeGroups_CompetencyTypeId",
                table: "CompetencyTypeGroups",
                column: "CompetencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobGroupPositions_JobCategoryId",
                table: "JobGroupPositions",
                column: "JobCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobGroupPositions_JobGroupLevelId",
                table: "JobGroupPositions",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobGroupPositions_JobKeyTaskPerLevelId",
                table: "JobGroupPositions",
                column: "JobKeyTaskPerLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobGroupPositions_JobLocationRegionId",
                table: "JobGroupPositions",
                column: "JobLocationRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_JobGroupPositions_JobPositionId",
                table: "JobGroupPositions",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPositionCertificates_CertificateId",
                table: "JobPositionCertificates",
                column: "CertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPositionCompetencies_CompetencyId",
                table: "JobPositionCompetencies",
                column: "CompetencyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPositionCompetencies_CompetencyTypeId",
                table: "JobPositionCompetencies",
                column: "CompetencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCertificates_CertificateId",
                table: "JobRolePositionCertificates",
                column: "CertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCertificates_JobGroupLevelId",
                table: "JobRolePositionCertificates",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCertificates_JobPositionId",
                table: "JobRolePositionCertificates",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencies_CompetencyId",
                table: "JobRolePositionCompetencies",
                column: "CompetencyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencies_CompetencyTypeId",
                table: "JobRolePositionCompetencies",
                column: "CompetencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencies_JobGroupLevelId",
                table: "JobRolePositionCompetencies",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencies_JobPositionId",
                table: "JobRolePositionCompetencies",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencyRatings_CompetencyId",
                table: "JobRolePositionCompetencyRatings",
                column: "CompetencyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencyRatings_CompetencyLevelRequirementId",
                table: "JobRolePositionCompetencyRatings",
                column: "CompetencyLevelRequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencyRatings_CompetencyRatingLevelId",
                table: "JobRolePositionCompetencyRatings",
                column: "CompetencyRatingLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencyRatings_CompetencyTypeId",
                table: "JobRolePositionCompetencyRatings",
                column: "CompetencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencyRatings_JobGroupLevelId",
                table: "JobRolePositionCompetencyRatings",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencyRatings_JobPositionId",
                table: "JobRolePositionCompetencyRatings",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRoles_JobGroupLevelId",
                table: "JobRoles",
                column: "JobGroupLevelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompetencyTypeGroups");

            migrationBuilder.DropTable(
                name: "JobGroupPositions");

            migrationBuilder.DropTable(
                name: "JobPositionCertificates");

            migrationBuilder.DropTable(
                name: "JobPositionCompetencies");

            migrationBuilder.DropTable(
                name: "JobRolePositionCertificates");

            migrationBuilder.DropTable(
                name: "JobRolePositionCompetencies");

            migrationBuilder.DropTable(
                name: "JobRolePositionCompetencyRatings");

            migrationBuilder.DropTable(
                name: "JobRoles");

            migrationBuilder.DropTable(
                name: "JobCategories");

            migrationBuilder.DropTable(
                name: "JobKeyTaskPerLevels");

            migrationBuilder.DropTable(
                name: "JobLocationRegions");

            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "Competencies");

            migrationBuilder.DropTable(
                name: "CompetencyLevelRequirements");

            migrationBuilder.DropTable(
                name: "CompetencyRatingLevels");

            migrationBuilder.DropTable(
                name: "CompetencyTypes");

            migrationBuilder.DropTable(
                name: "JobPositions");

            migrationBuilder.DropTable(
                name: "JobGroups");

            migrationBuilder.DropTable(
                name: "JobGroupLevels");
        }
    }
}
