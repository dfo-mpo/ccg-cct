using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class PositionDesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PositionDescEng",
                table: "JobPositions",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PositionDescFre",
                table: "JobPositions",
                maxLength: 8000,
                nullable: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PositionDescEng",
                table: "JobPositions");

            migrationBuilder.DropColumn(
                name: "PositionDescFre",
                table: "JobPositions");

        }
    }
}
