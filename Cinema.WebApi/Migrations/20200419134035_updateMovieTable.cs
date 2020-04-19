using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations
{
    public partial class updateMovieTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "0fe4656a-4598-4f6f-9e7c-3f9347153a10",
                column: "Rated",
                value: "PG-13");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "13e6d16d-e8a9-4112-a3d0-fda72a846b17",
                column: "Rated",
                value: "PG-13");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "251759f9-a3c5-43d3-9734-39a288f2a461",
                column: "Rated",
                value: "R");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "5480d3f9-0e58-45bd-927c-95fd06cd2753",
                column: "Rated",
                value: "PG-13");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "69e84aef-f2e8-436c-b235-7563ae1cffa2",
                column: "Rated",
                value: "PG-13");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "0fe4656a-4598-4f6f-9e7c-3f9347153a10",
                columns: new[] { "Country", "Rated" },
                values: new object[] { "USA", "N/A" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "13e6d16d-e8a9-4112-a3d0-fda72a846b17",
                columns: new[] { "Country", "Rated" },
                values: new object[] { "Spain, Argentina", "N/A" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "164ca3af-4b7f-454f-bd07-9b8d6c3736cc",
                column: "Country",
                value: "USA");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "1df1dac8-0b73-486e-b1a0-ded9d9d0849c",
                column: "Country",
                value: "USA");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "251759f9-a3c5-43d3-9734-39a288f2a461",
                columns: new[] { "Country", "Rated" },
                values: new object[] { "USA, UK", "N/A" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "31446c42-fa95-4f38-8b8a-c5830649ca32",
                column: "Country",
                value: "USA");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "3a1a1424-20d5-469b-b39f-9012da50a71a",
                column: "Country",
                value: "USA");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "5480d3f9-0e58-45bd-927c-95fd06cd2753",
                columns: new[] { "Country", "Rated" },
                values: new object[] { "USA", "N/A" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "59c58d93-e15b-4d2c-94a2-03e82b82d7c2",
                column: "Country",
                value: "France, Belgium");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "69e84aef-f2e8-436c-b235-7563ae1cffa2",
                columns: new[] { "Country", "Rated" },
                values: new object[] { "UK", "N/A" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "ee79a6c6-c7e6-4ff8-9668-03ebe5134767",
                column: "Country",
                value: "USA");
        }
    }
}
