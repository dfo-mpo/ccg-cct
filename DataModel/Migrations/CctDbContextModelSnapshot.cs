﻿// <auto-generated />
using System;
using DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataModel.Migrations
{
    [DbContext(typeof(CctDbContext))]
    partial class CctDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataModel.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompetencyId")
                        .HasColumnType("int");

                    b.Property<string>("DescEng")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("DescFre")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("RequireIndicatorEng")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("RequireIndicatorFre")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("CompetencyId");

                    b.HasIndex("Id");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("DataModel.Competency", b =>
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

                    b.ToTable("Competencies");
                });

            modelBuilder.Entity("DataModel.CompetencyLevelRequirement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescEng")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("DescFre")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

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
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("DescFre")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("NameEng")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("NameFre")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

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

            modelBuilder.Entity("DataModel.JobCategory", b =>
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

                    b.ToTable("JobCategories");
                });

            modelBuilder.Entity("DataModel.JobGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassificationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("JobGroups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClassificationName = "GT"
                        },
                        new
                        {
                            Id = 2,
                            ClassificationName = "PG"
                        },
                        new
                        {
                            Id = 3,
                            ClassificationName = "SO-MAO"
                        });
                });

            modelBuilder.Entity("DataModel.JobGroupLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("JobGroupLevels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Value = "01"
                        },
                        new
                        {
                            Id = 2,
                            Value = "02"
                        },
                        new
                        {
                            Id = 3,
                            Value = "03"
                        });
                });

            modelBuilder.Entity("DataModel.JobGroupPosition", b =>
                {
                    b.Property<int>("JobGroupId")
                        .HasColumnType("int");

                    b.Property<int>("JobGroupLevelId")
                        .HasColumnType("int");

                    b.Property<int>("JobCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("JobPositionId")
                        .HasColumnType("int");

                    b.Property<int>("JobKeyTaskPerLevelId")
                        .HasColumnType("int");

                    b.Property<int>("JobLocationRegionId")
                        .HasColumnType("int");

                    b.HasKey("JobGroupId", "JobGroupLevelId", "JobCategoryId", "JobPositionId", "JobKeyTaskPerLevelId", "JobLocationRegionId");

                    b.HasIndex("JobCategoryId");

                    b.HasIndex("JobGroupLevelId");

                    b.HasIndex("JobKeyTaskPerLevelId");

                    b.HasIndex("JobLocationRegionId");

                    b.HasIndex("JobPositionId");

                    b.ToTable("JobGroupPositions");
                });

            modelBuilder.Entity("DataModel.JobKeyTaskPerLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescEng")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("DescFre")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("JobKeyTaskPerLevels");
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
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("TitleFre")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("JobPositions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TitleEng = "Manager",
                            TitleFre = "Gestionnaire"
                        },
                        new
                        {
                            Id = 2,
                            TitleEng = "Technical Advisor",
                            TitleFre = "Conseiller technique"
                        },
                        new
                        {
                            Id = 3,
                            TitleEng = "Business Architect",
                            TitleFre = "Architecte d'affaires"
                        },
                        new
                        {
                            Id = 4,
                            TitleEng = "Project Officer",
                            TitleFre = "Agent de projets"
                        },
                        new
                        {
                            Id = 5,
                            TitleEng = "Project Manager",
                            TitleFre = "Gestionnaire de projets"
                        });
                });

            modelBuilder.Entity("DataModel.JobPositionCompetency", b =>
                {
                    b.Property<int>("JobPositionId")
                        .HasColumnType("int");

                    b.Property<int>("CompetencyId")
                        .HasColumnType("int");

                    b.HasKey("JobPositionId", "CompetencyId");

                    b.HasIndex("CompetencyId");

                    b.ToTable("JobPositionCompetencies");
                });

            modelBuilder.Entity("DataModel.JobRole", b =>
                {
                    b.Property<int>("JobGroupId")
                        .HasColumnType("int");

                    b.Property<int>("JobGroupLevelId")
                        .HasColumnType("int");

                    b.HasKey("JobGroupId", "JobGroupLevelId");

                    b.HasIndex("JobGroupLevelId");

                    b.ToTable("JobRoles");
                });

            modelBuilder.Entity("DataModel.JobRolePositionCompetency", b =>
                {
                    b.Property<int>("JobGroupId")
                        .HasColumnType("int");

                    b.Property<int>("JobGroupLevelId")
                        .HasColumnType("int");

                    b.Property<int>("JobPositionId")
                        .HasColumnType("int");

                    b.Property<int>("CompetencyId")
                        .HasColumnType("int");

                    b.HasKey("JobGroupId", "JobGroupLevelId", "JobPositionId", "CompetencyId");

                    b.HasIndex("CompetencyId");

                    b.HasIndex("JobGroupLevelId");

                    b.HasIndex("JobPositionId");

                    b.ToTable("JobRolesPositionCompetencies");
                });

            modelBuilder.Entity("DataModel.Certificate", b =>
                {
                    b.HasOne("DataModel.Competency", "Competency")
                        .WithMany()
                        .HasForeignKey("CompetencyId");
                });

            modelBuilder.Entity("DataModel.CompetencyRatingGroup", b =>
                {
                    b.HasOne("DataModel.Competency", "Competency")
                        .WithMany("CompetencyRatingGroups")
                        .HasForeignKey("CompetencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.CompetencyLevelRequirement", "CompetencyLevelRequirement")
                        .WithMany("CompetencyRatingGroups")
                        .HasForeignKey("CompetencyLevelRequirementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.CompetencyRatingLevel", "CompetencyRatingLevel")
                        .WithMany("CompetencyRatingGroups")
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
                    b.HasOne("DataModel.JobCategory", "JobCategory")
                        .WithMany("JobGroupPositions")
                        .HasForeignKey("JobCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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

                    b.HasOne("DataModel.JobKeyTaskPerLevel", "JobKeyTaskPerLevel")
                        .WithMany("JobGroupPositions")
                        .HasForeignKey("JobKeyTaskPerLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobLocationRegion", "JobLocationRegion")
                        .WithMany("JobGroupPositions")
                        .HasForeignKey("JobLocationRegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobPosition", "JobPosition")
                        .WithMany()
                        .HasForeignKey("JobPositionId")
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
                });

            modelBuilder.Entity("DataModel.JobRolePositionCompetency", b =>
                {
                    b.HasOne("DataModel.Competency", "Competency")
                        .WithMany("JobRolesPositionCompetencies")
                        .HasForeignKey("CompetencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobGroup", "JobGroup")
                        .WithMany("JobRolesPositionCompetencies")
                        .HasForeignKey("JobGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobGroupLevel", "JobGroupLevel")
                        .WithMany("JobRolesPositionCompetencies")
                        .HasForeignKey("JobGroupLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.JobPosition", "JobPosition")
                        .WithMany("JobRolesPositionCompetencies")
                        .HasForeignKey("JobPositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
