using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations.User
{
    public partial class users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 40, nullable: false),
                    Surname = table.Column<string>(maxLength: 40, nullable: false),
                    Email = table.Column<string>(maxLength: 25, nullable: false),
                    Username = table.Column<string>(maxLength: 20, nullable: false),
                    Password = table.Column<string>(maxLength: 20, nullable: false),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password", "Role", "Surname", "Username" },
                values: new object[,]
                {
                    { "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e", "user@cinemate.com", "Petar", "Y2luZW1hdXNlcg==", "User", "Petrovic", "user" },
                    { "fcce9446-45f6-40f9-a8de-8d8ba40aebf9", "user2@cinemate.com", "Mile", "Y2luZW1hdXNlcjI=", "User", "Mikic", "user2" },
                    { "a7cb6058-be25-4d4f-8649-0839839a879c", "user3@cinemate.com", "Aleksa", "Y2luZW1hdXNlcjM=", "User", "Gavric", "user3" },
                    { "03491b89-9e02-422e-a082-9c63c5f10c02", "admin@cinemate.com", "Jovan", "Y2luZW1hYWRtaW4=", "Administrator", "Lukic", "admin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
