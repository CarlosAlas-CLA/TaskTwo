using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskTwo.Migrations
{
    public partial class EbayModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ebayMasters",
                columns: table => new
                {
                    MasterPageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastDayQtySold = table.Column<int>(nullable: false),
                    LastDayProfit = table.Column<int>(nullable: false),
                    TotalProducts = table.Column<int>(nullable: false),
                    EbayMasterMasterPageID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ebayMasters", x => x.MasterPageID);
                    table.ForeignKey(
                        name: "FK_ebayMasters_ebayMasters_EbayMasterMasterPageID",
                        column: x => x.EbayMasterMasterPageID,
                        principalTable: "ebayMasters",
                        principalColumn: "MasterPageID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ebayTransactions",
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
                    MasterPageID = table.Column<int>(nullable: true),
                    EbayMasterMasterPageID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ebayTransactions", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_ebayTransactions_ebayMasters_EbayMasterMasterPageID",
                        column: x => x.EbayMasterMasterPageID,
                        principalTable: "ebayMasters",
                        principalColumn: "MasterPageID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ebayMasters",
                columns: new[] { "MasterPageID", "EbayMasterMasterPageID", "LastDayProfit", "LastDayQtySold", "TotalProducts" },
                values: new object[,]
                {
                    { 1, null, 100, 110000, 0 },
                    { 2, null, 200, 220000, 0 },
                    { 3, null, 3000, 50, 0 }
                });

            migrationBuilder.InsertData(
                table: "ebayTransactions",
                columns: new[] { "TransactionID", "Asin", "EbayMasterMasterPageID", "LastDayProfit", "LastDayQtySold", "LastUpdateDate", "MasterPageID", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, 770010102, null, 110000, 100, new DateTime(1, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, 10, "Pasta" },
                    { 2, 66200001, null, 220000, 200, new DateTime(1, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, 1, "Bread" },
                    { 3, 555010102, null, 30000, 50, new DateTime(1, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, 1000, "Tomato" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ebayMasters_EbayMasterMasterPageID",
                table: "ebayMasters",
                column: "EbayMasterMasterPageID");

            migrationBuilder.CreateIndex(
                name: "IX_ebayTransactions_EbayMasterMasterPageID",
                table: "ebayTransactions",
                column: "EbayMasterMasterPageID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ebayTransactions");

            migrationBuilder.DropTable(
                name: "ebayMasters");
        }
    }
}
