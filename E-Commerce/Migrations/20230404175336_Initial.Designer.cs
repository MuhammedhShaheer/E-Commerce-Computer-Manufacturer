﻿// <auto-generated />
using System;
using E_Commerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_Commerce.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230404175336_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.2.23128.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("E_Commerce.Models.ComputerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeriesPictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Computer");
                });

            modelBuilder.Entity("E_Commerce.Models.ComputerModelsModel", b =>
                {
                    b.Property<int>("ComputerCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ComputerSeriesId")
                        .HasColumnType("int");

                    b.Property<int>("ComputerModelId")
                        .HasColumnType("int");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductCategoryModelId")
                        .HasColumnType("int");

                    b.HasKey("ComputerCategoryId", "ComputerSeriesId", "ComputerModelId", "OrderStatusId", "CustomerId");

                    b.HasIndex("ComputerModelId");

                    b.HasIndex("ComputerSeriesId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductCategoryModelId");

                    b.ToTable("ComputerModels");
                });

            modelBuilder.Entity("E_Commerce.Models.ComputerSeriesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ComputerCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ComputerSeries");
                });

            modelBuilder.Entity("E_Commerce.Models.ConfigurationModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ComputerModelId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Configuration");
                });

            modelBuilder.Entity("E_Commerce.Models.CustomerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Password")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("E_Commerce.Models.OrderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BillingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ComputerModelId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShippingMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("E_Commerce.Models.OrderStatusModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("E_Commerce.Models.ProductCategoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ComputerCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ComputerModelId")
                        .HasColumnType("int");

                    b.Property<int>("ComputerSeriesId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<int>("ProductCategory")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComputerCategoryId");

                    b.HasIndex("ComputerModelId");

                    b.HasIndex("ComputerSeriesId");

                    b.HasIndex("CustomerId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("E_Commerce.Models.ComputerModelsModel", b =>
                {
                    b.HasOne("E_Commerce.Models.ComputerSeriesModel", "ComputerSeries")
                        .WithMany("ComputerModelsModel")
                        .HasForeignKey("ComputerCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce.Models.ConfigurationModel", "Configuration")
                        .WithMany("ComputerModelsModel")
                        .HasForeignKey("ComputerModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce.Models.ComputerModel", "Computer")
                        .WithMany("ComputerModelsModel")
                        .HasForeignKey("ComputerSeriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce.Models.OrderModel", "Order")
                        .WithMany("ComputerModelsModel")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce.Models.ProductCategoryModel", null)
                        .WithMany("ComputerModels")
                        .HasForeignKey("ProductCategoryModelId");

                    b.Navigation("Computer");

                    b.Navigation("ComputerSeries");

                    b.Navigation("Configuration");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("E_Commerce.Models.ProductCategoryModel", b =>
                {
                    b.HasOne("E_Commerce.Models.ComputerSeriesModel", "ComputerSeries")
                        .WithMany()
                        .HasForeignKey("ComputerCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce.Models.ConfigurationModel", "ConfigurationModel")
                        .WithMany()
                        .HasForeignKey("ComputerModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce.Models.ComputerModel", "Computer")
                        .WithMany()
                        .HasForeignKey("ComputerSeriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce.Models.OrderModel", "Order")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Computer");

                    b.Navigation("ComputerSeries");

                    b.Navigation("ConfigurationModel");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("E_Commerce.Models.ComputerModel", b =>
                {
                    b.Navigation("ComputerModelsModel");
                });

            modelBuilder.Entity("E_Commerce.Models.ComputerSeriesModel", b =>
                {
                    b.Navigation("ComputerModelsModel");
                });

            modelBuilder.Entity("E_Commerce.Models.ConfigurationModel", b =>
                {
                    b.Navigation("ComputerModelsModel");
                });

            modelBuilder.Entity("E_Commerce.Models.OrderModel", b =>
                {
                    b.Navigation("ComputerModelsModel");
                });

            modelBuilder.Entity("E_Commerce.Models.ProductCategoryModel", b =>
                {
                    b.Navigation("ComputerModels");
                });
#pragma warning restore 612, 618
        }
    }
}
