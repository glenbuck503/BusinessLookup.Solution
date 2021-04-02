using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessLookup.Migrations
{
    public partial class new3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 1,
                columns: new[] { "Name", "Number" },
                values: new object[] { "first shop", "1900" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "Goods", "Name", "Number" },
                values: new object[] { 3, "third", "third shop", "goodbye c#" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "Goods", "Name", "Number" },
                values: new object[] { 2, "second", "second shop", "livelinks" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 1,
                columns: new[] { "Name", "Number" },
                values: new object[] { "dfdsfs", "7" });
        }
    }
}
