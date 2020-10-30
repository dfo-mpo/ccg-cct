using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class initial9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassificationName",
                table: "JobGroups");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "JobGroups",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "CompetencyRatingLevels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "JobGroups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "GT");

            migrationBuilder.UpdateData(
                table: "JobGroups",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "PG");

            migrationBuilder.UpdateData(
                table: "JobGroups",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "SO-MAO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "JobGroups");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "CompetencyRatingLevels");

            migrationBuilder.AddColumn<string>(
                name: "ClassificationName",
                table: "JobGroups",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "JobGroups",
                keyColumn: "Id",
                keyValue: 1,
                column: "ClassificationName",
                value: "GT");

            migrationBuilder.UpdateData(
                table: "JobGroups",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClassificationName",
                value: "PG");

            migrationBuilder.UpdateData(
                table: "JobGroups",
                keyColumn: "Id",
                keyValue: 3,
                column: "ClassificationName",
                value: "SO-MAO");
        }
    }
}
