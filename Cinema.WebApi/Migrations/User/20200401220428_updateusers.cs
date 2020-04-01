using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations.User
{
    public partial class updateusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1e7dec1d-8a53-4f05-84cf-f311bba0aea2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d457afdc-8973-4928-ab74-a0aa43cb011a");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Users",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "Name", "Password", "Role", "Surname", "Username" },
                values: new object[,]
                {
                    { "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e", "4/1/1994", "Petar", "Y2luZW1hdXNlcg==", "User", "Petrovic", "user" },
                    { "fcce9446-45f6-40f9-a8de-8d8ba40aebf9", "11/5/1993", "Mile", "Y2luZW1hdXNlcjI=", "User", "Mikic", "user2" },
                    { "a7cb6058-be25-4d4f-8649-0839839a879c", "4/6/1990", "Aleksa", "Y2luZW1hdXNlcjM=", "User", "Gavric", "user3" },
                    { "03491b89-9e02-422e-a082-9c63c5f10c02", "9/8/1994", "Jovan", "Y2luZW1hYWRtaW4=", "Administrator", "Lukic", "admin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "03491b89-9e02-422e-a082-9c63c5f10c02");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a7cb6058-be25-4d4f-8649-0839839a879c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fcce9446-45f6-40f9-a8de-8d8ba40aebf9");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "Password", "Role", "Username" },
                values: new object[] { "1e7dec1d-8a53-4f05-84cf-f311bba0aea2", "4/1/1994", "Y2luZW1hdXNlcg==", "User", "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "Password", "Role", "Username" },
                values: new object[] { "d457afdc-8973-4928-ab74-a0aa43cb011a", "9/8/1994", "Y2luZW1hYWRtaW4=", "Administrator", "admin" });
        }
    }
}
