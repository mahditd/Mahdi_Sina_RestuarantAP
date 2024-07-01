﻿// <auto-generated />
using System;
using Mahdi_Sina_AP_Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mahdi_Sina_AP_Project.Migrations
{
    [DbContext(typeof(DataBase))]
    [Migration("20240701062756_DBM")]
    partial class DBM
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-preview.5.24306.3");

            modelBuilder.Entity("Mahdi_Sina_AP_Project.Comment", b =>
                {
                    b.Property<bool>("ISEDITED")
                        .HasColumnType("INTEGER");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("Mahdi_Sina_AP_Project.Complaint", b =>
                {
                    b.Property<bool>("ISCHECKED")
                        .HasColumnType("INTEGER");

                    b.ToTable("Complaint");
                });

            modelBuilder.Entity("Mahdi_Sina_AP_Project.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EMAIL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PASSWORD")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PHONENUMBER")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("POSTALCODE")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Mahdi_Sina_AP_Project.Reserve", b =>
                {
                    b.Property<DateTime>("RESERVETIME")
                        .HasColumnType("TEXT");

                    b.ToTable("Reserve");
                });

            modelBuilder.Entity("Sina_Mahdi_RestaurantAP.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PASSWORD")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("admins");
                });

            modelBuilder.Entity("Sina_Mahdi_RestaurantAP.Food", b =>
                {
                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<int>("FOODCOUNT")
                        .HasColumnType("INTEGER");

                    b.Property<string>("IMAGEPATH")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("INGREDIENTS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<float>("RATE")
                        .HasColumnType("REAL");

                    b.ToTable("Food");

                    b.HasDiscriminator().HasValue("Food");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Sina_Mahdi_RestaurantAP.Restaurant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ADDRESS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("CANRESERVE")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PASSWORD")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RATE")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("Sina_Mahdi_RestaurantAP.Order", b =>
                {
                    b.HasBaseType("Sina_Mahdi_RestaurantAP.Food");

                    b.Property<int?>("CustomerID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("METHOD")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RESTAURANTID")
                        .HasColumnType("INTEGER");

                    b.HasIndex("CustomerID");

                    b.HasIndex("RESTAURANTID");

                    b.HasDiscriminator().HasValue("Order");
                });

            modelBuilder.Entity("Sina_Mahdi_RestaurantAP.Order", b =>
                {
                    b.HasOne("Mahdi_Sina_AP_Project.Customer", null)
                        .WithMany("OrderList")
                        .HasForeignKey("CustomerID");

                    b.HasOne("Sina_Mahdi_RestaurantAP.Restaurant", "RESTAURANT")
                        .WithMany("ORDERLIST")
                        .HasForeignKey("RESTAURANTID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RESTAURANT");
                });

            modelBuilder.Entity("Mahdi_Sina_AP_Project.Customer", b =>
                {
                    b.Navigation("OrderList");
                });

            modelBuilder.Entity("Sina_Mahdi_RestaurantAP.Restaurant", b =>
                {
                    b.Navigation("ORDERLIST");
                });
#pragma warning restore 612, 618
        }
    }
}