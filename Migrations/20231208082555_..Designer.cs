﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ptm_store_service.Data;

namespace ptm_store_service.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231208082555_.")]
    partial class _
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ptm_store_service.Data.Addresses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Ward")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("ptm_store_service.Data.CartLines", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("VariantId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("VariantId")
                        .IsUnique();

                    b.ToTable("CartLines");
                });

            modelBuilder.Entity("ptm_store_service.Data.Carts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("ptm_store_service.Data.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ptm_store_service.Data.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("ptm_store_service.Data.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ptm_store_service.Data.Variants", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("SalePrice")
                        .HasColumnType("float");

                    b.Property<string>("SkuCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Variants");
                });

            modelBuilder.Entity("ptm_store_service.Data.Addresses", b =>
                {
                    b.HasOne("ptm_store_service.Data.Users", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ptm_store_service.Data.CartLines", b =>
                {
                    b.HasOne("ptm_store_service.Data.Carts", "Cart")
                        .WithMany("CartLines")
                        .HasForeignKey("CartId");

                    b.HasOne("ptm_store_service.Data.Variants", "Variants")
                        .WithOne("CartLines")
                        .HasForeignKey("ptm_store_service.Data.CartLines", "VariantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Variants");
                });

            modelBuilder.Entity("ptm_store_service.Data.Carts", b =>
                {
                    b.HasOne("ptm_store_service.Data.Users", "User")
                        .WithOne("Carts")
                        .HasForeignKey("ptm_store_service.Data.Carts", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ptm_store_service.Data.Products", b =>
                {
                    b.HasOne("ptm_store_service.Data.Categories", "Categories")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("ptm_store_service.Data.Variants", b =>
                {
                    b.HasOne("ptm_store_service.Data.Products", "Products")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ptm_store_service.Data.Carts", b =>
                {
                    b.Navigation("CartLines");
                });

            modelBuilder.Entity("ptm_store_service.Data.Categories", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ptm_store_service.Data.Products", b =>
                {
                    b.Navigation("Variants");
                });

            modelBuilder.Entity("ptm_store_service.Data.Users", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Carts");
                });

            modelBuilder.Entity("ptm_store_service.Data.Variants", b =>
                {
                    b.Navigation("CartLines");
                });
#pragma warning restore 612, 618
        }
    }
}
