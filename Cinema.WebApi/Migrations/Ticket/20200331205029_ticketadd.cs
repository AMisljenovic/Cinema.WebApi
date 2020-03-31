using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations.Ticket
{
    public partial class ticketadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    MoveId = table.Column<string>(nullable: true),
                    HallId = table.Column<string>(nullable: true),
                    PlayTime = table.Column<string>(nullable: true),
                    Day = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "Day", "HallId", "MoveId", "PlayTime" },
                values: new object[,]
                {
                    { "aa16e7c6-fdcd-4dcb-bae7-9c8e91905a6f", 1, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "5:00" },
                    { "3b148e97-30df-48ae-9175-24b418ae427e", 5, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "2:00" },
                    { "e3a92e97-ca60-41db-bd0e-a127ef1a352c", 4, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "22:00" },
                    { "783994c4-a7ef-403d-8838-5466ce9bc4c7", 4, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "9:00" },
                    { "3e7e45be-36c3-4401-997d-fb90755b7a0b", 4, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "0:00" },
                    { "12d92d1e-2ac4-4d6a-98dc-f684d4074cda", 3, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "16:00" },
                    { "b11bf793-6d82-4165-bb39-e9f99bac7d2b", 3, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "12:00" },
                    { "c7734607-bd36-49f8-9465-ea9e3b6a6c0e", 3, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "3:00" },
                    { "6e35995d-35ec-488f-a985-80190f3c2020", 2, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "16:00" },
                    { "9b9d6e3d-2c6e-4ed3-83a8-e7630d2f1f04", 2, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "11:00" },
                    { "5953feed-6ba9-44d6-8af5-14ec6baa6d8d", 2, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "5:00" },
                    { "81f8676f-202b-468f-935f-cf6c0d207010", 5, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "14:00" },
                    { "7ad5dd34-fd3c-4875-ab89-a8de463df46a", 1, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "18:00" },
                    { "5da17b26-a115-4e3c-8e7a-dcf95c28713b", 1, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "6:00" },
                    { "a6616812-b117-4c43-95dd-d7a805c9342d", 7, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "21:00" },
                    { "1a0f98e6-abfc-4c0c-bbb7-5409dc357c85", 7, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "12:00" },
                    { "db50cd25-64a1-40cc-8be8-7343f2c94ab0", 7, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "0:00" },
                    { "87468e4b-173b-4211-b83f-71ee5b4cdc5d", 6, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "17:00" },
                    { "efd85fc1-91a6-4f83-b283-858db241dfd3", 6, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "12:00" },
                    { "e6e5c60b-71da-4ce8-9017-029c86065416", 6, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "4:00" },
                    { "7161d9ec-5b3f-447e-b245-ed5f263f6a2e", 5, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "22:00" },
                    { "1165c044-70ab-450d-a29c-f1c7801e9a01", 5, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "13:00" },
                    { "6bdb862b-855f-46b0-bc11-24ce3140a7ba", 5, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "1:00" },
                    { "3cda0236-7ea3-4bb3-b23d-6be25275fa9b", 1, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "13:00" },
                    { "94a7b01e-8feb-40db-bf16-bae3e1805185", 5, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "17:00" },
                    { "b2260cfe-9942-464a-8477-cb1fc03449b8", 6, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "4:00" },
                    { "ac62415d-35e9-441e-b297-e8531f067389", 6, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "11:00" },
                    { "6e772ae5-7f5b-4ea5-8e0d-6a9c36622545", 7, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "3:00" },
                    { "4fb3b53d-0740-4fc1-86b6-b10bd60b9330", 6, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "22:00" },
                    { "9d597ca1-3be3-4b0a-b43c-59dc471b43f1", 6, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "9:00" },
                    { "ee2ee7bf-3109-4f28-b2fb-7bec1ec917bf", 6, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "3:00" },
                    { "7a2de723-dcfe-4a81-aa50-068f85525382", 5, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "17:00" },
                    { "9356a851-ea6f-4bbf-942d-e260a89ffeff", 5, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "9:00" },
                    { "fae6fd39-1d37-49d2-8565-b5ea1fcaf9d6", 5, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "5:00" },
                    { "1d01283b-2d6f-442b-89e9-89186e2f7e66", 4, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "21:00" },
                    { "6940d3ea-6e67-468d-a270-250d81f98735", 4, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "11:00" },
                    { "16d482ad-04ac-4fa8-a2df-606269a63447", 4, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "5:00" },
                    { "936027ea-938f-44f5-a145-e2c8f1972fe5", 3, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "19:00" },
                    { "5b44d714-f77a-411d-b3b8-8741a69362a0", 3, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "12:00" },
                    { "b177ff2e-6135-43cb-83e1-0438d9bf741c", 3, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "5:00" },
                    { "9f8db7ea-d94d-453f-bf58-725ac87a8f27", 2, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "21:00" },
                    { "c190abaf-73ee-4445-9114-3f291f105974", 2, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "9:00" },
                    { "7a5fde9a-b898-41e2-bd47-9ac56e13ca7e", 2, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "3:00" },
                    { "2f4b998f-4954-49df-b089-51a147cd6f48", 1, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "17:00" },
                    { "a8c814ac-6691-4f03-9106-bb7b7ea2c923", 1, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "13:00" },
                    { "8a2cd08d-aa5f-486a-bb6d-35aa351db7b3", 1, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "6:00" },
                    { "1831841e-563e-45a1-a464-b6ee61f69311", 7, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "18:00" },
                    { "68e4a997-616c-4d56-b3de-d03e15e954b4", 7, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "12:00" },
                    { "0b205732-048c-436b-a44c-c52e99db3077", 7, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "5:00" },
                    { "5be09b77-0ede-469b-99d0-e9a09cf9afb9", 6, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "21:00" },
                    { "adfaa075-0309-4254-ae44-5363cedb6d36", 4, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "17:00" },
                    { "c16e53d7-5bfa-428c-81ec-050d3f05b1ec", 7, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "14:00" },
                    { "6bab114d-69e7-427a-86c0-97fc226f79e1", 4, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "11:00" },
                    { "6687dbf1-aa8c-48ca-963e-2ae5bd62d1fd", 3, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "18:00" },
                    { "e706b4f0-d916-41c2-87f0-a2a54ca41bc1", 1, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "10:00" },
                    { "440b75c3-0009-48b5-8723-4f929d17e42e", 1, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "6:00" },
                    { "2da20f11-1192-47bd-b241-f0e61c7366d5", 7, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "21:00" },
                    { "9860ea07-5105-4a69-9199-b60e7ac533b0", 7, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "10:00" },
                    { "862b687c-9c20-4918-bec6-f8fee6999c56", 7, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "4:00" },
                    { "e82b3982-ab57-4555-8a7d-8572057aacf1", 6, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "22:00" },
                    { "2c0ef586-5304-47f7-9cec-15fccf7b0391", 6, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "9:00" },
                    { "07cd04f3-0b0f-4200-b05f-35c13e686fbe", 6, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "5:00" },
                    { "3534994f-c85d-4134-bde3-3cf9de339bbc", 5, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "16:00" },
                    { "5b68bd4e-333f-40d2-9dee-046f46d0c54d", 5, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "12:00" },
                    { "822a0f0a-29fe-42cd-8502-329ae95f484f", 1, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "18:00" },
                    { "87b52bed-d1fa-4e54-a04e-0a995dfdc187", 5, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "5:00" },
                    { "395f9682-5f30-4254-8017-9160966898a6", 4, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "14:00" },
                    { "8e8ead1b-75a1-4f07-8c31-714c59dc93b1", 4, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "0:00" },
                    { "df7ce33c-bbc3-4873-a0a6-d9a66913e974", 3, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "22:00" },
                    { "4d9791c3-2b58-4c0c-a416-fa3396ed6ba6", 3, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "13:00" },
                    { "60fccb0b-a096-4522-a1c2-e271d2be43cc", 3, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "3:00" },
                    { "41020870-f9f9-44b5-bf06-1a759b341416", 2, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "16:00" },
                    { "76300db9-9fd0-4836-8395-46ddea9b1d9f", 2, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "10:00" },
                    { "d1ff748e-649d-47c9-bb8d-92533314c4e1", 2, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "6:00" },
                    { "5caa1a49-e65b-414a-9b2a-6f7645cc6f39", 1, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "22:00" },
                    { "0f2dc950-797a-4503-b50e-fb0597c66ce8", 1, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "10:00" },
                    { "3c85405c-3d62-4113-ab4e-e86692d1a78e", 4, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "18:00" },
                    { "329eaae6-3bdd-45c6-a373-f73cff72a607", 2, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "1:00" },
                    { "604082af-8ad0-4366-85b7-dd40e7d1c486", 2, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "9:00" },
                    { "08416e9a-453a-45f3-ba08-16a01524def1", 2, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "16:00" },
                    { "371b4735-fa0f-4eda-8f2e-f472966f8434", 3, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "13:00" },
                    { "ae2df8b5-b3a3-4920-982b-9d3ba8f539d6", 3, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "2:00" },
                    { "769eab81-30f8-48d4-a718-1f7dde004b9d", 2, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "19:00" },
                    { "ba20f388-bd6e-4cc7-99b4-474f62449318", 2, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "11:00" },
                    { "7e483667-6cbc-4d46-8de6-747206d2b346", 2, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "7:00" },
                    { "a3e46762-53a4-4f21-8595-c2d90091da69", 1, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "21:00" },
                    { "edcd31a4-3aef-4e15-9dc2-3bccf13cc635", 1, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "9:00" },
                    { "a35f36cd-0015-4df7-9e6f-ba364893cd01", 1, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "7:00" },
                    { "8c75e4ef-5864-4bc3-9a98-8125f3562cae", 7, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "19:00" },
                    { "be92fd76-75ec-4e45-8c95-64f1aeb61f5f", 7, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "11:00" },
                    { "9df3b3d4-870c-4f94-8782-9bbbb0296c3b", 7, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "3:00" },
                    { "98df3920-5638-4ec2-8d07-fcba934a4adf", 6, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "22:00" },
                    { "5931ffe6-fbbb-4887-b726-c78b2c191fa6", 6, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "9:00" },
                    { "61122448-9815-476c-a071-0dfce3d1507c", 6, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "1:00" },
                    { "70759c44-dea6-487b-a52c-dfc960b54450", 5, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "21:00" },
                    { "019594ee-0c2a-44fe-abb2-eec58be9da73", 5, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "12:00" },
                    { "8ccb5cc0-6c36-41f5-9335-dc2ccfeba311", 5, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "2:00" },
                    { "450d1f95-3a39-4dbe-8c54-322c26e3644e", 4, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "20:00" },
                    { "88e496c8-c21c-4db7-bbbd-2d69fdc749a9", 4, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "12:00" },
                    { "b9ca768b-2325-4d1f-ac70-81dae8547a6c", 4, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "1:00" },
                    { "600ce3d7-b0df-4b34-9ebd-1f2f426483e6", 3, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "17:00" },
                    { "77652be9-ae8f-4121-b67c-b4cfe82ff676", 3, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "9:00" },
                    { "74aebd1c-5143-40ff-ad89-7255461e460b", 3, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "7:00" },
                    { "8ae9ca78-4a2b-4c59-8d2e-d344822c14a7", 4, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "3:00" },
                    { "7e6f198a-adf7-4e37-b72a-75e48fd8a08c", 7, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "17:00" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
