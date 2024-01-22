﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test_NANY.Data;

#nullable disable

namespace Test_NANY.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Test_NANY.Data.Models.ChildProfile", b =>
                {
                    b.Property<int>("Child_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Child_Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Child_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Religion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Child_Id");

                    b.ToTable("ChildProfile");
                });

            modelBuilder.Entity("Test_NANY.Data.Models.NanyProfile", b =>
                {
                    b.Property<int>("Nany_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Nany_Id"), 1L, 1);

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("NAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAge")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nany_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Religion")
                        .HasColumnType("int");

                    b.HasKey("Nany_Id");

                    b.ToTable("NanyProfile");
                });

            modelBuilder.Entity("Test_NANY.Data.Models.NanySchedule", b =>
                {
                    b.Property<int>("Schedule_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Schedule_Id"), 1L, 1);

                    b.Property<int>("Child_Id")
                        .HasColumnType("int");

                    b.Property<int>("Nany_Id")
                        .HasColumnType("int");

                    b.Property<int>("Shift_Id")
                        .HasColumnType("int");

                    b.HasKey("Schedule_Id");

                    b.ToTable("NanySchedule");
                });

            modelBuilder.Entity("Test_NANY.Data.Models.Registration", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RePass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Registration");
                });

            modelBuilder.Entity("Test_NANY.Data.Models.Shift", b =>
                {
                    b.Property<int>("Shift_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Shift_Id"), 1L, 1);

                    b.Property<DateTime?>("End_datetime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Start_datetime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("shift_No")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shift_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Shift_Id");

                    b.ToTable("Shift");
                });
#pragma warning restore 612, 618
        }
    }
}
