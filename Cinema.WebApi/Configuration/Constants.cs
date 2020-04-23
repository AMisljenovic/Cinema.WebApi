namespace Cinema.WebApi.Configuration
{
    public static class Constants
    {
        public static string[] PlayingMovieIds = new string[5]
        {
            "31446c42-fa95-4f38-8b8a-c5830649ca32",
            "59c58d93-e15b-4d2c-94a2-03e82b82d7c2",
            "164ca3af-4b7f-454f-bd07-9b8d6c3736cc",
            "13e6d16d-e8a9-4112-a3d0-fda72a846b17",
            "1df1dac8-0b73-486e-b1a0-ded9d9d0849c"
        };

        public static string[] AnnouncedMovieIds = new string[6]
        {
            "69e84aef-f2e8-436c-b235-7563ae1cffa2",
            "ee79a6c6-c7e6-4ff8-9668-03ebe5134767",
            "5480d3f9-0e58-45bd-927c-95fd06cd2753",
            "251759f9-a3c5-43d3-9734-39a288f2a461",
            "0fe4656a-4598-4f6f-9e7c-3f9347153a10",
            "3a1a1424-20d5-469b-b39f-9012da50a71a"
        };

        public static string[] HallIds = new string[5]
        {
            "b43eba05-74e4-45ea-bf32-0ca5b8f85003",
            "d0cdd288-de39-4a5d-9c7b-aac041e49414",
            "5019e093-32fa-42a0-bf18-dfd3724cc853",
            "ed5e3547-bf44-437c-8f9f-a94036ae860c",
            "01a2f471-b69d-4e68-9924-96e32351ab8d"
        };

        public static string[] UserIds = new string[4]
        {
            "2ea08fcd-3b57-43a5-8bcc-37fa8c99533e",
            "fcce9446-45f6-40f9-a8de-8d8ba40aebf9",
            "a7cb6058-be25-4d4f-8649-0839839a879c",
            "03491b89-9e02-422e-a082-9c63c5f10c02"
        };

        public static string[, ,] RepertoryIds = new string[5,7,3]
        {
            {{"18c4b1be-0ef2-403e-a670-fe010a670db1","9eb6b139-02cc-4be2-b1cf-5d8145f5cfa3","d464a27a-e837-4ea1-8881-77323dae42eb"},{"4dfd11e5-391a-47be-902c-99620a9eabce","c785db64-dedb-42cd-8f7a-57ade4bc38db","12c891d0-3a9c-40b0-93a1-e56ce23c15dd"},{"1c6173eb-e01b-4a87-8f1c-18f0fb6f4a54","e9c1a622-520c-4d6e-9447-12fd2523d40c","fd8e5615-28bc-4996-8651-0ff52f15362d"},{"9e798f75-e7db-4a9a-a21b-d49cbba34b01","3dd1e68e-667c-42b3-bea0-29ffcc30a0e8","bcf9d20a-decc-4bb1-ac1e-81a053135c94"},{"b25e331b-eb1f-4e56-8edb-a848c019eba0","2a8d4b29-f39b-4812-a219-3f7661842098","f288ec62-9915-412a-8e2f-a7555e60bc49"},{"907b2948-5efc-48b5-9cfb-3358e376d30e","d98821de-b8fd-4945-8c06-c912d2cb940a","533a5c82-b0ce-4e4e-afb9-cb23a7940a05"},{"8076031b-7b62-4185-9b15-4ac4466b3437","66fd7189-cf10-44cc-a4e5-0f16aa07bfb9","b6b2c675-d629-4f0f-ae26-d0a9a23983e1"}},
            {{"4f537a29-4171-4a9e-a3db-9acc950863e2","d2f88961-adf9-4089-9198-17e5b4b99c3b","870a16fa-a719-4491-b09a-b06ad652a1d7"},{"5f37e508-8156-4d8e-9859-d52933a64b12","94fa00b6-628c-4a42-a4ca-5e3398dbdbc0","40e5a01f-34d0-446f-a954-6057150ec540"},{"334fb052-927e-43ae-b032-e18de7dd81ce","f1a264a5-045c-4107-9ef6-8ca65d7df47c","a658c6b0-20fd-43b7-a603-52bee735a01a"},{"37b06319-09db-4b97-8f78-98f51f1d8e32","db2ea23f-e7ce-423e-9bc2-257b2c061d04","b9df548d-dde8-4c9d-9124-420e43072641"},{"5bc15682-2eaa-4baf-86ea-e03db1efe9f1","2727ab7e-65a3-437a-a403-c121c87a32bf","e67e8d98-37a8-4310-b51c-d2b2f4c5210f"},{"f0a03776-87cf-47b5-9a6c-679d0906d87e","b7b94c44-7346-4448-9030-5883e77047c6","8e25c8bb-a4a4-4df7-ab04-e8e2f6452a26"},{"ad3fe353-dca7-4fcd-bc8c-9badbaf1e811","2a1fccf7-7603-4ba5-b4be-044ed500ea75","a82ed5c0-e84a-481a-9c6d-78263c07e6ca"}},
            {{"34e641ec-9bea-4383-8e8b-f949aa764e21","750b85d6-9ea1-4b66-942c-4e09f432530b","00b4ebea-8f60-43c9-b1ff-091053e4f744"},{"14705128-16f3-4e28-8f2b-63465d15a49c","e0d1c58d-1db0-4705-b3cb-94e6c861737c","b728d7fe-fa8f-4b97-be85-72a3c2990648"},{"8040c6f9-f275-4752-9363-6d12069cd828","ef8b3693-e048-4782-9c25-22456b5230b7","b8429be8-5561-434d-91a8-731a94dbd95f"},{"0b1177fe-0733-42e8-a8c5-35ad8039a14e","f563fb50-26da-4a57-9bcd-b3836614835a","8411a5b7-699f-45d4-ab67-ee3a17338424"},{"18f8b880-1231-4028-9eb6-998e94b62b9b","73e61eb8-e1ef-400f-a6b8-b2e07725dfb2","524ce530-f997-44da-b118-2c88be728248"},{"1367d782-f24e-4985-978d-825515f40bee","5417a7e6-e108-48ff-b831-6578c3680a71","c80f93cc-c780-436d-800a-f3ba02aabcdc"},{"ef0f138d-b306-4983-a873-1222342b4368","87950de7-b4a3-430b-add8-57cb2f696aa6","86d5fad3-0481-4497-9dab-b97a7da4c13c"}},
            {{"2ce9ef7b-77f0-49e8-8277-fe90927f3ce7","8ad3aba2-5caa-40ca-afdb-d62f9253ed01","4f8eb2ca-3a70-4920-8de0-5033ed304451"},{"1dd5a479-a903-426e-9880-4eeef60b69f8","f6f1670a-4eba-4d98-85f6-d4c1d37a7dec","f6a55375-3743-4528-8ac4-8ba93e9ba017"},{"17738e0f-d311-4003-b6c2-7a8bfe733e20","067273f1-2931-4cf5-9f0f-0893fa7ec83e","2339db48-b2bc-481d-9d78-ebb9e32f433d"},{"661ac04f-8289-4eec-9530-c648264eb9a4","f7c4ec9d-e923-4d28-8918-ac842efc24e5","fa858d18-c031-4a4d-8700-7b46f21109f4"},{"1bbd4048-bbf7-4269-a4a1-bf0510fd18db","149d67fb-796f-489b-bbe2-993073b66bc6","23fc35c2-cd81-45be-bf32-b2cb1da3bc34"},{"2128363b-df77-4459-85aa-2beaf899ec4c","a9c0be59-ab64-4b33-8f03-26bd93aab48e","a7dd1624-9980-48f4-b73a-56660e673c89"},{"c6163527-6edf-43e2-a07b-f4889a37f70e","f56de32e-a8d4-495b-99dc-a3867d7408f0","7ed80a87-eb47-4249-8ac1-917a0800496c"}},
            {{"eacf5f01-e97f-412e-9ae0-a627b999bdeb","9fff2c90-0b6f-4974-864c-8f54a86edb4b","a840daac-d9a9-4c16-a48a-043e43247034"},{"e4ed83ca-81a4-4ea0-a7ef-5e4062faa9fa","29fe55f5-1a1f-40ad-8db4-9b6731040db2","c6a09e5f-f947-4c64-9b18-16aac2afe1b7"},{"7fe64e0c-3586-4164-a6b5-e336b032bd4a","ad23b7ab-3357-4f0d-a134-25d7ed235ef6","a1a5cd9b-768c-44c3-9da7-c159e933da5b"},{"7b0d2ec2-e0ad-4efc-ba04-8d9453fd6353","f974f0ce-ad88-4ca0-8e1e-a0f235ebe2fd","4b0c1825-74c9-4b7c-be7e-42a25038e481"},{"a36ce8fb-2240-4440-8fb9-2e09c1a21dba","d859c610-740e-4955-878b-06fe614a1998","4282c7e6-4904-4a11-83a4-bf5278775272"},{"646458e6-6060-4dcc-9118-b14ce4c1fe28","a1c414ac-30c6-44fa-84fe-8ed9bba25611","8cf9c962-93ad-429c-9347-6fb6022a1f37"},{"0002ce82-5bf2-4b33-9d69-6c4c3f09f36a","43161eb5-a4a4-455f-b402-fb7d7c73b98a","921112c1-f48f-4d06-9ae8-81b8c663fa2a"}},
        };

        public const int HallRows = 5;
        public const int HallColumns = 5;

        public const string CorsPolicy = "CorsPolicy";

        public const string secretKey = "dG9wU2VjcmV0S2V5ODg4";
    };  
}

