using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations.Repertory
{
    public partial class datecolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Repertoires",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "0002ce82-5bf2-4b33-9d69-6c4c3f09f36a",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "5/1/2020", "4:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "00b4ebea-8f60-43c9-b1ff-091053e4f744",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/25/2020", "18:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "067273f1-2931-4cf5-9f0f-0893fa7ec83e",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/27/2020", "12:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "0b1177fe-0733-42e8-a8c5-35ad8039a14e",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/28/2020", "4:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "12c891d0-3a9c-40b0-93a1-e56ce23c15dd",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/26/2020", "20:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "1367d782-f24e-4985-978d-825515f40bee",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/30/2020", "5:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "14705128-16f3-4e28-8f2b-63465d15a49c",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/26/2020", "1:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "149d67fb-796f-489b-bbe2-993073b66bc6",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/29/2020", "12:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "17738e0f-d311-4003-b6c2-7a8bfe733e20",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/27/2020", "7:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "18c4b1be-0ef2-403e-a670-fe010a670db1",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/25/2020", "2:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "18f8b880-1231-4028-9eb6-998e94b62b9b",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/29/2020", "0:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "1bbd4048-bbf7-4269-a4a1-bf0510fd18db",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/29/2020", "0:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "1c6173eb-e01b-4a87-8f1c-18f0fb6f4a54",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/27/2020", "0:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "1dd5a479-a903-426e-9880-4eeef60b69f8",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/26/2020", "0:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "2128363b-df77-4459-85aa-2beaf899ec4c",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/30/2020", "6:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "2339db48-b2bc-481d-9d78-ebb9e32f433d",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/27/2020", "18:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "23fc35c2-cd81-45be-bf32-b2cb1da3bc34",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/29/2020", "16:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "2727ab7e-65a3-437a-a403-c121c87a32bf",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/29/2020", "12:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "29fe55f5-1a1f-40ad-8db4-9b6731040db2",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/26/2020", "14:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "2a1fccf7-7603-4ba5-b4be-044ed500ea75",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "5/1/2020", "11:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "2a8d4b29-f39b-4812-a219-3f7661842098",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/29/2020", "9:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "2ce9ef7b-77f0-49e8-8277-fe90927f3ce7",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/25/2020", "1:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "334fb052-927e-43ae-b032-e18de7dd81ce",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/27/2020", "4:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "34e641ec-9bea-4383-8e8b-f949aa764e21",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/25/2020", "0:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "37b06319-09db-4b97-8f78-98f51f1d8e32",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/28/2020", "7:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "3dd1e68e-667c-42b3-bea0-29ffcc30a0e8",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/28/2020", "12:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "40e5a01f-34d0-446f-a954-6057150ec540",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/26/2020", "22:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "4282c7e6-4904-4a11-83a4-bf5278775272",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/29/2020", "22:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "43161eb5-a4a4-455f-b402-fb7d7c73b98a",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "5/1/2020", "9:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "4b0c1825-74c9-4b7c-be7e-42a25038e481",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/28/2020", "22:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "4dfd11e5-391a-47be-902c-99620a9eabce",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/26/2020", "4:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "4f537a29-4171-4a9e-a3db-9acc950863e2",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/25/2020", "4:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "4f8eb2ca-3a70-4920-8de0-5033ed304451",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/25/2020", "21:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "524ce530-f997-44da-b118-2c88be728248",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/29/2020", "16:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "533a5c82-b0ce-4e4e-afb9-cb23a7940a05",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/30/2020", "16:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "5417a7e6-e108-48ff-b831-6578c3680a71",
                column: "Date",
                value: "4/30/2020");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "5bc15682-2eaa-4baf-86ea-e03db1efe9f1",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/29/2020", "7:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "5f37e508-8156-4d8e-9859-d52933a64b12",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/26/2020", "3:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "646458e6-6060-4dcc-9118-b14ce4c1fe28",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/30/2020", "3:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "661ac04f-8289-4eec-9530-c648264eb9a4",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/28/2020", "7:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "66fd7189-cf10-44cc-a4e5-0f16aa07bfb9",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "5/1/2020", "10:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "73e61eb8-e1ef-400f-a6b8-b2e07725dfb2",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/29/2020", "13:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "750b85d6-9ea1-4b66-942c-4e09f432530b",
                column: "Date",
                value: "4/25/2020");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "7b0d2ec2-e0ad-4efc-ba04-8d9453fd6353",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/28/2020", "0:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "7ed80a87-eb47-4249-8ac1-917a0800496c",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "5/1/2020", "16:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "7fe64e0c-3586-4164-a6b5-e336b032bd4a",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/27/2020", "5:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "8040c6f9-f275-4752-9363-6d12069cd828",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/27/2020", "0:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "8076031b-7b62-4185-9b15-4ac4466b3437",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "5/1/2020", "1:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "8411a5b7-699f-45d4-ab67-ee3a17338424",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/28/2020", "21:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "86d5fad3-0481-4497-9dab-b97a7da4c13c",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "5/1/2020", "22:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "870a16fa-a719-4491-b09a-b06ad652a1d7",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/25/2020", "17:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "87950de7-b4a3-430b-add8-57cb2f696aa6",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "5/1/2020", "11:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "8ad3aba2-5caa-40ca-afdb-d62f9253ed01",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/25/2020", "14:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "8cf9c962-93ad-429c-9347-6fb6022a1f37",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/30/2020", "17:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "8e25c8bb-a4a4-4df7-ab04-e8e2f6452a26",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/30/2020", "17:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "907b2948-5efc-48b5-9cfb-3358e376d30e",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/30/2020", "7:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "921112c1-f48f-4d06-9ae8-81b8c663fa2a",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "5/1/2020", "22:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "94fa00b6-628c-4a42-a4ca-5e3398dbdbc0",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/26/2020", "14:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "9e798f75-e7db-4a9a-a21b-d49cbba34b01",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/28/2020", "7:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "9eb6b139-02cc-4be2-b1cf-5d8145f5cfa3",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/25/2020", "9:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "9fff2c90-0b6f-4974-864c-8f54a86edb4b",
                column: "Date",
                value: "4/25/2020");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "a1a5cd9b-768c-44c3-9da7-c159e933da5b",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/27/2020", "20:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "a1c414ac-30c6-44fa-84fe-8ed9bba25611",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/30/2020", "9:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "a36ce8fb-2240-4440-8fb9-2e09c1a21dba",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/29/2020", "1:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "a658c6b0-20fd-43b7-a603-52bee735a01a",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/27/2020", "19:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "a7dd1624-9980-48f4-b73a-56660e673c89",
                column: "Date",
                value: "4/30/2020");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "a82ed5c0-e84a-481a-9c6d-78263c07e6ca",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "5/1/2020", "16:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "a840daac-d9a9-4c16-a48a-043e43247034",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/25/2020", "21:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "a9c0be59-ab64-4b33-8f03-26bd93aab48e",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/30/2020", "10:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "ad23b7ab-3357-4f0d-a134-25d7ed235ef6",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/27/2020", "12:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "ad3fe353-dca7-4fcd-bc8c-9badbaf1e811",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "5/1/2020", "5:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "b25e331b-eb1f-4e56-8edb-a848c019eba0",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/29/2020", "4:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "b6b2c675-d629-4f0f-ae26-d0a9a23983e1",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "5/1/2020", "17:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "b728d7fe-fa8f-4b97-be85-72a3c2990648",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/26/2020", "16:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "b7b94c44-7346-4448-9030-5883e77047c6",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/30/2020", "13:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "b8429be8-5561-434d-91a8-731a94dbd95f",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/27/2020", "19:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "b9df548d-dde8-4c9d-9124-420e43072641",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/28/2020", "18:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "bcf9d20a-decc-4bb1-ac1e-81a053135c94",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/28/2020", "19:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "c6163527-6edf-43e2-a07b-f4889a37f70e",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "5/1/2020", "6:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "c6a09e5f-f947-4c64-9b18-16aac2afe1b7",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/26/2020", "21:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "c785db64-dedb-42cd-8f7a-57ade4bc38db",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/26/2020", "14:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "c80f93cc-c780-436d-800a-f3ba02aabcdc",
                column: "Date",
                value: "4/30/2020");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "d2f88961-adf9-4089-9198-17e5b4b99c3b",
                column: "Date",
                value: "4/25/2020");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "d464a27a-e837-4ea1-8881-77323dae42eb",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/25/2020", "21:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "d859c610-740e-4955-878b-06fe614a1998",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/29/2020", "14:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "d98821de-b8fd-4945-8c06-c912d2cb940a",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/30/2020", "10:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "db2ea23f-e7ce-423e-9bc2-257b2c061d04",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/28/2020", "13:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "e0d1c58d-1db0-4705-b3cb-94e6c861737c",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/26/2020", "14:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "e4ed83ca-81a4-4ea0-a7ef-5e4062faa9fa",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/26/2020", "4:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "e67e8d98-37a8-4310-b51c-d2b2f4c5210f",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/29/2020", "22:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "e9c1a622-520c-4d6e-9447-12fd2523d40c",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/27/2020", "12:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "eacf5f01-e97f-412e-9ae0-a627b999bdeb",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/25/2020", "7:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "ef0f138d-b306-4983-a873-1222342b4368",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "5/1/2020", "5:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "ef8b3693-e048-4782-9c25-22456b5230b7",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/27/2020", "12:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "f0a03776-87cf-47b5-9a6c-679d0906d87e",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/30/2020", "2:00" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "f1a264a5-045c-4107-9ef6-8ca65d7df47c",
                column: "Date",
                value: "4/27/2020");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "f288ec62-9915-412a-8e2f-a7555e60bc49",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/29/2020", "21:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "f563fb50-26da-4a57-9bcd-b3836614835a",
                column: "Date",
                value: "4/28/2020");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "f56de32e-a8d4-495b-99dc-a3867d7408f0",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "5/1/2020", "12:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "f6a55375-3743-4528-8ac4-8ba93e9ba017",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/26/2020", "19:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "f6f1670a-4eba-4d98-85f6-d4c1d37a7dec",
                column: "Date",
                value: "4/26/2020");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "f7c4ec9d-e923-4d28-8918-ac842efc24e5",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/28/2020", "11:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "f974f0ce-ad88-4ca0-8e1e-a0f235ebe2fd",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/28/2020", "9:30" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "fa858d18-c031-4a4d-8700-7b46f21109f4",
                columns: new[] { "Date", "PlayTime" },
                values: new object[] { "4/28/2020", "22:45" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "fd8e5615-28bc-4996-8651-0ff52f15362d",
                column: "Date",
                value: "4/27/2020");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Repertoires");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "0002ce82-5bf2-4b33-9d69-6c4c3f09f36a",
                column: "PlayTime",
                value: "7:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "00b4ebea-8f60-43c9-b1ff-091053e4f744",
                column: "PlayTime",
                value: "19:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "067273f1-2931-4cf5-9f0f-0893fa7ec83e",
                column: "PlayTime",
                value: "9:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "0b1177fe-0733-42e8-a8c5-35ad8039a14e",
                column: "PlayTime",
                value: "1:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "12c891d0-3a9c-40b0-93a1-e56ce23c15dd",
                column: "PlayTime",
                value: "16:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "1367d782-f24e-4985-978d-825515f40bee",
                column: "PlayTime",
                value: "0:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "14705128-16f3-4e28-8f2b-63465d15a49c",
                column: "PlayTime",
                value: "5:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "149d67fb-796f-489b-bbe2-993073b66bc6",
                column: "PlayTime",
                value: "10:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "17738e0f-d311-4003-b6c2-7a8bfe733e20",
                column: "PlayTime",
                value: "6:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "18c4b1be-0ef2-403e-a670-fe010a670db1",
                column: "PlayTime",
                value: "5:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "18f8b880-1231-4028-9eb6-998e94b62b9b",
                column: "PlayTime",
                value: "6:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "1bbd4048-bbf7-4269-a4a1-bf0510fd18db",
                column: "PlayTime",
                value: "3:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "1c6173eb-e01b-4a87-8f1c-18f0fb6f4a54",
                column: "PlayTime",
                value: "1:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "1dd5a479-a903-426e-9880-4eeef60b69f8",
                column: "PlayTime",
                value: "1:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "2128363b-df77-4459-85aa-2beaf899ec4c",
                column: "PlayTime",
                value: "5:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "2339db48-b2bc-481d-9d78-ebb9e32f433d",
                column: "PlayTime",
                value: "20:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "23fc35c2-cd81-45be-bf32-b2cb1da3bc34",
                column: "PlayTime",
                value: "22:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "2727ab7e-65a3-437a-a403-c121c87a32bf",
                column: "PlayTime",
                value: "10:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "29fe55f5-1a1f-40ad-8db4-9b6731040db2",
                column: "PlayTime",
                value: "11:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "2a1fccf7-7603-4ba5-b4be-044ed500ea75",
                column: "PlayTime",
                value: "13:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "2a8d4b29-f39b-4812-a219-3f7661842098",
                column: "PlayTime",
                value: "12:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "2ce9ef7b-77f0-49e8-8277-fe90927f3ce7",
                column: "PlayTime",
                value: "7:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "334fb052-927e-43ae-b032-e18de7dd81ce",
                column: "PlayTime",
                value: "3:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "34e641ec-9bea-4383-8e8b-f949aa764e21",
                column: "PlayTime",
                value: "3:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "37b06319-09db-4b97-8f78-98f51f1d8e32",
                column: "PlayTime",
                value: "4:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "3dd1e68e-667c-42b3-bea0-29ffcc30a0e8",
                column: "PlayTime",
                value: "14:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "40e5a01f-34d0-446f-a954-6057150ec540",
                column: "PlayTime",
                value: "17:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "4282c7e6-4904-4a11-83a4-bf5278775272",
                column: "PlayTime",
                value: "19:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "43161eb5-a4a4-455f-b402-fb7d7c73b98a",
                column: "PlayTime",
                value: "12:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "4b0c1825-74c9-4b7c-be7e-42a25038e481",
                column: "PlayTime",
                value: "16:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "4dfd11e5-391a-47be-902c-99620a9eabce",
                column: "PlayTime",
                value: "2:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "4f537a29-4171-4a9e-a3db-9acc950863e2",
                column: "PlayTime",
                value: "5:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "4f8eb2ca-3a70-4920-8de0-5033ed304451",
                column: "PlayTime",
                value: "19:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "524ce530-f997-44da-b118-2c88be728248",
                column: "PlayTime",
                value: "19:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "533a5c82-b0ce-4e4e-afb9-cb23a7940a05",
                column: "PlayTime",
                value: "21:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "5bc15682-2eaa-4baf-86ea-e03db1efe9f1",
                column: "PlayTime",
                value: "2:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "5f37e508-8156-4d8e-9859-d52933a64b12",
                column: "PlayTime",
                value: "1:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "646458e6-6060-4dcc-9118-b14ce4c1fe28",
                column: "PlayTime",
                value: "7:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "661ac04f-8289-4eec-9530-c648264eb9a4",
                column: "PlayTime",
                value: "0:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "66fd7189-cf10-44cc-a4e5-0f16aa07bfb9",
                column: "PlayTime",
                value: "14:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "73e61eb8-e1ef-400f-a6b8-b2e07725dfb2",
                column: "PlayTime",
                value: "14:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "7b0d2ec2-e0ad-4efc-ba04-8d9453fd6353",
                column: "PlayTime",
                value: "4:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "7ed80a87-eb47-4249-8ac1-917a0800496c",
                column: "PlayTime",
                value: "18:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "7fe64e0c-3586-4164-a6b5-e336b032bd4a",
                column: "PlayTime",
                value: "7:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "8040c6f9-f275-4752-9363-6d12069cd828",
                column: "PlayTime",
                value: "2:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "8076031b-7b62-4185-9b15-4ac4466b3437",
                column: "PlayTime",
                value: "2:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "8411a5b7-699f-45d4-ab67-ee3a17338424",
                column: "PlayTime",
                value: "20:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "86d5fad3-0481-4497-9dab-b97a7da4c13c",
                column: "PlayTime",
                value: "21:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "870a16fa-a719-4491-b09a-b06ad652a1d7",
                column: "PlayTime",
                value: "16:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "87950de7-b4a3-430b-add8-57cb2f696aa6",
                column: "PlayTime",
                value: "13:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "8ad3aba2-5caa-40ca-afdb-d62f9253ed01",
                column: "PlayTime",
                value: "12:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "8cf9c962-93ad-429c-9347-6fb6022a1f37",
                column: "PlayTime",
                value: "19:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "8e25c8bb-a4a4-4df7-ab04-e8e2f6452a26",
                column: "PlayTime",
                value: "20:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "907b2948-5efc-48b5-9cfb-3358e376d30e",
                column: "PlayTime",
                value: "0:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "921112c1-f48f-4d06-9ae8-81b8c663fa2a",
                column: "PlayTime",
                value: "17:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "94fa00b6-628c-4a42-a4ca-5e3398dbdbc0",
                column: "PlayTime",
                value: "10:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "9e798f75-e7db-4a9a-a21b-d49cbba34b01",
                column: "PlayTime",
                value: "0:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "9eb6b139-02cc-4be2-b1cf-5d8145f5cfa3",
                column: "PlayTime",
                value: "11:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "a1a5cd9b-768c-44c3-9da7-c159e933da5b",
                column: "PlayTime",
                value: "17:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "a1c414ac-30c6-44fa-84fe-8ed9bba25611",
                column: "PlayTime",
                value: "11:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "a36ce8fb-2240-4440-8fb9-2e09c1a21dba",
                column: "PlayTime",
                value: "3:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "a658c6b0-20fd-43b7-a603-52bee735a01a",
                column: "PlayTime",
                value: "21:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "a82ed5c0-e84a-481a-9c6d-78263c07e6ca",
                column: "PlayTime",
                value: "17:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "a840daac-d9a9-4c16-a48a-043e43247034",
                column: "PlayTime",
                value: "19:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "a9c0be59-ab64-4b33-8f03-26bd93aab48e",
                column: "PlayTime",
                value: "12:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "ad23b7ab-3357-4f0d-a134-25d7ed235ef6",
                column: "PlayTime",
                value: "14:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "ad3fe353-dca7-4fcd-bc8c-9badbaf1e811",
                column: "PlayTime",
                value: "4:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "b25e331b-eb1f-4e56-8edb-a848c019eba0",
                column: "PlayTime",
                value: "1:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "b6b2c675-d629-4f0f-ae26-d0a9a23983e1",
                column: "PlayTime",
                value: "20:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "b728d7fe-fa8f-4b97-be85-72a3c2990648",
                column: "PlayTime",
                value: "18:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "b7b94c44-7346-4448-9030-5883e77047c6",
                column: "PlayTime",
                value: "11:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "b8429be8-5561-434d-91a8-731a94dbd95f",
                column: "PlayTime",
                value: "18:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "b9df548d-dde8-4c9d-9124-420e43072641",
                column: "PlayTime",
                value: "22:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "bcf9d20a-decc-4bb1-ac1e-81a053135c94",
                column: "PlayTime",
                value: "16:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "c6163527-6edf-43e2-a07b-f4889a37f70e",
                column: "PlayTime",
                value: "7:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "c6a09e5f-f947-4c64-9b18-16aac2afe1b7",
                column: "PlayTime",
                value: "17:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "c785db64-dedb-42cd-8f7a-57ade4bc38db",
                column: "PlayTime",
                value: "10:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "d464a27a-e837-4ea1-8881-77323dae42eb",
                column: "PlayTime",
                value: "17:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "d859c610-740e-4955-878b-06fe614a1998",
                column: "PlayTime",
                value: "12:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "d98821de-b8fd-4945-8c06-c912d2cb940a",
                column: "PlayTime",
                value: "14:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "db2ea23f-e7ce-423e-9bc2-257b2c061d04",
                column: "PlayTime",
                value: "11:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "e0d1c58d-1db0-4705-b3cb-94e6c861737c",
                column: "PlayTime",
                value: "10:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "e4ed83ca-81a4-4ea0-a7ef-5e4062faa9fa",
                column: "PlayTime",
                value: "2:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "e67e8d98-37a8-4310-b51c-d2b2f4c5210f",
                column: "PlayTime",
                value: "19:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "e9c1a622-520c-4d6e-9447-12fd2523d40c",
                column: "PlayTime",
                value: "11:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "eacf5f01-e97f-412e-9ae0-a627b999bdeb",
                column: "PlayTime",
                value: "2:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "ef0f138d-b306-4983-a873-1222342b4368",
                column: "PlayTime",
                value: "6:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "ef8b3693-e048-4782-9c25-22456b5230b7",
                column: "PlayTime",
                value: "11:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "f0a03776-87cf-47b5-9a6c-679d0906d87e",
                column: "PlayTime",
                value: "7:00");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "f288ec62-9915-412a-8e2f-a7555e60bc49",
                column: "PlayTime",
                value: "17:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "f56de32e-a8d4-495b-99dc-a3867d7408f0",
                column: "PlayTime",
                value: "9:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "f6a55375-3743-4528-8ac4-8ba93e9ba017",
                column: "PlayTime",
                value: "18:45");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "f7c4ec9d-e923-4d28-8918-ac842efc24e5",
                column: "PlayTime",
                value: "13:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "f974f0ce-ad88-4ca0-8e1e-a0f235ebe2fd",
                column: "PlayTime",
                value: "13:30");

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "Id",
                keyValue: "fa858d18-c031-4a4d-8700-7b46f21109f4",
                column: "PlayTime",
                value: "17:45");
        }
    }
}
