﻿// <auto-generated />
using System;
using Diagnostic_Center_Bill_Management_System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Diagnostic_Center_Bill_Management_System.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Diagnostic_Center_Bill_Management_System.Models.TestRequest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bill_Number")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("MobileNo")
                        .HasColumnType("bigint");

                    b.Property<string>("PatientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("PayAmount")
                        .HasColumnType("real");

                    b.Property<float?>("ReqTestFee")
                        .HasColumnType("real");

                    b.Property<long?>("Slno")
                        .HasColumnType("bigint");

                    b.Property<long?>("TestSetupId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TestSetupId");

                    b.ToTable("TestRequests");
                });

            modelBuilder.Entity("Diagnostic_Center_Bill_Management_System.Models.TestSetup", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("Slno")
                        .HasColumnType("bigint");

                    b.Property<float?>("TestFee")
                        .HasColumnType("real");

                    b.Property<string>("TestName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<long?>("TestTypeSetupId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TestTypeSetupId");

                    b.ToTable("TestSetups");
                });

            modelBuilder.Entity("Diagnostic_Center_Bill_Management_System.Models.TestTypeSetup", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("Slno")
                        .HasColumnType("bigint");

                    b.Property<string>("TestType_Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("TestTypeSetups");
                });

            modelBuilder.Entity("Diagnostic_Center_Bill_Management_System.Models.TestRequest", b =>
                {
                    b.HasOne("Diagnostic_Center_Bill_Management_System.Models.TestSetup", "TestSetup")
                        .WithMany("TestRequest")
                        .HasForeignKey("TestSetupId");

                    b.Navigation("TestSetup");
                });

            modelBuilder.Entity("Diagnostic_Center_Bill_Management_System.Models.TestSetup", b =>
                {
                    b.HasOne("Diagnostic_Center_Bill_Management_System.Models.TestTypeSetup", "TestTypeSetup")
                        .WithMany("TestSetup")
                        .HasForeignKey("TestTypeSetupId");

                    b.Navigation("TestTypeSetup");
                });

            modelBuilder.Entity("Diagnostic_Center_Bill_Management_System.Models.TestSetup", b =>
                {
                    b.Navigation("TestRequest");
                });

            modelBuilder.Entity("Diagnostic_Center_Bill_Management_System.Models.TestTypeSetup", b =>
                {
                    b.Navigation("TestSetup");
                });
#pragma warning restore 612, 618
        }
    }
}
