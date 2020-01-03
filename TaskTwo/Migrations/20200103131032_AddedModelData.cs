using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskTwo.Migrations
{
    public partial class AddedModelData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ebayMasters",
                keyColumn: "MasterPageID",
                keyValue: 1,
                column: "TotalProducts",
                value: 244);

            migrationBuilder.UpdateData(
                table: "ebayMasters",
                keyColumn: "MasterPageID",
                keyValue: 2,
                column: "TotalProducts",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ebayMasters",
                keyColumn: "MasterPageID",
                keyValue: 3,
                column: "TotalProducts",
                value: 233);

            migrationBuilder.UpdateData(
                table: "masterPages",
                keyColumn: "MasterPageID",
                keyValue: 1,
                column: "TotalProducts",
                value: 14);

            migrationBuilder.UpdateData(
                table: "masterPages",
                keyColumn: "MasterPageID",
                keyValue: 2,
                column: "TotalProducts",
                value: 55);

            migrationBuilder.UpdateData(
                table: "masterPages",
                keyColumn: "MasterPageID",
                keyValue: 3,
                column: "TotalProducts",
                value: 33);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ebayMasters",
                keyColumn: "MasterPageID",
                keyValue: 1,
                column: "TotalProducts",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ebayMasters",
                keyColumn: "MasterPageID",
                keyValue: 2,
                column: "TotalProducts",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ebayMasters",
                keyColumn: "MasterPageID",
                keyValue: 3,
                column: "TotalProducts",
                value: 0);

            migrationBuilder.UpdateData(
                table: "masterPages",
                keyColumn: "MasterPageID",
                keyValue: 1,
                column: "TotalProducts",
                value: 0);

            migrationBuilder.UpdateData(
                table: "masterPages",
                keyColumn: "MasterPageID",
                keyValue: 2,
                column: "TotalProducts",
                value: 0);

            migrationBuilder.UpdateData(
                table: "masterPages",
                keyColumn: "MasterPageID",
                keyValue: 3,
                column: "TotalProducts",
                value: 0);
        }
    }
}
