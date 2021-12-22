using Microsoft.EntityFrameworkCore.Migrations;

namespace coreShoppingCartApplication.Migrations
{
    public partial class ProductDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "https://d3nn873nee648n.cloudfront.net/900x600/8384/5-SM205485.jpg", "Product One", 234.0 },
                    { 2, "https://d3nn873nee648n.cloudfront.net/900x600/8384/5-SM205485.jpg", "Product Two", 200.0 },
                    { 3, "https://d3nn873nee648n.cloudfront.net/900x600/8384/5-SM205485.jpg", "Product Three", 120.0 },
                    { 4, "https://d3nn873nee648n.cloudfront.net/900x600/8384/5-SM205485.jpg", "Product Four", 400.0 },
                    { 5, "https://d3nn873nee648n.cloudfront.net/900x600/8384/5-SM205485.jpg", "Product Five", 350.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
