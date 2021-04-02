using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessLookup.Migrations
{
    public partial class new2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 1,
                column: "Goods",
                value: "yeehaw");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 1,
                column: "Goods",
                value: "Woolly Mammoth");
        }
    }
}
