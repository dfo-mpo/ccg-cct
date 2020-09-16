using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AuditDate = table.Column<DateTime>(nullable: false),
                    AuditUser = table.Column<string>(nullable: true),
                    AuditData = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(nullable: false),
                    DescEng = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    DescFre = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Message = table.Column<string>(nullable: true),
                    MessageTemplate = table.Column<string>(nullable: true),
                    Level = table.Column<string>(maxLength: 128, nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    Exception = table.Column<string>(nullable: true),
                    LogEvent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Privileges",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    SortOrder = table.Column<short>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DescEng = table.Column<string>(nullable: true),
                    DescFre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Privileges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    SortOrder = table.Column<short>(nullable: false, defaultValue: (short)0),
                    IsActive = table.Column<bool>(nullable: false),
                    DescEng = table.Column<string>(nullable: true),
                    DescFre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    SortOrder = table.Column<short>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DescEng = table.Column<string>(nullable: true),
                    DescFre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemRolePrivileges",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SystemRoleId = table.Column<Guid>(nullable: false),
                    PrivilegeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemRolePrivileges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemRolePrivileges_Privileges_PrivilegeId",
                        column: x => x.PrivilegeId,
                        principalTable: "Privileges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SystemRolePrivileges_SystemRoles_SystemRoleId",
                        column: x => x.SystemRoleId,
                        principalTable: "SystemRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NameIdentifier = table.Column<string>(maxLength: 50, nullable: true),
                    SystemRoleId = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    LastLoginDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_SystemRoles_SystemRoleId",
                        column: x => x.SystemRoleId,
                        principalTable: "SystemRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Type = table.Column<string>(maxLength: 100, nullable: false),
                    Value = table.Column<string>(maxLength: 250, nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Privileges",
                columns: new[] { "Id", "Code", "DescEng", "DescFre", "IsActive", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("afe32f00-b6a6-4caa-b452-30e1240e34c0"), "Auth_User_View", "View users", "Afficher les utilisateurs", true, (short)0 },
                    { new Guid("3a76dde2-b837-450c-a6b3-eda358720bbd"), "Auth_User_Manage", "Manage users", "Gérer les utilisateurs", true, (short)0 },
                    { new Guid("c3e4261f-66d9-4a22-b589-3cdd5c17c12d"), "Auth_Assign_View", "View role privileges", "Afficher les privilèges de rôle", true, (short)0 },
                    { new Guid("b78ecf44-75b6-4058-b9fe-c4ae4a5b1baa"), "Auth_Assign_Manage", "Manage role privileges", "Gérer les privilèges de rôles", true, (short)0 },
                    { new Guid("664feb76-8bcf-445a-a70d-8a31ea9c9954"), "Auth_Role_View", "View roles", "Afficher les rôles", true, (short)0 },
                    { new Guid("cfea2a8f-40fd-4b8e-b7c2-062cf42745c6"), "Auth_Role_Manage", "Manage roles", "Gérer les rôles", true, (short)0 },
                    { new Guid("3bf1919a-c5d5-46aa-ba99-70dd1f73d8d4"), "Auth_Privilege_View", "View Privileges", "Afficher les privilèges", true, (short)0 },
                    { new Guid("6d823333-1c28-4ba5-8544-e0004d1bd272"), "Code_View", "View Code Tables", "Afficher les tableaux de codes", true, (short)0 }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Code", "DescEng", "DescFre", "IsActive" },
                values: new object[] { new Guid("fd988731-d699-40d1-a860-5619f331727e"), "A", "Active", "Actifs", true });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Code", "DescEng", "DescFre", "IsActive" },
                values: new object[] { new Guid("904d49f7-227e-4650-aba0-47b25d54c41b"), "O", "Ongoing monitoring/assessment required to determine way forward", "Un suivi et une évaluation continus sont nécessaires pour déterminer la voie à suivre.", true });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Code", "DescEng", "DescFre", "IsActive" },
                values: new object[] { new Guid("f75ef970-7785-446f-a125-b52c0f71ef85"), "TA", "Technical assessment/remediation in progress", "Évaluation technique/assainissement en cours", true });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Code", "DescEng", "DescFre", "IsActive" },
                values: new object[] { new Guid("b91082f4-21d0-4640-82e4-143ab566ec3f"), "OTH", "Other", "Autre", true });

            migrationBuilder.InsertData(
                table: "SystemRoles",
                columns: new[] { "Id", "Code", "DescEng", "DescFre", "IsActive", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("3d9aa27f-9ee9-4246-97ab-0ad6e696ffc5"), "Guest", "Guest", "Invité", true, (short)0 },
                    { new Guid("3bdce629-ffa6-4973-9be1-e7c3ba6d7cf4"), "User", "User", "Utilisateur", true, (short)0 },
                    { new Guid("4717fc67-e3cb-4d1c-b3d1-72ec3b5ad655"), "Admin", "Administrator", "Administrateur", true, (short)0 }
                });

            migrationBuilder.InsertData(
                table: "SystemRolePrivileges",
                columns: new[] { "Id", "PrivilegeId", "SystemRoleId" },
                values: new object[,]
                {
                    { new Guid("3ebf58b3-578e-4fc6-98ec-b5e7ff907d33"), new Guid("afe32f00-b6a6-4caa-b452-30e1240e34c0"), new Guid("3d9aa27f-9ee9-4246-97ab-0ad6e696ffc5") },
                    { new Guid("2be4f8e5-1845-4b9a-be05-f67a40300a3f"), new Guid("3a76dde2-b837-450c-a6b3-eda358720bbd"), new Guid("3d9aa27f-9ee9-4246-97ab-0ad6e696ffc5") },
                    { new Guid("36f15ab8-12d3-4728-946f-e06bd70ea635"), new Guid("c3e4261f-66d9-4a22-b589-3cdd5c17c12d"), new Guid("3d9aa27f-9ee9-4246-97ab-0ad6e696ffc5") },
                    { new Guid("17ddaa13-4c28-422a-b32c-2b599641a876"), new Guid("b78ecf44-75b6-4058-b9fe-c4ae4a5b1baa"), new Guid("3d9aa27f-9ee9-4246-97ab-0ad6e696ffc5") },
                    { new Guid("6875db1c-d2c7-4d69-ad99-b21c6a996ee0"), new Guid("664feb76-8bcf-445a-a70d-8a31ea9c9954"), new Guid("3d9aa27f-9ee9-4246-97ab-0ad6e696ffc5") },
                    { new Guid("6cd0ae01-5e08-456e-98d7-fa694752ab7a"), new Guid("cfea2a8f-40fd-4b8e-b7c2-062cf42745c6"), new Guid("3d9aa27f-9ee9-4246-97ab-0ad6e696ffc5") },
                    { new Guid("daee098c-58e8-4473-b363-6e547319d40f"), new Guid("3bf1919a-c5d5-46aa-ba99-70dd1f73d8d4"), new Guid("3d9aa27f-9ee9-4246-97ab-0ad6e696ffc5") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Privileges_Code",
                table: "Privileges",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_Code",
                table: "Statuses",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_SystemRolePrivileges_PrivilegeId",
                table: "SystemRolePrivileges",
                column: "PrivilegeId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemRolePrivileges_SystemRoleId_PrivilegeId",
                table: "SystemRolePrivileges",
                columns: new[] { "SystemRoleId", "PrivilegeId" });

            migrationBuilder.CreateIndex(
                name: "IX_SystemRoles_Code",
                table: "SystemRoles",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_NameIdentifier",
                table: "Users",
                column: "NameIdentifier",
                unique: true,
                filter: "[NameIdentifier] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SystemRoleId",
                table: "Users",
                column: "SystemRoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLogs");

            migrationBuilder.DropTable(
                name: "Classifications");

            migrationBuilder.DropTable(
                name: "EventLogs");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "SystemRolePrivileges");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "Privileges");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "SystemRoles");
        }
    }
}
