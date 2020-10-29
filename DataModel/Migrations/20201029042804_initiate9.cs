using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class initiate9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompetencyLevelRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequirementsDescEng = table.Column<string>(maxLength: 150, nullable: true),
                    RequirementsDescFre = table.Column<string>(maxLength: 150, nullable: true)
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
                    RatingLevelNameEng = table.Column<string>(maxLength: 150, nullable: true),
                    RatingLevelNameFre = table.Column<string>(maxLength: 150, nullable: true),
                    RatingLevelDescEng = table.Column<string>(maxLength: 150, nullable: true),
                    RatingLevelDescFre = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyRatingLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Competencys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEng = table.Column<string>(maxLength: 150, nullable: true),
                    NameFre = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competencys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEng = table.Column<string>(maxLength: 150, nullable: true),
                    NameFre = table.Column<string>(maxLength: 150, nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    DescriptionEng = table.Column<string>(maxLength: 150, nullable: true),
                    DescriptionFre = table.Column<string>(maxLength: 150, nullable: true),
                    RequireIndicatorEng = table.Column<string>(maxLength: 150, nullable: true),
                    RequireIndicatorFre = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobCategorys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueEng = table.Column<string>(maxLength: 150, nullable: true),
                    ValueFre = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCategorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobGroupLevels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassificationLevel = table.Column<string>(maxLength: 150, nullable: true)
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
                    ClassificationName = table.Column<string>(maxLength: 150, nullable: true)
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
                    KeyTaskPerLevelEng = table.Column<string>(maxLength: 150, nullable: true),
                    KeyTaskPerLevelFre = table.Column<string>(maxLength: 150, nullable: true)
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
                    RegionNameEng = table.Column<string>(maxLength: 150, nullable: true),
                    RegionNameFre = table.Column<string>(maxLength: 150, nullable: true)
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
                    PositionNameEng = table.Column<string>(maxLength: 150, nullable: true),
                    PositionNameFre = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyGroupsRatings",
                columns: table => new
                {
                    CompetencyId = table.Column<int>(nullable: false),
                    CompetencyRatingLevelId = table.Column<int>(nullable: false),
                    CompetencyLevelRequirementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyGroupsRatings", x => new { x.CompetencyId, x.CompetencyRatingLevelId, x.CompetencyLevelRequirementId });
                    table.ForeignKey(
                        name: "FK_CompetencyGroupsRatings_Competencys_CompetencyId",
                        column: x => x.CompetencyId,
                        principalTable: "Competencys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetencyGroupsRatings_CompetencyLevelRequirements_CompetencyLevelRequirementId",
                        column: x => x.CompetencyLevelRequirementId,
                        principalTable: "CompetencyLevelRequirements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetencyGroupsRatings_CompetencyRatingLevels_CompetencyRatingLevelId",
                        column: x => x.CompetencyRatingLevelId,
                        principalTable: "CompetencyRatingLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyGroupsTypes",
                columns: table => new
                {
                    CompetencyId = table.Column<int>(nullable: false),
                    CompetencyTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyGroupsTypes", x => new { x.CompetencyId, x.CompetencyTypeId });
                    table.ForeignKey(
                        name: "FK_CompetencyGroupsTypes_Competencys_CompetencyId",
                        column: x => x.CompetencyId,
                        principalTable: "Competencys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetencyGroupsTypes_CompetencyTypes_CompetencyTypeId",
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
                        name: "FK_JobGroupPositions_JobCategorys_JobCategoryId",
                        column: x => x.JobCategoryId,
                        principalTable: "JobCategorys",
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
                name: "JobPositionCompetencys",
                columns: table => new
                {
                    JobPositionId = table.Column<int>(nullable: false),
                    CompetencyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPositionCompetencys", x => new { x.JobPositionId, x.CompetencyId });
                    table.ForeignKey(
                        name: "FK_JobPositionCompetencys_Competencys_CompetencyId",
                        column: x => x.CompetencyId,
                        principalTable: "Competencys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPositionCompetencys_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobRolesPositionCompetencys",
                columns: table => new
                {
                    JobGroupId = table.Column<int>(nullable: false),
                    JobGroupLevelId = table.Column<int>(nullable: false),
                    JobPositionId = table.Column<int>(nullable: false),
                    CompetencyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRolesPositionCompetencys", x => new { x.JobGroupId, x.JobGroupLevelId, x.JobPositionId, x.CompetencyId });
                    table.ForeignKey(
                        name: "FK_JobRolesPositionCompetencys_Competencys_CompetencyId",
                        column: x => x.CompetencyId,
                        principalTable: "Competencys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolesPositionCompetencys_JobGroups_JobGroupId",
                        column: x => x.JobGroupId,
                        principalTable: "JobGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolesPositionCompetencys_JobGroupLevels_JobGroupLevelId",
                        column: x => x.JobGroupLevelId,
                        principalTable: "JobGroupLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolesPositionCompetencys_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompetencyGroupsRatings_CompetencyLevelRequirementId",
                table: "CompetencyGroupsRatings",
                column: "CompetencyLevelRequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetencyGroupsRatings_CompetencyRatingLevelId",
                table: "CompetencyGroupsRatings",
                column: "CompetencyRatingLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetencyGroupsTypes_CompetencyTypeId",
                table: "CompetencyGroupsTypes",
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
                name: "IX_JobPositionCompetencys_CompetencyId",
                table: "JobPositionCompetencys",
                column: "CompetencyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRoles_JobGroupLevelId",
                table: "JobRoles",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolesPositionCompetencys_CompetencyId",
                table: "JobRolesPositionCompetencys",
                column: "CompetencyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolesPositionCompetencys_JobGroupLevelId",
                table: "JobRolesPositionCompetencys",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolesPositionCompetencys_JobPositionId",
                table: "JobRolesPositionCompetencys",
                column: "JobPositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompetencyGroupsRatings");

            migrationBuilder.DropTable(
                name: "CompetencyGroupsTypes");

            migrationBuilder.DropTable(
                name: "JobGroupPositions");

            migrationBuilder.DropTable(
                name: "JobPositionCompetencys");

            migrationBuilder.DropTable(
                name: "JobRoles");

            migrationBuilder.DropTable(
                name: "JobRolesPositionCompetencys");

            migrationBuilder.DropTable(
                name: "CompetencyLevelRequirements");

            migrationBuilder.DropTable(
                name: "CompetencyRatingLevels");

            migrationBuilder.DropTable(
                name: "CompetencyTypes");

            migrationBuilder.DropTable(
                name: "JobCategorys");

            migrationBuilder.DropTable(
                name: "JobKeyTaskPerLevels");

            migrationBuilder.DropTable(
                name: "JobLocationRegions");

            migrationBuilder.DropTable(
                name: "Competencys");

            migrationBuilder.DropTable(
                name: "JobGroups");

            migrationBuilder.DropTable(
                name: "JobGroupLevels");

            migrationBuilder.DropTable(
                name: "JobPositions");
        }
    }
}
