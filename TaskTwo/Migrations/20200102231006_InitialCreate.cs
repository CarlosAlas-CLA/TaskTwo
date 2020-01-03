using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskTwo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "masterPages",
                columns: table => new
                {
                    MasterPageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastDayQtySold = table.Column<int>(nullable: false),
                    LastDayProfit = table.Column<int>(nullable: false),
                    TotalProducts = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_masterPages", x => x.MasterPageID);
                });

            migrationBuilder.CreateTable(
                name: "transactionPages",
                columns: table => new
                {
                    TransactionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    Asin = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    LastDayQtySold = table.Column<int>(nullable: false),
                    LastDayProfit = table.Column<int>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    MasterPageID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transactionPages", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_transactionPages_masterPages_MasterPageID",
                        column: x => x.MasterPageID,
                        principalTable: "masterPages",
                        principalColumn: "MasterPageID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "masterPages",
                columns: new[] { "MasterPageID", "LastDayProfit", "LastDayQtySold", "TotalProducts" },
                values: new object[] { 1, 100, 110000, 0 });

            migrationBuilder.InsertData(
                table: "masterPages",
                columns: new[] { "MasterPageID", "LastDayProfit", "LastDayQtySold", "TotalProducts" },
                values: new object[] { 2, 200, 220000, 0 });

            migrationBuilder.InsertData(
                table: "masterPages",
                columns: new[] { "MasterPageID", "LastDayProfit", "LastDayQtySold", "TotalProducts" },
                values: new object[] { 3, 3000, 50, 0 });

            migrationBuilder.InsertData(
                table: "transactionPages",
                columns: new[] { "TransactionID", "Asin", "LastDayProfit", "LastDayQtySold", "LastUpdateDate", "MasterPageID", "Price", "ProductName" },
                values: new object[] { 1, 10102, 110000, 100, new DateTime(1, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, 10000, "Pizza" });

            migrationBuilder.InsertData(
                table: "transactionPages",
                columns: new[] { "TransactionID", "Asin", "LastDayProfit", "LastDayQtySold", "LastUpdateDate", "MasterPageID", "Price", "ProductName" },
                values: new object[] { 2, 200001, 220000, 200, new DateTime(1, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, 100, "Sauce" });

            migrationBuilder.InsertData(
                table: "transactionPages",
                columns: new[] { "TransactionID", "Asin", "LastDayProfit", "LastDayQtySold", "LastUpdateDate", "MasterPageID", "Price", "ProductName" },
                values: new object[] { 3, 10102, 30000, 50, new DateTime(1, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, 1000, "Tamales" });

            migrationBuilder.CreateIndex(
                name: "IX_transactionPages_MasterPageID",
                table: "transactionPages",
                column: "MasterPageID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transactionPages");

            migrationBuilder.DropTable(
                name: "masterPages");
        }
    }
}
