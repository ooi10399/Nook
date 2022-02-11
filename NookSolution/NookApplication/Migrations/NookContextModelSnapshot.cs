﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NookApplication.Models;

namespace NookApplication.Migrations
{
    [DbContext(typeof(NookContext))]
    partial class NookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InterestRentee", b =>
                {
                    b.Property<int>("InterestsIntId")
                        .HasColumnType("int");

                    b.Property<int>("RenteesUserId")
                        .HasColumnType("int");

                    b.HasKey("InterestsIntId", "RenteesUserId");

                    b.HasIndex("RenteesUserId");

                    b.ToTable("InterestRentee");
                });

            modelBuilder.Entity("NookApplication.Models.Interest", b =>
                {
                    b.Property<int>("IntId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IntName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IntId");

                    b.ToTable("Interests");

                    b.HasData(
                        new
                        {
                            IntId = 1,
                            IntName = "Cafe-hopping"
                        },
                        new
                        {
                            IntId = 2,
                            IntName = "Pottery-making"
                        });
                });

            modelBuilder.Entity("NookApplication.Models.Rentee", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Fee")
                        .HasColumnType("float");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Rentees");

                    b.HasData(
                        new
                        {
                            UserId = 101,
                            About = "Call me queen.",
                            DOB = new DateTime(1974, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "elicam@email.com",
                            Fee = 20.0,
                            FullName = "Elizabeth Cambridge",
                            Gender = false,
                            NickName = "Eli",
                            Password = "elipass"
                        },
                        new
                        {
                            UserId = 102,
                            About = "Call me king.",
                            DOB = new DateTime(1974, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "philc@email.com",
                            Fee = 20.0,
                            FullName = "Phillip Cambridge",
                            Gender = true,
                            NickName = "Phil",
                            Password = "philpass"
                        });
                });

            modelBuilder.Entity("NookApplication.Models.Renter", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Renters");

                    b.HasData(
                        new
                        {
                            UserId = 101,
                            About = "Will call you queen.",
                            DOB = new DateTime(1974, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "johndoe@email.com",
                            FullName = "John Doe",
                            Gender = true,
                            NickName = "John",
                            Password = "johnpass"
                        },
                        new
                        {
                            UserId = 102,
                            About = "Will call you king.",
                            DOB = new DateTime(1974, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "janedoe@email.com",
                            FullName = "Jane Doe",
                            Gender = false,
                            NickName = "Jane",
                            Password = "janepass"
                        });
                });

            modelBuilder.Entity("InterestRentee", b =>
                {
                    b.HasOne("NookApplication.Models.Interest", null)
                        .WithMany()
                        .HasForeignKey("InterestsIntId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NookApplication.Models.Rentee", null)
                        .WithMany()
                        .HasForeignKey("RenteesUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}