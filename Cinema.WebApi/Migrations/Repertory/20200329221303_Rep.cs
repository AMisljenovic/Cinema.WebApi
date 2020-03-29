using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations.Repertory
{
    public partial class Rep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Repertoires",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    MoveId = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false),
                    AvailableTickets = table.Column<int>(nullable: false),
                    SoldTickets = table.Column<int>(nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Repertoires");
        }
    }
}
