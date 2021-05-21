﻿// <auto-generated />
using DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataModel.Migrations
{
    [DbContext(typeof(CctDbContext))]
    [Migration("20210518171423_NewDataModel")]
    partial class NewDataModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataModel.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescEng")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("DescFre")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("NameEng")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("NameFre")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("DataModel.CertificateDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescEng")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("DescFre")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.ToTable("CertificateDescriptions");
                });

            modelBuilder.Entity("DataModel.Competency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescEng")
                        .IsRequired()
                        .HasColumnType("nvarchar(2500)")
                        .HasMaxLength(2500);

                    b.Property<string>("DescFre")
                        .IsRequired()
                        .HasColumnType("nvarchar(2500)")
                        .HasMaxLength(2500);

                    b.Property<string>("NameEng")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("NameFre")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.ToTable("Competencies");
                });

            modelBuilder.Entity("DataModel.CompetencyLevelRequirement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescEng")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(8000);

                    b.Property<string>("DescFre")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(8000);

                    b.HasKey("Id");

                    b.ToTable("CompetencyLevelRequirements");
                });

            modelBuilder.Entity("DataModel.CompetencyRatingGroup", b =>
                {
                    b.Property<int>("CompetencyId")
                        .HasColumnType("int");

                    b.Property<int>("CompetencyRatingLevelId")
                        .HasColumnType("int");

                    b.Property<int>("CompetencyLevelRequirementId")
                        .HasColumnType("int");

                    b.HasKey("CompetencyId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId");

                    b.HasIndex("CompetencyLevelRequirementId");

                    b.HasIndex("CompetencyRatingLevelId");

                    b.ToTable("CompetencyRatingGroups");
                });

            modelBuilder.Entity("DataModel.CompetencyRatingLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescEng")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("DescFre")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("NameEng")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("NameFre")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CompetencyRatingLevels");
                });

            modelBuilder.Entity("DataModel.CompetencyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameEng")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("NameFre")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("CompetencyTypes");
                });

            modelBuilder.Entity("DataModel.CompetencyTypeGroup", b =>
                {
                    b.Property<int>("CompetencyId")
                        .HasColumnType("int");

                    b.Property<int>("CompetencyTypeId")
                        .HasColumnType("int");

                    b.HasKey("CompetencyId", "CompetencyTypeId");

                    b.HasIndex("CompetencyTypeId");

                    b.ToTable("CompetencyTypeGroups");
                });

            modelBuilder.Entity("DataModel.JobGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("NameEng")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("NameFre")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("JobGroups");
                });

            modelBuilder.Entity("DataModel.JobGroupLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LevelValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("JobGroupLevels");
                });

            modelBuilder.Entity("DataModel.JobGroupPosition", b =>
                {
                    b.Property<int>("JobGroupId")
                        .HasColumnType("int");

                    b.Property<int>("SubJobGroupId")
                        .HasColumnType("int");

                    b.Property<int>("JobGroupLevelId")
                        .HasColumnType("int");

                    b.Property<int>("JobPositionId")
                        .HasColumnType("int");

                    b.Property<int>("SubJobGroupId1")
                        .HasColumnType("int");

                    b.Property<int>("SubJobGroupJobGroupId")
                        .HasColumnType("int");

                    b.HasKey("JobGroupId", "SubJobGroupId", "JobGroupLevelId", "JobPositionId");

                    b.HasIndex("JobGroupLevelId");

                    b.HasIndex("JobPositionId");

                    b.HasIndex("SubJobGroupId1", "SubJobGroupJobGroupId");

                    b.ToTable("JobGroupPositions");
                });

            modelBuilder.Entity("DataModel.JobHLCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ValueEng")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("ValueFre")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("JobHLCategories");
                });

            modelBuilder.Entity("DataModel.JobLocationRegion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameEng")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("NameFre")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("JobLocationRegions");
                });

            modelBuilder.Entity("DataModel.JobPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TitleEng")
                        .IsRequired()
                        .HasColumnType("nvarchar(3000)")
                        .HasMaxLength(3000);

                    b.Property<string>("TitleFre")
                        .IsRequired()
                        .HasColumnType("nvarchar(3000)")
                        .HasMaxLength(3000);

                    b.HasKey("Id");

                    b.ToTable("JobPositions");
                });

            modelBuilder.Entity("DataModel.JobPositionCompetency", b =>
                {
                    b.Property<int>("JobPositionId")
                        .HasColumnType("int");

                    b.Property<int>("CompetencyId")
                        .HasColumnType("int");

                    b.Property<int>("CompetencyTypeId")
                        .HasColumnType("int");

                    b.HasKey("JobPositionId", "CompetencyId", "CompetencyTypeId");

                    b.HasIndex("CompetencyId");

                    b.HasIndex("CompetencyTypeId");

                    b.ToTable("JobPositionCompetencies");
                });

            modelBuilder.Entity("DataModel.JobRole", b =>
                {
                    b.Property<int>("JobGroupId")
                        .HasColumnType("int");

                    b.Property<int>("SubJobGroupId")
                        .HasColumnType("int");

                    b.Property<int>("JobGroupLevelId")
                        .HasColumnType("int");

                    b.Property<int>("SubJobGroupId1")
                        .HasColumnType("int");

                    b.Property<int>("SubJobGroupJobGroupId")
                        .HasColumnType("int");

                    b.HasKey("JobGroupId", "SubJobGroupId", "JobGroupLevelId");

                    b.HasIndex("JobGroupLevelId");

                    b.HasIndex("SubJobGroupId1", "SubJobGroupJobGroupId");

                    b.ToTable("JobRoles");
                });

            modelBuilder.Entity("DataModel.JobRolePositionCertificate", b =>
                {
                    b.Property<int>("JobGroupId")
                        .HasColumnType("int");

                    b.Property<int>("SubJobGroupId")
                        .HasColumnType("int");

                    b.Property<int>("JobGroupLevelId")
                        .HasColumnType("int");

                    b.Property<int>("JobPositionId")
                        .HasColumnType("int");

                    b.Property<int>("CertificateId")
                        .HasColumnType("int");

                    b.Property<int>("CertificateDescriptionId")
                        .HasColumnType("int");

                    b.Property<int>("SubJobGroupId1")
                        .HasColumnType("int");

                    b.Property<int>("SubJobGroupJobGroupId")
                        .HasColumnType("int");

                    b.HasKey("JobGroupId", "SubJobGroupId", "JobGroupLevelId", "JobPositionId", "CertificateId", "CertificateDescriptionId");

                    b.HasIndex("CertificateDescriptionId");

                    b.HasIndex("CertificateId");

                    b.HasIndex("JobGroupLevelId");

                    b.HasIndex("JobPositionId");

                    b.HasIndex("SubJobGroupId1", "SubJobGroupJobGroupId");

                    b.ToTable("JobRolePositionCertificates");
                });

            modelBuilder.Entity("DataModel.JobRolePositionCompetency", b =>
                {
                    b.Property<int>("JobGroupId")
                        .HasColumnType("int");

                    b.Property<int>("SubJobGroupId")
                        .HasColumnType("int");

                    b.Property<int>("JobGroupLevelId")
                        .HasColumnType("int");

                    b.Property<int>("JobPositionId")
                        .HasColumnType("int");

                    b.Property<int>("CompetencyId")
                        .HasColumnType("int");

                    b.Property<int>("CompetencyTypeId")
                        .HasColumnType("int");

                    b.Property<int>("SubJobGroupId1")
                        .HasColumnType("int");

                    b.Property<int>("SubJobGroupJobGroupId")
                        .HasColumnType("int");

                    b.HasKey("JobGroupId", "SubJobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId", "CompetencyTypeId");

                    b.HasIndex("CompetencyId");

                    b.HasIndex("CompetencyTypeId");

                    b.HasIndex("JobGroupLevelId");

                    b.HasIndex("JobPositionId");

                    b.HasIndex("SubJobGroupId1", "SubJobGroupJobGroupId");

                    b.ToTable("JobRolePositionCompetencies");
                });

            modelBuilder.Entity("DataModel.JobRolePositionCompetencyRating", b =>
                {
                    b.Property<int>("JobGroupId")
                        .HasColumnType("int");

                    b.Property<int>("SubJobGroupId")
                        .HasColumnType("int");

                    b.Property<int>("JobGroupLevelId")
                        .HasColumnType("int");

                    b.Property<int>("JobPositionId")
                        .HasColumnType("int");

                    b.Property<int>("CompetencyId")
                        .HasColumnType("int");

                    b.Property<int>("CompetencyTypeId")
                        .HasColumnType("int");

                    b.Property<int>("CompetencyRatingLevelId")
                        .HasColumnType("int");

                    b.Property<int>("CompetencyLevelRequirementId")
                        .HasColumnType("int");

                    b.Property<int>("SubJobGroupId1")
                        .HasColumnType("int");

                    b.Property<int>("SubJobGroupJobGroupId")
                        .HasColumnType("int");

                    b.HasKey("JobGroupId", "SubJobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId", "CompetencyTypeId", "CompetencyRatingLevelId", "CompetencyLevelRequirementId");

                    b.HasIndex("CompetencyId");

                    b.HasIndex("CompetencyLevelRequirementId");

                    b.HasIndex("CompetencyRatingLevelId");

                    b.HasIndex("CompetencyTypeId");

                    b.HasIndex("JobGroupLevelId");

                    b.HasIndex("JobPositionId");

                    b.HasIndex("SubJobGroupId1", "SubJobGroupJobGroupId");

                    b.ToTable("JobRolePositionCompetencyRatings");
                });

            modelBuilder.Entity("DataModel.JobRolePositionHLCategory", b =>
                {
                    b.Property<int>("JobGroupId")
                        .HasColumnType("int");

                    b.Property<int>("SubJobGroupId")
                        .HasColumnType("int");

                    b.Property<int>("JobGroupLevelId")
                        .HasColumnType("int");

                    b.Property<int>("JobPositionId")
                        .HasColumnType("int");

                    b.Property<int>("JobHLCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("SubJobGroupId1")
                        .HasColumnType("int");

                    b.Property<int>("SubJobGroupJobGroupId")
                        .HasColumnType("int");

                    b.HasKey("JobGroupId", "SubJobGroupId", "JobGroupLevelId", "JobPositionId", "JobHLCategoryId");

                    b.HasIndex("JobGroupLevelId");

                    b.HasIndex("JobHLCategoryId");

                    b.HasIndex("JobPositionId");

                    b.HasIndex("SubJobGroupId1", "SubJobGroupJobGroupId");

                    b.ToTable("JobRolePositionHLCategories");
                });

            modelBuilder.Entity("DataModel.JobRolePositionLocation", b =>
                {
                    b.Property<int>("JobGroupId")
                        .HasColumnType("int");

                    b.Property<int>("SubJobGroupId")
                        .HasColumnType("int");

                    b.Property<int>("JobGroupLevelId")
                        .HasColumnType("int");

                    b.Property<int>("JobPositionId")
                        .HasColumnType("int");

                    b.Property<int>("JobLocationRegionId")
                        .HasColumnType("int");

                    b.Property<int>("SubJobGroupId1")
                        .HasColumnType("int");

                    b.Property<int>("SubJobGroupJobGroupId")
                        .HasColumnType("int");

                    b.HasKey("JobGroupId", "SubJobGroupId", "JobGroupLevelId", "JobPositionId", "JobLocationRegionId");

                    b.HasIndex("JobGroupLevelId");

                    b.HasIndex("JobLocationRegionId");

                    b.HasIndex("JobPositionId");

                    b.HasIndex("SubJobGroupId1", "SubJobGroupJobGroupId");

                    b.ToTable("JobRolePositionLocations");
                });

            modelBuilder.Entity("DataModel.SubJobGroup", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("JobGroupId")
                        .HasColumnType("int");

                    b.Property<string>("NameEng")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("NameFre")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("SubCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id", "JobGroupId");

                    b.HasIndex("JobGroupId");

                    b.ToTable("SubJobGroups");
                });

            modelBuilder.Entity("DataModel.CompetencyRatingGroup", b =>
                {
                    b.HasOne("DataModel.Competency", "Competency")
                        .WithMany()
                        .HasForeignKey("CompetencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.CompetencyLevelRequirement", "CompetencyLevelRequirement")
                        .WithMany()
                        .HasForeignKey("CompetencyLevelRequirementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.CompetencyRatingLevel", "CompetencyRatingLevel")
                        .WithMany()
                        .HasForeignKey("CompetencyRatingLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataModel.CompetencyTypeGroup", b =>
                {
                    b.HasOne("DataModel.Competency", "Competency")
                        .WithMany("CompetencyTypeGroups")
                        .HasForeignKey("CompetencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.CompetencyType", "CompetencyType")
                        .WithMany("CompetencyTypeGroups")
                        .HasForeignKey("CompetencyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataModel.JobGroupPosition", b =>
                {
                    b.HasOne("DataModel.JobGroup", "JobGroup")
                        .WithMany("JobGroupPositions")
                        .HasForeignKey("JobGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobGroupLevel", "JobGroupLevel")
                        .WithMany("JobGroupPositions")
                        .HasForeignKey("JobGroupLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobPosition", "JobPosition")
                        .WithMany()
                        .HasForeignKey("JobPositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.SubJobGroup", "SubJobGroup")
                        .WithMany()
                        .HasForeignKey("SubJobGroupId1", "SubJobGroupJobGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataModel.JobPositionCompetency", b =>
                {
                    b.HasOne("DataModel.Competency", "Competency")
                        .WithMany("JobPositionCompetencies")
                        .HasForeignKey("CompetencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.CompetencyType", "CompetencyType")
                        .WithMany()
                        .HasForeignKey("CompetencyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobPosition", "JobPosition")
                        .WithMany("JobPositionCompetencies")
                        .HasForeignKey("JobPositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataModel.JobRole", b =>
                {
                    b.HasOne("DataModel.JobGroup", "JobGroup")
                        .WithMany("JobRoles")
                        .HasForeignKey("JobGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobGroupLevel", "JobGroupLevel")
                        .WithMany("JobRoles")
                        .HasForeignKey("JobGroupLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.SubJobGroup", "SubJobGroup")
                        .WithMany()
                        .HasForeignKey("SubJobGroupId1", "SubJobGroupJobGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataModel.JobRolePositionCertificate", b =>
                {
                    b.HasOne("DataModel.CertificateDescription", "CertificateDescription")
                        .WithMany("JobRolePositionCertificates")
                        .HasForeignKey("CertificateDescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.Certificate", "Certificate")
                        .WithMany("JobRolePositionCertificates")
                        .HasForeignKey("CertificateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobGroup", "JobGroup")
                        .WithMany()
                        .HasForeignKey("JobGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobGroupLevel", "JobGroupLevel")
                        .WithMany()
                        .HasForeignKey("JobGroupLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobPosition", "JobPosition")
                        .WithMany("JobRolePositionCertificates")
                        .HasForeignKey("JobPositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.SubJobGroup", "SubJobGroup")
                        .WithMany()
                        .HasForeignKey("SubJobGroupId1", "SubJobGroupJobGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataModel.JobRolePositionCompetency", b =>
                {
                    b.HasOne("DataModel.Competency", "Competency")
                        .WithMany("JobRolePositionCompetencies")
                        .HasForeignKey("CompetencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.CompetencyType", "CompetencyType")
                        .WithMany()
                        .HasForeignKey("CompetencyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobGroup", "JobGroup")
                        .WithMany("JobRolePositionCompetencies")
                        .HasForeignKey("JobGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobGroupLevel", "JobGroupLevel")
                        .WithMany("JobRolePositionCompetencies")
                        .HasForeignKey("JobGroupLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobPosition", "JobPosition")
                        .WithMany("JobRolePositionCompetencies")
                        .HasForeignKey("JobPositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.SubJobGroup", "SubJobGroup")
                        .WithMany()
                        .HasForeignKey("SubJobGroupId1", "SubJobGroupJobGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataModel.JobRolePositionCompetencyRating", b =>
                {
                    b.HasOne("DataModel.Competency", "Competency")
                        .WithMany("JobRolePositionCompetencyRatings")
                        .HasForeignKey("CompetencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.CompetencyLevelRequirement", "CompetencyLevelRequirement")
                        .WithMany("JobRolePositionCompetencyRatings")
                        .HasForeignKey("CompetencyLevelRequirementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.CompetencyRatingLevel", "CompetencyRatingLevel")
                        .WithMany("JobRolePositionCompetencyRatings")
                        .HasForeignKey("CompetencyRatingLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.CompetencyType", "CompetencyType")
                        .WithMany()
                        .HasForeignKey("CompetencyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobGroup", "JobGroup")
                        .WithMany()
                        .HasForeignKey("JobGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobGroupLevel", "JobGroupLevel")
                        .WithMany()
                        .HasForeignKey("JobGroupLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobPosition", "JobPosition")
                        .WithMany()
                        .HasForeignKey("JobPositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.SubJobGroup", "SubJobGroup")
                        .WithMany()
                        .HasForeignKey("SubJobGroupId1", "SubJobGroupJobGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataModel.JobRolePositionHLCategory", b =>
                {
                    b.HasOne("DataModel.JobGroup", "JobGroup")
                        .WithMany()
                        .HasForeignKey("JobGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobGroupLevel", "JobGroupLevel")
                        .WithMany()
                        .HasForeignKey("JobGroupLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobHLCategory", "JobHLCategory")
                        .WithMany("JobRolePositionHLCategory")
                        .HasForeignKey("JobHLCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobPosition", "JobPosition")
                        .WithMany()
                        .HasForeignKey("JobPositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.SubJobGroup", "SubJobGroup")
                        .WithMany()
                        .HasForeignKey("SubJobGroupId1", "SubJobGroupJobGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataModel.JobRolePositionLocation", b =>
                {
                    b.HasOne("DataModel.JobGroup", "JobGroup")
                        .WithMany()
                        .HasForeignKey("JobGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobGroupLevel", "JobGroupLevel")
                        .WithMany()
                        .HasForeignKey("JobGroupLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobLocationRegion", "JobLocationRegion")
                        .WithMany("JobRolePositionLocations")
                        .HasForeignKey("JobLocationRegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobPosition", "JobPosition")
                        .WithMany()
                        .HasForeignKey("JobPositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.SubJobGroup", "SubJobGroup")
                        .WithMany()
                        .HasForeignKey("SubJobGroupId1", "SubJobGroupJobGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataModel.SubJobGroup", b =>
                {
                    b.HasOne("DataModel.JobGroup", "JobGroup")
                        .WithMany("SubJobGroups")
                        .HasForeignKey("JobGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
