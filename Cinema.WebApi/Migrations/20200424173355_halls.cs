using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations
{
    public partial class halls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 40, nullable: false),
                    Rows = table.Column<int>(nullable: false),
                    Columns = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Columns", "Name", "Rows" },
                values: new object[,]
                {
                    { "b43eba05-74e4-45ea-bf32-0ca5b8f85003", 5, "A1", 5 },
                    { "d0cdd288-de39-4a5d-9c7b-aac041e49414", 5, "A2", 5 },
                    { "5019e093-32fa-42a0-bf18-dfd3724cc853", 5, "B1", 5 },
                    { "ed5e3547-bf44-437c-8f9f-a94036ae860c", 5, "B2", 5 },
                    { "01a2f471-b69d-4e68-9924-96e32351ab8d", 5, "C", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Halls");
        }
    }
}
