﻿// <auto-generated />
using Mahdi_Sina_AP_Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mahdi_Sina_AP_Project.Migrations
{
    [DbContext(typeof(DataBase))]
    [Migration("20240703053936_DBM")]
    partial class DBM
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-preview.5.24306.3");

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

                    b.Property<string>("USERNAME")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("commentJson")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("complaintJson")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("orderlistjson")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("subscribtion")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Sina_Mahdi_RestaurantAP.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PASSWORD")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("USERNAME")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Sina_Mahdi_RestaurantAP.Restaurant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PASSWORD")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("USERNAME")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("canReserve")
                        .HasColumnType("INTEGER");

                    b.Property<string>("foodListJson")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("orderList")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("rate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("reserveList")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Restaurants");
                });
#pragma warning restore 612, 618
        }
    }
}
