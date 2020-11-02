using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class newdbandseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEng = table.Column<string>(maxLength: 250, nullable: false),
                    NameFre = table.Column<string>(maxLength: 250, nullable: false)
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(maxLength: 250, nullable: false)
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcrEng = table.Column<string>(nullable: true),
                    AcrFre = table.Column<string>(nullable: true),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleEng = table.Column<string>(maxLength: 250, nullable: false),
                    TitleFre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetencyId = table.Column<int>(nullable: true),
                    DescEng = table.Column<string>(maxLength: 250, nullable: false),
                    DescFre = table.Column<string>(maxLength: 250, nullable: false),
                    RequireIndicatorEng = table.Column<string>(maxLength: 250, nullable: true),
                    RequireIndicatorFre = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Certificates_Competencies_CompetencyId",
                        column: x => x.CompetencyId,
                        principalTable: "Competencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyRatingGroups",
                columns: table => new
                {
                    CompetencyId = table.Column<int>(nullable: false),
                    CompetencyRatingLevelId = table.Column<int>(nullable: false),
                    CompetencyLevelRequirementId = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_JobGroupPositions", x => new { x.JobGroupId, x.JobGroupLevelId, x.JobCategoryId, x.JobPositionId, x.JobKeyTaskPerLevelId, x.JobLocationRegionId });
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
                name: "JobPositionCompetencies",
                columns: table => new
                {
                    JobPositionId = table.Column<int>(nullable: false),
                    CompetencyId = table.Column<int>(nullable: false)
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
                        name: "FK_JobPositionCompetencies_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobRolesPositionCompetencies",
                columns: table => new
                {
                    JobGroupId = table.Column<int>(nullable: false),
                    JobGroupLevelId = table.Column<int>(nullable: false),
                    JobPositionId = table.Column<int>(nullable: false),
                    CompetencyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRolesPositionCompetencies", x => new { x.JobGroupId, x.JobGroupLevelId, x.JobPositionId, x.CompetencyId });
                    table.ForeignKey(
                        name: "FK_JobRolesPositionCompetencies_Competencies_CompetencyId",
                        column: x => x.CompetencyId,
                        principalTable: "Competencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolesPositionCompetencies_JobGroups_JobGroupId",
                        column: x => x.JobGroupId,
                        principalTable: "JobGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolesPositionCompetencies_JobGroupLevels_JobGroupLevelId",
                        column: x => x.JobGroupLevelId,
                        principalTable: "JobGroupLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolesPositionCompetencies_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "JobGroupLevels",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { 3, "03" },
                    { 2, "02" },
                    { 1, "01" }
                });

            migrationBuilder.InsertData(
                table: "JobGroups",
                columns: new[] { "Id", "AcrEng", "AcrFre", "NameEng", "NameFre" },
                values: new object[,]
                {
                    { 1, "GT", "TG", "General Technical", "Technique générale" },
                    { 8, "SC", "EN", "Ships'' Crews", "Équipages de navires" },
                    { 7, "GL", "TGM", "General Labour and Trades", "Travail général et métiers" },
                    { 9, "SO", "ON", "Ships'' Officers", "Officiers de navire" },
                    { 5, "ES", "ATS", "Engineering and Scientific Support", "Assistance technique et scientifique" },
                    { 4, "CS", "SI", "Computer Systems", "Systèmes informatiques" },
                    { 3, "GS", "SG", "General Services", "Services généraux" },
                    { 2, "L", "GP", "Lightkeepers", "Les gardiens de phare" },
                    { 6, "PS", "AA", "Purchasing and Supply", "Achat et approvisionnement" }
                });

            migrationBuilder.InsertData(
                table: "JobPositions",
                columns: new[] { "Id", "TitleEng", "TitleFre" },
                values: new object[,]
                {
                    { 4, "Project Officer", "Agent de projets" },
                    { 1, "Manager", "Gestionnaire" },
                    { 2, "Technical Advisor", "Conseiller technique" },
                    { 3, "Business Architect", "Architecte d'affaires" },
                    { 5, "Project Manager", "Gestionnaire de projets" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_CompetencyId",
                table: "Certificates",
                column: "CompetencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_Id",
                table: "Certificates",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CompetencyRatingGroups_CompetencyLevelRequirementId",
                table: "CompetencyRatingGroups",
                column: "CompetencyLevelRequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetencyRatingGroups_CompetencyRatingLevelId",
                table: "CompetencyRatingGroups",
                column: "CompetencyRatingLevelId");

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
                name: "IX_JobPositionCompetencies_CompetencyId",
                table: "JobPositionCompetencies",
                column: "CompetencyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRoles_JobGroupLevelId",
                table: "JobRoles",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolesPositionCompetencies_CompetencyId",
                table: "JobRolesPositionCompetencies",
                column: "CompetencyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolesPositionCompetencies_JobGroupLevelId",
                table: "JobRolesPositionCompetencies",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolesPositionCompetencies_JobPositionId",
                table: "JobRolesPositionCompetencies",
                column: "JobPositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "CompetencyRatingGroups");

            migrationBuilder.DropTable(
                name: "CompetencyTypeGroups");

            migrationBuilder.DropTable(
                name: "JobGroupPositions");

            migrationBuilder.DropTable(
                name: "JobPositionCompetencies");

            migrationBuilder.DropTable(
                name: "JobRoles");

            migrationBuilder.DropTable(
                name: "JobRolesPositionCompetencies");

            migrationBuilder.DropTable(
                name: "CompetencyLevelRequirements");

            migrationBuilder.DropTable(
                name: "CompetencyRatingLevels");

            migrationBuilder.DropTable(
                name: "CompetencyTypes");

            migrationBuilder.DropTable(
                name: "JobCategories");

            migrationBuilder.DropTable(
                name: "JobKeyTaskPerLevels");

            migrationBuilder.DropTable(
                name: "JobLocationRegions");

            migrationBuilder.DropTable(
                name: "Competencies");

            migrationBuilder.DropTable(
                name: "JobGroups");

            migrationBuilder.DropTable(
                name: "JobGroupLevels");

            migrationBuilder.DropTable(
                name: "JobPositions");
        }
    }
}
