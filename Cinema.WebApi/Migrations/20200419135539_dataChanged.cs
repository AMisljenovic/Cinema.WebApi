using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations
{
    public partial class dataChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "251759f9-a3c5-43d3-9734-39a288f2a461",
                columns: new[] { "Plot", "Runtime" },
                values: new object[] { "An action epic revolving around international espionage, time travel, and evolution.", "125min" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "251759f9-a3c5-43d3-9734-39a288f2a461",
                columns: new[] { "Plot", "Runtime" },
                values: new object[] { "An action epic revolving around international espionage, time travel, and evolution. Possibly about a man trying to prevent World War 3 through time travel and rebirth.", "N/A" });
        }
    }
}
