using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class tablemodifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobGroupPosition_JobGroup_JobGroupId",
                table: "JobGroupPosition");

            migrationBuilder.DropIndex(
                name: "IX_JobGroupPosition_JobGroupId",
                table: "JobGroupPosition");

            migrationBuilder.DropColumn(
                name: "JobGroupId",
                table: "JobGroupPosition");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobGroupId",
                table: "JobGroupPosition",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobGroupPosition_JobGroupId",
                table: "JobGroupPosition",
                column: "JobGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobGroupPosition_JobGroup_JobGroupId",
                table: "JobGroupPosition",
                column: "JobGroupId",
                principalTable: "JobGroup",
                principalColumn: "JobGroupId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
