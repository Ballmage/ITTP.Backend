﻿// <auto-generated />
using System;
using ITTP.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ITTP.Persistance.Migrations
{
    [DbContext(typeof(ITTPDbContext))]
    [Migration("20230528143630_OneMigration")]
    partial class OneMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ITTP.Domain.User", b =>
                {
                    b.Property<string>("Guid")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Admin")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RevokedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("RevokedOn")
                        .HasColumnType("datetime");

                    b.HasKey("Guid");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Guid = "7b1bb49b-fe35-4747-93d4-cd3da1131a6f",
                            Admin = true,
                            Birthday = new DateTime(2003, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "database",
                            CreatedOn = new DateTime(2023, 5, 28, 17, 36, 29, 464, DateTimeKind.Local).AddTicks(7154),
                            Gender = 1,
                            Login = "admin",
                            Name = "Николай",
                            Password = "asd123"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}