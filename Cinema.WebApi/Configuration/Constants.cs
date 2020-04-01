using System;

namespace Cinema.WebApi.Configuration
{
    public static class Constants
    {
        public static Guid[] PlayingMovieIds = new Guid[5]
        {
            Guid.Parse("31446c42-fa95-4f38-8b8a-c5830649ca32"),
            Guid.Parse("59c58d93-e15b-4d2c-94a2-03e82b82d7c2"),
            Guid.Parse("164ca3af-4b7f-454f-bd07-9b8d6c3736cc"),
            Guid.Parse("13e6d16d-e8a9-4112-a3d0-fda72a846b17"),
            Guid.Parse("1df1dac8-0b73-486e-b1a0-ded9d9d0849c"),
            //Guid.Parse("9f855797-11d1-4634-b489-1ae58211ee98"),
            //Guid.Parse("22469aab-0419-475e-a64a-ecfc335c7321"),
            //Guid.Parse("26ba6b32-be90-443f-8ba2-890f14551457")
        };

        public static Guid[] AnnouncedMovieIds = new Guid[6]
        {
            Guid.Parse("69e84aef-f2e8-436c-b235-7563ae1cffa2"),
            Guid.Parse("ee79a6c6-c7e6-4ff8-9668-03ebe5134767"),
            Guid.Parse("5480d3f9-0e58-45bd-927c-95fd06cd2753"),
            Guid.Parse("251759f9-a3c5-43d3-9734-39a288f2a461"),
            Guid.Parse("0fe4656a-4598-4f6f-9e7c-3f9347153a10"),
            Guid.Parse("3a1a1424-20d5-469b-b39f-9012da50a71a")
        };

        public static Guid[] HallIds = new Guid[5]
        {
            Guid.Parse("b43eba05-74e4-45ea-bf32-0ca5b8f85003"),
            Guid.Parse("d0cdd288-de39-4a5d-9c7b-aac041e49414"),
            Guid.Parse("5019e093-32fa-42a0-bf18-dfd3724cc853"),
            Guid.Parse("ed5e3547-bf44-437c-8f9f-a94036ae860c"),
            Guid.Parse("01a2f471-b69d-4e68-9924-96e32351ab8d")
        };

        public static Guid[] UserIds = new Guid[4]
        {
            Guid.Parse("2ea08fcd-3b57-43a5-8bcc-37fa8c99533e"),
            Guid.Parse("fcce9446-45f6-40f9-a8de-8d8ba40aebf9"),
            Guid.Parse("a7cb6058-be25-4d4f-8649-0839839a879c"),
            Guid.Parse("03491b89-9e02-422e-a082-9c63c5f10c02")
        };

        public static Guid[,] RepertoryIds = new Guid[5,7]
        {
            {Guid.Parse("988eec28-16b6-4a01-9b01-42c4c46c154a"),Guid.Parse("17fd6d52-88c3-4f2f-9265-ef8acad4dfbf"),Guid.Parse("9939ac87-ad57-40d7-ae40-42dd2ccaa362"),Guid.Parse("027fc860-c53b-426f-92fa-39917ba87dd6"),Guid.Parse("98865c20-c82a-4d79-b89c-b1a682ce0741"),Guid.Parse("75eb97f4-c617-4d23-9aa8-7976922a9eb2"),Guid.Parse("73233417-65ed-444d-a8f6-3e054c9b0a82")},
            {Guid.Parse("6b8806ab-5b35-4d3f-8683-5b84e382eac6"),Guid.Parse("790e99a9-3659-42b6-b1c5-11c415bc165b"),Guid.Parse("af5149a1-3827-4b39-a254-6b1bc23d543f"),Guid.Parse("a685b6b3-af7d-4fd3-a84c-d53f63b8a71e"),Guid.Parse("8b9390b5-55a5-4bf6-aed5-0c894ac1ffd8"),Guid.Parse("c30a2e59-af7e-4443-8e24-473cbd904530"),Guid.Parse("6eed182c-4fe7-4685-992b-3d2ddbf4ecf8")},
            {Guid.Parse("3b55ad13-f4ff-4af2-8bfb-b52cdc81e5a2"),Guid.Parse("3294aef1-77ff-4c64-960b-79298833b329"),Guid.Parse("b57df145-fc1c-4106-b68a-33e3cf367c1e"),Guid.Parse("a480658e-7bff-43f8-bc1e-50cabd2af102"),Guid.Parse("03a24bcc-c587-454d-9b17-bfa0ea56f74e"),Guid.Parse("16c74882-fb74-4811-adac-e4a3942ded2e"),Guid.Parse("104ce451-533f-49f8-bbcd-b67916d2f617")},
            {Guid.Parse("3471724d-c1e9-4e50-8c61-417d2f65e9c8"),Guid.Parse("aab0e823-4a50-41bc-8e19-16f79925172f"),Guid.Parse("77cea3c9-f93a-402b-8417-8a961270685f"),Guid.Parse("550ef24b-fdeb-443e-8b06-c9b04db44601"),Guid.Parse("5b5d036a-dea9-4293-bd50-3095f4af55d5"),Guid.Parse("2f2a94f2-0bc4-4096-acb0-b5f05661eb71"),Guid.Parse("70af2a20-7cb0-4de0-85cb-670062de0ebd")},
            {Guid.Parse("556af0c7-60de-49b7-98c4-6407c416129f"),Guid.Parse("f5ce36a6-ad54-4259-8e14-259c5d076967"),Guid.Parse("a8e0bff2-b4b5-4693-a8c5-8f15aa14ef2c"),Guid.Parse("390fec00-efec-4f87-af6d-51884a87bcab"),Guid.Parse("7db6c863-d6f6-417a-a521-951a9eded5e9"),Guid.Parse("ebc2bdae-b8d4-4c13-a226-ab16eb521d4c"),Guid.Parse("43ef0486-d802-4148-b87b-85d6379f3607")},
        };

        public static int HallRows = 5;
        public static int HallColumns = 5;
    };  
}

