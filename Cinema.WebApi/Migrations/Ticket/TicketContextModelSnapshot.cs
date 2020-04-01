﻿// <auto-generated />
using Cinema.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cinema.WebApi.Migrations.Ticket
{
    [DbContext(typeof(TicketContext))]
    partial class TicketContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cinema.WebApi.Models.Ticket", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RepertoryId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeatColumn")
                        .HasColumnType("int");

                    b.Property<int>("SeatRow")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = "21bf2f2e-19ee-47d7-943c-2efe3f3e581c",
                            RepertoryId = "988eec28-16b6-4a01-9b01-42c4c46c154a",
                            SeatColumn = 1,
                            SeatRow = 0,
                            UserId = "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e"
                        },
                        new
                        {
                            Id = "dd411f03-9297-4848-a80a-db69024a59a3",
                            RepertoryId = "17fd6d52-88c3-4f2f-9265-ef8acad4dfbf",
                            SeatColumn = 3,
                            SeatRow = 0,
                            UserId = "fcce9446-45f6-40f9-a8de-8d8ba40aebf9"
                        },
                        new
                        {
                            Id = "2ba60196-16a2-4fba-bf61-acd271aca7da",
                            RepertoryId = "9939ac87-ad57-40d7-ae40-42dd2ccaa362",
                            SeatColumn = 0,
                            SeatRow = 1,
                            UserId = "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e"
                        },
                        new
                        {
                            Id = "e9c5e775-1edf-43cc-bbd7-05de34dcdc2e",
                            RepertoryId = "027fc860-c53b-426f-92fa-39917ba87dd6",
                            SeatColumn = 1,
                            SeatRow = 0,
                            UserId = "fcce9446-45f6-40f9-a8de-8d8ba40aebf9"
                        },
                        new
                        {
                            Id = "4cfa8c36-3ed5-4ce4-a752-ca531d4e6982",
                            RepertoryId = "98865c20-c82a-4d79-b89c-b1a682ce0741",
                            SeatColumn = 1,
                            SeatRow = 0,
                            UserId = "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e"
                        },
                        new
                        {
                            Id = "b695d561-c906-4ba6-b822-c1c57744ad32",
                            RepertoryId = "75eb97f4-c617-4d23-9aa8-7976922a9eb2",
                            SeatColumn = 0,
                            SeatRow = 2,
                            UserId = "fcce9446-45f6-40f9-a8de-8d8ba40aebf9"
                        },
                        new
                        {
                            Id = "2d811d01-14fb-406a-b4f9-373b5572eb38",
                            RepertoryId = "73233417-65ed-444d-a8f6-3e054c9b0a82",
                            SeatColumn = 2,
                            SeatRow = 1,
                            UserId = "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e"
                        },
                        new
                        {
                            Id = "c06700d6-7d9a-4b08-9eef-85e4070457bb",
                            RepertoryId = "6b8806ab-5b35-4d3f-8683-5b84e382eac6",
                            SeatColumn = 3,
                            SeatRow = 3,
                            UserId = "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e"
                        },
                        new
                        {
                            Id = "5661e316-5c51-43e8-8684-2989a3b6091e",
                            RepertoryId = "790e99a9-3659-42b6-b1c5-11c415bc165b",
                            SeatColumn = 2,
                            SeatRow = 3,
                            UserId = "fcce9446-45f6-40f9-a8de-8d8ba40aebf9"
                        },
                        new
                        {
                            Id = "b5eeb191-3ff1-4f3c-a066-eb992d45c60d",
                            RepertoryId = "af5149a1-3827-4b39-a254-6b1bc23d543f",
                            SeatColumn = 0,
                            SeatRow = 1,
                            UserId = "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e"
                        },
                        new
                        {
                            Id = "28e2a487-0f68-4357-a44c-0a6631b627cd",
                            RepertoryId = "a685b6b3-af7d-4fd3-a84c-d53f63b8a71e",
                            SeatColumn = 3,
                            SeatRow = 3,
                            UserId = "fcce9446-45f6-40f9-a8de-8d8ba40aebf9"
                        },
                        new
                        {
                            Id = "30595af5-8f61-4c84-b0c7-ce6af577aa67",
                            RepertoryId = "8b9390b5-55a5-4bf6-aed5-0c894ac1ffd8",
                            SeatColumn = 2,
                            SeatRow = 3,
                            UserId = "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e"
                        },
                        new
                        {
                            Id = "5b964ab6-d652-477c-b63b-72b7254b3395",
                            RepertoryId = "c30a2e59-af7e-4443-8e24-473cbd904530",
                            SeatColumn = 3,
                            SeatRow = 3,
                            UserId = "fcce9446-45f6-40f9-a8de-8d8ba40aebf9"
                        },
                        new
                        {
                            Id = "a2829917-b2fb-4cc1-835a-6a77317dcff0",
                            RepertoryId = "6eed182c-4fe7-4685-992b-3d2ddbf4ecf8",
                            SeatColumn = 1,
                            SeatRow = 1,
                            UserId = "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e"
                        },
                        new
                        {
                            Id = "38c71260-3494-4153-aeed-a706cbc0c93f",
                            RepertoryId = "3b55ad13-f4ff-4af2-8bfb-b52cdc81e5a2",
                            SeatColumn = 0,
                            SeatRow = 0,
                            UserId = "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e"
                        },
                        new
                        {
                            Id = "71b968fb-079a-4fd0-8689-ffcc8083c06e",
                            RepertoryId = "3294aef1-77ff-4c64-960b-79298833b329",
                            SeatColumn = 1,
                            SeatRow = 0,
                            UserId = "fcce9446-45f6-40f9-a8de-8d8ba40aebf9"
                        },
                        new
                        {
                            Id = "8ec004c4-c871-4d05-8e22-b203addc92f6",
                            RepertoryId = "b57df145-fc1c-4106-b68a-33e3cf367c1e",
                            SeatColumn = 1,
                            SeatRow = 2,
                            UserId = "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e"
                        },
                        new
                        {
                            Id = "1f946c2c-7eca-40fc-98c4-431f13d967cc",
                            RepertoryId = "a480658e-7bff-43f8-bc1e-50cabd2af102",
                            SeatColumn = 1,
                            SeatRow = 2,
                            UserId = "fcce9446-45f6-40f9-a8de-8d8ba40aebf9"
                        },
                        new
                        {
                            Id = "6464c03d-e10d-4049-9183-93f0ec0e0c94",
                            RepertoryId = "03a24bcc-c587-454d-9b17-bfa0ea56f74e",
                            SeatColumn = 0,
                            SeatRow = 1,
                            UserId = "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e"
                        },
                        new
                        {
                            Id = "813eaf19-5d11-4ae0-87d1-8a8250e97197",
                            RepertoryId = "16c74882-fb74-4811-adac-e4a3942ded2e",
                            SeatColumn = 1,
                            SeatRow = 0,
                            UserId = "fcce9446-45f6-40f9-a8de-8d8ba40aebf9"
                        },
                        new
                        {
                            Id = "5baaa130-2b77-4b57-8e02-4724bf345428",
                            RepertoryId = "104ce451-533f-49f8-bbcd-b67916d2f617",
                            SeatColumn = 3,
                            SeatRow = 0,
                            UserId = "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e"
                        },
                        new
                        {
                            Id = "3a27653f-3c72-4346-91b1-8b2caa9198fb",
                            RepertoryId = "3471724d-c1e9-4e50-8c61-417d2f65e9c8",
                            SeatColumn = 0,
                            SeatRow = 1,
                            UserId = "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e"
                        },
                        new
                        {
                            Id = "6c865fc9-dacc-48b4-bf12-af4213ab5e15",
                            RepertoryId = "aab0e823-4a50-41bc-8e19-16f79925172f",
                            SeatColumn = 0,
                            SeatRow = 3,
                            UserId = "fcce9446-45f6-40f9-a8de-8d8ba40aebf9"
                        },
                        new
                        {
                            Id = "c063716c-1add-4dc4-9f51-c8fac9a2f1a5",
                            RepertoryId = "77cea3c9-f93a-402b-8417-8a961270685f",
                            SeatColumn = 2,
                            SeatRow = 1,
                            UserId = "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e"
                        },
                        new
                        {
                            Id = "3f87df47-4d65-4dfa-9262-80653ba10792",
                            RepertoryId = "550ef24b-fdeb-443e-8b06-c9b04db44601",
                            SeatColumn = 2,
                            SeatRow = 2,
                            UserId = "fcce9446-45f6-40f9-a8de-8d8ba40aebf9"
                        },
                        new
                        {
                            Id = "5c32e39d-c28f-44bf-ad8f-79e02a36fc1a",
                            RepertoryId = "5b5d036a-dea9-4293-bd50-3095f4af55d5",
                            SeatColumn = 1,
                            SeatRow = 1,
                            UserId = "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e"
                        },
                        new
                        {
                            Id = "58387d9f-2123-4f02-9e18-7c02fe249a2e",
                            RepertoryId = "2f2a94f2-0bc4-4096-acb0-b5f05661eb71",
                            SeatColumn = 1,
                            SeatRow = 0,
                            UserId = "fcce9446-45f6-40f9-a8de-8d8ba40aebf9"
                        },
                        new
                        {
                            Id = "2ee790f8-a606-42f7-9baf-8ec96fcae3cb",
                            RepertoryId = "70af2a20-7cb0-4de0-85cb-670062de0ebd",
                            SeatColumn = 2,
                            SeatRow = 2,
                            UserId = "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e"
                        },
                        new
                        {
                            Id = "d7ccdf39-2387-4ab5-870e-351a721a0795",
                            RepertoryId = "556af0c7-60de-49b7-98c4-6407c416129f",
                            SeatColumn = 1,
                            SeatRow = 0,
                            UserId = "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e"
                        },
                        new
                        {
                            Id = "bb326d23-710f-48a0-bc90-185a1374a15d",
                            RepertoryId = "f5ce36a6-ad54-4259-8e14-259c5d076967",
                            SeatColumn = 0,
                            SeatRow = 0,
                            UserId = "fcce9446-45f6-40f9-a8de-8d8ba40aebf9"
                        },
                        new
                        {
                            Id = "f9dcd418-e554-4ead-9eff-a7bb5d5bdd4b",
                            RepertoryId = "a8e0bff2-b4b5-4693-a8c5-8f15aa14ef2c",
                            SeatColumn = 0,
                            SeatRow = 3,
                            UserId = "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e"
                        },
                        new
                        {
                            Id = "3fcedd8b-217e-4f2e-b4bf-d0e3015104d3",
                            RepertoryId = "390fec00-efec-4f87-af6d-51884a87bcab",
                            SeatColumn = 3,
                            SeatRow = 0,
                            UserId = "fcce9446-45f6-40f9-a8de-8d8ba40aebf9"
                        },
                        new
                        {
                            Id = "deac4e92-142f-4e90-9976-2486f20b0ebc",
                            RepertoryId = "7db6c863-d6f6-417a-a521-951a9eded5e9",
                            SeatColumn = 2,
                            SeatRow = 3,
                            UserId = "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e"
                        },
                        new
                        {
                            Id = "48ddfbf3-26e4-4302-a8a0-402a4d1c3255",
                            RepertoryId = "ebc2bdae-b8d4-4c13-a226-ab16eb521d4c",
                            SeatColumn = 0,
                            SeatRow = 0,
                            UserId = "fcce9446-45f6-40f9-a8de-8d8ba40aebf9"
                        },
                        new
                        {
                            Id = "9ba4d00d-1c94-4ada-9d56-f529b3167c3f",
                            RepertoryId = "43ef0486-d802-4148-b87b-85d6379f3607",
                            SeatColumn = 0,
                            SeatRow = 1,
                            UserId = "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
