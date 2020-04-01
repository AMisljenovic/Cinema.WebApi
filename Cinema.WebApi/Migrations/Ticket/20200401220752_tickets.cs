using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations.Ticket
{
    public partial class tickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    RepertoryId = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    SeatRow = table.Column<int>(nullable: false),
                    SeatColumn = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "RepertoryId", "SeatColumn", "SeatRow", "UserId" },
                values: new object[,]
                {
                    { "21bf2f2e-19ee-47d7-943c-2efe3f3e581c", "988eec28-16b6-4a01-9b01-42c4c46c154a", 1, 0, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "813eaf19-5d11-4ae0-87d1-8a8250e97197", "16c74882-fb74-4811-adac-e4a3942ded2e", 1, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "5baaa130-2b77-4b57-8e02-4724bf345428", "104ce451-533f-49f8-bbcd-b67916d2f617", 3, 0, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "3a27653f-3c72-4346-91b1-8b2caa9198fb", "3471724d-c1e9-4e50-8c61-417d2f65e9c8", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "6c865fc9-dacc-48b4-bf12-af4213ab5e15", "aab0e823-4a50-41bc-8e19-16f79925172f", 0, 3, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "c063716c-1add-4dc4-9f51-c8fac9a2f1a5", "77cea3c9-f93a-402b-8417-8a961270685f", 2, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "3f87df47-4d65-4dfa-9262-80653ba10792", "550ef24b-fdeb-443e-8b06-c9b04db44601", 2, 2, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "6464c03d-e10d-4049-9183-93f0ec0e0c94", "03a24bcc-c587-454d-9b17-bfa0ea56f74e", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "5c32e39d-c28f-44bf-ad8f-79e02a36fc1a", "5b5d036a-dea9-4293-bd50-3095f4af55d5", 1, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "2ee790f8-a606-42f7-9baf-8ec96fcae3cb", "70af2a20-7cb0-4de0-85cb-670062de0ebd", 2, 2, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "d7ccdf39-2387-4ab5-870e-351a721a0795", "556af0c7-60de-49b7-98c4-6407c416129f", 1, 0, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "bb326d23-710f-48a0-bc90-185a1374a15d", "f5ce36a6-ad54-4259-8e14-259c5d076967", 0, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "f9dcd418-e554-4ead-9eff-a7bb5d5bdd4b", "a8e0bff2-b4b5-4693-a8c5-8f15aa14ef2c", 0, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "3fcedd8b-217e-4f2e-b4bf-d0e3015104d3", "390fec00-efec-4f87-af6d-51884a87bcab", 3, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "deac4e92-142f-4e90-9976-2486f20b0ebc", "7db6c863-d6f6-417a-a521-951a9eded5e9", 2, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "58387d9f-2123-4f02-9e18-7c02fe249a2e", "2f2a94f2-0bc4-4096-acb0-b5f05661eb71", 1, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "48ddfbf3-26e4-4302-a8a0-402a4d1c3255", "ebc2bdae-b8d4-4c13-a226-ab16eb521d4c", 0, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "1f946c2c-7eca-40fc-98c4-431f13d967cc", "a480658e-7bff-43f8-bc1e-50cabd2af102", 1, 2, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "71b968fb-079a-4fd0-8689-ffcc8083c06e", "3294aef1-77ff-4c64-960b-79298833b329", 1, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "dd411f03-9297-4848-a80a-db69024a59a3", "17fd6d52-88c3-4f2f-9265-ef8acad4dfbf", 3, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "2ba60196-16a2-4fba-bf61-acd271aca7da", "9939ac87-ad57-40d7-ae40-42dd2ccaa362", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "e9c5e775-1edf-43cc-bbd7-05de34dcdc2e", "027fc860-c53b-426f-92fa-39917ba87dd6", 1, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "4cfa8c36-3ed5-4ce4-a752-ca531d4e6982", "98865c20-c82a-4d79-b89c-b1a682ce0741", 1, 0, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "b695d561-c906-4ba6-b822-c1c57744ad32", "75eb97f4-c617-4d23-9aa8-7976922a9eb2", 0, 2, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "2d811d01-14fb-406a-b4f9-373b5572eb38", "73233417-65ed-444d-a8f6-3e054c9b0a82", 2, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "8ec004c4-c871-4d05-8e22-b203addc92f6", "b57df145-fc1c-4106-b68a-33e3cf367c1e", 1, 2, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "c06700d6-7d9a-4b08-9eef-85e4070457bb", "6b8806ab-5b35-4d3f-8683-5b84e382eac6", 3, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "b5eeb191-3ff1-4f3c-a066-eb992d45c60d", "af5149a1-3827-4b39-a254-6b1bc23d543f", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "28e2a487-0f68-4357-a44c-0a6631b627cd", "a685b6b3-af7d-4fd3-a84c-d53f63b8a71e", 3, 3, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "30595af5-8f61-4c84-b0c7-ce6af577aa67", "8b9390b5-55a5-4bf6-aed5-0c894ac1ffd8", 2, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "5b964ab6-d652-477c-b63b-72b7254b3395", "c30a2e59-af7e-4443-8e24-473cbd904530", 3, 3, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "a2829917-b2fb-4cc1-835a-6a77317dcff0", "6eed182c-4fe7-4685-992b-3d2ddbf4ecf8", 1, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "38c71260-3494-4153-aeed-a706cbc0c93f", "3b55ad13-f4ff-4af2-8bfb-b52cdc81e5a2", 0, 0, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "5661e316-5c51-43e8-8684-2989a3b6091e", "790e99a9-3659-42b6-b1c5-11c415bc165b", 2, 3, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "9ba4d00d-1c94-4ada-9d56-f529b3167c3f", "43ef0486-d802-4148-b87b-85d6379f3607", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
