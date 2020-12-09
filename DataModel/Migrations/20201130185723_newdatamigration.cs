using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class newdatamigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEng = table.Column<string>(maxLength: 1000, nullable: true),
                    NameFre = table.Column<string>(maxLength: 1000, nullable: true),
                    DescEng = table.Column<string>(maxLength: 250, nullable: true),
                    DescFre = table.Column<string>(maxLength: 250, nullable: true),
                    RequireIndicatorEng = table.Column<string>(maxLength: 250, nullable: true),
                    RequireIndicatorFre = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Competencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEng = table.Column<string>(maxLength: 1000, nullable: false),
                    NameFre = table.Column<string>(maxLength: 1000, nullable: false),
                    DescEng = table.Column<string>(maxLength: 2500, nullable: false),
                    DescFre = table.Column<string>(maxLength: 2500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyLevelRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescEng = table.Column<string>(maxLength: 8000, nullable: true),
                    DescFre = table.Column<string>(maxLength: 8000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyLevelRequirements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyRatingLevels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(nullable: false),
                    NameEng = table.Column<string>(maxLength: 250, nullable: false),
                    NameFre = table.Column<string>(maxLength: 250, nullable: false),
                    DescEng = table.Column<string>(maxLength: 500, nullable: true),
                    DescFre = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyRatingLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEng = table.Column<string>(maxLength: 250, nullable: false),
                    NameFre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueEng = table.Column<string>(maxLength: 50, nullable: false),
                    ValueFre = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobGroupLevels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelValue = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobGroupLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(maxLength: 20, nullable: false),
                    NameEng = table.Column<string>(maxLength: 500, nullable: false),
                    NameFre = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobKeyTaskPerLevels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescEng = table.Column<string>(maxLength: 2000, nullable: true),
                    DescFre = table.Column<string>(maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobKeyTaskPerLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobLocationRegions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEng = table.Column<string>(maxLength: 500, nullable: false),
                    NameFre = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobLocationRegions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobPositions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleEng = table.Column<string>(maxLength: 3000, nullable: false),
                    TitleFre = table.Column<string>(maxLength: 3000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyTypeGroups",
                columns: table => new
                {
                    CompetencyId = table.Column<int>(nullable: false),
                    CompetencyTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyTypeGroups", x => new { x.CompetencyId, x.CompetencyTypeId });
                    table.ForeignKey(
                        name: "FK_CompetencyTypeGroups_Competencies_CompetencyId",
                        column: x => x.CompetencyId,
                        principalTable: "Competencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetencyTypeGroups_CompetencyTypes_CompetencyTypeId",
                        column: x => x.CompetencyTypeId,
                        principalTable: "CompetencyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobRoles",
                columns: table => new
                {
                    JobGroupId = table.Column<int>(nullable: false),
                    JobGroupLevelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRoles", x => new { x.JobGroupId, x.JobGroupLevelId });
                    table.ForeignKey(
                        name: "FK_JobRoles_JobGroups_JobGroupId",
                        column: x => x.JobGroupId,
                        principalTable: "JobGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRoles_JobGroupLevels_JobGroupLevelId",
                        column: x => x.JobGroupLevelId,
                        principalTable: "JobGroupLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobGroupPositions",
                columns: table => new
                {
                    JobGroupId = table.Column<int>(nullable: false),
                    JobGroupLevelId = table.Column<int>(nullable: false),
                    JobPositionId = table.Column<int>(nullable: false),
                    JobLocationRegionId = table.Column<int>(nullable: false),
                    JobKeyTaskPerLevelId = table.Column<int>(nullable: false),
                    JobCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobGroupPositions", x => new { x.JobGroupId, x.JobGroupLevelId, x.JobPositionId });
                    table.ForeignKey(
                        name: "FK_JobGroupPositions_JobCategories_JobCategoryId",
                        column: x => x.JobCategoryId,
                        principalTable: "JobCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobGroupPositions_JobGroups_JobGroupId",
                        column: x => x.JobGroupId,
                        principalTable: "JobGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobGroupPositions_JobGroupLevels_JobGroupLevelId",
                        column: x => x.JobGroupLevelId,
                        principalTable: "JobGroupLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobGroupPositions_JobKeyTaskPerLevels_JobKeyTaskPerLevelId",
                        column: x => x.JobKeyTaskPerLevelId,
                        principalTable: "JobKeyTaskPerLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobGroupPositions_JobLocationRegions_JobLocationRegionId",
                        column: x => x.JobLocationRegionId,
                        principalTable: "JobLocationRegions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobGroupPositions_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobPositionCertificates",
                columns: table => new
                {
                    JobPositionId = table.Column<int>(nullable: false),
                    CertificateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPositionCertificates", x => new { x.JobPositionId, x.CertificateId });
                    table.ForeignKey(
                        name: "FK_JobPositionCertificates_Certificates_CertificateId",
                        column: x => x.CertificateId,
                        principalTable: "Certificates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPositionCertificates_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobPositionCompetencies",
                columns: table => new
                {
                    JobPositionId = table.Column<int>(nullable: false),
                    CompetencyId = table.Column<int>(nullable: false),
                    CompetencyTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPositionCompetencies", x => new { x.JobPositionId, x.CompetencyId });
                    table.ForeignKey(
                        name: "FK_JobPositionCompetencies_Competencies_CompetencyId",
                        column: x => x.CompetencyId,
                        principalTable: "Competencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPositionCompetencies_CompetencyTypes_CompetencyTypeId",
                        column: x => x.CompetencyTypeId,
                        principalTable: "CompetencyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPositionCompetencies_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobRolePositionCertificates",
                columns: table => new
                {
                    JobGroupId = table.Column<int>(nullable: false),
                    JobGroupLevelId = table.Column<int>(nullable: false),
                    JobPositionId = table.Column<int>(nullable: false),
                    CertificateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRolePositionCertificates", x => new { x.JobGroupId, x.JobGroupLevelId, x.JobPositionId, x.CertificateId });
                    table.ForeignKey(
                        name: "FK_JobRolePositionCertificates_Certificates_CertificateId",
                        column: x => x.CertificateId,
                        principalTable: "Certificates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCertificates_JobGroups_JobGroupId",
                        column: x => x.JobGroupId,
                        principalTable: "JobGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCertificates_JobGroupLevels_JobGroupLevelId",
                        column: x => x.JobGroupLevelId,
                        principalTable: "JobGroupLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCertificates_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobRolePositionCompetencies",
                columns: table => new
                {
                    JobGroupId = table.Column<int>(nullable: false),
                    JobGroupLevelId = table.Column<int>(nullable: false),
                    JobPositionId = table.Column<int>(nullable: false),
                    CompetencyId = table.Column<int>(nullable: false),
                    CompetencyTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRolePositionCompetencies", x => new { x.JobGroupId, x.JobGroupLevelId, x.JobPositionId, x.CompetencyId });
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencies_Competencies_CompetencyId",
                        column: x => x.CompetencyId,
                        principalTable: "Competencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencies_CompetencyTypes_CompetencyTypeId",
                        column: x => x.CompetencyTypeId,
                        principalTable: "CompetencyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencies_JobGroups_JobGroupId",
                        column: x => x.JobGroupId,
                        principalTable: "JobGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencies_JobGroupLevels_JobGroupLevelId",
                        column: x => x.JobGroupLevelId,
                        principalTable: "JobGroupLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencies_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobRolePositionCompetencyRatings",
                columns: table => new
                {
                    JobGroupId = table.Column<int>(nullable: false),
                    JobGroupLevelId = table.Column<int>(nullable: false),
                    JobPositionId = table.Column<int>(nullable: false),
                    CompetencyId = table.Column<int>(nullable: false),
                    CompetencyTypeId = table.Column<int>(nullable: false),
                    CompetencyRatingLevelId = table.Column<int>(nullable: false),
                    CompetencyLevelRequirementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRolePositionCompetencyRatings", x => new { x.JobGroupId, x.JobGroupLevelId, x.JobPositionId, x.CompetencyId, x.CompetencyTypeId });
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencyRatings_Competencies_CompetencyId",
                        column: x => x.CompetencyId,
                        principalTable: "Competencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencyRatings_CompetencyLevelRequirements_CompetencyLevelRequirementId",
                        column: x => x.CompetencyLevelRequirementId,
                        principalTable: "CompetencyLevelRequirements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencyRatings_CompetencyRatingLevels_CompetencyRatingLevelId",
                        column: x => x.CompetencyRatingLevelId,
                        principalTable: "CompetencyRatingLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencyRatings_CompetencyTypes_CompetencyTypeId",
                        column: x => x.CompetencyTypeId,
                        principalTable: "CompetencyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencyRatings_JobGroups_JobGroupId",
                        column: x => x.JobGroupId,
                        principalTable: "JobGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencyRatings_JobGroupLevels_JobGroupLevelId",
                        column: x => x.JobGroupLevelId,
                        principalTable: "JobGroupLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRolePositionCompetencyRatings_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "NameEng", "NameFre", "DescEng", "DescFre", "RequireIndicatorEng", "RequireIndicatorFre" },
                values: new object[,]
                {
                    { 1, "Master 1500 GT", "Master 1500 GT", "lorem ipsum", "lorem ipsum", "lorem ipsum", "lorem ipsum"},
                    { 2, "Master 1600A GT", "Master 1600A GT", "lorem ipsum", "lorem ipsum", "lorem ipsum", "lorem ipsum" },
                    { 3, "lorem ipsum", "lorem ipsum", "lorem ipsum", "lorem ipsum", "lorem ipsum", "lorem ipsum" },
                    { 4, "lorem ipsum", "lorem ipsum", "lorem ipsum", "lorem ipsum", "lorem ipsum", "lorem ipsum" },
                    { 5, "lorem ipsum", "lorem ipsum", "lorem ipsum", "lorem ipsum", "lorem ipsum", "lorem ipsum" },
                    { 6, "lorem ipsum", "lorem ipsum", "lorem ipsum", "lorem ipsum", "lorem ipsum", "lorem ipsum" }
                });

            migrationBuilder.InsertData(
                table: "Competencies",
                columns: new[] { "Id", "DescEng", "DescFre", "NameEng", "NameFre" },
                values: new object[,]
                {
                    { 1, "Knowledge of the Canadian Coast Guard organization, partners, and relationships with Fisheries and Oceans Canada (DFO), and other internal and external stakeholders.", "Knowledge of the Canadian Coast Guard organization, partners, and relationships with Fisheries and Oceans Canada (DFO), and other internal and external stakeholders.", "Organizational Knowledge", "Connaissances organisationnelles" },
                    { 2, "Knowledge of the programs the Canadian Coast Guard manages and supports. Understands the services and delivery of program mandates:  Search and Rescue (SAR), Icebreaking (IB), Aids to Navigation (AtoN), Environmental Response (ER), Conservation and Protection (DFO C&P), Oceanography (DFO Science) and Fisheries Research (DFO Science).", "Knowledge of the programs the Canadian Coast Guard manages and supports. Understands the services and delivery of program mandates:  Search and Rescue (SAR), Icebreaking (IB), Aids to Navigation (AtoN), Environmental Response (ER), Conservation and Protection (DFO C&P), Oceanography (DFO Science) and Fisheries Research (DFO Science).", "Program Knowledge and Application", "Connaissance et application des programmes" },
                    { 3, "Understanding of administrative procedures and processes in one or more area of responsibility.", "Understanding of administrative procedures and processes in one or more area of responsibility.", "Administrative Knowledge", "Connaissances en administration" },
                    { 4, "Knowledge of the Incident Command System (ICS), its functions, role, and reporting structures. Knowledge of procedures and processes involved in an emergency response.", "Knowledge of the Incident Command System (ICS), its functions, role, and reporting structures. Knowledge of procedures and processes involved in an emergency response.", "Incident Command System (ICS) Knowledge", "Connaissance des systèmes de commandement dinterventions (SCI)" },
                    { 5, "Knowledge of policies and directives on the management and administration of workforce management (HR) issues affecting seagoing personnel.", "Knowledge of policies and directives on the management and administration of workforce management (HR) issues affecting seagoing personnel.", "Seagoing Personnel Management", "Gestion du personnel navigant" },
                    { 6, "Knowledge of the coastal marine domain factors such as meteorology, shipping patterns, and security resources. Knowledge of the coastal security nets, its players, authorities, and roles. Knowledge of agency interoperabilities.", "Knowledge of the coastal marine domain factors such as meteorology, shipping patterns, and security resources. Knowledge of the coastal security nets, its players, authorities, and roles. Knowledge of agency interoperabilities.", "Maritime Security (MSOC) Knowledge", "Sécurité maritime (COSM) Connaissance" },

                    { 7, "Knowledge of the step by step process of analysis, design, development, implementation, and evaluation in the course of delivering training. May also be referred to as Instructional Systems Design, or ISD.", "Knowledge of the step by step process of analysis, design, development, implementation, and evaluation in the course of delivering training. May also be referred to as Instructional Systems Design, or ISD.", "Knowledge of Systems Approach to Training", "Connaissance de l'approche systémique de la formation" },
                    { 8, "Knowledge of specialized fields, including concepts, theories, principles, methods, techniques, and practices. Such knowledge can be acquired through formal education, experience, specialized or on-the-job training, self-education, or a combination.", "Knowledge of specialized fields, including concepts, theories, principles, methods, techniques, and practices. Such knowledge can be acquired through formal education, experience, specialized or on-the-job training, self-education, or a combination.", "Knowledge of Specialized Fields", "Connaissance des domaines spécialisés" },
                    { 9, "Manages a project or program while respecting procedures, operations, policies, and legislation, including inter-relationships with other departments, agencies, or the private sector. Project management involves effectively participating and/or integrating all aspects of a given finite project, ensuring that work progresses towards achieving goals and objectives. Program management involves effectively managing an ongoing activity line.", "Manages a project or program while respecting procedures, operations, policies, and legislation, including inter-relationships with other departments, agencies, or the private sector. Project management involves effectively participating and/or integrating all aspects of a given finite project, ensuring that work progresses towards achieving goals and objectives. Program management involves effectively managing an ongoing activity line.", "Project/Program Management", "Gestion de projet / programme" },
                    { 10, "Integrates various ideas, intentions, and information to form effective goals, objectives, timelines, action plans, and solutions.", "Integrates various ideas, intentions, and information to form effective goals, objectives, timelines, action plans, and solutions.", "Planning and Prioritizing", "Planification et établissement de priorités" },
                    { 11, "Manages the process of selecting vendors, establishing payment terms, strategic vetting, selection, the negotiation of contracts, and actual purchasing of goods.", "Manages the process of selecting vendors, establishing payment terms, strategic vetting, selection, the negotiation of contracts, and actual purchasing of goods.", "Procurement and Purchasing", "Approvisionnement et achat" },
                    { 12, "Plans, organizes, controls, and evaluates the operations of workforce management and personnel units. Develops and implements policies, programs, and procedures regarding workforce planning, recruitment, training, wellness, and career development.", "Plans, organizes, controls, and evaluates the operations of workforce management and personnel units. Develops and implements policies, programs, and procedures regarding workforce planning, recruitment, training, wellness, and career development.", "Workforce Management (HR) for Specialists", "Gestion des ressources humaines (RH) pour les spécialistes" },

                    { 13, "Applies required financial procedures and tracking in order to manage public funds in an appropriate manner.", "Applies required financial procedures and tracking in order to manage public funds in an appropriate manner.", "Financial Management for Specialists", "Gestion financière pour les spécialistes" },
                    { 14, "Encompasses written, oral, visual, and digital communication in an organizational context, as a specialty. Focuses on the study of information and the ways it is planned, created, managed, distributed, and consumed within the Canadian Coast Guard.", "Encompasses written, oral, visual, and digital communication in an organizational context, as a specialty. Focuses on the study of information and the ways it is planned, created, managed, distributed, and consumed within the Canadian Coast Guard.", "Communications for Specialists", "Communications pour les spécialistes" },
                    { 15, "Manages real property and facilities management activities on a whole-life basis.", "Manages real property and facilities management activities on a whole-life basis.", "Real Property and Facilities Management", "Gestion des biens immobiliers et des installations" },
                    { 16, "Establishes and enables processes in an organizational context, by defining needs and recommending solutions that deliver value to Canadian Coast Guard stakeholders.", "Establishes and enables processes in an organizational context, by defining needs and recommending solutions that deliver value to Canadian Coast Guard stakeholders.", "Business Analysis", "Analyse des affaires" },
                    { 17, "Provides a high standard of service to Canadian Coast Guard members and other stakeholders.", "Provides a high standard of service to Canadian Coast Guard members and other stakeholders.", "Support Services", "Services de soutien" },
                    { 18, "Manages unit or units workforce planning, recruitment, organizational design, classification issues, training and development, employment equity, official languages issues, performance management/labour relations, compensation issues, and rewards/recognition items.", "Manages unit or units workforce planning, recruitment, organizational design, classification issues, training and development, employment equity, official languages issues, performance management/labour relations, compensation issues, and rewards/recognition items.", "Workforce Management (HR) for Supervisors/Managers", "Gestion de l'effectif (RH) pour les superviseurs/gestionnaires" },

                    { 19, "Applies the rules, policies, regulations, and procedures of the Financial Administration Act as they apply to the Canadian Coast Guard as well as the organization's financial assets and management procedures (including related procurement rules) such as: financial authority level and approval process, financial accounting procedures, public accountability, budgeting, projecting, monitoring, reporting, financial auditing, etc.", "Applies the rules, policies, regulations, and procedures of the Financial Administration Act as they apply to the Canadian Coast Guard as well as the organization's financial assets and management procedures (including related procurement rules) such as: financial authority level and approval process, financial accounting procedures, public accountability, budgeting, projecting, monitoring, reporting, financial auditing, etc.", "Financial Management for Supervisors/Managers", "Gestion financière pour les superviseurs/gestionnaires" },
                    { 20, "Consults with the chief cook in preparing menus and the economical use of provisions. Consults with the steward on all matters pertaining to accommodation, sanitation, and laundry facilities. Establishes requirements and procedures for the requisition, receipt, storage, and distribution of supplies. Collaborates with officers of the engine room department in the loading and moving of stores, supplies, and provisions.", "Consults with the chief cook in preparing menus and the economical use of provisions. Consults with the steward on all matters pertaining to accommodation, sanitation, and laundry facilities. Establishes requirements and procedures for the requisition, receipt, storage, and distribution of supplies. Collaborates with officers of the engine room department in the loading and moving of stores, supplies, and provisions.", "Hotel Services Management", "Gestion des services hôteliers" },
                    { 21, "Analyzes and gathers information to produce intelligence-driven products in collaboration with interdepartmental partners. Compiles data and information gathered from surveillance activities, intelligence investigations, security events, or incidents.", "Analyzes and gathers information to produce intelligence-driven products in collaboration with interdepartmental partners. Compiles data and information gathered from surveillance activities, intelligence investigations, security events, or incidents.", "Maritime Security Operations Centre (MSOC)", "Sécurité maritime (COSM)" },
                    { 22, "Plans and carries out systematic activities implemented within the quality management system.", "Plans and carries out systematic activities implemented within the quality management system.", "Quality Assurance (QA)", "Assurance de la qualité" },
                    { 23, "Classifies materiel according to Canadian Coast Guard and Public Services and Procurement Canada (PSPC) directives. Tracks materiel during receipt, storage, issue, and disposal.", "Classifies materiel according to Canadian Coast Guard and Public Services and Procurement Canada (PSPC) directives. Tracks materiel during receipt, storage, issue, and disposal.", "Materiel Management", "Gestion du matériel" },
                    { 24, "Plans and develops exercises (simulations of an emergency situation), which includes validating exercise plans, developing member skills, testing them during exercises, and testing established procedures. It includes a visual overview of the exercise, tracks related hours/cost of exercise, assigns responsibilities and logistical tasks.", "Plans and develops exercises (simulations of an emergency situation), which includes validating exercise plans, developing member skills, testing them during exercises, and testing established procedures. It includes a visual overview of the exercise, tracks related hours/cost of exercise, assigns responsibilities and logistical tasks.", "Exercise Planning", "Planification d'exercices" },

                    { 25, "Teaching or instructing adults in systematic and sustained self-educating activities so that they may gain new forms of knowledge, skills, attitudes, or values. This includes various forms of specific and generic instruction as required by the Canadian Coast Guard with an emphasis on the needs of adults and the results orientation of the organization.", "Teaching or instructing adults in systematic and sustained self-educating activities so that they may gain new forms of knowledge, skills, attitudes, or values. This includes various forms of specific and generic instruction as required by the Canadian Coast Guard with an emphasis on the needs of adults and the results orientation of the organization.", "Adult Teaching", "Enseignement aux adultes" },
                    { 26, "Honours commitments and consistently strives to act in the public interest by ensuring that public trust and the law are not violated, while avoiding conflicts of interest and maintaining political and interpersonal neutrality.", "Honours commitments and consistently strives to act in the public interest by ensuring that public trust and the law are not violated, while avoiding conflicts of interest and maintaining political and interpersonal neutrality.", "Demonstrating Integrity and Respect", "Fait preuve d'intégrité et de respect" },
                    { 27, "Plans and adjusts work based on a thorough understanding of the Canadian Coast Guard's priorities. Obtains relevant information, considers all facts, and exercises sound judgement to formulate an opinion and/or make a decision. Analyzes situations and seeks feedback to learn from mistakes.", "Plans and adjusts work based on a thorough understanding of the Canadian Coast Guard's priorities. Obtains relevant information, considers all facts, and exercises sound judgement to formulate an opinion and/or make a decision. Analyzes situations and seeks feedback to learn from mistakes.", "Thinking Things Through", "Réflexion approfondie" },
                    { 28, "Works cooperatively in order to achieve results. Works positively as part of a team and manages internal conflict. Identifies opportunities to work together within the organization to improve team dynamics and develop relationships. Seeks and builds internal/external alliances, collaborations, and partnerships to advance the Canadian Coast Guard's mandate.", "Works cooperatively in order to achieve results. Works positively as part of a team and manages internal conflict. Identifies opportunities to work together within the organization to improve team dynamics and develop relationships. Seeks and builds internal/external alliances, collaborations, and partnerships to advance the Canadian Coast Guard's mandate.", "Working Effectively With Others", "Travaille efficacement avec les autres" },
                    { 33, "Embraces change and actively looks for opportunities to learn and develop professionally and personally. Translates direction into concrete work activities. Identifies opportunities or issues, and takes action to enhance organizational results, without being prompted by others.", "Embraces change and actively looks for opportunities to learn and develop professionally and personally. Translates direction into concrete work activities. Identifies opportunities or issues, and takes action to enhance organizational results, without being prompted by others.", "Showing Initiative and Being Action Oriented", "Fait preuve d'intiative et est orienté vers l'action" },
                    { 34, "Promotes workplace safety. Follows safety guidelines, procedures, and regulations. Reacts safely and appropriately during emergencies. Integrates health and safety considerations in planning, response, and reviews.", "Promotes workplace safety. Follows safety guidelines, procedures, and regulations. Reacts safely and appropriately during emergencies. Integrates health and safety considerations in planning, response, and reviews.", "Apply Safety Considerations", "Intégre les considérations relatives à la sécurité" },

                    { 36, "Attracts and mobilizes members and colleagues towards a shared vision and purpose in the best interests of the Canadian Coast Guard and the public it serves. Motivates project members, sets achievable objectives, maintains a positive outlook, takes responsibility, makes decisions, and provides constructive feedback.", "Attracts and mobilizes members and colleagues towards a shared vision and purpose in the best interests of the Canadian Coast Guard and the public it serves. Motivates project members, sets achievable objectives, maintains a positive outlook, takes responsibility, makes decisions, and provides constructive feedback.", "Leadership", "Leadership" },
                    { 37, "The extent that members believe in the mission, mandate, and values of the Coast Guard and project that commitment through their actions and attitudes towards the organization and its stakeholders. Employee statements and deportment reflect a natural enthusiasm for the Coast Guard, what it does, and how it is viewed by the public.", "The extent that members believe in the mission, mandate, and values of the Coast Guard and project that commitment through their actions and attitudes towards the organization and its stakeholders. Employee statements and deportment reflect a natural enthusiasm for the Coast Guard, what it does, and how it is viewed by the public.", "Canadian Coast Guard Cultural Awareness", "Sensibilisation à la culture de la Garde côtière canadienne" }

                });

            migrationBuilder.InsertData(
                table: "CompetencyLevelRequirements",
                columns: new[] { "Id", "DescEng", "DescFre" },
                values: new object[,]
                {
                    { 1, "Basic knowledge of a unit in the Coast Guard organization chart and its reporting relationships.", "Basic knowledge of a unit in the Coast Guard organization chart and its reporting relationships." },
                    { 2, "Limited knowledge of the Coast Guard's mandate and its relationship with Fisheries and Oceans Canada (DFO). Understands the organization's directorates regionally and/or nationally.", "Limited knowledge of the Coast Guard's mandate and its relationship with Fisheries and Oceans Canada (DFO). Understands the organization's directorates regionally and/or nationally." },
                    { 3, "Practical knowledge of the Coast Guard and Fisheries and Oceans Canada (DFO) organizations, and of the Coast Guard as a special operating agency. Understands a program and its linkages to other programs and directorates regionally and/or nationally.", "Practical knowledge of the Coast Guard and Fisheries and Oceans Canada (DFO) organizations, and of the Coast Guard as a special operating agency. Understands a program and its linkages to other programs and directorates regionally and/or nationally." },
                    { 4, "Advanced knowledge of the Coast Guard and Fisheries and Oceans Canada (DFO) organizations, directorates and associated programs and relations regionally and nationally.", "Advanced knowledge of the Coast Guard and Fisheries and Oceans Canada (DFO) organizations, directorates and associated programs and relations regionally and nationally." },
                    { 5, "Expert knowledge of the Coast Guard and Fisheries and Oceans Canada (DFO) organizations and their interdependencies with other internal (includes other government departments) and external (includes industry and other governments) organizations. Expertise in providing advice and guidance to stakeholders about the organization and its capabilities.", "Expert knowledge of the Coast Guard and Fisheries and Oceans Canada (DFO) organizations and their interdependencies with other internal (includes other government departments) and external (includes industry and other governments) organizations. Expertise in providing advice and guidance to stakeholders about the organization and its capabilities." },
                    { 6, "Basic knowledge of the Coast Guard and its role as an enabler of various programs.", "Basic knowledge of the Coast Guard and its role as an enabler of various programs." },
                    { 7, "Limited knowledge of the Coast Guard's functions and the roles and responsibilities of key Coast Guard contacts within a regional organizational setting. Understands some programs and assets well.", "Limited knowledge of the Coast Guard's functions and the roles and responsibilities of key Coast Guard contacts within a regional organizational setting. Understands some programs and assets well." },
                    { 8, "Practical knowledge of program deliveries in a regional or national organizational setting.  Understands most programs and associated assets. Knowledge of key contacts for other programs. Comprehends roles and responsibilities of client partners.", "Practical knowledge of program deliveries in a regional or national organizational setting.  Understands most programs and associated assets. Knowledge of key contacts for other programs. Comprehends roles and responsibilities of client partners." },
                    { 9, "Advanced knowledge of programs and their impacts on public and partner relations, regionally and/or nationally. Extensive knowledge of all the Coast Guard's programs and the capability and status of Coast Guard assets regionally and/or nationally. Understands program planning exercises.", "Advanced knowledge of programs and their impacts on public and partner relations, regionally and/or nationally. Extensive knowledge of all the Coast Guard's programs and the capability and status of Coast Guard assets regionally and/or nationally. Understands program planning exercises." },
                    { 10, "Expert knowledge of all the Coast Guard programs and delivery modes and timelines regionally and nationally. Understands expectations and needs of stakeholders for the Coast Guard and other government departments (OGDs) in planning and exercises. Understands the significance of potential program efficiencies, changes, or expansion opportunities.", "Expert knowledge of all the Coast Guard programs and delivery modes and timelines regionally and nationally. Understands expectations and needs of stakeholders for the Coast Guard and other government departments (OGDs) in planning and exercises. Understands the significance of potential program efficiencies, changes, or expansion opportunities." },
                    { 12, "Understands basic administrative tasks and rules as they relate to a position. Recognizes the need to have supervisor approve requests where applicable.", "Understands basic administrative tasks and rules as they relate to a position. Recognizes the need to have supervisor approve requests where applicable." },
                    { 13, "Recognizes when administration requirements are met. Understands systems and software pertaining to administrative functions and where applicable, the shipboard logistics functions in the performance of duties.", "Recognizes when administration requirements are met. Understands systems and software pertaining to administrative functions and where applicable, the shipboard logistics functions in the performance of duties." },
                    { 14, "Understands the full range of administration services such as expense forms, reimbursements (travel, stores, etc.) and where applicable items such as ex gratiapayments, timesheets, drafting correspondence and reports, training requests and authorizations, etc.", "Understands the full range of administration services such as expense forms, reimbursements (travel, stores, etc.) and where applicable items such as ex gratiapayments, timesheets, drafting correspondence and reports, training requests and authorizations, etc." },
                    { 15, "Understands the full administration requirements of a sector or unit and how they interrelate with one another to effect efficient transactions throughout. Knowledge of all applicable policies, standards etc., to perform duties.", "Understands the full administration requirements of a sector or unit and how they interrelate with one another to effect efficient transactions throughout. Knowledge of all applicable policies, standards etc., to perform duties." },
                    { 16, "Expert knowledge in the administrative functions of multiple units working together and the needs of a work site, when and where applicable. Awareness of national and regional initiatives related to the administrative functions of a unit or units.", "Expert knowledge in the administrative functions of multiple units working together and the needs of a work site, when and where applicable. Awareness of national and regional initiatives related to the administrative functions of a unit or units." },
                    { 17, "Basic understanding of the different Incident Command System (ICS) elements and incident levels. Understands the established and applicable operational procedures within ICS. Knowledge of associated computer software and hardware.", "Basic understanding of the different Incident Command System (ICS) elements and incident levels. Understands the established and applicable operational procedures within ICS. Knowledge of associated computer software and hardware." },
                    { 18, "Limited knowledge of the principles and working process of the Incident Command System (ICS). Knowledge of methodology for all Coast Guard incidents, emergency or contingency plans executed in environmental response, humanitarian assistance, maritime security, planned security events, Coast Guard internal incidents and major maritime incidents.", "Limited knowledge of the principles and working process of the Incident Command System (ICS). Knowledge of methodology for all Coast Guard incidents, emergency or contingency plans executed in environmental response, humanitarian assistance, maritime security, planned security events, Coast Guard internal incidents and major maritime incidents." },
                    { 19, "Practical knowledge of the Incident Command System (ICS) during pollution incidents. Knowledge of the relationship between the Coast Guard Safety Management System (SMS) and the ICS. Understands how to determine optimum intervention options and determining the severity, sensitivity, and impact of an incident. Understands equipment specifications and maintenance requirements.", "Practical knowledge of the Incident Command System (ICS) during pollution incidents. Knowledge of the relationship between the Coast Guard Safety Management System (SMS) and the ICS. Understands how to determine optimum intervention options and determining the severity, sensitivity, and impact of an incident. Understands equipment specifications and maintenance requirements." },
                    { 20, "Advanced knowledge of the management of an Incident Command System (ICS) command and control structure. Knowledge of interoperability with other organizations such as regional, federal, provincial, territorial, and international partners, and response organizations. Understands and applies life cycle management of equipment. Understands national exercise program (NEP) principles.", "Advanced knowledge of the management of an Incident Command System (ICS) command and control structure. Knowledge of interoperability with other organizations such as regional, federal, provincial, territorial, and international partners, and response organizations. Understands and applies life cycle management of equipment. Understands national exercise program (NEP) principles." },
                    { 21, "Expert knowledge of the Incident Command System (ICS) and identifying new possibilities/capabilities to improve the existing systems and practices. Expertise in drafting/review of acts, regulations, and frameworks, and emergency management policies and directions. ", "Expert knowledge of the Incident Command System (ICS) and identifying new possibilities/capabilities to improve the existing systems and practices. Expertise in drafting/review of acts, regulations, and frameworks, and emergency management policies and directions. " },
                    { 22, "Basic knowledge of existing policies and documents related to seagoing personnel and where to locate them.", "Basic knowledge of existing policies and documents related to seagoing personnel and where to locate them." },
                    { 23, "Limited knowledge of the Canadian Coast Guard's documentation covering policies and directives related to crewing profile, rotation regulations, leave, medical fitness and training, and certification for seagoing personnel. ", "Limited knowledge of the Canadian Coast Guard's documentation covering policies and directives related to crewing profile, rotation regulations, leave, medical fitness and training, and certification for seagoing personnel. " },
                    { 24, "Practical knowledge of the Coast Guard's seagoing dynamic environment. Understands applicable policies and directives when initiating administration processes related to seagoing personnel such as timesheet verification, scheduling and tracking medicals, using the crewing profiles, leave management, labour relations protocols, and using the MariTime system, etc.", "Practical knowledge of the Coast Guard's seagoing dynamic environment. Understands applicable policies and directives when initiating administration processes related to seagoing personnel such as timesheet verification, scheduling and tracking medicals, using the crewing profiles, leave management, labour relations protocols, and using the MariTime system, etc." },
                    { 25, "Advanced knowledge of the regional/national approaches in the application of any required policies and regulations related to operational personnel management. Understands new concepts and processes to improve recruitment, retention, and sustainment of the Coast Guard's seagoing personnel and its management. ", "Advanced knowledge of the regional/national approaches in the application of any required policies and regulations related to operational personnel management. Understands new concepts and processes to improve recruitment, retention, and sustainment of the Coast Guard's seagoing personnel and its management. " },
                    { 26, "Expert knowledge in strategic guidance related to the seagoing personnel management doctrine.   Expertise in recommending, drafting, and implementation of policies related to the management of seagoing personnel. ", "Expert knowledge in strategic guidance related to the seagoing personnel management doctrine.   Expertise in recommending, drafting, and implementation of policies related to the management of seagoing personnel. " },
                    { 27, "Basic knowledge of coastal domain factors, working relations with other Canadian Coast Guard units, and equipment. ", "Basic knowledge of coastal domain factors, working relations with other Canadian Coast Guard units, and equipment. " },
                    { 28, "Limited knowledge in supporting Fisheries and Oceans Canada's (DFO) marine security programs and conducting analyses using surveillance equipment and working with internal partners. ", "Limited knowledge in supporting Fisheries and Oceans Canada's (DFO) marine security programs and conducting analyses using surveillance equipment and working with internal partners. " },
                    { 29, "Practical knowledge in the full range of the maritime security operations centres (MSOC),  its exercises, and its surveillance and analyses with internal partners.", "Practical knowledge in the full range of the maritime security operations centres (MSOC),  its exercises, and its surveillance and analyses with internal partners." },
                    { 30, "Advanced knowledge of all facets of marine security operations, training, and analyses regionally or nationally, as well as training/consultation initiatives. Knowledge of Fisheries and Oceans Canada (DFO), Department of National Defence (DND), Royal Canadian Mounted Police (RCMP), Transport Canada (TC), and the Coast Guard's response systems, programs, and surveillance equipment (Long Range Identification and Tracking [LRIT], radars, cameras).", "Advanced knowledge of all facets of marine security operations, training, and analyses regionally or nationally, as well as training/consultation initiatives. Knowledge of Fisheries and Oceans Canada (DFO), Department of National Defence (DND), Royal Canadian Mounted Police (RCMP), Transport Canada (TC), and the Coast Guard's response systems, programs, and surveillance equipment (Long Range Identification and Tracking [LRIT], radars, cameras)." },
                    { 31, "Expert knowledge of all facets of the marine security operations program and its relations with international and industrial stakeholders (e.g. United States Coast Guard [USCG], Ports). Expertise in providing insights to managers and stakeholders in advisory groups, the military, Canadian Security Intelligence Service (CSIS), and governments.", "Expert knowledge of all facets of the marine security operations program and its relations with international and industrial stakeholders (e.g. United States Coast Guard [USCG], Ports). Expertise in providing insights to managers and stakeholders in advisory groups, the military, Canadian Security Intelligence Service (CSIS), and governments." },
                    { 32, "Basic knowledge of the training needs analysis process in relation to the Canadian Coast Guard's training gaps and requirements. ", "Basic knowledge of the training needs analysis process in relation to the Canadian Coast Guard's training gaps and requirements. " },
                    { 33, "Limited knowledge of determining training elements including terminal objectives, training structure and outline, brief description of the training, and the method of delivery.", "Limited knowledge of determining training elements including terminal objectives, training structure and outline, brief description of the training, and the method of delivery." },
                    { 34, "Practical knowledge in developing enabling objectives. Understands the development of course materials and curriculum including the instructor lesson plan, participant handouts, assessments, and selected media such as PowerPoint presentations, video, or audio, etc. ", "Practical knowledge in developing enabling objectives. Understands the development of course materials and curriculum including the instructor lesson plan, participant handouts, assessments, and selected media such as PowerPoint presentations, video, or audio, etc. " },
                    { 35, "Advanced knowledge in identifying methods and activities for presenting new information. Knowledge of setting aims and learning objectives. Understanding of the design strategy, for the development of new courses. Knowledge of making course modifications based on feedback. ", "Advanced knowledge in identifying methods and activities for presenting new information. Knowledge of setting aims and learning objectives. Understanding of the design strategy, for the development of new courses. Knowledge of making course modifications based on feedback. " },
                    { 36, "Expert knowledge of evaluating training results to determine whether the sessions led to required changes in behaviour for the participants. Knowledge in redefining course development, materials, and instructional methods. Understanding of briefing senior management regarding issues, trends, suggestions, and areas of improvement based on evaluation, including trends related to diversity and generational issues.", "Expert knowledge of evaluating training results to determine whether the sessions led to required changes in behaviour for the participants. Knowledge in redefining course development, materials, and instructional methods. Understanding of briefing senior management regarding issues, trends, suggestions, and areas of improvement based on evaluation, including trends related to diversity and generational issues." },
                    { 37, "Basic knowledge of aspects of specialized fields to accomplish defined activities by applying methods, techniques, and established practices.", "Basic knowledge of aspects of specialized fields to accomplish defined activities by applying methods, techniques, and established practices." },
                    { 38, "Limited knowledge of theories and principles of a specialized field and the relevancy to their application. ", "Limited knowledge of theories and principles of a specialized field and the relevancy to their application. " },
                    { 39, "Practical knowledge of specialized methodologies of a field and comprehensive understanding of their underlying concepts, theories, and principles. ", "Practical knowledge of specialized methodologies of a field and comprehensive understanding of their underlying concepts, theories, and principles. " },
                    { 40, "Advanced knowledge in specialized methodologies of a field and of their underlying concepts. Extensive comprehension of the methodologies, theories, and applied principles of a specialized field.", "Advanced knowledge in specialized methodologies of a field and of their underlying concepts. Extensive comprehension of the methodologies, theories, and applied principles of a specialized field." },
                    { 41, "Expert knowledge in specialized methodologies of a field or fields and of their underlying concepts, theories, and principles. Extensive knowledge in the provision of coaching/guidance to staff, peers, and senior management.", "Expert knowledge in specialized methodologies of a field or fields and of their underlying concepts, theories, and principles. Extensive knowledge in the provision of coaching/guidance to staff, peers, and senior management." },
                    { 42, "Participates in project/program support activities. ", "Participates in project/program support activities. " },
                    { 43, "Respects project/program goals, participants' roles, and the importance of project management principles. Participates in project support activities (i.e. gathering needed information). Participates with others in small and well defined components of the project/program.", "Respects project/program goals, participants' roles, and the importance of project management principles. Participates in project support activities (i.e. gathering needed information). Participates with others in small and well defined components of the project/program." },
                    { 44, "Actively promotes project goals, participants' roles, and the importance of project management principles, such as time, cost, and quality management. Participates, with minimal supervision, with others in all aspects of project or program. Seeks advice and guidance for more complex components of the project/program.", "Actively promotes project goals, participants' roles, and the importance of project management principles, such as time, cost, and quality management. Participates, with minimal supervision, with others in all aspects of project or program. Seeks advice and guidance for more complex components of the project/program." },
                    { 45, "Leads projects and/or programs. Leads project/program support activities, taking the initiative to gather additional information, keep documentation organized, and identify process improvements, when and where applicable. Provides advice to others who seek assistance within the project/program scope. ", "Leads projects and/or programs. Leads project/program support activities, taking the initiative to gather additional information, keep documentation organized, and identify process improvements, when and where applicable. Provides advice to others who seek assistance within the project/program scope. " },
                    { 46, "Responsibly delivers on the established mandate of a project/program. Directs teams to complete activities in accordance with current policies and practices. Provides accurate and timely recommendations to clients. Trains and advises anyone seeking guidance on basic to complex elements of project/program. ", "Responsibly delivers on the established mandate of a project/program. Directs teams to complete activities in accordance with current policies and practices. Provides accurate and timely recommendations to clients. Trains and advises anyone seeking guidance on basic to complex elements of project/program. " },
                    { 47, "Monitors the quality and timeliness of individual responsibilities using the available resources, searching for clarity as needed. ", "Monitors the quality and timeliness of individual responsibilities using the available resources, searching for clarity as needed. " },
                    { 48, "Plans and organizes individual responsibilities to accomplish pre-determined standards or procedures. Monitors the quality and timeliness of work while leveraging the resources at immediate disposal.", "Plans and organizes individual responsibilities to accomplish pre-determined standards or procedures. Monitors the quality and timeliness of work while leveraging the resources at immediate disposal." },
                    { 49, "Plans and organizes activities efficiently. Monitors the quality and timeliness of unit workloads. Uses available resources and seeks assistance to clarify priorities, when and where required. Reports on results to promote accountability. ", "Plans and organizes activities efficiently. Monitors the quality and timeliness of unit workloads. Uses available resources and seeks assistance to clarify priorities, when and where required. Reports on results to promote accountability. " },
                    { 50, "Efficiently plans and organizes activities for a unit. Establishes goals and objectives and anticipates obstacles realistically. Determines priorities and allocates resources effectively. Assists others and gives guidance as required.", "Efficiently plans and organizes activities for a unit. Establishes goals and objectives and anticipates obstacles realistically. Determines priorities and allocates resources effectively. Assists others and gives guidance as required." },
                    { 51, "Plans and organizes effectively while managing multiple demands and competing priorities. Influences processes and courses of action. Provides guidance and advice on a project or program area. ", "Plans and organizes effectively while managing multiple demands and competing priorities. Influences processes and courses of action. Provides guidance and advice on a project or program area. " },
                    { 52, "Administers low-risk contracts. Monitors inventory levels of materials, equipment, and stock using manual or computerized inventory systems. Prepares requisition orders to replenish materials, equipment, and stock. Maintains stock rotation, disposes of and accounts for outdated stock. Enters data for production scheduling, stock replenishment, relocation, and inventory adjustments. Maintains a contractor database, insurance requirements, and pricing accuracy. ", "Administers low-risk contracts. Monitors inventory levels of materials, equipment, and stock using manual or computerized inventory systems. Prepares requisition orders to replenish materials, equipment, and stock. Maintains stock rotation, disposes of and accounts for outdated stock. Enters data for production scheduling, stock replenishment, relocation, and inventory adjustments. Maintains a contractor database, insurance requirements, and pricing accuracy. " },
                    { 53, "Monitors and reports on contract milestones and outcomes. Completes price variations in accordance with predetermined processes. Sources and obtains price quotations from catalogues and suppliers, and prepares purchase orders. Calculates cost of orders and charges or forwards invoices to appropriate accounts. Prepares and maintains purchasing files, reports, and price lists. Assesses requirements of clients and develops specifications for equipment, materials, and supplies to be purchased. ", "Monitors and reports on contract milestones and outcomes. Completes price variations in accordance with predetermined processes. Sources and obtains price quotations from catalogues and suppliers, and prepares purchase orders. Calculates cost of orders and charges or forwards invoices to appropriate accounts. Prepares and maintains purchasing files, reports, and price lists. Assesses requirements of clients and develops specifications for equipment, materials, and supplies to be purchased. " },
                    { 54, "Manages medium-risk contracts including governance, risk, performance, and financial management. Purchases general and specialized equipment, materials, land or access rights, or business services for use or for further processing by the Canadian Coast Guard. Interprets and applies the terms and conditions of the contract to varied situations. Manages, or assists in the management of, all procedural aspects of purchasing activities. Adapts contract management practices in changing circumstances whilst maintaining the overall intent of the contract.  ", "Manages medium-risk contracts including governance, risk, performance, and financial management. Purchases general and specialized equipment, materials, land or access rights, or business services for use or for further processing by the Canadian Coast Guard. Interprets and applies the terms and conditions of the contract to varied situations. Manages, or assists in the management of, all procedural aspects of purchasing activities. Adapts contract management practices in changing circumstances whilst maintaining the overall intent of the contract.  " },
                    { 55, "Establishes delivery schedules, monitors progress, and contacts clients and suppliers to resolve problems in a work unit. Negotiates land acquisition or access rights for Coast Guard use, and may conduct field investigations of properties. Reviews and processes claims against suppliers. Monitors contract performance and identifies when corrective action needs to be taken to drive better outcomes. Assesses contract variations, and makes appropriate decisions based on risk. Invites tenders, consults with suppliers, and reviews quotations. Determines or negotiates contract terms and conditions, awards supplier contracts or recommend contract awards. Explores innovative contract management strategies for complex requirements with stakeholders.", "Establishes delivery schedules, monitors progress, and contacts clients and suppliers to resolve problems in a work unit. Negotiates land acquisition or access rights for Coast Guard use, and may conduct field investigations of properties. Reviews and processes claims against suppliers. Monitors contract performance and identifies when corrective action needs to be taken to drive better outcomes. Assesses contract variations, and makes appropriate decisions based on risk. Invites tenders, consults with suppliers, and reviews quotations. Determines or negotiates contract terms and conditions, awards supplier contracts or recommend contract awards. Explores innovative contract management strategies for complex requirements with stakeholders." },
                    { 56, "Plans, organizes, directs, controls, and evaluates the purchasing activities of one or more work units. Identifies vendors of materials, equipment, or supplies. Participates in the development of specifications for equipment, products, or substitute materials. Interprets and advises on the terms and conditions of the contract, and applies to varied and complex situations. Monitors, evaluates and reports on contract milestones, key performance indicators adherence, performance metrics, and outcomes. Oversees the management of contracts and categories, and reports on contract activities that may result in political or public interest. Defines and advises on contract management responsibilities and processes across the Coast Guard. Drives the use of innovative contract management strategies where appropriate to deliver the best outcome and maximize value. Develops purchasing policies and procedures and controls purchasing department budget, when and where applicable.", "Plans, organizes, directs, controls, and evaluates the purchasing activities of one or more work units. Identifies vendors of materials, equipment, or supplies. Participates in the development of specifications for equipment, products, or substitute materials. Interprets and advises on the terms and conditions of the contract, and applies to varied and complex situations. Monitors, evaluates and reports on contract milestones, key performance indicators adherence, performance metrics, and outcomes. Oversees the management of contracts and categories, and reports on contract activities that may result in political or public interest. Defines and advises on contract management responsibilities and processes across the Coast Guard. Drives the use of innovative contract management strategies where appropriate to deliver the best outcome and maximize value. Develops purchasing policies and procedures and controls purchasing department budget, when and where applicable." },
                    { 57, "Coordinates a variety of recruitment, training, performance evaluation, HR systems, and classification activities. Prepares and proofreads forms and documents for and between the workforce management team or clients. Runs reports. Ensures that workforce management-related material is signed, dated, distributed, maintained, and filed appropriately. ", "Coordinates a variety of recruitment, training, performance evaluation, HR systems, and classification activities. Prepares and proofreads forms and documents for and between the workforce management team or clients. Runs reports. Ensures that workforce management-related material is signed, dated, distributed, maintained, and filed appropriately. " },
                    { 58, "Compiles, maintains, and processes information relating to recruitment, training, performance evaluation, HR systems, or classification. Facilitates business line, workforce intelligence, succession planning, organizational awareness, and HR management practices. Arranges for advertising or posting job vacancies. Assists in screening of job applicants, and conducting of reference checks, when and where applicable.", "Compiles, maintains, and processes information relating to recruitment, training, performance evaluation, HR systems, or classification. Facilitates business line, workforce intelligence, succession planning, organizational awareness, and HR management practices. Arranges for advertising or posting job vacancies. Assists in screening of job applicants, and conducting of reference checks, when and where applicable." },
                    { 59, "Identifies job vacancies and prospective recruiting requirements. Provides advice to managers related to recruitment, training, or HR systems. Interprets and applies legislation and policies related to workforce management functions. Determines eligibility to entitlements, arranges and delivers member training. Provides information or services such as employee assistance, counselling, and recognition programs, when and where applicable. ", "Identifies job vacancies and prospective recruiting requirements. Provides advice to managers related to recruitment, training, or HR systems. Interprets and applies legislation and policies related to workforce management functions. Determines eligibility to entitlements, arranges and delivers member training. Provides information or services such as employee assistance, counselling, and recognition programs, when and where applicable. " },
                    { 60, "Implements and evaluates workforce management policies, programs, and procedures. Working closely with clients or the workforce management team, collaborates in developing the merit criteria, assessment tools, and employment equity programs, offering strategic staffing ideas and assisting with performance management or disability files according to portfolio. Provides advice on the interpretation of policies, staffing, training, and benefits programs. Maintains workforce management information and related records systems. Hires and oversees training of staff. Co-ordinates employee performance appraisal programs. ", "Implements and evaluates workforce management policies, programs, and procedures. Working closely with clients or the workforce management team, collaborates in developing the merit criteria, assessment tools, and employment equity programs, offering strategic staffing ideas and assisting with performance management or disability files according to portfolio. Provides advice on the interpretation of policies, staffing, training, and benefits programs. Maintains workforce management information and related records systems. Hires and oversees training of staff. Co-ordinates employee performance appraisal programs. " },
                    { 61, "Directs, controls, and evaluates the operations of the Canadian Coast Guard's workforce management discipline. Develops and implements policies, programs and procedures regarding workforce management planning, recruitment, training and development, and classification. Negotiates settlements of appeals and disputes and co-ordinates the termination of employment process, when and where applicable. Directs the organization's quality management program in relation to workforce management.", "Directs, controls, and evaluates the operations of the Canadian Coast Guard's workforce management discipline. Develops and implements policies, programs and procedures regarding workforce management planning, recruitment, training and development, and classification. Negotiates settlements of appeals and disputes and co-ordinates the termination of employment process, when and where applicable. Directs the organization's quality management program in relation to workforce management." },
                    { 62, "Adheres to budget controls as assigned. Articulates a 'value for money' mindset. Provides correct financial information as required. ", "Adheres to budget controls as assigned. Articulates a 'value for money' mindset. Provides correct financial information as required." },
                    { 63, "Monitors project/program expenditures and individual expenses for reporting purposes. Identifies wasteful financial practices or opportunities for greater efficiencies. Tracks and files variation reports. ", "Monitors project/program expenditures and individual expenses for reporting purposes. Identifies wasteful financial practices or opportunities for greater efficiencies. Tracks and files variation reports. " },
                    { 64, "Analyzes unit cash flow trends. Maintains financial records and compares trends by period and year. Prepares statistical, financial, and accounting reports. Verifies and evaluates procedures used for recording financial transactions, and makes recommendations for changes to procedures, systems, and other financial controls. Provides guidance to members. ", "Analyzes unit cash flow trends. Maintains financial records and compares trends by period and year. Prepares statistical, financial, and accounting reports. Verifies and evaluates procedures used for recording financial transactions, and makes recommendations for changes to procedures, systems, and other financial controls. Provides guidance to members. " },
                    { 65, "Analyzes broad accounting and financial records to ensure accuracy and compliance with established accounting standards and procedures. Plans, organizes, and administers financial tracking and reconciliation systems for Canadian Coast Guard programs and business lines. Prepares detailed reports and conducts audits to improve organizational financial management practices. Provides guidance to management. Designs, operates, and monitors rigorous systems for Financial Information Management, internal audit, and evaluation. ", "Analyzes broad accounting and financial records to ensure accuracy and compliance with established accounting standards and procedures. Plans, organizes, and administers financial tracking and reconciliation systems for Canadian Coast Guard programs and business lines. Prepares detailed reports and conducts audits to improve organizational financial management practices. Provides guidance to management. Designs, operates, and monitors rigorous systems for Financial Information Management, internal audit, and evaluation. " },
                    { 66, "Directs, controls, and evaluates the operation of financial and accounting departments. Reports on established trends with organizational recommendations for change. Ensures partner organizations, agencies, or governments understand the organization's complex fiscal issues. Develops and implements financial policies, establishes performance standards, and prepares various financial reports for senior management. Advises senior management on current and best practices in sound financial management practice and procedure. ", "Directs, controls, and evaluates the operation of financial and accounting departments. Reports on established trends with organizational recommendations for change. Ensures partner organizations, agencies, or governments understand the organization's complex fiscal issues. Develops and implements financial policies, establishes performance standards, and prepares various financial reports for senior management. Advises senior management on current and best practices in sound financial management practice and procedure. " },
                    { 67, "Conducts media monitoring and coverage analysis. Provides communication support services. Offers logistical support for media events and interviews.", "Conducts media monitoring and coverage analysis. Provides communication support services. Offers logistical support for media events and interviews." },
                    { 68, "Writes and edits a range of communications products. Supports social media and websites. Assists in the development and/or implementation of communications products. Contributes to implementing communication plans or projects in the digital environment. ", "Writes and edits a range of communications products. Supports social media and websites. Assists in the development and/or implementation of communications products. Contributes to implementing communication plans or projects in the digital environment. " },
                    { 69, "Produces communications products. Plans, coordinates, and/or implements announcements or special events such as town halls or media availabilities. Provides communication support to clients. Contributes to content of strategic communications plans. Monitors and analyzes multimedia coverage, providing tactical responses where requested. Uses social media to communicate in a government context. ", "Produces communications products. Plans, coordinates, and/or implements announcements or special events such as town halls or media availabilities. Provides communication support to clients. Contributes to content of strategic communications plans. Monitors and analyzes multimedia coverage, providing tactical responses where requested. Uses social media to communicate in a government context. " },
                    { 70, "Provides strategic communications advice to managers. Develops and implements marketing and/or advertising plans, storyboards, and videos. Evaluates communications plans and develops associated communications products, when and where required. Coordinates and/or works within inter-governmental or multi-departmental communications initiatives, projects, or strategies. Extracts subject-matter experts while executing segmentation and audience analysis. Assists senior management in conveying messages on behalf of the Coast Guard in an appropriate manner that is consistent with established Acts, policies, and practices. Establishes networks with Fisheries and Oceans Canada (DFO) communications partners.", "Provides strategic communications advice to managers. Develops and implements marketing and/or advertising plans, storyboards, and videos. Evaluates communications plans and develops associated communications products, when and where required. Coordinates and/or works within inter-governmental or multi-departmental communications initiatives, projects, or strategies. Extracts subject-matter experts while executing segmentation and audience analysis. Assists senior management in conveying messages on behalf of the Coast Guard in an appropriate manner that is consistent with established Acts, policies, and practices. Establishes networks with Fisheries and Oceans Canada (DFO) communications partners." },
                    { 71, "Organizes and coordinates ministerial events. Leads the development, implementation, and evaluation of communications plans. Develops specialized communications products. In partnership with Fisheries and Oceans Canada (DFO) communications partners, leads or participates in external and internal stakeholder collaboration and major event responses. Manages media relations for sensitive issues. Develops and implements proactive media outreach strategies. Plans and executes extensive electronic (web and social media) communications initiatives.", "Organizes and coordinates ministerial events. Leads the development, implementation, and evaluation of communications plans. Develops specialized communications products. In partnership with Fisheries and Oceans Canada (DFO) communications partners, leads or participates in external and internal stakeholder collaboration and major event responses. Manages media relations for sensitive issues. Develops and implements proactive media outreach strategies. Plans and executes extensive electronic (web and social media) communications initiatives." },
                    { 72, "Applies real property and accommodation management’s key elements and policies and identifies where to find related information. Supports activities related to real property and accommodation maintenance and operations. ", "Applies real property and accommodation management’s key elements and policies and identifies where to find related information. Supports activities related to real property and accommodation maintenance and operations. " },
                    { 73, "Assists in the writing of real property and/or accommodation management documents. Gathers information for planning, coordinating, and/or monitoring budgets. Assists in the search, analysis, and integration of information from different sources to formulate recommendations or action plans.", "Assists in the writing of real property and/or accommodation management documents. Gathers information for planning, coordinating, and/or monitoring budgets. Assists in the search, analysis, and integration of information from different sources to formulate recommendations or action plans." },
                    { 74, "Interprets policies, standards, directives, or codes related to office accommodations or real property construction projects. Plans, organizes, or implements office accommodation or real property construction projects and analyses information and provides recommendations to clients or management. ", "Interprets policies, standards, directives, or codes related to office accommodations or real property construction projects. Plans, organizes, or implements office accommodation or real property construction projects and analyses information and provides recommendations to clients or management. " },
                    { 75, "Monitors marine structure projects, when and where applicable. Develops systems and/or processes, guidelines, and policies for identifying, collecting, maintaining, and evaluating real property and accommodations management information. ", "Monitors marine structure projects, when and where applicable. Develops systems and/or processes, guidelines, and policies for identifying, collecting, maintaining, and evaluating real property and accommodations management information. " },
                    { 76, "Identifies and implements risk and performance management strategies in assessing and planning real property and/or accommodations management projects. Develops plans and strategies that address the variety and complexity of real property and accommodations management operations, use, and maintenance.", "Identifies and implements risk and performance management strategies in assessing and planning real property and/or accommodations management projects. Develops plans and strategies that address the variety and complexity of real property and accommodations management operations, use, and maintenance." },
                    { 77, "Describes the basic function of the business’s core systems. Defines objectives and success criteria of the specific role. Identifies sources of existing and potential information relating to the project. Documents consistently.", "Describes the basic function of the business’s core systems. Defines objectives and success criteria of the specific role. Identifies sources of existing and potential information relating to the project. Documents consistently." },
                    { 78, "Identifies key project milestones and defines project scope. Derives project estimates and quantifies uncertainty. Stores, references, and locates information in an efficient manner appropriate to the role. Validates, refines, and optimizes solution option models. Communicates difficult issues concisely and effectively to supervisors. Identifies potential areas of conflict and works to avoid their occurrence or their impact. ", "Identifies key project milestones and defines project scope. Derives project estimates and quantifies uncertainty. Stores, references, and locates information in an efficient manner appropriate to the role. Validates, refines, and optimizes solution option models. Communicates difficult issues concisely and effectively to supervisors. Identifies potential areas of conflict and works to avoid their occurrence or their impact. " },
                    { 79, "Identifies and minimizes risk to ongoing Coast Guard operations. Consistently identifies technology interfaces and focuses on integration aspects of projects. Identifies and defines proposed business benefits. Ensures planning tools and techniques are applied effectively. Through analysis of options, selects the option with the greatest business benefit bearing in mind the Coast Guard objectives. Articulates the vision, objectives, and benefits of a new initiative. Identifies current areas of conflict and seeks to understand apposing points of view. ", "Identifies and minimizes risk to ongoing Coast Guard operations. Consistently identifies technology interfaces and focuses on integration aspects of projects. Identifies and defines proposed business benefits. Ensures planning tools and techniques are applied effectively. Through analysis of options, selects the option with the greatest business benefit bearing in mind the Coast Guard objectives. Articulates the vision, objectives, and benefits of a new initiative. Identifies current areas of conflict and seeks to understand apposing points of view. " },
                    { 80, "Identifies and relays improvement opportunities and industry trends to the organization. Ensures a mechanism is in place to capture project risks, issues, and scope. Follows up with individuals and/or groups to clarify or complete the identified gaps and errors. Employees models to determine and communicate solution options. Makes recommendations with justifications to the appropriate decision making authority. ", "Identifies and relays improvement opportunities and industry trends to the organization. Ensures a mechanism is in place to capture project risks, issues, and scope. Follows up with individuals and/or groups to clarify or complete the identified gaps and errors. Employees models to determine and communicate solution options. Makes recommendations with justifications to the appropriate decision making authority. " },
                    { 81, "Identifies risks and impacts associated with proposed business options. Forecasts the impact of change. Applies effective influencing strategies. ", "Identifies risks and impacts associated with proposed business options. Forecasts the impact of change. Applies effective influencing strategies. " },
                    { 82, "Employs a fair and non-partisan approach in the delivery of services. Supports others in managing their tasks/responsibilities by providing timely information or resources. Accurately determines where to direct inquiries.", "Employs a fair and non-partisan approach in the delivery of services. Supports others in managing their tasks/responsibilities by providing timely information or resources. Accurately determines where to direct inquiries." },
                    { 83, "Establishes and maintains electronic and paper filing systems so that information can be readily retrieved. Actively promotes services to existing and potential clients. Anticipates potential problems and initiates ways of improving standards. Complies with existing quality standards, procedures, guidelines, and service agreements. Asks questions in order to clarify the needs and requirements associated with initial client requests. ", "Establishes and maintains electronic and paper filing systems so that information can be readily retrieved. Actively promotes services to existing and potential clients. Anticipates potential problems and initiates ways of improving standards. Complies with existing quality standards, procedures, guidelines, and service agreements. Asks questions in order to clarify the needs and requirements associated with initial client requests. " },
                    { 84, "Applies due diligence and sound judgment when responding to requests and dealing with confidential information. Quickly and effectively solves client’s problems including complaints. Serves Coast Guard clients with the understanding that service is a core principle of the organization.", "Applies due diligence and sound judgment when responding to requests and dealing with confidential information. Quickly and effectively solves client’s problems including complaints. Serves Coast Guard clients with the understanding that service is a core principle of the organization." },
                    { 85, "Develops standards of service delivery beyond those generally accepted. Promotes innovative measures to address client service needs. Deals with stakeholders professionally while representing the Coastg Guard. ", "Develops standards of service delivery beyond those generally accepted. Promotes innovative measures to address client service needs. Deals with stakeholders professionally while representing the Coastg Guard. " },
                    { 86, "Strategically and systematically evaluates opportunities within a sector, field, or area to improve client service in a non-partisan manner. Develops and implements creative and innovative ways of meeting client needs, whether in the regions or in headquarters.", "Strategically and systematically evaluates opportunities within a sector, field, or area to improve client service in a non-partisan manner. Develops and implements creative and innovative ways of meeting client needs, whether in the regions or in headquarters." },
                    { 87, "Identifies irregular workforce management practices. Seeks advice when workforce management issues arise. ", "Identifies irregular workforce management practices. Seeks advice when workforce management issues arise. " },
                    { 88, "Provides basic HR-related information to colleagues, members, and others. Identifies deviations in applications of HR procedures or validates them with the competent authority. Supervises a small unit and conducts performance management input. ", "Provides basic HR-related information to colleagues, members, and others. Identifies deviations in applications of HR procedures or validates them with the competent authority. Supervises a small unit and conducts performance management input. " },
                    { 89, "Addresses standard workforce management issues within areas of responsibility (AOR). Supervises or manages staff (operational or administrative). Provides performance feedback. Aligns workforce management practices to audit results and findings, when and where applicable. Provides on-the-job training and makes training and development recommendations. Participates on staffing boards and provides input into statements of merit criteria, when and where required.", "Addresses standard workforce management issues within areas of responsibility (AOR). Supervises or manages staff (operational or administrative). Provides performance feedback. Aligns workforce management practices to audit results and findings, when and where applicable. Provides on-the-job training and makes training and development recommendations. Participates on staffing boards and provides input into statements of merit criteria, when and where required." },
                    { 90, "Manages a unit. Participates on staffing boards and drafts statements of merit criteria, and, where applicable, conducts assessments. Manages unit member performance, including the development of objectives, learning plans, talent management and action plans, and dealing with disciplinary matters. Analyzes and forecasts workforce management needs and initiates required succession planning processes. Approves training requests by considering value for money. ", "Manages a unit. Participates on staffing boards and drafts statements of merit criteria, and, where applicable, conducts assessments. Manages unit member performance, including the development of objectives, learning plans, talent management and action plans, and dealing with disciplinary matters. Analyzes and forecasts workforce management needs and initiates required succession planning processes. Approves training requests by considering value for money. " },
                    { 91, "Manages several units or projects. Develops complex workforce management plans that capitalize on recruitment, performance management, etc. Exercises an influence on Canadian Coast Guard workforce management strategic planning and development, succession planning, and other workforce management areas. Contributes to linking policies and systems to performance management processes, competencies, and performance outcomes in support of broader organizational goals. Ensures alignment of workforce management plans with the objectives of the Coast Guard's overall program strategy.", "Manages several units or projects. Develops complex workforce management plans that capitalize on recruitment, performance management, etc. Exercises an influence on Canadian Coast Guard workforce management strategic planning and development, succession planning, and other workforce management areas. Contributes to linking policies and systems to performance management processes, competencies, and performance outcomes in support of broader organizational goals. Ensures alignment of workforce management plans with the objectives of the Coast Guard's overall program strategy." },
                    { 92, "Prepares and processes bills, invoices, accounts payable and receivable. Enters data into financial tracking systems according to established procedures.", "Prepares and processes bills, invoices, accounts payable and receivable. Enters data into financial tracking systems according to established procedures." },
                    { 93, "Maintains Coast Guard unit assets and property (e.g. office equipment, vehicles, information databases, etc.). Updates budgets and projections. Purchases with credit cards when required. Runs salary and Operations and Maintenance (O&M) reports and statements for managers. Makes budget entries and reconciles accounts with rationales. Tracks and analyzes unit cash flow.", "Maintains Coast Guard unit assets and property (e.g. office equipment, vehicles, information databases, etc.). Updates budgets and projections. Purchases with credit cards when required. Runs salary and Operations and Maintenance (O&M) reports and statements for managers. Makes budget entries and reconciles accounts with rationales. Tracks and analyzes unit cash flow." },
                    { 94, "Articulates the processes by which financial resources are identified, obtained, allocated, managed and accounted for. Makes sound financial decisions after having analyzed their impact on the organization and operations within the scope of fiscal responsibilities. Monitors the use of Coast Guard financial resources and budgets by employees, suppliers, partners or others. Complies with legislation, policies and practices applicable to the appropriate and effective use of financial resources. Takes a significant role in preparing budgets and forecasts for projects and initiatives.", "Articulates the processes by which financial resources are identified, obtained, allocated, managed and accounted for. Makes sound financial decisions after having analyzed their impact on the organization and operations within the scope of fiscal responsibilities. Monitors the use of Coast Guard financial resources and budgets by employees, suppliers, partners or others. Complies with legislation, policies and practices applicable to the appropriate and effective use of financial resources. Takes a significant role in preparing budgets and forecasts for projects and initiatives." },
                    { 95, "Ensures adequate internal control systems over the Coast Guard's financial assets, investments, liabilities, revenues, and expenditures. Manages financial and accounting responsibilities for large programs or multiple business lines. Identifies additional or alternative financial resources and opportunities for funding organization-wide projects, programs, research centers and/or services, etc. Acts on audit, evaluation, and other objective financial performance information. Sets up and manages income and expenditure monitoring systems and keeps these systems under close review and makes improvements where relevant. Uses delegated authority to purchase supplies for the work group. Performs a variety of financial management practices such as: budgeting, forecasting, cost benefits, risk analysis. ", "Ensures adequate internal control systems over the Coast Guard's financial assets, investments, liabilities, revenues, and expenditures. Manages financial and accounting responsibilities for large programs or multiple business lines. Identifies additional or alternative financial resources and opportunities for funding organization-wide projects, programs, research centers and/or services, etc. Acts on audit, evaluation, and other objective financial performance information. Sets up and manages income and expenditure monitoring systems and keeps these systems under close review and makes improvements where relevant. Uses delegated authority to purchase supplies for the work group. Performs a variety of financial management practices such as: budgeting, forecasting, cost benefits, risk analysis. " },
                    { 96, "Ensures framework is in place for sound financial planning, management, control and reporting (i.e. spanning pay, capital, Operations and Maintenance [O&M] costs and revenues). Ensures processes and infrastructure provide managers with integrated financial and non-financial performance information, a mature approach to risk management, appropriate control systems, and a shared set of values and ethics. ", "Ensures framework is in place for sound financial planning, management, control and reporting (i.e. spanning pay, capital, Operations and Maintenance [O&M] costs and revenues). Ensures processes and infrastructure provide managers with integrated financial and non-financial performance information, a mature approach to risk management, appropriate control systems, and a shared set of values and ethics. " },
                    { 97, "Recognizes relations between shipboard departments and how they interact and the role of the cooks and stewards. Actively learns meal planning and storage protocols.", "Recognizes relations between shipboard departments and how they interact and the role of the cooks and stewards. Actively learns meal planning and storage protocols." },
                    { 98, "Manages the logistics department in the absence of a supply officer. Consults with the cook and steward in managing storage and purchasing protocols. Assists in menu planning. ", "Manages the logistics department in the absence of a supply officer. Consults with the cook and steward in managing storage and purchasing protocols. Assists in menu planning. " },
                    { 99, "Manages the logistics department in the absence of a logistics officer. Consults with the chief cook in preparing menus. Consults with the steward on matters pertaining to accommodation. Establishes requirements for the requisition, receipt, storage, and distribution of supplies. Collaborates with the engine room department in the loading of stores.", "Manages the logistics department in the absence of a logistics officer. Consults with the chief cook in preparing menus. Consults with the steward on matters pertaining to accommodation. Establishes requirements for the requisition, receipt, storage, and distribution of supplies. Collaborates with the engine room department in the loading of stores." },
                    { 100, "Manages the logistics department as a supply officer. Consults with the chief cook in preparing menus. Consults with the steward on matters pertaining to accommodation, sanitation, and laundry facilities. Establishes requirements and procedures for the requisition, receipt, storage, and distribution of supplies. Collaborates with officers of the engine room department in the loading and moving of stores and supplies.", "Manages the logistics department as a supply officer. Consults with the chief cook in preparing menus. Consults with the steward on matters pertaining to accommodation, sanitation, and laundry facilities. Establishes requirements and procedures for the requisition, receipt, storage, and distribution of supplies. Collaborates with officers of the engine room department in the loading and moving of stores and supplies." },
                    { 101, "Manages the logistics department as a logistics officer. Consults with the chief cook and steward in all matters pertaining to shipboard hotel provisions and systems. Consults with shoreside stakeholders and conducts logistics audits and training at sea and ashore. ", "Manages the logistics department as a logistics officer. Consults with the chief cook and steward in all matters pertaining to shipboard hotel provisions and systems. Consults with shoreside stakeholders and conducts logistics audits and training at sea and ashore. " },
                    { 102, "Cites relevant sections of acts and regulations pertaining to maritime security operations centres (MSOC) (Privacy Act, Oceans Act, etc.). Identifies memoranda of understandings (MOUs) and service level agreements (SLAs) in place. Observes and records data for analysis from various sources.", "Cites relevant sections of acts and regulations pertaining to maritime security operations centres (MSOC) (Privacy Act, Oceans Act, etc.). Identifies memoranda of understandings (MOUs) and service level agreements (SLAs) in place. Observes and records data for analysis from various sources." },
                    { 103, "Identifies legal and regulatory limitations related to operations. Applies appropriate document classification to reports. Undertakes basic assignments in surveillance activities. Observes radar feeds and identifies basic trends, patterns, and anomalies.", "Identifies legal and regulatory limitations related to operations. Applies appropriate document classification to reports. Undertakes basic assignments in surveillance activities. Observes radar feeds and identifies basic trends, patterns, and anomalies." },
                    { 104, "Applies various constraints imposed by legislation and agreements by considering information sharing limitations when distributing products and/or information. Provides regular vessel tracking updates to partners as required. Analyzes information to contribute to products such as threat/risk assessments. Compiles and filters data received from partners for duplicates and unknowns. ", "Applies various constraints imposed by legislation and agreements by considering information sharing limitations when distributing products and/or information. Provides regular vessel tracking updates to partners as required. Analyzes information to contribute to products such as threat/risk assessments. Compiles and filters data received from partners for duplicates and unknowns. " },
                    { 105, "Incorporates legal opinions into procedures and processes. Identifies new sources of information. Produces vessel movement analysis based on historical data from various sources. Identifies surveillance gaps to recommend new products to fill gaps. Advises management on potential maritime threats/risks when no obvious warning is present. Conceives new maritime security initiatives to expand services and products within Fisheries and Oceans Canada (DFO).", "Incorporates legal opinions into procedures and processes. Identifies new sources of information. Produces vessel movement analysis based on historical data from various sources. Identifies surveillance gaps to recommend new products to fill gaps. Advises management on potential maritime threats/risks when no obvious warning is present. Conceives new maritime security initiatives to expand services and products within Fisheries and Oceans Canada (DFO)." },
                    { 106, "Develops formalized collection plans. Provides advice on maritime security incidents. Identifies new products to assist partners and clients in identifying potential threats. Collaborates with partners to develop maritime security operations centres (MSOC) products. Recommends capability of Canadian Coast Guard assets to and works with other government departments (OGDs) during maritime security events. Influences Coast Guard maritime security policy utilizing knowledge of partners changing initiatives, policies, and mandates.", "Develops formalized collection plans. Provides advice on maritime security incidents. Identifies new products to assist partners and clients in identifying potential threats. Collaborates with partners to develop maritime security operations centres (MSOC) products. Recommends capability of Canadian Coast Guard assets to and works with other government departments (OGDs) during maritime security events. Influences Coast Guard maritime security policy utilizing knowledge of partners changing initiatives, policies, and mandates." },
                    { 107, "Reports and logs observed non-conformities. ", "Reports and logs observed non-conformities. " },
                    { 108, "Participates in reviews and drafts quality assurance reports. Researches and compares findings against standard operating procedures or design specifications.", "Participates in reviews and drafts quality assurance reports. Researches and compares findings against standard operating procedures or design specifications." },
                    { 109, "Implements the Canadian Coast Guard's quality assurance program. Interprets a wide variety of data and makes recommendations. Formulates recommendations for, or where appropriate, develops options to resolve non-conformities.", "Implements the Canadian Coast Guard's quality assurance program. Interprets a wide variety of data and makes recommendations. Formulates recommendations for, or where appropriate, develops options to resolve non-conformities." },
                    { 110, "Defines and articulates parameters and desired objectives, encouraging others to adopt and deliver on those objectives. Applies the constraints within which information can or cannot be shared. Assists in developing quality assurance (QA) programs. Provides summary reports detailing QA findings.", "Defines and articulates parameters and desired objectives, encouraging others to adopt and deliver on those objectives. Applies the constraints within which information can or cannot be shared. Assists in developing quality assurance (QA) programs. Provides summary reports detailing QA findings." },
                    { 111, "Champions the Coast Guard's quality assurance (QA) program and systems. Develops creative and innovative programs, projects, and activities. Advises stakeholders on QA protocols and best practices. ", "Champions the Coast Guard's quality assurance (QA) program and systems. Develops creative and innovative programs, projects, and activities. Advises stakeholders on QA protocols and best practices. " },
                    { 112, "Requests supplies based on demand. Ensures that proper receipt, identification, and inspection is carried out for all incoming materiel.", "Requests supplies based on demand. Ensures that proper receipt, identification, and inspection is carried out for all incoming materiel." },
                    { 113, "Requests parts and supplies from internal stocks using approved classification system. Understands and follows the inventory management system (IMS). Processes special and emergency requirements of all clients.", "Requests parts and supplies from internal stocks using approved classification system. Understands and follows the inventory management system (IMS). Processes special and emergency requirements of all clients." },
                    { 114, "Receives, stores, issues, and records materiel according to approved inventory management system (IMS) and categories of materiel. Ensures that materiel held in stock is properly identified, catalogued, and incorporated in the centralized cataloguing files. Ensures that inventory is managed in accordance with Acts and regulations, when and where applicable. Maintains commitment control records for materiel requisitioned for stock and for non-stocked items.", "Receives, stores, issues, and records materiel according to approved inventory management system (IMS) and categories of materiel. Ensures that materiel held in stock is properly identified, catalogued, and incorporated in the centralized cataloguing files. Ensures that inventory is managed in accordance with Acts and regulations, when and where applicable. Maintains commitment control records for materiel requisitioned for stock and for non-stocked items." },
                    { 115, "Uses supplier classifications systems and cross-reference tables where available. Performs a full systematic process of developing, operating, maintaining, upgrading, and disposing, including commissioning and decommissioning of vessels as they relate to fleet operations, when and where applicable. ", "Uses supplier classifications systems and cross-reference tables where available. Performs a full systematic process of developing, operating, maintaining, upgrading, and disposing, including commissioning and decommissioning of vessels as they relate to fleet operations, when and where applicable. " },
                    { 116, "Attends national meetings and represents regional interests in the area of materiel management. Advises and guides management on cost-effective approaches. Tests new software and innovative approaches within the field. Trains and guides employees within the materiel management field, when and where applicable.", "Attends national meetings and represents regional interests in the area of materiel management. Advises and guides management on cost-effective approaches. Tests new software and innovative approaches within the field. Trains and guides employees within the materiel management field, when and where applicable." },
                    { 117, "Provides input into basic exercise plans.", "Provides input into basic exercise plans." },
                    { 118, "Participates in and validates discussion-based exercises in talking through plan finalization.  ", "Participates in and validates discussion-based exercises in talking through plan finalization.  " },
                    { 119, "Produces and validates tabletop exercises, which stimulate the divisions between responders needing to communicate and be coordinated, where the participants are expected to know the plan and test it for procedural weaknesses. ", "Produces and validates tabletop exercises, which stimulate the divisions between responders needing to communicate and be coordinated, where the participants are expected to know the plan and test it for procedural weaknesses. " },
                    { 120, "Produces and validates live exercises in order to help participants develop skills  and confidence, testing logistics and physical capabilities, and providing experience of what it would be like to use a plan or procedure in real life. ", "Produces and validates live exercises in order to help participants develop skills  and confidence, testing logistics and physical capabilities, and providing experience of what it would be like to use a plan or procedure in real life. " },
                    { 121, "Proposes, develops, trials, and validates all types of exercises, including discussion-based, table top, and live. Uses hotwash and lesson learned functions to propose changes and new exercises. Consults on developing testing exercises and training others. ", "Proposes, develops, trials, and validates all types of exercises, including discussion-based, table top, and live. Uses hotwash and lesson learned functions to propose changes and new exercises. Consults on developing testing exercises and training others. " },
                    { 122, "Assesses learners’ prior knowledge, learning needs, and career and college readiness goals. Sets learning goals and a course of study. Monitors learning through summative and formative assessment. ", "Assesses learners’ prior knowledge, learning needs, and career and college readiness goals. Sets learning goals and a course of study. Monitors learning through summative and formative assessment. " },
                    { 123, "Designs learner-centered classroom environments. Designs standards-based instructional units. Uses instructional techniques that are relevant and effective with adult learners. ", "Designs learner-centered classroom environments. Designs standards-based instructional units. Uses instructional techniques that are relevant and effective with adult learners. " },
                    { 124, "Communicates high expectations of learners on Coast Guard employment in motivating them to meet  goals. Delivers lessons in a professional, clear, and understandable way. Engages in active listening, dialogue, and questioning to facilitate and support learning.", "Communicates high expectations of learners on Coast Guard employment in motivating them to meet  goals. Delivers lessons in a professional, clear, and understandable way. Engages in active listening, dialogue, and questioning to facilitate and support learning." },
                    { 125, "Participates in professional development networks and learning communities. Shares content and pedagogical resources with program staff in collaborative professional development projects. Refines instructional practices through reflection on experience, evidence, and data. Designs instruction to build learners’ subject matter of expertise skills (i.e. marine skills in the Coast Guard). ", "Participates in professional development networks and learning communities. Shares content and pedagogical resources with program staff in collaborative professional development projects. Refines instructional practices through reflection on experience, evidence, and data. Designs instruction to build learners’ subject matter of expertise skills (i.e. marine skills in the Coast Guard). " },
                    { 126, "Champions a training environment featuring maximum flexibility, creativity, and passion, encouraging questions and discussion. Models an understanding of diversity in self and in students.", "Champions a training environment featuring maximum flexibility, creativity, and passion, encouraging questions and discussion. Models an understanding of diversity in self and in students." },
                    { 127, "Reads the Government of Canada's Values and Ethics Code. Behaves consistently with the Values and Ethics Code and seeks appropriate guidance when required. ", "Reads the Government of Canada's Values and Ethics Code. Behaves consistently with the Values and Ethics Code and seeks appropriate guidance when required. " },
                    { 128, "Uses government assets responsibly. Discusses ethical concerns with their supervisor or colleagues and, when necessary, seeks and follows appropriate disclosure procedures.", "Uses government assets responsibly. Discusses ethical concerns with their supervisor or colleagues and, when necessary, seeks and follows appropriate disclosure procedures." },
                    { 129, "Works in a manner that reflects a commitment to public service excellence. Assists peers respectfully when dealing with ethical concerns. Recognizes the importance of diversity, and bilingualism. Is well versed in the Government of Canada's Values and Ethics Code. Demonstrates respect for government property and policies.", "Works in a manner that reflects a commitment to public service excellence. Assists peers respectfully when dealing with ethical concerns. Recognizes the importance of diversity, and bilingualism. Is well versed in the Government of Canada's Values and Ethics Code. Demonstrates respect for government property and policies." },
                    { 130, "Consistently balances national, regional, and site specific ethical priorities. Actively promotes integrity, diversity, bilingualism, and respect through work behaviour and the workplace.  ", "Consistently balances national, regional, and site specific ethical priorities. Actively promotes integrity, diversity, bilingualism, and respect through work behaviour and the workplace.  " },
                    { 131, "Models public service before self. Assists and advises on issues with national and/or legal implications. Champions diversity and bilingualism. Acts with transparency and fairness. Enforces the appropriate use of government assets and resources.", "Models public service before self. Assists and advises on issues with national and/or legal implications. Champions diversity and bilingualism. Acts with transparency and fairness. Enforces the appropriate use of government assets and resources." },
                    { 132, "Breaks down concrete problems into parts and organizes information. Recognizes pertinent facts and issues that make up a problem. Asks standard questions and follows first line of investigation to identify the key elements of a situation or problem. Uses known procedures and standard operating models.", "Breaks down concrete problems into parts and organizes information. Recognizes pertinent facts and issues that make up a problem. Asks standard questions and follows first line of investigation to identify the key elements of a situation or problem. Uses known procedures and standard operating models." },
                    { 133, "Researches available options to recommend a solution. Understands the Coast Guard's operational and organizational goals and strategies, and aligns activities towards the vision and strategic imperatives. ", "Researches available options to recommend a solution. Understands the Coast Guard's operational and organizational goals and strategies, and aligns activities towards the vision and strategic imperatives. " },
                    { 134, "Analyzes multiple causal relationships among several parts of a problem or situation. Anticipates the risks or implications inherent in a suggested plan of action and devises appropriate strategies to mitigate their impact. Makes a well-reasoned response even when faced with incomplete or contradictory information. Synthesizes complex ideas, issues, and observations into a clear understanding. Thinks beyond the work environment and makes decisions in the context of the bigger picture. ", "Analyzes multiple causal relationships among several parts of a problem or situation. Anticipates the risks or implications inherent in a suggested plan of action and devises appropriate strategies to mitigate their impact. Makes a well-reasoned response even when faced with incomplete or contradictory information. Synthesizes complex ideas, issues, and observations into a clear understanding. Thinks beyond the work environment and makes decisions in the context of the bigger picture. " },
                    { 135, "Identifies several potential causes of events or multiple-part consequences. Analyzes complex, evolving circumstances and takes corrective action to avoid resource constraints and meet deadlines. Compares and contrasts evidence and information from various sources in a comprehensive and time sensitive manner. Understands program interdependencies and the need to integrate activities across functions/areas related to project planning, program implementation, and evaluation. Creates strategic alignment between cross-functional teams. Thinks laterally about business problems and opportunities; sees how the work and efforts of other Coast Guard teams/functions/operational centres intertwine to meet broad objectives.", "Identifies several potential causes of events or multiple-part consequences. Analyzes complex, evolving circumstances and takes corrective action to avoid resource constraints and meet deadlines. Compares and contrasts evidence and information from various sources in a comprehensive and time sensitive manner. Understands program interdependencies and the need to integrate activities across functions/areas related to project planning, program implementation, and evaluation. Creates strategic alignment between cross-functional teams. Thinks laterally about business problems and opportunities; sees how the work and efforts of other Coast Guard teams/functions/operational centres intertwine to meet broad objectives." },
                    { 136, "Thinks strategically about the range of market and business issues likely to impact the Coast Guard's ability to fulfill its mandate. Uses a sound understanding of the organization's strengths and weaknesses, its key stakeholders, and its long-term organizational strategy to leverage decisions of varying scope. ", "Thinks strategically about the range of market and business issues likely to impact the Coast Guard's ability to fulfill its mandate. Uses a sound understanding of the organization's strengths and weaknesses, its key stakeholders, and its long-term organizational strategy to leverage decisions of varying scope. " },
                    { 137, "Encourages members of the team to contribute to a process. Listens and asks questions. Expresses appreciation to others who have provided information assistance or support. Deals proactively with interpersonal matters that could affect team performance.", "Encourages members of the team to contribute to a process. Listens and asks questions. Expresses appreciation to others who have provided information assistance or support. Deals proactively with interpersonal matters that could affect team performance." },
                    { 138, "Solicits opinions and viewpoints of team members. Cultivates personal bonds with colleagues in order to enhance performance throughout the organization. Discusses issues and exchanges information with partners to identify areas of mutual interest and benefit. Draws on other groups to facilitate project execution or persuade others. Manages personal work-life balance and respects the work-life balance of others.", "Solicits opinions and viewpoints of team members. Cultivates personal bonds with colleagues in order to enhance performance throughout the organization. Discusses issues and exchanges information with partners to identify areas of mutual interest and benefit. Draws on other groups to facilitate project execution or persuade others. Manages personal work-life balance and respects the work-life balance of others." },
                    { 139, "Effectively promotes a respectful and positive work environment. Recognizes diverse needs and perspectives (e.g. language differences, cultural differences, disabilities, and personal family circumstances). Recognizes individuals' achievements, knowledge, and capabilities. Monitors the work environment, successfully identifies underlying issues that impact negatively on people, and takes appropriate action, when and where applicable. Seeks and influences new relationships outside own unit and identifies new collaborative partnerships that better position of the Coast Guard's programs and services. Identifies and creates opportunities to partner through networking and participating in cross-functional, multi-stakeholder groups.", "Effectively promotes a respectful and positive work environment. Recognizes diverse needs and perspectives (e.g. language differences, cultural differences, disabilities, and personal family circumstances). Recognizes individuals' achievements, knowledge, and capabilities. Monitors the work environment, successfully identifies underlying issues that impact negatively on people, and takes appropriate action, when and where applicable. Seeks and influences new relationships outside own unit and identifies new collaborative partnerships that better position of the Coast Guard's programs and services. Identifies and creates opportunities to partner through networking and participating in cross-functional, multi-stakeholder groups." },
                    { 140, "Models and promotes a culture of respect, fairness, and trust. Proficient in capitalizing on the strengths of team members. Encourages members of the team to contribute to a process, and seeks consensus. Always actively works with other teams to ensure that broader common goals are met. Builds and nurtures effective and collaborative networks and relationships with communities of practice, colleagues, and stakeholders.", "Models and promotes a culture of respect, fairness, and trust. Proficient in capitalizing on the strengths of team members. Encourages members of the team to contribute to a process, and seeks consensus. Always actively works with other teams to ensure that broader common goals are met. Builds and nurtures effective and collaborative networks and relationships with communities of practice, colleagues, and stakeholders." },
                    { 141, "Advises others in dealing with ethical dilemmas, displaying sensitivity to diversity, and diverse needs in all dealings and relationships, and in maintaining fairness, consistency, and equity. Challenges current organizational behaviours and methods of operating, when and where applicable. Sets direction in terms of ethical standards and values for the organization. Draws on internal and external networks to help ensure buy-in and ownership; enhances the visibility of the Coast Guard's operations in the broader public sphere.", "Advises others in dealing with ethical dilemmas, displaying sensitivity to diversity, and diverse needs in all dealings and relationships, and in maintaining fairness, consistency, and equity. Challenges current organizational behaviours and methods of operating, when and where applicable. Sets direction in terms of ethical standards and values for the organization. Draws on internal and external networks to help ensure buy-in and ownership; enhances the visibility of the Coast Guard's operations in the broader public sphere." },
                    { 142, "Completes work assignments. Balances work to meet commitments and deadlines by being focused on goals.", "Completes work assignments. Balances work to meet commitments and deadlines by being focused on goals." },
                    { 143, "Responds to issues and/or brings concerns forward rather than waiting for them to be reported by someone else. Looks for new opportunities and seizes them when they arise. Plans for contingencies to deal with unexpected events. Structures work in order to achieve required results. ", "Responds to issues and/or brings concerns forward rather than waiting for them to be reported by someone else. Looks for new opportunities and seizes them when they arise. Plans for contingencies to deal with unexpected events. Structures work in order to achieve required results. " },
                    { 144, "Considers ideas from a variety of sources in order to solve problems. Remains flexible to find alternate ways around obstacles/barriers to achieve goals. Takes calculated risks to achieve goals/outcomes. Perseveres in seeking solutions despite obstacles. Regularly evaluate and challenges work processes. Establishes effective organizational methods for assigning, managing, and tracking work, when and where applicable. Solicits and/or provides information that could affect the planning, programs, and decision-making for the Canadian Coast Guard.", "Considers ideas from a variety of sources in order to solve problems. Remains flexible to find alternate ways around obstacles/barriers to achieve goals. Takes calculated risks to achieve goals/outcomes. Perseveres in seeking solutions despite obstacles. Regularly evaluate and challenges work processes. Establishes effective organizational methods for assigning, managing, and tracking work, when and where applicable. Solicits and/or provides information that could affect the planning, programs, and decision-making for the Canadian Coast Guard." },
                    { 145, "Offers expertise to resolve problems. Plans ahead to address future requirements without being asked. Anticipates and responds in a proactive manner to future needs of internal or external clients or groups. Coaches, supports, and encourages others to test limits, when and where applicable. Seeks new opportunities to improve outcomes using innovative approaches to overcome obstacles and surpass performance goals.", "Offers expertise to resolve problems. Plans ahead to address future requirements without being asked. Anticipates and responds in a proactive manner to future needs of internal or external clients or groups. Coaches, supports, and encourages others to test limits, when and where applicable. Seeks new opportunities to improve outcomes using innovative approaches to overcome obstacles and surpass performance goals." },
                    { 146, "Sets standards and criteria for measuring success organizationally. Seizes opportunities and initiatives across organizational boundaries to achieve efficiencies consistent with the Coast Guard's vision. Creates an environment in which all systems and processes support high levels of efficiency. Champions the ongoing spirit of improvement and professional growth across the organization.", "Sets standards and criteria for measuring success organizationally. Seizes opportunities and initiatives across organizational boundaries to achieve efficiencies consistent with the Coast Guard's vision. Creates an environment in which all systems and processes support high levels of efficiency. Champions the ongoing spirit of improvement and professional growth across the organization." },
                    { 147, "Awareness of the importance of safety in the Canadian Coast Guard. Familiar with the joining safety package.", "Awareness of the importance of safety in the Canadian Coast Guard. Familiar with the joining safety package." },
                    { 148, "Evaluates environment and adapts work to maintain safety. Ensures safety training is up to date. Uses appropriate personal protective equipment (PPE) when and where applicable. Applies proper safety procedures.", "Evaluates environment and adapts work to maintain safety. Ensures safety training is up to date. Uses appropriate personal protective equipment (PPE) when and where applicable. Applies proper safety procedures." },
                    { 149, "Conducts operations consistent with the Coast Guard Safety Management System (SMS), national and regulatory safety procedures, and policy when and where applicable. Understands the risks and manages safety and health issues when and where applicable. May participate in occupational health and safety groups and audits. ", "Conducts operations consistent with the Coast Guard Safety Management System (SMS), national and regulatory safety procedures, and policy when and where applicable. Understands the risks and manages safety and health issues when and where applicable. May participate in occupational health and safety groups and audits. " },
                    { 150, "Promotes a culture of unit safety. Ensures required personnel under supervision are trained in first aid and safety procedures. Ensures personnel under supervision apply safety plans and principles. Integrates health and safety planning in conformity with Incident Command Systems (ICS) principles when and where applicable. Integrates health and safety considerations in post-incident and post-exercise reviews.", "Promotes a culture of unit safety. Ensures required personnel under supervision are trained in first aid and safety procedures. Ensures personnel under supervision apply safety plans and principles. Integrates health and safety planning in conformity with Incident Command Systems (ICS) principles when and where applicable. Integrates health and safety considerations in post-incident and post-exercise reviews." },
                    { 151, "Promotes and integrates a culture of organizational safety. Develops risk analyses for responders and senior personnel regarding health and safety. Ensures required personnel are trained in first aid and safety procedures, as required. Leverages health and safety lessons learned from post-incident and post-exercise reviews in daily operations. ", "Promotes and integrates a culture of organizational safety. Develops risk analyses for responders and senior personnel regarding health and safety. Ensures required personnel are trained in first aid and safety procedures, as required. Leverages health and safety lessons learned from post-incident and post-exercise reviews in daily operations. " },
                    { 152, "Listens to leaders and emulates positive behaviour through observation and imitation, when and where applicable. Recognizes personal limitations and is motivated to address and improve them. ", "Listens to leaders and emulates positive behaviour through observation and imitation, when and where applicable. Recognizes personal limitations and is motivated to address and improve them. " },
                    { 153, "Adapts to change to help the team evolve in conjunction with the Coast Guard's evolving concerns. Seizes opportunities to increase skills and knowledge about operations, members, and stakeholders, when and where applicable. ", "Adapts to change to help the team evolve in conjunction with the Coast Guard's evolving concerns. Seizes opportunities to increase skills and knowledge about operations, members, and stakeholders, when and where applicable. " },
                    { 154, "Demonstrates interest in team members' success and well-being by listening and actively viewing situations through others' perspectives. Identifies strengths, leverages them, and persuades others for the benefit of the Coast Guard. Routinely teaches and guides work, based on operational knowledge through direct and indirect means. Seeks solutions by charting opinions and options.", "Demonstrates interest in team members' success and well-being by listening and actively viewing situations through others' perspectives. Identifies strengths, leverages them, and persuades others for the benefit of the Coast Guard. Routinely teaches and guides work, based on operational knowledge through direct and indirect means. Seeks solutions by charting opinions and options." },
                    { 155, "Links members' individual development to organizational objectives and developing future leaders. Encourages innovation. Remains effective in the face of obstacles. Identifies and assesses risks in projects or decisions and produces realistic contingency plans to mitigate possible impacts. Exercises positive influence on the organization when needed. ", "Links members' individual development to organizational objectives and developing future leaders. Encourages innovation. Remains effective in the face of obstacles. Identifies and assesses risks in projects or decisions and produces realistic contingency plans to mitigate possible impacts. Exercises positive influence on the organization when needed. " },
                    { 156, "Sets and champions organizational directions. Recognizes the big picture and cultivates organizational vision. Prioritizes the creation of a work environment that propels teams to step up to new challenges. Seamlessly assumes next level responsibilities. Regularly exercises persuasive influence on the organization in a wide variety of tactical and strategic areas.", "Sets and champions organizational directions. Recognizes the big picture and cultivates organizational vision. Prioritizes the creation of a work environment that propels teams to step up to new challenges. Seamlessly assumes next level responsibilities. Regularly exercises persuasive influence on the organization in a wide variety of tactical and strategic areas." },
                    { 157, "Articulates pride in being a member of the Coast Guard. Wears and maintains the uniform properly, when and where applicable.", "Articulates pride in being a member of the Coast Guard. Wears and maintains the uniform properly, when and where applicable." },
                    { 158, "Expresses pride in the humanitarian and environmental nature of the Coast Guard's mission. Participates in organizational engagement activities. Wears the uniform proudly.", "Expresses pride in the humanitarian and environmental nature of the Coast Guard's mission. Participates in organizational engagement activities. Wears the uniform proudly." },
                    { 159, "Expresses pride in the Coast Guard's regional and/or national achievements. Incorporates and models the Coast Guard's ambitious vision and motto in daily practice and supports it within units. Articulates the Coast Guard's vision when providing advice or instructions internally. ", "Expresses pride in the Coast Guard's regional and/or national achievements. Incorporates and models the Coast Guard's ambitious vision and motto in daily practice and supports it within units. Articulates the Coast Guard's vision when providing advice or instructions internally. " },
                    { 160, "Propagates the Coast Guard's vision, mission, mandate, and programs internally and externally as an example of deep pride in the organization. Conveys the importance of the Coast Guard's work to members and stakeholders. Celebrates organizational achievements.", "Propagates the Coast Guard's vision, mission, mandate, and programs internally and externally as an example of deep pride in the organization. Conveys the importance of the Coast Guard's work to members and stakeholders. Celebrates organizational achievements." },
                    { 161, "Models organizational pride in the Coast Guard's brand and the jobs it performs. Champions the organization when working collectively with internal and external stakeholders. Promotes organizational achievements and employee engagement events nationally. Strives to hone organizational excellence through celebration and pageantry.", "Models organizational pride in the Coast Guard's brand and the jobs it performs. Champions the organization when working collectively with internal and external stakeholders. Promotes organizational achievements and employee engagement events nationally. Strives to hone organizational excellence through celebration and pageantry." }
                });

            migrationBuilder.InsertData(
                table: "CompetencyRatingLevels",
                columns: new[] { "Id", "Value", "NameEng", "NameFre", "DescEng", "DescFre" },
                values: new object[,]
                {
                    { 1, 1, "Fundamental Awareness", "Conscience fondamentale", "(Common knowledge or an understanding of basic techniques and concepts)", "(Connaissance commune ou compréhension des techniques et concepts de base)" },
                    { 2, 2, "Novice", "Novice", "(A level of experience has been obtained; may need help when performing a task/skill)", "(Un niveau d'expérience a été obtenu; peut avoir besoin d'aide lors de l'exécution d'une tâche / compétence)" },
                    { 3, 3, "Intermediate", "Intermediaire", "(Able to successfully complete the necessary tasks in this competency. Some assistance may still be needed but can usually perform the task independently)", "(Capable de mener à bien les tâches nécessaires dans cette compétence. Une assistance peut encore être nécessaire, mais peut généralement effectuer la tâche de manière indépendante)" },
                    { 4, 4, "Advanced", "Avancé", "(Performs the actions associated with this skill without assistance. Able to provide assistance to other colleagues when questions arise regarding this skill)", "(Effectue les actions associées à cette compétence sans assistance. Capable de fournir une assistance à d'autres collègues lorsque des questions se posent concernant cette compétence)" },
                    { 5, 5, "Expert", "Expert", "(Provides guidance, troubleshoot, and answer questions related to this area of expertise and the field where the skill is used)", "(Fournit des conseils, dépanne et répond aux questions liées à ce domaine d'expertise et au domaine dans lequel la compétence est utilisée)" }
                });

            migrationBuilder.InsertData(
                table: "CompetencyTypes",
                columns: new[] { "Id", "NameEng", "NameFre" },
                values: new object[,]
                {
                    { 1, "Knowledge Elements", "Éléments de connaissance" },
                    { 2, "Technical Elements", "Éléments techniques" },
                    { 3, "Behavioural Elements", "Éléments comportementaux" }
                });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "Id", "ValueEng", "ValueFre" },
                values: new object[,]
                {
                    { 1, "Seagoing", "En mer" },
                    { 2, "Shoreside", "Sur terre" }
                });

            migrationBuilder.InsertData(
                table: "JobGroupLevels",
                columns: new[] { "Id", "LevelValue" },
                values: new object[,]
                {
                    { 1, "01" },
                    { 2, "02" },
                    { 3, "03" },
                    { 4, "04" },
                    { 5, "05" },
                    { 6, "06" },
                    { 7, "07" },
                    { 8, "08" },
                    { 9, "09" }
                });

            migrationBuilder.InsertData(
                table: "JobGroups",
                columns: new[] { "Id", "Code", "NameEng", "NameFre" },
                values: new object[,]
                {
                    { 1, "GT", "General Technician", "Technicien général" },
                    { 2, "AS", "Administrative Services", "Services administratif" },
                    { 3, "CS", "Computer Systems", "Systèmes informatiques" },
                    { 4, "GS", "General Services", "Services généraux" },
                    { 5, "LI", "Lightkeepers", "Les gardiens de phare" },
                    { 6, "EG", "Engineering and Scientific Support", "Soutien technologique et scientifique" },
                    { 7, "PG", "Purchasing and Supply", "Achat et approvisionnement" },
                    { 8, "GL", "General Labour and Trades", "Travail général et métiers" },
                    { 9, "SC", "Ships' Crews", "Équipages de navires" },
                    { 10, "SO", "Ships' Officers", "Officiers de navire" },
                    { 11, "ENG", "Architecture, Engineering", "Architecture et Ingénierie" },
                    { 12, "CR", "Clerical and Regulatory", "Commis aux écritures et aux règlements" },
                    { 13, "EC", "Economics and Social Science Services", "Économique et services de sciences sociales" },
                    { 14, "ED", "Education Services", "Services de l’enseignement" },
                    { 15, "EU", "Educational Support", "Soutien de l’enseignement" },
                    { 16, "EX", "Executive Group", "Groupe exécutif" },
                    { 17, "LS", "Library Science", "Bibliothéconomie" },
                    { 18, "NU", "Nursing", "Infirmiers" },
                    { 19, "OE", "Office Equipment", "Matériel de bureau" },
                    { 20, "PM", "Programme Administration", "Administration des programmes" },
                    { 21, "RO", "Radio Operations", "Radiotélégraphie" }
                });

            migrationBuilder.InsertData(
                table: "JobKeyTaskPerLevels",
                columns: new[] { "Id", "DescEng", "DescFre" },
                values: new object[,]
                {
                    { 1, "Basic knowledge of a unit in the Coast Guard organization chart and its reporting relationships.", "Basic knowledge of a unit in the Coast Guard organization chart and its reporting relationships." },
                    { 2, "Limited knowledge of the Coast Guard's mandate and its relationship with Fisheries and Oceans Canada (DFO). Understands the organization's directorates regionally and/or nationally.", "Limited knowledge of the Coast Guard's mandate and its relationship with Fisheries and Oceans Canada (DFO). Understands the organization's directorates regionally and/or nationally." },
                    { 3, "Practical knowledge of the Coast Guard and Fisheries and Oceans Canada (DFO) organizations, and of the Coast Guard as a special operating agency. Understands a program and its linkages to other programs and directorates regionally and/or nationally.", "Practical knowledge of the Coast Guard and Fisheries and Oceans Canada (DFO) organizations, and of the Coast Guard as a special operating agency. Understands a program and its linkages to other programs and directorates regionally and/or nationally." },
                    { 4, "Advanced knowledge of the Coast Guard and Fisheries and Oceans Canada (DFO) organizations, directorates and associated programs and relations regionally and nationally.", "Advanced knowledge of the Coast Guard and Fisheries and Oceans Canada (DFO) organizations, directorates and associated programs and relations regionally and nationally." },
                    { 5, "Expert knowledge of the Coast Guard and Fisheries and Oceans Canada (DFO) organizations and their interdependencies with other internal (includes other government departments) and external (includes industry and other governments) organizations. Expertise in providing advice and guidance to stakeholders about the organization and its capabilities.", "Expert knowledge of the Coast Guard and Fisheries and Oceans Canada (DFO) organizations and their interdependencies with other internal (includes other government departments) and external (includes industry and other governments) organizations. Expertise in providing advice and guidance to stakeholders about the organization and its capabilities." },
                    { 6, "Basic knowledge of the Coast Guard and its role as an enabler of various programs.", "Basic knowledge of the Coast Guard and its role as an enabler of various programs." },
                    { 7, "Limited knowledge of the Coast Guard's functions and the roles and responsibilities of key Coast Guard contacts within a regional organizational setting. Understands some programs and assets well.", "Limited knowledge of the Coast Guard's functions and the roles and responsibilities of key Coast Guard contacts within a regional organizational setting. Understands some programs and assets well." },
                    { 8, "Practical knowledge of program deliveries in a regional or national organizational setting.  Understands most programs and associated assets. Knowledge of key contacts for other programs. Comprehends roles and responsibilities of client partners.", "Practical knowledge of program deliveries in a regional or national organizational setting.  Understands most programs and associated assets. Knowledge of key contacts for other programs. Comprehends roles and responsibilities of client partners." },
                    { 9, "Advanced knowledge of programs and their impacts on public and partner relations, regionally and/or nationally. Extensive knowledge of all the Coast Guard's programs and the capability and status of Coast Guard assets regionally and/or nationally. Understands program planning exercises.", "Advanced knowledge of programs and their impacts on public and partner relations, regionally and/or nationally. Extensive knowledge of all the Coast Guard's programs and the capability and status of Coast Guard assets regionally and/or nationally. Understands program planning exercises." },
                    { 10, "Expert knowledge of all the Coast Guard programs and delivery modes and timelines regionally and nationally. Understands expectations and needs of stakeholders for the Coast Guard and other government departments (OGDs) in planning and exercises. Understands the significance of potential program efficiencies, changes, or expansion opportunities.", "Expert knowledge of all the Coast Guard programs and delivery modes and timelines regionally and nationally. Understands expectations and needs of stakeholders for the Coast Guard and other government departments (OGDs) in planning and exercises. Understands the significance of potential program efficiencies, changes, or expansion opportunities." },
                    { 12, "Understands basic administrative tasks and rules as they relate to a position. Recognizes the need to have supervisor approve requests where applicable.", "Understands basic administrative tasks and rules as they relate to a position. Recognizes the need to have supervisor approve requests where applicable." },
                    { 13, "Recognizes when administration requirements are met. Understands systems and software pertaining to administrative functions and where applicable, the shipboard logistics functions in the performance of duties.", "Recognizes when administration requirements are met. Understands systems and software pertaining to administrative functions and where applicable, the shipboard logistics functions in the performance of duties." },
                    { 14, "Understands the full range of administration services such as expense forms, reimbursements (travel, stores, etc.) and where applicable items such as ex gratiapayments, timesheets, drafting correspondence and reports, training requests and authorizations, etc.", "Understands the full range of administration services such as expense forms, reimbursements (travel, stores, etc.) and where applicable items such as ex gratiapayments, timesheets, drafting correspondence and reports, training requests and authorizations, etc." },
                    { 15, "Understands the full administration requirements of a sector or unit and how they interrelate with one another to effect efficient transactions throughout. Knowledge of all applicable policies, standards etc., to perform duties.", "Understands the full administration requirements of a sector or unit and how they interrelate with one another to effect efficient transactions throughout. Knowledge of all applicable policies, standards etc., to perform duties." },
                    { 16, "Expert knowledge in the administrative functions of multiple units working together and the needs of a work site, when and where applicable. Awareness of national and regional initiatives related to the administrative functions of a unit or units.", "Expert knowledge in the administrative functions of multiple units working together and the needs of a work site, when and where applicable. Awareness of national and regional initiatives related to the administrative functions of a unit or units." },
                    { 17, "Basic understanding of the different Incident Command System (ICS) elements and incident levels. Understands the established and applicable operational procedures within ICS. Knowledge of associated computer software and hardware.", "Basic understanding of the different Incident Command System (ICS) elements and incident levels. Understands the established and applicable operational procedures within ICS. Knowledge of associated computer software and hardware." },
                    { 18, "Limited knowledge of the principles and working process of the Incident Command System (ICS). Knowledge of methodology for all Coast Guard incidents, emergency or contingency plans executed in environmental response, humanitarian assistance, maritime security, planned security events, Coast Guard internal incidents and major maritime incidents.", "Limited knowledge of the principles and working process of the Incident Command System (ICS). Knowledge of methodology for all Coast Guard incidents, emergency or contingency plans executed in environmental response, humanitarian assistance, maritime security, planned security events, Coast Guard internal incidents and major maritime incidents." },
                    { 19, "Practical knowledge of the Incident Command System (ICS) during pollution incidents. Knowledge of the relationship between the Coast Guard Safety Management System (SMS) and the ICS. Understands how to determine optimum intervention options and determining the severity, sensitivity, and impact of an incident. Understands equipment specifications and maintenance requirements.", "Practical knowledge of the Incident Command System (ICS) during pollution incidents. Knowledge of the relationship between the Coast Guard Safety Management System (SMS) and the ICS. Understands how to determine optimum intervention options and determining the severity, sensitivity, and impact of an incident. Understands equipment specifications and maintenance requirements." },
                    { 20, "Advanced knowledge of the management of an Incident Command System (ICS) command and control structure. Knowledge of interoperability with other organizations such as regional, federal, provincial, territorial, and international partners, and response organizations. Understands and applies life cycle management of equipment. Understands national exercise program (NEP) principles.", "Advanced knowledge of the management of an Incident Command System (ICS) command and control structure. Knowledge of interoperability with other organizations such as regional, federal, provincial, territorial, and international partners, and response organizations. Understands and applies life cycle management of equipment. Understands national exercise program (NEP) principles." },
                    { 21, "Expert knowledge of the Incident Command System (ICS) and identifying new possibilities/capabilities to improve the existing systems and practices. Expertise in drafting/review of acts, regulations, and frameworks, and emergency management policies and directions. ", "Expert knowledge of the Incident Command System (ICS) and identifying new possibilities/capabilities to improve the existing systems and practices. Expertise in drafting/review of acts, regulations, and frameworks, and emergency management policies and directions. " },
                    { 22, "Basic knowledge of existing policies and documents related to seagoing personnel and where to locate them.", "Basic knowledge of existing policies and documents related to seagoing personnel and where to locate them." },
                    { 23, "Limited knowledge of the Canadian Coast Guard's documentation covering policies and directives related to crewing profile, rotation regulations, leave, medical fitness and training, and certification for seagoing personnel. ", "Limited knowledge of the Canadian Coast Guard's documentation covering policies and directives related to crewing profile, rotation regulations, leave, medical fitness and training, and certification for seagoing personnel. " },
                    { 24, "Practical knowledge of the Coast Guard's seagoing dynamic environment. Understands applicable policies and directives when initiating administration processes related to seagoing personnel such as timesheet verification, scheduling and tracking medicals, using the crewing profiles, leave management, labour relations protocols, and using the MariTime system, etc.", "Practical knowledge of the Coast Guard's seagoing dynamic environment. Understands applicable policies and directives when initiating administration processes related to seagoing personnel such as timesheet verification, scheduling and tracking medicals, using the crewing profiles, leave management, labour relations protocols, and using the MariTime system, etc." },
                    { 25, "Advanced knowledge of the regional/national approaches in the application of any required policies and regulations related to operational personnel management. Understands new concepts and processes to improve recruitment, retention, and sustainment of the Coast Guard's seagoing personnel and its management. ", "Advanced knowledge of the regional/national approaches in the application of any required policies and regulations related to operational personnel management. Understands new concepts and processes to improve recruitment, retention, and sustainment of the Coast Guard's seagoing personnel and its management. " },
                    { 26, "Expert knowledge in strategic guidance related to the seagoing personnel management doctrine.   Expertise in recommending, drafting, and implementation of policies related to the management of seagoing personnel. ", "Expert knowledge in strategic guidance related to the seagoing personnel management doctrine.   Expertise in recommending, drafting, and implementation of policies related to the management of seagoing personnel. " },
                    { 27, "Basic knowledge of coastal domain factors, working relations with other Canadian Coast Guard units, and equipment. ", "Basic knowledge of coastal domain factors, working relations with other Canadian Coast Guard units, and equipment. " },
                    { 28, "Limited knowledge in supporting Fisheries and Oceans Canada's (DFO) marine security programs and conducting analyses using surveillance equipment and working with internal partners. ", "Limited knowledge in supporting Fisheries and Oceans Canada's (DFO) marine security programs and conducting analyses using surveillance equipment and working with internal partners. " },
                    { 29, "Practical knowledge in the full range of the maritime security operations centres (MSOC),  its exercises, and its surveillance and analyses with internal partners.", "Practical knowledge in the full range of the maritime security operations centres (MSOC),  its exercises, and its surveillance and analyses with internal partners." },
                    { 30, "Advanced knowledge of all facets of marine security operations, training, and analyses regionally or nationally, as well as training/consultation initiatives. Knowledge of Fisheries and Oceans Canada (DFO), Department of National Defence (DND), Royal Canadian Mounted Police (RCMP), Transport Canada (TC), and the Coast Guard's response systems, programs, and surveillance equipment (Long Range Identification and Tracking [LRIT], radars, cameras).", "Advanced knowledge of all facets of marine security operations, training, and analyses regionally or nationally, as well as training/consultation initiatives. Knowledge of Fisheries and Oceans Canada (DFO), Department of National Defence (DND), Royal Canadian Mounted Police (RCMP), Transport Canada (TC), and the Coast Guard's response systems, programs, and surveillance equipment (Long Range Identification and Tracking [LRIT], radars, cameras)." },
                    { 31, "Expert knowledge of all facets of the marine security operations program and its relations with international and industrial stakeholders (e.g. United States Coast Guard [USCG], Ports). Expertise in providing insights to managers and stakeholders in advisory groups, the military, Canadian Security Intelligence Service (CSIS), and governments.", "Expert knowledge of all facets of the marine security operations program and its relations with international and industrial stakeholders (e.g. United States Coast Guard [USCG], Ports). Expertise in providing insights to managers and stakeholders in advisory groups, the military, Canadian Security Intelligence Service (CSIS), and governments." },
                    { 32, "Basic knowledge of the training needs analysis process in relation to the Canadian Coast Guard's training gaps and requirements. ", "Basic knowledge of the training needs analysis process in relation to the Canadian Coast Guard's training gaps and requirements. " },
                    { 33, "Limited knowledge of determining training elements including terminal objectives, training structure and outline, brief description of the training, and the method of delivery.", "Limited knowledge of determining training elements including terminal objectives, training structure and outline, brief description of the training, and the method of delivery." },
                    { 34, "Practical knowledge in developing enabling objectives. Understands the development of course materials and curriculum including the instructor lesson plan, participant handouts, assessments, and selected media such as PowerPoint presentations, video, or audio, etc. ", "Practical knowledge in developing enabling objectives. Understands the development of course materials and curriculum including the instructor lesson plan, participant handouts, assessments, and selected media such as PowerPoint presentations, video, or audio, etc. " },
                    { 35, "Advanced knowledge in identifying methods and activities for presenting new information. Knowledge of setting aims and learning objectives. Understanding of the design strategy, for the development of new courses. Knowledge of making course modifications based on feedback. ", "Advanced knowledge in identifying methods and activities for presenting new information. Knowledge of setting aims and learning objectives. Understanding of the design strategy, for the development of new courses. Knowledge of making course modifications based on feedback. " },
                    { 36, "Expert knowledge of evaluating training results to determine whether the sessions led to required changes in behaviour for the participants. Knowledge in redefining course development, materials, and instructional methods. Understanding of briefing senior management regarding issues, trends, suggestions, and areas of improvement based on evaluation, including trends related to diversity and generational issues.", "Expert knowledge of evaluating training results to determine whether the sessions led to required changes in behaviour for the participants. Knowledge in redefining course development, materials, and instructional methods. Understanding of briefing senior management regarding issues, trends, suggestions, and areas of improvement based on evaluation, including trends related to diversity and generational issues." },
                    { 37, "Basic knowledge of aspects of specialized fields to accomplish defined activities by applying methods, techniques, and established practices.", "Basic knowledge of aspects of specialized fields to accomplish defined activities by applying methods, techniques, and established practices." },
                    { 38, "Limited knowledge of theories and principles of a specialized field and the relevancy to their application. ", "Limited knowledge of theories and principles of a specialized field and the relevancy to their application. " },
                    { 39, "Practical knowledge of specialized methodologies of a field and comprehensive understanding of their underlying concepts, theories, and principles. ", "Practical knowledge of specialized methodologies of a field and comprehensive understanding of their underlying concepts, theories, and principles. " },
                    { 40, "Advanced knowledge in specialized methodologies of a field and of their underlying concepts. Extensive comprehension of the methodologies, theories, and applied principles of a specialized field.", "Advanced knowledge in specialized methodologies of a field and of their underlying concepts. Extensive comprehension of the methodologies, theories, and applied principles of a specialized field." },
                    { 41, "Expert knowledge in specialized methodologies of a field or fields and of their underlying concepts, theories, and principles. Extensive knowledge in the provision of coaching/guidance to staff, peers, and senior management.", "Expert knowledge in specialized methodologies of a field or fields and of their underlying concepts, theories, and principles. Extensive knowledge in the provision of coaching/guidance to staff, peers, and senior management." },
                    { 42, "Participates in project/program support activities. ", "Participates in project/program support activities. " },
                    { 43, "Respects project/program goals, participants' roles, and the importance of project management principles. Participates in project support activities (i.e. gathering needed information). Participates with others in small and well defined components of the project/program.", "Respects project/program goals, participants' roles, and the importance of project management principles. Participates in project support activities (i.e. gathering needed information). Participates with others in small and well defined components of the project/program." },
                    { 44, "Actively promotes project goals, participants' roles, and the importance of project management principles, such as time, cost, and quality management. Participates, with minimal supervision, with others in all aspects of project or program. Seeks advice and guidance for more complex components of the project/program.", "Actively promotes project goals, participants' roles, and the importance of project management principles, such as time, cost, and quality management. Participates, with minimal supervision, with others in all aspects of project or program. Seeks advice and guidance for more complex components of the project/program." },
                    { 45, "Leads projects and/or programs. Leads project/program support activities, taking the initiative to gather additional information, keep documentation organized, and identify process improvements, when and where applicable. Provides advice to others who seek assistance within the project/program scope. ", "Leads projects and/or programs. Leads project/program support activities, taking the initiative to gather additional information, keep documentation organized, and identify process improvements, when and where applicable. Provides advice to others who seek assistance within the project/program scope. " },
                    { 46, "Responsibly delivers on the established mandate of a project/program. Directs teams to complete activities in accordance with current policies and practices. Provides accurate and timely recommendations to clients. Trains and advises anyone seeking guidance on basic to complex elements of project/program. ", "Responsibly delivers on the established mandate of a project/program. Directs teams to complete activities in accordance with current policies and practices. Provides accurate and timely recommendations to clients. Trains and advises anyone seeking guidance on basic to complex elements of project/program. " },
                    { 47, "Monitors the quality and timeliness of individual responsibilities using the available resources, searching for clarity as needed. ", "Monitors the quality and timeliness of individual responsibilities using the available resources, searching for clarity as needed. " },
                    { 48, "Plans and organizes individual responsibilities to accomplish pre-determined standards or procedures. Monitors the quality and timeliness of work while leveraging the resources at immediate disposal.", "Plans and organizes individual responsibilities to accomplish pre-determined standards or procedures. Monitors the quality and timeliness of work while leveraging the resources at immediate disposal." },
                    { 49, "Plans and organizes activities efficiently. Monitors the quality and timeliness of unit workloads. Uses available resources and seeks assistance to clarify priorities, when and where required. Reports on results to promote accountability. ", "Plans and organizes activities efficiently. Monitors the quality and timeliness of unit workloads. Uses available resources and seeks assistance to clarify priorities, when and where required. Reports on results to promote accountability. " },
                    { 50, "Efficiently plans and organizes activities for a unit. Establishes goals and objectives and anticipates obstacles realistically. Determines priorities and allocates resources effectively. Assists others and gives guidance as required.", "Efficiently plans and organizes activities for a unit. Establishes goals and objectives and anticipates obstacles realistically. Determines priorities and allocates resources effectively. Assists others and gives guidance as required." },
                    { 51, "Plans and organizes effectively while managing multiple demands and competing priorities. Influences processes and courses of action. Provides guidance and advice on a project or program area. ", "Plans and organizes effectively while managing multiple demands and competing priorities. Influences processes and courses of action. Provides guidance and advice on a project or program area. " },
                    { 52, "Administers low-risk contracts. Monitors inventory levels of materials, equipment, and stock using manual or computerized inventory systems. Prepares requisition orders to replenish materials, equipment, and stock. Maintains stock rotation, disposes of and accounts for outdated stock. Enters data for production scheduling, stock replenishment, relocation, and inventory adjustments. Maintains a contractor database, insurance requirements, and pricing accuracy. ", "Administers low-risk contracts. Monitors inventory levels of materials, equipment, and stock using manual or computerized inventory systems. Prepares requisition orders to replenish materials, equipment, and stock. Maintains stock rotation, disposes of and accounts for outdated stock. Enters data for production scheduling, stock replenishment, relocation, and inventory adjustments. Maintains a contractor database, insurance requirements, and pricing accuracy. " },
                    { 53, "Monitors and reports on contract milestones and outcomes. Completes price variations in accordance with predetermined processes. Sources and obtains price quotations from catalogues and suppliers, and prepares purchase orders. Calculates cost of orders and charges or forwards invoices to appropriate accounts. Prepares and maintains purchasing files, reports, and price lists. Assesses requirements of clients and develops specifications for equipment, materials, and supplies to be purchased. ", "Monitors and reports on contract milestones and outcomes. Completes price variations in accordance with predetermined processes. Sources and obtains price quotations from catalogues and suppliers, and prepares purchase orders. Calculates cost of orders and charges or forwards invoices to appropriate accounts. Prepares and maintains purchasing files, reports, and price lists. Assesses requirements of clients and develops specifications for equipment, materials, and supplies to be purchased. " },
                    { 54, "Manages medium-risk contracts including governance, risk, performance, and financial management. Purchases general and specialized equipment, materials, land or access rights, or business services for use or for further processing by the Canadian Coast Guard. Interprets and applies the terms and conditions of the contract to varied situations. Manages, or assists in the management of, all procedural aspects of purchasing activities. Adapts contract management practices in changing circumstances whilst maintaining the overall intent of the contract.  ", "Manages medium-risk contracts including governance, risk, performance, and financial management. Purchases general and specialized equipment, materials, land or access rights, or business services for use or for further processing by the Canadian Coast Guard. Interprets and applies the terms and conditions of the contract to varied situations. Manages, or assists in the management of, all procedural aspects of purchasing activities. Adapts contract management practices in changing circumstances whilst maintaining the overall intent of the contract.  " },
                    { 55, "Establishes delivery schedules, monitors progress, and contacts clients and suppliers to resolve problems in a work unit. Negotiates land acquisition or access rights for Coast Guard use, and may conduct field investigations of properties. Reviews and processes claims against suppliers. Monitors contract performance and identifies when corrective action needs to be taken to drive better outcomes. Assesses contract variations, and makes appropriate decisions based on risk. Invites tenders, consults with suppliers, and reviews quotations. Determines or negotiates contract terms and conditions, awards supplier contracts or recommend contract awards. Explores innovative contract management strategies for complex requirements with stakeholders.", "Establishes delivery schedules, monitors progress, and contacts clients and suppliers to resolve problems in a work unit. Negotiates land acquisition or access rights for Coast Guard use, and may conduct field investigations of properties. Reviews and processes claims against suppliers. Monitors contract performance and identifies when corrective action needs to be taken to drive better outcomes. Assesses contract variations, and makes appropriate decisions based on risk. Invites tenders, consults with suppliers, and reviews quotations. Determines or negotiates contract terms and conditions, awards supplier contracts or recommend contract awards. Explores innovative contract management strategies for complex requirements with stakeholders." },
                    { 56, "Plans, organizes, directs, controls, and evaluates the purchasing activities of one or more work units. Identifies vendors of materials, equipment, or supplies. Participates in the development of specifications for equipment, products, or substitute materials. Interprets and advises on the terms and conditions of the contract, and applies to varied and complex situations. Monitors, evaluates and reports on contract milestones, key performance indicators adherence, performance metrics, and outcomes. Oversees the management of contracts and categories, and reports on contract activities that may result in political or public interest. Defines and advises on contract management responsibilities and processes across the Coast Guard. Drives the use of innovative contract management strategies where appropriate to deliver the best outcome and maximize value. Develops purchasing policies and procedures and controls purchasing department budget, when and where applicable.", "Plans, organizes, directs, controls, and evaluates the purchasing activities of one or more work units. Identifies vendors of materials, equipment, or supplies. Participates in the development of specifications for equipment, products, or substitute materials. Interprets and advises on the terms and conditions of the contract, and applies to varied and complex situations. Monitors, evaluates and reports on contract milestones, key performance indicators adherence, performance metrics, and outcomes. Oversees the management of contracts and categories, and reports on contract activities that may result in political or public interest. Defines and advises on contract management responsibilities and processes across the Coast Guard. Drives the use of innovative contract management strategies where appropriate to deliver the best outcome and maximize value. Develops purchasing policies and procedures and controls purchasing department budget, when and where applicable." },
                    { 57, "Coordinates a variety of recruitment, training, performance evaluation, HR systems, and classification activities. Prepares and proofreads forms and documents for and between the workforce management team or clients. Runs reports. Ensures that workforce management-related material is signed, dated, distributed, maintained, and filed appropriately. ", "Coordinates a variety of recruitment, training, performance evaluation, HR systems, and classification activities. Prepares and proofreads forms and documents for and between the workforce management team or clients. Runs reports. Ensures that workforce management-related material is signed, dated, distributed, maintained, and filed appropriately. " },
                    { 58, "Compiles, maintains, and processes information relating to recruitment, training, performance evaluation, HR systems, or classification. Facilitates business line, workforce intelligence, succession planning, organizational awareness, and HR management practices. Arranges for advertising or posting job vacancies. Assists in screening of job applicants, and conducting of reference checks, when and where applicable.", "Compiles, maintains, and processes information relating to recruitment, training, performance evaluation, HR systems, or classification. Facilitates business line, workforce intelligence, succession planning, organizational awareness, and HR management practices. Arranges for advertising or posting job vacancies. Assists in screening of job applicants, and conducting of reference checks, when and where applicable." },
                    { 59, "Identifies job vacancies and prospective recruiting requirements. Provides advice to managers related to recruitment, training, or HR systems. Interprets and applies legislation and policies related to workforce management functions. Determines eligibility to entitlements, arranges and delivers member training. Provides information or services such as employee assistance, counselling, and recognition programs, when and where applicable. ", "Identifies job vacancies and prospective recruiting requirements. Provides advice to managers related to recruitment, training, or HR systems. Interprets and applies legislation and policies related to workforce management functions. Determines eligibility to entitlements, arranges and delivers member training. Provides information or services such as employee assistance, counselling, and recognition programs, when and where applicable. " },
                    { 60, "Implements and evaluates workforce management policies, programs, and procedures. Working closely with clients or the workforce management team, collaborates in developing the merit criteria, assessment tools, and employment equity programs, offering strategic staffing ideas and assisting with performance management or disability files according to portfolio. Provides advice on the interpretation of policies, staffing, training, and benefits programs. Maintains workforce management information and related records systems. Hires and oversees training of staff. Co-ordinates employee performance appraisal programs. ", "Implements and evaluates workforce management policies, programs, and procedures. Working closely with clients or the workforce management team, collaborates in developing the merit criteria, assessment tools, and employment equity programs, offering strategic staffing ideas and assisting with performance management or disability files according to portfolio. Provides advice on the interpretation of policies, staffing, training, and benefits programs. Maintains workforce management information and related records systems. Hires and oversees training of staff. Co-ordinates employee performance appraisal programs. " },
                    { 61, "Directs, controls, and evaluates the operations of the Canadian Coast Guard's workforce management discipline. Develops and implements policies, programs and procedures regarding workforce management planning, recruitment, training and development, and classification. Negotiates settlements of appeals and disputes and co-ordinates the termination of employment process, when and where applicable. Directs the organization's quality management program in relation to workforce management.", "Directs, controls, and evaluates the operations of the Canadian Coast Guard's workforce management discipline. Develops and implements policies, programs and procedures regarding workforce management planning, recruitment, training and development, and classification. Negotiates settlements of appeals and disputes and co-ordinates the termination of employment process, when and where applicable. Directs the organization's quality management program in relation to workforce management." },
                    { 62, "Adheres to budget controls as assigned. Articulates a 'value for money' mindset. Provides correct financial information as required. ", "Adheres to budget controls as assigned. Articulates a 'value for money' mindset. Provides correct financial information as required." },
                    { 63, "Monitors project/program expenditures and individual expenses for reporting purposes. Identifies wasteful financial practices or opportunities for greater efficiencies. Tracks and files variation reports. ", "Monitors project/program expenditures and individual expenses for reporting purposes. Identifies wasteful financial practices or opportunities for greater efficiencies. Tracks and files variation reports. " },
                    { 64, "Analyzes unit cash flow trends. Maintains financial records and compares trends by period and year. Prepares statistical, financial, and accounting reports. Verifies and evaluates procedures used for recording financial transactions, and makes recommendations for changes to procedures, systems, and other financial controls. Provides guidance to members. ", "Analyzes unit cash flow trends. Maintains financial records and compares trends by period and year. Prepares statistical, financial, and accounting reports. Verifies and evaluates procedures used for recording financial transactions, and makes recommendations for changes to procedures, systems, and other financial controls. Provides guidance to members. " },
                    { 65, "Analyzes broad accounting and financial records to ensure accuracy and compliance with established accounting standards and procedures. Plans, organizes, and administers financial tracking and reconciliation systems for Canadian Coast Guard programs and business lines. Prepares detailed reports and conducts audits to improve organizational financial management practices. Provides guidance to management. Designs, operates, and monitors rigorous systems for Financial Information Management, internal audit, and evaluation. ", "Analyzes broad accounting and financial records to ensure accuracy and compliance with established accounting standards and procedures. Plans, organizes, and administers financial tracking and reconciliation systems for Canadian Coast Guard programs and business lines. Prepares detailed reports and conducts audits to improve organizational financial management practices. Provides guidance to management. Designs, operates, and monitors rigorous systems for Financial Information Management, internal audit, and evaluation. " },
                    { 66, "Directs, controls, and evaluates the operation of financial and accounting departments. Reports on established trends with organizational recommendations for change. Ensures partner organizations, agencies, or governments understand the organization's complex fiscal issues. Develops and implements financial policies, establishes performance standards, and prepares various financial reports for senior management. Advises senior management on current and best practices in sound financial management practice and procedure. ", "Directs, controls, and evaluates the operation of financial and accounting departments. Reports on established trends with organizational recommendations for change. Ensures partner organizations, agencies, or governments understand the organization's complex fiscal issues. Develops and implements financial policies, establishes performance standards, and prepares various financial reports for senior management. Advises senior management on current and best practices in sound financial management practice and procedure. " },
                    { 67, "Conducts media monitoring and coverage analysis. Provides communication support services. Offers logistical support for media events and interviews.", "Conducts media monitoring and coverage analysis. Provides communication support services. Offers logistical support for media events and interviews." },
                    { 68, "Writes and edits a range of communications products. Supports social media and websites. Assists in the development and/or implementation of communications products. Contributes to implementing communication plans or projects in the digital environment. ", "Writes and edits a range of communications products. Supports social media and websites. Assists in the development and/or implementation of communications products. Contributes to implementing communication plans or projects in the digital environment. " },
                    { 69, "Produces communications products. Plans, coordinates, and/or implements announcements or special events such as town halls or media availabilities. Provides communication support to clients. Contributes to content of strategic communications plans. Monitors and analyzes multimedia coverage, providing tactical responses where requested. Uses social media to communicate in a government context. ", "Produces communications products. Plans, coordinates, and/or implements announcements or special events such as town halls or media availabilities. Provides communication support to clients. Contributes to content of strategic communications plans. Monitors and analyzes multimedia coverage, providing tactical responses where requested. Uses social media to communicate in a government context. " },
                    { 70, "Provides strategic communications advice to managers. Develops and implements marketing and/or advertising plans, storyboards, and videos. Evaluates communications plans and develops associated communications products, when and where required. Coordinates and/or works within inter-governmental or multi-departmental communications initiatives, projects, or strategies. Extracts subject-matter experts while executing segmentation and audience analysis. Assists senior management in conveying messages on behalf of the Coast Guard in an appropriate manner that is consistent with established Acts, policies, and practices. Establishes networks with Fisheries and Oceans Canada (DFO) communications partners.", "Provides strategic communications advice to managers. Develops and implements marketing and/or advertising plans, storyboards, and videos. Evaluates communications plans and develops associated communications products, when and where required. Coordinates and/or works within inter-governmental or multi-departmental communications initiatives, projects, or strategies. Extracts subject-matter experts while executing segmentation and audience analysis. Assists senior management in conveying messages on behalf of the Coast Guard in an appropriate manner that is consistent with established Acts, policies, and practices. Establishes networks with Fisheries and Oceans Canada (DFO) communications partners." },
                    { 71, "Organizes and coordinates ministerial events. Leads the development, implementation, and evaluation of communications plans. Develops specialized communications products. In partnership with Fisheries and Oceans Canada (DFO) communications partners, leads or participates in external and internal stakeholder collaboration and major event responses. Manages media relations for sensitive issues. Develops and implements proactive media outreach strategies. Plans and executes extensive electronic (web and social media) communications initiatives.", "Organizes and coordinates ministerial events. Leads the development, implementation, and evaluation of communications plans. Develops specialized communications products. In partnership with Fisheries and Oceans Canada (DFO) communications partners, leads or participates in external and internal stakeholder collaboration and major event responses. Manages media relations for sensitive issues. Develops and implements proactive media outreach strategies. Plans and executes extensive electronic (web and social media) communications initiatives." },
                    { 72, "Applies real property and accommodation management’s key elements and policies and identifies where to find related information. Supports activities related to real property and accommodation maintenance and operations. ", "Applies real property and accommodation management’s key elements and policies and identifies where to find related information. Supports activities related to real property and accommodation maintenance and operations. " },
                    { 73, "Assists in the writing of real property and/or accommodation management documents. Gathers information for planning, coordinating, and/or monitoring budgets. Assists in the search, analysis, and integration of information from different sources to formulate recommendations or action plans.", "Assists in the writing of real property and/or accommodation management documents. Gathers information for planning, coordinating, and/or monitoring budgets. Assists in the search, analysis, and integration of information from different sources to formulate recommendations or action plans." },
                    { 74, "Interprets policies, standards, directives, or codes related to office accommodations or real property construction projects. Plans, organizes, or implements office accommodation or real property construction projects and analyses information and provides recommendations to clients or management. ", "Interprets policies, standards, directives, or codes related to office accommodations or real property construction projects. Plans, organizes, or implements office accommodation or real property construction projects and analyses information and provides recommendations to clients or management. " },
                    { 75, "Monitors marine structure projects, when and where applicable. Develops systems and/or processes, guidelines, and policies for identifying, collecting, maintaining, and evaluating real property and accommodations management information. ", "Monitors marine structure projects, when and where applicable. Develops systems and/or processes, guidelines, and policies for identifying, collecting, maintaining, and evaluating real property and accommodations management information. " },
                    { 76, "Identifies and implements risk and performance management strategies in assessing and planning real property and/or accommodations management projects. Develops plans and strategies that address the variety and complexity of real property and accommodations management operations, use, and maintenance.", "Identifies and implements risk and performance management strategies in assessing and planning real property and/or accommodations management projects. Develops plans and strategies that address the variety and complexity of real property and accommodations management operations, use, and maintenance." },
                    { 77, "Describes the basic function of the business’s core systems. Defines objectives and success criteria of the specific role. Identifies sources of existing and potential information relating to the project. Documents consistently.", "Describes the basic function of the business’s core systems. Defines objectives and success criteria of the specific role. Identifies sources of existing and potential information relating to the project. Documents consistently." },
                    { 78, "Identifies key project milestones and defines project scope. Derives project estimates and quantifies uncertainty. Stores, references, and locates information in an efficient manner appropriate to the role. Validates, refines, and optimizes solution option models. Communicates difficult issues concisely and effectively to supervisors. Identifies potential areas of conflict and works to avoid their occurrence or their impact. ", "Identifies key project milestones and defines project scope. Derives project estimates and quantifies uncertainty. Stores, references, and locates information in an efficient manner appropriate to the role. Validates, refines, and optimizes solution option models. Communicates difficult issues concisely and effectively to supervisors. Identifies potential areas of conflict and works to avoid their occurrence or their impact. " },
                    { 79, "Identifies and minimizes risk to ongoing Coast Guard operations. Consistently identifies technology interfaces and focuses on integration aspects of projects. Identifies and defines proposed business benefits. Ensures planning tools and techniques are applied effectively. Through analysis of options, selects the option with the greatest business benefit bearing in mind the Coast Guard objectives. Articulates the vision, objectives, and benefits of a new initiative. Identifies current areas of conflict and seeks to understand apposing points of view. ", "Identifies and minimizes risk to ongoing Coast Guard operations. Consistently identifies technology interfaces and focuses on integration aspects of projects. Identifies and defines proposed business benefits. Ensures planning tools and techniques are applied effectively. Through analysis of options, selects the option with the greatest business benefit bearing in mind the Coast Guard objectives. Articulates the vision, objectives, and benefits of a new initiative. Identifies current areas of conflict and seeks to understand apposing points of view. " },
                    { 80, "Identifies and relays improvement opportunities and industry trends to the organization. Ensures a mechanism is in place to capture project risks, issues, and scope. Follows up with individuals and/or groups to clarify or complete the identified gaps and errors. Employees models to determine and communicate solution options. Makes recommendations with justifications to the appropriate decision making authority. ", "Identifies and relays improvement opportunities and industry trends to the organization. Ensures a mechanism is in place to capture project risks, issues, and scope. Follows up with individuals and/or groups to clarify or complete the identified gaps and errors. Employees models to determine and communicate solution options. Makes recommendations with justifications to the appropriate decision making authority. " },
                    { 81, "Identifies risks and impacts associated with proposed business options. Forecasts the impact of change. Applies effective influencing strategies. ", "Identifies risks and impacts associated with proposed business options. Forecasts the impact of change. Applies effective influencing strategies. " },
                    { 82, "Employs a fair and non-partisan approach in the delivery of services. Supports others in managing their tasks/responsibilities by providing timely information or resources. Accurately determines where to direct inquiries.", "Employs a fair and non-partisan approach in the delivery of services. Supports others in managing their tasks/responsibilities by providing timely information or resources. Accurately determines where to direct inquiries." },
                    { 83, "Establishes and maintains electronic and paper filing systems so that information can be readily retrieved. Actively promotes services to existing and potential clients. Anticipates potential problems and initiates ways of improving standards. Complies with existing quality standards, procedures, guidelines, and service agreements. Asks questions in order to clarify the needs and requirements associated with initial client requests. ", "Establishes and maintains electronic and paper filing systems so that information can be readily retrieved. Actively promotes services to existing and potential clients. Anticipates potential problems and initiates ways of improving standards. Complies with existing quality standards, procedures, guidelines, and service agreements. Asks questions in order to clarify the needs and requirements associated with initial client requests. " },
                    { 84, "Applies due diligence and sound judgment when responding to requests and dealing with confidential information. Quickly and effectively solves client’s problems including complaints. Serves Coast Guard clients with the understanding that service is a core principle of the organization.", "Applies due diligence and sound judgment when responding to requests and dealing with confidential information. Quickly and effectively solves client’s problems including complaints. Serves Coast Guard clients with the understanding that service is a core principle of the organization." },
                    { 85, "Develops standards of service delivery beyond those generally accepted. Promotes innovative measures to address client service needs. Deals with stakeholders professionally while representing the Coastg Guard. ", "Develops standards of service delivery beyond those generally accepted. Promotes innovative measures to address client service needs. Deals with stakeholders professionally while representing the Coastg Guard. " },
                    { 86, "Strategically and systematically evaluates opportunities within a sector, field, or area to improve client service in a non-partisan manner. Develops and implements creative and innovative ways of meeting client needs, whether in the regions or in headquarters.", "Strategically and systematically evaluates opportunities within a sector, field, or area to improve client service in a non-partisan manner. Develops and implements creative and innovative ways of meeting client needs, whether in the regions or in headquarters." },
                    { 87, "Identifies irregular workforce management practices. Seeks advice when workforce management issues arise. ", "Identifies irregular workforce management practices. Seeks advice when workforce management issues arise. " },
                    { 88, "Provides basic HR-related information to colleagues, members, and others. Identifies deviations in applications of HR procedures or validates them with the competent authority. Supervises a small unit and conducts performance management input. ", "Provides basic HR-related information to colleagues, members, and others. Identifies deviations in applications of HR procedures or validates them with the competent authority. Supervises a small unit and conducts performance management input. " },
                    { 89, "Addresses standard workforce management issues within areas of responsibility (AOR). Supervises or manages staff (operational or administrative). Provides performance feedback. Aligns workforce management practices to audit results and findings, when and where applicable. Provides on-the-job training and makes training and development recommendations. Participates on staffing boards and provides input into statements of merit criteria, when and where required.", "Addresses standard workforce management issues within areas of responsibility (AOR). Supervises or manages staff (operational or administrative). Provides performance feedback. Aligns workforce management practices to audit results and findings, when and where applicable. Provides on-the-job training and makes training and development recommendations. Participates on staffing boards and provides input into statements of merit criteria, when and where required." },
                    { 90, "Manages a unit. Participates on staffing boards and drafts statements of merit criteria, and, where applicable, conducts assessments. Manages unit member performance, including the development of objectives, learning plans, talent management and action plans, and dealing with disciplinary matters. Analyzes and forecasts workforce management needs and initiates required succession planning processes. Approves training requests by considering value for money. ", "Manages a unit. Participates on staffing boards and drafts statements of merit criteria, and, where applicable, conducts assessments. Manages unit member performance, including the development of objectives, learning plans, talent management and action plans, and dealing with disciplinary matters. Analyzes and forecasts workforce management needs and initiates required succession planning processes. Approves training requests by considering value for money. " },
                    { 91, "Manages several units or projects. Develops complex workforce management plans that capitalize on recruitment, performance management, etc. Exercises an influence on Canadian Coast Guard workforce management strategic planning and development, succession planning, and other workforce management areas. Contributes to linking policies and systems to performance management processes, competencies, and performance outcomes in support of broader organizational goals. Ensures alignment of workforce management plans with the objectives of the Coast Guard's overall program strategy.", "Manages several units or projects. Develops complex workforce management plans that capitalize on recruitment, performance management, etc. Exercises an influence on Canadian Coast Guard workforce management strategic planning and development, succession planning, and other workforce management areas. Contributes to linking policies and systems to performance management processes, competencies, and performance outcomes in support of broader organizational goals. Ensures alignment of workforce management plans with the objectives of the Coast Guard's overall program strategy." },
                    { 92, "Prepares and processes bills, invoices, accounts payable and receivable. Enters data into financial tracking systems according to established procedures.", "Prepares and processes bills, invoices, accounts payable and receivable. Enters data into financial tracking systems according to established procedures." },
                    { 93, "Maintains Coast Guard unit assets and property (e.g. office equipment, vehicles, information databases, etc.). Updates budgets and projections. Purchases with credit cards when required. Runs salary and Operations and Maintenance (O&M) reports and statements for managers. Makes budget entries and reconciles accounts with rationales. Tracks and analyzes unit cash flow.", "Maintains Coast Guard unit assets and property (e.g. office equipment, vehicles, information databases, etc.). Updates budgets and projections. Purchases with credit cards when required. Runs salary and Operations and Maintenance (O&M) reports and statements for managers. Makes budget entries and reconciles accounts with rationales. Tracks and analyzes unit cash flow." },
                    { 94, "Articulates the processes by which financial resources are identified, obtained, allocated, managed and accounted for. Makes sound financial decisions after having analyzed their impact on the organization and operations within the scope of fiscal responsibilities. Monitors the use of Coast Guard financial resources and budgets by employees, suppliers, partners or others. Complies with legislation, policies and practices applicable to the appropriate and effective use of financial resources. Takes a significant role in preparing budgets and forecasts for projects and initiatives.", "Articulates the processes by which financial resources are identified, obtained, allocated, managed and accounted for. Makes sound financial decisions after having analyzed their impact on the organization and operations within the scope of fiscal responsibilities. Monitors the use of Coast Guard financial resources and budgets by employees, suppliers, partners or others. Complies with legislation, policies and practices applicable to the appropriate and effective use of financial resources. Takes a significant role in preparing budgets and forecasts for projects and initiatives." },
                    { 95, "Ensures adequate internal control systems over the Coast Guard's financial assets, investments, liabilities, revenues, and expenditures. Manages financial and accounting responsibilities for large programs or multiple business lines. Identifies additional or alternative financial resources and opportunities for funding organization-wide projects, programs, research centers and/or services, etc. Acts on audit, evaluation, and other objective financial performance information. Sets up and manages income and expenditure monitoring systems and keeps these systems under close review and makes improvements where relevant. Uses delegated authority to purchase supplies for the work group. Performs a variety of financial management practices such as: budgeting, forecasting, cost benefits, risk analysis. ", "Ensures adequate internal control systems over the Coast Guard's financial assets, investments, liabilities, revenues, and expenditures. Manages financial and accounting responsibilities for large programs or multiple business lines. Identifies additional or alternative financial resources and opportunities for funding organization-wide projects, programs, research centers and/or services, etc. Acts on audit, evaluation, and other objective financial performance information. Sets up and manages income and expenditure monitoring systems and keeps these systems under close review and makes improvements where relevant. Uses delegated authority to purchase supplies for the work group. Performs a variety of financial management practices such as: budgeting, forecasting, cost benefits, risk analysis. " },
                    { 96, "Ensures framework is in place for sound financial planning, management, control and reporting (i.e. spanning pay, capital, Operations and Maintenance [O&M] costs and revenues). Ensures processes and infrastructure provide managers with integrated financial and non-financial performance information, a mature approach to risk management, appropriate control systems, and a shared set of values and ethics. ", "Ensures framework is in place for sound financial planning, management, control and reporting (i.e. spanning pay, capital, Operations and Maintenance [O&M] costs and revenues). Ensures processes and infrastructure provide managers with integrated financial and non-financial performance information, a mature approach to risk management, appropriate control systems, and a shared set of values and ethics. " },
                    { 97, "Recognizes relations between shipboard departments and how they interact and the role of the cooks and stewards. Actively learns meal planning and storage protocols.", "Recognizes relations between shipboard departments and how they interact and the role of the cooks and stewards. Actively learns meal planning and storage protocols." },
                    { 98, "Manages the logistics department in the absence of a supply officer. Consults with the cook and steward in managing storage and purchasing protocols. Assists in menu planning. ", "Manages the logistics department in the absence of a supply officer. Consults with the cook and steward in managing storage and purchasing protocols. Assists in menu planning. " },
                    { 99, "Manages the logistics department in the absence of a logistics officer. Consults with the chief cook in preparing menus. Consults with the steward on matters pertaining to accommodation. Establishes requirements for the requisition, receipt, storage, and distribution of supplies. Collaborates with the engine room department in the loading of stores.", "Manages the logistics department in the absence of a logistics officer. Consults with the chief cook in preparing menus. Consults with the steward on matters pertaining to accommodation. Establishes requirements for the requisition, receipt, storage, and distribution of supplies. Collaborates with the engine room department in the loading of stores." },
                    { 100, "Manages the logistics department as a supply officer. Consults with the chief cook in preparing menus. Consults with the steward on matters pertaining to accommodation, sanitation, and laundry facilities. Establishes requirements and procedures for the requisition, receipt, storage, and distribution of supplies. Collaborates with officers of the engine room department in the loading and moving of stores and supplies.", "Manages the logistics department as a supply officer. Consults with the chief cook in preparing menus. Consults with the steward on matters pertaining to accommodation, sanitation, and laundry facilities. Establishes requirements and procedures for the requisition, receipt, storage, and distribution of supplies. Collaborates with officers of the engine room department in the loading and moving of stores and supplies." },
                    { 101, "Manages the logistics department as a logistics officer. Consults with the chief cook and steward in all matters pertaining to shipboard hotel provisions and systems. Consults with shoreside stakeholders and conducts logistics audits and training at sea and ashore. ", "Manages the logistics department as a logistics officer. Consults with the chief cook and steward in all matters pertaining to shipboard hotel provisions and systems. Consults with shoreside stakeholders and conducts logistics audits and training at sea and ashore. " },
                    { 102, "Cites relevant sections of acts and regulations pertaining to maritime security operations centres (MSOC) (Privacy Act, Oceans Act, etc.). Identifies memoranda of understandings (MOUs) and service level agreements (SLAs) in place. Observes and records data for analysis from various sources.", "Cites relevant sections of acts and regulations pertaining to maritime security operations centres (MSOC) (Privacy Act, Oceans Act, etc.). Identifies memoranda of understandings (MOUs) and service level agreements (SLAs) in place. Observes and records data for analysis from various sources." },
                    { 103, "Identifies legal and regulatory limitations related to operations. Applies appropriate document classification to reports. Undertakes basic assignments in surveillance activities. Observes radar feeds and identifies basic trends, patterns, and anomalies.", "Identifies legal and regulatory limitations related to operations. Applies appropriate document classification to reports. Undertakes basic assignments in surveillance activities. Observes radar feeds and identifies basic trends, patterns, and anomalies." },
                    { 104, "Applies various constraints imposed by legislation and agreements by considering information sharing limitations when distributing products and/or information. Provides regular vessel tracking updates to partners as required. Analyzes information to contribute to products such as threat/risk assessments. Compiles and filters data received from partners for duplicates and unknowns. ", "Applies various constraints imposed by legislation and agreements by considering information sharing limitations when distributing products and/or information. Provides regular vessel tracking updates to partners as required. Analyzes information to contribute to products such as threat/risk assessments. Compiles and filters data received from partners for duplicates and unknowns. " },
                    { 105, "Incorporates legal opinions into procedures and processes. Identifies new sources of information. Produces vessel movement analysis based on historical data from various sources. Identifies surveillance gaps to recommend new products to fill gaps. Advises management on potential maritime threats/risks when no obvious warning is present. Conceives new maritime security initiatives to expand services and products within Fisheries and Oceans Canada (DFO).", "Incorporates legal opinions into procedures and processes. Identifies new sources of information. Produces vessel movement analysis based on historical data from various sources. Identifies surveillance gaps to recommend new products to fill gaps. Advises management on potential maritime threats/risks when no obvious warning is present. Conceives new maritime security initiatives to expand services and products within Fisheries and Oceans Canada (DFO)." },
                    { 106, "Develops formalized collection plans. Provides advice on maritime security incidents. Identifies new products to assist partners and clients in identifying potential threats. Collaborates with partners to develop maritime security operations centres (MSOC) products. Recommends capability of Canadian Coast Guard assets to and works with other government departments (OGDs) during maritime security events. Influences Coast Guard maritime security policy utilizing knowledge of partners changing initiatives, policies, and mandates.", "Develops formalized collection plans. Provides advice on maritime security incidents. Identifies new products to assist partners and clients in identifying potential threats. Collaborates with partners to develop maritime security operations centres (MSOC) products. Recommends capability of Canadian Coast Guard assets to and works with other government departments (OGDs) during maritime security events. Influences Coast Guard maritime security policy utilizing knowledge of partners changing initiatives, policies, and mandates." },
                    { 107, "Reports and logs observed non-conformities. ", "Reports and logs observed non-conformities. " },
                    { 108, "Participates in reviews and drafts quality assurance reports. Researches and compares findings against standard operating procedures or design specifications.", "Participates in reviews and drafts quality assurance reports. Researches and compares findings against standard operating procedures or design specifications." },
                    { 109, "Implements the Canadian Coast Guard's quality assurance program. Interprets a wide variety of data and makes recommendations. Formulates recommendations for, or where appropriate, develops options to resolve non-conformities.", "Implements the Canadian Coast Guard's quality assurance program. Interprets a wide variety of data and makes recommendations. Formulates recommendations for, or where appropriate, develops options to resolve non-conformities." },
                    { 110, "Defines and articulates parameters and desired objectives, encouraging others to adopt and deliver on those objectives. Applies the constraints within which information can or cannot be shared. Assists in developing quality assurance (QA) programs. Provides summary reports detailing QA findings.", "Defines and articulates parameters and desired objectives, encouraging others to adopt and deliver on those objectives. Applies the constraints within which information can or cannot be shared. Assists in developing quality assurance (QA) programs. Provides summary reports detailing QA findings." },
                    { 111, "Champions the Coast Guard's quality assurance (QA) program and systems. Develops creative and innovative programs, projects, and activities. Advises stakeholders on QA protocols and best practices. ", "Champions the Coast Guard's quality assurance (QA) program and systems. Develops creative and innovative programs, projects, and activities. Advises stakeholders on QA protocols and best practices. " },
                    { 112, "Requests supplies based on demand. Ensures that proper receipt, identification, and inspection is carried out for all incoming materiel.", "Requests supplies based on demand. Ensures that proper receipt, identification, and inspection is carried out for all incoming materiel." },
                    { 113, "Requests parts and supplies from internal stocks using approved classification system. Understands and follows the inventory management system (IMS). Processes special and emergency requirements of all clients.", "Requests parts and supplies from internal stocks using approved classification system. Understands and follows the inventory management system (IMS). Processes special and emergency requirements of all clients." },
                    { 114, "Receives, stores, issues, and records materiel according to approved inventory management system (IMS) and categories of materiel. Ensures that materiel held in stock is properly identified, catalogued, and incorporated in the centralized cataloguing files. Ensures that inventory is managed in accordance with Acts and regulations, when and where applicable. Maintains commitment control records for materiel requisitioned for stock and for non-stocked items.", "Receives, stores, issues, and records materiel according to approved inventory management system (IMS) and categories of materiel. Ensures that materiel held in stock is properly identified, catalogued, and incorporated in the centralized cataloguing files. Ensures that inventory is managed in accordance with Acts and regulations, when and where applicable. Maintains commitment control records for materiel requisitioned for stock and for non-stocked items." },
                    { 115, "Uses supplier classifications systems and cross-reference tables where available. Performs a full systematic process of developing, operating, maintaining, upgrading, and disposing, including commissioning and decommissioning of vessels as they relate to fleet operations, when and where applicable. ", "Uses supplier classifications systems and cross-reference tables where available. Performs a full systematic process of developing, operating, maintaining, upgrading, and disposing, including commissioning and decommissioning of vessels as they relate to fleet operations, when and where applicable. " },
                    { 116, "Attends national meetings and represents regional interests in the area of materiel management. Advises and guides management on cost-effective approaches. Tests new software and innovative approaches within the field. Trains and guides employees within the materiel management field, when and where applicable.", "Attends national meetings and represents regional interests in the area of materiel management. Advises and guides management on cost-effective approaches. Tests new software and innovative approaches within the field. Trains and guides employees within the materiel management field, when and where applicable." },
                    { 117, "Provides input into basic exercise plans.", "Provides input into basic exercise plans." },
                    { 118, "Participates in and validates discussion-based exercises in talking through plan finalization.  ", "Participates in and validates discussion-based exercises in talking through plan finalization.  " },
                    { 119, "Produces and validates tabletop exercises, which stimulate the divisions between responders needing to communicate and be coordinated, where the participants are expected to know the plan and test it for procedural weaknesses. ", "Produces and validates tabletop exercises, which stimulate the divisions between responders needing to communicate and be coordinated, where the participants are expected to know the plan and test it for procedural weaknesses. " },
                    { 120, "Produces and validates live exercises in order to help participants develop skills  and confidence, testing logistics and physical capabilities, and providing experience of what it would be like to use a plan or procedure in real life. ", "Produces and validates live exercises in order to help participants develop skills  and confidence, testing logistics and physical capabilities, and providing experience of what it would be like to use a plan or procedure in real life. " },
                    { 121, "Proposes, develops, trials, and validates all types of exercises, including discussion-based, table top, and live. Uses hotwash and lesson learned functions to propose changes and new exercises. Consults on developing testing exercises and training others. ", "Proposes, develops, trials, and validates all types of exercises, including discussion-based, table top, and live. Uses hotwash and lesson learned functions to propose changes and new exercises. Consults on developing testing exercises and training others. " },
                    { 122, "Assesses learners’ prior knowledge, learning needs, and career and college readiness goals. Sets learning goals and a course of study. Monitors learning through summative and formative assessment. ", "Assesses learners’ prior knowledge, learning needs, and career and college readiness goals. Sets learning goals and a course of study. Monitors learning through summative and formative assessment. " },
                    { 123, "Designs learner-centered classroom environments. Designs standards-based instructional units. Uses instructional techniques that are relevant and effective with adult learners. ", "Designs learner-centered classroom environments. Designs standards-based instructional units. Uses instructional techniques that are relevant and effective with adult learners. " },
                    { 124, "Communicates high expectations of learners on Coast Guard employment in motivating them to meet  goals. Delivers lessons in a professional, clear, and understandable way. Engages in active listening, dialogue, and questioning to facilitate and support learning.", "Communicates high expectations of learners on Coast Guard employment in motivating them to meet  goals. Delivers lessons in a professional, clear, and understandable way. Engages in active listening, dialogue, and questioning to facilitate and support learning." },
                    { 125, "Participates in professional development networks and learning communities. Shares content and pedagogical resources with program staff in collaborative professional development projects. Refines instructional practices through reflection on experience, evidence, and data. Designs instruction to build learners’ subject matter of expertise skills (i.e. marine skills in the Coast Guard). ", "Participates in professional development networks and learning communities. Shares content and pedagogical resources with program staff in collaborative professional development projects. Refines instructional practices through reflection on experience, evidence, and data. Designs instruction to build learners’ subject matter of expertise skills (i.e. marine skills in the Coast Guard). " },
                    { 126, "Champions a training environment featuring maximum flexibility, creativity, and passion, encouraging questions and discussion. Models an understanding of diversity in self and in students.", "Champions a training environment featuring maximum flexibility, creativity, and passion, encouraging questions and discussion. Models an understanding of diversity in self and in students." },
                    { 127, "Reads the Government of Canada's Values and Ethics Code. Behaves consistently with the Values and Ethics Code and seeks appropriate guidance when required. ", "Reads the Government of Canada's Values and Ethics Code. Behaves consistently with the Values and Ethics Code and seeks appropriate guidance when required. " },
                    { 128, "Uses government assets responsibly. Discusses ethical concerns with their supervisor or colleagues and, when necessary, seeks and follows appropriate disclosure procedures.", "Uses government assets responsibly. Discusses ethical concerns with their supervisor or colleagues and, when necessary, seeks and follows appropriate disclosure procedures." },
                    { 129, "Works in a manner that reflects a commitment to public service excellence. Assists peers respectfully when dealing with ethical concerns. Recognizes the importance of diversity, and bilingualism. Is well versed in the Government of Canada's Values and Ethics Code. Demonstrates respect for government property and policies.", "Works in a manner that reflects a commitment to public service excellence. Assists peers respectfully when dealing with ethical concerns. Recognizes the importance of diversity, and bilingualism. Is well versed in the Government of Canada's Values and Ethics Code. Demonstrates respect for government property and policies." },
                    { 130, "Consistently balances national, regional, and site specific ethical priorities. Actively promotes integrity, diversity, bilingualism, and respect through work behaviour and the workplace.  ", "Consistently balances national, regional, and site specific ethical priorities. Actively promotes integrity, diversity, bilingualism, and respect through work behaviour and the workplace.  " },
                    { 131, "Models public service before self. Assists and advises on issues with national and/or legal implications. Champions diversity and bilingualism. Acts with transparency and fairness. Enforces the appropriate use of government assets and resources.", "Models public service before self. Assists and advises on issues with national and/or legal implications. Champions diversity and bilingualism. Acts with transparency and fairness. Enforces the appropriate use of government assets and resources." },
                    { 132, "Breaks down concrete problems into parts and organizes information. Recognizes pertinent facts and issues that make up a problem. Asks standard questions and follows first line of investigation to identify the key elements of a situation or problem. Uses known procedures and standard operating models.", "Breaks down concrete problems into parts and organizes information. Recognizes pertinent facts and issues that make up a problem. Asks standard questions and follows first line of investigation to identify the key elements of a situation or problem. Uses known procedures and standard operating models." },
                    { 133, "Researches available options to recommend a solution. Understands the Coast Guard's operational and organizational goals and strategies, and aligns activities towards the vision and strategic imperatives. ", "Researches available options to recommend a solution. Understands the Coast Guard's operational and organizational goals and strategies, and aligns activities towards the vision and strategic imperatives. " },
                    { 134, "Analyzes multiple causal relationships among several parts of a problem or situation. Anticipates the risks or implications inherent in a suggested plan of action and devises appropriate strategies to mitigate their impact. Makes a well-reasoned response even when faced with incomplete or contradictory information. Synthesizes complex ideas, issues, and observations into a clear understanding. Thinks beyond the work environment and makes decisions in the context of the bigger picture. ", "Analyzes multiple causal relationships among several parts of a problem or situation. Anticipates the risks or implications inherent in a suggested plan of action and devises appropriate strategies to mitigate their impact. Makes a well-reasoned response even when faced with incomplete or contradictory information. Synthesizes complex ideas, issues, and observations into a clear understanding. Thinks beyond the work environment and makes decisions in the context of the bigger picture. " },
                    { 135, "Identifies several potential causes of events or multiple-part consequences. Analyzes complex, evolving circumstances and takes corrective action to avoid resource constraints and meet deadlines. Compares and contrasts evidence and information from various sources in a comprehensive and time sensitive manner. Understands program interdependencies and the need to integrate activities across functions/areas related to project planning, program implementation, and evaluation. Creates strategic alignment between cross-functional teams. Thinks laterally about business problems and opportunities; sees how the work and efforts of other Coast Guard teams/functions/operational centres intertwine to meet broad objectives.", "Identifies several potential causes of events or multiple-part consequences. Analyzes complex, evolving circumstances and takes corrective action to avoid resource constraints and meet deadlines. Compares and contrasts evidence and information from various sources in a comprehensive and time sensitive manner. Understands program interdependencies and the need to integrate activities across functions/areas related to project planning, program implementation, and evaluation. Creates strategic alignment between cross-functional teams. Thinks laterally about business problems and opportunities; sees how the work and efforts of other Coast Guard teams/functions/operational centres intertwine to meet broad objectives." },
                    { 136, "Thinks strategically about the range of market and business issues likely to impact the Coast Guard's ability to fulfill its mandate. Uses a sound understanding of the organization's strengths and weaknesses, its key stakeholders, and its long-term organizational strategy to leverage decisions of varying scope. ", "Thinks strategically about the range of market and business issues likely to impact the Coast Guard's ability to fulfill its mandate. Uses a sound understanding of the organization's strengths and weaknesses, its key stakeholders, and its long-term organizational strategy to leverage decisions of varying scope. " },
                    { 137, "Encourages members of the team to contribute to a process. Listens and asks questions. Expresses appreciation to others who have provided information assistance or support. Deals proactively with interpersonal matters that could affect team performance.", "Encourages members of the team to contribute to a process. Listens and asks questions. Expresses appreciation to others who have provided information assistance or support. Deals proactively with interpersonal matters that could affect team performance." },
                    { 138, "Solicits opinions and viewpoints of team members. Cultivates personal bonds with colleagues in order to enhance performance throughout the organization. Discusses issues and exchanges information with partners to identify areas of mutual interest and benefit. Draws on other groups to facilitate project execution or persuade others. Manages personal work-life balance and respects the work-life balance of others.", "Solicits opinions and viewpoints of team members. Cultivates personal bonds with colleagues in order to enhance performance throughout the organization. Discusses issues and exchanges information with partners to identify areas of mutual interest and benefit. Draws on other groups to facilitate project execution or persuade others. Manages personal work-life balance and respects the work-life balance of others." },
                    { 139, "Effectively promotes a respectful and positive work environment. Recognizes diverse needs and perspectives (e.g. language differences, cultural differences, disabilities, and personal family circumstances). Recognizes individuals' achievements, knowledge, and capabilities. Monitors the work environment, successfully identifies underlying issues that impact negatively on people, and takes appropriate action, when and where applicable. Seeks and influences new relationships outside own unit and identifies new collaborative partnerships that better position of the Coast Guard's programs and services. Identifies and creates opportunities to partner through networking and participating in cross-functional, multi-stakeholder groups.", "Effectively promotes a respectful and positive work environment. Recognizes diverse needs and perspectives (e.g. language differences, cultural differences, disabilities, and personal family circumstances). Recognizes individuals' achievements, knowledge, and capabilities. Monitors the work environment, successfully identifies underlying issues that impact negatively on people, and takes appropriate action, when and where applicable. Seeks and influences new relationships outside own unit and identifies new collaborative partnerships that better position of the Coast Guard's programs and services. Identifies and creates opportunities to partner through networking and participating in cross-functional, multi-stakeholder groups." },
                    { 140, "Models and promotes a culture of respect, fairness, and trust. Proficient in capitalizing on the strengths of team members. Encourages members of the team to contribute to a process, and seeks consensus. Always actively works with other teams to ensure that broader common goals are met. Builds and nurtures effective and collaborative networks and relationships with communities of practice, colleagues, and stakeholders.", "Models and promotes a culture of respect, fairness, and trust. Proficient in capitalizing on the strengths of team members. Encourages members of the team to contribute to a process, and seeks consensus. Always actively works with other teams to ensure that broader common goals are met. Builds and nurtures effective and collaborative networks and relationships with communities of practice, colleagues, and stakeholders." },
                    { 141, "Advises others in dealing with ethical dilemmas, displaying sensitivity to diversity, and diverse needs in all dealings and relationships, and in maintaining fairness, consistency, and equity. Challenges current organizational behaviours and methods of operating, when and where applicable. Sets direction in terms of ethical standards and values for the organization. Draws on internal and external networks to help ensure buy-in and ownership; enhances the visibility of the Coast Guard's operations in the broader public sphere.", "Advises others in dealing with ethical dilemmas, displaying sensitivity to diversity, and diverse needs in all dealings and relationships, and in maintaining fairness, consistency, and equity. Challenges current organizational behaviours and methods of operating, when and where applicable. Sets direction in terms of ethical standards and values for the organization. Draws on internal and external networks to help ensure buy-in and ownership; enhances the visibility of the Coast Guard's operations in the broader public sphere." },
                    { 142, "Completes work assignments. Balances work to meet commitments and deadlines by being focused on goals.", "Completes work assignments. Balances work to meet commitments and deadlines by being focused on goals." },
                    { 143, "Responds to issues and/or brings concerns forward rather than waiting for them to be reported by someone else. Looks for new opportunities and seizes them when they arise. Plans for contingencies to deal with unexpected events. Structures work in order to achieve required results. ", "Responds to issues and/or brings concerns forward rather than waiting for them to be reported by someone else. Looks for new opportunities and seizes them when they arise. Plans for contingencies to deal with unexpected events. Structures work in order to achieve required results. " },
                    { 144, "Considers ideas from a variety of sources in order to solve problems. Remains flexible to find alternate ways around obstacles/barriers to achieve goals. Takes calculated risks to achieve goals/outcomes. Perseveres in seeking solutions despite obstacles. Regularly evaluate and challenges work processes. Establishes effective organizational methods for assigning, managing, and tracking work, when and where applicable. Solicits and/or provides information that could affect the planning, programs, and decision-making for the Canadian Coast Guard.", "Considers ideas from a variety of sources in order to solve problems. Remains flexible to find alternate ways around obstacles/barriers to achieve goals. Takes calculated risks to achieve goals/outcomes. Perseveres in seeking solutions despite obstacles. Regularly evaluate and challenges work processes. Establishes effective organizational methods for assigning, managing, and tracking work, when and where applicable. Solicits and/or provides information that could affect the planning, programs, and decision-making for the Canadian Coast Guard." },
                    { 145, "Offers expertise to resolve problems. Plans ahead to address future requirements without being asked. Anticipates and responds in a proactive manner to future needs of internal or external clients or groups. Coaches, supports, and encourages others to test limits, when and where applicable. Seeks new opportunities to improve outcomes using innovative approaches to overcome obstacles and surpass performance goals.", "Offers expertise to resolve problems. Plans ahead to address future requirements without being asked. Anticipates and responds in a proactive manner to future needs of internal or external clients or groups. Coaches, supports, and encourages others to test limits, when and where applicable. Seeks new opportunities to improve outcomes using innovative approaches to overcome obstacles and surpass performance goals." },
                    { 146, "Sets standards and criteria for measuring success organizationally. Seizes opportunities and initiatives across organizational boundaries to achieve efficiencies consistent with the Coast Guard's vision. Creates an environment in which all systems and processes support high levels of efficiency. Champions the ongoing spirit of improvement and professional growth across the organization.", "Sets standards and criteria for measuring success organizationally. Seizes opportunities and initiatives across organizational boundaries to achieve efficiencies consistent with the Coast Guard's vision. Creates an environment in which all systems and processes support high levels of efficiency. Champions the ongoing spirit of improvement and professional growth across the organization." },
                    { 147, "Awareness of the importance of safety in the Canadian Coast Guard. Familiar with the joining safety package.", "Awareness of the importance of safety in the Canadian Coast Guard. Familiar with the joining safety package." },
                    { 148, "Evaluates environment and adapts work to maintain safety. Ensures safety training is up to date. Uses appropriate personal protective equipment (PPE) when and where applicable. Applies proper safety procedures.", "Evaluates environment and adapts work to maintain safety. Ensures safety training is up to date. Uses appropriate personal protective equipment (PPE) when and where applicable. Applies proper safety procedures." },
                    { 149, "Conducts operations consistent with the Coast Guard Safety Management System (SMS), national and regulatory safety procedures, and policy when and where applicable. Understands the risks and manages safety and health issues when and where applicable. May participate in occupational health and safety groups and audits. ", "Conducts operations consistent with the Coast Guard Safety Management System (SMS), national and regulatory safety procedures, and policy when and where applicable. Understands the risks and manages safety and health issues when and where applicable. May participate in occupational health and safety groups and audits. " },
                    { 150, "Promotes a culture of unit safety. Ensures required personnel under supervision are trained in first aid and safety procedures. Ensures personnel under supervision apply safety plans and principles. Integrates health and safety planning in conformity with Incident Command Systems (ICS) principles when and where applicable. Integrates health and safety considerations in post-incident and post-exercise reviews.", "Promotes a culture of unit safety. Ensures required personnel under supervision are trained in first aid and safety procedures. Ensures personnel under supervision apply safety plans and principles. Integrates health and safety planning in conformity with Incident Command Systems (ICS) principles when and where applicable. Integrates health and safety considerations in post-incident and post-exercise reviews." },
                    { 151, "Promotes and integrates a culture of organizational safety. Develops risk analyses for responders and senior personnel regarding health and safety. Ensures required personnel are trained in first aid and safety procedures, as required. Leverages health and safety lessons learned from post-incident and post-exercise reviews in daily operations. ", "Promotes and integrates a culture of organizational safety. Develops risk analyses for responders and senior personnel regarding health and safety. Ensures required personnel are trained in first aid and safety procedures, as required. Leverages health and safety lessons learned from post-incident and post-exercise reviews in daily operations. " },
                    { 152, "Listens to leaders and emulates positive behaviour through observation and imitation, when and where applicable. Recognizes personal limitations and is motivated to address and improve them. ", "Listens to leaders and emulates positive behaviour through observation and imitation, when and where applicable. Recognizes personal limitations and is motivated to address and improve them. " },
                    { 153, "Adapts to change to help the team evolve in conjunction with the Coast Guard's evolving concerns. Seizes opportunities to increase skills and knowledge about operations, members, and stakeholders, when and where applicable. ", "Adapts to change to help the team evolve in conjunction with the Coast Guard's evolving concerns. Seizes opportunities to increase skills and knowledge about operations, members, and stakeholders, when and where applicable. " },
                    { 154, "Demonstrates interest in team members' success and well-being by listening and actively viewing situations through others' perspectives. Identifies strengths, leverages them, and persuades others for the benefit of the Coast Guard. Routinely teaches and guides work, based on operational knowledge through direct and indirect means. Seeks solutions by charting opinions and options.", "Demonstrates interest in team members' success and well-being by listening and actively viewing situations through others' perspectives. Identifies strengths, leverages them, and persuades others for the benefit of the Coast Guard. Routinely teaches and guides work, based on operational knowledge through direct and indirect means. Seeks solutions by charting opinions and options." },
                    { 155, "Links members' individual development to organizational objectives and developing future leaders. Encourages innovation. Remains effective in the face of obstacles. Identifies and assesses risks in projects or decisions and produces realistic contingency plans to mitigate possible impacts. Exercises positive influence on the organization when needed. ", "Links members' individual development to organizational objectives and developing future leaders. Encourages innovation. Remains effective in the face of obstacles. Identifies and assesses risks in projects or decisions and produces realistic contingency plans to mitigate possible impacts. Exercises positive influence on the organization when needed. " },
                    { 156, "Sets and champions organizational directions. Recognizes the big picture and cultivates organizational vision. Prioritizes the creation of a work environment that propels teams to step up to new challenges. Seamlessly assumes next level responsibilities. Regularly exercises persuasive influence on the organization in a wide variety of tactical and strategic areas.", "Sets and champions organizational directions. Recognizes the big picture and cultivates organizational vision. Prioritizes the creation of a work environment that propels teams to step up to new challenges. Seamlessly assumes next level responsibilities. Regularly exercises persuasive influence on the organization in a wide variety of tactical and strategic areas." },
                    { 157, "Articulates pride in being a member of the Coast Guard. Wears and maintains the uniform properly, when and where applicable.", "Articulates pride in being a member of the Coast Guard. Wears and maintains the uniform properly, when and where applicable." },
                    { 158, "Expresses pride in the humanitarian and environmental nature of the Coast Guard's mission. Participates in organizational engagement activities. Wears the uniform proudly.", "Expresses pride in the humanitarian and environmental nature of the Coast Guard's mission. Participates in organizational engagement activities. Wears the uniform proudly." },
                    { 159, "Expresses pride in the Coast Guard's regional and/or national achievements. Incorporates and models the Coast Guard's ambitious vision and motto in daily practice and supports it within units. Articulates the Coast Guard's vision when providing advice or instructions internally. ", "Expresses pride in the Coast Guard's regional and/or national achievements. Incorporates and models the Coast Guard's ambitious vision and motto in daily practice and supports it within units. Articulates the Coast Guard's vision when providing advice or instructions internally. " },
                    { 160, "Propagates the Coast Guard's vision, mission, mandate, and programs internally and externally as an example of deep pride in the organization. Conveys the importance of the Coast Guard's work to members and stakeholders. Celebrates organizational achievements.", "Propagates the Coast Guard's vision, mission, mandate, and programs internally and externally as an example of deep pride in the organization. Conveys the importance of the Coast Guard's work to members and stakeholders. Celebrates organizational achievements." },
                    { 161, "Models organizational pride in the Coast Guard's brand and the jobs it performs. Champions the organization when working collectively with internal and external stakeholders. Promotes organizational achievements and employee engagement events nationally. Strives to hone organizational excellence through celebration and pageantry.", "Models organizational pride in the Coast Guard's brand and the jobs it performs. Champions the organization when working collectively with internal and external stakeholders. Promotes organizational achievements and employee engagement events nationally. Strives to hone organizational excellence through celebration and pageantry." }
                });

            migrationBuilder.InsertData(
                table: "JobLocationRegions",
                columns: new[] { "Id", "NameEng", "NameFre" },
                values: new object[,]
                {
                    { 1, "Atlantic", "Atlantic" },
                    { 2, "Western", "Ouest" },
                    { 3, "Arctic", "Artique" },
                    { 4, "National Headquarters", "Siège national" },
                    { 5, "Central and Arctic", "Centre et Arctique" },
                    { 6, "CCG College", "Collège de la GCC" },
                    { 7, "All Regions", "Toutes les régions" }
                });

            migrationBuilder.InsertData(
                table: "JobPositions",
                columns: new[] { "Id", "TitleEng", "TitleFre" },
                values: new object[,]
                {
                    { 1, "Administrative (Admin) or Project Assistant or Executive Assitant / Officer (Aids to Nav. Database, Financial Admin, Scheduling Coordination, Documentation Control, Publication, Technical Business", "Assistant administratif ou de projet / Agent (Données d''aide à la navigation, Administratif financière, planification / Coordination contrôle de document, Publication, Affaires techniques" },
                    { 2, "Administrative / Information Officer", "Agent administratif Services de gestion intégrée des affaires (SGIA)" },
                    { 3, "Fleet Activity Information System (FAIS) Coordinator", "Coordinateur Système d’information sur les activités de la flotte (FAIS)" },
                    { 4, "Fleet Training Coordinator Assistant", "Officier de formation de la flotte" }
                });

            migrationBuilder.InsertData(
                table: "CompetencyTypeGroups",
                columns: new[] { "CompetencyId", "CompetencyTypeId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 2 },
                    { 10, 2 },
                    { 11, 2 },
                    { 12, 2 },
                    { 13, 2 },
                    { 14, 2 },
                    { 15, 2 },
                    { 16, 2 },
                    { 17, 2 },
                    { 18, 2 },
                    { 19, 2 },
                    { 20, 2 },
                    { 21, 2 },
                    { 22, 2 },
                    { 23, 2 },
                    { 24, 2 },
                    { 25, 2 },
                    { 26, 3 },
                    { 27, 3 },
                    { 28, 3 },
                    { 33, 3 },
                    { 34, 3 },
                    { 36, 3 },
                    { 37, 3 }
                });



            migrationBuilder.InsertData(
                table: "JobPositionCompetencies",
                columns: new[] { "JobPositionId", "CompetencyId", "CompetencyTypeId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 1, 2, 1 },
                    { 1, 3, 1 },
                    { 1, 9, 2 },
                    { 1, 10, 2 },
                    { 1, 13, 2 },
                    { 1, 17, 2 },
                    { 1, 23, 2 },
                    { 1, 26, 3 },
                    { 1, 27, 3 },
                    { 1, 28, 3 },
                    { 1, 33, 3 },
                    { 1, 34, 3 },
                    { 1, 36, 3 },
                    { 1, 37, 3 },

                    { 2, 3, 1 },
                    { 2, 9, 2 },
                    { 2, 10, 2 },
                    { 2, 13, 2 },
                    { 2, 17, 2 },
                    { 2, 23, 2 },
                    { 2, 26, 3 },
                    { 2, 27, 3 },
                    { 2, 28, 3 },
                    { 2, 33, 3 },
                    { 2, 34, 3 },
                    { 2, 36, 3 },
                    { 2, 37, 3 },

                    { 3, 1, 1 },
                    { 3, 2, 1 },
                    { 3, 3, 1 },
                    { 3, 10, 2 },
                    { 3, 17, 2 },
                    { 3, 23, 2 },
                    { 3, 26, 3 },
                    { 3, 27, 3 },
                    { 3, 28, 3 },
                    { 3, 33, 3 },
                    { 3, 34, 3 },
                    { 3, 36, 3 },
                    { 3, 37, 3 },

                    { 4, 1, 1 },
                    { 4, 2, 1 },
                    { 4, 3, 1 },
                    { 4, 9, 2 },
                    { 4, 10, 2 },
                    { 4, 12, 2 },
                    { 4, 17, 2 },
                    { 4, 22, 2 },
                    { 4, 23, 2 },
                    { 4, 24, 2 },
                    { 4, 25, 2 },
                    { 4, 26, 3 },
                    { 4, 27, 3 },
                    { 4, 28, 3 },
                    { 4, 33, 3 },
                    { 4, 34, 3 },
                    { 4, 36, 3 },
                    { 4, 37, 3 }
                });

            migrationBuilder.InsertData(
                table: "JobRolePositionCertificates",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId" },
                values: new object[,]
                {
                    { 2, 1, 1, 1 },
                    { 2, 1, 2, 1 },
                    { 2, 1, 3, 2 },
                    { 2, 1, 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "JobRolePositionCompetencies",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId", "CompetencyTypeId" },
                values: new object[,]
                {
                    { 2, 1, 1, 1, 1 },
                    { 2, 1, 1, 2, 1 },
                    { 2, 1, 1, 3, 1 },
                    { 2, 1, 1, 9, 2 },
                    { 2, 1, 1, 10, 2 },
                    { 2, 1, 1, 13, 2 },
                    { 2, 1, 1, 17, 2 },
                    { 2, 1, 1, 23, 2 },
                    { 2, 1, 1, 26, 3 },
                    { 2, 1, 1, 27, 3 },
                    { 2, 1, 1, 28, 3 },
                    { 2, 1, 1, 33, 3 },
                    { 2, 1, 1, 34, 3 },
                    { 2, 1, 1, 36, 3 },
                    { 2, 1, 1, 37, 3 },

                    { 2, 1, 2, 3, 1 },
                    { 2, 1, 2, 9, 2 },
                    { 2, 1, 2, 10, 2 },
                    { 2, 1, 2, 13, 2 },
                    { 2, 1, 2, 17, 2 },
                    { 2, 1, 2, 23, 2 },
                    { 2, 1, 2, 26, 3 },
                    { 2, 1, 2, 27, 3 },
                    { 2, 1, 2, 28, 3 },
                    { 2, 1, 2, 33, 3 },
                    { 2, 1, 2, 34, 3 },
                    { 2, 1, 2, 36, 3 },
                    { 2, 1, 2, 37, 3 },

                    { 2, 1, 3, 1, 1 },
                    { 2, 1, 3, 2, 1 },
                    { 2, 1, 3, 3, 1 },
                    { 2, 1, 3, 10, 2 },
                    { 2, 1, 3, 17, 2 },
                    { 2, 1, 3, 23, 2 },
                    { 2, 1, 3, 26, 3 },
                    { 2, 1, 3, 27, 3 },
                    { 2, 1, 3, 28, 3 },
                    { 2, 1, 3, 33, 3 },
                    { 2, 1, 3, 34, 3 },
                    { 2, 1, 3, 36, 3 },
                    { 2, 1, 3, 37, 3 },

                    { 2, 1, 4, 1, 1 },
                    { 2, 1, 4, 2, 1 },
                    { 2, 1, 4, 3, 1 },
                    { 2, 1, 4, 9, 2 },
                    { 2, 1, 4, 10, 2 },
                    { 2, 1, 4, 13, 2 },
                    { 2, 1, 4, 17, 2 },
                    { 2, 1, 4, 22, 2 },
                    { 2, 1, 4, 23, 2 },
                    { 2, 1, 4, 24, 2 },
                    { 2, 1, 4, 25, 2 },
                    { 2, 1, 4, 26, 3 },
                    { 2, 1, 4, 27, 3 },
                    { 2, 1, 4, 28, 3 },
                    { 2, 1, 4, 33, 3 },
                    { 2, 1, 4, 34, 3 },
                    { 2, 1, 4, 36, 3 },
                    { 2, 1, 4, 37, 3 }
                });

            migrationBuilder.InsertData(
                table: "JobRolePositionCompetencyRatings",
                columns: new[] { "JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId", "CompetencyTypeId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId" },
                values: new object[,]
                {
                    { 2, 1, 1, 1, 1, 1, 1 },
                    { 2, 1, 1, 2, 1, 2, 7 },
                    { 2, 1, 1, 3, 1, 2, 13 },
                    { 2, 1, 1, 9, 2, 1, 42 },
                    { 2, 1, 1, 10, 2, 1, 47 },
                    { 2, 1, 1, 13, 2, 1, 62 },
                    { 2, 1, 1, 17, 2, 2, 83 },
                    { 2, 1, 1, 23, 2, 1, 112 },
                    { 2, 1, 1, 26, 3, 2, 128 },
                    { 2, 1, 1, 27, 3, 2, 133 },
                    { 2, 1, 1, 28, 3, 2, 138 },
                    { 2, 1, 1, 33, 3, 2, 143 },
                    { 2, 1, 1, 34, 3, 2, 148 },
                    { 2, 1, 1, 36, 3, 2, 153 },
                    { 2, 1, 1, 37, 3, 2, 158 },
                    { 2, 1, 2, 3, 1, 2, 7 },
                    { 2, 1, 2, 9, 2, 1, 42 },
                    { 2, 1, 2, 10, 2, 1, 47 },
                    { 2, 1, 2, 13, 2, 1, 62 },
                    { 2, 1, 2, 17, 2, 2, 83 },
                    { 2, 1, 2, 23, 2, 1, 112 },
                    { 2, 1, 2, 26, 3, 2, 128 },
                    { 2, 1, 2, 27, 3, 2, 133 },
                    { 2, 1, 2, 28, 3, 2, 138 },
                    { 2, 1, 2, 33, 3, 2, 143 },
                    { 2, 1, 2, 34, 3, 2, 148 },
                    { 2, 1, 2, 36, 3, 2, 153 },
                    { 2, 1, 2, 37, 3, 2, 158 },
                    { 2, 1, 3, 1, 1, 1, 1 },
                    { 2, 1, 3, 2, 1, 2, 7 },
                    { 2, 1, 3, 3, 1, 2, 13 },
                    { 2, 1, 3, 10, 2, 1, 47 },
                    { 2, 1, 3, 17, 2, 2, 83 },
                    { 2, 1, 3, 23, 2, 1, 112 },
                    { 2, 1, 3, 26, 3, 2, 128 },
                    { 2, 1, 3, 27, 3, 2, 133 },
                    { 2, 1, 3, 28, 3, 2, 138 },
                    { 2, 1, 3, 33, 3, 2, 143 },
                    { 2, 1, 3, 34, 3, 2, 148 },
                    { 2, 1, 3, 36, 3, 2, 153 },
                    { 2, 1, 3, 37, 3, 2, 158 },
                    { 2, 1, 4, 1, 1, 1, 1 },
                    { 2, 1, 4, 2, 1, 2, 7 },
                    { 2, 1, 4, 3, 1, 2, 13 },
                    { 2, 1, 4, 9, 2, 1, 42 },
                    { 2, 1, 4, 10, 2, 1, 47 },
                    { 2, 1, 4, 12, 2, 1, 57 },
                    { 2, 1, 4, 17, 2, 2, 83 },
                    { 2, 1, 4, 22, 2, 1, 107 },
                    { 2, 1, 4, 23, 2, 1, 112 },
                    { 2, 1, 4, 24, 2, 1, 117 },
                    { 2, 1, 4, 25, 2, 1, 122 },
                    { 2, 1, 4, 26, 3, 2, 128 },
                    { 2, 1, 4, 27, 3, 2, 133 },
                    { 2, 1, 4, 28, 3, 2, 138 },
                    { 2, 1, 4, 33, 3, 2, 143 },
                    { 2, 1, 4, 34, 3, 2, 148 },
                    { 2, 1, 4, 36, 3, 2, 153 },
                    { 2, 1, 4, 37, 3, 2, 158 }
                });

            migrationBuilder.InsertData(
                table: "JobRoles",
                columns: new[] { "JobGroupId", "JobGroupLevelId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompetencyTypeGroups_CompetencyTypeId",
                table: "CompetencyTypeGroups",
                column: "CompetencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobGroupPositions_JobCategoryId",
                table: "JobGroupPositions",
                column: "JobCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobGroupPositions_JobGroupLevelId",
                table: "JobGroupPositions",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobGroupPositions_JobKeyTaskPerLevelId",
                table: "JobGroupPositions",
                column: "JobKeyTaskPerLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobGroupPositions_JobLocationRegionId",
                table: "JobGroupPositions",
                column: "JobLocationRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_JobGroupPositions_JobPositionId",
                table: "JobGroupPositions",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPositionCertificates_CertificateId",
                table: "JobPositionCertificates",
                column: "CertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPositionCompetencies_CompetencyId",
                table: "JobPositionCompetencies",
                column: "CompetencyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPositionCompetencies_CompetencyTypeId",
                table: "JobPositionCompetencies",
                column: "CompetencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCertificates_CertificateId",
                table: "JobRolePositionCertificates",
                column: "CertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCertificates_JobGroupLevelId",
                table: "JobRolePositionCertificates",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCertificates_JobPositionId",
                table: "JobRolePositionCertificates",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencies_CompetencyId",
                table: "JobRolePositionCompetencies",
                column: "CompetencyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencies_CompetencyTypeId",
                table: "JobRolePositionCompetencies",
                column: "CompetencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencies_JobGroupLevelId",
                table: "JobRolePositionCompetencies",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencies_JobPositionId",
                table: "JobRolePositionCompetencies",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencyRatings_CompetencyId",
                table: "JobRolePositionCompetencyRatings",
                column: "CompetencyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencyRatings_CompetencyLevelRequirementId",
                table: "JobRolePositionCompetencyRatings",
                column: "CompetencyLevelRequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencyRatings_CompetencyRatingLevelId",
                table: "JobRolePositionCompetencyRatings",
                column: "CompetencyRatingLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencyRatings_CompetencyTypeId",
                table: "JobRolePositionCompetencyRatings",
                column: "CompetencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencyRatings_JobGroupLevelId",
                table: "JobRolePositionCompetencyRatings",
                column: "JobGroupLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRolePositionCompetencyRatings_JobPositionId",
                table: "JobRolePositionCompetencyRatings",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRoles_JobGroupLevelId",
                table: "JobRoles",
                column: "JobGroupLevelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "Competencies");

            migrationBuilder.DropTable(
                name: "CompetencyLevelRequirements");

            migrationBuilder.DropTable(
                name: "CompetencyRatingGroup");

            migrationBuilder.DropTable(
                name: "CompetencyRatingLevels");

            migrationBuilder.DropTable(
                name: "CompetencyTypeGroups");

            migrationBuilder.DropTable(
                name: "CompetencyTypes");

            migrationBuilder.DropTable(
                name: "JobCategories");
           
            migrationBuilder.DropTable(
                name: "JobGroupLevels");
            
            migrationBuilder.DropTable(
                name: "JobGroupPositions");

            migrationBuilder.DropTable(
                name: "JobGroups");

            migrationBuilder.DropTable(
                name: "JobKeyTaskPerLevels");

            migrationBuilder.DropTable(
               name: "JobLocationRegions");

            migrationBuilder.DropTable(
               name: "JobPositionCertificates");

            migrationBuilder.DropTable(
                name: "JobPositionCompetencies");

            migrationBuilder.DropTable(
                name: "JobPositions");

            migrationBuilder.DropTable(
                name: "JobRolePositionCertificates");

            migrationBuilder.DropTable(
                name: "JobRolePositionCompetencies");

            migrationBuilder.DropTable(
                name: "JobRolePositionCompetencyRatings");

            migrationBuilder.DropTable(
                name: "JobRoles");
        }

    }
}