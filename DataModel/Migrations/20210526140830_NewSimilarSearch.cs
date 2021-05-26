using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class NewSimilarSearch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubJobGroups_JobGroups_JobGroupId",
                table: "SubJobGroups");

            migrationBuilder.DropIndex(
                name: "IX_SubJobGroups_JobGroupId",
                table: "SubJobGroups");

            migrationBuilder.DropColumn(
                name: "JobGroupId",
                table: "SubJobGroups");

            migrationBuilder.AlterColumn<string>(
                name: "SubCode",
                table: "SubJobGroups",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.CreateTable(
                name: "SimilarJobGroupSearches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobGroup = table.Column<string>(maxLength: 2500, nullable: true),
                    SubJobGroup = table.Column<string>(maxLength: 2500, nullable: true),
                    Level = table.Column<int>(nullable: false),
                    HundredPercentResult = table.Column<string>(maxLength: 2500, nullable: true),
                    NineteenPercentResult = table.Column<string>(maxLength: 2500, nullable: true),
                    HeighteenPercentResult = table.Column<string>(maxLength: 2500, nullable: true),
                    SeventeenPercentResult = table.Column<string>(maxLength: 2500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimilarJobGroupSearches", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SimilarJobGroupSearches");

            migrationBuilder.AlterColumn<string>(
                name: "SubCode",
                table: "SubJobGroups",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobGroupId",
                table: "SubJobGroups",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubJobGroups_JobGroupId",
                table: "SubJobGroups",
                column: "JobGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubJobGroups_JobGroups_JobGroupId",
                table: "SubJobGroups",
                column: "JobGroupId",
                principalTable: "JobGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
