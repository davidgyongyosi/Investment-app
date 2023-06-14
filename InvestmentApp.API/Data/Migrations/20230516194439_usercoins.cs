using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestmentApp.API.Data.Migrations
{
    public partial class usercoins : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coins_AspNetUsers_SiteUserId",
                table: "Coins");

            migrationBuilder.DropIndex(
                name: "IX_Coins_SiteUserId",
                table: "Coins");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ee242f9-c291-47ad-a700-b0bc5f99ebd1");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "0285c0c0-3330-45b4-92ad-3c294cbf3ca0");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "043ebf5a-aff7-4428-b07e-e24588466d6d");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "0623cc22-20c4-4daf-a3e1-dec2579d933a");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "08d3b36b-9b3a-409b-b507-a241e62786ce");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "0cc32277-8be7-44d6-b455-c0fe51ee206f");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "13527571-5a11-48c7-b5e2-0e9a97a96714");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "142b2ec1-6099-4c80-9506-c37b2840f919");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "17a439f7-9afc-4cd9-8abe-01f567d45340");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "19631629-bd8b-4b65-82d4-402ecb3a3f21");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "29043b33-e1bc-436e-b0bd-a195d04645bd");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "29af8297-534e-445f-9ed7-98e96f513093");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "2f25da7a-7122-4375-a22e-7b6e8135ccb2");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "340b63fa-6a67-40bc-97bb-f851a93cda43");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "36457ac4-3a79-41fa-8ad0-190f97684646");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "38dd5c25-20d0-437e-8d6a-a50a707a2b3d");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "3b35cfdb-dd3c-4df8-a229-25d2bfb84714");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "3d3463df-61c3-4009-a70e-bef4a53f5177");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "44bbd8a4-0e7d-46c5-8c63-5bcbac6bb07c");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "4840d130-14dd-4fa7-bbad-49a04769daef");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "48cb8b2a-5b21-454f-b1f8-604e7419d53a");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "4919d6a4-b9d0-4e32-9627-150bbf549eaa");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "4b899616-90af-4eca-bd3a-de8d84166c15");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "4e0b1c98-ba51-4106-bd2f-c8c2f93dc02c");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "501151c3-c34f-4279-940c-1fa83d6f8f6f");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "510d6b86-740a-430a-aa4e-a624475ac30d");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "514063ef-a3f2-455c-b57c-f7d11e8ad40c");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "59016292-8420-465c-b85e-c147db54d757");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "59d992ee-c0d9-4fdb-b269-4dfb015cbf85");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "5bcf7151-482c-4947-bd1f-81b77f63a36e");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "5d76075b-fafb-48aa-904e-375a2885869b");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "5e6e5c02-4835-48c8-8a58-a361ee5d3c26");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "65f1cc11-3737-450a-bc4d-5c991d7587e6");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "6645470a-fb78-4250-bb0f-3448126c30c6");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "66722ced-88a9-4224-ba4f-ca355c0131ca");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "67bdb076-5ece-4727-886c-1fcf9f0264fe");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "693d598a-2a76-4e25-bea3-8f5b98258798");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "693ead45-f8c7-436a-a2cb-24403ba31113");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "710e8975-70e4-460e-bf9e-8e06ad803cfd");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "73e6f05c-b73a-425c-a2bd-e2b34b866110");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "75d0840a-ff0e-462e-8af4-6b4f03730e6c");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "78e04947-e6da-44e8-baf3-30e124e5f040");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "7be61c74-40c0-47b1-855e-01f5dc39843a");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "7c7f1ccb-5cb7-435b-b7b6-c8536fb34797");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "7de962f7-a815-4c30-b191-4ea551ca3018");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "7ffa9eaf-59bf-4758-828b-32237fd29d38");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "80b601d0-0bb5-4de5-9f9f-ba5b8b7e94b5");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "8a4d0d70-f6df-4a80-83e3-319db12b15b2");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "8aac9925-c2f8-4479-8597-c0b2d0185d06");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "8b425bab-28b1-40fc-b929-beb57cdb412b");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "8cc2bbb7-c50c-455b-ab13-6a0deaffead3");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "8d8e3bd8-62da-4e7a-9eec-4479c44eedcf");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "928d30a6-da92-499e-83ad-bf7a9fbf0253");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "965647d6-c5ac-4969-897f-cb814655a1be");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "97b96933-b2ea-4b8a-9fd7-a41be2ac357c");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "9b56560e-252a-4109-83ca-fd465acb8405");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "9b7ad908-0213-49cc-af81-04f917bdfb5e");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "9cb88f89-f3a9-4cf9-a1f9-094b251a1245");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "9da30b98-470c-43f3-a964-20095687022e");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "9e6d72bc-20b6-44d9-9198-04b8a14840e1");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "9e8cbd9e-2f62-4aa6-88e2-9a593d28179c");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "a055e335-b7d0-4a4e-92ba-64dbd4b10757");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "a0beacc8-4dbb-49aa-af01-8858c29ac66c");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "a1414068-9ebe-45bf-a3aa-2c7d9c134bd2");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "a4058938-bf94-4236-a503-1777d8c2b560");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "a7eea96c-be36-490d-9cf9-5f3956328f84");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "aa3304f1-880c-4ea5-884b-b7159182986c");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "aa4f1597-ab20-402c-9e66-5068e915fbe8");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "ab94e930-67a5-465c-a26f-ffc25cb3eab5");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "b4a16ca6-c222-40a4-a491-9b7c2ff3abbe");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "b974bde3-c42c-4456-9fc7-6d03898f75ec");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "ba647049-6ca9-45d1-ada4-1ed2b1de0f7b");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "ba7f33e8-3322-4d82-9816-028bcbe9b8f9");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "bdb5cd88-2e67-4379-b710-e857daf10e69");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c011693c-73e4-406d-a422-df7bfcda5631");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c0895e2e-0958-464a-aab9-35e4c94274a6");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c409c523-224b-4e9e-a2b4-46bd7b02d255");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c41f328c-8356-461f-b9ea-3ff9026e78fc");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c7647942-360f-4acf-aef9-c6936dcba0a7");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c895f366-7082-41db-9eb8-bdbb29757b32");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "cbc1556c-0ffe-4ef7-9786-165fe109d40f");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "cc162449-6afb-40c5-8d7f-e7fdf489ccd8");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "ccae3fc4-96e6-466a-af4a-153bbd14dc88");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "cd4df56c-2ee3-43e3-8b9b-6006f188da30");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "cd9554fd-5c6f-4f81-86f5-29edd872c53d");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "cf5edf10-43dd-4d1b-b42f-7aad5e3a1e46");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "d15b0d27-b4ae-4b46-b68b-aae11404e215");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "d4f3e90c-2ef4-410a-99a8-fdfb85c66e19");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "d5616321-c0ec-4894-bbc5-c7a0ebb1ad5b");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "d59a3eed-2b15-4ca9-a876-1252098f44bc");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "daf45a24-6ae5-466c-a687-6f3e56941b84");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "df9dd654-09b7-40f2-bb3e-c7ee28047169");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "e15b365c-8e09-4bbb-af55-a782fe3bf74f");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "e514d76a-4935-4289-9e90-3ff107fef186");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "ecb82c60-ef2f-4f5e-b9d2-0d4dbc206c4b");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "f5c040ca-b52a-4239-ab6b-a7c074cd8c35");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "f62b4311-44d5-4978-a00d-c51fc00eea3e");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "fab71830-5bf8-4d72-952a-dbba03dd3a97");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "fe069cf3-e476-46d8-b6a6-3f193b2f7c0c");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "fee6213e-cb45-4846-8f5c-383087a62841");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "ff3af06c-a068-4191-9d61-67282a34c733");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "02cf06a7-ff46-47d0-908c-02e226accbd9");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "05c93b0d-4a46-43f6-a457-8b9ee903b6f7");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "06231693-5101-450c-bcac-dd8bf0b25a92");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "0751b2a5-78f0-44a1-96bf-2935a489c9e1");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "0835fbc5-6f64-4a4b-8317-b6966548e61a");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "0bdd2174-1855-4413-892e-a98da63f8c2c");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "0c0ce570-2c92-4800-a050-350abdf6bc72");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "0d3870c1-b02c-4a8b-b9ae-2f16379ea0c6");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "110aa5ae-849f-47f1-ace5-3c4e9f7d72e1");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "1225e89f-bd61-4ee7-9f1d-c88e4b1654d5");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "16846623-52f1-47c1-b3ba-c8c57b70c409");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "1f36fb79-1adf-4ebb-bb1a-89b333ab3f04");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "1f96d094-6682-4846-84b1-7020513a6b4e");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "2106dde6-f646-433e-94ac-12b19abc163f");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "248d9f21-cc91-4082-8688-8ac524f5f867");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "28d7195a-894b-4b3c-a87f-02c3d26bbd3c");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "2cd42260-a51c-43c7-ad94-68f1ddef5c2c");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "324e4994-9448-4013-b1ea-1471b68aecbc");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "35df841e-ee10-4424-b331-5215bf77b370");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "38758cf3-3e1d-4a98-9df7-ea32b2009897");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "3921a445-0fb1-4bfc-8854-bc0d6ac4adc9");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "3f1dbad0-9f9b-4d4a-bbe2-c339491fd86f");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "42188ef2-eacf-4ae0-b091-bf50ce2d9a55");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "4355bad6-95b3-42ed-855c-8e30e61aef7a");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "459916f8-ef50-476a-8679-39cd64934054");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "46314d5c-8ad4-4a79-a8f4-57b0767b9e70");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "46560da1-f75e-42a3-8726-ff0dc96fb074");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "46805839-692a-4169-93db-57f6181e4d45");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "47734fe7-b722-4a0c-9224-8dfda549d8b8");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "487adfdb-b314-4a35-a574-e5817484c949");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "4c4e395f-7e2c-4326-ab97-8a8152264feb");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "4e7fe755-940a-4b98-b748-5cd8e0f14c6a");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "501148e1-156e-44fe-b16e-09d2e3a19320");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "543950a0-4a92-4ad7-8da5-8b4feb969e1c");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "5632943a-f882-42b6-9a23-4e1f756cba22");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "5819d334-8fdc-474f-ab9f-3b472322d203");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "59ec5852-d778-45b8-a4c1-1d499a249364");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "6039f63e-127d-4768-bb83-cd9699a71a63");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "6a0a4bd9-b88a-4c0f-b29a-c734fd0c7167");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "6b84023f-3def-4469-b650-ad6cb4681f35");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "6d918399-2327-4eff-84f1-b4c901e3a610");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "6e0a4a0b-9cf3-4657-8d95-f250ee709fb0");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "7044c542-d1b0-48b8-bf01-92054270758c");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "71038e20-4d5d-412b-b42b-ac7c24de3f6f");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "713737f8-b65f-4e5c-9294-ddcd28da7768");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "7307681e-c273-428b-b239-72ecbf4689c4");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "7f0fce8a-fa98-4d96-93e2-ce8a2f7ca570");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "810e6138-478a-465d-8c46-a33a92f79710");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "83c25faa-80f1-4ddb-a432-af20a9a881ce");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "8657258c-68dd-4dbe-b9de-0b403b3d1412");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "8e8f1194-5a2e-4cec-a0ad-066212e0429f");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "9335e839-da02-46e2-9cf2-b763bf9283c2");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "94722f5d-5657-40df-9582-48ad46fe2821");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "9543a1d7-f33b-4e6f-b75d-cf30eacd3ad8");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "9595fad0-8637-4655-8a50-4996099cd721");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "9c5d62f6-0ac8-4a9e-b348-eda5aeeacbe2");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "9ce55b59-8d71-425f-9b45-fed60591aa0f");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "a13d959c-27bd-423c-a6f3-af30dfe9813f");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "a569971c-76c0-423e-aac4-c3d9de9bd362");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "a830e775-1fcb-45f0-bc67-c8345befcae1");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "ac301dca-3f27-465e-bc06-94f2955b3928");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "b077ef0b-6e8e-49fc-a461-c8d0566d4e2d");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "b117c409-b548-4de6-b43c-1a82251c8cdb");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "b6324aa6-8347-4dcf-8a93-437af7115595");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "b6933c09-f3d0-4924-a89f-36957e1833c3");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "b9d99efc-b689-423e-9681-8b298509aac8");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "b9e1db6d-b48b-4762-bf9b-9e8562c4bb26");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "bab5131a-a632-4129-8dce-7396e3535797");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "bb7bba5f-2a7a-42c1-9a6a-c37cf603c5df");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "bb95f0a9-dc35-458e-a3c9-f9c40a1cce1e");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "c055f1f1-c9ad-44e8-84bb-d221adaf28e8");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "c0a48cf8-f630-4730-942c-757fc0e983da");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "c16a76a8-85ba-467d-82bb-20459cc6ef92");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "c6e17fb1-c913-455a-892c-b1cb93c3aa52");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "c7967843-ae09-4832-a25a-7b37cf737140");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "c8c83405-f4f2-493b-baa4-1b7c5dae3c8f");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "c9ae5527-ca58-436a-aa87-a5d4e00d16ac");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "ccdc40d3-7164-43a5-86af-d2be1bd511e4");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "cd04fe79-d91e-4315-9ec3-880646793ea3");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "cfe82f24-7800-4b34-a83c-3dfd3666d0dc");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "d48398ba-5a2e-43de-90f4-2dfde1ac3a46");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "d66439f5-22ef-4afd-b4b2-e1e78cf1bc56");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "d973d455-9c40-49c5-94c4-dd050565e3f2");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "dc0eacff-30f0-4a48-898f-76c9fc983b71");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "dd4b9380-fe3d-4b44-b6c8-531e185920ea");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "df213624-30ec-42ff-9a4d-06aee99fb71b");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "e268ee73-6fd5-4c04-8078-7b7c10dca666");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "e36a91e9-8260-4177-a2a8-3d066ed5b690");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "e3d173de-0231-45e4-90a8-78975417162b");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "e3fdfc74-ed17-4f9e-bc60-7694cfa34aef");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "e56f1122-e620-4897-95fa-b43d92d44bcb");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "ebe55c42-5ef4-447a-adc1-a8ff001ab659");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "ee7e6e03-e1bf-4517-ad9e-ce9b655a0915");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "ef9b7199-504c-4474-a1d5-1268b14f556a");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "efafe5d9-93bd-4bfa-a87f-004e4721f0bf");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "f037c1ce-1a07-4bcf-8765-15031283fdca");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "f104eddd-b8e2-4901-8a3f-b17bd17be517");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "f1aa8938-dbb0-4a24-ba59-abd8f6322e1c");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "f32b0b73-6035-4d31-b9a0-82b7bd808703");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "f7aac25f-7ad2-408a-8459-680979a52348");

            migrationBuilder.DropColumn(
                name: "SiteUserId",
                table: "Coins");

            migrationBuilder.DropColumn(
                name: "PictureData",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "PictureContentType",
                table: "AspNetUsers",
                newName: "Picture");

            migrationBuilder.CreateTable(
                name: "UserCoins",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CoinId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CoinCount = table.Column<double>(type: "float", nullable: false),
                    SiteUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCoins", x => new { x.UserId, x.CoinId });
                    table.ForeignKey(
                        name: "FK_UserCoins_AspNetUsers_SiteUserId",
                        column: x => x.SiteUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserCoins_Coins_CoinId",
                        column: x => x.CoinId,
                        principalTable: "Coins",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_UserCoins_CoinId",
                table: "UserCoins",
                column: "CoinId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCoins_SiteUserId",
                table: "UserCoins",
                column: "SiteUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCoins");

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

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "00558eaf-d093-46a1-a6b6-2eb4f9c000e7");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "0159894d-f6ea-4c7a-87ea-aaaad985dcab");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "038f2a36-b75c-4c60-8e56-dc150b2b185b");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "05ec641e-61c0-488b-b3e3-3e414c5cf197");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "07f1794d-4bae-4082-803d-0e50d6e7fae3");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "0a859a5a-07f2-4aa8-ab0c-33f4e612a61c");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "0b56f6c3-2b6b-45e3-a3b2-722faa9c52dc");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "0c0aacf5-4dbe-4340-8502-971cc3231fe2");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "0d30c542-3d4c-4ec4-a591-680fd1a7de1e");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "0ec5a7f3-19b8-4b62-abcf-47d86bbe7963");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "10036c21-35a8-4f23-b0b1-6f4ca517f807");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "107b0161-a754-4f3d-991f-78990b971e65");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "13721be0-d666-4373-b67f-6f8a65a2276e");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "151f32c8-4962-4c62-9c88-851e77dbbe2a");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "16ace850-f7d7-42aa-b0e0-fede6b4fd358");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "1c6428e2-7f24-4851-a120-36d04d528ba5");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "1f3a6640-0bd3-4ca3-ab6a-4a8de24cf98e");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "2255564c-ca3c-4693-a722-cb312bdb33f2");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "251329b3-ed57-47c4-9339-bd8bc12dd9ef");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "2ae8bf0f-7991-475e-ab4d-3843a274590a");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "2e263a45-421c-4473-87e9-fe54d38a47d5");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "35937b3e-7fff-44f3-9614-21cc73c31f95");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "3d8f3253-5831-45d5-8873-df8d199a2c8d");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "45d37b36-232f-4a3b-9372-6c93bfacfde2");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "4641b5d4-0a48-4f99-9f66-5f3d4c4c6ae1");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "4659d65c-a599-42a5-be77-9c0cd37f5613");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "46b8179c-f989-4114-94b0-14d9359224a9");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "4866d118-6548-47ee-8b09-a2f093ca42c8");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "48ea2bb2-7ecb-459b-aa65-e88805bd805c");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "4f022314-58c6-4b6b-b906-2b212a617f07");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "4f89b20a-a82c-45b2-a93a-8a75380cff5e");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "4ff2ba26-c775-463c-909d-506b4f5fc7d7");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "5160a7e6-bbe2-4184-a5bc-c5fdf74af6e8");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "52c649a8-9961-4810-afc5-a88ba58e6b1b");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "52d08a91-a771-4f6d-8e77-8393a7463435");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "53178fdc-0e03-43f1-acf1-1ff966f8a6dd");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "58b34d45-a992-4a30-a654-03e4b7ac1052");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "5ad89144-e3fc-4eeb-96e7-e27186e4d15e");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "5b65b3f7-8aba-4fac-ab1c-2b6f5318111f");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "5f8cec04-3b40-4d9a-bce2-3d2eaceba385");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "606e7786-1274-4d2c-b2b3-4775d69788da");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "60f1fd4c-04f7-442c-b31b-130be32e5ed1");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "68687eac-a9d6-4f55-b842-77cf9d9b7e96");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "6bbfb25b-af74-49b3-9936-29d045cfd0cd");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "6fa567f2-0658-4a1f-bf1f-e03693ff7987");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "6fe2d09b-28ab-4df9-99fa-f498ea85076c");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "76578b06-1074-4ff4-b266-5cb85f7ccb55");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "79f684df-d599-4040-b9b8-29bc39a2ef56");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "7b58d14f-6660-4b34-88d3-251963c08c61");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "7f2e471a-3d3b-4f8a-aa89-d08115a99b8d");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "83d10b06-13e4-4482-9d5e-a8054f024f6f");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "84806bc0-92fc-462f-992d-9a60d98d65bc");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "8ae2020f-274d-41f3-bea1-b21b4ac089af");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "8e733a5c-13d0-4a76-a55d-7f2cd4f7eb9c");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "8f738644-b289-4a6c-9c21-5cb348929709");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "9007bfcb-81d3-4c98-bf15-246c19aa0686");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "9125c9d0-65d5-4668-8676-536d5f093516");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "a083cfb9-8c90-4dce-ae6e-1063e988962f");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "a0858bc4-6ba9-4b81-a0b3-0f2d5dc4cdb6");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "a15b53ed-fbe0-476e-aa4c-374739b47745");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "a39a5753-2f13-4d61-bd2e-c027de699200");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "a3e3ab66-3f13-4152-b510-998203fa100f");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "a5be82bb-5871-40d6-8032-215bae3cf996");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "a88992c4-a753-41f3-aca0-b6a1c13e3367");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "a9efa19a-abc1-4d70-af1c-6e53d9037358");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "ab5cebbe-5226-498f-9b87-b208267fa48b");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "acada883-db1c-4431-a4e2-b30f46e0cae5");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "aff345ef-857e-4907-95fe-ac6c180bc050");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "aff82e0c-2867-428e-a4fe-f516c2acf275");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "b3b30456-c655-409d-9477-76a6d58fae2f");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "b61dcb2e-e130-4d7b-9043-19a651c119a9");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "bac02d0b-9c7e-448e-9e54-0f5cc4117935");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "bae169b7-d524-4f06-b9e9-699f1ffa74e1");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "bb104042-816d-4102-811d-9f260ddd327d");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "bb8e6c14-6c39-4210-9945-0aaa059366e5");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "bee3c9df-9daf-463f-9912-48f5c8496dea");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "c0104dbb-110e-4a96-bcaa-3ebb684ee6ae");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "c2b642da-e3d5-4541-b565-f78dde4fceed");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "c2db18d0-948a-4083-a484-5d9cf1396886");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "c468f85d-cd2f-4f61-94c2-f40420b73ca5");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "c83290a4-2c0a-4457-82f0-de2c1a8a1cc1");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "cc655074-18e4-4c51-bc47-0ae51fdbc73a");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "d1be4907-e5b2-4c24-8100-5df6648d52a2");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "d4f971f1-ae40-4491-89f1-be547d20c420");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "d5d2e5d8-99db-4107-9832-d120eba6022f");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "d9cdf871-770a-4fe1-8dec-161f6013df08");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "db0494de-c3ee-452b-8b50-aeb383f98da1");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "db1a8971-5375-4a83-b4d4-d2729e30a542");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "db3a9d7c-13fc-4603-90fe-7d47cdf2473e");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "dc92e992-2855-4864-b4b9-660b006644e3");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "dd409837-85c2-4595-8761-48277566d520");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "e36c9cd3-e20a-4cbb-b1ea-09c53069a574");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "e69c3231-f51b-4ae6-87a2-990018e85077");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "efebf04d-ba5c-4784-8233-c2f514c0b63c");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "f2762896-23b2-4b0f-964f-2b2c77bf2202");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "f46f4e6b-0e15-4e83-b44f-a5e876823f66");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "f7a3e71a-53ea-4783-be57-1968d93bd0da");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "fbc91893-9838-449e-9e1c-0a7f7c62da07");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "ff5ef7c8-0275-4323-8ff3-53548f408d92");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "ff77f15f-eee9-47ee-9e65-025818e185fa");

            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "AspNetUsers",
                newName: "PictureContentType");

            migrationBuilder.AddColumn<string>(
                name: "SiteUserId",
                table: "Coins",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PictureData",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureContentType", "PictureData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6ee242f9-c291-47ad-a700-b0bc5f99ebd1", 0, "2eae1705-299d-4def-8e20-ca0785eec9db", "admin@admin.adm", true, "Super", "User", false, null, null, "SUPERUSER", "AQAAAAEAACcQAAAAEB+nCwNpdFUUItsLTRwx2TGQSRzKUVbYpmaguLEv5NhSArFeSzc4fqjAPvZegx9M0A==", null, false, null, null, "f1706083-4c8e-48ff-a3c9-1bb86a5f3cdb", false, "superuser" });

            migrationBuilder.InsertData(
                table: "Deltas",
                columns: new[] { "Uid", "CoinUid", "day", "hour", "month", "quarter", "week", "year" },
                values: new object[,]
                {
                    { "02cf06a7-ff46-47d0-908c-02e226accbd9", "ba7f33e8-3322-4d82-9816-028bcbe9b8f9", "1.0177", "1.0007", "1.0522", "1.1287", "1.0363", "0.7739" },
                    { "05c93b0d-4a46-43f6-a457-8b9ee903b6f7", "08d3b36b-9b3a-409b-b507-a241e62786ce", "1.0112", "0.993", "1.0818", "1.0524", "1.0714", "0.5822" },
                    { "06231693-5101-450c-bcac-dd8bf0b25a92", "ab94e930-67a5-465c-a26f-ffc25cb3eab5", "1.0201", "0.9941", "0.9952", "1.0141", "1.005", "0.2957" },
                    { "0751b2a5-78f0-44a1-96bf-2935a489c9e1", "c7647942-360f-4acf-aef9-c6936dcba0a7", "1.0192", "0.9945", "1.029", "1.1902", "1.0182", "0.3548" },
                    { "0835fbc5-6f64-4a4b-8317-b6966548e61a", "fe069cf3-e476-46d8-b6a6-3f193b2f7c0c", "1.005", "1.0077", "1.59", "4.367", "1.1586", "1.2163" },
                    { "0bdd2174-1855-4413-892e-a98da63f8c2c", "80b601d0-0bb5-4de5-9f9f-ba5b8b7e94b5", "1.0434", "0.997", "1.0122", "1.3515", "1.0075", "0.3299" },
                    { "0c0ce570-2c92-4800-a050-350abdf6bc72", "b4a16ca6-c222-40a4-a491-9b7c2ff3abbe", "1.0014", "1.0002", "1.0008", "0.9982", "0.9995", "1.0006" },
                    { "0d3870c1-b02c-4a8b-b9ae-2f16379ea0c6", "3b35cfdb-dd3c-4df8-a229-25d2bfb84714", "1.0246", "0.9895", "0.9753", "1.0318", "1.029", "0.9331" },
                    { "110aa5ae-849f-47f1-ace5-3c4e9f7d72e1", "7be61c74-40c0-47b1-855e-01f5dc39843a", "1.0145", "0.996", "1.2151", "1.5635", "1.0772", "0.7361" },
                    { "1225e89f-bd61-4ee7-9f1d-c88e4b1654d5", "ccae3fc4-96e6-466a-af4a-153bbd14dc88", "1.0429", "0.9919", "1.0917", "1.1994", "1.0388", "0.2346" },
                    { "16846623-52f1-47c1-b3ba-c8c57b70c409", "8aac9925-c2f8-4479-8597-c0b2d0185d06", "1.0007", "1.0002", "1.0022", "0.9987", "0.9997", "0.9922" },
                    { "1f36fb79-1adf-4ebb-bb1a-89b333ab3f04", "fab71830-5bf8-4d72-952a-dbba03dd3a97", "1.0517", "0.9947", "1.1679", "1.4126", "1.0693", "0.6494" },
                    { "1f96d094-6682-4846-84b1-7020513a6b4e", "48cb8b2a-5b21-454f-b1f8-604e7419d53a", "1.0269", "0.997", "0.7974", "2.6062", "0.9943", "2.7918" },
                    { "2106dde6-f646-433e-94ac-12b19abc163f", "44bbd8a4-0e7d-46c5-8c63-5bcbac6bb07c", "1.0332", "0.9938", "1.0642", "1.1588", "1.0332", "0.5282" },
                    { "248d9f21-cc91-4082-8688-8ac524f5f867", "d15b0d27-b4ae-4b46-b68b-aae11404e215", "1.0014", "1.0009", "0.9975", "1.0103", "1.0027", null },
                    { "28d7195a-894b-4b3c-a87f-02c3d26bbd3c", "e514d76a-4935-4289-9e90-3ff107fef186", "1.0828", "0.9991", "0.8834", "1.8079", "1.0608", null },
                    { "2cd42260-a51c-43c7-ad94-68f1ddef5c2c", "340b63fa-6a67-40bc-97bb-f851a93cda43", "1.0508", "1.0059", "1.2188", "1.2707", "1.1054", "0.4397" },
                    { "324e4994-9448-4013-b1ea-1471b68aecbc", "a4058938-bf94-4236-a503-1777d8c2b560", "1.0222", "0.9912", "1.1324", "1.7931", "1.1162", "0.4293" },
                    { "35df841e-ee10-4424-b331-5215bf77b370", "c895f366-7082-41db-9eb8-bdbb29757b32", "1.0393", "0.9993", "0.8536", "1.1363", "1.0291", "0.387" },
                    { "38758cf3-3e1d-4a98-9df7-ea32b2009897", "9e8cbd9e-2f62-4aa6-88e2-9a593d28179c", "1.002", "0.9984", "0.9554", "1.1226", "1.0073", "0.4407" },
                    { "3921a445-0fb1-4bfc-8854-bc0d6ac4adc9", "59d992ee-c0d9-4fdb-b269-4dfb015cbf85", "1.0403", "0.9972", "0.8918", "0.9821", "1.0165", "0.1339" },
                    { "3f1dbad0-9f9b-4d4a-bbe2-c339491fd86f", "a0beacc8-4dbb-49aa-af01-8858c29ac66c", "1.0282", "0.9886", "1.0137", "2.3016", "0.9994", "0.9456" },
                    { "42188ef2-eacf-4ae0-b091-bf50ce2d9a55", "e15b365c-8e09-4bbb-af55-a782fe3bf74f", "1.0198", "0.9914", "0.9879", "1.1483", "1.0075", "0.5478" },
                    { "4355bad6-95b3-42ed-855c-8e30e61aef7a", "4919d6a4-b9d0-4e32-9627-150bbf549eaa", "1.028", "0.9948", "1.0465", "1.492", "1.0155", "0.3942" },
                    { "459916f8-ef50-476a-8679-39cd64934054", "df9dd654-09b7-40f2-bb3e-c7ee28047169", "1.0108", "0.9945", "0.9691", "1.2224", "1.1084", "0.3204" },
                    { "46314d5c-8ad4-4a79-a8f4-57b0767b9e70", "0623cc22-20c4-4daf-a3e1-dec2579d933a", "1.0228", "0.9979", "1.1777", "1.2614", "1.0025", "0.5387" },
                    { "46560da1-f75e-42a3-8726-ff0dc96fb074", "9b7ad908-0213-49cc-af81-04f917bdfb5e", "1.0199", "0.9991", "0.9522", "1.1834", "1.0472", "0.4535" },
                    { "46805839-692a-4169-93db-57f6181e4d45", "8b425bab-28b1-40fc-b929-beb57cdb412b", "1.001", "1.0008", "0.9991", "0.9991", "1.0005", "1.0002" },
                    { "47734fe7-b722-4a0c-9224-8dfda549d8b8", "2f25da7a-7122-4375-a22e-7b6e8135ccb2", "1.0507", "0.9978", "1.0774", "1.7127", "1.0186", "2.1172" },
                    { "487adfdb-b314-4a35-a574-e5817484c949", "aa3304f1-880c-4ea5-884b-b7159182986c", "1.0697", "0.9897", "0.9781", "1.4846", "1.0533", "0.3198" },
                    { "4c4e395f-7e2c-4326-ab97-8a8152264feb", "cc162449-6afb-40c5-8d7f-e7fdf489ccd8", "0.9213", "1.0092", "0.8233", "1.1073", "1.0584", "0.0859" },
                    { "4e7fe755-940a-4b98-b748-5cd8e0f14c6a", "0285c0c0-3330-45b4-92ad-3c294cbf3ca0", "1.0249", "0.9954", "1.0052", "1.057", "1.0236", "0.1803" },
                    { "501148e1-156e-44fe-b16e-09d2e3a19320", "501151c3-c34f-4279-940c-1fa83d6f8f6f", "1.0494", "0.9959", "0.8899", "0.971", "1.0331", "0.4758" },
                    { "543950a0-4a92-4ad7-8da5-8b4feb969e1c", "710e8975-70e4-460e-bf9e-8e06ad803cfd", "0.9902", "0.996", "1.0202", "1.1787", "1.0906", "0.1296" },
                    { "5632943a-f882-42b6-9a23-4e1f756cba22", "d59a3eed-2b15-4ca9-a876-1252098f44bc", "1.0191", "0.9967", "0.9639", "0.8558", "0.9934", "0.4214" },
                    { "5819d334-8fdc-474f-ab9f-3b472322d203", "7c7f1ccb-5cb7-435b-b7b6-c8536fb34797", "0.9791", "0.9855", "0.9011", "3.5057", "1.0514", "0.7247" },
                    { "59ec5852-d778-45b8-a4c1-1d499a249364", "8d8e3bd8-62da-4e7a-9eec-4479c44eedcf", "1.032", "0.9933", "1.0428", "1.2469", "1.034", "0.3636" },
                    { "6039f63e-127d-4768-bb83-cd9699a71a63", "38dd5c25-20d0-437e-8d6a-a50a707a2b3d", "1.0248", "0.9947", "0.885", "1.5859", "1.079", "0.3131" },
                    { "6a0a4bd9-b88a-4c0f-b29a-c734fd0c7167", "bdb5cd88-2e67-4379-b710-e857daf10e69", "1.3221", "1.0248", "2.0292", "1.9399", "1.6615", "0.6003" },
                    { "6b84023f-3def-4469-b650-ad6cb4681f35", "cf5edf10-43dd-4d1b-b42f-7aad5e3a1e46", "0.9745", "0.9854", "1.1625", "0.9999", "1.0092", "0.2974" },
                    { "6d918399-2327-4eff-84f1-b4c901e3a610", "a7eea96c-be36-490d-9cf9-5f3956328f84", "1.0203", "0.9961", "1.1143", "1.0216", "1.0345", "0.1924" }
                });

            migrationBuilder.InsertData(
                table: "Deltas",
                columns: new[] { "Uid", "CoinUid", "day", "hour", "month", "quarter", "week", "year" },
                values: new object[,]
                {
                    { "6e0a4a0b-9cf3-4657-8d95-f250ee709fb0", "29af8297-534e-445f-9ed7-98e96f513093", "1.0013", "1", "0.9985", "1.0005", "0.9995", "0.999" },
                    { "7044c542-d1b0-48b8-bf01-92054270758c", "0cc32277-8be7-44d6-b455-c0fe51ee206f", "1.048", "0.9975", "1.1325", "1.2779", "1.0231", "0.5462" },
                    { "71038e20-4d5d-412b-b42b-ac7c24de3f6f", "29043b33-e1bc-436e-b0bd-a195d04645bd", "1.0412", "0.998", "0.8207", "1.2243", "1.0761", "0.2315" },
                    { "713737f8-b65f-4e5c-9294-ddcd28da7768", "510d6b86-740a-430a-aa4e-a624475ac30d", "1.0103", "1.0006", "0.9076", "0.7213", "1.0622", "0.4108" },
                    { "7307681e-c273-428b-b239-72ecbf4689c4", "cbc1556c-0ffe-4ef7-9786-165fe109d40f", "1.0369", "0.997", "1.1888", "2.449", "1.1299", "0.9112" },
                    { "7f0fce8a-fa98-4d96-93e2-ce8a2f7ca570", "ba647049-6ca9-45d1-ada4-1ed2b1de0f7b", "1.0034", "0.9999", "1.1025", "1.2812", "0.9597", null },
                    { "810e6138-478a-465d-8c46-a33a92f79710", "c41f328c-8356-461f-b9ea-3ff9026e78fc", "1.0162", "0.9976", "0.9458", "0.9821", "0.9948", "0.1641" },
                    { "83c25faa-80f1-4ddb-a432-af20a9a881ce", "c409c523-224b-4e9e-a2b4-46bd7b02d255", "1.0311", "0.9942", "0.9478", "1.2353", "1.008", "0.7982" },
                    { "8657258c-68dd-4dbe-b9de-0b403b3d1412", "97b96933-b2ea-4b8a-9fd7-a41be2ac357c", "1.0047", "0.9991", "0.9117", "0.9117", "0.9975", "0.3257" },
                    { "8e8f1194-5a2e-4cec-a0ad-066212e0429f", "9da30b98-470c-43f3-a964-20095687022e", "1.0341", "0.9961", "0.8677", "1.4814", "1.0413", "2.1912" },
                    { "9335e839-da02-46e2-9cf2-b763bf9283c2", "693d598a-2a76-4e25-bea3-8f5b98258798", "1.0432", "0.9948", "0.9706", "1.0065", "1.0144", "0.6439" },
                    { "94722f5d-5657-40df-9582-48ad46fe2821", "3d3463df-61c3-4009-a70e-bef4a53f5177", "1.0372", "0.994", "1.0597", "1.3917", "1.0605", "0.4696" },
                    { "9543a1d7-f33b-4e6f-b75d-cf30eacd3ad8", "59016292-8420-465c-b85e-c147db54d757", "1.02", "0.9931", "0.9194", "1.2462", "0.9764", "0.3547" },
                    { "9595fad0-8637-4655-8a50-4996099cd721", "5bcf7151-482c-4947-bd1f-81b77f63a36e", "1.0644", "0.988", "1.0148", "1.3681", "1.0189", "0.2455" },
                    { "9c5d62f6-0ac8-4a9e-b348-eda5aeeacbe2", "f5c040ca-b52a-4239-ab6b-a7c074cd8c35", "1.0218", "0.9964", "1.0649", "1.7", "0.9823", "0.5832" },
                    { "9ce55b59-8d71-425f-9b45-fed60591aa0f", "4b899616-90af-4eca-bd3a-de8d84166c15", "1.1373", "0.9895", null, null, "1.1208", null },
                    { "a13d959c-27bd-423c-a6f3-af30dfe9813f", "aa4f1597-ab20-402c-9e66-5068e915fbe8", "1.0832", "1.0045", "1.059", "1.7174", "1.0047", "1.3894" },
                    { "a569971c-76c0-423e-aac4-c3d9de9bd362", "6645470a-fb78-4250-bb0f-3448126c30c6", "0.9813", "0.993", "2.3575", "5.3643", "1.044", null },
                    { "a830e775-1fcb-45f0-bc67-c8345befcae1", "8cc2bbb7-c50c-455b-ab13-6a0deaffead3", "1.001", "0.9997", "1.001", "0.9983", "0.9984", "0.999" },
                    { "ac301dca-3f27-465e-bc06-94f2955b3928", "d4f3e90c-2ef4-410a-99a8-fdfb85c66e19", "1.0085", "0.9929", "0.9535", "2.1061", "1.066", "0.6134" },
                    { "b077ef0b-6e8e-49fc-a461-c8d0566d4e2d", "514063ef-a3f2-455c-b57c-f7d11e8ad40c", "1.0075", "0.996", "1.0137", "1.1225", "0.9693", "0.3284" },
                    { "b117c409-b548-4de6-b43c-1a82251c8cdb", "b974bde3-c42c-4456-9fc7-6d03898f75ec", "1.0063", "0.9966", "0.9453", "0.7312", "1.0229", null },
                    { "b6324aa6-8347-4dcf-8a93-437af7115595", "daf45a24-6ae5-466c-a687-6f3e56941b84", "1.0133", "0.9914", "0.9394", "1.0667", "0.9907", "0.2584" },
                    { "b6933c09-f3d0-4924-a89f-36957e1833c3", "965647d6-c5ac-4969-897f-cb814655a1be", "1.0228", "0.9897", "1.2911", "15.2606", "1.0296", "2.2857" },
                    { "b9d99efc-b689-423e-9681-8b298509aac8", "cd4df56c-2ee3-43e3-8b9b-6006f188da30", "1.0072", "1.0015", "0.9582", "1.0328", "0.996", "0.4449" },
                    { "b9e1db6d-b48b-4762-bf9b-9e8562c4bb26", "ff3af06c-a068-4191-9d61-67282a34c733", "0.9895", "0.9861", "1.1374", "2.9948", "1.2064", "0.7545" },
                    { "bab5131a-a632-4129-8dce-7396e3535797", "9cb88f89-f3a9-4cf9-a1f9-094b251a1245", "1.0633", "0.9944", "0.9839", "1.6174", "1.0956", "0.1982" },
                    { "bb7bba5f-2a7a-42c1-9a6a-c37cf603c5df", "66722ced-88a9-4224-ba4f-ca355c0131ca", "1.0076", "0.9966", "1.0795", "0.9665", "1.0318", "0.6951" },
                    { "bb95f0a9-dc35-458e-a3c9-f9c40a1cce1e", "a1414068-9ebe-45bf-a3aa-2c7d9c134bd2", "1.0016", "0.9988", "0.9635", "1.1126", "0.9824", "1.0779" },
                    { "c055f1f1-c9ad-44e8-84bb-d221adaf28e8", "5e6e5c02-4835-48c8-8a58-a361ee5d3c26", "1.0176", "0.9939", "0.955", "1.0029", "1.0213", "1.0791" },
                    { "c0a48cf8-f630-4730-942c-757fc0e983da", "17a439f7-9afc-4cd9-8abe-01f567d45340", "1.0729", "0.988", "0.8825", "1.5197", "1.0774", null },
                    { "c16a76a8-85ba-467d-82bb-20459cc6ef92", "4840d130-14dd-4fa7-bbad-49a04769daef", "1.0526", "0.9945", "1.1633", "1.0759", "0.9539", "0.6201" },
                    { "c6e17fb1-c913-455a-892c-b1cb93c3aa52", "75d0840a-ff0e-462e-8af4-6b4f03730e6c", "1.022", "0.9941", "1.0027", "1.2343", "1.0238", "0.2804" },
                    { "c7967843-ae09-4832-a25a-7b37cf737140", "d5616321-c0ec-4894-bbc5-c7a0ebb1ad5b", "1.021", "1.0043", "1.3642", "1.3607", "1.0078", "0.7121" },
                    { "c8c83405-f4f2-493b-baa4-1b7c5dae3c8f", "f62b4311-44d5-4978-a00d-c51fc00eea3e", "1.032", "0.9985", "1.4135", "1.5832", "1.0594", "0.783" },
                    { "c9ae5527-ca58-436a-aa87-a5d4e00d16ac", "13527571-5a11-48c7-b5e2-0e9a97a96714", "1.0417", "1.0008", "0.9789", "1.1153", "1.0062", "0.1731" },
                    { "ccdc40d3-7164-43a5-86af-d2be1bd511e4", "67bdb076-5ece-4727-886c-1fcf9f0264fe", "1.0194", "0.9975", "0.9903", "1.1445", "0.9797", "0.3334" },
                    { "cd04fe79-d91e-4315-9ec3-880646793ea3", "fee6213e-cb45-4846-8f5c-383087a62841", "1.0225", "0.9892", "0.8715", "1.3718", "0.979", "0.5173" },
                    { "cfe82f24-7800-4b34-a83c-3dfd3666d0dc", "8a4d0d70-f6df-4a80-83e3-319db12b15b2", "1.0256", "0.9901", "1.1881", "1.3504", "1.081", "0.551" },
                    { "d48398ba-5a2e-43de-90f4-2dfde1ac3a46", "65f1cc11-3737-450a-bc4d-5c991d7587e6", "1.0305", "0.9934", "1.0044", "1.2474", "0.9945", "0.3406" },
                    { "d66439f5-22ef-4afd-b4b2-e1e78cf1bc56", "ecb82c60-ef2f-4f5e-b9d2-0d4dbc206c4b", "1.0428", "0.9981", "1.0508", "1.296", "1.0267", "0.4133" },
                    { "d973d455-9c40-49c5-94c4-dd050565e3f2", "36457ac4-3a79-41fa-8ad0-190f97684646", "1.0337", "0.9961", "1.0162", "0.9273", "1.0669", "0.3514" }
                });

            migrationBuilder.InsertData(
                table: "Deltas",
                columns: new[] { "Uid", "CoinUid", "day", "hour", "month", "quarter", "week", "year" },
                values: new object[,]
                {
                    { "dc0eacff-30f0-4a48-898f-76c9fc983b71", "c011693c-73e4-406d-a422-df7bfcda5631", "1.056", "0.9995", "1.0552", "1.2429", "1.0179", "0.343" },
                    { "dd4b9380-fe3d-4b44-b6c8-531e185920ea", "cd9554fd-5c6f-4f81-86f5-29edd872c53d", "1.0247", "0.9905", "0.9683", "2.0002", "1.0255", "0.3914" },
                    { "df213624-30ec-42ff-9a4d-06aee99fb71b", "a055e335-b7d0-4a4e-92ba-64dbd4b10757", "1.0216", "0.995", "1.0224", "1.1148", "1.0365", "0.3999" },
                    { "e268ee73-6fd5-4c04-8078-7b7c10dca666", "142b2ec1-6099-4c80-9506-c37b2840f919", "1.0009", "1", "1.0273", "1.5427", "1.0394", "0.8396" },
                    { "e36a91e9-8260-4177-a2a8-3d066ed5b690", "693ead45-f8c7-436a-a2cb-24403ba31113", "1.0319", "0.9924", "1.0318", "1.1087", "1.036", "0.2338" },
                    { "e3d173de-0231-45e4-90a8-78975417162b", "7ffa9eaf-59bf-4758-828b-32237fd29d38", "1.0012", "0.9999", "1.0001", "0.9998", "0.9992", "0.9967" },
                    { "e3fdfc74-ed17-4f9e-bc60-7694cfa34aef", "c0895e2e-0958-464a-aab9-35e4c94274a6", "1.0015", "1.0002", "1.0007", "0.9982", "0.9992", "0.9995" },
                    { "e56f1122-e620-4897-95fa-b43d92d44bcb", "7de962f7-a815-4c30-b191-4ea551ca3018", "1.0151", "0.9963", "1.2169", "1.5697", "1.1228", "0.7389" },
                    { "ebe55c42-5ef4-447a-adc1-a8ff001ab659", "9b56560e-252a-4109-83ca-fd465acb8405", "1.0062", "0.9962", "2.3628", "3.5283", "1.0767", "1.211" },
                    { "ee7e6e03-e1bf-4517-ad9e-ce9b655a0915", "928d30a6-da92-499e-83ad-bf7a9fbf0253", "1.0557", "0.9921", "0.8615", "1.1902", "0.9397", "0.7305" },
                    { "ef9b7199-504c-4474-a1d5-1268b14f556a", "9e6d72bc-20b6-44d9-9198-04b8a14840e1", "1.0301", "0.9961", "1.1802", "1.4353", "1.1875", "0.2352" },
                    { "efafe5d9-93bd-4bfa-a87f-004e4721f0bf", "73e6f05c-b73a-425c-a2bd-e2b34b866110", "1.0141", "0.9942", "0.9851", "1.1411", "0.9952", "0.4189" },
                    { "f037c1ce-1a07-4bcf-8765-15031283fdca", "043ebf5a-aff7-4428-b07e-e24588466d6d", "1.0461", "1.0032", "1.0085", "1.371", "0.9351", "0.2871" },
                    { "f104eddd-b8e2-4901-8a3f-b17bd17be517", "4e0b1c98-ba51-4106-bd2f-c8c2f93dc02c", "1.028", "0.9998", "1.1186", "1.1118", "1.0344", "0.8596" },
                    { "f1aa8938-dbb0-4a24-ba59-abd8f6322e1c", "19631629-bd8b-4b65-82d4-402ecb3a3f21", "1.0093", "0.9999", "1.0657", "1.0741", "1.011", "1.0337" },
                    { "f32b0b73-6035-4d31-b9a0-82b7bd808703", "5d76075b-fafb-48aa-904e-375a2885869b", "1.0172", "0.9949", "1.0646", "1.0195", "1.0078", "0.5355" },
                    { "f7aac25f-7ad2-408a-8459-680979a52348", "78e04947-e6da-44e8-baf3-30e124e5f040", "1.0264", "0.9943", "1.009", "1.1468", "1.0095", "0.4609" }
                });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "Uid", "Age", "AllTimeHighUSD", "Cap", "Code", "DeltaUid", "Name", "Rank", "Rate", "SiteUserId", "Volume", "png64" },
                values: new object[,]
                {
                    { "0285c0c0-3330-45b4-92ad-3c294cbf3ca0", "889", 165L, 1286469629L, "AXS", "4e7fe755-940a-4b98-b748-5cd8e0f14c6a", "Axie Infinity", 45L, 8.7608934428342931, null, 51937698L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/axs.png" },
                    { "043ebf5a-aff7-4428-b07e-e24588466d6d", "842", 45L, 646351012L, "FXS", "f037c1ce-1a07-4bcf-8765-15031283fdca", "Frax Share", 81L, 9.0715358525988101, null, 24544289L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/fxs.png" },
                    { "0623cc22-20c4-4daf-a3e1-dec2579d933a", "3172", 1L, 2803651541L, "XLM", "46314d5c-8ad4-4a79-a8f4-57b0767b9e70", "Stellar", 26L, 0.1048605169525406, null, 51728530L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xlm.png" },
                    { "08d3b36b-9b3a-409b-b507-a241e62786ce", "2453", 169L, 3128581467L, "ETC", "05c93b0d-4a46-43f6-a457-8b9ee903b6f7", "Ethereum Classic", 22L, 22.275222847304718, null, 199755588L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/etc.png" },
                    { "0cc32277-8be7-44d6-b455-c0fe51ee206f", "2111", 24L, 1394057151L, "EOS", "7044c542-d1b0-48b8-bf01-92054270758c", "EOS", 41L, 1.2654443359627325, null, 164795547L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/eos.png" },
                    { "13527571-5a11-48c7-b5e2-0e9a97a96714", "804", 42L, 1056339832L, "FLOW", "c9ae5527-ca58-436a-aa87-a5d4e00d16ac", "Flow", 50L, 1.0194362398508712, null, 23890678L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/flow.png" },
                    { "142b2ec1-6099-4c80-9506-c37b2840f919", "941", 13L, 774577600L, "GT", "e268ee73-6fd5-4c04-8078-7b7c10dca666", "Gatechain Token", 68L, 5.4945079961524126, null, 508581L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/gt.png" },
                    { "17a439f7-9afc-4cd9-8abe-01f567d45340", "316", 3L, 523108103L, "OP", "c0a48cf8-f630-4730-942c-757fc0e983da", "Optimism", 92L, 2.4359119352872192, null, 169354388L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/op.png" },
                    { "19631629-bd8b-4b65-82d4-402ecb3a3f21", "1295", 2222L, 527549554L, "PAXG", "f1aa8938-dbb0-4a24-ba59-abd8f6322e1c", "PAX Gold", 91L, 2042.9919540285246, null, 14703777L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/paxg.png" },
                    { "29043b33-e1bc-436e-b0bd-a195d04645bd", "1198", 9L, 450724496L, "KAVA", "71038e20-4d5d-412b-b42b-ac7c24de3f6f", "Kava", 98L, 0.94235684969696731, null, 16450427L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/kava.png" },
                    { "29af8297-534e-445f-9ed7-98e96f513093", "3208", 1L, 80650366506L, "USDT", "6e0a4a0b-9cf3-4657-8d95-f250ee709fb0", "Tether", 3L, 1.0008881832810113, null, 29981592764L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/usdt.png" },
                    { "2f25da7a-7122-4375-a22e-7b6e8135ccb2", "563", 86L, 647976770L, "__GMX", "47734fe7-b722-4a0c-9224-8dfda549d8b8", "GMX", 80L, 81.073507988673299, null, 38651507L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/__gmx.png" },
                    { "340b63fa-6a67-40bc-97bb-f851a93cda43", "2019", 3L, 14892005010L, "ADA", "2cd42260-a51c-43c7-ad94-68f1ddef5c2c", "Cardano", 7L, 0.42493925406676497, null, 400520948L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ada.png" },
                    { "36457ac4-3a79-41fa-8ad0-190f97684646", "392", 27L, 1651519237L, "APE", "d973d455-9c40-49c5-94c4-dd050565e3f2", "ApeCoin", 35L, 4.4805947930215595, null, 197598811L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ape.png" },
                    { "38dd5c25-20d0-437e-8d6a-a50a707a2b3d", "909", 238L, 2510872731L, "FIL", "6039f63e-127d-4768-bb83-cd9699a71a63", "Filecoin", 28L, 6.0535867293097585, null, 132878881L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/fil.png" },
                    { "3b35cfdb-dd3c-4df8-a229-25d2bfb84714", "520", 84L, 532259706L, "ENS", "0d3870c1-b02c-4a8b-b9ae-2f16379ea0c6", "Ethereum Name Service", 90L, 13.590619143368228, null, 27588209L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ens.png" },
                    { "3d3463df-61c3-4009-a70e-bef4a53f5177", "970", 7L, 825120005L, "CRV", "94722f5d-5657-40df-9582-48ad46fe2821", "Curve DAO Token", 63L, 1.0631347154224129, null, 50675677L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/crv.png" },
                    { "44bbd8a4-0e7d-46c5-8c63-5bcbac6bb07c", "2035", 53L, 3847806271L, "LINK", "2106dde6-f646-433e-94ac-12b19abc163f", "Chainlink", 20L, 7.4411264640052144, null, 213379211L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/link.png" },
                    { "4840d130-14dd-4fa7-bbad-49a04769daef", "3405", 1L, 11522625745L, "DOGE", "c16a76a8-85ba-467d-82bb-20459cc6ef92", "Dogecoin", 8L, 0.086851280356138386, null, 580249613L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/doge.png" },
                    { "48cb8b2a-5b21-454f-b1f8-604e7419d53a", "675", 1L, 486891673L, "AGIX", "1f96d094-6682-4846-84b1-7020513a6b4e", "SingularityNET", 93L, 0.40368364922792982, null, 65325438L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/agix.png" },
                    { "4919d6a4-b9d0-4e32-9627-150bbf549eaa", "2051", 4L, 484033579L, "LRC", "4355bad6-95b3-42ed-855c-8e30e61aef7a", "Loopring", 94L, 0.36153227169751667, null, 26078150L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/lrc.png" },
                    { "4b899616-90af-4eca-bd3a-de8d84166c15", "21", 12L, 5445384888L, "ARB", "9ce55b59-8d71-425f-9b45-fed60591aa0f", "Arbitrum", 19L, 1.3548179589002987, null, 1046271860L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/arb.png" },
                    { "4e0b1c98-ba51-4106-bd2f-c8c2f93dc02c", "4205", 413L, 6867505577L, "LTC", "f104eddd-b8e2-4901-8a3f-b17bd17be517", "Litecoin", 14L, 94.466823379278523, null, 506762508L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ltc.png" },
                    { "501151c3-c34f-4279-940c-1fa83d6f8f6f", "2376", 44L, 2818399814L, "ATOM", "501148e1-156e-44fe-b16e-09d2e3a19320", "Cosmos", 25L, 11.815959899295345, null, 127011892L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/atom.png" },
                    { "510d6b86-740a-430a-aa4e-a624475ac30d", "1894", 40L, 779841435L, "HT", "713737f8-b65f-4e5c-9294-ddcd28da7768", "Huobi Token", 67L, 3.8257985724268013, null, 16402020L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ht.png" },
                    { "514063ef-a3f2-455c-b57c-f7d11e8ad40c", "2129", 6L, 617694856L, "MIOTA", "b077ef0b-6e8e-49fc-a461-c8d0566d4e2d", "IOTA", 82L, 0.22222994285848705, null, 5754165L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/miota.png" },
                    { "59016292-8420-465c-b85e-c147db54d757", "1839", 9L, 1044099181L, "XTZ", "9543a1d7-f33b-4e6f-b75d-cf30eacd3ad8", "Tezos", 51L, 1.117674002603652, null, 13413660L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xtz.png" },
                    { "59d992ee-c0d9-4fdb-b269-4dfb015cbf85", "618", 11L, 454317232L, "OSMO", "3921a445-0fb1-4bfc-8854-bc0d6ac4adc9", "Osmosis", 96L, 0.80657164263503145, null, 10831520L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/osmo.png" },
                    { "5bcf7151-482c-4947-bd1f-81b77f63a36e", "742", 4L, 780230689L, "_KLAY", "9595fad0-8637-4655-8a50-4996099cd721", "Klaytn", 66L, 0.25288983619249283, null, 96165252L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/_klay.png" },
                    { "5d76075b-fafb-48aa-904e-375a2885869b", "1372", 1L, 699581929L, "CHZ", "f32b0b73-6035-4d31-b9a0-82b7bd808703", "Chiliz", 74L, 0.13090821005850312, null, 79719095L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/chz.png" },
                    { "5e6e5c02-4835-48c8-8a58-a361ee5d3c26", "1706", 427L, 1497475701L, "QNT", "c055f1f1-c9ad-44e8-84bb-d221adaf28e8", "Quant", 40L, 124.03778671920671, null, 22989970L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/qnt.png" },
                    { "65f1cc11-3737-450a-bc4d-5c991d7587e6", "1912", 16L, 1074858108L, "THETA", "d48398ba-5a2e-43de-90f4-2dfde1ac3a46", "Theta Network", 49L, 1.0748581079631161, null, 20049268L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/theta.png" },
                    { "6645470a-fb78-4250-bb0f-3448126c30c6", "322", 0L, 583907727L, "KAS", "a569971c-76c0-423e-aac4-c3d9de9bd362", "Kaspa", 86L, 0.032612547915839396, null, 18569847L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/kas.png" },
                    { "66722ced-88a9-4224-ba4f-ca355c0131ca", "3282", 517L, 2966640940L, "XMR", "bb7bba5f-2a7a-42c1-9a6a-c37cf603c5df", "Monero", 23L, 162.41889788396699, null, 70093418L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xmr.png" },
                    { "67bdb076-5ece-4727-886c-1fcf9f0264fe", "650", 0L, 615081473L, "XEC", "ccdc40d3-7164-43a5-86af-d2be1bd511e4", "eCash", 83L, 3.1770908082477563E-05, null, 4034928L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xec.png" },
                    { "693d598a-2a76-4e25-bea3-8f5b98258798", "938", 45L, 2925381898L, "UNI", "9335e839-da02-46e2-9cf2-b763bf9283c2", "Uniswap", 24L, 6.195608698729786, null, 99949699L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/uni.png" },
                    { "693ead45-f8c7-436a-a2cb-24403ba31113", "970", 8L, 1213382309L, "SAND", "e36a91e9-8260-4177-a2a8-3d066ed5b690", "The Sandbox", 46L, 0.6665903180573155, null, 116041705L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/sand.png" },
                    { "710e8975-70e4-460e-bf9e-8e06ad803cfd", "900", 20L, 1941871015L, "NEAR", "543950a0-4a92-4ad7-8da5-8b4feb969e1c", "NEAR Protocol", 32L, 2.1966128181102982, null, 176283114L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/near.png" },
                    { "73e6f05c-b73a-425c-a2bd-e2b34b866110", "799", 0L, 6529338418L, "SHIB", "efafe5d9-93bd-4bfa-a87f-004e4721f0bf", "Shiba Inu", 16L, 1.1079815049231357E-05, null, 177337714L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/shib.png" },
                    { "75d0840a-ff0e-462e-8af4-6b4f03730e6c", "2034", 6L, 1349697366L, "MANA", "c6e17fb1-c913-455a-892c-b1cb93c3aa52", "Decentraland", 42L, 0.61540675203591522, null, 100343643L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/mana.png" },
                    { "78e04947-e6da-44e8-baf3-30e124e5f040", "911", 663L, 1160144987L, "AAVE", "f7aac25f-7ad2-408a-8459-680979a52348", "Aave", 48L, 80.770928125200655, null, 90749892L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/aave.png" },
                    { "7be61c74-40c0-47b1-855e-01f5dc39843a", "5213", 68781L, 586709801651L, "BTC", "110aa5ae-849f-47f1-ace5-3c4e9f7d72e1", "Bitcoin", 1L, 30328.198749641579, null, 12110337907L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/btc.png" }
                });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "Uid", "Age", "AllTimeHighUSD", "Cap", "Code", "DeltaUid", "Name", "Rank", "Rate", "SiteUserId", "Volume", "png64" },
                values: new object[,]
                {
                    { "7c7f1ccb-5cb7-435b-b7b6-c8536fb34797", "1198", 3L, 1204098652L, "_STX", "5819d334-8fdc-474f-ab9f-3b472322d203", "Stacks", 47L, 0.87687742582793438, null, 121602900L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/_stx.png" },
                    { "7de962f7-a815-4c30-b191-4ea551ca3018", "1532", 69231L, 3594285291L, "WBTC", "e56f1122-e620-4897-95fa-b43d92d44bcb", "Wrapped Bitcoin", 21L, 30387.424050003468, null, 210801018L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/wbtc.png" },
                    { "7ffa9eaf-59bf-4758-828b-32237fd29d38", "1864", 2L, 855538288L, "TUSD", "e3d173de-0231-45e4-90a8-78975417162b", "True USD", 59L, 0.99974566674995036, null, 56647944L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/tusd.png" },
                    { "80b601d0-0bb5-4de5-9f9f-ba5b8b7e94b5", "1291", 1L, 2031619214L, "HBAR", "0bdd2174-1855-4413-892e-a98da63f8c2c", "Hedera Hashgraph", 31L, 0.066320362634824354, null, 42902466L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/hbar.png" },
                    { "8a4d0d70-f6df-4a80-83e3-319db12b15b2", "706", 40L, 483242748L, "CSPR", "cfe82f24-7800-4b34-a83c-3dfd3666d0dc", "Casper Network", 95L, 0.044268223688168698, null, 7331958L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/cspr.png" },
                    { "8aac9925-c2f8-4479-8597-c0b2d0185d06", "1301", 1L, 6753399417L, "BUSD", "16846623-52f1-47c1-b3ba-c8c57b70c409", "Binance USD", 15L, 1.0019091540080731, null, 2131249600L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/busd.png" },
                    { "8b425bab-28b1-40fc-b929-beb57cdb412b", "1658", 1L, 928656143L, "USDP", "46805839-692a-4169-93db-57f6181e4d45", "Pax Dollar", 55L, 0.99880958981750056, null, 423611L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/usdp.png" },
                    { "8cc2bbb7-c50c-455b-ab13-6a0deaffead3", "1933", 1L, 9349403278L, "DAI", "a830e775-1fcb-45f0-bc67-c8345befcae1", "Dai", 12L, 0.99896975301912971, null, 145345881L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/dai.png" },
                    { "8d8e3bd8-62da-4e7a-9eec-4479c44eedcf", "963", 55L, 7216234937L, "DOT", "59ec5852-d778-45b8-a4c1-1d499a249364", "Polkadot", 13L, 6.5941059350564526, null, 196136715L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/dot.png" },
                    { "928d30a6-da92-499e-83ad-bf7a9fbf0253", "827", 7L, 2091528832L, "LDO", "ee7e6e03-e1bf-4517-ad9e-ce9b655a0915", "Lido DAO", 30L, 2.4161572053155989, null, 123572048L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ldo.png" },
                    { "965647d6-c5ac-4969-897f-cb814655a1be", "884", 2L, 813159667L, "CFX", "b6933c09-f3d0-4924-a89f-36957e1833c3", "Conflux Token", 64L, 0.38767397643673057, null, 267248994L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/cfx.png" },
                    { "97b96933-b2ea-4b8a-9fd7-a41be2ac357c", "1532", 0L, 588833375L, "BTT", "8657258c-68dd-4dbe-b9de-0b403b3d1412", "BitTorrent", 85L, 6.1889839871637984E-07, null, 9281947L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/btt.png" },
                    { "9b56560e-252a-4109-83ca-fd465acb8405", "1189", 0L, 665049722L, "_SURE", "ebe55c42-5ef4-447a-adc1-a8ff001ab659", "inSure", 78L, 0.0076776003523308248, null, 3034637L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/_sure.png" },
                    { "9b7ad908-0213-49cc-af81-04f917bdfb5e", "1996", 28L, 668334731L, "KCS", "46560da1-f75e-42a3-8726-ff0dc96fb074", "KuCoin Shares", 77L, 8.8355279000857276, null, 1364003L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/kcs.png" },
                    { "9cb88f89-f3a9-4cf9-a1f9-094b251a1245", "693", 60L, 443590805L, "CVX", "bab5131a-a632-4129-8dce-7396e3535797", "Convex Finance", 100L, 5.8113251636007464, null, 10949452L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/cvx.png" },
                    { "9da30b98-470c-43f3-a964-20095687022e", "1443", 59L, 10454208201L, "OKB", "8e8f1194-5a2e-4cec-a0ad-066212e0429f", "OKB", 9L, 43.296753238680481, null, 10300220L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/okb.png" },
                    { "9e6d72bc-20b6-44d9-9198-04b8a14840e1", "1096", 260L, 9643105628L, "SOL", "ef9b7199-504c-4474-a1d5-1268b14f556a", "Solana", 11L, 24.622276579457843, null, 599873521L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/sol.png" },
                    { "9e8cbd9e-2f62-4aa6-88e2-9a593d28179c", "590", 3L, 950876060L, "__BIT", "38758cf3-3e1d-4a98-9df7-ea32b2009897", "BITDAO", 54L, 0.52140798636966734, null, 4058412L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/__bit.png" },
                    { "a055e335-b7d0-4a4e-92ba-64dbd4b10757", "2081", 4356L, 2650155454L, "BCH", "df213624-30ec-42ff-9a4d-06aee99fb71b", "Bitcoin Cash", 27L, 136.86199605416891, null, 70687185L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/bch.png" },
                    { "a0beacc8-4dbb-49aa-af01-8858c29ac66c", "675", 0L, 537254667L, "BABYDOGE", "3f1dbad0-9f9b-4d4a-bbe2-c339491fd86f", "Baby Doge Coin", 89L, 2.4980008270697834E-09, null, 10275593L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/babydoge.png" },
                    { "a1414068-9ebe-45bf-a3aa-2c7d9c134bd2", "2038", 0L, 6025817589L, "TRX", "bb95f0a9-dc35-458e-a3c9-f9c40a1cce1e", "TRON", 18L, 0.066335058912063344, null, 181564796L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/trx.png" },
                    { "a4058938-bf94-4236-a503-1777d8c2b560", "1626", 3L, 1297548084L, "FTM", "324e4994-9448-4013-b1ea-1471b68aecbc", "Fantom", 44L, 0.51061396968355321, null, 312600111L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ftm.png" },
                    { "a7eea96c-be36-490d-9cf9-5f3956328f84", "1359", 21L, 549835701L, "RUNE", "6d918399-2327-4eff-84f1-b4c901e3a610", "THORChain", 87L, 1.6321258352499231, null, 31640143L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/rune.png" },
                    { "aa3304f1-880c-4ea5-884b-b7159182986c", "727", 188L, 694182713L, "MINA", "487adfdb-b314-4a35-a574-e5817484c949", "Mina Protocol", 75L, 0.78559999246932066, null, 48803309L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/mina.png" },
                    { "aa4f1597-ab20-402c-9e66-5068e915fbe8", "1198", 62L, 880725615L, "RPL", "a13d959c-27bd-423c-a6f3-af30dfe9813f", "Rocket Pool", 58L, 46.078929767765544, null, 15099734L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/rpl.png" },
                    { "ab94e930-67a5-465c-a26f-ffc25cb3eab5", "1391", 3L, 1575340028L, "ALGO", "06231693-5101-450c-bcac-dd8bf0b25a92", "Algorand", 38L, 0.21861473534216658, null, 59994706L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/algo.png" },
                    { "b4a16ca6-c222-40a4-a491-9b7c2ff3abbe", "1647", 1L, 31890674516L, "USDC", "0c0ce570-2c92-4800-a050-350abdf6bc72", "USD Coin", 5L, 0.99906956237183553, null, 2131442649L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/usdc.png" },
                    { "b974bde3-c42c-4456-9fc7-6d03898f75ec", "2276", 119L, 828116098L, "LUNC", "b117c409-b548-4de6-b43c-1a82251c8cdb", "Luna Classic", 62L, 0.00012669284582174738, null, 60224966L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/lunc.png" },
                    { "ba647049-6ca9-45d1-ada4-1ed2b1de0f7b", null, 15L, 730176154L, "WBT", "7f0fce8a-fa98-4d96-93e2-ce8a2f7ca570", "WhiteBIT Token", 70L, 4.8137561350336462, null, 2385277L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/wbt.png" },
                    { "ba7f33e8-3322-4d82-9816-028bcbe9b8f9", "2112", 692L, 51303060046L, "BNB", "02cf06a7-ff46-47d0-908c-02e226accbd9", "BNB", 4L, 326.31460014781129, null, 601475322L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/bnb.png" },
                    { "bdb5cd88-2e67-4379-b710-e857daf10e69", "586", 1L, 803419209L, "XRD", "6a0a4bd9-b88a-4c0f-b29a-c734fd0c7167", "Radix Native Token", 65L, 0.079177929219493154, null, 16144664L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xrd.png" },
                    { "c011693c-73e4-406d-a422-df7bfcda5631", "1419", 0L, 451724888L, "RSR", "dc0eacff-30f0-4a48-898f-76c9fc983b71", "Reserve Rights", 97L, 0.0045180395383625487, null, 10588914L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/rsr.png" },
                    { "c0895e2e-0958-464a-aab9-35e4c94274a6", "842", 2L, 912592048L, "FRAX", "e3fdfc74-ed17-4f9e-bc60-7694cfa34aef", "Frax", 56L, 0.99870729767877375, null, 4632040L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/frax.png" },
                    { "c409c523-224b-4e9e-a2b4-46bd7b02d255", "1445", 3L, 10422239560L, "MATIC", "83c25faa-80f1-4ddb-a432-af20a9a881ce", "Polygon", 10L, 1.1304598432321304, null, 277086510L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/matic.png" },
                    { "c41f328c-8356-461f-b9ea-3ff9026e78fc", "1492", 1L, 1742687263L, "CRO", "810e6138-478a-465d-8c46-a33a92f79710", "Cronos", 34L, 0.068981764580794316, null, 7649509L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/cro.png" },
                    { "c7647942-360f-4acf-aef9-c6936dcba0a7", "839", 9L, 443724164L, "1INCH", "0751b2a5-78f0-44a1-96bf-2935a489c9e1", "1inch", 99L, 0.54478528873423893, null, 25365079L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/1inch.png" },
                    { "c895f366-7082-41db-9eb8-bdbb29757b32", "2264", 6299L, 730593589L, "MKR", "35df841e-ee10-4424-b331-5215bf77b370", "Maker", 69L, 747.31017008504386, null, 32172507L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/mkr.png" },
                    { "cbc1556c-0ffe-4ef7-9786-165fe109d40f", "767", 4L, 971061789L, "MX", "7307681e-c273-428b-b239-72ecbf4689c4", "MX Token", 53L, 2.2210928294677328, null, 11230083L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/mx.png" },
                    { "cc162449-6afb-40c5-8d7f-e7fdf489ccd8", "975", 14L, 2194180620L, "SRM", "4c4e395f-7e2c-4326-ab97-8a8152264feb", "Serum", 29L, 0.21594670202632751, null, 57598923L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/srm.png" },
                    { "ccae3fc4-96e6-466a-af4a-153bbd14dc88", "933", 146L, 6153496756L, "AVAX", "1225e89f-bd61-4ee7-9f1d-c88e4b1654d5", "Avalanche", 17L, 18.864857950030537, null, 273147965L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/avax.png" },
                    { "cd4df56c-2ee3-43e3-8b9b-6006f188da30", "916", 44L, 677474395L, "CAKE", "b9d99efc-b689-423e-9681-8b298509aac8", "PancakeSwap", 76L, 3.6559057060612723, null, 52025532L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/cake.png" },
                    { "cd9554fd-5c6f-4f81-86f5-29edd872c53d", "847", 3L, 1327911676L, "GRT", "dd4b9380-fe3d-4b44-b6c8-531e185920ea", "The Graph", 43L, 0.15024820642818762, null, 63528779L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/grt.png" }
                });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "Uid", "Age", "AllTimeHighUSD", "Cap", "Code", "DeltaUid", "Name", "Rank", "Rate", "SiteUserId", "Volume", "png64" },
                values: new object[,]
                {
                    { "cf5edf10-43dd-4d1b-b42f-7aad5e3a1e46", "2356", 2218L, 728613411L, "ZEC", "6b84023f-3def-4469-b650-ad6cb4681f35", "Zcash", 71L, 44.622822872541775, null, 67990465L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/zec.png" },
                    { "d15b0d27-b4ae-4b46-b68b-aae11404e215", "345", 1L, 718573479L, "USDD", "248d9f21-cc91-4082-8688-8ac524f5f867", "Decentralized USD", 72L, 0.99068212104553866, null, 19909392L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/usdd.png" },
                    { "d4f3e90c-2ef4-410a-99a8-fdfb85c66e19", "524", 9L, 1548206265L, "_IMX", "ac301dca-3f27-465e-bc06-94f2955b3928", "Immutable X", 39L, 1.1334500380214361, null, 59935349L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/_imx.png" },
                    { "d5616321-c0ec-4894-bbc5-c7a0ebb1ad5b", "4120", 4L, 26621449102L, "XRP", "c7967843-ae09-4832-a25a-7b37cf737140", "XRP", 6L, 0.51441608174902442, null, 924923532L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xrp.png" },
                    { "d59a3eed-2b15-4ca9-a876-1252098f44bc", "1610", 491L, 700363684L, "BSV", "5632943a-f882-42b6-9a23-4e1f756cba22", "Bitcoin SV", 73L, 36.352170713002614, null, 13024930L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/bsv.png" },
                    { "daf45a24-6ae5-466c-a687-6f3e56941b84", "951", 548L, 1036526264L, "EGLD", "b6324aa6-8347-4dcf-8a93-437af7115595", "MultiversX", 52L, 41.016003940720196, null, 20727486L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/egld.png" },
                    { "df9dd654-09b7-40f2-bb3e-c7ee28047169", "702", 495L, 1650816962L, "ICP", "459916f8-ef50-476a-8679-39cd64934054", "Internet Computer", 36L, 5.4603279459398069, null, 44688712L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/icp.png" },
                    { "e15b365c-8e09-4bbb-af55-a782fe3bf74f", "3344", 1642L, 651136662L, "DASH", "42188ef2-eacf-4ae0-b091-bf50ce2d9a55", "Dash", 79L, 57.983550702574263, null, 65698320L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/dash.png" },
                    { "e514d76a-4935-4289-9e90-3ff107fef186", "176", 20L, 1594170040L, "APT", "28d7195a-894b-4b3c-a87f-02c3d26bbd3c", "Aptos", 37L, 12.262846463104303, null, 310152845L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/apt.png" },
                    { "ecb82c60-ef2f-4f5e-b9d2-0d4dbc206c4b", "2060", 0L, 1835849605L, "VET", "d66439f5-22ef-4afd-b4b2-e1e78cf1bc56", "VeChain", 33L, 0.025318171012815527, null, 41907992L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/vet.png" },
                    { "f5c040ca-b52a-4239-ab6b-a7c074cd8c35", "2406", 196L, 892570611L, "NEO", "9c5d62f6-0ac8-4a9e-b348-eda5aeeacbe2", "NEO", 57L, 12.36252589362473, null, 30596279L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/neo.png" },
                    { "f62b4311-44d5-4978-a00d-c51fc00eea3e", "1838", 0L, 592646573L, "XDC", "c8c83405-f4f2-493b-baa4-1b7c5dae3c8f", "XDC Network", 84L, 0.042856757030258409, null, 3944111L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xdc.png" },
                    { "fab71830-5bf8-4d72-952a-dbba03dd3a97", "2814", 4861L, 245902442713L, "ETH", "1f36fb79-1adf-4ebb-bb1a-89b333ab3f04", "Ethereum", 2L, 2009.4359257497333, null, 11770158389L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/eth.png" },
                    { "fe069cf3-e476-46d8-b6a6-3f193b2f7c0c", "903", 25L, 537776849L, "INJ", "0835fbc5-6f64-4a4b-8317-b6966548e61a", "Injective Protocol", 88L, 6.7217437819127657, null, 107047190L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/inj.png" },
                    { "fee6213e-cb45-4846-8f5c-383087a62841", "1586", 29L, 831268461L, "SNX", "cd04fe79-d91e-4315-9ec3-880646793ea3", "Synthetix", 61L, 2.6283183340026004, null, 48403838L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/snx.png" },
                    { "ff3af06c-a068-4191-9d61-67282a34c733", "1028", 9L, 843087392L, "RNDR", "b9e1db6d-b48b-4762-bf9b-9e8562c4bb26", "Render Token", 60L, 1.5876871134321542, null, 87863143L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/rndr.png" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coins_SiteUserId",
                table: "Coins",
                column: "SiteUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coins_AspNetUsers_SiteUserId",
                table: "Coins",
                column: "SiteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
