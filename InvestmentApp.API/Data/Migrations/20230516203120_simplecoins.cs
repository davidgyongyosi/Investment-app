using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestmentApp.API.Data.Migrations
{
    public partial class simplecoins : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coins_Deltas_DeltaUid",
                table: "Coins");

            migrationBuilder.DropTable(
                name: "Deltas");

            migrationBuilder.DropIndex(
                name: "IX_Coins_DeltaUid",
                table: "Coins");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "218e23ee-3d3f-44de-9baa-aee9df2e42a5");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "00a58d6a-db90-469d-be95-2185fc17f979");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "00c6c5e0-65e3-4a02-b13d-8a9a8b8b7cb5");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "04fcd875-83ce-4cb3-a564-6a7608d136f3");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "07f2e753-e8fe-498a-a9c9-7d056484b33b");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "0e1825c5-436f-4587-bba6-19ae05485c21");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "103610be-fbeb-4da2-9c2e-6ad4d1a2ee30");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "1071c14a-8aa0-41be-83b6-d9df8a73ab1e");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "11be9958-42d8-4c54-bffb-4c63df994954");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "14ca573d-60b6-4c4f-8a6c-1397f4a02d70");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "1e3b2bac-30ce-4da5-8956-9b3072adc2a3");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "1ffc4b9e-7555-4dcb-85c9-b9758dcc30a8");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "22939949-b883-4730-abd6-2a5a4ac67b26");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "234e3f1a-55c7-43f8-8176-047c8df56edd");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "2481a92b-312a-4e92-8fff-5ebf79fe1b77");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "2b70d1e7-dcaa-4d84-8f3c-a7de732f93a2");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "2bf5f773-15bf-4b23-b371-7ebac84a5f91");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "2f639296-bea3-44d3-9394-8a59e3c3f9b9");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "300666f1-62d4-439f-a0aa-89c2647959c9");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "30c4dd3d-ccc1-4db6-bc7c-d22899b89e10");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "31223c34-d855-4365-a0fb-2603770cc249");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "315a3da5-88c0-4838-a084-f0ca29600ea2");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "31662005-d845-42d3-8de4-11fb800a03f6");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "31b390b0-c875-4fdd-b2ec-8cc241768c1b");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "3a1927d2-b63f-4340-88dd-7b2e0cbdd558");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "3f223f7b-6b11-495f-81e4-723c298ba40b");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "41ba51c1-4c80-4cf0-b880-54c4c1bb91de");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "42563122-c15e-425d-952a-53052dc52b54");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "47219fe2-c8e4-4816-ac5f-f83188ff758b");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "474096f6-7211-4df4-8fa2-b9a011aff8c5");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "493c3449-4953-4d0c-ac6d-6cedee4d4114");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "4a57977d-4018-4e3d-9212-5409a54ab163");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "4bc4ea90-4150-4a98-87bd-48f04328711e");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "4c8535ff-10a9-469f-a8b5-388761f6d3ce");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "5ea1414e-0f0d-4b47-8d3a-64583882cc7e");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "65434590-0a8c-428c-84a5-b2046ee5cc35");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "6d0a301b-6fd8-485d-9db8-f8ce68d75461");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "6d6a5712-ad52-4eb2-bc6a-3353be0f838f");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "6e5a3ce2-cce6-4534-8e7b-419518953044");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "73ccf66c-ea37-4b49-a60e-36f97ec96cd8");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "7451991a-70c3-4ae1-b4e4-4badf6821921");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "74d0d929-3ced-40f4-85a6-0a9c4409a5b0");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "79d8b7f8-ea13-4058-8f6d-778ed96fbaac");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "7b912c80-b60d-4b52-be48-06c0daadc1a6");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "7c555c3d-1ec9-4197-bd9a-d251b243cdb0");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "7cb35744-7e15-4103-8b47-f65876e2bc36");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "7f6d2c74-558f-4f02-a029-b1edb550e7f3");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "80a8eb57-07a4-4222-b311-6ef3427a483a");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "82277bd2-505a-4960-af03-f4f403c9f834");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "83020740-e8b7-4f31-aea5-50ee7def810d");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "8390fb64-1022-4f4a-b9ce-e5cc6bccfbf6");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "839d67ad-8fbc-47a3-a86f-7c3b4180518f");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "8427ec50-7adc-4df0-8121-71df02589e95");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "869706da-e977-46d6-8fed-e161c873adf2");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "8a4476d9-69f0-4e68-86c7-c41254da77f1");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "8c5cb517-29fe-44b8-a99d-910a345019fa");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "8e87662d-62e9-4b31-8aaf-896b02cb0c21");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "901f4dfc-640b-4dfa-be52-f0841778d984");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "9251d6c6-02b1-407b-909d-4ba410472290");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "9c5872f2-30a2-4a27-b359-03619584b2a3");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "9c7b16f5-871d-4131-8982-087fa62fa693");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "a544a11e-b73b-45d1-be56-a73babe2ff5f");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "ac9fd358-f5fd-4322-87fa-42ab6529b584");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "adbe5b09-3e15-4819-aa75-a21e8093a8f5");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "af3c9047-02c1-4520-ad54-70a4d429299a");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "b5a407a9-24d9-49bf-b813-95e06fe5162c");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "b8a49a7e-b19a-4753-aa69-04b821c34fe9");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "bcf46d2f-f53f-4eb5-a044-7e208a9675f5");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "bfb5a8f0-12a9-4d78-9e0d-abd08f0a9a7f");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c00aff61-4ece-4688-a191-4e027e051cb5");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c1d95bfa-4c76-4bc1-88d5-d3b380520927");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c7450992-fb42-466e-a26b-45b94c14050b");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c746516f-c6c5-4ab5-b8df-3e3847866cd1");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c7bcc84b-19c7-4552-a8f2-45b587d89cd2");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c8e63c08-04d0-4267-8cc8-2b13d949f840");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c98145cc-c09b-46fd-8770-4098a8dbf611");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "cb1537ce-9308-4638-9d9d-6e32924ba218");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "cb608feb-add4-49b4-a4f7-6bfeebf7b0fe");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "cb9f0331-31ac-41c5-99a5-3ff576a68e9c");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "cdc1eca2-ea4f-44a1-8c12-3a586542e5c7");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "cfded66e-11d7-4563-94a3-e96c09c2977f");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "d19e8060-4f26-4343-9878-3182f5001589");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "d322cc74-f36c-4166-bd33-bf19ba9597cd");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "d65e5bcf-50bb-4d3c-8257-82c0908a91c0");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "da5186b8-2de1-4cc3-84fb-5b654c87c359");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "dae5c89b-68e9-4cc3-ae92-cd5f2da45f00");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "dc8a14ae-cb2c-40db-b143-5601085f0734");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "dca12168-a05a-4eaa-8bdd-1e8b03797bcc");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "e014437d-b496-4438-8eac-62a4f8e5013f");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "e36ecd02-b3bd-4f9d-8835-209ee6b7cc10");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "e394644e-0d80-4380-a86f-72177547ccc5");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "e4c1a8d3-7e24-442b-a657-689527b65839");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "e646e0fd-0430-406d-98e6-49c1ea8acba2");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "e6df53c6-4b14-401c-bc81-7130c34f51cc");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "e727bae6-6789-45f0-ad1d-70f86ef2c7cb");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "e852c56a-c479-403c-98b2-8ab79e905290");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "eff1d749-e325-4b49-ac9b-b18f127d0b86");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "f0b30a1c-70c7-4704-b03d-2a72926e1ffc");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "f5852f93-acd1-4cf2-adfb-17e43e6cbc3d");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "fc781058-4c32-4357-b7df-2f2cc5f63830");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "fd00b850-ec2c-4dfc-ac3a-ca709efca421");

            migrationBuilder.DropColumn(
                name: "DeltaUid",
                table: "Coins");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f4417f7f-969e-4665-8ede-c5cf6186d494", 0, "59b33f55-c672-40d6-9dd0-ff67e00d4991", "admin@admin.adm", true, "Super", "User", false, null, null, "SUPERUSER", "AQAAAAEAACcQAAAAEJc7hM2CaGiFFD7KgE8VPnWpmAaBYyHT1Rdrl2QFivdoxrGvwF0yxeHLhCF6/rANNQ==", null, false, null, "831e82c9-37ff-4d7b-9b9e-a8b759e1b6a9", false, "superuser" });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "Uid", "Age", "AllTimeHighUSD", "Cap", "Code", "Name", "Rank", "Rate", "Volume", "png64" },
                values: new object[,]
                {
                    { "0169c8d9-aa3a-4382-860b-3e06f79ad59b", "5213", 68781L, 586709801651L, "BTC", "Bitcoin", 1L, 30328.198749641579, 12110337907L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/btc.png" },
                    { "038a0444-d0b5-40e2-b4fb-9a14378e1877", "590", 3L, 950876060L, "__BIT", "BITDAO", 54L, 0.52140798636966734, 4058412L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/__bit.png" },
                    { "04dd475d-ce79-4ad9-afd8-82745b0c6a94", "693", 60L, 443590805L, "CVX", "Convex Finance", 100L, 5.8113251636007464, 10949452L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/cvx.png" },
                    { "05c907a4-deb0-4b27-a189-250fca78c530", "909", 238L, 2510872731L, "FIL", "Filecoin", 28L, 6.0535867293097585, 132878881L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/fil.png" },
                    { "07882747-08f7-45c9-b185-d2b5cc07eebd", "2035", 53L, 3847806271L, "LINK", "Chainlink", 20L, 7.4411264640052144, 213379211L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/link.png" },
                    { "0792e903-0555-4934-afac-40ea40ff4fbe", "1295", 2222L, 527549554L, "PAXG", "PAX Gold", 91L, 2042.9919540285246, 14703777L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/paxg.png" },
                    { "0dd40887-9493-43eb-b305-d588bb40ab22", "586", 1L, 803419209L, "XRD", "Radix Native Token", 65L, 0.079177929219493154, 16144664L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xrd.png" },
                    { "10053db6-f624-4e45-a6a9-599de8a7a494", "1359", 21L, 549835701L, "RUNE", "THORChain", 87L, 1.6321258352499231, 31640143L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/rune.png" },
                    { "10a2238d-018e-463c-acda-a0da7b8c2f8b", "2051", 4L, 484033579L, "LRC", "Loopring", 94L, 0.36153227169751667, 26078150L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/lrc.png" },
                    { "11efb5c3-3ceb-4afe-84fe-7b3d4501ae81", "847", 3L, 1327911676L, "GRT", "The Graph", 43L, 0.15024820642818762, 63528779L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/grt.png" },
                    { "123bd1b6-1d5f-4759-88ca-87f97be26f34", "975", 14L, 2194180620L, "SRM", "Serum", 29L, 0.21594670202632751, 57598923L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/srm.png" },
                    { "198b6cfa-c0fc-450e-ad0e-63f82c356b5d", "1610", 491L, 700363684L, "BSV", "Bitcoin SV", 73L, 36.352170713002614, 13024930L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/bsv.png" },
                    { "1a12cfa4-3e0c-4291-b822-272c0db9e4e9", "1301", 1L, 6753399417L, "BUSD", "Binance USD", 15L, 1.0019091540080731, 2131249600L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/busd.png" },
                    { "1bf1939f-82c7-4646-99b8-dee16e222eb4", "2129", 6L, 617694856L, "MIOTA", "IOTA", 82L, 0.22222994285848705, 5754165L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/miota.png" },
                    { "1d2ccb4a-4daa-4a0c-a3f9-fe372a8228aa", "618", 11L, 454317232L, "OSMO", "Osmosis", 96L, 0.80657164263503145, 10831520L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/osmo.png" },
                    { "1dada382-fc31-43f6-9873-a759b408c2ff", "1198", 3L, 1204098652L, "_STX", "Stacks", 47L, 0.87687742582793438, 121602900L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/_stx.png" },
                    { "20342bf1-21fe-4b6a-8855-6f6836cce96e", "1445", 3L, 10422239560L, "MATIC", "Polygon", 10L, 1.1304598432321304, 277086510L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/matic.png" },
                    { "206b78c6-f0f8-4ccc-b7f0-38df759213c5", "1372", 1L, 699581929L, "CHZ", "Chiliz", 74L, 0.13090821005850312, 79719095L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/chz.png" },
                    { "216736bf-56c3-4813-b61d-8f284f4adfe3", "900", 20L, 1941871015L, "NEAR", "NEAR Protocol", 32L, 2.1966128181102982, 176283114L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/near.png" },
                    { "227b2e47-628f-4fd8-b112-2f14a8f7913f", "799", 0L, 6529338418L, "SHIB", "Shiba Inu", 16L, 1.1079815049231357E-05, 177337714L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/shib.png" },
                    { "239dc9ae-c859-4f3c-98e9-4ec3c2ffacd5", "727", 188L, 694182713L, "MINA", "Mina Protocol", 75L, 0.78559999246932066, 48803309L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/mina.png" },
                    { "2623f19b-61f8-4b8f-92d5-2853ea9d3bb1", "2264", 6299L, 730593589L, "MKR", "Maker", 69L, 747.31017008504386, 32172507L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/mkr.png" },
                    { "2c7d4693-6d95-49f0-8780-3c847c2c6cdf", "970", 7L, 825120005L, "CRV", "Curve DAO Token", 63L, 1.0631347154224129, 50675677L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/crv.png" },
                    { "2d0457ba-a1ea-4195-bbf0-09fdff34864e", "176", 20L, 1594170040L, "APT", "Aptos", 37L, 12.262846463104303, 310152845L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/apt.png" },
                    { "2d499fcf-0a52-4a59-8a1d-386421dbde88", "916", 44L, 677474395L, "CAKE", "PancakeSwap", 76L, 3.6559057060612723, 52025532L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/cake.png" },
                    { "347040da-120d-41c7-8fd5-6a46bdb077d0", "1419", 0L, 451724888L, "RSR", "Reserve Rights", 97L, 0.0045180395383625487, 10588914L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/rsr.png" },
                    { "35636325-f16d-45c8-b8b5-50e86ba964e4", "1658", 1L, 928656143L, "USDP", "Pax Dollar", 55L, 0.99880958981750056, 423611L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/usdp.png" },
                    { "3933792c-0eae-46f3-8c3a-a2b23019ca95", "392", 27L, 1651519237L, "APE", "ApeCoin", 35L, 4.4805947930215595, 197598811L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ape.png" },
                    { "3d6495c1-0a6a-44f5-ae71-23c5a9d10dc7", "933", 146L, 6153496756L, "AVAX", "Avalanche", 17L, 18.864857950030537, 273147965L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/avax.png" },
                    { "426d4b9a-9d8d-4883-9589-80ed5dddace0", "911", 663L, 1160144987L, "AAVE", "Aave", 48L, 80.770928125200655, 90749892L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/aave.png" },
                    { "4968bddf-4553-41b1-9b86-be185f98da7f", "706", 40L, 483242748L, "CSPR", "Casper Network", 95L, 0.044268223688168698, 7331958L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/cspr.png" },
                    { "5143ec1f-c058-4f46-afd5-ba6a9a2c552c", "702", 495L, 1650816962L, "ICP", "Internet Computer", 36L, 5.4603279459398069, 44688712L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/icp.png" },
                    { "53a5caf4-79db-4faf-af7b-5d1e47252e11", "2356", 2218L, 728613411L, "ZEC", "Zcash", 71L, 44.622822872541775, 67990465L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/zec.png" },
                    { "5480de55-8576-4077-ae04-7bb0c2e19754", "3282", 517L, 2966640940L, "XMR", "Monero", 23L, 162.41889788396699, 70093418L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xmr.png" },
                    { "54e83eba-bbbe-4675-bec6-590b928e6c86", "1198", 9L, 450724496L, "KAVA", "Kava", 98L, 0.94235684969696731, 16450427L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/kava.png" },
                    { "5b6f9c59-6e3d-4b5a-aa84-e0b45cedc926", "2453", 169L, 3128581467L, "ETC", "Ethereum Classic", 22L, 22.275222847304718, 199755588L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/etc.png" },
                    { "5d13c27c-15fc-4bd7-b659-a5bd61328b86", "889", 165L, 1286469629L, "AXS", "Axie Infinity", 45L, 8.7608934428342931, 51937698L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/axs.png" },
                    { "5ed6d1d4-4663-4dd8-a81a-59e9e000a98f", "3172", 1L, 2803651541L, "XLM", "Stellar", 26L, 0.1048605169525406, 51728530L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xlm.png" },
                    { "656bfb89-b9a8-4622-abdf-885116c2530f", "941", 13L, 774577600L, "GT", "Gatechain Token", 68L, 5.4945079961524126, 508581L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/gt.png" },
                    { "69bb41d9-3c41-4cfb-81d8-8bf4ff5e1b78", "804", 42L, 1056339832L, "FLOW", "Flow", 50L, 1.0194362398508712, 23890678L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/flow.png" },
                    { "6a6120b8-dd12-49db-9122-e8d0e352a702", "827", 7L, 2091528832L, "LDO", "Lido DAO", 30L, 2.4161572053155989, 123572048L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ldo.png" }
                });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "Uid", "Age", "AllTimeHighUSD", "Cap", "Code", "Name", "Rank", "Rate", "Volume", "png64" },
                values: new object[,]
                {
                    { "7273f03d-d0f2-4a6e-9214-1e37e300c5e6", "3344", 1642L, 651136662L, "DASH", "Dash", 79L, 57.983550702574263, 65698320L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/dash.png" },
                    { "74bc713d-d3d5-4275-83e4-452a43a93325", "1894", 40L, 779841435L, "HT", "Huobi Token", 67L, 3.8257985724268013, 16402020L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ht.png" },
                    { "75437215-20c9-4fce-9e9d-14ca75579ac9", "1626", 3L, 1297548084L, "FTM", "Fantom", 44L, 0.51061396968355321, 312600111L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ftm.png" },
                    { "798b0b2e-a312-41c4-9b26-0a51765c4220", "2406", 196L, 892570611L, "NEO", "NEO", 57L, 12.36252589362473, 30596279L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/neo.png" },
                    { "7a598784-823a-4e6c-a3cd-3a769f62176d", "1198", 62L, 880725615L, "RPL", "Rocket Pool", 58L, 46.078929767765544, 15099734L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/rpl.png" },
                    { "7dc66db9-8bc4-4220-af50-585749f26159", "1391", 3L, 1575340028L, "ALGO", "Algorand", 38L, 0.21861473534216658, 59994706L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/algo.png" },
                    { "7e5cb3b0-25ca-43c3-b2e5-25d37dbc812e", "903", 25L, 537776849L, "INJ", "Injective Protocol", 88L, 6.7217437819127657, 107047190L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/inj.png" },
                    { "7f3184aa-6784-490b-9b55-586c446466e6", "21", 12L, 5445384888L, "ARB", "Arbitrum", 19L, 1.3548179589002987, 1046271860L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/arb.png" },
                    { "7fcd41e9-be52-4db1-b901-c9ce6f2db390", "1838", 0L, 592646573L, "XDC", "XDC Network", 84L, 0.042856757030258409, 3944111L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xdc.png" },
                    { "810be481-3c1e-4442-a93d-0fbf0cb0d178", "2276", 119L, 828116098L, "LUNC", "Luna Classic", 62L, 0.00012669284582174738, 60224966L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/lunc.png" },
                    { "873576e0-90ad-423c-8bb8-3a13c57b7361", "4120", 4L, 26621449102L, "XRP", "XRP", 6L, 0.51441608174902442, 924923532L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xrp.png" },
                    { "882a48bc-c924-47b7-8f4a-00863f4446f4", "675", 0L, 537254667L, "BABYDOGE", "Baby Doge Coin", 89L, 2.4980008270697834E-09, 10275593L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/babydoge.png" },
                    { "8ae4b52c-ef14-417b-bb83-f5cfe1662541", "1933", 1L, 9349403278L, "DAI", "Dai", 12L, 0.99896975301912971, 145345881L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/dai.png" },
                    { "8bf5cc93-6db8-4ed1-9afb-e9ba73598937", "2112", 692L, 51303060046L, "BNB", "BNB", 4L, 326.31460014781129, 601475322L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/bnb.png" },
                    { "8c31e2b4-20bb-4ce8-96b0-33b256c8f969", null, 15L, 730176154L, "WBT", "WhiteBIT Token", 70L, 4.8137561350336462, 2385277L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/wbt.png" },
                    { "92e50369-cecd-458f-a4cd-517e86406eb5", "2111", 24L, 1394057151L, "EOS", "EOS", 41L, 1.2654443359627325, 164795547L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/eos.png" },
                    { "93733212-4904-4c6e-b418-8821b0260adf", "345", 1L, 718573479L, "USDD", "Decentralized USD", 72L, 0.99068212104553866, 19909392L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/usdd.png" },
                    { "954ab37d-6470-451a-87e9-1286f06f2b2f", "1532", 69231L, 3594285291L, "WBTC", "Wrapped Bitcoin", 21L, 30387.424050003468, 210801018L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/wbtc.png" },
                    { "9578a4ed-070b-48f8-bb29-2dd3558d180b", "1864", 2L, 855538288L, "TUSD", "True USD", 59L, 0.99974566674995036, 56647944L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/tusd.png" },
                    { "9659bfe1-6980-45ea-8eac-8674925120aa", "2019", 3L, 14892005010L, "ADA", "Cardano", 7L, 0.42493925406676497, 400520948L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ada.png" },
                    { "96fc943f-9456-4fbb-95a0-905c5395ecb5", "3405", 1L, 11522625745L, "DOGE", "Dogecoin", 8L, 0.086851280356138386, 580249613L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/doge.png" },
                    { "97193e12-2d24-4972-8833-0abbb4fcaaec", "842", 45L, 646351012L, "FXS", "Frax Share", 81L, 9.0715358525988101, 24544289L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/fxs.png" },
                    { "98071af9-357a-4a9a-9c8f-57a8aaff6367", "1028", 9L, 843087392L, "RNDR", "Render Token", 60L, 1.5876871134321542, 87863143L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/rndr.png" },
                    { "98b848eb-bacb-4472-aba6-7a1fdc6cd460", "2060", 0L, 1835849605L, "VET", "VeChain", 33L, 0.025318171012815527, 41907992L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/vet.png" },
                    { "996deb32-b17c-4212-a07f-8cbd6758d2db", "2376", 44L, 2818399814L, "ATOM", "Cosmos", 25L, 11.815959899295345, 127011892L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/atom.png" },
                    { "9f4110c1-8912-4428-9256-6e7a251609b1", "742", 4L, 780230689L, "_KLAY", "Klaytn", 66L, 0.25288983619249283, 96165252L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/_klay.png" },
                    { "ab943b1c-d2d1-4018-8157-06298228b5fe", "650", 0L, 615081473L, "XEC", "eCash", 83L, 3.1770908082477563E-05, 4034928L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xec.png" },
                    { "abb663c3-3469-49fa-8a10-36005de13815", "767", 4L, 971061789L, "MX", "MX Token", 53L, 2.2210928294677328, 11230083L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/mx.png" },
                    { "ad600520-465d-4196-9c3b-896452d5ff31", "1096", 260L, 9643105628L, "SOL", "Solana", 11L, 24.622276579457843, 599873521L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/sol.png" },
                    { "b0159e95-53e2-421f-b470-21f2f8dcfb8b", "1586", 29L, 831268461L, "SNX", "Synthetix", 61L, 2.6283183340026004, 48403838L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/snx.png" },
                    { "b277c939-92f5-472c-a088-72cdab86afbe", "842", 2L, 912592048L, "FRAX", "Frax", 56L, 0.99870729767877375, 4632040L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/frax.png" },
                    { "b32d3494-0e2e-4e8f-90a1-a74654d0cd90", "2038", 0L, 6025817589L, "TRX", "TRON", 18L, 0.066335058912063344, 181564796L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/trx.png" },
                    { "b843440f-4d60-42a3-aaaf-4e146f386ab4", "563", 86L, 647976770L, "__GMX", "GMX", 80L, 81.073507988673299, 38651507L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/__gmx.png" },
                    { "b843a92d-f6dd-48a2-ab1c-0ec41b9d78f5", "2034", 6L, 1349697366L, "MANA", "Decentraland", 42L, 0.61540675203591522, 100343643L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/mana.png" },
                    { "bb845e83-ef50-48fc-a3e7-7d079e218552", "1912", 16L, 1074858108L, "THETA", "Theta Network", 49L, 1.0748581079631161, 20049268L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/theta.png" },
                    { "bca4932e-101a-4ed0-9d3a-eb97623a3584", "322", 0L, 583907727L, "KAS", "Kaspa", 86L, 0.032612547915839396, 18569847L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/kas.png" },
                    { "be46aad2-de68-4eda-8726-6c7dc58bc7a4", "4205", 413L, 6867505577L, "LTC", "Litecoin", 14L, 94.466823379278523, 506762508L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ltc.png" },
                    { "c01206d0-1b99-4d25-93a3-8818071705e1", "1839", 9L, 1044099181L, "XTZ", "Tezos", 51L, 1.117674002603652, 13413660L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xtz.png" },
                    { "c1e9a6a0-259c-4df1-a7b8-0a23127922b9", "1532", 0L, 588833375L, "BTT", "BitTorrent", 85L, 6.1889839871637984E-07, 9281947L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/btt.png" },
                    { "c239b40d-2e60-4378-a851-660614315786", "951", 548L, 1036526264L, "EGLD", "MultiversX", 52L, 41.016003940720196, 20727486L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/egld.png" },
                    { "c357517c-9cca-41de-9ac2-c74436f5f834", "1492", 1L, 1742687263L, "CRO", "Cronos", 34L, 0.068981764580794316, 7649509L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/cro.png" },
                    { "c5229aa4-3105-4925-9905-5d6de05b727f", "839", 9L, 443724164L, "1INCH", "1inch", 99L, 0.54478528873423893, 25365079L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/1inch.png" }
                });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "Uid", "Age", "AllTimeHighUSD", "Cap", "Code", "Name", "Rank", "Rate", "Volume", "png64" },
                values: new object[,]
                {
                    { "ca5b3024-be73-4a71-9f04-7092f1da686b", "1291", 1L, 2031619214L, "HBAR", "Hedera Hashgraph", 31L, 0.066320362634824354, 42902466L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/hbar.png" },
                    { "ca69d6d1-a161-447c-ab7b-3b01e883faa5", "938", 45L, 2925381898L, "UNI", "Uniswap", 24L, 6.195608698729786, 99949699L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/uni.png" },
                    { "cd70c475-9025-4202-a3b3-c667a128ef90", "3208", 1L, 80650366506L, "USDT", "Tether", 3L, 1.0008881832810113, 29981592764L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/usdt.png" },
                    { "d695a145-a009-433b-900c-c1e1314c00b0", "316", 3L, 523108103L, "OP", "Optimism", 92L, 2.4359119352872192, 169354388L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/op.png" },
                    { "d9dc8780-eeab-41ad-8655-8254eee33d1b", "884", 2L, 813159667L, "CFX", "Conflux Token", 64L, 0.38767397643673057, 267248994L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/cfx.png" },
                    { "dd335fa4-4a98-48ce-aab9-2b2289c2eb71", "1706", 427L, 1497475701L, "QNT", "Quant", 40L, 124.03778671920671, 22989970L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/qnt.png" },
                    { "df51cae1-e394-4205-9a6b-a7121b6d7071", "1189", 0L, 665049722L, "_SURE", "inSure", 78L, 0.0076776003523308248, 3034637L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/_sure.png" },
                    { "df7c27ba-397d-48ab-bcaf-4266a8bfae66", "1443", 59L, 10454208201L, "OKB", "OKB", 9L, 43.296753238680481, 10300220L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/okb.png" },
                    { "e04f5d05-f762-4944-9217-514938afb000", "524", 9L, 1548206265L, "_IMX", "Immutable X", 39L, 1.1334500380214361, 59935349L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/_imx.png" },
                    { "e63acbec-3dc7-4568-ac14-30b4adb729fc", "1647", 1L, 31890674516L, "USDC", "USD Coin", 5L, 0.99906956237183553, 2131442649L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/usdc.png" },
                    { "ea687a12-4444-4a54-9135-758491cb567e", "2081", 4356L, 2650155454L, "BCH", "Bitcoin Cash", 27L, 136.86199605416891, 70687185L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/bch.png" },
                    { "f00c1b45-b77f-4db5-b732-64626535ed8e", "520", 84L, 532259706L, "ENS", "Ethereum Name Service", 90L, 13.590619143368228, 27588209L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ens.png" },
                    { "f8344790-2bfe-4f7d-8d18-78629252f899", "2814", 4861L, 245902442713L, "ETH", "Ethereum", 2L, 2009.4359257497333, 11770158389L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/eth.png" },
                    { "f86b5501-149a-43c3-a409-caae71563849", "963", 55L, 7216234937L, "DOT", "Polkadot", 13L, 6.5941059350564526, 196136715L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/dot.png" },
                    { "f94d3800-f404-46dc-88f6-dbd9ebe9cda8", "675", 1L, 486891673L, "AGIX", "SingularityNET", 93L, 0.40368364922792982, 65325438L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/agix.png" },
                    { "fbe620f3-cd1a-4add-a90e-6c5db8dc13a4", "970", 8L, 1213382309L, "SAND", "The Sandbox", 46L, 0.6665903180573155, 116041705L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/sand.png" },
                    { "fcf1825a-b59a-45a3-a709-165f63edaa9d", "1996", 28L, 668334731L, "KCS", "KuCoin Shares", 77L, 8.8355279000857276, 1364003L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/kcs.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4417f7f-969e-4665-8ede-c5cf6186d494");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "0169c8d9-aa3a-4382-860b-3e06f79ad59b");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "038a0444-d0b5-40e2-b4fb-9a14378e1877");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "04dd475d-ce79-4ad9-afd8-82745b0c6a94");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "05c907a4-deb0-4b27-a189-250fca78c530");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "07882747-08f7-45c9-b185-d2b5cc07eebd");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "0792e903-0555-4934-afac-40ea40ff4fbe");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "0dd40887-9493-43eb-b305-d588bb40ab22");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "10053db6-f624-4e45-a6a9-599de8a7a494");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "10a2238d-018e-463c-acda-a0da7b8c2f8b");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "11efb5c3-3ceb-4afe-84fe-7b3d4501ae81");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "123bd1b6-1d5f-4759-88ca-87f97be26f34");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "198b6cfa-c0fc-450e-ad0e-63f82c356b5d");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "1a12cfa4-3e0c-4291-b822-272c0db9e4e9");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "1bf1939f-82c7-4646-99b8-dee16e222eb4");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "1d2ccb4a-4daa-4a0c-a3f9-fe372a8228aa");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "1dada382-fc31-43f6-9873-a759b408c2ff");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "20342bf1-21fe-4b6a-8855-6f6836cce96e");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "206b78c6-f0f8-4ccc-b7f0-38df759213c5");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "216736bf-56c3-4813-b61d-8f284f4adfe3");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "227b2e47-628f-4fd8-b112-2f14a8f7913f");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "239dc9ae-c859-4f3c-98e9-4ec3c2ffacd5");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "2623f19b-61f8-4b8f-92d5-2853ea9d3bb1");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "2c7d4693-6d95-49f0-8780-3c847c2c6cdf");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "2d0457ba-a1ea-4195-bbf0-09fdff34864e");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "2d499fcf-0a52-4a59-8a1d-386421dbde88");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "347040da-120d-41c7-8fd5-6a46bdb077d0");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "35636325-f16d-45c8-b8b5-50e86ba964e4");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "3933792c-0eae-46f3-8c3a-a2b23019ca95");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "3d6495c1-0a6a-44f5-ae71-23c5a9d10dc7");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "426d4b9a-9d8d-4883-9589-80ed5dddace0");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "4968bddf-4553-41b1-9b86-be185f98da7f");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "5143ec1f-c058-4f46-afd5-ba6a9a2c552c");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "53a5caf4-79db-4faf-af7b-5d1e47252e11");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "5480de55-8576-4077-ae04-7bb0c2e19754");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "54e83eba-bbbe-4675-bec6-590b928e6c86");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "5b6f9c59-6e3d-4b5a-aa84-e0b45cedc926");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "5d13c27c-15fc-4bd7-b659-a5bd61328b86");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "5ed6d1d4-4663-4dd8-a81a-59e9e000a98f");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "656bfb89-b9a8-4622-abdf-885116c2530f");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "69bb41d9-3c41-4cfb-81d8-8bf4ff5e1b78");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "6a6120b8-dd12-49db-9122-e8d0e352a702");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "7273f03d-d0f2-4a6e-9214-1e37e300c5e6");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "74bc713d-d3d5-4275-83e4-452a43a93325");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "75437215-20c9-4fce-9e9d-14ca75579ac9");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "798b0b2e-a312-41c4-9b26-0a51765c4220");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "7a598784-823a-4e6c-a3cd-3a769f62176d");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "7dc66db9-8bc4-4220-af50-585749f26159");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "7e5cb3b0-25ca-43c3-b2e5-25d37dbc812e");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "7f3184aa-6784-490b-9b55-586c446466e6");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "7fcd41e9-be52-4db1-b901-c9ce6f2db390");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "810be481-3c1e-4442-a93d-0fbf0cb0d178");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "873576e0-90ad-423c-8bb8-3a13c57b7361");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "882a48bc-c924-47b7-8f4a-00863f4446f4");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "8ae4b52c-ef14-417b-bb83-f5cfe1662541");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "8bf5cc93-6db8-4ed1-9afb-e9ba73598937");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "8c31e2b4-20bb-4ce8-96b0-33b256c8f969");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "92e50369-cecd-458f-a4cd-517e86406eb5");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "93733212-4904-4c6e-b418-8821b0260adf");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "954ab37d-6470-451a-87e9-1286f06f2b2f");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "9578a4ed-070b-48f8-bb29-2dd3558d180b");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "9659bfe1-6980-45ea-8eac-8674925120aa");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "96fc943f-9456-4fbb-95a0-905c5395ecb5");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "97193e12-2d24-4972-8833-0abbb4fcaaec");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "98071af9-357a-4a9a-9c8f-57a8aaff6367");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "98b848eb-bacb-4472-aba6-7a1fdc6cd460");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "996deb32-b17c-4212-a07f-8cbd6758d2db");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "9f4110c1-8912-4428-9256-6e7a251609b1");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "ab943b1c-d2d1-4018-8157-06298228b5fe");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "abb663c3-3469-49fa-8a10-36005de13815");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "ad600520-465d-4196-9c3b-896452d5ff31");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "b0159e95-53e2-421f-b470-21f2f8dcfb8b");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "b277c939-92f5-472c-a088-72cdab86afbe");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "b32d3494-0e2e-4e8f-90a1-a74654d0cd90");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "b843440f-4d60-42a3-aaaf-4e146f386ab4");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "b843a92d-f6dd-48a2-ab1c-0ec41b9d78f5");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "bb845e83-ef50-48fc-a3e7-7d079e218552");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "bca4932e-101a-4ed0-9d3a-eb97623a3584");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "be46aad2-de68-4eda-8726-6c7dc58bc7a4");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c01206d0-1b99-4d25-93a3-8818071705e1");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c1e9a6a0-259c-4df1-a7b8-0a23127922b9");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c239b40d-2e60-4378-a851-660614315786");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c357517c-9cca-41de-9ac2-c74436f5f834");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c5229aa4-3105-4925-9905-5d6de05b727f");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "ca5b3024-be73-4a71-9f04-7092f1da686b");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "ca69d6d1-a161-447c-ab7b-3b01e883faa5");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "cd70c475-9025-4202-a3b3-c667a128ef90");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "d695a145-a009-433b-900c-c1e1314c00b0");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "d9dc8780-eeab-41ad-8655-8254eee33d1b");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "dd335fa4-4a98-48ce-aab9-2b2289c2eb71");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "df51cae1-e394-4205-9a6b-a7121b6d7071");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "df7c27ba-397d-48ab-bcaf-4266a8bfae66");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "e04f5d05-f762-4944-9217-514938afb000");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "e63acbec-3dc7-4568-ac14-30b4adb729fc");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "ea687a12-4444-4a54-9135-758491cb567e");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "f00c1b45-b77f-4db5-b732-64626535ed8e");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "f8344790-2bfe-4f7d-8d18-78629252f899");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "f86b5501-149a-43c3-a409-caae71563849");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "f94d3800-f404-46dc-88f6-dbd9ebe9cda8");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "fbe620f3-cd1a-4add-a90e-6c5db8dc13a4");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "fcf1825a-b59a-45a3-a709-165f63edaa9d");

            migrationBuilder.AddColumn<string>(
                name: "DeltaUid",
                table: "Coins",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Deltas",
                columns: table => new
                {
                    Uid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CoinUid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    day = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    month = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quarter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    week = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    year = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deltas", x => x.Uid);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "218e23ee-3d3f-44de-9baa-aee9df2e42a5", 0, "62689340-d729-4aad-89dc-30f98dd3b70a", "admin@admin.adm", true, "Super", "User", false, null, null, "SUPERUSER", "AQAAAAEAACcQAAAAEF6HnkhzI67jzh5QAESxAwqtVN4bGkedTkNXfafKvKRVFL0Xf6YVcwGOwzB10TrkYw==", null, false, null, "7b348183-3190-4791-88c9-159c9c5cbc2b", false, "superuser" });

            migrationBuilder.InsertData(
                table: "Deltas",
                columns: new[] { "Uid", "CoinUid", "day", "hour", "month", "quarter", "week", "year" },
                values: new object[,]
                {
                    { "00558eaf-d093-46a1-a6b6-2eb4f9c000e7", "73ccf66c-ea37-4b49-a60e-36f97ec96cd8", "1.0176", "0.9939", "0.955", "1.0029", "1.0213", "1.0791" },
                    { "0159894d-f6ea-4c7a-87ea-aaaad985dcab", "07f2e753-e8fe-498a-a9c9-7d056484b33b", "1.0434", "0.997", "1.0122", "1.3515", "1.0075", "0.3299" },
                    { "038f2a36-b75c-4c60-8e56-dc150b2b185b", "f5852f93-acd1-4cf2-adfb-17e43e6cbc3d", "1.0076", "0.9966", "1.0795", "0.9665", "1.0318", "0.6951" },
                    { "05ec641e-61c0-488b-b3e3-3e414c5cf197", "83020740-e8b7-4f31-aea5-50ee7def810d", "1.0007", "1.0002", "1.0022", "0.9987", "0.9997", "0.9922" },
                    { "07f1794d-4bae-4082-803d-0e50d6e7fae3", "c8e63c08-04d0-4267-8cc8-2b13d949f840", "1.0199", "0.9991", "0.9522", "1.1834", "1.0472", "0.4535" },
                    { "0a859a5a-07f2-4aa8-ab0c-33f4e612a61c", "493c3449-4953-4d0c-ac6d-6cedee4d4114", "1.0832", "1.0045", "1.059", "1.7174", "1.0047", "1.3894" },
                    { "0b56f6c3-2b6b-45e3-a3b2-722faa9c52dc", "31662005-d845-42d3-8de4-11fb800a03f6", "1.0228", "0.9979", "1.1777", "1.2614", "1.0025", "0.5387" },
                    { "0c0aacf5-4dbe-4340-8502-971cc3231fe2", "ac9fd358-f5fd-4322-87fa-42ab6529b584", "1.0112", "0.993", "1.0818", "1.0524", "1.0714", "0.5822" },
                    { "0d30c542-3d4c-4ec4-a591-680fd1a7de1e", "6e5a3ce2-cce6-4534-8e7b-419518953044", "1.0828", "0.9991", "0.8834", "1.8079", "1.0608", null },
                    { "0ec5a7f3-19b8-4b62-abcf-47d86bbe7963", "7c555c3d-1ec9-4197-bd9a-d251b243cdb0", "1.0256", "0.9901", "1.1881", "1.3504", "1.081", "0.551" },
                    { "10036c21-35a8-4f23-b0b1-6f4ca517f807", "e646e0fd-0430-406d-98e6-49c1ea8acba2", "1.0222", "0.9912", "1.1324", "1.7931", "1.1162", "0.4293" },
                    { "107b0161-a754-4f3d-991f-78990b971e65", "1e3b2bac-30ce-4da5-8956-9b3072adc2a3", "1.0016", "0.9988", "0.9635", "1.1126", "0.9824", "1.0779" },
                    { "13721be0-d666-4373-b67f-6f8a65a2276e", "2481a92b-312a-4e92-8fff-5ebf79fe1b77", "1.0301", "0.9961", "1.1802", "1.4353", "1.1875", "0.2352" },
                    { "151f32c8-4962-4c62-9c88-851e77dbbe2a", "839d67ad-8fbc-47a3-a86f-7c3b4180518f", "1.0103", "1.0006", "0.9076", "0.7213", "1.0622", "0.4108" },
                    { "16ace850-f7d7-42aa-b0e0-fede6b4fd358", "e852c56a-c479-403c-98b2-8ab79e905290", "1.0403", "0.9972", "0.8918", "0.9821", "1.0165", "0.1339" },
                    { "1c6428e2-7f24-4851-a120-36d04d528ba5", "adbe5b09-3e15-4819-aa75-a21e8093a8f5", "1.0012", "0.9999", "1.0001", "0.9998", "0.9992", "0.9967" },
                    { "1f3a6640-0bd3-4ca3-ab6a-4a8de24cf98e", "80a8eb57-07a4-4222-b311-6ef3427a483a", "1.0177", "1.0007", "1.0522", "1.1287", "1.0363", "0.7739" },
                    { "2255564c-ca3c-4693-a722-cb312bdb33f2", "6d0a301b-6fd8-485d-9db8-f8ce68d75461", "1.0729", "0.988", "0.8825", "1.5197", "1.0774", null },
                    { "251329b3-ed57-47c4-9339-bd8bc12dd9ef", "2bf5f773-15bf-4b23-b371-7ebac84a5f91", "1.0192", "0.9945", "1.029", "1.1902", "1.0182", "0.3548" },
                    { "2ae8bf0f-7991-475e-ab4d-3843a274590a", "da5186b8-2de1-4cc3-84fb-5b654c87c359", "1.0093", "0.9999", "1.0657", "1.0741", "1.011", "1.0337" },
                    { "2e263a45-421c-4473-87e9-fe54d38a47d5", "7451991a-70c3-4ae1-b4e4-4badf6821921", "1.001", "1.0008", "0.9991", "0.9991", "1.0005", "1.0002" },
                    { "35937b3e-7fff-44f3-9614-21cc73c31f95", "2f639296-bea3-44d3-9394-8a59e3c3f9b9", "1.0225", "0.9892", "0.8715", "1.3718", "0.979", "0.5173" },
                    { "3d8f3253-5831-45d5-8873-df8d199a2c8d", "c7bcc84b-19c7-4552-a8f2-45b587d89cd2", "1.0014", "1.0002", "1.0008", "0.9982", "0.9995", "1.0006" },
                    { "45d37b36-232f-4a3b-9372-6c93bfacfde2", "7cb35744-7e15-4103-8b47-f65876e2bc36", "1.0644", "0.988", "1.0148", "1.3681", "1.0189", "0.2455" },
                    { "4641b5d4-0a48-4f99-9f66-5f3d4c4c6ae1", "3a1927d2-b63f-4340-88dd-7b2e0cbdd558", "1.0372", "0.994", "1.0597", "1.3917", "1.0605", "0.4696" },
                    { "4659d65c-a599-42a5-be77-9c0cd37f5613", "9c7b16f5-871d-4131-8982-087fa62fa693", "0.9745", "0.9854", "1.1625", "0.9999", "1.0092", "0.2974" },
                    { "46b8179c-f989-4114-94b0-14d9359224a9", "04fcd875-83ce-4cb3-a564-6a7608d136f3", "1.0063", "0.9966", "0.9453", "0.7312", "1.0229", null },
                    { "4866d118-6548-47ee-8b09-a2f093ca42c8", "d65e5bcf-50bb-4d3c-8257-82c0908a91c0", "1.0269", "0.997", "0.7974", "2.6062", "0.9943", "2.7918" },
                    { "48ea2bb2-7ecb-459b-aa65-e88805bd805c", "234e3f1a-55c7-43f8-8176-047c8df56edd", "1.0428", "0.9981", "1.0508", "1.296", "1.0267", "0.4133" },
                    { "4f022314-58c6-4b6b-b906-2b212a617f07", "65434590-0a8c-428c-84a5-b2046ee5cc35", "1.0557", "0.9921", "0.8615", "1.1902", "0.9397", "0.7305" },
                    { "4f89b20a-a82c-45b2-a93a-8a75380cff5e", "cdc1eca2-ea4f-44a1-8c12-3a586542e5c7", "1.0203", "0.9961", "1.1143", "1.0216", "1.0345", "0.1924" },
                    { "4ff2ba26-c775-463c-909d-506b4f5fc7d7", "fd00b850-ec2c-4dfc-ac3a-ca709efca421", "1.02", "0.9931", "0.9194", "1.2462", "0.9764", "0.3547" },
                    { "5160a7e6-bbe2-4184-a5bc-c5fdf74af6e8", "901f4dfc-640b-4dfa-be52-f0841778d984", "1.0072", "1.0015", "0.9582", "1.0328", "0.996", "0.4449" },
                    { "52c649a8-9961-4810-afc5-a88ba58e6b1b", "4a57977d-4018-4e3d-9212-5409a54ab163", "1.0248", "0.9947", "0.885", "1.5859", "1.079", "0.3131" },
                    { "52d08a91-a771-4f6d-8e77-8393a7463435", "7f6d2c74-558f-4f02-a029-b1edb550e7f3", "1.0218", "0.9964", "1.0649", "1.7", "0.9823", "0.5832" },
                    { "53178fdc-0e03-43f1-acf1-1ff966f8a6dd", "8a4476d9-69f0-4e68-86c7-c41254da77f1", "1.0034", "0.9999", "1.1025", "1.2812", "0.9597", null },
                    { "58b34d45-a992-4a30-a654-03e4b7ac1052", "42563122-c15e-425d-952a-53052dc52b54", "1.0014", "1.0009", "0.9975", "1.0103", "1.0027", null },
                    { "5ad89144-e3fc-4eeb-96e7-e27186e4d15e", "869706da-e977-46d6-8fed-e161c873adf2", "1.0145", "0.996", "1.2151", "1.5635", "1.0772", "0.7361" },
                    { "5b65b3f7-8aba-4fac-ab1c-2b6f5318111f", "e36ecd02-b3bd-4f9d-8835-209ee6b7cc10", "1.028", "0.9998", "1.1186", "1.1118", "1.0344", "0.8596" },
                    { "5f8cec04-3b40-4d9a-bce2-3d2eaceba385", "47219fe2-c8e4-4816-ac5f-f83188ff758b", "1.0015", "1.0002", "1.0007", "0.9982", "0.9992", "0.9995" },
                    { "606e7786-1274-4d2c-b2b3-4775d69788da", "dca12168-a05a-4eaa-8bdd-1e8b03797bcc", "1.0013", "1", "0.9985", "1.0005", "0.9995", "0.999" }
                });

            migrationBuilder.InsertData(
                table: "Deltas",
                columns: new[] { "Uid", "CoinUid", "day", "hour", "month", "quarter", "week", "year" },
                values: new object[,]
                {
                    { "60f1fd4c-04f7-442c-b31b-130be32e5ed1", "c98145cc-c09b-46fd-8770-4098a8dbf611", "1.0432", "0.9948", "0.9706", "1.0065", "1.0144", "0.6439" },
                    { "68687eac-a9d6-4f55-b842-77cf9d9b7e96", "dc8a14ae-cb2c-40db-b143-5601085f0734", "1.0507", "0.9978", "1.0774", "1.7127", "1.0186", "2.1172" },
                    { "6bbfb25b-af74-49b3-9936-29d045cfd0cd", "8427ec50-7adc-4df0-8121-71df02589e95", "1.0133", "0.9914", "0.9394", "1.0667", "0.9907", "0.2584" },
                    { "6fa567f2-0658-4a1f-bf1f-e03693ff7987", "bfb5a8f0-12a9-4d78-9e0d-abd08f0a9a7f", "0.9902", "0.996", "1.0202", "1.1787", "1.0906", "0.1296" },
                    { "6fe2d09b-28ab-4df9-99fa-f498ea85076c", "41ba51c1-4c80-4cf0-b880-54c4c1bb91de", "1.0228", "0.9897", "1.2911", "15.2606", "1.0296", "2.2857" },
                    { "76578b06-1074-4ff4-b266-5cb85f7ccb55", "0e1825c5-436f-4587-bba6-19ae05485c21", "1.0311", "0.9942", "0.9478", "1.2353", "1.008", "0.7982" },
                    { "79f684df-d599-4040-b9b8-29bc39a2ef56", "6d6a5712-ad52-4eb2-bc6a-3353be0f838f", "1.0508", "1.0059", "1.2188", "1.2707", "1.1054", "0.4397" },
                    { "7b58d14f-6660-4b34-88d3-251963c08c61", "31223c34-d855-4365-a0fb-2603770cc249", "1.0191", "0.9967", "0.9639", "0.8558", "0.9934", "0.4214" },
                    { "7f2e471a-3d3b-4f8a-aa89-d08115a99b8d", "e727bae6-6789-45f0-ad1d-70f86ef2c7cb", "1.005", "1.0077", "1.59", "4.367", "1.1586", "1.2163" },
                    { "83d10b06-13e4-4482-9d5e-a8054f024f6f", "bcf46d2f-f53f-4eb5-a044-7e208a9675f5", "1.0412", "0.998", "0.8207", "1.2243", "1.0761", "0.2315" },
                    { "84806bc0-92fc-462f-992d-9a60d98d65bc", "00a58d6a-db90-469d-be95-2185fc17f979", "1.0319", "0.9924", "1.0318", "1.1087", "1.036", "0.2338" },
                    { "8ae2020f-274d-41f3-bea1-b21b4ac089af", "c7450992-fb42-466e-a26b-45b94c14050b", "1.028", "0.9948", "1.0465", "1.492", "1.0155", "0.3942" },
                    { "8e733a5c-13d0-4a76-a55d-7f2cd4f7eb9c", "8390fb64-1022-4f4a-b9ce-e5cc6bccfbf6", "1.0151", "0.9963", "1.2169", "1.5697", "1.1228", "0.7389" },
                    { "8f738644-b289-4a6c-9c21-5cb348929709", "c746516f-c6c5-4ab5-b8df-3e3847866cd1", "1.0172", "0.9949", "1.0646", "1.0195", "1.0078", "0.5355" },
                    { "9007bfcb-81d3-4c98-bf15-246c19aa0686", "22939949-b883-4730-abd6-2a5a4ac67b26", "1.0332", "0.9938", "1.0642", "1.1588", "1.0332", "0.5282" },
                    { "9125c9d0-65d5-4668-8676-536d5f093516", "14ca573d-60b6-4c4f-8a6c-1397f4a02d70", "1.032", "0.9933", "1.0428", "1.2469", "1.034", "0.3636" },
                    { "a083cfb9-8c90-4dce-ae6e-1063e988962f", "8e87662d-62e9-4b31-8aaf-896b02cb0c21", "1.002", "0.9984", "0.9554", "1.1226", "1.0073", "0.4407" },
                    { "a0858bc4-6ba9-4b81-a0b3-0f2d5dc4cdb6", "cb1537ce-9308-4638-9d9d-6e32924ba218", "1.0517", "0.9947", "1.1679", "1.4126", "1.0693", "0.6494" },
                    { "a15b53ed-fbe0-476e-aa4c-374739b47745", "315a3da5-88c0-4838-a084-f0ca29600ea2", "1.001", "0.9997", "1.001", "0.9983", "0.9984", "0.999" },
                    { "a39a5753-2f13-4d61-bd2e-c027de699200", "a544a11e-b73b-45d1-be56-a73babe2ff5f", "1.022", "0.9941", "1.0027", "1.2343", "1.0238", "0.2804" },
                    { "a3e3ab66-3f13-4152-b510-998203fa100f", "5ea1414e-0f0d-4b47-8d3a-64583882cc7e", "1.0141", "0.9942", "0.9851", "1.1411", "0.9952", "0.4189" },
                    { "a5be82bb-5871-40d6-8032-215bae3cf996", "300666f1-62d4-439f-a0aa-89c2647959c9", "0.9895", "0.9861", "1.1374", "2.9948", "1.2064", "0.7545" },
                    { "a88992c4-a753-41f3-aca0-b6a1c13e3367", "e6df53c6-4b14-401c-bc81-7130c34f51cc", "1.0494", "0.9959", "0.8899", "0.971", "1.0331", "0.4758" },
                    { "a9efa19a-abc1-4d70-af1c-6e53d9037358", "1071c14a-8aa0-41be-83b6-d9df8a73ab1e", "1.0246", "0.9895", "0.9753", "1.0318", "1.029", "0.9331" },
                    { "ab5cebbe-5226-498f-9b87-b208267fa48b", "d322cc74-f36c-4166-bd33-bf19ba9597cd", "1.0249", "0.9954", "1.0052", "1.057", "1.0236", "0.1803" },
                    { "acada883-db1c-4431-a4e2-b30f46e0cae5", "e394644e-0d80-4380-a86f-72177547ccc5", "1.0162", "0.9976", "0.9458", "0.9821", "0.9948", "0.1641" },
                    { "aff345ef-857e-4907-95fe-ac6c180bc050", "cfded66e-11d7-4563-94a3-e96c09c2977f", "1.0305", "0.9934", "1.0044", "1.2474", "0.9945", "0.3406" },
                    { "aff82e0c-2867-428e-a4fe-f516c2acf275", "d19e8060-4f26-4343-9878-3182f5001589", "0.9213", "1.0092", "0.8233", "1.1073", "1.0584", "0.0859" },
                    { "b3b30456-c655-409d-9477-76a6d58fae2f", "8c5cb517-29fe-44b8-a99d-910a345019fa", "1.0341", "0.9961", "0.8677", "1.4814", "1.0413", "2.1912" },
                    { "b61dcb2e-e130-4d7b-9043-19a651c119a9", "b8a49a7e-b19a-4753-aa69-04b821c34fe9", "0.9813", "0.993", "2.3575", "5.3643", "1.044", null },
                    { "bac02d0b-9c7e-448e-9e54-0f5cc4117935", "103610be-fbeb-4da2-9c2e-6ad4d1a2ee30", "1.056", "0.9995", "1.0552", "1.2429", "1.0179", "0.343" },
                    { "bae169b7-d524-4f06-b9e9-699f1ffa74e1", "fc781058-4c32-4357-b7df-2f2cc5f63830", "0.9791", "0.9855", "0.9011", "3.5057", "1.0514", "0.7247" },
                    { "bb104042-816d-4102-811d-9f260ddd327d", "31b390b0-c875-4fdd-b2ec-8cc241768c1b", "1.0108", "0.9945", "0.9691", "1.2224", "1.1084", "0.3204" },
                    { "bb8e6c14-6c39-4210-9945-0aaa059366e5", "2b70d1e7-dcaa-4d84-8f3c-a7de732f93a2", "1.0247", "0.9905", "0.9683", "2.0002", "1.0255", "0.3914" },
                    { "bee3c9df-9daf-463f-9912-48f5c8496dea", "11be9958-42d8-4c54-bffb-4c63df994954", "1.0047", "0.9991", "0.9117", "0.9117", "0.9975", "0.3257" },
                    { "c0104dbb-110e-4a96-bcaa-3ebb684ee6ae", "79d8b7f8-ea13-4058-8f6d-778ed96fbaac", "1.0337", "0.9961", "1.0162", "0.9273", "1.0669", "0.3514" },
                    { "c2b642da-e3d5-4541-b565-f78dde4fceed", "474096f6-7211-4df4-8fa2-b9a011aff8c5", "1.0417", "1.0008", "0.9789", "1.1153", "1.0062", "0.1731" },
                    { "c2db18d0-948a-4083-a484-5d9cf1396886", "4bc4ea90-4150-4a98-87bd-48f04328711e", "1.0369", "0.997", "1.1888", "2.449", "1.1299", "0.9112" },
                    { "c468f85d-cd2f-4f61-94c2-f40420b73ca5", "82277bd2-505a-4960-af03-f4f403c9f834", "1.0429", "0.9919", "1.0917", "1.1994", "1.0388", "0.2346" },
                    { "c83290a4-2c0a-4457-82f0-de2c1a8a1cc1", "1ffc4b9e-7555-4dcb-85c9-b9758dcc30a8", "1.0075", "0.996", "1.0137", "1.1225", "0.9693", "0.3284" },
                    { "cc655074-18e4-4c51-bc47-0ae51fdbc73a", "eff1d749-e325-4b49-ac9b-b18f127d0b86", "1.0009", "1", "1.0273", "1.5427", "1.0394", "0.8396" },
                    { "d1be4907-e5b2-4c24-8100-5df6648d52a2", "dae5c89b-68e9-4cc3-ae92-cd5f2da45f00", "1.0194", "0.9975", "0.9903", "1.1445", "0.9797", "0.3334" }
                });

            migrationBuilder.InsertData(
                table: "Deltas",
                columns: new[] { "Uid", "CoinUid", "day", "hour", "month", "quarter", "week", "year" },
                values: new object[,]
                {
                    { "d4f971f1-ae40-4491-89f1-be547d20c420", "e4c1a8d3-7e24-442b-a657-689527b65839", "1.0062", "0.9962", "2.3628", "3.5283", "1.0767", "1.211" },
                    { "d5d2e5d8-99db-4107-9832-d120eba6022f", "7b912c80-b60d-4b52-be48-06c0daadc1a6", "1.0198", "0.9914", "0.9879", "1.1483", "1.0075", "0.5478" },
                    { "d9cdf871-770a-4fe1-8dec-161f6013df08", "4c8535ff-10a9-469f-a8b5-388761f6d3ce", "1.0282", "0.9886", "1.0137", "2.3016", "0.9994", "0.9456" },
                    { "db0494de-c3ee-452b-8b50-aeb383f98da1", "b5a407a9-24d9-49bf-b813-95e06fe5162c", "1.032", "0.9985", "1.4135", "1.5832", "1.0594", "0.783" },
                    { "db1a8971-5375-4a83-b4d4-d2729e30a542", "3f223f7b-6b11-495f-81e4-723c298ba40b", "1.0461", "1.0032", "1.0085", "1.371", "0.9351", "0.2871" },
                    { "db3a9d7c-13fc-4603-90fe-7d47cdf2473e", "c00aff61-4ece-4688-a191-4e027e051cb5", "1.0264", "0.9943", "1.009", "1.1468", "1.0095", "0.4609" },
                    { "dc92e992-2855-4864-b4b9-660b006644e3", "f0b30a1c-70c7-4704-b03d-2a72926e1ffc", "1.0697", "0.9897", "0.9781", "1.4846", "1.0533", "0.3198" },
                    { "dd409837-85c2-4595-8761-48277566d520", "af3c9047-02c1-4520-ad54-70a4d429299a", "1.0085", "0.9929", "0.9535", "2.1061", "1.066", "0.6134" },
                    { "e36c9cd3-e20a-4cbb-b1ea-09c53069a574", "30c4dd3d-ccc1-4db6-bc7c-d22899b89e10", "1.3221", "1.0248", "2.0292", "1.9399", "1.6615", "0.6003" },
                    { "e69c3231-f51b-4ae6-87a2-990018e85077", "9251d6c6-02b1-407b-909d-4ba410472290", "1.0633", "0.9944", "0.9839", "1.6174", "1.0956", "0.1982" },
                    { "efebf04d-ba5c-4784-8233-c2f514c0b63c", "74d0d929-3ced-40f4-85a6-0a9c4409a5b0", "1.0526", "0.9945", "1.1633", "1.0759", "0.9539", "0.6201" },
                    { "f2762896-23b2-4b0f-964f-2b2c77bf2202", "e014437d-b496-4438-8eac-62a4f8e5013f", "1.0393", "0.9993", "0.8536", "1.1363", "1.0291", "0.387" },
                    { "f46f4e6b-0e15-4e83-b44f-a5e876823f66", "00c6c5e0-65e3-4a02-b13d-8a9a8b8b7cb5", "1.021", "1.0043", "1.3642", "1.3607", "1.0078", "0.7121" },
                    { "f7a3e71a-53ea-4783-be57-1968d93bd0da", "cb608feb-add4-49b4-a4f7-6bfeebf7b0fe", "1.048", "0.9975", "1.1325", "1.2779", "1.0231", "0.5462" },
                    { "fbc91893-9838-449e-9e1c-0a7f7c62da07", "cb9f0331-31ac-41c5-99a5-3ff576a68e9c", "1.0201", "0.9941", "0.9952", "1.0141", "1.005", "0.2957" },
                    { "ff5ef7c8-0275-4323-8ff3-53548f408d92", "9c5872f2-30a2-4a27-b359-03619584b2a3", "1.1373", "0.9895", null, null, "1.1208", null },
                    { "ff77f15f-eee9-47ee-9e65-025818e185fa", "c1d95bfa-4c76-4bc1-88d5-d3b380520927", "1.0216", "0.995", "1.0224", "1.1148", "1.0365", "0.3999" }
                });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "Uid", "Age", "AllTimeHighUSD", "Cap", "Code", "DeltaUid", "Name", "Rank", "Rate", "Volume", "png64" },
                values: new object[,]
                {
                    { "00a58d6a-db90-469d-be95-2185fc17f979", "970", 8L, 1213382309L, "SAND", "84806bc0-92fc-462f-992d-9a60d98d65bc", "The Sandbox", 46L, 0.6665903180573155, 116041705L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/sand.png" },
                    { "00c6c5e0-65e3-4a02-b13d-8a9a8b8b7cb5", "4120", 4L, 26621449102L, "XRP", "f46f4e6b-0e15-4e83-b44f-a5e876823f66", "XRP", 6L, 0.51441608174902442, 924923532L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xrp.png" },
                    { "04fcd875-83ce-4cb3-a564-6a7608d136f3", "2276", 119L, 828116098L, "LUNC", "46b8179c-f989-4114-94b0-14d9359224a9", "Luna Classic", 62L, 0.00012669284582174738, 60224966L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/lunc.png" },
                    { "07f2e753-e8fe-498a-a9c9-7d056484b33b", "1291", 1L, 2031619214L, "HBAR", "0159894d-f6ea-4c7a-87ea-aaaad985dcab", "Hedera Hashgraph", 31L, 0.066320362634824354, 42902466L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/hbar.png" },
                    { "0e1825c5-436f-4587-bba6-19ae05485c21", "1445", 3L, 10422239560L, "MATIC", "76578b06-1074-4ff4-b266-5cb85f7ccb55", "Polygon", 10L, 1.1304598432321304, 277086510L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/matic.png" },
                    { "103610be-fbeb-4da2-9c2e-6ad4d1a2ee30", "1419", 0L, 451724888L, "RSR", "bac02d0b-9c7e-448e-9e54-0f5cc4117935", "Reserve Rights", 97L, 0.0045180395383625487, 10588914L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/rsr.png" },
                    { "1071c14a-8aa0-41be-83b6-d9df8a73ab1e", "520", 84L, 532259706L, "ENS", "a9efa19a-abc1-4d70-af1c-6e53d9037358", "Ethereum Name Service", 90L, 13.590619143368228, 27588209L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ens.png" },
                    { "11be9958-42d8-4c54-bffb-4c63df994954", "1532", 0L, 588833375L, "BTT", "bee3c9df-9daf-463f-9912-48f5c8496dea", "BitTorrent", 85L, 6.1889839871637984E-07, 9281947L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/btt.png" },
                    { "14ca573d-60b6-4c4f-8a6c-1397f4a02d70", "963", 55L, 7216234937L, "DOT", "9125c9d0-65d5-4668-8676-536d5f093516", "Polkadot", 13L, 6.5941059350564526, 196136715L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/dot.png" },
                    { "1e3b2bac-30ce-4da5-8956-9b3072adc2a3", "2038", 0L, 6025817589L, "TRX", "107b0161-a754-4f3d-991f-78990b971e65", "TRON", 18L, 0.066335058912063344, 181564796L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/trx.png" },
                    { "1ffc4b9e-7555-4dcb-85c9-b9758dcc30a8", "2129", 6L, 617694856L, "MIOTA", "c83290a4-2c0a-4457-82f0-de2c1a8a1cc1", "IOTA", 82L, 0.22222994285848705, 5754165L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/miota.png" },
                    { "22939949-b883-4730-abd6-2a5a4ac67b26", "2035", 53L, 3847806271L, "LINK", "9007bfcb-81d3-4c98-bf15-246c19aa0686", "Chainlink", 20L, 7.4411264640052144, 213379211L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/link.png" },
                    { "234e3f1a-55c7-43f8-8176-047c8df56edd", "2060", 0L, 1835849605L, "VET", "48ea2bb2-7ecb-459b-aa65-e88805bd805c", "VeChain", 33L, 0.025318171012815527, 41907992L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/vet.png" },
                    { "2481a92b-312a-4e92-8fff-5ebf79fe1b77", "1096", 260L, 9643105628L, "SOL", "13721be0-d666-4373-b67f-6f8a65a2276e", "Solana", 11L, 24.622276579457843, 599873521L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/sol.png" },
                    { "2b70d1e7-dcaa-4d84-8f3c-a7de732f93a2", "847", 3L, 1327911676L, "GRT", "bb8e6c14-6c39-4210-9945-0aaa059366e5", "The Graph", 43L, 0.15024820642818762, 63528779L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/grt.png" },
                    { "2bf5f773-15bf-4b23-b371-7ebac84a5f91", "839", 9L, 443724164L, "1INCH", "251329b3-ed57-47c4-9339-bd8bc12dd9ef", "1inch", 99L, 0.54478528873423893, 25365079L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/1inch.png" },
                    { "2f639296-bea3-44d3-9394-8a59e3c3f9b9", "1586", 29L, 831268461L, "SNX", "35937b3e-7fff-44f3-9614-21cc73c31f95", "Synthetix", 61L, 2.6283183340026004, 48403838L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/snx.png" },
                    { "300666f1-62d4-439f-a0aa-89c2647959c9", "1028", 9L, 843087392L, "RNDR", "a5be82bb-5871-40d6-8032-215bae3cf996", "Render Token", 60L, 1.5876871134321542, 87863143L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/rndr.png" },
                    { "30c4dd3d-ccc1-4db6-bc7c-d22899b89e10", "586", 1L, 803419209L, "XRD", "e36c9cd3-e20a-4cbb-b1ea-09c53069a574", "Radix Native Token", 65L, 0.079177929219493154, 16144664L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xrd.png" },
                    { "31223c34-d855-4365-a0fb-2603770cc249", "1610", 491L, 700363684L, "BSV", "7b58d14f-6660-4b34-88d3-251963c08c61", "Bitcoin SV", 73L, 36.352170713002614, 13024930L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/bsv.png" },
                    { "315a3da5-88c0-4838-a084-f0ca29600ea2", "1933", 1L, 9349403278L, "DAI", "a15b53ed-fbe0-476e-aa4c-374739b47745", "Dai", 12L, 0.99896975301912971, 145345881L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/dai.png" },
                    { "31662005-d845-42d3-8de4-11fb800a03f6", "3172", 1L, 2803651541L, "XLM", "0b56f6c3-2b6b-45e3-a3b2-722faa9c52dc", "Stellar", 26L, 0.1048605169525406, 51728530L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xlm.png" },
                    { "31b390b0-c875-4fdd-b2ec-8cc241768c1b", "702", 495L, 1650816962L, "ICP", "bb104042-816d-4102-811d-9f260ddd327d", "Internet Computer", 36L, 5.4603279459398069, 44688712L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/icp.png" },
                    { "3a1927d2-b63f-4340-88dd-7b2e0cbdd558", "970", 7L, 825120005L, "CRV", "4641b5d4-0a48-4f99-9f66-5f3d4c4c6ae1", "Curve DAO Token", 63L, 1.0631347154224129, 50675677L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/crv.png" },
                    { "3f223f7b-6b11-495f-81e4-723c298ba40b", "842", 45L, 646351012L, "FXS", "db1a8971-5375-4a83-b4d4-d2729e30a542", "Frax Share", 81L, 9.0715358525988101, 24544289L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/fxs.png" },
                    { "41ba51c1-4c80-4cf0-b880-54c4c1bb91de", "884", 2L, 813159667L, "CFX", "6fe2d09b-28ab-4df9-99fa-f498ea85076c", "Conflux Token", 64L, 0.38767397643673057, 267248994L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/cfx.png" },
                    { "42563122-c15e-425d-952a-53052dc52b54", "345", 1L, 718573479L, "USDD", "58b34d45-a992-4a30-a654-03e4b7ac1052", "Decentralized USD", 72L, 0.99068212104553866, 19909392L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/usdd.png" },
                    { "47219fe2-c8e4-4816-ac5f-f83188ff758b", "842", 2L, 912592048L, "FRAX", "5f8cec04-3b40-4d9a-bce2-3d2eaceba385", "Frax", 56L, 0.99870729767877375, 4632040L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/frax.png" },
                    { "474096f6-7211-4df4-8fa2-b9a011aff8c5", "804", 42L, 1056339832L, "FLOW", "c2b642da-e3d5-4541-b565-f78dde4fceed", "Flow", 50L, 1.0194362398508712, 23890678L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/flow.png" },
                    { "493c3449-4953-4d0c-ac6d-6cedee4d4114", "1198", 62L, 880725615L, "RPL", "0a859a5a-07f2-4aa8-ab0c-33f4e612a61c", "Rocket Pool", 58L, 46.078929767765544, 15099734L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/rpl.png" },
                    { "4a57977d-4018-4e3d-9212-5409a54ab163", "909", 238L, 2510872731L, "FIL", "52c649a8-9961-4810-afc5-a88ba58e6b1b", "Filecoin", 28L, 6.0535867293097585, 132878881L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/fil.png" },
                    { "4bc4ea90-4150-4a98-87bd-48f04328711e", "767", 4L, 971061789L, "MX", "c2db18d0-948a-4083-a484-5d9cf1396886", "MX Token", 53L, 2.2210928294677328, 11230083L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/mx.png" },
                    { "4c8535ff-10a9-469f-a8b5-388761f6d3ce", "675", 0L, 537254667L, "BABYDOGE", "d9cdf871-770a-4fe1-8dec-161f6013df08", "Baby Doge Coin", 89L, 2.4980008270697834E-09, 10275593L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/babydoge.png" },
                    { "5ea1414e-0f0d-4b47-8d3a-64583882cc7e", "799", 0L, 6529338418L, "SHIB", "a3e3ab66-3f13-4152-b510-998203fa100f", "Shiba Inu", 16L, 1.1079815049231357E-05, 177337714L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/shib.png" },
                    { "65434590-0a8c-428c-84a5-b2046ee5cc35", "827", 7L, 2091528832L, "LDO", "4f022314-58c6-4b6b-b906-2b212a617f07", "Lido DAO", 30L, 2.4161572053155989, 123572048L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ldo.png" },
                    { "6d0a301b-6fd8-485d-9db8-f8ce68d75461", "316", 3L, 523108103L, "OP", "2255564c-ca3c-4693-a722-cb312bdb33f2", "Optimism", 92L, 2.4359119352872192, 169354388L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/op.png" },
                    { "6d6a5712-ad52-4eb2-bc6a-3353be0f838f", "2019", 3L, 14892005010L, "ADA", "79f684df-d599-4040-b9b8-29bc39a2ef56", "Cardano", 7L, 0.42493925406676497, 400520948L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ada.png" },
                    { "6e5a3ce2-cce6-4534-8e7b-419518953044", "176", 20L, 1594170040L, "APT", "0d30c542-3d4c-4ec4-a591-680fd1a7de1e", "Aptos", 37L, 12.262846463104303, 310152845L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/apt.png" },
                    { "73ccf66c-ea37-4b49-a60e-36f97ec96cd8", "1706", 427L, 1497475701L, "QNT", "00558eaf-d093-46a1-a6b6-2eb4f9c000e7", "Quant", 40L, 124.03778671920671, 22989970L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/qnt.png" },
                    { "7451991a-70c3-4ae1-b4e4-4badf6821921", "1658", 1L, 928656143L, "USDP", "2e263a45-421c-4473-87e9-fe54d38a47d5", "Pax Dollar", 55L, 0.99880958981750056, 423611L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/usdp.png" },
                    { "74d0d929-3ced-40f4-85a6-0a9c4409a5b0", "3405", 1L, 11522625745L, "DOGE", "efebf04d-ba5c-4784-8233-c2f514c0b63c", "Dogecoin", 8L, 0.086851280356138386, 580249613L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/doge.png" },
                    { "79d8b7f8-ea13-4058-8f6d-778ed96fbaac", "392", 27L, 1651519237L, "APE", "c0104dbb-110e-4a96-bcaa-3ebb684ee6ae", "ApeCoin", 35L, 4.4805947930215595, 197598811L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ape.png" }
                });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "Uid", "Age", "AllTimeHighUSD", "Cap", "Code", "DeltaUid", "Name", "Rank", "Rate", "Volume", "png64" },
                values: new object[,]
                {
                    { "7b912c80-b60d-4b52-be48-06c0daadc1a6", "3344", 1642L, 651136662L, "DASH", "d5d2e5d8-99db-4107-9832-d120eba6022f", "Dash", 79L, 57.983550702574263, 65698320L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/dash.png" },
                    { "7c555c3d-1ec9-4197-bd9a-d251b243cdb0", "706", 40L, 483242748L, "CSPR", "0ec5a7f3-19b8-4b62-abcf-47d86bbe7963", "Casper Network", 95L, 0.044268223688168698, 7331958L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/cspr.png" },
                    { "7cb35744-7e15-4103-8b47-f65876e2bc36", "742", 4L, 780230689L, "_KLAY", "45d37b36-232f-4a3b-9372-6c93bfacfde2", "Klaytn", 66L, 0.25288983619249283, 96165252L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/_klay.png" },
                    { "7f6d2c74-558f-4f02-a029-b1edb550e7f3", "2406", 196L, 892570611L, "NEO", "52d08a91-a771-4f6d-8e77-8393a7463435", "NEO", 57L, 12.36252589362473, 30596279L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/neo.png" },
                    { "80a8eb57-07a4-4222-b311-6ef3427a483a", "2112", 692L, 51303060046L, "BNB", "1f3a6640-0bd3-4ca3-ab6a-4a8de24cf98e", "BNB", 4L, 326.31460014781129, 601475322L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/bnb.png" },
                    { "82277bd2-505a-4960-af03-f4f403c9f834", "933", 146L, 6153496756L, "AVAX", "c468f85d-cd2f-4f61-94c2-f40420b73ca5", "Avalanche", 17L, 18.864857950030537, 273147965L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/avax.png" },
                    { "83020740-e8b7-4f31-aea5-50ee7def810d", "1301", 1L, 6753399417L, "BUSD", "05ec641e-61c0-488b-b3e3-3e414c5cf197", "Binance USD", 15L, 1.0019091540080731, 2131249600L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/busd.png" },
                    { "8390fb64-1022-4f4a-b9ce-e5cc6bccfbf6", "1532", 69231L, 3594285291L, "WBTC", "8e733a5c-13d0-4a76-a55d-7f2cd4f7eb9c", "Wrapped Bitcoin", 21L, 30387.424050003468, 210801018L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/wbtc.png" },
                    { "839d67ad-8fbc-47a3-a86f-7c3b4180518f", "1894", 40L, 779841435L, "HT", "151f32c8-4962-4c62-9c88-851e77dbbe2a", "Huobi Token", 67L, 3.8257985724268013, 16402020L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ht.png" },
                    { "8427ec50-7adc-4df0-8121-71df02589e95", "951", 548L, 1036526264L, "EGLD", "6bbfb25b-af74-49b3-9936-29d045cfd0cd", "MultiversX", 52L, 41.016003940720196, 20727486L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/egld.png" },
                    { "869706da-e977-46d6-8fed-e161c873adf2", "5213", 68781L, 586709801651L, "BTC", "5ad89144-e3fc-4eeb-96e7-e27186e4d15e", "Bitcoin", 1L, 30328.198749641579, 12110337907L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/btc.png" },
                    { "8a4476d9-69f0-4e68-86c7-c41254da77f1", null, 15L, 730176154L, "WBT", "53178fdc-0e03-43f1-acf1-1ff966f8a6dd", "WhiteBIT Token", 70L, 4.8137561350336462, 2385277L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/wbt.png" },
                    { "8c5cb517-29fe-44b8-a99d-910a345019fa", "1443", 59L, 10454208201L, "OKB", "b3b30456-c655-409d-9477-76a6d58fae2f", "OKB", 9L, 43.296753238680481, 10300220L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/okb.png" },
                    { "8e87662d-62e9-4b31-8aaf-896b02cb0c21", "590", 3L, 950876060L, "__BIT", "a083cfb9-8c90-4dce-ae6e-1063e988962f", "BITDAO", 54L, 0.52140798636966734, 4058412L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/__bit.png" },
                    { "901f4dfc-640b-4dfa-be52-f0841778d984", "916", 44L, 677474395L, "CAKE", "5160a7e6-bbe2-4184-a5bc-c5fdf74af6e8", "PancakeSwap", 76L, 3.6559057060612723, 52025532L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/cake.png" },
                    { "9251d6c6-02b1-407b-909d-4ba410472290", "693", 60L, 443590805L, "CVX", "e69c3231-f51b-4ae6-87a2-990018e85077", "Convex Finance", 100L, 5.8113251636007464, 10949452L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/cvx.png" },
                    { "9c5872f2-30a2-4a27-b359-03619584b2a3", "21", 12L, 5445384888L, "ARB", "ff5ef7c8-0275-4323-8ff3-53548f408d92", "Arbitrum", 19L, 1.3548179589002987, 1046271860L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/arb.png" },
                    { "9c7b16f5-871d-4131-8982-087fa62fa693", "2356", 2218L, 728613411L, "ZEC", "4659d65c-a599-42a5-be77-9c0cd37f5613", "Zcash", 71L, 44.622822872541775, 67990465L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/zec.png" },
                    { "a544a11e-b73b-45d1-be56-a73babe2ff5f", "2034", 6L, 1349697366L, "MANA", "a39a5753-2f13-4d61-bd2e-c027de699200", "Decentraland", 42L, 0.61540675203591522, 100343643L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/mana.png" },
                    { "ac9fd358-f5fd-4322-87fa-42ab6529b584", "2453", 169L, 3128581467L, "ETC", "0c0aacf5-4dbe-4340-8502-971cc3231fe2", "Ethereum Classic", 22L, 22.275222847304718, 199755588L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/etc.png" },
                    { "adbe5b09-3e15-4819-aa75-a21e8093a8f5", "1864", 2L, 855538288L, "TUSD", "1c6428e2-7f24-4851-a120-36d04d528ba5", "True USD", 59L, 0.99974566674995036, 56647944L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/tusd.png" },
                    { "af3c9047-02c1-4520-ad54-70a4d429299a", "524", 9L, 1548206265L, "_IMX", "dd409837-85c2-4595-8761-48277566d520", "Immutable X", 39L, 1.1334500380214361, 59935349L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/_imx.png" },
                    { "b5a407a9-24d9-49bf-b813-95e06fe5162c", "1838", 0L, 592646573L, "XDC", "db0494de-c3ee-452b-8b50-aeb383f98da1", "XDC Network", 84L, 0.042856757030258409, 3944111L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xdc.png" },
                    { "b8a49a7e-b19a-4753-aa69-04b821c34fe9", "322", 0L, 583907727L, "KAS", "b61dcb2e-e130-4d7b-9043-19a651c119a9", "Kaspa", 86L, 0.032612547915839396, 18569847L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/kas.png" },
                    { "bcf46d2f-f53f-4eb5-a044-7e208a9675f5", "1198", 9L, 450724496L, "KAVA", "83d10b06-13e4-4482-9d5e-a8054f024f6f", "Kava", 98L, 0.94235684969696731, 16450427L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/kava.png" },
                    { "bfb5a8f0-12a9-4d78-9e0d-abd08f0a9a7f", "900", 20L, 1941871015L, "NEAR", "6fa567f2-0658-4a1f-bf1f-e03693ff7987", "NEAR Protocol", 32L, 2.1966128181102982, 176283114L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/near.png" },
                    { "c00aff61-4ece-4688-a191-4e027e051cb5", "911", 663L, 1160144987L, "AAVE", "db3a9d7c-13fc-4603-90fe-7d47cdf2473e", "Aave", 48L, 80.770928125200655, 90749892L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/aave.png" },
                    { "c1d95bfa-4c76-4bc1-88d5-d3b380520927", "2081", 4356L, 2650155454L, "BCH", "ff77f15f-eee9-47ee-9e65-025818e185fa", "Bitcoin Cash", 27L, 136.86199605416891, 70687185L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/bch.png" },
                    { "c7450992-fb42-466e-a26b-45b94c14050b", "2051", 4L, 484033579L, "LRC", "8ae2020f-274d-41f3-bea1-b21b4ac089af", "Loopring", 94L, 0.36153227169751667, 26078150L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/lrc.png" },
                    { "c746516f-c6c5-4ab5-b8df-3e3847866cd1", "1372", 1L, 699581929L, "CHZ", "8f738644-b289-4a6c-9c21-5cb348929709", "Chiliz", 74L, 0.13090821005850312, 79719095L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/chz.png" },
                    { "c7bcc84b-19c7-4552-a8f2-45b587d89cd2", "1647", 1L, 31890674516L, "USDC", "3d8f3253-5831-45d5-8873-df8d199a2c8d", "USD Coin", 5L, 0.99906956237183553, 2131442649L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/usdc.png" },
                    { "c8e63c08-04d0-4267-8cc8-2b13d949f840", "1996", 28L, 668334731L, "KCS", "07f1794d-4bae-4082-803d-0e50d6e7fae3", "KuCoin Shares", 77L, 8.8355279000857276, 1364003L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/kcs.png" },
                    { "c98145cc-c09b-46fd-8770-4098a8dbf611", "938", 45L, 2925381898L, "UNI", "60f1fd4c-04f7-442c-b31b-130be32e5ed1", "Uniswap", 24L, 6.195608698729786, 99949699L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/uni.png" },
                    { "cb1537ce-9308-4638-9d9d-6e32924ba218", "2814", 4861L, 245902442713L, "ETH", "a0858bc4-6ba9-4b81-a0b3-0f2d5dc4cdb6", "Ethereum", 2L, 2009.4359257497333, 11770158389L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/eth.png" },
                    { "cb608feb-add4-49b4-a4f7-6bfeebf7b0fe", "2111", 24L, 1394057151L, "EOS", "f7a3e71a-53ea-4783-be57-1968d93bd0da", "EOS", 41L, 1.2654443359627325, 164795547L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/eos.png" },
                    { "cb9f0331-31ac-41c5-99a5-3ff576a68e9c", "1391", 3L, 1575340028L, "ALGO", "fbc91893-9838-449e-9e1c-0a7f7c62da07", "Algorand", 38L, 0.21861473534216658, 59994706L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/algo.png" },
                    { "cdc1eca2-ea4f-44a1-8c12-3a586542e5c7", "1359", 21L, 549835701L, "RUNE", "4f89b20a-a82c-45b2-a93a-8a75380cff5e", "THORChain", 87L, 1.6321258352499231, 31640143L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/rune.png" },
                    { "cfded66e-11d7-4563-94a3-e96c09c2977f", "1912", 16L, 1074858108L, "THETA", "aff345ef-857e-4907-95fe-ac6c180bc050", "Theta Network", 49L, 1.0748581079631161, 20049268L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/theta.png" },
                    { "d19e8060-4f26-4343-9878-3182f5001589", "975", 14L, 2194180620L, "SRM", "aff82e0c-2867-428e-a4fe-f516c2acf275", "Serum", 29L, 0.21594670202632751, 57598923L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/srm.png" },
                    { "d322cc74-f36c-4166-bd33-bf19ba9597cd", "889", 165L, 1286469629L, "AXS", "ab5cebbe-5226-498f-9b87-b208267fa48b", "Axie Infinity", 45L, 8.7608934428342931, 51937698L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/axs.png" },
                    { "d65e5bcf-50bb-4d3c-8257-82c0908a91c0", "675", 1L, 486891673L, "AGIX", "4866d118-6548-47ee-8b09-a2f093ca42c8", "SingularityNET", 93L, 0.40368364922792982, 65325438L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/agix.png" },
                    { "da5186b8-2de1-4cc3-84fb-5b654c87c359", "1295", 2222L, 527549554L, "PAXG", "2ae8bf0f-7991-475e-ab4d-3843a274590a", "PAX Gold", 91L, 2042.9919540285246, 14703777L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/paxg.png" }
                });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "Uid", "Age", "AllTimeHighUSD", "Cap", "Code", "DeltaUid", "Name", "Rank", "Rate", "Volume", "png64" },
                values: new object[,]
                {
                    { "dae5c89b-68e9-4cc3-ae92-cd5f2da45f00", "650", 0L, 615081473L, "XEC", "d1be4907-e5b2-4c24-8100-5df6648d52a2", "eCash", 83L, 3.1770908082477563E-05, 4034928L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xec.png" },
                    { "dc8a14ae-cb2c-40db-b143-5601085f0734", "563", 86L, 647976770L, "__GMX", "68687eac-a9d6-4f55-b842-77cf9d9b7e96", "GMX", 80L, 81.073507988673299, 38651507L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/__gmx.png" },
                    { "dca12168-a05a-4eaa-8bdd-1e8b03797bcc", "3208", 1L, 80650366506L, "USDT", "606e7786-1274-4d2c-b2b3-4775d69788da", "Tether", 3L, 1.0008881832810113, 29981592764L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/usdt.png" },
                    { "e014437d-b496-4438-8eac-62a4f8e5013f", "2264", 6299L, 730593589L, "MKR", "f2762896-23b2-4b0f-964f-2b2c77bf2202", "Maker", 69L, 747.31017008504386, 32172507L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/mkr.png" },
                    { "e36ecd02-b3bd-4f9d-8835-209ee6b7cc10", "4205", 413L, 6867505577L, "LTC", "5b65b3f7-8aba-4fac-ab1c-2b6f5318111f", "Litecoin", 14L, 94.466823379278523, 506762508L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ltc.png" },
                    { "e394644e-0d80-4380-a86f-72177547ccc5", "1492", 1L, 1742687263L, "CRO", "acada883-db1c-4431-a4e2-b30f46e0cae5", "Cronos", 34L, 0.068981764580794316, 7649509L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/cro.png" },
                    { "e4c1a8d3-7e24-442b-a657-689527b65839", "1189", 0L, 665049722L, "_SURE", "d4f971f1-ae40-4491-89f1-be547d20c420", "inSure", 78L, 0.0076776003523308248, 3034637L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/_sure.png" },
                    { "e646e0fd-0430-406d-98e6-49c1ea8acba2", "1626", 3L, 1297548084L, "FTM", "10036c21-35a8-4f23-b0b1-6f4ca517f807", "Fantom", 44L, 0.51061396968355321, 312600111L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ftm.png" },
                    { "e6df53c6-4b14-401c-bc81-7130c34f51cc", "2376", 44L, 2818399814L, "ATOM", "a88992c4-a753-41f3-aca0-b6a1c13e3367", "Cosmos", 25L, 11.815959899295345, 127011892L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/atom.png" },
                    { "e727bae6-6789-45f0-ad1d-70f86ef2c7cb", "903", 25L, 537776849L, "INJ", "7f2e471a-3d3b-4f8a-aa89-d08115a99b8d", "Injective Protocol", 88L, 6.7217437819127657, 107047190L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/inj.png" },
                    { "e852c56a-c479-403c-98b2-8ab79e905290", "618", 11L, 454317232L, "OSMO", "16ace850-f7d7-42aa-b0e0-fede6b4fd358", "Osmosis", 96L, 0.80657164263503145, 10831520L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/osmo.png" },
                    { "eff1d749-e325-4b49-ac9b-b18f127d0b86", "941", 13L, 774577600L, "GT", "cc655074-18e4-4c51-bc47-0ae51fdbc73a", "Gatechain Token", 68L, 5.4945079961524126, 508581L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/gt.png" },
                    { "f0b30a1c-70c7-4704-b03d-2a72926e1ffc", "727", 188L, 694182713L, "MINA", "dc92e992-2855-4864-b4b9-660b006644e3", "Mina Protocol", 75L, 0.78559999246932066, 48803309L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/mina.png" },
                    { "f5852f93-acd1-4cf2-adfb-17e43e6cbc3d", "3282", 517L, 2966640940L, "XMR", "038f2a36-b75c-4c60-8e56-dc150b2b185b", "Monero", 23L, 162.41889788396699, 70093418L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xmr.png" },
                    { "fc781058-4c32-4357-b7df-2f2cc5f63830", "1198", 3L, 1204098652L, "_STX", "bae169b7-d524-4f06-b9e9-699f1ffa74e1", "Stacks", 47L, 0.87687742582793438, 121602900L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/_stx.png" },
                    { "fd00b850-ec2c-4dfc-ac3a-ca709efca421", "1839", 9L, 1044099181L, "XTZ", "4ff2ba26-c775-463c-909d-506b4f5fc7d7", "Tezos", 51L, 1.117674002603652, 13413660L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xtz.png" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coins_DeltaUid",
                table: "Coins",
                column: "DeltaUid",
                unique: true,
                filter: "[DeltaUid] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Coins_Deltas_DeltaUid",
                table: "Coins",
                column: "DeltaUid",
                principalTable: "Deltas",
                principalColumn: "Uid");
        }
    }
}
