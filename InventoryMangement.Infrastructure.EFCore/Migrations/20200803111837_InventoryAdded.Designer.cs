﻿// <auto-generated />
using System;
using InventoryMangement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InventoryMangement.Infrastructure.EFCore.Migrations
{
    [DbContext(typeof(InventoryContext))]
    [Migration("20200803111837_InventoryAdded")]
    partial class InventoryAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.6.20312.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InventoryManagement.Domain.InventoryAgg.Inventory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("InventoryManagement.Domain.InventoryAgg.Inventory", b =>
                {
                    b.OwnsMany("InventoryManagement.Domain.InventoryAgg.InventoryOperation", "Operations", b1 =>
                        {
                            b1.Property<long>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<long>("Count")
                                .HasColumnType("bigint");

                            b1.Property<long>("CurrentCount")
                                .HasColumnType("bigint");

                            b1.Property<string>("Description")
                                .HasColumnType("nvarchar(1000)")
                                .HasMaxLength(1000);

                            b1.Property<long>("InventoryId")
                                .HasColumnType("bigint");

                            b1.Property<bool>("Operation")
                                .HasColumnType("bit");

                            b1.Property<DateTime>("OperationDate")
                                .HasColumnType("datetime2");

                            b1.Property<long>("OperatorId")
                                .HasColumnType("bigint");

                            b1.Property<long>("OrderId")
                                .HasColumnType("bigint");

                            b1.HasKey("Id");

                            b1.HasIndex("InventoryId");

                            b1.ToTable("Operations");

                            b1.WithOwner("Inventory")
                                .HasForeignKey("InventoryId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
