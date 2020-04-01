using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations.Repertory
{
    public partial class repertories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Repertoires",
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
                    table.PrimaryKey("PK_Repertoires", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Repertoires",
                columns: new[] { "Id", "Day", "HallId", "MoveId", "PlayTime" },
                values: new object[,]
                {
                    { "988eec28-16b6-4a01-9b01-42c4c46c154a", 1, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "7:00" },
                    { "5b5d036a-dea9-4293-bd50-3095f4af55d5", 5, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "4:00" },
                    { "47d57738-c5b5-4b90-9fbe-901b9504ccef", 4, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "16:45" },
                    { "b273a4a2-7112-4b74-8fe8-b98f95d00b73", 4, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "11:30" },
                    { "550ef24b-fdeb-443e-8b06-c9b04db44601", 4, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "7:00" },
                    { "0b9b0649-3c24-4bbd-875c-bcd11027a246", 3, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "21:45" },
                    { "d6e9e639-ba33-4ab3-99d6-3aec76f2f74c", 3, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "12:30" },
                    { "77cea3c9-f93a-402b-8417-8a961270685f", 3, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "3:00" },
                    { "1b1be08d-c5fd-4775-af4a-dc872b294f86", 2, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "20:45" },
                    { "5874fe1a-5fef-40af-a3c8-998d6127f18d", 2, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "9:30" },
                    { "aab0e823-4a50-41bc-8e19-16f79925172f", 2, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "1:00" },
                    { "3ff3c362-0f9f-4b3f-83e5-20e499fadde4", 5, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "10:30" },
                    { "0d051f02-644e-42ea-b18d-c15cb1778109", 1, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "21:45" },
                    { "3471724d-c1e9-4e50-8c61-417d2f65e9c8", 1, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "5:00" },
                    { "24cfcf55-91e2-4814-ac5f-6a701b8d176e", 7, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "17:45" },
                    { "adb12d8e-c77c-48e1-8ee9-d473c73c2044", 7, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "11:30" },
                    { "104ce451-533f-49f8-bbcd-b67916d2f617", 7, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "6:00" },
                    { "5cfe43cd-58d5-408e-a358-7ed522fc1ad5", 6, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "17:45" },
                    { "69631d70-2504-4fc0-9e53-cb633a6ba9f6", 6, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "10:30" },
                    { "16c74882-fb74-4811-adac-e4a3942ded2e", 6, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "2:00" },
                    { "0816d0ac-83fb-4cd6-b5b3-ec37d42bac18", 5, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "20:45" },
                    { "0738dd57-6cc2-4a1d-bbe0-e123e58e8af0", 5, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "12:30" },
                    { "03a24bcc-c587-454d-9b17-bfa0ea56f74e", 5, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "6:00" },
                    { "02f82a4b-369b-4eb1-a25b-fcd7ba6f9d2a", 1, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "14:30" },
                    { "e16ec183-04f8-41b6-87d0-d9f4f0db9c0b", 5, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "16:45" },
                    { "2f2a94f2-0bc4-4096-acb0-b5f05661eb71", 6, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "6:00" },
                    { "4000f9d2-92b4-4d50-a8e9-ebdb38df90d6", 6, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "12:30" },
                    { "43ef0486-d802-4148-b87b-85d6379f3607", 7, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "0:00" },
                    { "31bdd4c6-c598-4f6a-b936-688d19ca2c94", 6, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "20:45" },
                    { "ee842dca-435e-4842-8d42-0d5512cc97a4", 6, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "12:30" },
                    { "ebc2bdae-b8d4-4c13-a226-ab16eb521d4c", 6, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "4:00" },
                    { "c68a2df3-778e-49cf-b9bb-62bc4335ad5d", 5, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "19:45" },
                    { "c0e0c1ac-4e18-453a-9984-d3535b20e60c", 5, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "10:30" },
                    { "7db6c863-d6f6-417a-a521-951a9eded5e9", 5, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "7:00" },
                    { "44279d07-c413-4fb7-95e4-918893e982eb", 4, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "17:45" },
                    { "e33b58b1-007a-47c6-8ae8-34b4d05ef76c", 4, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "11:30" },
                    { "390fec00-efec-4f87-af6d-51884a87bcab", 4, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "1:00" },
                    { "71764a7a-dc05-49c9-a310-50f50a64bada", 3, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "21:45" },
                    { "d28ce986-8f8a-4943-bb87-47c9976fa808", 3, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "10:30" },
                    { "a8e0bff2-b4b5-4693-a8c5-8f15aa14ef2c", 3, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "1:00" },
                    { "42bede1e-4702-4710-87b1-9344abb8734c", 2, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "19:45" },
                    { "7013ba14-7be2-4a12-b5d3-3cb2500ba105", 2, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "12:30" },
                    { "f5ce36a6-ad54-4259-8e14-259c5d076967", 2, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "5:00" },
                    { "bfba14da-5319-41ef-b539-9947ba0249a2", 1, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "17:45" },
                    { "b40a88c6-69db-4d7d-8398-016a57dcae56", 1, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "11:30" },
                    { "556af0c7-60de-49b7-98c4-6407c416129f", 1, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "0:00" },
                    { "38c8f6d0-bedc-4793-b712-17bf19526aeb", 7, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "20:45" },
                    { "720442be-4c7d-45aa-b0d4-277cf7e2c8d1", 7, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "11:30" },
                    { "70af2a20-7cb0-4de0-85cb-670062de0ebd", 7, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "1:00" },
                    { "31b0023d-7ace-463c-b8e6-658cf970841d", 6, "ed5e3547-bf44-437c-8f9f-a94036ae860c", "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "18:45" },
                    { "47a905cb-4b44-4ca2-9110-408528a68609", 4, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "22:45" },
                    { "b3bca5fa-eae9-4352-b47c-39a5911712d9", 7, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "10:30" },
                    { "1f2f00b6-dd46-4751-b23a-3a399b15f27b", 4, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "12:30" },
                    { "e808cd89-b9c8-46d0-b727-f126d8d25f57", 3, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "17:45" },
                    { "bf44c5e0-c42e-48e5-8c5b-dc63e2955c84", 1, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "11:30" },
                    { "6b8806ab-5b35-4d3f-8683-5b84e382eac6", 1, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "1:00" },
                    { "8a227825-424d-478f-8bee-e6ad3a25d16d", 7, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "20:45" },
                    { "f4b260f4-b30a-458b-bf50-3a7c8347cee4", 7, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "13:30" },
                    { "73233417-65ed-444d-a8f6-3e054c9b0a82", 7, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "4:00" },
                    { "9e742095-18b1-4ddd-b687-0b76441b367a", 6, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "17:45" },
                    { "46a00178-acc9-4eef-8aab-e8c7daaf39fc", 6, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "13:30" },
                    { "75eb97f4-c617-4d23-9aa8-7976922a9eb2", 6, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "0:00" },
                    { "63791a27-319b-439e-97aa-fe737ff98a5c", 5, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "17:45" },
                    { "da75aa21-4503-470c-b6d5-af28b8ae7ad7", 5, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "13:30" },
                    { "bfe41058-faa1-46ab-9650-f98819d7bda3", 1, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "16:45" },
                    { "98865c20-c82a-4d79-b89c-b1a682ce0741", 5, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "3:00" },
                    { "03319ec6-db92-4ef6-b3d2-292df0833ed6", 4, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "11:30" },
                    { "027fc860-c53b-426f-92fa-39917ba87dd6", 4, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "3:00" },
                    { "1e82b50f-0a97-442d-994e-40edc3004f61", 3, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "16:45" },
                    { "24d486a9-317d-4cde-85b6-d61ae53d5b6b", 3, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "11:30" },
                    { "9939ac87-ad57-40d7-ae40-42dd2ccaa362", 3, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "4:00" },
                    { "ffa5ae09-ca3c-42df-9dc8-506bc0c3821d", 2, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "20:45" },
                    { "88ba9f78-f749-43ba-a53d-92e401f34d3e", 2, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "10:30" },
                    { "17fd6d52-88c3-4f2f-9265-ef8acad4dfbf", 2, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "5:00" },
                    { "abd44f1a-763b-4b1d-8b28-1f18453ddd0e", 1, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "19:45" },
                    { "e4c98065-bec5-4a4c-a5eb-4bf18b27d005", 1, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "9:30" },
                    { "845cb544-9858-40dd-bfc2-9f0db9dcb591", 4, "b43eba05-74e4-45ea-bf32-0ca5b8f85003", "31446c42-fa95-4f38-8b8a-c5830649ca32", "21:45" },
                    { "790e99a9-3659-42b6-b1c5-11c415bc165b", 2, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "3:00" },
                    { "325dec93-bb9a-4358-bed0-96aef589b08c", 2, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "9:30" },
                    { "bb7531b9-f4f5-45c2-9d22-e7f10b896275", 2, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "21:45" },
                    { "9a0ea611-1277-472b-b610-f068ee6284d5", 3, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "11:30" },
                    { "b57df145-fc1c-4106-b68a-33e3cf367c1e", 3, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "5:00" },
                    { "545b32ed-7bf9-4c93-99d6-69498bc256a9", 2, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "20:45" },
                    { "aff0f720-d1ec-48a2-b77c-753c65b2362b", 2, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "13:30" },
                    { "3294aef1-77ff-4c64-960b-79298833b329", 2, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "6:00" },
                    { "2d3da9bf-0997-4aa2-a8d6-6994ba2a55e7", 1, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "18:45" },
                    { "124fc9a6-5709-4f21-97ae-578eece6b999", 1, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "11:30" },
                    { "3b55ad13-f4ff-4af2-8bfb-b52cdc81e5a2", 1, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "0:00" },
                    { "64f5fb78-c031-4e03-a9b1-d0a4f0bcc3b4", 7, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "16:45" },
                    { "0fbfa8a2-55e2-4a02-bab4-6f6472f471ad", 7, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "13:30" },
                    { "6eed182c-4fe7-4685-992b-3d2ddbf4ecf8", 7, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "1:00" },
                    { "ce353ef5-5f5d-4216-becb-28df3bd00824", 6, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "18:45" },
                    { "22b9163f-02dd-4535-84d3-019c10343f2f", 6, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "14:30" },
                    { "c30a2e59-af7e-4443-8e24-473cbd904530", 6, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "4:00" },
                    { "b5467859-e4e5-4c77-912f-2fb6ac7b057b", 5, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "22:45" },
                    { "2a1c452e-b979-47b1-bce7-c5b5ed7092b2", 5, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "9:30" },
                    { "8b9390b5-55a5-4bf6-aed5-0c894ac1ffd8", 5, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "2:00" },
                    { "8915e116-5e4e-48b8-9124-fd67f74ee718", 4, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "20:45" },
                    { "dfa65423-1f0a-4a82-87ec-7d6680470724", 4, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "13:30" },
                    { "a685b6b3-af7d-4fd3-a84c-d53f63b8a71e", 4, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "4:00" },
                    { "9b804dd2-acf1-4341-a601-f2e1e0a5872a", 3, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "18:45" },
                    { "625f45ec-e197-42d4-9a80-b610f9fe6093", 3, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "9:30" },
                    { "af5149a1-3827-4b39-a254-6b1bc23d543f", 3, "d0cdd288-de39-4a5d-9c7b-aac041e49414", "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "0:00" },
                    { "a480658e-7bff-43f8-bc1e-50cabd2af102", 4, "5019e093-32fa-42a0-bf18-dfd3724cc853", "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "0:00" },
                    { "af75f44d-ab13-487a-84b7-a96961c8be0a", 7, "01a2f471-b69d-4e68-9924-96e32351ab8d", "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "22:45" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Repertoires");
        }
    }
}
