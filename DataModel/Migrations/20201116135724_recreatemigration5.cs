using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class recreatemigration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_JobRolePositionCompetencyRatings",
                table: "JobRolePositionCompetencyRatings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobRolePositionCompetencies",
                table: "JobRolePositionCompetencies");

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 1, 2, 2, 1 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 1, 2, 2, 2 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 1, 3, 1, 1 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 1, 3, 1, 2 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 1, 3, 1, 3 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 2, 4, 2 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 2, 4, 3 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 2, 4, 4 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 3, 3, 2 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 3, 3, 3 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 3, 3, 4 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 3, 3, 6 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 2, 6, 1 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 2, 6, 2 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 2, 6, 6 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 3, 5, 1 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 3, 5, 2 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 3, 5, 4 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 3, 5, 6 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencyRatings",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 1, 2, 2, 1 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencyRatings",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 1, 2, 2, 2 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencyRatings",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 1, 3, 1, 1 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencyRatings",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 1, 3, 1, 2 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencyRatings",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 1, 3, 1, 3 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencyRatings",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 2, 4, 2 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencyRatings",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 2, 4, 3 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencyRatings",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 2, 4, 4 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencyRatings",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 3, 3, 2 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencyRatings",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 3, 3, 3 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencyRatings",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 3, 3, 4 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencyRatings",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 3, 3, 6 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencyRatings",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 3, 5, 1 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencyRatings",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 3, 5, 2 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencyRatings",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 3, 5, 4 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencyRatings",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 3, 5, 6 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencyRatings",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 3, 6, 1 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencyRatings",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 3, 6, 2 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencyRatings",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 3, 6, 6 });

            migrationBuilder.AddColumn<int>(
                name: "CompetencyTypeId",
                table: "JobRolePositionCompetencyRatings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompetencyTypeId",
                table: "JobRolePositionCompetencies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompetencyTypeId",
                table: "JobPositionCompetencies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobRolePositionCompetencyRatings",
                table: "JobRolePositionCompetencyRatings",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId", "CompetencyTypeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobRolePositionCompetencies",
                table: "JobRolePositionCompetencies",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId", "CompetencyTypeId" });

            migrationBuilder.UpdateData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 1, 1 },
                column: "CompetencyTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 1, 2 },
                column: "CompetencyTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 1, 3 },
                column: "CompetencyTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 1 },
                column: "CompetencyTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 2 },
                column: "CompetencyTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 2 },
                column: "CompetencyTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 3 },
                column: "CompetencyTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 4 },
                column: "CompetencyTypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 6 },
                column: "CompetencyTypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 4, 2 },
                column: "CompetencyTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 4, 3 },
                column: "CompetencyTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 4, 4 },
                column: "CompetencyTypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 5, 1 },
                column: "CompetencyTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 5, 2 },
                column: "CompetencyTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 6, 1 },
                column: "CompetencyTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 6, 2 },
                column: "CompetencyTypeId",
                value: 2);

            migrationBuilder.InsertData(
                table: "JobRolePositionCompetencies",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId", "CompetencyTypeId" },
                values: new object[,]
                {
                    { 3, 2, 6, 6, 3 },
                    { 1, 3, 1, 1, 1 },
                    { 3, 2, 6, 1, 1 },
                    { 3, 3, 5, 4, 3 },
                    { 3, 3, 5, 2, 2 },
                    { 3, 3, 5, 1, 1 },
                    { 2, 2, 4, 4, 3 },
                    { 2, 2, 4, 3, 2 },
                    { 2, 2, 4, 2, 2 },
                    { 2, 3, 3, 6, 3 },
                    { 3, 3, 5, 6, 3 },
                    { 2, 3, 3, 4, 3 },
                    { 2, 3, 3, 3, 2 },
                    { 2, 3, 3, 2, 2 },
                    { 1, 2, 2, 2, 2 },
                    { 1, 2, 2, 1, 1 },
                    { 1, 3, 1, 3, 2 },
                    { 1, 3, 1, 2, 2 },
                    { 3, 2, 6, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "JobRolePositionCompetencyRatings",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId", "CompetencyTypeId", "CompetencyLevelRequirementId", "CompetencyRatingLevelId" },
                values: new object[,]
                {
                    { 3, 3, 6, 6, 3, 3, 3 },
                    { 3, 3, 6, 1, 1, 3, 3 },
                    { 3, 3, 5, 6, 3, 4, 4 },
                    { 1, 3, 1, 1, 1, 1, 1 },
                    { 1, 3, 1, 2, 2, 2, 2 },
                    { 1, 3, 1, 3, 2, 3, 3 },
                    { 1, 2, 2, 1, 1, 4, 4 },
                    { 1, 2, 2, 2, 2, 5, 5 },
                    { 2, 3, 3, 2, 2, 1, 1 },
                    { 3, 3, 6, 2, 2, 4, 4 },
                    { 2, 3, 3, 3, 2, 2, 2 },
                    { 2, 2, 4, 2, 2, 5, 5 },
                    { 2, 2, 4, 3, 2, 1, 1 },
                    { 2, 2, 4, 4, 3, 2, 2 },
                    { 3, 3, 5, 1, 1, 4, 4 },
                    { 3, 3, 5, 2, 2, 4, 4 },
                    { 3, 3, 5, 4, 3, 5, 5 },
                    { 2, 3, 3, 6, 3, 4, 4 },
                    { 2, 3, 3, 4, 3, 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencyRatings_CompetencyTypeId",
                table: "JobRolePositionCompetencyRatings",
                column: "CompetencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencies_CompetencyTypeId",
                table: "JobRolePositionCompetencies",
                column: "CompetencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPositionCompetencies_CompetencyTypeId",
                table: "JobPositionCompetencies",
                column: "CompetencyTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPositionCompetencies_CompetencyTypes_CompetencyTypeId",
                table: "JobPositionCompetencies",
                column: "CompetencyTypeId",
                principalTable: "CompetencyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobRolePositionCompetencies_CompetencyTypes_CompetencyTypeId",
                table: "JobRolePositionCompetencies",
                column: "CompetencyTypeId",
                principalTable: "CompetencyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobRolePositionCompetencyRatings_CompetencyTypes_CompetencyTypeId",
                table: "JobRolePositionCompetencyRatings",
                column: "CompetencyTypeId",
                principalTable: "CompetencyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPositionCompetencies_CompetencyTypes_CompetencyTypeId",
                table: "JobPositionCompetencies");

            migrationBuilder.DropForeignKey(
                name: "FK_JobRolePositionCompetencies_CompetencyTypes_CompetencyTypeId",
                table: "JobRolePositionCompetencies");

            migrationBuilder.DropForeignKey(
                name: "FK_JobRolePositionCompetencyRatings_CompetencyTypes_CompetencyTypeId",
                table: "JobRolePositionCompetencyRatings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobRolePositionCompetencyRatings",
                table: "JobRolePositionCompetencyRatings");

            migrationBuilder.DropIndex(
                name: "IX_JobRolePositionCompetencyRatings_CompetencyTypeId",
                table: "JobRolePositionCompetencyRatings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobRolePositionCompetencies",
                table: "JobRolePositionCompetencies");

            migrationBuilder.DropIndex(
                name: "IX_JobRolePositionCompetencies_CompetencyTypeId",
                table: "JobRolePositionCompetencies");

            migrationBuilder.DropIndex(
                name: "IX_JobPositionCompetencies_CompetencyTypeId",
                table: "JobPositionCompetencies");

            migrationBuilder.DropColumn(
                name: "CompetencyTypeId",
                table: "JobRolePositionCompetencyRatings");

            migrationBuilder.DropColumn(
                name: "CompetencyTypeId",
                table: "JobRolePositionCompetencies");

            migrationBuilder.DropColumn(
                name: "CompetencyTypeId",
                table: "JobPositionCompetencies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobRolePositionCompetencyRatings",
                table: "JobRolePositionCompetencyRatings",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobRolePositionCompetencies",
                table: "JobRolePositionCompetencies",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" });
        }
    }
}
