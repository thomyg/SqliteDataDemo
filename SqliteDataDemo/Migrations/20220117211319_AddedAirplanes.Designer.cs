﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SqliteDataDemo.Data;

#nullable disable

namespace SqliteDataDemo.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220117211319_AddedAirplanes")]
    partial class AddedAirplanes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("SqliteDataDemo.Data.Airplane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EngineCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HomeAirPort")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Reach")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Airplanes");
                });

            modelBuilder.Entity("SqliteDataDemo.Data.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Built")
                        .HasColumnType("TEXT");

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PlateNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Built = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Colour = "Black",
                            Name = "Black Panter",
                            PlateNumber = "G-BP-1"
                        },
                        new
                        {
                            Id = 2,
                            Built = new DateTime(1990, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Colour = "Red",
                            Name = "Red Velvet",
                            PlateNumber = "G-RV-1"
                        });
                });

            modelBuilder.Entity("SqliteDataDemo.Data.Ship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Ships");
                });
#pragma warning restore 612, 618
        }
    }
}