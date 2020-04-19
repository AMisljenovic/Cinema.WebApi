using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations
{
    public partial class entriesUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Director",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "0fe4656a-4598-4f6f-9e7c-3f9347153a10",
                column: "Writer",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "13e6d16d-e8a9-4112-a3d0-fda72a846b17",
                column: "Writer",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "164ca3af-4b7f-454f-bd07-9b8d6c3736cc",
                column: "Writer",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "1df1dac8-0b73-486e-b1a0-ded9d9d0849c",
                column: "Writer",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "251759f9-a3c5-43d3-9734-39a288f2a461",
                columns: new[] { "Runtime", "Writer" },
                values: new object[] { "125 min", null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "31446c42-fa95-4f38-8b8a-c5830649ca32",
                column: "Writer",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "3a1a1424-20d5-469b-b39f-9012da50a71a",
                column: "Writer",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "5480d3f9-0e58-45bd-927c-95fd06cd2753",
                column: "Writer",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "59c58d93-e15b-4d2c-94a2-03e82b82d7c2",
                column: "Writer",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "69e84aef-f2e8-436c-b235-7563ae1cffa2",
                column: "Writer",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "ee79a6c6-c7e6-4ff8-9668-03ebe5134767",
                column: "Writer",
                value: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "0fe4656a-4598-4f6f-9e7c-3f9347153a10",
                columns: new[] { "Director", "Writer" },
                values: new object[] { "Dustin Cook", "Dustin Cook" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "13e6d16d-e8a9-4112-a3d0-fda72a846b17",
                columns: new[] { "Director", "Writer" },
                values: new object[] { "Alejandro Amenábar", "Alejandro Amenábar, Alejandro Hernández" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "164ca3af-4b7f-454f-bd07-9b8d6c3736cc",
                columns: new[] { "Director", "Writer" },
                values: new object[] { "Jon Watts", "Chris McKenna, Erik Sommers, Stan Lee (based on the Marvel comic book by), Steve Ditko (based on the Marvel comic book by)" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "1df1dac8-0b73-486e-b1a0-ded9d9d0849c",
                columns: new[] { "Director", "Writer" },
                values: new object[] { "Alex Ranarivelo", "Alex Ranarivelo" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "251759f9-a3c5-43d3-9734-39a288f2a461",
                columns: new[] { "Director", "Runtime", "Writer" },
                values: new object[] { "Christopher Nolan", "125min", "Christopher Nolan" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "31446c42-fa95-4f38-8b8a-c5830649ca32",
                columns: new[] { "Director", "Writer" },
                values: new object[] { "Roger Kumble", "Elizabeth Hackett, Hilary Galanoy" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "3a1a1424-20d5-469b-b39f-9012da50a71a",
                columns: new[] { "Director", "Writer" },
                values: new object[] { "Dee Rees", "Marco Villalobos (screenplay by), Dee Rees (screenplay by), Joan Didion (based on the book by)" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "5480d3f9-0e58-45bd-927c-95fd06cd2753",
                columns: new[] { "Director", "Writer" },
                values: new object[] { "Alex Magaña", "Alex Magaña" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "59c58d93-e15b-4d2c-94a2-03e82b82d7c2",
                columns: new[] { "Director", "Writer" },
                values: new object[] { "Fred Grivois", "Ileana Epsztajn (collaboration), Fred Grivois (screenplay), Jérémie Guez (collaboration)" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "69e84aef-f2e8-436c-b235-7563ae1cffa2",
                columns: new[] { "Director", "Writer" },
                values: new object[] { "David Modell", "N/A" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "ee79a6c6-c7e6-4ff8-9668-03ebe5134767",
                columns: new[] { "Director", "Writer" },
                values: new object[] { "Pat Williams", "Neal H. Dobrofsky, Tippi Dobrofsky" });
        }
    }
}
