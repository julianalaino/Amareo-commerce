using Microsoft.EntityFrameworkCore.Migrations;

namespace Customer.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Customer");

            migrationBuilder.CreateTable(
                name: "Clients",
                schema: "Customer",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.InsertData(
                schema: "Customer",
                table: "Clients",
                columns: new[] { "ClientId", "Name" },
                values: new object[,]
                {
                    { 1, "Name for clien 1" },
                    { 73, "Name for clien 73" },
                    { 72, "Name for clien 72" },
                    { 71, "Name for clien 71" },
                    { 70, "Name for clien 70" },
                    { 69, "Name for clien 69" },
                    { 68, "Name for clien 68" },
                    { 67, "Name for clien 67" },
                    { 66, "Name for clien 66" },
                    { 65, "Name for clien 65" },
                    { 64, "Name for clien 64" },
                    { 63, "Name for clien 63" },
                    { 62, "Name for clien 62" },
                    { 61, "Name for clien 61" },
                    { 60, "Name for clien 60" },
                    { 59, "Name for clien 59" },
                    { 58, "Name for clien 58" },
                    { 57, "Name for clien 57" },
                    { 56, "Name for clien 56" },
                    { 55, "Name for clien 55" },
                    { 54, "Name for clien 54" },
                    { 53, "Name for clien 53" },
                    { 74, "Name for clien 74" },
                    { 52, "Name for clien 52" },
                    { 75, "Name for clien 75" },
                    { 77, "Name for clien 77" },
                    { 98, "Name for clien 98" },
                    { 97, "Name for clien 97" },
                    { 96, "Name for clien 96" },
                    { 95, "Name for clien 95" },
                    { 94, "Name for clien 94" },
                    { 93, "Name for clien 93" },
                    { 92, "Name for clien 92" },
                    { 91, "Name for clien 91" },
                    { 90, "Name for clien 90" },
                    { 89, "Name for clien 89" },
                    { 88, "Name for clien 88" },
                    { 87, "Name for clien 87" },
                    { 86, "Name for clien 86" },
                    { 85, "Name for clien 85" },
                    { 84, "Name for clien 84" },
                    { 83, "Name for clien 83" },
                    { 82, "Name for clien 82" },
                    { 81, "Name for clien 81" },
                    { 80, "Name for clien 80" },
                    { 79, "Name for clien 79" },
                    { 78, "Name for clien 78" },
                    { 76, "Name for clien 76" },
                    { 51, "Name for clien 51" },
                    { 50, "Name for clien 50" },
                    { 49, "Name for clien 49" },
                    { 22, "Name for clien 22" },
                    { 21, "Name for clien 21" },
                    { 20, "Name for clien 20" },
                    { 19, "Name for clien 19" },
                    { 18, "Name for clien 18" },
                    { 17, "Name for clien 17" },
                    { 16, "Name for clien 16" },
                    { 15, "Name for clien 15" },
                    { 14, "Name for clien 14" },
                    { 13, "Name for clien 13" },
                    { 12, "Name for clien 12" },
                    { 11, "Name for clien 11" },
                    { 10, "Name for clien 10" },
                    { 9, "Name for clien 9" },
                    { 8, "Name for clien 8" },
                    { 7, "Name for clien 7" },
                    { 6, "Name for clien 6" },
                    { 5, "Name for clien 5" },
                    { 4, "Name for clien 4" },
                    { 3, "Name for clien 3" },
                    { 2, "Name for clien 2" },
                    { 23, "Name for clien 23" },
                    { 24, "Name for clien 24" },
                    { 25, "Name for clien 25" },
                    { 26, "Name for clien 26" },
                    { 48, "Name for clien 48" },
                    { 47, "Name for clien 47" },
                    { 46, "Name for clien 46" },
                    { 45, "Name for clien 45" },
                    { 44, "Name for clien 44" },
                    { 43, "Name for clien 43" },
                    { 42, "Name for clien 42" },
                    { 41, "Name for clien 41" },
                    { 40, "Name for clien 40" },
                    { 39, "Name for clien 39" },
                    { 99, "Name for clien 99" },
                    { 38, "Name for clien 38" },
                    { 36, "Name for clien 36" },
                    { 35, "Name for clien 35" },
                    { 34, "Name for clien 34" },
                    { 33, "Name for clien 33" },
                    { 32, "Name for clien 32" },
                    { 31, "Name for clien 31" },
                    { 30, "Name for clien 30" },
                    { 29, "Name for clien 29" },
                    { 28, "Name for clien 28" },
                    { 27, "Name for clien 27" },
                    { 37, "Name for clien 37" },
                    { 100, "Name for clien 100" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ClientId",
                schema: "Customer",
                table: "Clients",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients",
                schema: "Customer");
        }
    }
}
