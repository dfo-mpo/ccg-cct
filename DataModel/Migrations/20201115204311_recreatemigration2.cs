using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class recreatemigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(maxLength: 250, nullable: false),
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
                    CompetencyId = table.Column<int>(nullable: false)
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
                    CompetencyRatingLevelId = table.Column<int>(nullable: false),
                    CompetencyLevelRequirementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRolePositionCompetencyRatings", x => new { x.JobGroupId, x.JobGroupLevelId, x.JobPositionId, x.CompetencyId });
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
                name: "CompetencyTypes");

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
                name: "JobPositions");

            migrationBuilder.DropTable(
                name: "JobGroups");

            migrationBuilder.DropTable(
                name: "JobGroupLevels");
        }
    }
}
