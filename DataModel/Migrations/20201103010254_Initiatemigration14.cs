using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class Initiatemigration14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "JobGroupLevels");

            migrationBuilder.AddColumn<string>(
                name: "LevelValue",
                table: "JobGroupLevels",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "JobGroupLevels",
                keyColumn: "Id",
                keyValue: 1,
                column: "LevelValue",
                value: "01");

            migrationBuilder.UpdateData(
                table: "JobGroupLevels",
                keyColumn: "Id",
                keyValue: 2,
                column: "LevelValue",
                value: "02");

            migrationBuilder.UpdateData(
                table: "JobGroupLevels",
                keyColumn: "Id",
                keyValue: 3,
                column: "LevelValue",
                value: "03");

            migrationBuilder.InsertData(
                table: "JobRoles",
                columns: new[] { "JobGroupId", "JobGroupLevelId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 3 },
                    { 3, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobRoles",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "JobRoles",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "JobRoles",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "JobRoles",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DropColumn(
                name: "LevelValue",
                table: "JobGroupLevels");

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "JobGroupLevels",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "JobGroupLevels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Value",
                value: "01");

            migrationBuilder.UpdateData(
                table: "JobGroupLevels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Value",
                value: "02");

            migrationBuilder.UpdateData(
                table: "JobGroupLevels",
                keyColumn: "Id",
                keyValue: 3,
                column: "Value",
                value: "03");
        }
    }
}
