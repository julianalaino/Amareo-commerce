using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class initialize5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 679m },
                    { 73, "Description for product 73", "Product 73", 882m },
                    { 72, "Description for product 72", "Product 72", 520m },
                    { 71, "Description for product 71", "Product 71", 806m },
                    { 70, "Description for product 70", "Product 70", 841m },
                    { 69, "Description for product 69", "Product 69", 977m },
                    { 68, "Description for product 68", "Product 68", 290m },
                    { 67, "Description for product 67", "Product 67", 787m },
                    { 66, "Description for product 66", "Product 66", 822m },
                    { 65, "Description for product 65", "Product 65", 993m },
                    { 64, "Description for product 64", "Product 64", 732m },
                    { 63, "Description for product 63", "Product 63", 209m },
                    { 62, "Description for product 62", "Product 62", 823m },
                    { 61, "Description for product 61", "Product 61", 186m },
                    { 60, "Description for product 60", "Product 60", 640m },
                    { 59, "Description for product 59", "Product 59", 213m },
                    { 58, "Description for product 58", "Product 58", 796m },
                    { 57, "Description for product 57", "Product 57", 225m },
                    { 56, "Description for product 56", "Product 56", 827m },
                    { 55, "Description for product 55", "Product 55", 538m },
                    { 54, "Description for product 54", "Product 54", 794m },
                    { 53, "Description for product 53", "Product 53", 525m },
                    { 74, "Description for product 74", "Product 74", 106m },
                    { 52, "Description for product 52", "Product 52", 350m },
                    { 75, "Description for product 75", "Product 75", 968m },
                    { 77, "Description for product 77", "Product 77", 911m },
                    { 98, "Description for product 98", "Product 98", 308m },
                    { 97, "Description for product 97", "Product 97", 426m },
                    { 96, "Description for product 96", "Product 96", 213m },
                    { 95, "Description for product 95", "Product 95", 802m },
                    { 94, "Description for product 94", "Product 94", 730m },
                    { 93, "Description for product 93", "Product 93", 848m },
                    { 92, "Description for product 92", "Product 92", 141m },
                    { 91, "Description for product 91", "Product 91", 142m },
                    { 90, "Description for product 90", "Product 90", 995m },
                    { 89, "Description for product 89", "Product 89", 317m },
                    { 88, "Description for product 88", "Product 88", 860m },
                    { 87, "Description for product 87", "Product 87", 966m },
                    { 86, "Description for product 86", "Product 86", 587m },
                    { 85, "Description for product 85", "Product 85", 121m },
                    { 84, "Description for product 84", "Product 84", 971m },
                    { 83, "Description for product 83", "Product 83", 296m },
                    { 82, "Description for product 82", "Product 82", 420m },
                    { 81, "Description for product 81", "Product 81", 342m },
                    { 80, "Description for product 80", "Product 80", 552m },
                    { 79, "Description for product 79", "Product 79", 308m },
                    { 78, "Description for product 78", "Product 78", 171m },
                    { 76, "Description for product 76", "Product 76", 596m },
                    { 51, "Description for product 51", "Product 51", 845m },
                    { 50, "Description for product 50", "Product 50", 207m },
                    { 49, "Description for product 49", "Product 49", 911m },
                    { 22, "Description for product 22", "Product 22", 852m },
                    { 21, "Description for product 21", "Product 21", 132m },
                    { 20, "Description for product 20", "Product 20", 905m },
                    { 19, "Description for product 19", "Product 19", 895m },
                    { 18, "Description for product 18", "Product 18", 254m },
                    { 17, "Description for product 17", "Product 17", 482m },
                    { 16, "Description for product 16", "Product 16", 644m },
                    { 15, "Description for product 15", "Product 15", 109m },
                    { 14, "Description for product 14", "Product 14", 800m },
                    { 13, "Description for product 13", "Product 13", 946m },
                    { 12, "Description for product 12", "Product 12", 441m },
                    { 11, "Description for product 11", "Product 11", 314m },
                    { 10, "Description for product 10", "Product 10", 831m },
                    { 9, "Description for product 9", "Product 9", 599m },
                    { 8, "Description for product 8", "Product 8", 288m },
                    { 7, "Description for product 7", "Product 7", 930m },
                    { 6, "Description for product 6", "Product 6", 642m },
                    { 5, "Description for product 5", "Product 5", 113m },
                    { 4, "Description for product 4", "Product 4", 199m },
                    { 3, "Description for product 3", "Product 3", 590m },
                    { 2, "Description for product 2", "Product 2", 248m },
                    { 23, "Description for product 23", "Product 23", 122m },
                    { 24, "Description for product 24", "Product 24", 794m },
                    { 25, "Description for product 25", "Product 25", 985m },
                    { 26, "Description for product 26", "Product 26", 473m },
                    { 48, "Description for product 48", "Product 48", 235m },
                    { 47, "Description for product 47", "Product 47", 230m },
                    { 46, "Description for product 46", "Product 46", 532m },
                    { 45, "Description for product 45", "Product 45", 585m },
                    { 44, "Description for product 44", "Product 44", 951m },
                    { 43, "Description for product 43", "Product 43", 941m },
                    { 42, "Description for product 42", "Product 42", 535m },
                    { 41, "Description for product 41", "Product 41", 936m },
                    { 40, "Description for product 40", "Product 40", 888m },
                    { 39, "Description for product 39", "Product 39", 371m },
                    { 99, "Description for product 99", "Product 99", 958m },
                    { 38, "Description for product 38", "Product 38", 962m },
                    { 36, "Description for product 36", "Product 36", 268m },
                    { 35, "Description for product 35", "Product 35", 822m },
                    { 34, "Description for product 34", "Product 34", 755m },
                    { 33, "Description for product 33", "Product 33", 654m },
                    { 32, "Description for product 32", "Product 32", 492m },
                    { 31, "Description for product 31", "Product 31", 837m },
                    { 30, "Description for product 30", "Product 30", 866m },
                    { 29, "Description for product 29", "Product 29", 179m },
                    { 28, "Description for product 28", "Product 28", 207m },
                    { 27, "Description for product 27", "Product 27", 556m },
                    { 37, "Description for product 37", "Product 37", 837m },
                    { 100, "Description for product 100", "Product 100", 763m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stock",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 73, 73, 31 },
                    { 72, 72, 14 },
                    { 71, 71, 21 },
                    { 70, 70, 91 },
                    { 69, 69, 23 },
                    { 68, 68, 92 },
                    { 67, 67, 61 },
                    { 66, 66, 71 },
                    { 65, 65, 11 },
                    { 64, 64, 38 },
                    { 63, 63, 18 },
                    { 62, 62, 53 },
                    { 61, 61, 78 },
                    { 60, 60, 1 },
                    { 59, 59, 66 },
                    { 58, 58, 45 },
                    { 57, 57, 31 },
                    { 56, 56, 33 },
                    { 55, 55, 90 },
                    { 54, 54, 38 },
                    { 53, 53, 53 },
                    { 74, 74, 27 },
                    { 52, 52, 78 },
                    { 75, 75, 24 },
                    { 77, 77, 83 },
                    { 98, 98, 46 },
                    { 97, 97, 39 },
                    { 96, 96, 44 },
                    { 95, 95, 60 },
                    { 94, 94, 66 },
                    { 93, 93, 8 },
                    { 92, 92, 27 },
                    { 91, 91, 52 },
                    { 90, 90, 47 },
                    { 89, 89, 63 },
                    { 88, 88, 62 },
                    { 87, 87, 22 },
                    { 86, 86, 61 },
                    { 85, 85, 97 },
                    { 84, 84, 20 },
                    { 83, 83, 66 },
                    { 82, 82, 12 },
                    { 81, 81, 95 },
                    { 80, 80, 87 },
                    { 79, 79, 20 },
                    { 78, 78, 79 },
                    { 76, 76, 54 },
                    { 51, 51, 78 },
                    { 50, 50, 1 },
                    { 49, 49, 5 },
                    { 22, 22, 67 },
                    { 21, 21, 12 },
                    { 20, 20, 22 },
                    { 19, 19, 66 },
                    { 18, 18, 98 },
                    { 17, 17, 88 },
                    { 16, 16, 95 },
                    { 15, 15, 75 },
                    { 14, 14, 4 },
                    { 13, 13, 46 },
                    { 12, 12, 61 },
                    { 11, 11, 46 },
                    { 10, 10, 51 },
                    { 9, 9, 13 },
                    { 8, 8, 40 },
                    { 7, 7, 24 },
                    { 6, 6, 54 },
                    { 5, 5, 88 },
                    { 4, 4, 57 },
                    { 3, 3, 69 },
                    { 2, 2, 6 },
                    { 23, 23, 74 },
                    { 24, 24, 24 },
                    { 25, 25, 91 },
                    { 26, 26, 87 },
                    { 48, 48, 63 },
                    { 47, 47, 92 },
                    { 46, 46, 3 },
                    { 45, 45, 3 },
                    { 44, 44, 95 },
                    { 43, 43, 84 },
                    { 42, 42, 58 },
                    { 41, 41, 97 },
                    { 40, 40, 39 },
                    { 39, 39, 67 },
                    { 99, 99, 83 },
                    { 38, 38, 74 },
                    { 36, 36, 83 },
                    { 35, 35, 80 },
                    { 34, 34, 53 },
                    { 33, 33, 0 },
                    { 32, 32, 75 },
                    { 31, 31, 39 },
                    { 30, 30, 75 },
                    { 29, 29, 22 },
                    { 28, 28, 71 },
                    { 27, 27, 76 },
                    { 37, 37, 73 },
                    { 100, 100, 32 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Stock",
                keyColumn: "ProductInStockId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100);
        }
    }
}
