using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POC_backEnd.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_country", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "vatrates",
                columns: table => new
                {
                    VatRateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VatNumber = table.Column<decimal>(type: "decimal(5,3)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VatRates", x => x.VatRateId);
                    table.ForeignKey(
                        name: "FK_vatRates_country",
                        column: x => x.CountryId,
                        principalTable: "country",
                        principalColumn: "CountryId");
                });

            migrationBuilder.InsertData(
                table: "country",
                columns: new[] { "CountryId", "CountryName" },
                values: new object[,]
                {
                    { 1, "France" },
                    { 2, "United Kingdom" },
                    { 3, "Portugal" },
                    { 4, "Spain" }
                });

            migrationBuilder.InsertData(
                table: "vatrates",
                columns: new[] { "VatRateId", "CountryId", "VatNumber" },
                values: new object[,]
                {
                    { 1, 1, 5.5m },
                    { 2, 1, 20m },
                    { 3, 1, 10m },
                    { 4, 2, 5m },
                    { 5, 2, 20m },
                    { 6, 3, 6m },
                    { 7, 3, 13m },
                    { 8, 3, 23m },
                    { 9, 4, 21m },
                    { 10, 4, 10m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_vatrates_CountryId",
                table: "vatrates",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vatrates");

            migrationBuilder.DropTable(
                name: "country");
        }
    }
}
