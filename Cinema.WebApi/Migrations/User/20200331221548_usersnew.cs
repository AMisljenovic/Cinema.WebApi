using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations.User
{
    public partial class usersnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "47d67ed4-fa1f-48a9-8fc4-f7dd6a2cb095");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "aa82d054-1ddf-43cf-b6b2-6decd42e9bd7");

            migrationBuilder.AddColumn<string>(
                name: "Birthday",
                table: "Users",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "Password", "Role", "Username" },
                values: new object[] { "1e7dec1d-8a53-4f05-84cf-f311bba0aea2", "4/1/1994", "Y2luZW1hdXNlcg==", "User", "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "Password", "Role", "Username" },
                values: new object[] { "d457afdc-8973-4928-ab74-a0aa43cb011a", "9/8/1994", "Y2luZW1hYWRtaW4=", "Administrator", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1e7dec1d-8a53-4f05-84cf-f311bba0aea2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d457afdc-8973-4928-ab74-a0aa43cb011a");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Role", "Username" },
                values: new object[] { "47d67ed4-fa1f-48a9-8fc4-f7dd6a2cb095", "Y2luZW1hdXNlcg==", "User", "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Role", "Username" },
                values: new object[] { "aa82d054-1ddf-43cf-b6b2-6decd42e9bd7", "Y2luZW1hYWRtaW4=", "Administrator", "admin" });
        }
    }
}
