﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimesheetsApp.Entities;

#nullable disable

namespace TimesheetsApp.Migrations
{
    [DbContext(typeof(TimesheetsDbContext))]
    [Migration("20221018223447_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TimesheetsApp.Entities.Timesheet", b =>
                {
                    b.Property<int>("TimesheetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TimesheetId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TimesheetId");

                    b.ToTable("Timesheets");

                    b.HasData(
                        new
                        {
                            TimesheetId = 1,
                            Date = new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Hours = 20,
                            ProjectName = "New Build"
                        },
                        new
                        {
                            TimesheetId = 2,
                            Date = new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Hours = 9,
                            ProjectName = "Bug Fix"
                        },
                        new
                        {
                            TimesheetId = 3,
                            Date = new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Hours = 20,
                            ProjectName = "New Build"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
