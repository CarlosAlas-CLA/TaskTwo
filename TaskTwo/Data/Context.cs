using Microsoft.EntityFrameworkCore;
using Microsoft.Graph;
using System;
using TaskTwo.Models;
using TaskTwo.Services;

namespace TaskTwo.Data
{
    public class Context : DbContext
    {
        public DbSet<AmazonMaster> masterPages { get; set; }
        public DbSet<AmazonTransaction> transactionPages { get; set; }
        public DbSet<EbayMaster> ebayMasters { get; set; }
        public DbSet<EbayTransactions> ebayTransactions { get; set; }
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
            builder.Entity<AmazonMaster>().HasData(
     new AmazonMaster() { MasterPageID = 1, LastDayProfit = 100, LastDayQtySold = 110000 });

            builder.Entity<AmazonTransaction>().HasData(
new AmazonTransaction() { TransactionID = 1, MasterPageID = 1, Asin = 0010102, Price = 10000, LastUpdateDate = myDate, ProductName = "Pizza", LastDayQtySold = 100, LastDayProfit = 110000 });
            //Two
            builder.Entity<AmazonMaster>().HasData(
     new AmazonMaster() { MasterPageID = 2, LastDayProfit = 200, LastDayQtySold = 220000 });

            builder.Entity<AmazonTransaction>().HasData(
new AmazonTransaction() { TransactionID = 2, MasterPageID = 2, Asin = 200001, Price = 100, LastUpdateDate = myDate2, ProductName = "Sauce", LastDayQtySold = 200, LastDayProfit = 220000 });
            //Three
            builder.Entity<AmazonMaster>().HasData(
     new AmazonMaster() { MasterPageID = 3, LastDayProfit = 3000, LastDayQtySold = 50 });

            builder.Entity<AmazonTransaction>().HasData(
new AmazonTransaction() { TransactionID = 3, MasterPageID = 3, Asin = 010102, Price = 1000, LastUpdateDate = myDate3, ProductName = "Tamales", LastDayQtySold = 50, LastDayProfit = 30000 });
            //One
            base.OnModelCreating(builder);
            builder.Entity<EbayMaster>().HasData(
     new EbayMaster() { MasterPageID = 1, LastDayProfit = 100, LastDayQtySold = 110000 });

            builder.Entity<EbayTransactions>().HasData(
new EbayTransactions() { TransactionID = 1, MasterPageID = 1, Asin = 770010102, Price = 10, LastUpdateDate = myDate, ProductName = "Pasta", LastDayQtySold = 100, LastDayProfit = 110000 });
            //Two
            builder.Entity<EbayMaster>().HasData(
     new EbayMaster() { MasterPageID = 2, LastDayProfit = 200, LastDayQtySold = 220000 });

            builder.Entity<EbayTransactions>().HasData(
new EbayTransactions() { TransactionID = 2, MasterPageID = 2, Asin = 66200001, Price = 1, LastUpdateDate = myDate2, ProductName = "Bread", LastDayQtySold = 200, LastDayProfit = 220000 });
            //Three
            builder.Entity<EbayMaster>().HasData(
     new EbayMaster() { MasterPageID = 3, LastDayProfit = 3000, LastDayQtySold = 50 });

            builder.Entity<EbayTransactions>().HasData(
new EbayTransactions() { TransactionID = 3, MasterPageID = 3, Asin = 555010102, Price = 1000, LastUpdateDate = myDate3, ProductName = "Tomato", LastDayQtySold = 50, LastDayProfit = 30000 });


        }
    }
}
