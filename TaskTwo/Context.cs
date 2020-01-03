﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Graph;
using System;
using TaskTwo.Models;
namespace TaskTwo
{
    public class Context : DbContext
    {
        public DbSet<MasterPage> masterPages { get; set; }
        public DbSet<TransactionPage> transactionPages { get; set; }
        public Context()
        {
        }
        public Context(DbContextOptions<Context> options)
         : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            AppSettigns appSettigns = new AppSettigns();
            Settings.settings(appSettigns);
            options.UseSqlServer(appSettigns.ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            DateTime myDate = new DateTime(1, 10, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime myDate2 = new DateTime(1, 12, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime myDate3 = new DateTime(1, 11, 1, 0, 0, 0, DateTimeKind.Utc);

            //One
            base.OnModelCreating(builder);
            builder.Entity<MasterPage>().HasData(
     new MasterPage() { MasterPageID = 1, LastDayProfit = 100, LastDayQtySold = 110000 });

            builder.Entity<TransactionPage>().HasData(
new TransactionPage() { TransactionID = 1, MasterPageID = 1, Asin = 0010102, Price = 10000, LastUpdateDate = myDate, ProductName = "Pizza", LastDayQtySold = 100, LastDayProfit = 110000 });
            //Two
            builder.Entity<MasterPage>().HasData(
     new MasterPage() { MasterPageID = 2, LastDayProfit = 200, LastDayQtySold = 220000 });

            builder.Entity<TransactionPage>().HasData(
new TransactionPage() { TransactionID = 2, MasterPageID = 2, Asin = 200001, Price = 100, LastUpdateDate = myDate2, ProductName = "Sauce", LastDayQtySold = 200, LastDayProfit = 220000 });
            //Three
            builder.Entity<MasterPage>().HasData(
     new MasterPage() { MasterPageID = 3, LastDayProfit = 3000, LastDayQtySold = 50 });

            builder.Entity<TransactionPage>().HasData(
new TransactionPage() { TransactionID = 3, MasterPageID = 3, Asin = 010102, Price = 1000, LastUpdateDate = myDate3, ProductName = "Tamales", LastDayQtySold = 50, LastDayProfit = 30000 });
        }
    }
}
