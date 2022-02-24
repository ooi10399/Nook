﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NookAppointmentAPI.Models;

namespace NookAppointmentAPI.Migrations
{
    [DbContext(typeof(AppointmentContext))]
    [Migration("20220224140118_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NookAppointmentAPI.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("Fees")
                        .HasColumnType("float");

                    b.Property<DateTime>("PlacementDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RenteeUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RenterUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("AppointmentId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            AppointmentId = 101,
                            EndDateTime = new DateTime(2022, 12, 31, 15, 15, 23, 0, DateTimeKind.Unspecified),
                            Fees = 22.300000000000001,
                            PlacementDate = new DateTime(2022, 10, 31, 15, 15, 0, 0, DateTimeKind.Unspecified),
                            RenteeUserName = "101",
                            RenterUserName = "102",
                            StartDateTime = new DateTime(2021, 12, 31, 14, 50, 44, 0, DateTimeKind.Unspecified),
                            Status = "Pending",
                            UpdateDate = new DateTime(2022, 10, 31, 15, 15, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AppointmentId = 102,
                            EndDateTime = new DateTime(2022, 1, 14, 13, 10, 44, 0, DateTimeKind.Unspecified),
                            Fees = 43.0,
                            PlacementDate = new DateTime(2022, 1, 13, 15, 15, 0, 0, DateTimeKind.Unspecified),
                            RenteeUserName = "102",
                            RenterUserName = "105",
                            StartDateTime = new DateTime(2022, 1, 14, 12, 42, 23, 0, DateTimeKind.Unspecified),
                            Status = "Completed",
                            UpdateDate = new DateTime(2022, 1, 14, 15, 15, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AppointmentId = 103,
                            EndDateTime = new DateTime(2022, 1, 30, 19, 30, 53, 0, DateTimeKind.Unspecified),
                            Fees = 23.5,
                            PlacementDate = new DateTime(2022, 1, 10, 15, 15, 0, 0, DateTimeKind.Unspecified),
                            RenteeUserName = "103",
                            RenterUserName = "103",
                            StartDateTime = new DateTime(2022, 1, 30, 17, 46, 53, 0, DateTimeKind.Unspecified),
                            Status = "Completed",
                            UpdateDate = new DateTime(2022, 1, 31, 15, 15, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
