using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class recreatemigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "DescEng", "DescFre", "NameEng", "NameFre", "RequireIndicatorEng", "RequireIndicatorFre" },
                values: new object[,]
                {
                    { 1, "lorem ipsum", "lorem ipsum", "Master 1500 GT", "Master 1500 GT", "lorem ipsum", "lorem ipsum" },
                    { 2, "lorem ipsum", "lorem ipsum", "Master 1600A GT", "Master 1600A GT", "lorem ipsum", "lorem ipsum" },
                    { 3, "lorem ipsum", "lorem ipsum", "Z Alpha MDX", "Z Alpha MDX", "lorem ipsum", "lorem ipsum" },
                    { 4, "lorem ipsum", "lorem ipsum", "V Delta MKZ", "V Delta MKZ", "lorem ipsum", "lorem ipsum" },
                    { 5, "lorem ipsum", "lorem ipsum", "six Sigma", "six Sigma", "lorem ipsum", "lorem ipsum" },
                    { 6, "lorem ipsum", "lorem ipsum", "Gamma v9", "Gamma v9", "lorem ipsum", "lorem ipsum" }
                });

            migrationBuilder.InsertData(
                table: "Competencies",
                columns: new[] { "Id", "DescEng", "DescFre", "NameEng", "NameFre" },
                values: new object[,]
                {
                    { 5, "lorem ipus", "lorem ipus", "Inventory Management Systems", "Gestion du cycle de vie des actifs" },
                    { 4, "lorem ipus", "lorem ipus", "Life-Cycle Asset Management", "Gestion du cycle de vie des actifs" },
                    { 6, "lorem ipus", "lorem ipus", "Control and procurement", "Controlle et approvisionnement" },
                    { 2, "lorem ipus", "lorem ipus", "Materiel and Supply Chain Management", "Matériel et chaîne d'approvisionnement Gestion" },
                    { 1, "lorem ipus", "lorem ipus", "Organizational Knowledge", "Connaissances organisationnelles" },
                    { 3, "lorem ipus", "lorem ipus", "Planning and Prioritizing", "Planification et établissement des priorités" }
                });

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

            migrationBuilder.InsertData(
                table: "CompetencyRatingLevels",
                columns: new[] { "Id", "DescEng", "DescFre", "NameEng", "NameFre", "Value" },
                values: new object[,]
                {
                    { 5, "Lorem ipsumEng", "Lorem ipsumFre", "Expert", "Niveau expert", 5 },
                    { 1, "Lorem ipsumEng", "Lorem ipsumFra", "Fundamental Awareness", "activité fondamentale de sensibilisation", 1 },
                    { 2, "Lorem ipsumEng", "Lorem ipsumFra", "Novice", "Niveau debutant(e)", 2 },
                    { 3, "Lorem ipsumEng", "Lorem ipsumFra", "Intermediate", "Niveau intermediaire", 3 },
                    { 4, "Lorem ipsumEng", "Lorem ipsumFre", "Advanced", "Niveau avancé", 4 }
                });

            migrationBuilder.InsertData(
                table: "CompetencyTypes",
                columns: new[] { "Id", "NameEng", "NameFre" },
                values: new object[,]
                {
                    { 3, "Behavioural Elements", "Éléments comportementaux" },
                    { 2, "Technical Elements", "Éléments techniques" },
                    { 1, "Knowledge Elements", "Éléments de connaissance" }
                });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "Id", "ValueEng", "ValueFre" },
                values: new object[,]
                {
                    { 1, "Seagoing", "En mer" },
                    { 2, "non-seagoing", "sur terre" }
                });

            migrationBuilder.InsertData(
                table: "JobGroupLevels",
                columns: new[] { "Id", "LevelValue" },
                values: new object[,]
                {
                    { 1, "01" },
                    { 2, "02" },
                    { 3, "03" }
                });

            migrationBuilder.InsertData(
                table: "JobGroups",
                columns: new[] { "Id", "Code", "NameEng", "NameFre" },
                values: new object[,]
                {
                    { 1, "AS", "Admin. Services", "Admin. Services" },
                    { 2, "CS", "Admin. Services", "Services Admin" },
                    { 3, "GT", "General Technician", "Technicien General" }
                });

            migrationBuilder.InsertData(
                table: "JobKeyTaskPerLevels",
                columns: new[] { "Id", "DescEng", "DescFre" },
                values: new object[,]
                {
                    { 4, "Lorem ipsumEng", "Lorem ipsumFra" },
                    { 3, "Lorem ipsumEng", "Lorem ipsumFra" },
                    { 1, "Lorem ipsumEng", "Lorem ipsumFra" },
                    { 2, "Lorem ipsumEng", "Lorem ipsumFra" }
                });

            migrationBuilder.InsertData(
                table: "JobLocationRegions",
                columns: new[] { "Id", "NameEng", "NameFre" },
                values: new object[,]
                {
                    { 1, "Atlantic", "Quebec" },
                    { 2, "Western", "Ouest" },
                    { 3, "Arctic", "Artique" },
                    { 4, "National Headquarters", "siège national" }
                });

            migrationBuilder.InsertData(
                table: "JobPositions",
                columns: new[] { "Id", "TitleEng", "TitleFre" },
                values: new object[,]
                {
                    { 5, "cooker", "cuisiner" },
                    { 1, "Manager", "Gestionnaire" },
                    { 2, "Technical Advisor", "Conseiller technique" },
                    { 3, "Business Architect", "Architecte d'affaires" },
                    { 4, "Project Officer", "Agent de projets" },
                    { 6, "Major", "Major" }
                });

            migrationBuilder.InsertData(
                table: "CompetencyTypeGroups",
                columns: new[] { "CompetencyId", "CompetencyTypeId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 3 },
                    { 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "JobGroupPositions",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "JobCategoryId", "JobKeyTaskPerLevelId", "JobLocationRegionId" },
                values: new object[,]
                {
                    { 2, 1, 3, 2, 4, 3 },
                    { 1, 1, 1, 1, 1, 1 },
                    { 3, 2, 6, 2, 4, 4 },
                    { 1, 2, 2, 1, 2, 2 },
                    { 3, 1, 5, 2, 4, 3 },
                    { 2, 2, 4, 2, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "JobPositionCompetencies",
                columns: new[] { "JobPositionId", "CompetencyId" },
                values: new object[,]
                {
                    { 3, 4 },
                    { 4, 4 },
                    { 3, 3 },
                    { 3, 2 },
                    { 5, 2 },
                    { 2, 2 },
                    { 4, 2 },
                    { 5, 1 },
                    { 3, 6 },
                    { 2, 1 },
                    { 6, 1 },
                    { 6, 2 },
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "JobRolePositionCertificates",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId" },
                values: new object[,]
                {
                    { 1, 2, 2, 1 },
                    { 2, 2, 4, 2 },
                    { 2, 2, 4, 3 },
                    { 3, 2, 6, 6 },
                    { 2, 3, 3, 5 },
                    { 1, 3, 1, 2 },
                    { 2, 3, 3, 2 },
                    { 3, 3, 5, 6 },
                    { 2, 3, 3, 3 },
                    { 1, 3, 1, 3 },
                    { 1, 3, 1, 1 },
                    { 3, 3, 5, 1 },
                    { 3, 3, 5, 2 },
                    { 3, 3, 5, 4 },
                    { 1, 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "JobRolePositionCompetencies",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId" },
                values: new object[,]
                {
                    { 3, 3, 5, 4 },
                    { 3, 3, 5, 1 },
                    { 3, 2, 6, 1 },
                    { 2, 2, 4, 4 },
                    { 2, 2, 4, 3 },
                    { 2, 2, 4, 2 },
                    { 3, 2, 6, 2 },
                    { 3, 2, 6, 6 },
                    { 3, 3, 5, 6 },
                    { 3, 3, 5, 2 },
                    { 2, 3, 3, 3 },
                    { 1, 3, 1, 1 },
                    { 2, 3, 3, 6 },
                    { 2, 3, 3, 4 },
                    { 2, 3, 3, 2 },
                    { 1, 3, 1, 2 },
                    { 1, 3, 1, 3 },
                    { 1, 2, 2, 2 },
                    { 1, 2, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "JobRolePositionCompetencyRatings",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId", "CompetencyLevelRequirementId", "CompetencyRatingLevelId" },
                values: new object[,]
                {
                    { 2, 3, 3, 4, 3, 3 },
                    { 3, 3, 6, 1, 3, 3 },
                    { 3, 3, 5, 6, 4, 4 },
                    { 3, 3, 5, 4, 5, 5 },
                    { 3, 3, 5, 2, 4, 4 },
                    { 3, 3, 5, 1, 4, 4 },
                    { 2, 3, 3, 6, 4, 4 },
                    { 1, 3, 1, 1, 1, 1 },
                    { 1, 3, 1, 3, 3, 3 },
                    { 2, 3, 3, 3, 2, 2 },
                    { 1, 3, 1, 2, 2, 2 },
                    { 2, 3, 3, 2, 1, 1 },
                    { 2, 2, 4, 2, 5, 5 },
                    { 3, 3, 6, 6, 3, 3 },
                    { 2, 2, 4, 4, 2, 2 },
                    { 3, 3, 6, 2, 4, 4 },
                    { 1, 2, 2, 2, 5, 5 },
                    { 1, 2, 2, 1, 4, 4 },
                    { 2, 2, 4, 3, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "JobRoles",
                columns: new[] { "JobGroupId", "JobGroupLevelId" },
                values: new object[,]
                {
                    { 2, 2 },
                    { 1, 2 },
                    { 3, 1 },
                    { 2, 1 },
                    { 1, 1 },
                    { 3, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompetencyTypeGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyTypeId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CompetencyTypeGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyTypeId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CompetencyTypeGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyTypeId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CompetencyTypeGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyTypeId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "CompetencyTypeGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyTypeId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "CompetencyTypeGroups",
                keyColumns: new[] { "CompetencyId", "CompetencyTypeId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "JobGroupPositions",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId" },
                keyValues: new object[] { 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "JobGroupPositions",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId" },
                keyValues: new object[] { 1, 2, 2 });

            migrationBuilder.DeleteData(
                table: "JobGroupPositions",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId" },
                keyValues: new object[] { 2, 1, 3 });

            migrationBuilder.DeleteData(
                table: "JobGroupPositions",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId" },
                keyValues: new object[] { 2, 2, 4 });

            migrationBuilder.DeleteData(
                table: "JobGroupPositions",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId" },
                keyValues: new object[] { 3, 1, 5 });

            migrationBuilder.DeleteData(
                table: "JobGroupPositions",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId" },
                keyValues: new object[] { 3, 2, 6 });

            migrationBuilder.DeleteData(
                table: "JobKeyTaskPerLevels",
                keyColumn: "Id",
                keyValue: 3);

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
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "JobPositionCompetencies",
                keyColumns: new[] { "JobPositionId", "CompetencyId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCertificates",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId" },
                keyValues: new object[] { 1, 2, 2, 1 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCertificates",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId" },
                keyValues: new object[] { 1, 2, 2, 2 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCertificates",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId" },
                keyValues: new object[] { 1, 3, 1, 1 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCertificates",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId" },
                keyValues: new object[] { 1, 3, 1, 2 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCertificates",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId" },
                keyValues: new object[] { 1, 3, 1, 3 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCertificates",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId" },
                keyValues: new object[] { 2, 2, 4, 2 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCertificates",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId" },
                keyValues: new object[] { 2, 2, 4, 3 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCertificates",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId" },
                keyValues: new object[] { 2, 3, 3, 2 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCertificates",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId" },
                keyValues: new object[] { 2, 3, 3, 3 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCertificates",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId" },
                keyValues: new object[] { 2, 3, 3, 5 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCertificates",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId" },
                keyValues: new object[] { 3, 2, 6, 6 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCertificates",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId" },
                keyValues: new object[] { 3, 3, 5, 1 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCertificates",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId" },
                keyValues: new object[] { 3, 3, 5, 2 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCertificates",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId" },
                keyValues: new object[] { 3, 3, 5, 4 });

            migrationBuilder.DeleteData(
                table: "JobRolePositionCertificates",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId" },
                keyValues: new object[] { 3, 3, 5, 6 });

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

            migrationBuilder.DeleteData(
                table: "JobRoles",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "JobRoles",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "JobRoles",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "JobRoles",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "JobRoles",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "JobRoles",
                keyColumns: new[] { "JobGroupId", "JobGroupLevelId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 6);

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
                table: "JobCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobGroupLevels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobGroupLevels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobGroupLevels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobGroups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobGroups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobGroups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobKeyTaskPerLevels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobKeyTaskPerLevels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobKeyTaskPerLevels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobLocationRegions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobLocationRegions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobLocationRegions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobLocationRegions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobPositions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobPositions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobPositions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobPositions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobPositions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "JobPositions",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
