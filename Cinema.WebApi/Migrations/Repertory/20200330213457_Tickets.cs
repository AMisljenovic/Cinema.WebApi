using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations.Repertory
{
    public partial class Tickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Repertoires");

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    MoveId = table.Column<string>(nullable: true),
                    HallId = table.Column<string>(nullable: true),
                    PlayTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "HallId", "MoveId", "PlayTime" },
                values: new object[,]
                {
                    { "99d552f6-a5ea-4bc5-bae6-f873e43d3e54", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "22:00" },
                    { "6159020f-5378-4238-9c9b-f141af24ae66", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "15:00" },
                    { "77e80d38-54b0-4862-9b16-2c1f91b24f0a", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "19:00" },
                    { "4a01092c-64b7-4292-b951-b1fe9c2a98a7", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "8:00" },
                    { "910ebc69-2941-4474-9926-ed63742f89e9", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "20:00" },
                    { "db334185-efe7-488c-b557-e38a4dbc76a5", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "1:00" },
                    { "1aae3142-0846-4c24-82bb-e2ca007aa04f", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "9f855797-11d1-4634-b489-1ae58211ee98", "2:00" },
                    { "f9cfa2e9-fbcc-4a59-a35f-1d6fe500a1a3", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "9f855797-11d1-4634-b489-1ae58211ee98", "6:00" },
                    { "19db299c-0f5a-4b95-9404-fa41c18144a4", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "9f855797-11d1-4634-b489-1ae58211ee98", "20:00" },
                    { "ac9f0430-b7a1-4178-9759-e5a30d653774", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "9f855797-11d1-4634-b489-1ae58211ee98", "18:00" },
                    { "4cb1bfc4-7aef-4830-b17b-2fad4fc88af4", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "9f855797-11d1-4634-b489-1ae58211ee98", "8:00" },
                    { "622d9398-dc90-48c5-8c67-b762fb075ec9", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "9f855797-11d1-4634-b489-1ae58211ee98", "8:00" },
                    { "38478451-700b-4c6d-8cdb-9ef6c2644da4", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "18:00" },
                    { "6f518878-7afb-4bab-b9ba-b8c9e1de5ef3", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "9f855797-11d1-4634-b489-1ae58211ee98", "16:00" },
                    { "52e73b77-ddf0-4e48-99bc-f47d739e43d9", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "22469aab-0419-475e-a64a-ecfc335c7321", "16:00" },
                    { "4eced269-3e97-40f2-834a-e0e557419516", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "22469aab-0419-475e-a64a-ecfc335c7321", "20:00" },
                    { "3c098b4f-1f5f-472a-a6cd-eaa24812037a", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "22469aab-0419-475e-a64a-ecfc335c7321", "7:00" },
                    { "75df98a8-cb1b-4544-966d-f7e185f740c9", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "22469aab-0419-475e-a64a-ecfc335c7321", "11:00" },
                    { "74944f24-75fd-4820-b70c-e8164645e78f", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "22469aab-0419-475e-a64a-ecfc335c7321", "16:00" },
                    { "f72837db-3b3f-4e7e-9d4f-782b5744babd", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "22469aab-0419-475e-a64a-ecfc335c7321", "22:00" },
                    { "77a6bb6d-001e-4179-8d55-8d167c64eee8", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "26ba6b32-be90-443f-8ba2-890f14551457", "6:00" },
                    { "56cbb7cd-15be-45e7-aad6-20d19912d532", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "26ba6b32-be90-443f-8ba2-890f14551457", "15:00" },
                    { "01964291-6e4a-4b5e-b761-09f407b66552", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "26ba6b32-be90-443f-8ba2-890f14551457", "14:00" },
                    { "540ac782-b18c-41ed-bd39-cd843883acf5", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "26ba6b32-be90-443f-8ba2-890f14551457", "15:00" },
                    { "17f9b83a-f90a-4a03-a3c4-11a8622276dc", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "26ba6b32-be90-443f-8ba2-890f14551457", "10:00" },
                    { "8d336485-7965-4888-aca3-b35826b125c3", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "22469aab-0419-475e-a64a-ecfc335c7321", "11:00" },
                    { "506cdc04-0eb8-40cc-9591-2ee7559ced98", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "15:00" },
                    { "28fdbfe2-7177-46bb-a54e-0c77cbb161ee", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "15:00" },
                    { "01096560-bed8-42bd-b750-2f489d41d2d7", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "2:00" },
                    { "38979969-a611-4042-864d-56178378dfaf", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "31446c42-fa95-4f38-8b8a-c5830649ca32", "9:00" },
                    { "4a508e5b-f359-432d-b34a-150d49f1332a", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "0:00" },
                    { "e7caeb2d-e632-40ae-9271-067829b465d3", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "31446c42-fa95-4f38-8b8a-c5830649ca32", "17:00" },
                    { "1587a985-fab5-405b-a622-f490f8a3992d", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "18:00" },
                    { "15d466b2-06e8-49e4-82b9-ec60a1a90b96", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "31446c42-fa95-4f38-8b8a-c5830649ca32", "5:00" },
                    { "199be63f-15fd-4396-9984-c31cd9b14518", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "0:00" },
                    { "51ef3239-1319-4386-9e80-6d1f03aa8244", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "12:00" },
                    { "2707a35f-1c8f-4fab-b0aa-2f1150ad1e03", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "8:00" },
                    { "e0778d70-122b-47c0-a12e-c04e182729b1", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "2:00" },
                    { "be0e8e81-7d1c-4f37-8521-adc510aa42ac", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "11:00" },
                    { "a1b602ad-c53b-4af1-b6d1-48b0d637a8ba", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "8:00" },
                    { "0d45f245-76fa-4c5c-999d-1c1d04ebb868", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "6:00" },
                    { "af431ef7-1ade-46bf-91e0-cde7c9bced42", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "22:00" },
                    { "d2680fa6-74de-4fc8-9b9a-fb0eb1be2042", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "11:00" },
                    { "a0a516c8-ad23-4cfa-b1db-1e3c41403a06", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "0:00" },
                    { "77ac1010-6e14-4951-a111-ba83e98274d6", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "13:00" },
                    { "2e85e693-d880-4fc0-9ddb-25e79594384f", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "16:00" },
                    { "d91b7fcf-b10e-4bfa-bb9c-d623cd4edd7c", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "4:00" },
                    { "91191664-df47-45f6-bbed-b5ed1e7e078f", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "3:00" },
                    { "1c7d537f-5245-465f-b964-c801242b5b70", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "7:00" },
                    { "fe0aca0c-40b2-4841-9b4b-13716a5c2b54", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "10:00" },
                    { "a4c37f75-bb66-4bec-b5ae-a443220fd676", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "0:00" },
                    { "7e25bae7-e6a8-4c6e-a4e1-eb4b398cfcff", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "6:00" },
                    { "349a2449-e9cb-4787-9022-8f334e0ff740", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "22:00" },
                    { "9815f7cd-9073-4624-906f-67d9ea44d70d", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "21:00" },
                    { "278d9f49-3ef9-4bb4-9fa2-4b336b831c5d", "d0cdd288-de39-4a5d-9c7b-aac041e49414", "26ba6b32-be90-443f-8ba2-890f14551457", "15:00" },
                    { "a026950b-ab91-4713-a9a1-6fc8898a2f6f", "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "26ba6b32-be90-443f-8ba2-890f14551457", "11:00" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.CreateTable(
                name: "Repertoires",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AvailableTickets = table.Column<int>(type: "int", nullable: false),
                    MoveId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoldTickets = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repertoires", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Repertoires",
                columns: new[] { "Id", "AvailableTickets", "MoveId", "SoldTickets", "Time" },
                values: new object[,]
                {
                    { "d140b25f-1c14-4aec-a271-be66febfcc00", 30, "31446c42-fa95-4f38-8b8a-c5830649ca32", 0, new DateTime(2020, 3, 2, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2b36a06b-be50-4669-ab12-720f5bb5d4bf", 30, "31446c42-fa95-4f38-8b8a-c5830649ca32", 0, new DateTime(2020, 3, 3, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "681ab4c0-a17f-45a4-a37a-e77d4b270ec4", 30, "31446c42-fa95-4f38-8b8a-c5830649ca32", 0, new DateTime(2020, 3, 4, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2497ac91-eb3d-4d8f-9d2f-ad39925a698e", 30, "31446c42-fa95-4f38-8b8a-c5830649ca32", 0, new DateTime(2020, 3, 5, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "0a3b67f2-c1f4-4325-beb1-bb058fafaf7a", 30, "31446c42-fa95-4f38-8b8a-c5830649ca32", 0, new DateTime(2020, 3, 6, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "dbfff58d-0725-4449-b1bb-fbe2f23f35b7", 30, "31446c42-fa95-4f38-8b8a-c5830649ca32", 0, new DateTime(2020, 3, 7, 21, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "3cbf7579-ab7d-4e2d-91fd-e1b7dae4e034", 30, "31446c42-fa95-4f38-8b8a-c5830649ca32", 0, new DateTime(2020, 3, 8, 23, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
