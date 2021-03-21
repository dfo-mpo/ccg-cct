using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class InitialMigrationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_JobRolePositionCertificates",
                table: "JobRolePositionCertificates");

            migrationBuilder.AddColumn<int>(
                name: "CertificateDescriptionId",
                table: "JobRolePositionCertificates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CertificateDescriptionId",
                table: "Certificates",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobRolePositionCertificates",
                table: "JobRolePositionCertificates",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId", "CertificateDescriptionId" });

            migrationBuilder.CreateTable(
                name: "CertificateDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescEng = table.Column<string>(maxLength: 1000, nullable: true),
                    DescFre = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateDescriptions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCertificates_CertificateDescriptionId",
                table: "JobRolePositionCertificates",
                column: "CertificateDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_CertificateDescriptionId",
                table: "Certificates",
                column: "CertificateDescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Certificates_CertificateDescriptions_CertificateDescriptionId",
                table: "Certificates",
                column: "CertificateDescriptionId",
                principalTable: "CertificateDescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobRolePositionCertificates_CertificateDescriptions_CertificateDescriptionId",
                table: "JobRolePositionCertificates",
                column: "CertificateDescriptionId",
                principalTable: "CertificateDescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificates_CertificateDescriptions_CertificateDescriptionId",
                table: "Certificates");

            migrationBuilder.DropForeignKey(
                name: "FK_JobRolePositionCertificates_CertificateDescriptions_CertificateDescriptionId",
                table: "JobRolePositionCertificates");

            migrationBuilder.DropTable(
                name: "CertificateDescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobRolePositionCertificates",
                table: "JobRolePositionCertificates");

            migrationBuilder.DropIndex(
                name: "IX_JobRolePositionCertificates_CertificateDescriptionId",
                table: "JobRolePositionCertificates");

            migrationBuilder.DropIndex(
                name: "IX_Certificates_CertificateDescriptionId",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "CertificateDescriptionId",
                table: "JobRolePositionCertificates");

            migrationBuilder.DropColumn(
                name: "CertificateDescriptionId",
                table: "Certificates");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobRolePositionCertificates",
                table: "JobRolePositionCertificates",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId" });
        }
    }
}
