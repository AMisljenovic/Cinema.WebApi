using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations.Reservation
{
    public partial class reservations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    RepertoryId = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    SeatRow = table.Column<int>(nullable: false),
                    SeatColumn = table.Column<int>(nullable: false),
                    Date = table.Column<string>(nullable: false),
                    PlayTime = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "Date", "PlayTime", "RepertoryId", "SeatColumn", "SeatRow", "UserId" },
                values: new object[,]
                {
                    { "93daecbb-4d96-4f80-af17-ec17e7dfba33", "21-Jun-20", "9:30", "9eb6b139-02cc-4be2-b1cf-5d8145f5cfa3", 2, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "a5e6c241-88ef-4e55-97f4-43845246d2f9", "18-Jun-20", "0:00", "a36ce8fb-2240-4440-8fb9-2e09c1a21dba", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "8ff4c7dd-f14a-4ce7-ae47-1a89f053f262", "24-Jun-20", "19:45", "4b0c1825-74c9-4b7c-be7e-42a25038e481", 0, 3, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "74642d97-d034-4efe-9da1-124c9b6c7b4c", "24-Jun-20", "11:30", "f974f0ce-ad88-4ca0-8e1e-a0f235ebe2fd", 1, 2, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "87a465c9-5ad3-4e11-90e4-b2ade4d66557", "24-Jun-20", "1:00", "7b0d2ec2-e0ad-4efc-ba04-8d9453fd6353", 3, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "4700586a-881a-4faf-a1a5-337f71c8b6d5", "23-Jun-20", "21:45", "a1a5cd9b-768c-44c3-9da7-c159e933da5b", 3, 2, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "5b434629-5d12-4499-876b-70c6dab7ab61", "23-Jun-20", "14:30", "ad23b7ab-3357-4f0d-a134-25d7ed235ef6", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "b9a2291e-2f2c-4d38-b9e1-4533652871c3", "23-Jun-20", "0:00", "7fe64e0c-3586-4164-a6b5-e336b032bd4a", 2, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "a978ac5a-ee63-4e37-904a-005400456635", "22-Jun-20", "20:45", "c6a09e5f-f947-4c64-9b18-16aac2afe1b7", 2, 1, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "de613f9d-2155-4eee-b8e3-a7c4db81e703", "22-Jun-20", "11:30", "29fe55f5-1a1f-40ad-8db4-9b6731040db2", 3, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "71fede29-4885-4a64-bb17-3a651b3e5f20", "22-Jun-20", "3:00", "e4ed83ca-81a4-4ea0-a7ef-5e4062faa9fa", 1, 2, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "f06a5d18-eb39-4aae-a507-3b4408987ebf", "21-Jun-20", "22:45", "a840daac-d9a9-4c16-a48a-043e43247034", 1, 0, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "180ddf41-2f6c-42f3-b629-c22dcb837234", "21-Jun-20", "9:30", "9fff2c90-0b6f-4974-864c-8f54a86edb4b", 2, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "45197098-1d8c-4963-b839-f0ecbe0aa4cd", "21-Jun-20", "2:00", "eacf5f01-e97f-412e-9ae0-a627b999bdeb", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "69b6603c-ec40-4a61-b577-159311f1964e", "20-Jun-20", "22:45", "7ed80a87-eb47-4249-8ac1-917a0800496c", 3, 2, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "d8b0f6ef-3ba6-4574-b990-ff38987e1b64", "20-Jun-20", "14:30", "f56de32e-a8d4-495b-99dc-a3867d7408f0", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "29945117-9667-4b47-b8b0-2b9234b72faa", "20-Jun-20", "1:00", "c6163527-6edf-43e2-a07b-f4889a37f70e", 2, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "9ed2d266-862b-4d30-b396-98455d8bdb3c", "19-Jun-20", "16:45", "a7dd1624-9980-48f4-b73a-56660e673c89", 2, 1, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "921d3260-eb2d-47fe-85ce-d3c5d775fcf4", "19-Jun-20", "14:30", "a9c0be59-ab64-4b33-8f03-26bd93aab48e", 3, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "014fd308-525f-443c-b761-5edf13fd828b", "19-Jun-20", "2:00", "2128363b-df77-4459-85aa-2beaf899ec4c", 1, 2, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "6042395c-3987-40d5-9c33-e3b83cafaca3", "18-Jun-20", "22:45", "23fc35c2-cd81-45be-bf32-b2cb1da3bc34", 1, 0, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "1b424fad-6dfe-41c4-a3f4-c64d6cec4790", "18-Jun-20", "9:30", "149d67fb-796f-489b-bbe2-993073b66bc6", 2, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "638f1432-3148-4b05-b58a-aaca15c09fbd", "18-Jun-20", "3:00", "1bbd4048-bbf7-4269-a4a1-bf0510fd18db", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "570858aa-1965-4283-b16c-ea6ed7b173e7", "24-Jun-20", "17:45", "fa858d18-c031-4a4d-8700-7b46f21109f4", 0, 3, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "78b71410-7a14-4ed5-9fec-b95d6e0eb909", "24-Jun-20", "13:30", "f7c4ec9d-e923-4d28-8918-ac842efc24e5", 1, 2, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "4c49a65c-5c1d-43c4-a6a1-73331f11f10d", "24-Jun-20", "3:00", "661ac04f-8289-4eec-9530-c648264eb9a4", 3, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "a63d0a00-52df-477a-8ace-ce4708320798", "23-Jun-20", "21:45", "2339db48-b2bc-481d-9d78-ebb9e32f433d", 3, 2, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "b2dc91e5-7803-4fc5-971d-fd39486ecadd", "23-Jun-20", "9:30", "067273f1-2931-4cf5-9f0f-0893fa7ec83e", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "32a38324-7c15-4c6a-bc3a-97bbd180ca1d", "18-Jun-20", "13:30", "d859c610-740e-4955-878b-06fe614a1998", 2, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "55173ba9-2b39-4d0b-9b4d-17c347d1331c", "23-Jun-20", "1:00", "17738e0f-d311-4003-b6c2-7a8bfe733e20", 2, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "8ff4a700-b5d5-4cbe-bede-55c0e705998d", "18-Jun-20", "22:45", "4282c7e6-4904-4a11-83a4-bf5278775272", 1, 0, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "7faea543-e156-4688-a996-a254f157b39e", "19-Jun-20", "10:30", "a1c414ac-30c6-44fa-84fe-8ed9bba25611", 3, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "d012d627-e79b-428b-a1c2-e9c7327f85f1", "18-Jun-20", "2:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 2, 4, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "949c4ab6-52e3-4546-88a9-2b9fb79e914d", "18-Jun-20", "0:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 1, 4, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "7c4120c2-663a-48f3-9b58-095480e01ebd", "18-Jun-20", "1:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 0, 4, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "783f26ba-4f55-41ea-bde2-ea7a07af890b", "18-Jun-20", "0:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 4, 3, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "8773b48b-66dc-4175-8247-90c620252369", "18-Jun-20", "7:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 3, 3, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "df00d7e3-791a-4d60-b782-133cdbfd1189", "18-Jun-20", "2:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 2, 3, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "4ac957f1-c531-4301-9729-d463657e8ce8", "18-Jun-20", "5:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 1, 3, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "81286a49-2737-4bd1-b67d-e0b2197b28bc", "18-Jun-20", "0:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 0, 3, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "8b74d61d-199f-41d7-9e51-25fd95a45d75", "18-Jun-20", "0:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 4, 2, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "6cca94aa-05b3-4fb1-a53a-cf65f580a2e7", "18-Jun-20", "1:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 3, 2, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "f8de561b-8f3e-4e40-a9d0-db311be0c13a", "18-Jun-20", "4:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 2, 2, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "63ae4b76-e8a7-4f61-aa22-aac692fed17b", "18-Jun-20", "0:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 1, 2, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "6ffd2e06-9331-4779-ab22-28f0b4989c51", "18-Jun-20", "2:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 0, 2, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "56c2c6c1-bcd4-46cf-b087-8a59fdd269b7", "18-Jun-20", "2:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 4, 1, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "7fb4f576-4941-4dc8-9a43-36cc27708cf1", "18-Jun-20", "1:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 3, 1, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "7f80b2ac-d93d-4f42-b9fa-59aec29e69d5", "18-Jun-20", "1:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 2, 1, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "12abf993-20af-4b00-8f46-38a57e74fa2b", "18-Jun-20", "5:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 1, 1, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "5effc7bb-93e0-4f70-9d92-ce8c90886829", "18-Jun-20", "5:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 0, 1, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "679c463b-293d-4a02-9a1b-8d07997e71b5", "18-Jun-20", "0:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 4, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "af1c330e-95b9-41c5-b0d8-ef7bdd265f2b", "18-Jun-20", "2:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 3, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "b39be881-dba3-480a-a433-b94c54214259", "18-Jun-20", "4:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 2, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "867e971b-3071-46b3-844e-e8e942664dcb", "18-Jun-20", "3:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 1, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "8b2fed32-37b2-4d10-88f3-3f0088182036", "18-Jun-20", "0:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 0, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "e7a65865-20c5-460c-94e7-41ef047b5cbc", "20-Jun-20", "21:45", "921112c1-f48f-4d06-9ae8-81b8c663fa2a", 3, 2, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "4801784d-28d9-457f-a4f7-987a53e4d4d1", "20-Jun-20", "9:30", "43161eb5-a4a4-455f-b402-fb7d7c73b98a", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "14a4841f-780b-4767-a421-f8cee46628e9", "20-Jun-20", "4:00", "0002ce82-5bf2-4b33-9d69-6c4c3f09f36a", 2, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "aa89cc37-f61f-490a-a79d-a2da991430b1", "19-Jun-20", "22:45", "8cf9c962-93ad-429c-9347-6fb6022a1f37", 2, 1, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "3be405fa-ed92-4c1b-8869-bafca7ed87a3", "19-Jun-20", "0:00", "646458e6-6060-4dcc-9118-b14ce4c1fe28", 1, 2, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "6f754279-7c67-4a33-afb9-9420fe3435e3", "18-Jun-20", "2:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 3, 4, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "aacb40d6-39df-4bbf-a055-2198a0b3ceb4", "22-Jun-20", "19:45", "f6a55375-3743-4528-8ac4-8ba93e9ba017", 2, 1, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "2d92c05c-1e81-43ea-bd8e-5f1b57583af1", "22-Jun-20", "1:00", "1dd5a479-a903-426e-9880-4eeef60b69f8", 1, 2, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "e8bfb942-0413-4077-8a56-dc9e5585f0da", "18-Jun-20", "11:30", "2727ab7e-65a3-437a-a403-c121c87a32bf", 2, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "84efbf16-82c0-4c5a-a67d-8c4249e2cd3d", "18-Jun-20", "7:00", "5bc15682-2eaa-4baf-86ea-e03db1efe9f1", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "6bdca5a8-7b94-4364-805e-9960c1f1e479", "24-Jun-20", "16:45", "b9df548d-dde8-4c9d-9124-420e43072641", 0, 3, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "7896ebe9-268b-48d9-bdd5-2a7cf6108712", "24-Jun-20", "10:30", "db2ea23f-e7ce-423e-9bc2-257b2c061d04", 1, 2, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "5154cc70-2696-4743-98c9-64b577383f43", "24-Jun-20", "7:00", "37b06319-09db-4b97-8f78-98f51f1d8e32", 3, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "b67aa509-5696-455e-a11b-1f0a97b8c0a8", "23-Jun-20", "17:45", "a658c6b0-20fd-43b7-a603-52bee735a01a", 3, 2, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "afeb565e-f343-46c4-b7d0-7c9be3f20bde", "23-Jun-20", "12:30", "f1a264a5-045c-4107-9ef6-8ca65d7df47c", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "f982db60-053f-4fcc-b55a-7a9974f683d5", "23-Jun-20", "0:00", "334fb052-927e-43ae-b032-e18de7dd81ce", 2, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "9896da41-b562-4a9f-9fc8-ca13c459930b", "22-Jun-20", "18:45", "40e5a01f-34d0-446f-a954-6057150ec540", 2, 1, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "1f169426-42e6-47ad-b0bd-68efb82e004d", "22-Jun-20", "12:30", "94fa00b6-628c-4a42-a4ca-5e3398dbdbc0", 3, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "2fb72f6f-0584-4257-a5d7-dc66922a5956", "22-Jun-20", "2:00", "5f37e508-8156-4d8e-9859-d52933a64b12", 1, 2, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "efed0277-b35b-44fb-85e9-d968d90702d2", "21-Jun-20", "18:45", "870a16fa-a719-4491-b09a-b06ad652a1d7", 1, 0, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "d751435c-d1a1-43cb-ac88-c6eeb4a5b7c5", "21-Jun-20", "14:30", "d2f88961-adf9-4089-9198-17e5b4b99c3b", 2, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "cd1fdd51-906c-483d-9e57-a50ed19c4679", "21-Jun-20", "2:00", "4f537a29-4171-4a9e-a3db-9acc950863e2", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "249f266a-d563-446c-8d1f-45843bc2200b", "20-Jun-20", "22:45", "b6b2c675-d629-4f0f-ae26-d0a9a23983e1", 3, 2, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "02897beb-0b08-4942-812e-963fc56715be", "20-Jun-20", "13:30", "66fd7189-cf10-44cc-a4e5-0f16aa07bfb9", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "75f792a0-c158-42d1-ae23-922334e39d70", "19-Jun-20", "21:45", "533a5c82-b0ce-4e4e-afb9-cb23a7940a05", 2, 1, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "308bb888-fdf5-47bd-9ec0-3d0daa61b306", "19-Jun-20", "14:30", "d98821de-b8fd-4945-8c06-c912d2cb940a", 3, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "19573143-73c0-4c0a-a6f6-fdf03712386b", "18-Jun-20", "20:45", "f288ec62-9915-412a-8e2f-a7555e60bc49", 1, 0, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "a9082471-7f7e-47a6-bd3b-f94f9215870f", "18-Jun-20", "11:30", "2a8d4b29-f39b-4812-a219-3f7661842098", 2, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "47063bb1-b7f8-425e-9492-48dddd199ae6", "24-Jun-20", "22:45", "bcf9d20a-decc-4bb1-ac1e-81a053135c94", 0, 3, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "e7844e95-89cc-44e6-91f5-ff9dc4fc1feb", "24-Jun-20", "14:30", "3dd1e68e-667c-42b3-bea0-29ffcc30a0e8", 1, 2, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "9b60b82f-cb8a-455a-9b6d-820368c01676", "23-Jun-20", "20:45", "fd8e5615-28bc-4996-8651-0ff52f15362d", 3, 2, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "59d08206-a22d-4c24-927c-9b3b66553890", "23-Jun-20", "10:30", "e9c1a622-520c-4d6e-9447-12fd2523d40c", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "af89a445-df9f-48b6-8045-24ad47176c6e", "22-Jun-20", "16:45", "12c891d0-3a9c-40b0-93a1-e56ce23c15dd", 2, 1, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "e8105d5b-e3cf-4771-b9fc-2b1da99f4fc0", "22-Jun-20", "9:30", "c785db64-dedb-42cd-8f7a-57ade4bc38db", 3, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "c30ecdda-6182-47bf-be1d-84dcfe4e7d6a", "21-Jun-20", "21:45", "d464a27a-e837-4ea1-8881-77323dae42eb", 1, 0, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "a6f591e7-78d3-4a21-89e6-6b412e58c7d1", "18-Jun-20", "21:45", "e67e8d98-37a8-4310-b51c-d2b2f4c5210f", 1, 0, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "a64a5b35-ebd5-46ce-b3b8-076d8f5136ad", "22-Jun-20", "13:30", "f6f1670a-4eba-4d98-85f6-d4c1d37a7dec", 3, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "23078a97-4a7a-4749-a892-ea3b89b6055c", "19-Jun-20", "2:00", "f0a03776-87cf-47b5-9a6c-679d0906d87e", 1, 2, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "43d27260-5e50-4124-9654-3d12eb21430d", "19-Jun-20", "19:45", "8e25c8bb-a4a4-4df7-ab04-e8e2f6452a26", 2, 1, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "efea93c6-2ec6-4de8-95fe-64588a75b57c", "21-Jun-20", "22:45", "4f8eb2ca-3a70-4920-8de0-5033ed304451", 1, 0, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "273e1126-bbf8-45d7-9772-1d6567c70793", "21-Jun-20", "9:30", "8ad3aba2-5caa-40ca-afdb-d62f9253ed01", 2, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "5d30139d-c159-479b-8297-b4fce6705726", "21-Jun-20", "3:00", "2ce9ef7b-77f0-49e8-8277-fe90927f3ce7", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "916bb435-b008-4a93-96e0-232503e81bda", "20-Jun-20", "19:45", "86d5fad3-0481-4497-9dab-b97a7da4c13c", 3, 2, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "7808a060-ebee-49bf-a70d-b8078829ba98", "20-Jun-20", "14:30", "87950de7-b4a3-430b-add8-57cb2f696aa6", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "078a46a2-904c-4c25-adab-691ac801cd4b", "20-Jun-20", "4:00", "ef0f138d-b306-4983-a873-1222342b4368", 2, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "8e2f3b49-7924-40a7-887c-44394e36e4ad", "19-Jun-20", "18:45", "c80f93cc-c780-436d-800a-f3ba02aabcdc", 2, 1, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "ec59fa10-f80e-47fb-b43a-ed21a846b5f7", "19-Jun-20", "9:30", "5417a7e6-e108-48ff-b831-6578c3680a71", 3, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "bd632325-a02c-41a2-a87a-806c80ddb210", "19-Jun-20", "3:00", "1367d782-f24e-4985-978d-825515f40bee", 1, 2, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "f704b331-ef31-4624-a934-37bd41e083bd", "18-Jun-20", "20:45", "524ce530-f997-44da-b118-2c88be728248", 1, 0, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "8d5d8abe-83f8-4239-8c6f-66c70318f620", "18-Jun-20", "13:30", "73e61eb8-e1ef-400f-a6b8-b2e07725dfb2", 2, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "1aa53f06-e8b2-40f2-bbe5-7fa6b23bb378", "18-Jun-20", "4:00", "18f8b880-1231-4028-9eb6-998e94b62b9b", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "25cb1776-2b87-4fd2-b2f1-bbeb80ec290c", "24-Jun-20", "20:45", "8411a5b7-699f-45d4-ab67-ee3a17338424", 0, 3, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "55c841e1-b204-4503-a2d0-21446fdb073a", "24-Jun-20", "10:30", "f563fb50-26da-4a57-9bcd-b3836614835a", 1, 2, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "40c3dfb6-1cda-4c02-89c8-3bd912d591ed", "24-Jun-20", "6:00", "0b1177fe-0733-42e8-a8c5-35ad8039a14e", 3, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "34c31300-f44f-4f7a-b1cf-0e9a0455ee08", "23-Jun-20", "22:45", "b8429be8-5561-434d-91a8-731a94dbd95f", 3, 2, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "3d4aa63e-c2b6-403a-8337-bb6444498fb3", "23-Jun-20", "13:30", "ef8b3693-e048-4782-9c25-22456b5230b7", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "0f3bbc92-705b-43bf-af99-aa6bdc1d1ffc", "23-Jun-20", "1:00", "8040c6f9-f275-4752-9363-6d12069cd828", 2, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "cbd3ac55-1efc-41ba-a02b-ca195b88aeff", "22-Jun-20", "16:45", "b728d7fe-fa8f-4b97-be85-72a3c2990648", 2, 1, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "349f6963-83b4-48bf-b495-313354ece32d", "22-Jun-20", "12:30", "e0d1c58d-1db0-4705-b3cb-94e6c861737c", 3, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "01847531-58a9-48af-b87f-6e8707a0fcfa", "22-Jun-20", "3:00", "14705128-16f3-4e28-8f2b-63465d15a49c", 1, 2, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "64952b34-a3d5-4560-bf71-96af75fb24bc", "21-Jun-20", "16:45", "00b4ebea-8f60-43c9-b1ff-091053e4f744", 1, 0, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "20b6612b-3381-4a4a-990f-41392f406b5e", "21-Jun-20", "14:30", "750b85d6-9ea1-4b66-942c-4e09f432530b", 2, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "f99506ee-e1c6-4160-9e56-b79be3abff25", "21-Jun-20", "1:00", "34e641ec-9bea-4383-8e8b-f949aa764e21", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "d02d576b-394b-48f7-8de4-c9f2006b6e4d", "20-Jun-20", "19:45", "a82ed5c0-e84a-481a-9c6d-78263c07e6ca", 3, 2, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "8138b35c-d4e9-40b6-9dff-189b7a3735c9", "20-Jun-20", "11:30", "2a1fccf7-7603-4ba5-b4be-044ed500ea75", 0, 1, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "6fb79a85-f44d-41fd-a076-ec1028a71e80", "20-Jun-20", "0:00", "ad3fe353-dca7-4fcd-bc8c-9badbaf1e811", 2, 3, "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e" },
                    { "b29325b0-b123-4575-b7fc-a8e5370f7e8a", "19-Jun-20", "14:30", "b7b94c44-7346-4448-9030-5883e77047c6", 3, 0, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" },
                    { "12176f16-fbcc-4cb3-90d7-3715b5995545", "18-Jun-20", "5:00", "18c4b1be-0ef2-403e-a670-fe010a670db1", 4, 4, "fcce9446-45f6-40f9-a8de-8d8ba40aebf9" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RepertoryId_SeatColumn_SeatRow_Date_PlayTime",
                table: "Reservations",
                columns: new[] { "RepertoryId", "SeatColumn", "SeatRow", "Date", "PlayTime" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");
        }
    }
}
