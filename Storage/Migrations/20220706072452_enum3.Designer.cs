﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Storage.Data;

namespace Storage.Migrations
{
    [DbContext(typeof(StorageContext))]
    [Migration("20220706072452_enum3")]
    partial class enum3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Storage.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("Orderdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Shelf")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 0,
                            Count = 12,
                            Description = "Krocket-spel för högst 4 personer.",
                            Name = "Krocket-spel",
                            Orderdate = new DateTime(2022, 7, 6, 9, 24, 51, 722, DateTimeKind.Local).AddTicks(4220),
                            Price = 230,
                            Shelf = "R1:H1:V1"
                        },
                        new
                        {
                            Id = 2,
                            Category = 0,
                            Count = 4,
                            Description = "Extra klubba till krocket-spel.",
                            Name = "Extra Krocket-klubba",
                            Orderdate = new DateTime(2022, 7, 6, 9, 24, 51, 726, DateTimeKind.Local).AddTicks(1392),
                            Price = 110,
                            Shelf = "R1:H1:V2"
                        },
                        new
                        {
                            Id = 3,
                            Category = 0,
                            Count = 7,
                            Description = "Extra klot till krocket-spel.",
                            Name = "Extra Krocket-klot",
                            Orderdate = new DateTime(2022, 7, 6, 9, 24, 51, 726, DateTimeKind.Local).AddTicks(1428),
                            Price = 72,
                            Shelf = "R1:H1:V3"
                        },
                        new
                        {
                            Id = 4,
                            Category = 2,
                            Count = 25,
                            Description = "Plåster för tårna.",
                            Name = "Tå-plåster",
                            Orderdate = new DateTime(2022, 7, 6, 9, 24, 51, 726, DateTimeKind.Local).AddTicks(1434),
                            Price = 23,
                            Shelf = "R1:H2:V1"
                        },
                        new
                        {
                            Id = 5,
                            Category = 1,
                            Count = 19,
                            Description = "Hjälm",
                            Name = "Hjälm",
                            Orderdate = new DateTime(2022, 7, 6, 9, 24, 51, 726, DateTimeKind.Local).AddTicks(1437),
                            Price = 249,
                            Shelf = "R1:H3:V1"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
