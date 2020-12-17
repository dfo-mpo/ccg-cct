using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class ResetMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "Competencies");

            migrationBuilder.DropTable(
                name: "CompetencyLevelRequirements");

            migrationBuilder.DropTable(
                name: "CompetencyRatingGroups");

            migrationBuilder.DropTable(
                name: "CompetencyRatingLevels");

            migrationBuilder.DropTable(
                name: "CompetencyTypeGroups");

            migrationBuilder.DropTable(
                name: "CompetencyTypes");

            migrationBuilder.DropTable(
                name: "JobGroupLevels");

            migrationBuilder.DropTable(
                name: "JobGroupPositions");

            migrationBuilder.DropTable(
                name: "JobGroups");

            migrationBuilder.DropTable(
                name: "JobHLCategories");

            migrationBuilder.DropTable(
                name: "JobLocationRegions");

            migrationBuilder.DropTable(
                name: "JobPositionCompetencies");

            migrationBuilder.DropTable(
                name: "JobPositions");

            migrationBuilder.DropTable(
                name: "JobRolePositionCertificates");

            migrationBuilder.DropTable(
                name: "JobRolePositionCompetencies");

            migrationBuilder.DropTable(
                name: "JobRolePositionCompetencyRatings");

            migrationBuilder.DropTable(
                name: "JobRolePositionHLCategories");

            migrationBuilder.DropTable(
                name: "JobRolePositionLocations");

            migrationBuilder.DropTable(
                name: "JobRoles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "JobGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NameEng = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    NameFre = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobGroupLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelValue = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobGroupLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobPositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleEng = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    TitleFre = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobHLCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueEng = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ValueFre = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobHLCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobLocationRegions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEng = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    NameFre = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobLocationRegions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobRoles",
                columns: table => new
                {
                    JobGroupId = table.Column<int>(type: "int", nullable: false),
                    JobGroupLevelId = table.Column<int>(type: "int", nullable: false)
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
                    JobGroupId = table.Column<int>(type: "int", nullable: false),
                    JobGroupLevelId = table.Column<int>(type: "int", nullable: false),
                    JobPositionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobGroupPositions", x => new { x.JobGroupId, x.JobGroupLevelId, x.JobPositionId });
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
                        name: "FK_JobGroupPositions_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Competencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescEng = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: false),
                    DescFre = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: false),
                    NameEng = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    NameFre = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyRatingLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescEng = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DescFre = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    NameEng = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    NameFre = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyRatingLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEng = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NameFre = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescEng = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DescFre = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NameEng = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    NameFre = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    RequireIndicatorEng = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RequireIndicatorFre = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyTypeGroups",
                columns: table => new
                {
                    CompetencyId = table.Column<int>(type: "int", nullable: false),
                    CompetencyTypeId = table.Column<int>(type: "int", nullable: false)
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
                name: "CompetencyLevelRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescEng = table.Column<string>(type: "nvarchar(8000)", maxLength: 8000, nullable: true),
                    DescFre = table.Column<string>(type: "nvarchar(8000)", maxLength: 8000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyLevelRequirements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyRatingGroups",
                columns: table => new
                {
                    CompetencyId = table.Column<int>(type: "int", nullable: false),
                    CompetencyRatingLevelId = table.Column<int>(type: "int", nullable: false),
                    CompetencyLevelRequirementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyRatingGroups", x => new { x.CompetencyId, x.CompetencyRatingLevelId, x.CompetencyLevelRequirementId });
                    table.ForeignKey(
                        name: "FK_CompetencyRatingGroups_Competencies_CompetencyId",
                        column: x => x.CompetencyId,
                        principalTable: "Competencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetencyRatingGroups_CompetencyLevelRequirements_CompetencyLevelRequirementId",
                        column: x => x.CompetencyLevelRequirementId,
                        principalTable: "CompetencyLevelRequirements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetencyRatingGroups_CompetencyRatingLevels_CompetencyRatingLevelId",
                        column: x => x.CompetencyRatingLevelId,
                        principalTable: "CompetencyRatingLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobPositionCompetencies",
                columns: table => new
                {
                    JobPositionId = table.Column<int>(type: "int", nullable: false),
                    CompetencyId = table.Column<int>(type: "int", nullable: false),
                    CompetencyTypeId = table.Column<int>(type: "int", nullable: false)
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
                name: "JobRolePositionCompetencies",
                columns: table => new
                {
                    JobGroupId = table.Column<int>(type: "int", nullable: false),
                    JobGroupLevelId = table.Column<int>(type: "int", nullable: false),
                    JobPositionId = table.Column<int>(type: "int", nullable: false),
                    CompetencyId = table.Column<int>(type: "int", nullable: false),
                    CompetencyTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRolePositionCompetencies", x => new { x.JobGroupId, x.JobGroupLevelId, x.JobPositionId, x.CompetencyId });
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
                name: "JobRolePositionCertificates",
                columns: table => new
                {
                    JobGroupId = table.Column<int>(type: "int", nullable: false),
                    JobGroupLevelId = table.Column<int>(type: "int", nullable: false),
                    JobPositionId = table.Column<int>(type: "int", nullable: false),
                    CertificateId = table.Column<int>(type: "int", nullable: false)
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
                name: "JobRolePositionCompetencyRatings",
                columns: table => new
                {
                    JobGroupId = table.Column<int>(type: "int", nullable: false),
                    JobGroupLevelId = table.Column<int>(type: "int", nullable: false),
                    JobPositionId = table.Column<int>(type: "int", nullable: false),
                    CompetencyId = table.Column<int>(type: "int", nullable: false),
                    CompetencyTypeId = table.Column<int>(type: "int", nullable: false),
                    CompetencyRatingLevelId = table.Column<int>(type: "int", nullable: false),
                    CompetencyLevelRequirementId = table.Column<int>(type: "int", nullable: false)
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
                        name: "FK_JobRolePositionCompetencyRatings_CompetencyLevelRequirements_CompetencyLevelRequirementId",
                        column: x => x.CompetencyLevelRequirementId,
                        principalTable: "CompetencyLevelRequirements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencyRatings_CompetencyRatingLevels_CompetencyRatingLevelId",
                        column: x => x.CompetencyRatingLevelId,
                        principalTable: "CompetencyRatingLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencyRatings_CompetencyTypes_CompetencyTypeId",
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
                        name: "FK_JobRolePositionCompetencyRatings_JobGroupLevels_JobGroupLevelId",
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

            migrationBuilder.CreateTable(
                name: "JobRolePositionLocations",
                columns: table => new
                {
                    JobGroupId = table.Column<int>(nullable: false),
                    JobGroupLevelId = table.Column<int>(nullable: false),
                    JobPositionId = table.Column<int>(nullable: false),
                    JobLocationRegionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRolePositionLocations", x => new { x.JobGroupId, x.JobGroupLevelId, x.JobPositionId, x.JobLocationRegionId });
                    table.ForeignKey(
                        name: "FK_JobRolePositionLocations_JobGroups_JobGroupId",
                        column: x => x.JobGroupId,
                        principalTable: "JobGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionLocations_JobGroupLevels_JobGroupLevelId",
                        column: x => x.JobGroupLevelId,
                        principalTable: "JobGroupLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionLocations_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionLocations_JobLocationRegions_JobLocationRegionId",
                        column: x => x.JobLocationRegionId,
                        principalTable: "JobLocationRegions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobRolePositionHLCategories",
                columns: table => new
                {
                    JobGroupId = table.Column<int>(nullable: false),
                    JobGroupLevelId = table.Column<int>(nullable: false),
                    JobPositionId = table.Column<int>(nullable: false),
                    JobHLCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRolePositionHLCategories", x => new { x.JobGroupId, x.JobGroupLevelId, x.JobPositionId, x.JobHLCategoryId });
                    table.ForeignKey(
                        name: "FK_JobRolePositionHLCategories_JobGroups_JobGroupId",
                        column: x => x.JobGroupId,
                        principalTable: "JobGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionHLCategories_JobGroupLevels_JobGroupLevelId",
                        column: x => x.JobGroupLevelId,
                        principalTable: "JobGroupLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionHLCategories_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionHLCategories_JobHLCategories_JobHLCategoryId",
                        column: x => x.JobHLCategoryId,
                        principalTable: "JobHLCategories",
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
                    { 4, "Lorem ipsumEng", "Lorem ipsumFre" },
                    { 3, "Lorem ipsumEng", "Lorem ipsumFre" },
                    { 5, "Lorem ipsumEng", "Lorem ipsumFre" },
                    { 1, "Lorem ipsumEng", "Lorem ipsumFre" },
                    { 2, "Lorem ipsumEng", "Lorem ipsumFre" }
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
                    { 3, "Behavioural Elements", "Éléments comportementaux" },
                    { 2, "Technical Elements", "Éléments techniques" },
                    { 1, "Knowledge Elements", "Éléments de connaissance" }
                });

            migrationBuilder.InsertData(
                table: "JobHLCategories",
                columns: new[] { "Id", "ValueEng", "ValueFre" },
                values: new object[,]
                {
                    { 1, "Seagoing", "En mer" },
                    { 2, "Shoreside", "Sur terre" }
                });

            migrationBuilder.InsertData(
                table: "JobGroupLevels",
                columns: new[] { "Id", "LevelValue" },
                values: new object[,]
                {
                    { 2, "02" },
                    { 6, "06" },
                    { 5, "05" },
                    { 4, "04" },
                    { 1, "01" },
                    { 3, "03" }
                });

            migrationBuilder.InsertData(
                table: "JobGroups",
                columns: new[] { "Id", "Code", "NameEng", "NameFre" },
                values: new object[,]
                {
                    { 2, "CS", "Computer Sciences", "Sciences Informatiques" },
                    { 1, "AS", "Admin. Services", "Admin. Services" },
                    { 3, "SO-MAO", "Ships' Officers", "Officiers et officières de navire" }
                });


            migrationBuilder.InsertData(
                table: "JobLocationRegions",
                columns: new[] { "Id", "NameEng", "NameFre" },
                values: new object[,]
                {
                    { 4, "National Headquarters", "siège national" },
                    { 1, "Atlantic", "Atlantique" },
                    { 2, "Western", "Ouest" },
                    { 3, "Arctic", "Artique" }
                });

            migrationBuilder.InsertData(
                table: "JobPositions",
                columns: new[] { "Id", "TitleEng", "TitleFre" },
                values: new object[,]
                {
                    { 9, "Cook", "Cuisinier" },
                    { 8, "Director", "Directeur" },
                    { 7, "Analyst", "Analyste" },
                    { 6, "Supervisor", "Superviseur" },
                    { 10, "Supervisor: Search and Rescue", "Superviseur(se) : Recherche et sauvetage" },
                    { 4, "Business Architect", "Architecte d'affaires" },
                    { 3, "Technical Advisor", "Conseiller technique" },
                    { 2, "Manager", "Gestionnaire" },
                    { 1, "Administrative assistant", "Adjointe administrative" },
                    { 5, "Project Officer", "Agent de projets" },
                    { 11, "Marine officer", "Officier de marine" }
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
                    { 1, 3, 5, 1, 3, 4 },
                    { 2, 5, 8, 1, 5, 4 },
                    { 1, 2, 1, 1, 2, 4 },
                    { 3, 3, 11, 2, 1, 1 },
                    { 1, 4, 6, 1, 4, 4 },
                    { 1, 5, 2, 1, 5, 4 },
                    { 2, 2, 4, 1, 2, 4 },
                    { 2, 4, 7, 1, 4, 4 },
                    { 3, 3, 10, 2, 3, 1 },
                    { 2, 3, 3, 1, 3, 4 },
                    { 3, 1, 9, 2, 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "JobPositionCompetencies",
                columns: new[] { "JobPositionId", "CompetencyId", "CompetencyTypeId" },
                values: new object[,]
                {
                    { 9, 1, 1 },
                    { 4, 1, 1 },
                    { 4, 2, 1 },
                    { 7, 4, 2 },
                    { 4, 3, 2 },
                    { 4, 4, 2 },
                    { 4, 5, 3 },
                    { 8, 6, 3 },
                    { 9, 3, 2 },
                    { 5, 1, 1 },
                    { 8, 3, 2 },
                    { 5, 3, 2 },
                    { 7, 3, 2 },
                    { 7, 2, 1 },
                    { 7, 1, 1 },
                    { 7, 6, 3 },
                    { 6, 5, 3 },
                    { 6, 4, 3 },
                    { 5, 2, 1 },
                    { 6, 3, 2 },
                    { 6, 1, 1 },
                    { 8, 1, 1 },
                    { 8, 2, 1 },
                    { 3, 5, 3 },
                    { 8, 4, 2 },
                    { 8, 5, 3 },
                    { 6, 2, 2 },
                    { 3, 4, 2 },
                    { 9, 2, 2 },
                    { 3, 2, 1 },
                    { 11, 4, 3 },
                    { 11, 3, 2 },
                    { 11, 2, 2 },
                    { 11, 1, 1 },
                    { 1, 1, 1 },
                    { 1, 2, 1 },
                    { 2, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 2 },
                    { 2, 4, 3 },
                    { 10, 4, 3 },
                    { 2, 3, 2 },
                    { 10, 3, 2 },
                    { 3, 1, 1 },
                    { 10, 1, 1 },
                    { 10, 2, 2 },
                    { 7, 5, 3 }
                });

            migrationBuilder.InsertData(
                table: "JobRolePositionCertificates",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId" },
                values: new object[,]
                {
                    { 1, 5, 2, 2 },
                    { 1, 4, 6, 1 },
                    { 3, 3, 11, 5 },
                    { 3, 3, 11, 4 },
                    { 2, 3, 3, 3 },
                    { 2, 3, 3, 4 },
                    { 1, 5, 2, 3 },
                    { 3, 1, 9, 6 },
                    { 2, 4, 7, 6 },
                    { 2, 4, 7, 4 },
                    { 2, 4, 7, 3 },
                    { 1, 3, 5, 1 },
                    { 1, 4, 6, 2 },
                    { 3, 3, 10, 4 },
                    { 3, 1, 9, 4 },
                    { 3, 3, 10, 6 },
                    { 1, 5, 2, 1 },
                    { 2, 5, 8, 3 },
                    { 2, 5, 8, 4 },
                    { 2, 5, 8, 5 },
                    { 2, 5, 8, 6 },
                    { 2, 2, 4, 3 },
                    { 3, 3, 11, 6 },
                    { 3, 3, 10, 5 },
                    { 2, 2, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "JobRolePositionCompetencies",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId", "CompetencyTypeId" },
                values: new object[,]
                {
                    { 3, 3, 11, 4, 3 },
                    { 3, 3, 11, 3, 2 },
                    { 3, 3, 11, 1, 1 },
                    { 2, 4, 7, 3, 2 },
                    { 2, 4, 7, 2, 1 },
                    { 2, 4, 7, 1, 1 },
                    { 3, 3, 11, 2, 2 },
                    { 2, 4, 7, 4, 2 },
                    { 3, 1, 9, 1, 1 },
                    { 2, 4, 7, 6, 3 },
                    { 3, 1, 9, 3, 2 },
                    { 3, 1, 9, 2, 2 },
                    { 2, 5, 8, 6, 3 },
                    { 3, 3, 10, 3, 2 },
                    { 3, 3, 10, 2, 2 },
                    { 3, 3, 10, 1, 1 },
                    { 2, 5, 8, 1, 1 },
                    { 2, 5, 8, 2, 1 },
                    { 2, 5, 8, 3, 2 },
                    { 2, 5, 8, 4, 2 },
                    { 2, 5, 8, 5, 3 },
                    { 2, 4, 7, 5, 3 },
                    { 3, 3, 10, 4, 3 },
                    { 1, 4, 6, 2, 2 },
                    { 1, 3, 5, 2, 1 },
                    { 2, 2, 4, 3, 2 },
                    { 2, 2, 4, 2, 1 },
                    { 1, 5, 2, 4, 3 },
                    { 1, 3, 5, 1, 1 },
                    { 2, 3, 3, 5, 3 },
                    { 1, 3, 5, 3, 2 },
                    { 1, 5, 2, 3, 2 },
                    { 1, 5, 2, 2, 1 },
                    { 1, 5, 2, 1, 1 },
                    { 2, 2, 4, 1, 1 },
                    { 2, 2, 4, 4, 2 },
                    { 1, 2, 1, 2, 1 },
                    { 1, 4, 6, 1, 1 },
                    { 2, 3, 3, 1, 1 },
                    { 1, 4, 6, 3, 2 },
                    { 1, 4, 6, 4, 3 },
                    { 1, 4, 6, 5, 3 },
                    { 2, 3, 3, 2, 1 },
                    { 2, 3, 3, 3, 2 },
                    { 2, 3, 3, 4, 2 },
                    { 1, 2, 1, 1, 1 },
                    { 2, 2, 4, 5, 3 }
                });

            migrationBuilder.InsertData(
                table: "JobRolePositionCompetencyRatings",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId", "CompetencyTypeId", "CompetencyLevelRequirementId", "CompetencyRatingLevelId" },
                values: new object[,]
                {
                    { 3, 1, 9, 3, 2, 1, 1 },
                    { 3, 1, 9, 2, 2, 2, 2 },
                    { 3, 1, 9, 1, 1, 1, 1 },
                    { 1, 4, 6, 4, 3, 3, 3 },
                    { 1, 5, 2, 3, 2, 3, 3 },
                    { 1, 5, 2, 2, 1, 3, 3 },
                    { 1, 5, 2, 1, 1, 3, 3 },
                    { 1, 2, 1, 2, 1, 2, 1 },
                    { 1, 2, 1, 1, 1, 1, 1 },
                    { 3, 3, 10, 1, 1, 2, 3 },
                    { 3, 3, 10, 2, 2, 3, 3 },
                    { 3, 3, 10, 3, 2, 3, 3 },
                    { 3, 3, 10, 4, 3, 4, 4 },
                    { 3, 3, 11, 1, 1, 2, 3 },
                    { 3, 3, 11, 2, 2, 3, 3 },
                    { 1, 5, 2, 4, 3, 2, 2 },
                    { 2, 3, 3, 1, 1, 3, 3 },
                    { 2, 3, 3, 2, 1, 2, 2 },
                    { 2, 3, 3, 3, 2, 3, 3 },
                    { 1, 4, 6, 3, 2, 3, 3 },
                    { 1, 4, 6, 2, 1, 3, 3 },
                    { 1, 4, 6, 1, 1, 4, 4 },
                    { 3, 3, 11, 3, 2, 2, 2 },
                    { 2, 4, 7, 1, 1, 4, 4 },
                    { 2, 4, 7, 2, 1, 4, 4 },
                    { 1, 4, 6, 5, 3, 5, 5 },
                    { 2, 4, 7, 4, 2, 4, 4 },
                    { 2, 4, 7, 5, 3, 3, 3 },
                    { 2, 4, 7, 6, 3, 2, 2 },
                    { 1, 3, 5, 3, 2, 2, 2 },
                    { 1, 3, 5, 2, 1, 3, 3 },
                    { 1, 3, 5, 1, 1, 2, 2 },
                    { 2, 4, 7, 3, 2, 3, 3 },
                    { 2, 2, 4, 4, 2, 3, 3 },
                    { 2, 3, 3, 4, 3, 2, 2 },
                    { 2, 5, 8, 6, 3, 4, 4 },
                    { 2, 2, 4, 5, 3, 2, 2 },
                    { 2, 5, 8, 5, 3, 4, 4 },
                    { 2, 5, 8, 4, 2, 3, 3 },
                    { 2, 5, 8, 3, 2, 4, 4 },
                    { 3, 3, 11, 4, 3, 2, 2 },
                    { 2, 5, 8, 1, 1, 5, 5 },
                    { 2, 3, 3, 5, 3, 1, 1 },
                    { 2, 2, 4, 3, 2, 3, 3 },
                    { 2, 2, 4, 2, 1, 3, 3 },
                    { 2, 2, 4, 1, 1, 3, 3 },
                    { 2, 5, 8, 2, 1, 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "JobRoles",
                columns: new[] { "JobGroupId", "JobGroupLevelId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 1, 2 },
                    { 3, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 2, 4 },
                    { 3, 4 },
                    { 2, 2 },
                    { 1, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompetencyTypeGroups_CompetencyTypeId",
                table: "CompetencyTypeGroups",
                column: "CompetencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRoles_JobGroupLevelId",
                table: "JobRoles",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobGroupPositions_JobGroupLevelId",
                table: "JobGroupPositions",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobGroupPositions_JobPositionId",
                table: "JobGroupPositions",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetencyRatingGroups_CompetencyRatingLevelId",
                table: "CompetencyRatingGroups",
                column: "CompetencyRatingLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetencyRatingGroups_CompetencyLevelRequirementId",
                table: "CompetencyRatingGroups",
                column: "CompetencyLevelRequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPositionCompetencies_CompetencyId",
                table: "JobPositionCompetencies",
                column: "CompetencyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPositionCompetencies_CompetencyTypeId",
                table: "JobPositionCompetencies",
                column: "CompetencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCertificates_JobGroupLevelId",
                table: "JobRolePositionCertificates",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCertificates_JobPositionId",
                table: "JobRolePositionCertificates",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCertificates_CertificateId",
                table: "JobRolePositionCertificates",
                column: "CertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencies_JobGroupLevelId",
                table: "JobRolePositionCompetencies",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencies_JobPositionId",
                table: "JobRolePositionCompetencies",
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
                name: "IX_JobRolePositionCompetencyRatings_JobGroupLevelId",
                table: "JobRolePositionCompetencyRatings",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencyRatings_JobPositionId",
                table: "JobRolePositionCompetencyRatings",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencyRatings_CompetencyId",
                table: "JobRolePositionCompetencyRatings",
                column: "CompetencyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencyRatings_CompetencyTypeId",
                table: "JobRolePositionCompetencyRatings",
                column: "CompetencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencyRatings_CompetencyRatingLevelId",
                table: "JobRolePositionCompetencyRatings",
                column: "CompetencyRatingLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencyRatings_CompetencyLevelRequirementId",
                table: "JobRolePositionCompetencyRatings",
                column: "CompetencyLevelRequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionLocations_JobGroupLevelId",
                table: "JobRolePositionLocations",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionLocations_JobPositionId",
                table: "JobRolePositionLocations",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionLocations_JobLocationRegionId",
                table: "JobRolePositionLocations",
                column: "JobLocationRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionHLCategories_JobGroupLevelId",
                table: "JobRolePositionHLCategories",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionHLCategories_JobPositionId",
                table: "JobRolePositionHLCategories",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionHLCategories_JobHLCategoryId",
                table: "JobRolePositionHLCategories",
                column: "JobHLCategoryId");
        }
    }
}
