using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskTwo.Migrations
{
    public partial class ChangeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ebayTransactions_ebayMasters_EbayMasterMasterPageID",
                table: "ebayTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_transactionPages_masterPages_AmazonMasterMasterPageID",
                table: "transactionPages");

            migrationBuilder.DropIndex(
                name: "IX_transactionPages_AmazonMasterMasterPageID",
                table: "transactionPages");

            migrationBuilder.DropIndex(
                name: "IX_ebayTransactions_EbayMasterMasterPageID",
                table: "ebayTransactions");

            migrationBuilder.DropColumn(
                name: "AmazonMasterMasterPageID",
                table: "transactionPages");

            migrationBuilder.DropColumn(
                name: "EbayMasterMasterPageID",
                table: "ebayTransactions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AmazonMasterMasterPageID",
                table: "transactionPages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EbayMasterMasterPageID",
                table: "ebayTransactions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_transactionPages_AmazonMasterMasterPageID",
                table: "transactionPages",
                column: "AmazonMasterMasterPageID");

            migrationBuilder.CreateIndex(
                name: "IX_ebayTransactions_EbayMasterMasterPageID",
                table: "ebayTransactions",
                column: "EbayMasterMasterPageID");

            migrationBuilder.AddForeignKey(
                name: "FK_ebayTransactions_ebayMasters_EbayMasterMasterPageID",
                table: "ebayTransactions",
                column: "EbayMasterMasterPageID",
                principalTable: "ebayMasters",
                principalColumn: "MasterPageID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_transactionPages_masterPages_AmazonMasterMasterPageID",
                table: "transactionPages",
                column: "AmazonMasterMasterPageID",
                principalTable: "masterPages",
                principalColumn: "MasterPageID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
