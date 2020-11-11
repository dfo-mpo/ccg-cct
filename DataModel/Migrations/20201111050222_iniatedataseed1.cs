using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class iniatedataseed1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 3, 2, 5 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 2, 4, 4 });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompetencyId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CompetencyId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Competencies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "NameEng", "NameFre" },
                values: new object[] { "Master 1505 GT", "Master 1505 GT" });

            migrationBuilder.UpdateData(
                table: "Competencies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "NameEng", "NameFre" },
                values: new object[] { "Master 1500 GT", "Master 1500 GT" });

            migrationBuilder.InsertData(
                table: "CompetencyLevelRequirements",
                columns: new[] { "Id", "DescEng", "DescFre" },
                values: new object[,]
                {
                    { 1, "Lorem ipsumEng", "Lorem ipsumFre" },
                    { 2, "Lorem ipsumEng", "Lorem ipsumFre" },
                    { 3, "Lorem ipsumEng", "Lorem ipsumFre" },
                    { 4, "Lorem ipsumEng", "Lorem ipsumFre" },
                    { 5, "Lorem ipsumEng", "Lorem ipsumFre" }
                });

            migrationBuilder.UpdateData(
                table: "JobCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "ValueFre",
                value: "sur terre");

            migrationBuilder.InsertData(
                table: "JobRolePositionCompetencies",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                values: new object[,]
                {
                    { 2, 3, 1, 6 },
                    { 3, 2, 2, 5 },
                    { 3, 2, 4, 7 }
                });

            migrationBuilder.InsertData(
                table: "CompetencyRatingGroups",
                columns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 3, 5, 5 },
                    { 2, 5, 5 },
                    { 1, 5, 5 },
                    { 5, 4, 4 },
                    { 4, 4, 4 },
                    { 3, 4, 4 },
                    { 2, 4, 4 },
                    { 1, 4, 4 },
                    { 5, 3, 3 },
                    { 4, 3, 3 },
                    { 4, 5, 5 },
                    { 3, 3, 3 },
                    { 1, 3, 3 },
                    { 5, 2, 2 },
                    { 4, 2, 2 },
                    { 3, 2, 2 },
                    { 2, 2, 2 },
                    { 1, 2, 2 },
                    { 5, 1, 1 },
                    { 4, 1, 1 },
                    { 3, 1, 1 },
                    { 2, 1, 1 },
                    { 2, 3, 3 },
                    { 5, 5, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 1, 2, 2 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 1, 3, 3 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 1, 4, 4 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 1, 5, 5 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 2, 1, 1 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 2, 2, 2 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 2, 3, 3 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 2, 4, 4 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 2, 5, 5 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 3, 1, 1 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 3, 2, 2 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 3, 3, 3 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 3, 4, 4 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 3, 5, 5 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 4, 1, 1 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 4, 2, 2 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 4, 3, 3 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 4, 4, 4 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 4, 5, 5 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 5, 1, 1 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 5, 2, 2 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 5, 3, 3 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 5, 4, 4 });

            migrationBuilder.DeleteData(
                table: "CompetencyRatingGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                keyValues: new object[] { 5, 5, 5 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 3, 1, 6 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 2, 2, 5 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 2, 4, 7 });

            migrationBuilder.DeleteData(
                table: "CompetencyLevelRequirements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CompetencyLevelRequirements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CompetencyLevelRequirements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CompetencyLevelRequirements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CompetencyLevelRequirements",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompetencyId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CompetencyId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Competencies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "NameEng", "NameFre" },
                values: new object[] { "Master 150 GT", "Master 150 GT" });

            migrationBuilder.UpdateData(
                table: "Competencies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "NameEng", "NameFre" },
                values: new object[] { "Master 1700 GT", "Master 1700 GT" });

            migrationBuilder.UpdateData(
                table: "JobCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "ValueFre",
                value: "non maritime");

            migrationBuilder.InsertData(
                table: "JobRolePositionCompetencies",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                values: new object[,]
                {
                    { 2, 3, 2, 5 },
                    { 3, 2, 4, 4 }
                });
        }
    }
}
