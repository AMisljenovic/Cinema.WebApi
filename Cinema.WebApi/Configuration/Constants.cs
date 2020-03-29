using System;

namespace Cinema.WebApi.Configuration
{
    public static class Constants
    {
        public static Guid[] PlayingMovieIds = new Guid[8] 
        {
            Guid.Parse("31446c42-fa95-4f38-8b8a-c5830649ca32"),
            Guid.Parse("59c58d93-e15b-4d2c-94a2-03e82b82d7c2"),
            Guid.Parse("164ca3af-4b7f-454f-bd07-9b8d6c3736cc"),
            Guid.Parse("13e6d16d-e8a9-4112-a3d0-fda72a846b17"),
            Guid.Parse("1df1dac8-0b73-486e-b1a0-ded9d9d0849c"),
            Guid.Parse("9f855797-11d1-4634-b489-1ae58211ee98"),
            Guid.Parse("22469aab-0419-475e-a64a-ecfc335c7321"),
            Guid.Parse("26ba6b32-be90-443f-8ba2-890f14551457")
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
    }
}
