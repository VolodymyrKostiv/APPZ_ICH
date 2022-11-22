﻿// <auto-generated />
using System;
using ICH.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ICH.DAL.Migrations
{
    [DbContext(typeof(ICHDBContext))]
    partial class ICHDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ICH.DAL.Entities.General.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("ICH.DAL.Entities.User.CV", b =>
                {
                    b.Property<int>("CVId")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CVId");

                    b.ToTable("CV");
                });

            modelBuilder.Entity("ICH.DAL.Entities.User.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserTypeId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("UserTypeId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ICH.DAL.Entities.User.UserInfo", b =>
                {
                    b.Property<int>("UserInfoId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("UserInfoId");

                    b.HasIndex("LocationId");

                    b.ToTable("UserInfo");
                });

            modelBuilder.Entity("ICH.DAL.Entities.User.UserType", b =>
                {
                    b.Property<int>("UserTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserTypeId"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UserTypeId");

                    b.ToTable("UserType");
                });

            modelBuilder.Entity("ICH.DAL.Entities.Vacancy.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ICH.DAL.Entities.Vacancy.EmploymentType", b =>
                {
                    b.Property<int>("EmploymentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmploymentTypeId"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("EmploymentTypeId");

                    b.ToTable("EmploymentTypes");
                });

            modelBuilder.Entity("ICH.DAL.Entities.Vacancy.SpecialCategory", b =>
                {
                    b.Property<int>("SpecialCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpecialCategoryId"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SpecialCategoryId");

                    b.ToTable("SpecialCategories");
                });

            modelBuilder.Entity("ICH.DAL.Entities.Vacancy.Vacancy", b =>
                {
                    b.Property<int>("VacancyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VacancyId"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmploymentTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<int?>("Salary")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("WorkTypeId")
                        .HasColumnType("int");

                    b.HasKey("VacancyId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EmploymentTypeId");

                    b.HasIndex("LocationId");

                    b.HasIndex("UserId");

                    b.HasIndex("WorkTypeId");

                    b.ToTable("Vacancies");
                });

            modelBuilder.Entity("ICH.DAL.Entities.Vacancy.WorkType", b =>
                {
                    b.Property<int>("WorkTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkTypeId"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("WorkTypeId");

                    b.ToTable("WorkTypes");
                });

            modelBuilder.Entity("SpecialCategoryVacancy", b =>
                {
                    b.Property<int>("SpecialCategoriesSpecialCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("VacanciesVacancyId")
                        .HasColumnType("int");

                    b.HasKey("SpecialCategoriesSpecialCategoryId", "VacanciesVacancyId");

                    b.HasIndex("VacanciesVacancyId");

                    b.ToTable("SpecialCategoryVacancy");
                });

            modelBuilder.Entity("ICH.DAL.Entities.User.CV", b =>
                {
                    b.HasOne("ICH.DAL.Entities.User.UserInfo", "UserInfo")
                        .WithOne("CV")
                        .HasForeignKey("ICH.DAL.Entities.User.CV", "CVId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("ICH.DAL.Entities.User.User", b =>
                {
                    b.HasOne("ICH.DAL.Entities.User.UserType", "UserType")
                        .WithMany("Users")
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserType");
                });

            modelBuilder.Entity("ICH.DAL.Entities.User.UserInfo", b =>
                {
                    b.HasOne("ICH.DAL.Entities.General.Location", "Location")
                        .WithMany("UserInfos")
                        .HasForeignKey("LocationId");

                    b.HasOne("ICH.DAL.Entities.User.User", "User")
                        .WithOne("UserInfo")
                        .HasForeignKey("ICH.DAL.Entities.User.UserInfo", "UserInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ICH.DAL.Entities.Vacancy.Vacancy", b =>
                {
                    b.HasOne("ICH.DAL.Entities.Vacancy.Category", null)
                        .WithMany("Vacancies")
                        .HasForeignKey("CategoryId");

                    b.HasOne("ICH.DAL.Entities.Vacancy.EmploymentType", "EmploymentType")
                        .WithMany("Vacancies")
                        .HasForeignKey("EmploymentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ICH.DAL.Entities.General.Location", "Location")
                        .WithMany("Vacancies")
                        .HasForeignKey("LocationId");

                    b.HasOne("ICH.DAL.Entities.User.User", "User")
                        .WithMany("Vacancies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ICH.DAL.Entities.Vacancy.WorkType", null)
                        .WithMany("Vacancies")
                        .HasForeignKey("WorkTypeId");

                    b.Navigation("EmploymentType");

                    b.Navigation("Location");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SpecialCategoryVacancy", b =>
                {
                    b.HasOne("ICH.DAL.Entities.Vacancy.SpecialCategory", null)
                        .WithMany()
                        .HasForeignKey("SpecialCategoriesSpecialCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ICH.DAL.Entities.Vacancy.Vacancy", null)
                        .WithMany()
                        .HasForeignKey("VacanciesVacancyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ICH.DAL.Entities.General.Location", b =>
                {
                    b.Navigation("UserInfos");

                    b.Navigation("Vacancies");
                });

            modelBuilder.Entity("ICH.DAL.Entities.User.User", b =>
                {
                    b.Navigation("UserInfo")
                        .IsRequired();

                    b.Navigation("Vacancies");
                });

            modelBuilder.Entity("ICH.DAL.Entities.User.UserInfo", b =>
                {
                    b.Navigation("CV")
                        .IsRequired();
                });

            modelBuilder.Entity("ICH.DAL.Entities.User.UserType", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ICH.DAL.Entities.Vacancy.Category", b =>
                {
                    b.Navigation("Vacancies");
                });

            modelBuilder.Entity("ICH.DAL.Entities.Vacancy.EmploymentType", b =>
                {
                    b.Navigation("Vacancies");
                });

            modelBuilder.Entity("ICH.DAL.Entities.Vacancy.WorkType", b =>
                {
                    b.Navigation("Vacancies");
                });
#pragma warning restore 612, 618
        }
    }
}
