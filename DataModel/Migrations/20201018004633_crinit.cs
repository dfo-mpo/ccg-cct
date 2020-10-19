using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class crinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competency",
                columns: table => new
                {
                    CompetencyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetencyNameEng = table.Column<string>(nullable: true),
                    CompetencyNameFra = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competency", x => x.CompetencyId);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyLevelRequirements",
                columns: table => new
                {
                    CompetencyLevelRequirementsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetencyLevelRequirementsEng = table.Column<string>(nullable: true),
                    CompetencyLevelRequirementsFra = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyLevelRequirements", x => x.CompetencyLevelRequirementsId);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyRatingLevel",
                columns: table => new
                {
                    CompetencyRatingLevelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetencyRatingLevelNameEng = table.Column<string>(nullable: true),
                    CompetencyRatingLevelNameFra = table.Column<string>(nullable: true),
                    CompetencyRatingLevelDescriptionEng = table.Column<string>(nullable: true),
                    CompetencyRatingLevelDescriptionFra = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyRatingLevel", x => x.CompetencyRatingLevelId);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyType",
                columns: table => new
                {
                    CompetencyTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetencyCategoryEng = table.Column<string>(nullable: true),
                    CompetencyCategoryFra = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    CertificateDescriptionEng = table.Column<string>(nullable: true),
                    CertificateDescriptionFra = table.Column<string>(nullable: true),
                    RequireIndicatorEng = table.Column<string>(nullable: true),
                    RequireIndicatorFra = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyType", x => x.CompetencyTypeId);
                });

            migrationBuilder.CreateTable(
                name: "JobCategory",
                columns: table => new
                {
                    JobCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobCategoryValueEng = table.Column<string>(nullable: true),
                    JobCategoryValueFra = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCategory", x => x.JobCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "JobGroup",
                columns: table => new
                {
                    JobGroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobGroupClassification = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobGroup", x => x.JobGroupId);
                });

            migrationBuilder.CreateTable(
                name: "JobGroupLevel",
                columns: table => new
                {
                    JobGroupLevelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobGroupClassificationLevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobGroupLevel", x => x.JobGroupLevelId);
                });

            migrationBuilder.CreateTable(
                name: "JobKeyTaskPerLevel",
                columns: table => new
                {
                    JobKeyTaskPerLevelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobKeyTaskPerLevelEng = table.Column<string>(nullable: true),
                    JobKeyTaskPerLevelFra = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobKeyTaskPerLevel", x => x.JobKeyTaskPerLevelId);
                });

            migrationBuilder.CreateTable(
                name: "JobLocationRegion",
                columns: table => new
                {
                    JobLocationRegionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobLocationRegionEng = table.Column<string>(nullable: true),
                    JobLocationRegionFra = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobLocationRegion", x => x.JobLocationRegionId);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyGroupsRatings",
                columns: table => new
                {
                    CompetencyId = table.Column<int>(nullable: false),
                    CompetencyRatingLevelId = table.Column<int>(nullable: false),
                    CompetencyLevelRequirementsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyGroupsRatings", x => new { x.CompetencyId, x.CompetencyRatingLevelId, x.CompetencyLevelRequirementsId });
                    table.ForeignKey(
                        name: "FK_CompetencyGroupsRatings_Competency_CompetencyId",
                        column: x => x.CompetencyId,
                        principalTable: "Competency",
                        principalColumn: "CompetencyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetencyGroupsRatings_CompetencyLevelRequirements_CompetencyLevelRequirementsId",
                        column: x => x.CompetencyLevelRequirementsId,
                        principalTable: "CompetencyLevelRequirements",
                        principalColumn: "CompetencyLevelRequirementsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetencyGroupsRatings_CompetencyRatingLevel_CompetencyRatingLevelId",
                        column: x => x.CompetencyRatingLevelId,
                        principalTable: "CompetencyRatingLevel",
                        principalColumn: "CompetencyRatingLevelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyGroupsTypes",
                columns: table => new
                {
                    CompetencyId = table.Column<int>(nullable: false),
                    CompetencyTypeid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyGroupsTypes", x => new { x.CompetencyId, x.CompetencyTypeid });
                    table.ForeignKey(
                        name: "FK_CompetencyGroupsTypes_Competency_CompetencyId",
                        column: x => x.CompetencyId,
                        principalTable: "Competency",
                        principalColumn: "CompetencyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetencyGroupsTypes_CompetencyType_CompetencyTypeid",
                        column: x => x.CompetencyTypeid,
                        principalTable: "CompetencyType",
                        principalColumn: "CompetencyTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobGroupPosition",
                columns: table => new
                {
                    JobPositionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobPositionTitleEng = table.Column<string>(nullable: true),
                    JobPositionTitleFra = table.Column<string>(nullable: true),
                    JobGroupId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobGroupPosition", x => x.JobPositionId);
                    table.ForeignKey(
                        name: "FK_JobGroupPosition_JobGroup_JobGroupId",
                        column: x => x.JobGroupId,
                        principalTable: "JobGroup",
                        principalColumn: "JobGroupId",
                        onDelete: ReferentialAction.Restrict);
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
                        name: "FK_JobRoles_JobGroup_JobGroupId",
                        column: x => x.JobGroupId,
                        principalTable: "JobGroup",
                        principalColumn: "JobGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRoles_JobGroupLevel_JobGroupLevelId",
                        column: x => x.JobGroupLevelId,
                        principalTable: "JobGroupLevel",
                        principalColumn: "JobGroupLevelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobPosition",
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
                    table.PrimaryKey("PK_JobPosition", x => new { x.JobGroupId, x.JobGroupLevelId, x.JobCategoryId, x.JobPositionId, x.JobKeyTaskPerLevelId, x.JobLocationRegionId });
                    table.ForeignKey(
                        name: "FK_JobPosition_JobCategory_JobCategoryId",
                        column: x => x.JobCategoryId,
                        principalTable: "JobCategory",
                        principalColumn: "JobCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPosition_JobGroup_JobGroupId",
                        column: x => x.JobGroupId,
                        principalTable: "JobGroup",
                        principalColumn: "JobGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPosition_JobGroupLevel_JobGroupLevelId",
                        column: x => x.JobGroupLevelId,
                        principalTable: "JobGroupLevel",
                        principalColumn: "JobGroupLevelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPosition_JobKeyTaskPerLevel_JobKeyTaskPerLevelId",
                        column: x => x.JobKeyTaskPerLevelId,
                        principalTable: "JobKeyTaskPerLevel",
                        principalColumn: "JobKeyTaskPerLevelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPosition_JobLocationRegion_JobLocationRegionId",
                        column: x => x.JobLocationRegionId,
                        principalTable: "JobLocationRegion",
                        principalColumn: "JobLocationRegionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPosition_JobGroupPosition_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobGroupPosition",
                        principalColumn: "JobPositionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobPositionCompetency",
                columns: table => new
                {
                    JobPositionId = table.Column<int>(nullable: false),
                    CompetencyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPositionCompetency", x => new { x.JobPositionId, x.CompetencyId });
                    table.ForeignKey(
                        name: "FK_JobPositionCompetency_Competency_CompetencyId",
                        column: x => x.CompetencyId,
                        principalTable: "Competency",
                        principalColumn: "CompetencyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPositionCompetency_JobGroupPosition_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobGroupPosition",
                        principalColumn: "JobPositionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobRolesPositionCompetency",
                columns: table => new
                {
                    JobGroupId = table.Column<int>(nullable: false),
                    JobGroupLevelId = table.Column<int>(nullable: false),
                    JobPositionId = table.Column<int>(nullable: false),
                    CompetencyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRolesPositionCompetency", x => new { x.JobGroupId, x.JobGroupLevelId, x.JobPositionId, x.CompetencyId });
                    table.ForeignKey(
                        name: "FK_JobRolesPositionCompetency_Competency_CompetencyId",
                        column: x => x.CompetencyId,
                        principalTable: "Competency",
                        principalColumn: "CompetencyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolesPositionCompetency_JobGroup_JobGroupId",
                        column: x => x.JobGroupId,
                        principalTable: "JobGroup",
                        principalColumn: "JobGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolesPositionCompetency_JobGroupLevel_JobGroupLevelId",
                        column: x => x.JobGroupLevelId,
                        principalTable: "JobGroupLevel",
                        principalColumn: "JobGroupLevelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolesPositionCompetency_JobGroupPosition_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobGroupPosition",
                        principalColumn: "JobPositionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompetencyGroupsRatings_CompetencyLevelRequirementsId",
                table: "CompetencyGroupsRatings",
                column: "CompetencyLevelRequirementsId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetencyGroupsRatings_CompetencyRatingLevelId",
                table: "CompetencyGroupsRatings",
                column: "CompetencyRatingLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetencyGroupsTypes_CompetencyTypeid",
                table: "CompetencyGroupsTypes",
                column: "CompetencyTypeid");

            migrationBuilder.CreateIndex(
                name: "IX_JobGroupPosition_JobGroupId",
                table: "JobGroupPosition",
                column: "JobGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosition_JobCategoryId",
                table: "JobPosition",
                column: "JobCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosition_JobGroupLevelId",
                table: "JobPosition",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosition_JobKeyTaskPerLevelId",
                table: "JobPosition",
                column: "JobKeyTaskPerLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosition_JobLocationRegionId",
                table: "JobPosition",
                column: "JobLocationRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosition_JobPositionId",
                table: "JobPosition",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPositionCompetency_CompetencyId",
                table: "JobPositionCompetency",
                column: "CompetencyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRoles_JobGroupLevelId",
                table: "JobRoles",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolesPositionCompetency_CompetencyId",
                table: "JobRolesPositionCompetency",
                column: "CompetencyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolesPositionCompetency_JobGroupLevelId",
                table: "JobRolesPositionCompetency",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolesPositionCompetency_JobPositionId",
                table: "JobRolesPositionCompetency",
                column: "JobPositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompetencyGroupsRatings");

            migrationBuilder.DropTable(
                name: "CompetencyGroupsTypes");

            migrationBuilder.DropTable(
                name: "JobPosition");

            migrationBuilder.DropTable(
                name: "JobPositionCompetency");

            migrationBuilder.DropTable(
                name: "JobRoles");

            migrationBuilder.DropTable(
                name: "JobRolesPositionCompetency");

            migrationBuilder.DropTable(
                name: "CompetencyLevelRequirements");

            migrationBuilder.DropTable(
                name: "CompetencyRatingLevel");

            migrationBuilder.DropTable(
                name: "CompetencyType");

            migrationBuilder.DropTable(
                name: "JobCategory");

            migrationBuilder.DropTable(
                name: "JobKeyTaskPerLevel");

            migrationBuilder.DropTable(
                name: "JobLocationRegion");

            migrationBuilder.DropTable(
                name: "Competency");

            migrationBuilder.DropTable(
                name: "JobGroupLevel");

            migrationBuilder.DropTable(
                name: "JobGroupPosition");

            migrationBuilder.DropTable(
                name: "JobGroup");
        }
    }
}
