using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations.Hall
{
    public partial class Halls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Rows = table.Column<int>(nullable: false),
                    Cloumns = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    HallId = table.Column<string>(nullable: true),
                    Rows = table.Column<int>(nullable: false),
                    Cloumns = table.Column<int>(nullable: false),
                    Reserved = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Cloumns", "Rows" },
                values: new object[,]
                {
                    { "b43eba05-74e4-45ea-bf32-0ca5b8f85003", 5, 5 },
                    { "d0cdd288-de39-4a5d-9c7b-aac041e49414", 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Cloumns", "HallId", "Reserved", "Rows" },
                values: new object[,]
                {
                    { "d86fa7a8-db57-4aa6-91c4-4bcd7b011287", 1, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 0 },
                    { "43a6b6e9-8ef4-4cea-991c-221c70f571d7", 2, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 0 },
                    { "ae0ed366-d10e-484a-b112-492b3ecdddb5", 3, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 0 },
                    { "477d4cca-5c27-46b7-99bb-194521682592", 4, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 0 },
                    { "0290efc4-caf8-4dd0-9826-89ea01ce9b8b", 0, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 1 },
                    { "6b4b5383-115b-4850-9b0b-e2cf380cbeab", 1, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 1 },
                    { "eccb8796-2ae1-423c-9922-16fe300950ed", 2, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 1 },
                    { "d19c4e85-cbb7-436e-bde9-fbf4c5d4e28b", 3, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 1 },
                    { "78b383ae-8327-4635-9549-810f4c393017", 4, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 1 },
                    { "68d44adc-eaf4-42fe-a5e5-498b282b2a57", 0, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 2 },
                    { "d286b940-b051-4529-b357-2632b4448bac", 1, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 2 },
                    { "7787b36a-6e02-43f2-a3d9-f098bf8d255f", 2, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 2 },
                    { "e1072318-70b1-4daa-b731-761f7dae6a46", 3, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 2 },
                    { "add39a69-ba38-4c47-bf01-178af7736185", 4, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 2 },
                    { "53f30c7d-65a9-4269-970c-fef9b87cf483", 0, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 3 },
                    { "bf0539d0-4df6-41b8-817c-88e43d765d71", 1, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 3 },
                    { "efaa88e5-16d8-4a8a-8234-752ccd12e657", 2, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 3 },
                    { "69fa85f4-6085-4431-bd93-e141d2073192", 3, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 3 },
                    { "93c7db4e-badf-4c9a-af1c-b7b17595b873", 4, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 3 },
                    { "47aaf87e-def2-4338-a999-d8ba6c2036df", 0, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 4 },
                    { "9d7844a5-077c-40eb-9a08-eee874ef4a78", 1, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 4 },
                    { "f8e1c236-0529-4455-aa96-7fa5ee2e65ba", 2, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 4 },
                    { "3c28887c-64ab-41f6-ae3e-df9772c2f933", 0, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 0 },
                    { "26399e3d-b421-40b6-86ac-fc706e1c9fec", 4, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 4 },
                    { "b8e4e1a3-4183-498a-8da7-d92c77388976", 3, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 4 },
                    { "f63cb18c-9ac5-46e1-8030-84531919a5c8", 2, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 4 },
                    { "131ff15e-9649-4b64-b4a7-4c7cf9b098a7", 0, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 0 },
                    { "db6282f4-afb9-4fa2-a268-20f98cb47610", 1, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 0 },
                    { "f3db3259-1104-432a-aa2f-d3854e67126e", 2, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 0 },
                    { "a286e6f4-6e43-4a07-ab0a-c2c62c6ef22c", 3, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 0 },
                    { "8010fecc-cf41-406b-b567-8f7b537f3e7c", 4, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 0 },
                    { "bf1c442f-e84d-48f6-a21a-4be7e0a3bad5", 0, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 1 },
                    { "2f3a3320-4a16-4e6e-a162-d34fd3b2c1f6", 1, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 1 },
                    { "3d1368d4-79fd-42b6-84d8-f4e2f84105ce", 2, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 1 },
                    { "94b07d20-3554-48b5-8ac8-9062a3dea4f9", 3, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 1 },
                    { "205e613f-44cc-4312-9d9c-0271e6282959", 4, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 1 },
                    { "ab69adba-9bb0-4994-87ac-a5b3b2749e78", 3, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 4 },
                    { "4f4d2acd-17ac-4d92-b45b-43cf78377bab", 0, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 2 },
                    { "57b00ec8-a22a-4dc0-99ca-830c72a38256", 2, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 2 },
                    { "28237f16-300e-4814-8346-74ce1ea5f5f7", 3, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 2 },
                    { "f057487c-209b-4450-908f-26c719ee0c1f", 4, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 2 },
                    { "1a3f4013-a03c-4beb-8fce-b8dbe7603c08", 0, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 3 },
                    { "09e808a1-c523-4895-96f3-90a6ea4a21cb", 1, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 3 },
                    { "9a87d194-c60b-4552-ac4c-28c36da4d24e", 2, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 3 },
                    { "7bc1be5d-37f8-472b-bbae-cd695a83e6cd", 3, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 3 },
                    { "51e3593a-f2b5-470a-b7ea-0e8cd23f5ed9", 4, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 3 },
                    { "602701e3-0ed4-4de7-842f-0427524f6214", 0, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 4 },
                    { "23ac2fe2-6383-44f6-a540-95ae6c374285", 1, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 4 },
                    { "a4b8cc59-18bc-42b0-9569-6a41ef9676ea", 1, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", false, 2 },
                    { "42a77795-10a0-4c9a-bb86-1e31c57a5015", 4, "d0cdd288-de39-4a5d-9c7b-aac041e49414", false, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Halls");

            migrationBuilder.DropTable(
                name: "Seats");
        }
    }
}
