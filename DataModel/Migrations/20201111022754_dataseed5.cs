using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class dataseed5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificates_Competencies_CompetencyId",
                table: "Certificates");

            migrationBuilder.DropForeignKey(
                name: "FK_JobRolesPositionCompetencies_Competencies_CompetencyId",
                table: "JobRolesPositionCompetencies");

            migrationBuilder.DropForeignKey(
                name: "FK_JobRolesPositionCompetencies_JobGroups_JobGroupId",
                table: "JobRolesPositionCompetencies");

            migrationBuilder.DropForeignKey(
                name: "FK_JobRolesPositionCompetencies_JobGroupLevels_JobGroupLevelId",
                table: "JobRolesPositionCompetencies");

            migrationBuilder.DropForeignKey(
                name: "FK_JobRolesPositionCompetencies_JobPositions_JobPositionId",
                table: "JobRolesPositionCompetencies");

            migrationBuilder.DropIndex(
                name: "IX_Certificates_Id",
                table: "Certificates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobRolesPositionCompetencies",
                table: "JobRolesPositionCompetencies");

            migrationBuilder.DeleteData(
                table: "JobGroupPositions",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobCategoryId", "JobPositionId", "JobKeyTaskPerLevelId", "JobLocationRegionId" },
                keyValues: new object[] { 1, 1, 1, 2, 1, 1 });

            migrationBuilder.DeleteData(
                table: "JobGroupPositions",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobCategoryId", "JobPositionId", "JobKeyTaskPerLevelId", "JobLocationRegionId" },
                keyValues: new object[] { 3, 3, 2, 2, 4, 3 });

            migrationBuilder.DeleteData(
                table: "JobGroupPositions",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobCategoryId", "JobPositionId", "JobKeyTaskPerLevelId", "JobLocationRegionId" },
                keyValues: new object[] { 3, 3, 2, 2, 4, 4 });

            migrationBuilder.DropColumn(
                name: "DescEng",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "DescFre",
                table: "Certificates");

            migrationBuilder.RenameTable(
                name: "JobRolesPositionCompetencies",
                newName: "JobRolePositionCompetencies");

            migrationBuilder.RenameIndex(
                name: "IX_JobRolesPositionCompetencies_JobPositionId",
                table: "JobRolePositionCompetencies",
                newName: "IX_JobRolePositionCompetencies_JobPositionId");

            migrationBuilder.RenameIndex(
                name: "IX_JobRolesPositionCompetencies_JobGroupLevelId",
                table: "JobRolePositionCompetencies",
                newName: "IX_JobRolePositionCompetencies_JobGroupLevelId");

            migrationBuilder.RenameIndex(
                name: "IX_JobRolesPositionCompetencies_CompetencyId",
                table: "JobRolePositionCompetencies",
                newName: "IX_JobRolePositionCompetencies_CompetencyId");

            migrationBuilder.AddColumn<string>(
                name: "DescEng",
                table: "Competencies",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescFre",
                table: "Competencies",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "CompetencyId",
                table: "Certificates",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobRolePositionCompetencies",
                table: "JobRolePositionCompetencies",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" });

            migrationBuilder.InsertData(
                table: "Competencies",
                columns: new[] { "Id", "DescEng", "DescFre", "NameEng", "NameFre" },
                values: new object[,]
                {
                    { 1, "lorem ipus", "lorem ipus", "Organizational Knowledge", "Connaissances organisationnelles" },
                    { 2, "lorem ipus", "lorem ipus", "Materiel and Supply Chain Management", "Matériel et chaîne d'approvisionnement Gestion" },
                    { 3, "lorem ipus", "lorem ipus", "Planning and Prioritizing", "Planification et établissement des priorités" },
                    { 4, "lorem ipus", "lorem ipus", "Life-Cycle Asset Management", "Gestion du cycle de vie des actifs" },
                    { 5, "lorem ipus", "lorem ipus", "Inventory Management Systems", "Gestion du cycle de vie des actifs" },
                    { 6, "lorem ipus", "lorem ipus", "Master 150 GT", "Master 150 GT" },
                    { 7, "lorem ipus", "lorem ipus", "Master 1700 GT", "Master 1700 GT" }
                });

            migrationBuilder.InsertData(
                table: "CompetencyRatingLevels",
                columns: new[] { "Id", "DescEng", "DescFre", "NameEng", "NameFre", "Value" },
                values: new object[,]
                {
                    { 4, "Lorem ipsumEng", "Lorem ipsumFre", "Advanced", "Niveau avancé", 4 },
                    { 3, "Lorem ipsumEng", "Lorem ipsumFra", "Intermediate", "Niveau intermediaire", 3 },
                    { 5, "Lorem ipsumEng", "Lorem ipsumFre", "Expert", "Niveau expert", 5 },
                    { 1, "Lorem ipsumEng", "Lorem ipsumFra", "Fundamental Awareness", "activité fondamentale de sensibilisation", 1 },
                    { 2, "Lorem ipsumEng", "Lorem ipsumFra", "Novice", "Niveau debutant(e)", 2 }
                });

            migrationBuilder.InsertData(
                table: "CompetencyTypes",
                columns: new[] { "Id", "NameEng", "NameFre" },
                values: new object[,]
                {
                    { 1, "Knowledge Elements", "Éléments de connaissance" },
                    { 2, "Technical Elements", "Éléments techniques" },
                    { 3, "Behavioural Elements", "Éléments comportementaux" },
                    { 4, "Certificates", "Certificats" }
                });

            migrationBuilder.InsertData(
                table: "JobGroupPositions",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobCategoryId", "JobPositionId", "JobKeyTaskPerLevelId", "JobLocationRegionId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, 1 },
                    { 3, 3, 2, 3, 4, 3 },
                    { 3, 3, 2, 4, 4, 4 }
                });

            migrationBuilder.UpdateData(
                table: "JobKeyTaskPerLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DescEng", "DescFre" },
                values: new object[] { "Lorem ipsumEng", "Lorem ipsumFra" });

            migrationBuilder.UpdateData(
                table: "JobKeyTaskPerLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DescEng", "DescFre" },
                values: new object[] { "Lorem ipsumEng", "Lorem ipsumFra" });

            migrationBuilder.UpdateData(
                table: "JobKeyTaskPerLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DescEng", "DescFre" },
                values: new object[] { "Lorem ipsumEng", "Lorem ipsumFra" });

            migrationBuilder.UpdateData(
                table: "JobKeyTaskPerLevels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DescEng", "DescFre" },
                values: new object[] { "Lorem ipsumEng", "Lorem ipsumFra" });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "CompetencyId", "RequireIndicatorEng", "RequireIndicatorFre" },
                values: new object[,]
                {
                    { 1, 4, "lorem ipsum", "lorem ipsum" },
                    { 2, 4, "lorem ipsum", "lorem ipsum" }
                });

            migrationBuilder.InsertData(
                table: "CompetencyTypeGroups",
                columns: new[] { "CompetencyId", "CompetencyTypeId" },
                values: new object[,]
                {
                    { 7, 4 },
                    { 5, 3 },
                    { 4, 3 },
                    { 3, 2 },
                    { 2, 2 },
                    { 1, 1 },
                    { 6, 4 }
                });

            migrationBuilder.InsertData(
                table: "JobPositionCompetencies",
                columns: new[] { "JobPositionId", "CompetencyId" },
                values: new object[,]
                {
                    { 4, 7 },
                    { 3, 7 },
                    { 1, 6 },
                    { 4, 5 },
                    { 2, 5 },
                    { 3, 4 },
                    { 2, 4 },
                    { 1, 3 },
                    { 1, 2 },
                    { 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "JobRolePositionCompetencies",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                values: new object[,]
                {
                    { 3, 2, 3, 4 },
                    { 2, 3, 2, 5 },
                    { 3, 2, 4, 5 },
                    { 2, 3, 2, 4 },
                    { 3, 2, 3, 7 },
                    { 1, 1, 1, 3 },
                    { 1, 1, 1, 2 },
                    { 1, 1, 1, 1 },
                    { 3, 2, 4, 4 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Certificates_Competencies_CompetencyId",
                table: "Certificates",
                column: "CompetencyId",
                principalTable: "Competencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobRolePositionCompetencies_Competencies_CompetencyId",
                table: "JobRolePositionCompetencies",
                column: "CompetencyId",
                principalTable: "Competencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobRolePositionCompetencies_JobGroups_JobGroupId",
                table: "JobRolePositionCompetencies",
                column: "JobGroupId",
                principalTable: "JobGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobRolePositionCompetencies_JobGroupLevels_JobGroupLevelId",
                table: "JobRolePositionCompetencies",
                column: "JobGroupLevelId",
                principalTable: "JobGroupLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobRolePositionCompetencies_JobPositions_JobPositionId",
                table: "JobRolePositionCompetencies",
                column: "JobPositionId",
                principalTable: "JobPositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificates_Competencies_CompetencyId",
                table: "Certificates");

            migrationBuilder.DropForeignKey(
                name: "FK_JobRolePositionCompetencies_Competencies_CompetencyId",
                table: "JobRolePositionCompetencies");

            migrationBuilder.DropForeignKey(
                name: "FK_JobRolePositionCompetencies_JobGroups_JobGroupId",
                table: "JobRolePositionCompetencies");

            migrationBuilder.DropForeignKey(
                name: "FK_JobRolePositionCompetencies_JobGroupLevels_JobGroupLevelId",
                table: "JobRolePositionCompetencies");

            migrationBuilder.DropForeignKey(
                name: "FK_JobRolePositionCompetencies_JobPositions_JobPositionId",
                table: "JobRolePositionCompetencies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobRolePositionCompetencies",
                table: "JobRolePositionCompetencies");

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CompetencyRatingLevels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CompetencyRatingLevels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CompetencyRatingLevels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CompetencyRatingLevels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CompetencyRatingLevels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CompetencyTypeGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyTypeId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CompetencyTypeGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyTypeId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CompetencyTypeGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyTypeId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CompetencyTypeGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyTypeId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "CompetencyTypeGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyTypeId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "CompetencyTypeGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyTypeId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "CompetencyTypeGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyTypeId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "JobGroupPositions",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobCategoryId", "JobPositionId", "JobKeyTaskPerLevelId", "JobLocationRegionId" },
                keyValues: new object[] { 1, 1, 1, 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "JobGroupPositions",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobCategoryId", "JobPositionId", "JobKeyTaskPerLevelId", "JobLocationRegionId" },
                keyValues: new object[] { 3, 3, 2, 3, 4, 3 });

            migrationBuilder.DeleteData(
                table: "JobGroupPositions",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobCategoryId", "JobPositionId", "JobKeyTaskPerLevelId", "JobLocationRegionId" },
                keyValues: new object[] { 3, 3, 2, 4, 4, 4 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 1, 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 1, 1, 1, 2 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 1, 1, 1, 3 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 3, 2, 4 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 3, 2, 5 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 2, 3, 4 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 2, 3, 7 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 2, 4, 4 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCompetencies",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 2, 4, 5 });

            migrationBuilder.DeleteData(
                table: "Competencies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Competencies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Competencies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Competencies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Competencies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Competencies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Competencies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CompetencyTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CompetencyTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CompetencyTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CompetencyTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "DescEng",
                table: "Competencies");

            migrationBuilder.DropColumn(
                name: "DescFre",
                table: "Competencies");

            migrationBuilder.RenameTable(
                name: "JobRolePositionCompetencies",
                newName: "JobRolesPositionCompetencies");

            migrationBuilder.RenameIndex(
                name: "IX_JobRolePositionCompetencies_JobPositionId",
                table: "JobRolesPositionCompetencies",
                newName: "IX_JobRolesPositionCompetencies_JobPositionId");

            migrationBuilder.RenameIndex(
                name: "IX_JobRolePositionCompetencies_JobGroupLevelId",
                table: "JobRolesPositionCompetencies",
                newName: "IX_JobRolesPositionCompetencies_JobGroupLevelId");

            migrationBuilder.RenameIndex(
                name: "IX_JobRolePositionCompetencies_CompetencyId",
                table: "JobRolesPositionCompetencies",
                newName: "IX_JobRolesPositionCompetencies_CompetencyId");

            migrationBuilder.AlterColumn<int>(
                name: "CompetencyId",
                table: "Certificates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "DescEng",
                table: "Certificates",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescFre",
                table: "Certificates",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobRolesPositionCompetencies",
                table: "JobRolesPositionCompetencies",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" });

            migrationBuilder.InsertData(
                table: "JobGroupPositions",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobCategoryId", "JobPositionId", "JobKeyTaskPerLevelId", "JobLocationRegionId" },
                values: new object[,]
                {
                    { 1, 1, 1, 2, 1, 1 },
                    { 3, 3, 2, 2, 4, 3 },
                    { 3, 3, 2, 2, 4, 4 }
                });

            migrationBuilder.UpdateData(
                table: "JobKeyTaskPerLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DescEng", "DescFre" },
                values: new object[] { "It is a long established fact that a reader will be distracted", "Lorem ipsum dolor sit amet, consectetur adipiscing elit" });

            migrationBuilder.UpdateData(
                table: "JobKeyTaskPerLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DescEng", "DescFre" },
                values: new object[] { "or avoids pleasure itself, because it is pleasure", "Nemo enim ipsam voluptatem quia voluptas sit" });

            migrationBuilder.UpdateData(
                table: "JobKeyTaskPerLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DescEng", "DescFre" },
                values: new object[] { " but because occasionally circumstances occur in which toil and pain can procure", "dolore magnam aliquam quaerat voluptatem." });

            migrationBuilder.UpdateData(
                table: "JobKeyTaskPerLevels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DescEng", "DescFre" },
                values: new object[] { "To take a trivial example", "Nam libero tempore, cum soluta nobis est eligendi" });

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_Id",
                table: "Certificates",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Certificates_Competencies_CompetencyId",
                table: "Certificates",
                column: "CompetencyId",
                principalTable: "Competencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobRolesPositionCompetencies_Competencies_CompetencyId",
                table: "JobRolesPositionCompetencies",
                column: "CompetencyId",
                principalTable: "Competencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobRolesPositionCompetencies_JobGroups_JobGroupId",
                table: "JobRolesPositionCompetencies",
                column: "JobGroupId",
                principalTable: "JobGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobRolesPositionCompetencies_JobGroupLevels_JobGroupLevelId",
                table: "JobRolesPositionCompetencies",
                column: "JobGroupLevelId",
                principalTable: "JobGroupLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobRolesPositionCompetencies_JobPositions_JobPositionId",
                table: "JobRolesPositionCompetencies",
                column: "JobPositionId",
                principalTable: "JobPositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
