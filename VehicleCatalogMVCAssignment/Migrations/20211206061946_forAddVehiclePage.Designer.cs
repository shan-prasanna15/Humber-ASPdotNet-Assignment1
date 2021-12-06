﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleCatalogMVCAssignment.Models;

namespace VehicleCatalogMVCAssignment.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20211206061946_forAddVehiclePage")]
    partial class forAddVehiclePage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VehicleCatalogMVCAssignment.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VehicleID")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCartItemID");

                    b.HasIndex("VehicleID");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("VehicleCatalogMVCAssignment.Models.Vehicle", b =>
                {
                    b.Property<int>("VehicleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAutomaticTransmission")
                        .HasColumnType("bit");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModelYear")
                        .HasColumnType("int");

                    b.Property<int?>("VehicleClassVehicleCategoryID")
                        .HasColumnType("int");

                    b.Property<int>("VinNo")
                        .HasColumnType("int");

                    b.HasKey("VehicleID");

                    b.HasIndex("VehicleClassVehicleCategoryID");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("VehicleCatalogMVCAssignment.Models.VehicleCategory", b =>
                {
                    b.Property<int>("VehicleCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleCategoryID");

                    b.ToTable("VehicleCategories");
                });

            modelBuilder.Entity("VehicleCatalogMVCAssignment.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("VehicleCatalogMVCAssignment.Models.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleID");
                });

            modelBuilder.Entity("VehicleCatalogMVCAssignment.Models.Vehicle", b =>
                {
                    b.HasOne("VehicleCatalogMVCAssignment.Models.VehicleCategory", "VehicleClass")
                        .WithMany("Vehicles")
                        .HasForeignKey("VehicleClassVehicleCategoryID");
                });
#pragma warning restore 612, 618
        }
    }
}
