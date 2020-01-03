﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskTwo.Data;

namespace TaskTwo.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskTwo.Models.AmazonMaster", b =>
                {
                    b.Property<int>("MasterPageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LastDayProfit")
                        .HasColumnType("int");

                    b.Property<int>("LastDayQtySold")
                        .HasColumnType("int");

                    b.Property<int>("TotalProducts")
                        .HasColumnType("int");

                    b.HasKey("MasterPageID");

                    b.ToTable("masterPages");

                    b.HasData(
                        new
                        {
                            MasterPageID = 1,
                            LastDayProfit = 100,
                            LastDayQtySold = 110000,
                            TotalProducts = 14
                        },
                        new
                        {
                            MasterPageID = 2,
                            LastDayProfit = 200,
                            LastDayQtySold = 220000,
                            TotalProducts = 55
                        },
                        new
                        {
                            MasterPageID = 3,
                            LastDayProfit = 3000,
                            LastDayQtySold = 50,
                            TotalProducts = 33
                        });
                });

            modelBuilder.Entity("TaskTwo.Models.AmazonTransaction", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Asin")
                        .HasColumnType("int");

                    b.Property<int>("LastDayProfit")
                        .HasColumnType("int");

                    b.Property<int>("LastDayQtySold")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MasterPageID")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransactionID");

                    b.ToTable("transactionPages");

                    b.HasData(
                        new
                        {
                            TransactionID = 1,
                            Asin = 10102,
                            LastDayProfit = 110000,
                            LastDayQtySold = 100,
                            LastUpdateDate = new DateTime(1, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            MasterPageID = 1,
                            Price = 10000,
                            ProductName = "Pizza"
                        },
                        new
                        {
                            TransactionID = 2,
                            Asin = 200001,
                            LastDayProfit = 220000,
                            LastDayQtySold = 200,
                            LastUpdateDate = new DateTime(1, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            MasterPageID = 2,
                            Price = 100,
                            ProductName = "Sauce"
                        },
                        new
                        {
                            TransactionID = 3,
                            Asin = 10102,
                            LastDayProfit = 30000,
                            LastDayQtySold = 50,
                            LastUpdateDate = new DateTime(1, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            MasterPageID = 3,
                            Price = 1000,
                            ProductName = "Tamales"
                        });
                });

            modelBuilder.Entity("TaskTwo.Models.EbayMaster", b =>
                {
                    b.Property<int>("MasterPageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LastDayProfit")
                        .HasColumnType("int");

                    b.Property<int>("LastDayQtySold")
                        .HasColumnType("int");

                    b.Property<int>("TotalProducts")
                        .HasColumnType("int");

                    b.HasKey("MasterPageID");

                    b.ToTable("ebayMasters");

                    b.HasData(
                        new
                        {
                            MasterPageID = 1,
                            LastDayProfit = 100,
                            LastDayQtySold = 110000,
                            TotalProducts = 244
                        },
                        new
                        {
                            MasterPageID = 2,
                            LastDayProfit = 200,
                            LastDayQtySold = 220000,
                            TotalProducts = 2
                        },
                        new
                        {
                            MasterPageID = 3,
                            LastDayProfit = 3000,
                            LastDayQtySold = 50,
                            TotalProducts = 233
                        });
                });

            modelBuilder.Entity("TaskTwo.Models.EbayTransactions", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Asin")
                        .HasColumnType("int");

                    b.Property<int>("LastDayProfit")
                        .HasColumnType("int");

                    b.Property<int>("LastDayQtySold")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MasterPageID")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransactionID");

                    b.ToTable("ebayTransactions");

                    b.HasData(
                        new
                        {
                            TransactionID = 1,
                            Asin = 770010102,
                            LastDayProfit = 110000,
                            LastDayQtySold = 100,
                            LastUpdateDate = new DateTime(1, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            MasterPageID = 1,
                            Price = 10,
                            ProductName = "Pasta"
                        },
                        new
                        {
                            TransactionID = 2,
                            Asin = 66200001,
                            LastDayProfit = 220000,
                            LastDayQtySold = 200,
                            LastUpdateDate = new DateTime(1, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            MasterPageID = 2,
                            Price = 1,
                            ProductName = "Bread"
                        },
                        new
                        {
                            TransactionID = 3,
                            Asin = 555010102,
                            LastDayProfit = 30000,
                            LastDayQtySold = 50,
                            LastUpdateDate = new DateTime(1, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            MasterPageID = 3,
                            Price = 1000,
                            ProductName = "Tomato"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
