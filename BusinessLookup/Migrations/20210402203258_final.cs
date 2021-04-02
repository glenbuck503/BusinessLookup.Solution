using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessLookup.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 2,
                column: "Number",
                value: "pdx");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 2,
                column: "Number",
                value: "livelinks");
        }
    }
}
