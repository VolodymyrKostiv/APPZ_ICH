﻿// <auto-generated />
using System;
using ICH.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ICH.DAL.Migrations
{
    [DbContext(typeof(ICHDBContext))]
    [Migration("20231203064509_UserVacancy")]
    partial class UserVacancy
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("UserInfoId")
                        .HasColumnType("int");

                    b.Property<int>("UserTypeId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("UserInfoId");

                    b.HasIndex("UserTypeId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ICH.DAL.Entities.User.UserInfo", b =>
                {
                    b.Property<int>("UserInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserInfoId"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmploymentTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkTypeId")
                        .HasColumnType("int");

                    b.HasKey("UserInfoId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EmploymentTypeId");

                    b.HasIndex("LocationId");

                    b.HasIndex("WorkTypeId");

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

            modelBuilder.Entity("ICH.DAL.Entities.User.UserVacancies", b =>
                {
                    b.Property<int>("UserVacanaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserVacanaId"), 1L, 1);

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UserVacancyStatusId")
                        .HasColumnType("int");

                    b.Property<int?>("VacancyId")
                        .HasColumnType("int");

                    b.HasKey("UserVacanaId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserVacancyStatusId");

                    b.HasIndex("VacancyId");

                    b.ToTable("UserVacancies");
                });

            modelBuilder.Entity("ICH.DAL.Entities.User.UserVacancyStatus", b =>
                {
                    b.Property<int>("UserVacancyStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserVacancyStatusId"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserVacancyStatusId");

                    b.ToTable("UserVacancyStatus");
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

                    b.Property<int?>("EmploymentTypeId")
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

                    b.Property<int?>("VacancyStatusId")
                        .HasColumnType("int");

                    b.Property<int?>("WorkTypeId")
                        .HasColumnType("int");

                    b.HasKey("VacancyId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EmploymentTypeId");

                    b.HasIndex("LocationId");

                    b.HasIndex("UserId");

                    b.HasIndex("VacancyStatusId");

                    b.HasIndex("WorkTypeId");

                    b.ToTable("Vacancies");
                });

            modelBuilder.Entity("ICH.DAL.Entities.Vacancy.VacancyStatus", b =>
                {
                    b.Property<int>("VacancyStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VacancyStatusId"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VacancyStatusId");

                    b.ToTable("VacancyStatus");
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

            modelBuilder.Entity("SpecialCategoryUserInfo", b =>
                {
                    b.Property<int>("SpecialCategoriesSpecialCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("UserInfosUserInfoId")
                        .HasColumnType("int");

                    b.HasKey("SpecialCategoriesSpecialCategoryId", "UserInfosUserInfoId");

                    b.HasIndex("UserInfosUserInfoId");

                    b.ToTable("SpecialCategoryUserInfo");
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

            modelBuilder.Entity("ICH.DAL.Entities.User.User", b =>
                {
                    b.HasOne("ICH.DAL.Entities.User.UserInfo", "UserInfo")
                        .WithMany("Users")
                        .HasForeignKey("UserInfoId");

                    b.HasOne("ICH.DAL.Entities.User.UserType", "UserType")
                        .WithMany("Users")
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserInfo");

                    b.Navigation("UserType");
                });

            modelBuilder.Entity("ICH.DAL.Entities.User.UserInfo", b =>
                {
                    b.HasOne("ICH.DAL.Entities.Vacancy.Category", "Category")
                        .WithMany("UserInfos")
                        .HasForeignKey("CategoryId");

                    b.HasOne("ICH.DAL.Entities.Vacancy.EmploymentType", "EmploymentType")
                        .WithMany("UserInfos")
                        .HasForeignKey("EmploymentTypeId");

                    b.HasOne("ICH.DAL.Entities.General.Location", "Location")
                        .WithMany("UserInfos")
                        .HasForeignKey("LocationId");

                    b.HasOne("ICH.DAL.Entities.Vacancy.WorkType", "WorkType")
                        .WithMany("UserInfos")
                        .HasForeignKey("WorkTypeId");

                    b.Navigation("Category");

                    b.Navigation("EmploymentType");

                    b.Navigation("Location");

                    b.Navigation("WorkType");
                });

            modelBuilder.Entity("ICH.DAL.Entities.User.UserVacancies", b =>
                {
                    b.HasOne("ICH.DAL.Entities.User.User", "User")
                        .WithMany("UserVacancies")
                        .HasForeignKey("UserId");

                    b.HasOne("ICH.DAL.Entities.User.UserVacancyStatus", "UserVacancyStatus")
                        .WithMany("Vacancies")
                        .HasForeignKey("UserVacancyStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ICH.DAL.Entities.Vacancy.Vacancy", "Vacancy")
                        .WithMany("UserVacancies")
                        .HasForeignKey("VacancyId");

                    b.Navigation("User");

                    b.Navigation("UserVacancyStatus");

                    b.Navigation("Vacancy");
                });

            modelBuilder.Entity("ICH.DAL.Entities.Vacancy.Vacancy", b =>
                {
                    b.HasOne("ICH.DAL.Entities.Vacancy.Category", "Category")
                        .WithMany("Vacancies")
                        .HasForeignKey("CategoryId");

                    b.HasOne("ICH.DAL.Entities.Vacancy.EmploymentType", "EmploymentType")
                        .WithMany("Vacancies")
                        .HasForeignKey("EmploymentTypeId");

                    b.HasOne("ICH.DAL.Entities.General.Location", "Location")
                        .WithMany("Vacancies")
                        .HasForeignKey("LocationId");

                    b.HasOne("ICH.DAL.Entities.User.User", "User")
                        .WithMany("Vacancies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ICH.DAL.Entities.Vacancy.VacancyStatus", "VacancyStatus")
                        .WithMany("Vacancies")
                        .HasForeignKey("VacancyStatusId");

                    b.HasOne("ICH.DAL.Entities.Vacancy.WorkType", "WorkType")
                        .WithMany("Vacancies")
                        .HasForeignKey("WorkTypeId");

                    b.Navigation("Category");

                    b.Navigation("EmploymentType");

                    b.Navigation("Location");

                    b.Navigation("User");

                    b.Navigation("VacancyStatus");

                    b.Navigation("WorkType");
                });

            modelBuilder.Entity("SpecialCategoryUserInfo", b =>
                {
                    b.HasOne("ICH.DAL.Entities.Vacancy.SpecialCategory", null)
                        .WithMany()
                        .HasForeignKey("SpecialCategoriesSpecialCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ICH.DAL.Entities.User.UserInfo", null)
                        .WithMany()
                        .HasForeignKey("UserInfosUserInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.Navigation("UserVacancies");

                    b.Navigation("Vacancies");
                });

            modelBuilder.Entity("ICH.DAL.Entities.User.UserInfo", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ICH.DAL.Entities.User.UserType", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ICH.DAL.Entities.User.UserVacancyStatus", b =>
                {
                    b.Navigation("Vacancies");
                });

            modelBuilder.Entity("ICH.DAL.Entities.Vacancy.Category", b =>
                {
                    b.Navigation("UserInfos");

                    b.Navigation("Vacancies");
                });

            modelBuilder.Entity("ICH.DAL.Entities.Vacancy.EmploymentType", b =>
                {
                    b.Navigation("UserInfos");

                    b.Navigation("Vacancies");
                });

            modelBuilder.Entity("ICH.DAL.Entities.Vacancy.Vacancy", b =>
                {
                    b.Navigation("UserVacancies");
                });

            modelBuilder.Entity("ICH.DAL.Entities.Vacancy.VacancyStatus", b =>
                {
                    b.Navigation("Vacancies");
                });

            modelBuilder.Entity("ICH.DAL.Entities.Vacancy.WorkType", b =>
                {
                    b.Navigation("UserInfos");

                    b.Navigation("Vacancies");
                });
#pragma warning restore 612, 618
        }
    }
}
