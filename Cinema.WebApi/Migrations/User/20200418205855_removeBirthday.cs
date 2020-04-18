using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations.User
{
    public partial class removeBirthday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Birthday",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "03491b89-9e02-422e-a082-9c63c5f10c02",
                column: "Birthday",
                value: "9/8/1994");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e",
                column: "Birthday",
                value: "4/1/1994");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a7cb6058-be25-4d4f-8649-0839839a879c",
                column: "Birthday",
                value: "4/6/1990");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fcce9446-45f6-40f9-a8de-8d8ba40aebf9",
                column: "Birthday",
                value: "11/5/1993");
        }
    }
}
