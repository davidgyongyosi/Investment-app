using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestmentApp.API.Data.Migrations
{
    public partial class dbseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7872ee76-a15c-414f-bbde-adcc75e11bcb");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureContentType", "PictureData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2e590081-b7b5-4ad1-9b11-76f9d8bddab2", 0, "0668b578-639a-4f46-bd3b-35219cff46e3", "admin@admin.adm", true, "Super", "User", false, null, null, "SUPERUSER", "AQAAAAEAACcQAAAAEM9AZmwNtpEwyAKZuMPtStcp60ZGxgzbfrJbXgu2jW0vsmnkaHHI2OGHtV6++6o+0w==", null, false, null, null, "432b18ff-81bc-439c-839b-99a90462b2ac", false, "superuser" });

            migrationBuilder.InsertData(
                table: "Deltas",
                columns: new[] { "Uid", "CoinUid", "day", "hour", "month", "quarter", "week", "year" },
                values: new object[,]
                {
                    { "01539b3d-ba30-4cbd-af2a-5e755f9da5cb", "51f469e4-bd1f-429a-a101-94997d669b7f", "1.0369", "0.997", "1.1888", "2.449", "1.1299", "0.9112" },
                    { "01954976-aa52-4e23-8398-950e48520695", "a81a9705-f973-40fc-a482-f67e8eb47b21", "1.021", "1.0043", "1.3642", "1.3607", "1.0078", "0.7121" },
                    { "0608eff1-8690-4e9c-84a5-1e31fa2f90bf", "2ecc07d5-c086-4dc0-9e02-ca5cc742ddbf", "1.0494", "0.9959", "0.8899", "0.971", "1.0331", "0.4758" },
                    { "0ab416db-d658-44d0-80a6-4d9e7a89fa3f", "7c5d7525-7ca3-43de-b4ef-000ef0416962", "1.0246", "0.9895", "0.9753", "1.0318", "1.029", "0.9331" },
                    { "0b06f4e2-7db0-40bb-accb-1c0217e736ae", "82e992e8-857a-4f05-be4f-03e8a49c0594", "1.0016", "0.9988", "0.9635", "1.1126", "0.9824", "1.0779" },
                    { "0b2a0434-9e21-49a2-afaa-bb12ee3eec80", "8a0c166e-ed8e-4caa-bdde-6c5bb3552b2e", "1.0218", "0.9964", "1.0649", "1.7", "0.9823", "0.5832" },
                    { "0d0b68a9-a84e-45d3-aebc-cbd4471bc8b7", "2f1d8bc1-331d-469b-9e97-937b01d14093", "1.0072", "1.0015", "0.9582", "1.0328", "0.996", "0.4449" },
                    { "0ecba28a-74c5-43ed-aecf-a8c0706b44e2", "b6efae7f-83ec-41c2-87f7-d4378d00ddb1", "1.048", "0.9975", "1.1325", "1.2779", "1.0231", "0.5462" },
                    { "12a0fdae-a703-4e52-9e41-854ca3a3b461", "fefecaec-5ac3-4925-87ca-bfe5db3d5e6a", "1.032", "0.9985", "1.4135", "1.5832", "1.0594", "0.783" },
                    { "18ce346f-557d-48a9-b56c-c168760902d0", "ffbe895f-6d1a-4ece-b397-fa6de58d2c62", "1.0216", "0.995", "1.0224", "1.1148", "1.0365", "0.3999" },
                    { "198b9ff0-80c3-47d6-838d-b4ae9cc9b4a1", "5418b5bc-9ce5-4856-a425-4637a6b9c4c6", "1.032", "0.9933", "1.0428", "1.2469", "1.034", "0.3636" },
                    { "23bc1b0c-863a-48b4-9065-314a805e3f8a", "c32fef2c-5f6a-4614-91a4-2cc3fa83a6d1", "1.0428", "0.9981", "1.0508", "1.296", "1.0267", "0.4133" },
                    { "24da6561-b53f-4be1-8b82-b27e48595fa7", "d93a67ef-378e-465f-85c4-08e46704de40", "1.028", "0.9998", "1.1186", "1.1118", "1.0344", "0.8596" },
                    { "27bd3fbc-464f-413d-86fa-d29480534cb4", "a563428a-03f6-4abd-8dc3-2fd11d1c55d5", "1.0201", "0.9941", "0.9952", "1.0141", "1.005", "0.2957" },
                    { "2a2823b1-0c2d-44b8-9400-b1c2ea532e71", "a2b2d551-21df-491f-835b-c6beebb0b408", "1.1373", "0.9895", null, null, "1.1208", null },
                    { "2bc3cbd0-9d10-4258-8a85-9e976f5c4b2e", "25740240-c20a-41b0-893b-d0ba8b8df986", "1.0282", "0.9886", "1.0137", "2.3016", "0.9994", "0.9456" },
                    { "2bd2f5ea-c6a8-4ada-81d0-aee6031dab92", "a65575a9-4072-4789-a7c3-25401baf70d9", "1.0403", "0.9972", "0.8918", "0.9821", "1.0165", "0.1339" },
                    { "2c07bd39-0abd-4ba2-a0f9-96841c4dfb1d", "85041870-7421-42bf-a183-35056a6349e8", "1.0372", "0.994", "1.0597", "1.3917", "1.0605", "0.4696" },
                    { "2cda2510-5294-413c-8e8b-394edf940605", "4ea72bac-fb00-4964-a6a2-726b1a2f04b4", "1.0062", "0.9962", "2.3628", "3.5283", "1.0767", "1.211" },
                    { "3125e3f6-6264-4408-8433-ccdbc3f8d56d", "49d3883b-95a0-4f01-912b-4fc51c1fccf5", "1.0093", "0.9999", "1.0657", "1.0741", "1.011", "1.0337" },
                    { "31faf842-e214-41c6-8c0a-75ba32e51d36", "c5af080b-aca1-467c-a0d8-7b75c0c68b4d", "1.0015", "1.0002", "1.0007", "0.9982", "0.9992", "0.9995" },
                    { "3263aedb-1a1f-46b8-9636-ce44cb1674e5", "543b513d-2652-482f-b072-b4204c646c68", "1.0063", "0.9966", "0.9453", "0.7312", "1.0229", null },
                    { "331e2c91-9ebf-46e0-bc3c-a0740d856d72", "89fdd974-aac0-4afc-af87-a41975ed23eb", "1.0014", "1.0002", "1.0008", "0.9982", "0.9995", "1.0006" },
                    { "35627d9d-b4d0-4139-bb77-75c09e8b2088", "d4c96869-ae1a-43fd-b7ff-16755347baf2", "1.005", "1.0077", "1.59", "4.367", "1.1586", "1.2163" },
                    { "35d23e80-fefb-4242-938a-ce060a96b79b", "9254ac5a-d541-4f5c-bdda-e31093e8313d", "1.02", "0.9931", "0.9194", "1.2462", "0.9764", "0.3547" },
                    { "3cbf5774-d7bf-4252-98d8-046d39a786fa", "33103bf4-495b-4818-afaf-8dd76d0ddf3d", "1.0007", "1.0002", "1.0022", "0.9987", "0.9997", "0.9922" },
                    { "3f67de36-5819-4013-9bda-76358df9d1e2", "ee0b9381-1fb2-41f8-a6aa-3afc0a21d906", "1.0337", "0.9961", "1.0162", "0.9273", "1.0669", "0.3514" },
                    { "40c822a5-9ba8-449a-9733-3ad8cea79852", "9a39bd25-9b2f-43df-b44a-b6a2b1175c8a", "1.0526", "0.9945", "1.1633", "1.0759", "0.9539", "0.6201" },
                    { "40e84bad-f0aa-45ab-bf2a-02784c0be650", "c88947ea-7ca9-4e2b-b2d7-0576fad2b782", "1.0198", "0.9914", "0.9879", "1.1483", "1.0075", "0.5478" },
                    { "41d255ea-8acb-44a9-98a8-87c5e874c91a", "10a44298-c9a1-46a9-b654-54db88ae1869", "1.0191", "0.9967", "0.9639", "0.8558", "0.9934", "0.4214" },
                    { "4d345cc7-af65-4238-8909-4734c04f6830", "50a060da-9326-4626-90af-1b40e019c8db", "1.0145", "0.996", "1.2151", "1.5635", "1.0772", "0.7361" },
                    { "4e9afe76-c1df-4b49-8cfb-792fc08f664e", "ac1e2cf4-4e56-4ad6-ba48-a66cb4525da5", "1.0311", "0.9942", "0.9478", "1.2353", "1.008", "0.7982" },
                    { "4e9b379b-4d48-49c5-a798-503c4fc565ce", "1e565033-830b-44d1-b489-58f269892d17", "1.0247", "0.9905", "0.9683", "2.0002", "1.0255", "0.3914" },
                    { "4f1d994e-5b37-48cb-bdfb-3ac1397f3753", "76126682-369b-443e-9866-98510cc41e05", "1.0429", "0.9919", "1.0917", "1.1994", "1.0388", "0.2346" },
                    { "4fdbce7d-bf41-4ec6-84e3-af90d83e4251", "182f58e2-d4ea-45c0-927c-cac93713f01f", "1.0225", "0.9892", "0.8715", "1.3718", "0.979", "0.5173" },
                    { "50fc142c-d6c0-4bbe-9a4f-f3afa8f099b6", "2feb1110-3721-4152-bb9a-52f8c415a0cb", "1.0461", "1.0032", "1.0085", "1.371", "0.9351", "0.2871" },
                    { "56fbec66-7b2b-42dd-9848-6fc2aaa5634c", "e7e843d6-f373-4f29-bb94-519416689bc3", "1.0013", "1", "0.9985", "1.0005", "0.9995", "0.999" },
                    { "5773a323-e45f-4698-9bcd-f2ab0b5b83d2", "75431122-53f8-4630-b207-868f5159830b", "1.0141", "0.9942", "0.9851", "1.1411", "0.9952", "0.4189" },
                    { "5d1439ef-8b1a-41d8-a7cc-6907ac2cbb3b", "170cca9c-3459-435e-b048-179b19819c88", "1.0014", "1.0009", "0.9975", "1.0103", "1.0027", null },
                    { "62b1ce5c-2c27-41d5-bd60-165dd4509765", "6eeb8a05-bc80-4658-af09-41e2d914c89f", "1.0228", "0.9897", "1.2911", "15.2606", "1.0296", "2.2857" },
                    { "62fc596d-cd35-4c1f-8835-fa74b5f6dab7", "bf4de514-bd16-47bd-9ed4-ed3ee82a8a2d", "1.0103", "1.0006", "0.9076", "0.7213", "1.0622", "0.4108" }
                });

            migrationBuilder.InsertData(
                table: "Deltas",
                columns: new[] { "Uid", "CoinUid", "day", "hour", "month", "quarter", "week", "year" },
                values: new object[,]
                {
                    { "699c6eb8-f196-4bf5-a06a-da573293799d", "a6ddd36b-4458-4148-8d75-b11a528d2907", "0.9745", "0.9854", "1.1625", "0.9999", "1.0092", "0.2974" },
                    { "6b71f274-0db1-4877-8757-f58ab5780672", "cd32473f-b885-4957-8cb7-bb3bc6fd0a96", "1.056", "0.9995", "1.0552", "1.2429", "1.0179", "0.343" },
                    { "6f555fe7-9b31-401c-ad85-a4cab3363abb", "3e65bc00-e1e5-488e-9fb9-9c42e93f46e8", "1.0076", "0.9966", "1.0795", "0.9665", "1.0318", "0.6951" },
                    { "6fba972a-3762-491f-840b-0882db77608b", "009b97d0-35f9-472c-b5f6-3719496540ce", "1.0249", "0.9954", "1.0052", "1.057", "1.0236", "0.1803" },
                    { "779103b8-c7d9-4572-93b9-1552feb51904", "2937cd96-5358-4819-9cd0-9704dfda2aca", "1.0832", "1.0045", "1.059", "1.7174", "1.0047", "1.3894" },
                    { "7b007890-e446-43b5-840c-89268a84525b", "2b4f6d95-983f-44de-862c-282a44d93dc1", "1.0177", "1.0007", "1.0522", "1.1287", "1.0363", "0.7739" },
                    { "86c6ea59-967a-47c0-9cba-9130a0b145a2", "f04aea14-7635-428e-8567-ebe00a5317aa", "1.002", "0.9984", "0.9554", "1.1226", "1.0073", "0.4407" },
                    { "87eeeb5f-cfe5-48c3-94b5-227745889a70", "9d43d0e4-1844-4010-ad4c-502cfdf15d7e", "1.0162", "0.9976", "0.9458", "0.9821", "0.9948", "0.1641" },
                    { "883e879f-629f-4fcc-a939-07bf351c32f3", "f88e6a29-d675-4b83-86b1-3b3a099df0b9", "1.0508", "1.0059", "1.2188", "1.2707", "1.1054", "0.4397" },
                    { "89989032-82e0-4d0e-ae03-3c930e7f01ee", "421a3f3e-fa92-4021-b4c8-65711ddc9b9e", "1.001", "1.0008", "0.9991", "0.9991", "1.0005", "1.0002" },
                    { "8cfd1be0-2152-402a-930b-47ba17f90e25", "720a023c-0a96-4703-829b-6afdbf58ce29", "1.001", "0.9997", "1.001", "0.9983", "0.9984", "0.999" },
                    { "8da370f8-3d53-494e-9a0c-85e070435be8", "1ec67bdb-f3f6-423f-a1d0-118c1f8bd8f1", "1.0133", "0.9914", "0.9394", "1.0667", "0.9907", "0.2584" },
                    { "8f9ade29-3838-4dd0-a717-1f5b347131e3", "7a1c62fd-314d-4c43-9a80-b7cfe682f127", "0.9791", "0.9855", "0.9011", "3.5057", "1.0514", "0.7247" },
                    { "91c00286-cd95-4978-8478-d3415eac2455", "9322b30e-e079-48c3-8a17-3ee0aa27a558", "1.0075", "0.996", "1.0137", "1.1225", "0.9693", "0.3284" },
                    { "93c3fe03-bb76-40dc-897e-1ad5c271a049", "726a595f-fce1-4aa6-8108-6862441002d3", "1.0557", "0.9921", "0.8615", "1.1902", "0.9397", "0.7305" },
                    { "94d66bf8-d083-4ce8-806b-bf84b5e836cd", "79758d13-9341-41ef-847f-cbc9c9adfb00", "0.9895", "0.9861", "1.1374", "2.9948", "1.2064", "0.7545" },
                    { "9ba44d16-b0a3-4022-8a48-df4074a15b72", "c41aa7fa-7982-4764-8c67-52061a3a7c9a", "1.0393", "0.9993", "0.8536", "1.1363", "1.0291", "0.387" },
                    { "9e4796a7-8982-4e86-8e44-3a979bd53ff4", "94593c6c-e6ff-4424-bc91-4017a41b1037", "1.0434", "0.997", "1.0122", "1.3515", "1.0075", "0.3299" },
                    { "a3a9a5a9-9159-410a-ab78-24c12635084c", "2b98c21c-894d-4a87-ad65-f902d9d784c8", "1.0332", "0.9938", "1.0642", "1.1588", "1.0332", "0.5282" },
                    { "a5468475-cb7c-4454-9fea-b4dc0f65895c", "21306162-5fba-4196-b263-757f8ab934ad", "1.0176", "0.9939", "0.955", "1.0029", "1.0213", "1.0791" },
                    { "a66db3ff-d0f9-4415-a8b9-93d988d8468a", "ffbae44b-7dab-432a-bfd4-de40be8fecab", "1.0047", "0.9991", "0.9117", "0.9117", "0.9975", "0.3257" },
                    { "b36cb1c3-8869-489d-8860-6b8e39702c86", "97d481d5-036f-41fa-b799-95c5c74dd163", "1.022", "0.9941", "1.0027", "1.2343", "1.0238", "0.2804" },
                    { "b47fcfbb-50e8-4124-8667-a52786cbc08f", "7a0aeee6-31b4-4cbd-864f-856b3ddf5ef5", "1.0199", "0.9991", "0.9522", "1.1834", "1.0472", "0.4535" },
                    { "b8855623-fa32-419a-a238-4fea85680ded", "d67fbd84-ddc5-438e-a822-e6649923f2b0", "1.0108", "0.9945", "0.9691", "1.2224", "1.1084", "0.3204" },
                    { "b8c7c9a6-042d-4393-934c-8cc514ff2c57", "4e78bfee-8e0f-4bf0-bd46-155c30480258", "1.0417", "1.0008", "0.9789", "1.1153", "1.0062", "0.1731" },
                    { "bcb210ba-e1d5-4f5c-8419-40623343e4e3", "067c8c67-4e8d-4f3a-95a4-940f076b0d0d", "1.0341", "0.9961", "0.8677", "1.4814", "1.0413", "2.1912" },
                    { "bf67d307-2ae1-4577-a5ec-bb9a77a90c8a", "9de876d6-62b5-483f-b4fe-d04276601eda", "1.0222", "0.9912", "1.1324", "1.7931", "1.1162", "0.4293" },
                    { "c25893af-5928-42ed-a9f2-ee9c59285a9f", "aedd06fe-47f7-4bba-b716-1fafe9775b53", "1.0256", "0.9901", "1.1881", "1.3504", "1.081", "0.551" },
                    { "c379b96d-2a7d-4ba7-aac6-176a75c73399", "3e29bb89-b21c-4d9b-9096-6b2b3b7d03ac", "1.0412", "0.998", "0.8207", "1.2243", "1.0761", "0.2315" },
                    { "c6ef4f63-6259-4749-bad2-94e54203e36f", "75c11d99-b70d-473f-b40d-11eb2d8311bc", "1.0248", "0.9947", "0.885", "1.5859", "1.079", "0.3131" },
                    { "ca6bcf6e-5678-40e4-abd8-f3a003a3ef16", "47f18768-71b3-4b0f-a583-113e63338ed9", "1.0151", "0.9963", "1.2169", "1.5697", "1.1228", "0.7389" },
                    { "cb879b9a-5e0c-4b78-a4c3-a7e11e92c2a4", "4e6f8ae6-d2a9-4223-8a0b-51f2841fe9b2", "1.0228", "0.9979", "1.1777", "1.2614", "1.0025", "0.5387" },
                    { "cda1c5fd-3d46-4195-ac0d-3eeb89e62872", "081aeac0-e2f6-4779-bfb2-b14ee35f8200", "0.9902", "0.996", "1.0202", "1.1787", "1.0906", "0.1296" },
                    { "d1223fe0-34f6-4706-81dd-a6704b64aa6c", "720efa19-425f-4549-8f4d-9332e24adc30", "1.0828", "0.9991", "0.8834", "1.8079", "1.0608", null },
                    { "d1775cd6-8fae-41d6-869f-958783be28d0", "712659b5-8ecc-4900-985d-acfdf5f8798a", "1.0034", "0.9999", "1.1025", "1.2812", "0.9597", null },
                    { "d3b93074-5f69-4403-9086-3ce9e290c205", "b0d77d1f-b5fe-474f-b65e-69327db127d0", "1.0729", "0.988", "0.8825", "1.5197", "1.0774", null },
                    { "d67cb417-1191-452d-bcb0-c566e62022c0", "d4f71f3c-095a-41f9-a61a-f47cf2e5f3b8", "1.0697", "0.9897", "0.9781", "1.4846", "1.0533", "0.3198" },
                    { "d71c37f1-d1ef-49ad-bc4e-6c2ef9fecadc", "2d428a13-db36-4d88-86cb-6e130eddbc9c", "1.0507", "0.9978", "1.0774", "1.7127", "1.0186", "2.1172" },
                    { "d742b763-4ff2-4405-acca-935b45ee97e0", "3294c8b7-8f10-4364-a39f-7fcecd87fd0a", "1.0085", "0.9929", "0.9535", "2.1061", "1.066", "0.6134" },
                    { "da701a9d-18fc-4055-a0a1-7b5218639c3d", "f74d6c5c-3afb-4cb0-80ac-d997ab01ad13", "1.0319", "0.9924", "1.0318", "1.1087", "1.036", "0.2338" },
                    { "deebc9ee-9bb2-4cd5-a017-2e2a75df0938", "910971f0-56f5-4be1-af5f-5eb8642a7f74", "1.0009", "1", "1.0273", "1.5427", "1.0394", "0.8396" },
                    { "e06bd365-8ede-4223-b297-18103bfca820", "4b8f25e7-a5c8-4f39-9ca9-4afb7d1b06ce", "1.0305", "0.9934", "1.0044", "1.2474", "0.9945", "0.3406" }
                });

            migrationBuilder.InsertData(
                table: "Deltas",
                columns: new[] { "Uid", "CoinUid", "day", "hour", "month", "quarter", "week", "year" },
                values: new object[,]
                {
                    { "e39b6fb4-4c54-48f8-a67b-1bc17698fb19", "fb4cf138-2ac2-4e9c-8c0d-c6ddc12d6053", "1.0172", "0.9949", "1.0646", "1.0195", "1.0078", "0.5355" },
                    { "e4fd43ca-b0dc-44c1-a9b3-c656e0cebba5", "b83d2282-104c-41b8-bec4-b72a3891a291", "1.3221", "1.0248", "2.0292", "1.9399", "1.6615", "0.6003" },
                    { "e6f7d708-d383-4984-91db-122dbcbad09f", "d488b33a-93ff-400b-b14b-15bb4f8e6c3a", "1.0194", "0.9975", "0.9903", "1.1445", "0.9797", "0.3334" },
                    { "e7697da3-9b4c-4022-86cc-f56902773582", "c3812308-1f1f-4bb4-9f73-dec3edbde77f", "0.9813", "0.993", "2.3575", "5.3643", "1.044", null },
                    { "e9c6695b-e4eb-4845-a248-ef0b6164f361", "8dd4bbd2-d874-409a-a0f3-323529a96324", "1.0203", "0.9961", "1.1143", "1.0216", "1.0345", "0.1924" },
                    { "eb2dad6f-f6b9-4765-8d22-334167d00386", "dcae1df5-2ef8-4c01-a95b-3e3df90094a9", "1.028", "0.9948", "1.0465", "1.492", "1.0155", "0.3942" },
                    { "ebb2cabc-0093-44ad-8973-55f1c987f7ff", "a6984976-327d-4f23-a3b0-74d433431036", "1.0301", "0.9961", "1.1802", "1.4353", "1.1875", "0.2352" },
                    { "ecab6faf-d9b4-4b9a-9635-bd59630f3568", "b6099a35-5ac0-4e42-ae9e-84d8bb31ca90", "1.0432", "0.9948", "0.9706", "1.0065", "1.0144", "0.6439" },
                    { "f09994b4-adf0-4fff-9cdb-84dd4015860a", "6706d8a0-2039-4404-bec8-94d98d9240bf", "1.0012", "0.9999", "1.0001", "0.9998", "0.9992", "0.9967" },
                    { "f15d07ad-c931-466d-ae91-26aa92734f1e", "aea7ffb8-a85a-4aeb-9ea6-b3355f074eb0", "1.0269", "0.997", "0.7974", "2.6062", "0.9943", "2.7918" },
                    { "f202d52d-bd7a-432d-82ec-9baefe642ea7", "de1f7fa5-4a64-4e32-b4b3-ec4345f3e1ee", "1.0264", "0.9943", "1.009", "1.1468", "1.0095", "0.4609" },
                    { "f295032f-ce01-48a7-8802-ffa658d45b1e", "e922cc44-5bd1-40fb-9b96-cf95871b74ae", "1.0644", "0.988", "1.0148", "1.3681", "1.0189", "0.2455" },
                    { "f2b62dec-fedd-4103-9069-56a50e0feb1f", "46106ec2-1e3f-4d42-a395-ae6e8ffd83bd", "1.0517", "0.9947", "1.1679", "1.4126", "1.0693", "0.6494" },
                    { "f56a2a04-d090-4423-aea0-8165d767a1b0", "b052c72e-538c-4837-a60f-643296f69389", "1.0112", "0.993", "1.0818", "1.0524", "1.0714", "0.5822" },
                    { "f7601c87-9b21-428e-aded-6cde50f9b614", "80991988-d0ea-40c6-815d-8688be7b019f", "0.9213", "1.0092", "0.8233", "1.1073", "1.0584", "0.0859" },
                    { "f9efa75b-cce9-491d-bc0a-fad4269dff00", "dd60b469-d41d-4be4-a0c4-bf004c1cf18a", "1.0192", "0.9945", "1.029", "1.1902", "1.0182", "0.3548" },
                    { "fa519dd8-4314-4f9b-9b2b-5faf0008f95f", "5bcef002-68db-497b-a329-bae2434539c1", "1.0633", "0.9944", "0.9839", "1.6174", "1.0956", "0.1982" }
                });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "Uid", "Age", "AllTimeHighUSD", "Cap", "Code", "DeltaUid", "Name", "Rank", "Rate", "SiteUserId", "Volume", "png64" },
                values: new object[,]
                {
                    { "009b97d0-35f9-472c-b5f6-3719496540ce", "889", 165L, 1286469629L, "AXS", "6fba972a-3762-491f-840b-0882db77608b", "Axie Infinity", 45L, 8.7608934428342931, null, 51937698L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/axs.png" },
                    { "067c8c67-4e8d-4f3a-95a4-940f076b0d0d", "1443", 59L, 10454208201L, "OKB", "bcb210ba-e1d5-4f5c-8419-40623343e4e3", "OKB", 9L, 43.296753238680481, null, 10300220L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/okb.png" },
                    { "081aeac0-e2f6-4779-bfb2-b14ee35f8200", "900", 20L, 1941871015L, "NEAR", "cda1c5fd-3d46-4195-ac0d-3eeb89e62872", "NEAR Protocol", 32L, 2.1966128181102982, null, 176283114L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/near.png" },
                    { "10a44298-c9a1-46a9-b654-54db88ae1869", "1610", 491L, 700363684L, "BSV", "41d255ea-8acb-44a9-98a8-87c5e874c91a", "Bitcoin SV", 73L, 36.352170713002614, null, 13024930L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/bsv.png" },
                    { "170cca9c-3459-435e-b048-179b19819c88", "345", 1L, 718573479L, "USDD", "5d1439ef-8b1a-41d8-a7cc-6907ac2cbb3b", "Decentralized USD", 72L, 0.99068212104553866, null, 19909392L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/usdd.png" },
                    { "182f58e2-d4ea-45c0-927c-cac93713f01f", "1586", 29L, 831268461L, "SNX", "4fdbce7d-bf41-4ec6-84e3-af90d83e4251", "Synthetix", 61L, 2.6283183340026004, null, 48403838L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/snx.png" },
                    { "1e565033-830b-44d1-b489-58f269892d17", "847", 3L, 1327911676L, "GRT", "4e9b379b-4d48-49c5-a798-503c4fc565ce", "The Graph", 43L, 0.15024820642818762, null, 63528779L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/grt.png" },
                    { "1ec67bdb-f3f6-423f-a1d0-118c1f8bd8f1", "951", 548L, 1036526264L, "EGLD", "8da370f8-3d53-494e-9a0c-85e070435be8", "MultiversX", 52L, 41.016003940720196, null, 20727486L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/egld.png" },
                    { "21306162-5fba-4196-b263-757f8ab934ad", "1706", 427L, 1497475701L, "QNT", "a5468475-cb7c-4454-9fea-b4dc0f65895c", "Quant", 40L, 124.03778671920671, null, 22989970L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/qnt.png" },
                    { "25740240-c20a-41b0-893b-d0ba8b8df986", "675", 0L, 537254667L, "BABYDOGE", "2bc3cbd0-9d10-4258-8a85-9e976f5c4b2e", "Baby Doge Coin", 89L, 2.4980008270697834E-09, null, 10275593L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/babydoge.png" },
                    { "2937cd96-5358-4819-9cd0-9704dfda2aca", "1198", 62L, 880725615L, "RPL", "779103b8-c7d9-4572-93b9-1552feb51904", "Rocket Pool", 58L, 46.078929767765544, null, 15099734L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/rpl.png" },
                    { "2b4f6d95-983f-44de-862c-282a44d93dc1", "2112", 692L, 51303060046L, "BNB", "7b007890-e446-43b5-840c-89268a84525b", "BNB", 4L, 326.31460014781129, null, 601475322L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/bnb.png" },
                    { "2b98c21c-894d-4a87-ad65-f902d9d784c8", "2035", 53L, 3847806271L, "LINK", "a3a9a5a9-9159-410a-ab78-24c12635084c", "Chainlink", 20L, 7.4411264640052144, null, 213379211L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/link.png" },
                    { "2d428a13-db36-4d88-86cb-6e130eddbc9c", "563", 86L, 647976770L, "__GMX", "d71c37f1-d1ef-49ad-bc4e-6c2ef9fecadc", "GMX", 80L, 81.073507988673299, null, 38651507L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/__gmx.png" },
                    { "2ecc07d5-c086-4dc0-9e02-ca5cc742ddbf", "2376", 44L, 2818399814L, "ATOM", "0608eff1-8690-4e9c-84a5-1e31fa2f90bf", "Cosmos", 25L, 11.815959899295345, null, 127011892L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/atom.png" },
                    { "2f1d8bc1-331d-469b-9e97-937b01d14093", "916", 44L, 677474395L, "CAKE", "0d0b68a9-a84e-45d3-aebc-cbd4471bc8b7", "PancakeSwap", 76L, 3.6559057060612723, null, 52025532L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/cake.png" },
                    { "2feb1110-3721-4152-bb9a-52f8c415a0cb", "842", 45L, 646351012L, "FXS", "50fc142c-d6c0-4bbe-9a4f-f3afa8f099b6", "Frax Share", 81L, 9.0715358525988101, null, 24544289L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/fxs.png" },
                    { "3294c8b7-8f10-4364-a39f-7fcecd87fd0a", "524", 9L, 1548206265L, "_IMX", "d742b763-4ff2-4405-acca-935b45ee97e0", "Immutable X", 39L, 1.1334500380214361, null, 59935349L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/_imx.png" },
                    { "33103bf4-495b-4818-afaf-8dd76d0ddf3d", "1301", 1L, 6753399417L, "BUSD", "3cbf5774-d7bf-4252-98d8-046d39a786fa", "Binance USD", 15L, 1.0019091540080731, null, 2131249600L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/busd.png" },
                    { "3e29bb89-b21c-4d9b-9096-6b2b3b7d03ac", "1198", 9L, 450724496L, "KAVA", "c379b96d-2a7d-4ba7-aac6-176a75c73399", "Kava", 98L, 0.94235684969696731, null, 16450427L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/kava.png" },
                    { "3e65bc00-e1e5-488e-9fb9-9c42e93f46e8", "3282", 517L, 2966640940L, "XMR", "6f555fe7-9b31-401c-ad85-a4cab3363abb", "Monero", 23L, 162.41889788396699, null, 70093418L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xmr.png" },
                    { "421a3f3e-fa92-4021-b4c8-65711ddc9b9e", "1658", 1L, 928656143L, "USDP", "89989032-82e0-4d0e-ae03-3c930e7f01ee", "Pax Dollar", 55L, 0.99880958981750056, null, 423611L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/usdp.png" },
                    { "46106ec2-1e3f-4d42-a395-ae6e8ffd83bd", "2814", 4861L, 245902442713L, "ETH", "f2b62dec-fedd-4103-9069-56a50e0feb1f", "Ethereum", 2L, 2009.4359257497333, null, 11770158389L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/eth.png" },
                    { "47f18768-71b3-4b0f-a583-113e63338ed9", "1532", 69231L, 3594285291L, "WBTC", "ca6bcf6e-5678-40e4-abd8-f3a003a3ef16", "Wrapped Bitcoin", 21L, 30387.424050003468, null, 210801018L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/wbtc.png" },
                    { "49d3883b-95a0-4f01-912b-4fc51c1fccf5", "1295", 2222L, 527549554L, "PAXG", "3125e3f6-6264-4408-8433-ccdbc3f8d56d", "PAX Gold", 91L, 2042.9919540285246, null, 14703777L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/paxg.png" },
                    { "4b8f25e7-a5c8-4f39-9ca9-4afb7d1b06ce", "1912", 16L, 1074858108L, "THETA", "e06bd365-8ede-4223-b297-18103bfca820", "Theta Network", 49L, 1.0748581079631161, null, 20049268L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/theta.png" },
                    { "4e6f8ae6-d2a9-4223-8a0b-51f2841fe9b2", "3172", 1L, 2803651541L, "XLM", "cb879b9a-5e0c-4b78-a4c3-a7e11e92c2a4", "Stellar", 26L, 0.1048605169525406, null, 51728530L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xlm.png" },
                    { "4e78bfee-8e0f-4bf0-bd46-155c30480258", "804", 42L, 1056339832L, "FLOW", "b8c7c9a6-042d-4393-934c-8cc514ff2c57", "Flow", 50L, 1.0194362398508712, null, 23890678L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/flow.png" },
                    { "4ea72bac-fb00-4964-a6a2-726b1a2f04b4", "1189", 0L, 665049722L, "_SURE", "2cda2510-5294-413c-8e8b-394edf940605", "inSure", 78L, 0.0076776003523308248, null, 3034637L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/_sure.png" },
                    { "50a060da-9326-4626-90af-1b40e019c8db", "5213", 68781L, 586709801651L, "BTC", "4d345cc7-af65-4238-8909-4734c04f6830", "Bitcoin", 1L, 30328.198749641579, null, 12110337907L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/btc.png" },
                    { "51f469e4-bd1f-429a-a101-94997d669b7f", "767", 4L, 971061789L, "MX", "01539b3d-ba30-4cbd-af2a-5e755f9da5cb", "MX Token", 53L, 2.2210928294677328, null, 11230083L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/mx.png" },
                    { "5418b5bc-9ce5-4856-a425-4637a6b9c4c6", "963", 55L, 7216234937L, "DOT", "198b9ff0-80c3-47d6-838d-b4ae9cc9b4a1", "Polkadot", 13L, 6.5941059350564526, null, 196136715L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/dot.png" },
                    { "543b513d-2652-482f-b072-b4204c646c68", "2276", 119L, 828116098L, "LUNC", "3263aedb-1a1f-46b8-9636-ce44cb1674e5", "Luna Classic", 62L, 0.00012669284582174738, null, 60224966L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/lunc.png" },
                    { "5bcef002-68db-497b-a329-bae2434539c1", "693", 60L, 443590805L, "CVX", "fa519dd8-4314-4f9b-9b2b-5faf0008f95f", "Convex Finance", 100L, 5.8113251636007464, null, 10949452L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/cvx.png" },
                    { "6706d8a0-2039-4404-bec8-94d98d9240bf", "1864", 2L, 855538288L, "TUSD", "f09994b4-adf0-4fff-9cdb-84dd4015860a", "True USD", 59L, 0.99974566674995036, null, 56647944L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/tusd.png" },
                    { "6eeb8a05-bc80-4658-af09-41e2d914c89f", "884", 2L, 813159667L, "CFX", "62b1ce5c-2c27-41d5-bd60-165dd4509765", "Conflux Token", 64L, 0.38767397643673057, null, 267248994L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/cfx.png" },
                    { "712659b5-8ecc-4900-985d-acfdf5f8798a", null, 15L, 730176154L, "WBT", "d1775cd6-8fae-41d6-869f-958783be28d0", "WhiteBIT Token", 70L, 4.8137561350336462, null, 2385277L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/wbt.png" },
                    { "720a023c-0a96-4703-829b-6afdbf58ce29", "1933", 1L, 9349403278L, "DAI", "8cfd1be0-2152-402a-930b-47ba17f90e25", "Dai", 12L, 0.99896975301912971, null, 145345881L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/dai.png" },
                    { "720efa19-425f-4549-8f4d-9332e24adc30", "176", 20L, 1594170040L, "APT", "d1223fe0-34f6-4706-81dd-a6704b64aa6c", "Aptos", 37L, 12.262846463104303, null, 310152845L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/apt.png" },
                    { "726a595f-fce1-4aa6-8108-6862441002d3", "827", 7L, 2091528832L, "LDO", "93c3fe03-bb76-40dc-897e-1ad5c271a049", "Lido DAO", 30L, 2.4161572053155989, null, 123572048L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ldo.png" },
                    { "75431122-53f8-4630-b207-868f5159830b", "799", 0L, 6529338418L, "SHIB", "5773a323-e45f-4698-9bcd-f2ab0b5b83d2", "Shiba Inu", 16L, 1.1079815049231357E-05, null, 177337714L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/shib.png" },
                    { "75c11d99-b70d-473f-b40d-11eb2d8311bc", "909", 238L, 2510872731L, "FIL", "c6ef4f63-6259-4749-bad2-94e54203e36f", "Filecoin", 28L, 6.0535867293097585, null, 132878881L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/fil.png" }
                });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "Uid", "Age", "AllTimeHighUSD", "Cap", "Code", "DeltaUid", "Name", "Rank", "Rate", "SiteUserId", "Volume", "png64" },
                values: new object[,]
                {
                    { "76126682-369b-443e-9866-98510cc41e05", "933", 146L, 6153496756L, "AVAX", "4f1d994e-5b37-48cb-bdfb-3ac1397f3753", "Avalanche", 17L, 18.864857950030537, null, 273147965L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/avax.png" },
                    { "79758d13-9341-41ef-847f-cbc9c9adfb00", "1028", 9L, 843087392L, "RNDR", "94d66bf8-d083-4ce8-806b-bf84b5e836cd", "Render Token", 60L, 1.5876871134321542, null, 87863143L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/rndr.png" },
                    { "7a0aeee6-31b4-4cbd-864f-856b3ddf5ef5", "1996", 28L, 668334731L, "KCS", "b47fcfbb-50e8-4124-8667-a52786cbc08f", "KuCoin Shares", 77L, 8.8355279000857276, null, 1364003L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/kcs.png" },
                    { "7a1c62fd-314d-4c43-9a80-b7cfe682f127", "1198", 3L, 1204098652L, "_STX", "8f9ade29-3838-4dd0-a717-1f5b347131e3", "Stacks", 47L, 0.87687742582793438, null, 121602900L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/_stx.png" },
                    { "7c5d7525-7ca3-43de-b4ef-000ef0416962", "520", 84L, 532259706L, "ENS", "0ab416db-d658-44d0-80a6-4d9e7a89fa3f", "Ethereum Name Service", 90L, 13.590619143368228, null, 27588209L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ens.png" },
                    { "80991988-d0ea-40c6-815d-8688be7b019f", "975", 14L, 2194180620L, "SRM", "f7601c87-9b21-428e-aded-6cde50f9b614", "Serum", 29L, 0.21594670202632751, null, 57598923L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/srm.png" },
                    { "82e992e8-857a-4f05-be4f-03e8a49c0594", "2038", 0L, 6025817589L, "TRX", "0b06f4e2-7db0-40bb-accb-1c0217e736ae", "TRON", 18L, 0.066335058912063344, null, 181564796L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/trx.png" },
                    { "85041870-7421-42bf-a183-35056a6349e8", "970", 7L, 825120005L, "CRV", "2c07bd39-0abd-4ba2-a0f9-96841c4dfb1d", "Curve DAO Token", 63L, 1.0631347154224129, null, 50675677L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/crv.png" },
                    { "89fdd974-aac0-4afc-af87-a41975ed23eb", "1647", 1L, 31890674516L, "USDC", "331e2c91-9ebf-46e0-bc3c-a0740d856d72", "USD Coin", 5L, 0.99906956237183553, null, 2131442649L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/usdc.png" },
                    { "8a0c166e-ed8e-4caa-bdde-6c5bb3552b2e", "2406", 196L, 892570611L, "NEO", "0b2a0434-9e21-49a2-afaa-bb12ee3eec80", "NEO", 57L, 12.36252589362473, null, 30596279L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/neo.png" },
                    { "8dd4bbd2-d874-409a-a0f3-323529a96324", "1359", 21L, 549835701L, "RUNE", "e9c6695b-e4eb-4845-a248-ef0b6164f361", "THORChain", 87L, 1.6321258352499231, null, 31640143L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/rune.png" },
                    { "910971f0-56f5-4be1-af5f-5eb8642a7f74", "941", 13L, 774577600L, "GT", "deebc9ee-9bb2-4cd5-a017-2e2a75df0938", "Gatechain Token", 68L, 5.4945079961524126, null, 508581L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/gt.png" },
                    { "9254ac5a-d541-4f5c-bdda-e31093e8313d", "1839", 9L, 1044099181L, "XTZ", "35d23e80-fefb-4242-938a-ce060a96b79b", "Tezos", 51L, 1.117674002603652, null, 13413660L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xtz.png" },
                    { "9322b30e-e079-48c3-8a17-3ee0aa27a558", "2129", 6L, 617694856L, "MIOTA", "91c00286-cd95-4978-8478-d3415eac2455", "IOTA", 82L, 0.22222994285848705, null, 5754165L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/miota.png" },
                    { "94593c6c-e6ff-4424-bc91-4017a41b1037", "1291", 1L, 2031619214L, "HBAR", "9e4796a7-8982-4e86-8e44-3a979bd53ff4", "Hedera Hashgraph", 31L, 0.066320362634824354, null, 42902466L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/hbar.png" },
                    { "97d481d5-036f-41fa-b799-95c5c74dd163", "2034", 6L, 1349697366L, "MANA", "b36cb1c3-8869-489d-8860-6b8e39702c86", "Decentraland", 42L, 0.61540675203591522, null, 100343643L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/mana.png" },
                    { "9a39bd25-9b2f-43df-b44a-b6a2b1175c8a", "3405", 1L, 11522625745L, "DOGE", "40c822a5-9ba8-449a-9733-3ad8cea79852", "Dogecoin", 8L, 0.086851280356138386, null, 580249613L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/doge.png" },
                    { "9d43d0e4-1844-4010-ad4c-502cfdf15d7e", "1492", 1L, 1742687263L, "CRO", "87eeeb5f-cfe5-48c3-94b5-227745889a70", "Cronos", 34L, 0.068981764580794316, null, 7649509L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/cro.png" },
                    { "9de876d6-62b5-483f-b4fe-d04276601eda", "1626", 3L, 1297548084L, "FTM", "bf67d307-2ae1-4577-a5ec-bb9a77a90c8a", "Fantom", 44L, 0.51061396968355321, null, 312600111L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ftm.png" },
                    { "a2b2d551-21df-491f-835b-c6beebb0b408", "21", 12L, 5445384888L, "ARB", "2a2823b1-0c2d-44b8-9400-b1c2ea532e71", "Arbitrum", 19L, 1.3548179589002987, null, 1046271860L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/arb.png" },
                    { "a563428a-03f6-4abd-8dc3-2fd11d1c55d5", "1391", 3L, 1575340028L, "ALGO", "27bd3fbc-464f-413d-86fa-d29480534cb4", "Algorand", 38L, 0.21861473534216658, null, 59994706L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/algo.png" },
                    { "a65575a9-4072-4789-a7c3-25401baf70d9", "618", 11L, 454317232L, "OSMO", "2bd2f5ea-c6a8-4ada-81d0-aee6031dab92", "Osmosis", 96L, 0.80657164263503145, null, 10831520L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/osmo.png" },
                    { "a6984976-327d-4f23-a3b0-74d433431036", "1096", 260L, 9643105628L, "SOL", "ebb2cabc-0093-44ad-8973-55f1c987f7ff", "Solana", 11L, 24.622276579457843, null, 599873521L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/sol.png" },
                    { "a6ddd36b-4458-4148-8d75-b11a528d2907", "2356", 2218L, 728613411L, "ZEC", "699c6eb8-f196-4bf5-a06a-da573293799d", "Zcash", 71L, 44.622822872541775, null, 67990465L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/zec.png" },
                    { "a81a9705-f973-40fc-a482-f67e8eb47b21", "4120", 4L, 26621449102L, "XRP", "01954976-aa52-4e23-8398-950e48520695", "XRP", 6L, 0.51441608174902442, null, 924923532L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xrp.png" },
                    { "ac1e2cf4-4e56-4ad6-ba48-a66cb4525da5", "1445", 3L, 10422239560L, "MATIC", "4e9afe76-c1df-4b49-8cfb-792fc08f664e", "Polygon", 10L, 1.1304598432321304, null, 277086510L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/matic.png" },
                    { "aea7ffb8-a85a-4aeb-9ea6-b3355f074eb0", "675", 1L, 486891673L, "AGIX", "f15d07ad-c931-466d-ae91-26aa92734f1e", "SingularityNET", 93L, 0.40368364922792982, null, 65325438L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/agix.png" },
                    { "aedd06fe-47f7-4bba-b716-1fafe9775b53", "706", 40L, 483242748L, "CSPR", "c25893af-5928-42ed-a9f2-ee9c59285a9f", "Casper Network", 95L, 0.044268223688168698, null, 7331958L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/cspr.png" },
                    { "b052c72e-538c-4837-a60f-643296f69389", "2453", 169L, 3128581467L, "ETC", "f56a2a04-d090-4423-aea0-8165d767a1b0", "Ethereum Classic", 22L, 22.275222847304718, null, 199755588L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/etc.png" },
                    { "b0d77d1f-b5fe-474f-b65e-69327db127d0", "316", 3L, 523108103L, "OP", "d3b93074-5f69-4403-9086-3ce9e290c205", "Optimism", 92L, 2.4359119352872192, null, 169354388L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/op.png" },
                    { "b6099a35-5ac0-4e42-ae9e-84d8bb31ca90", "938", 45L, 2925381898L, "UNI", "ecab6faf-d9b4-4b9a-9635-bd59630f3568", "Uniswap", 24L, 6.195608698729786, null, 99949699L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/uni.png" },
                    { "b6efae7f-83ec-41c2-87f7-d4378d00ddb1", "2111", 24L, 1394057151L, "EOS", "0ecba28a-74c5-43ed-aecf-a8c0706b44e2", "EOS", 41L, 1.2654443359627325, null, 164795547L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/eos.png" },
                    { "b83d2282-104c-41b8-bec4-b72a3891a291", "586", 1L, 803419209L, "XRD", "e4fd43ca-b0dc-44c1-a9b3-c656e0cebba5", "Radix Native Token", 65L, 0.079177929219493154, null, 16144664L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xrd.png" },
                    { "bf4de514-bd16-47bd-9ed4-ed3ee82a8a2d", "1894", 40L, 779841435L, "HT", "62fc596d-cd35-4c1f-8835-fa74b5f6dab7", "Huobi Token", 67L, 3.8257985724268013, null, 16402020L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ht.png" },
                    { "c32fef2c-5f6a-4614-91a4-2cc3fa83a6d1", "2060", 0L, 1835849605L, "VET", "23bc1b0c-863a-48b4-9065-314a805e3f8a", "VeChain", 33L, 0.025318171012815527, null, 41907992L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/vet.png" },
                    { "c3812308-1f1f-4bb4-9f73-dec3edbde77f", "322", 0L, 583907727L, "KAS", "e7697da3-9b4c-4022-86cc-f56902773582", "Kaspa", 86L, 0.032612547915839396, null, 18569847L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/kas.png" },
                    { "c41aa7fa-7982-4764-8c67-52061a3a7c9a", "2264", 6299L, 730593589L, "MKR", "9ba44d16-b0a3-4022-8a48-df4074a15b72", "Maker", 69L, 747.31017008504386, null, 32172507L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/mkr.png" },
                    { "c5af080b-aca1-467c-a0d8-7b75c0c68b4d", "842", 2L, 912592048L, "FRAX", "31faf842-e214-41c6-8c0a-75ba32e51d36", "Frax", 56L, 0.99870729767877375, null, 4632040L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/frax.png" },
                    { "c88947ea-7ca9-4e2b-b2d7-0576fad2b782", "3344", 1642L, 651136662L, "DASH", "40e84bad-f0aa-45ab-bf2a-02784c0be650", "Dash", 79L, 57.983550702574263, null, 65698320L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/dash.png" },
                    { "cd32473f-b885-4957-8cb7-bb3bc6fd0a96", "1419", 0L, 451724888L, "RSR", "6b71f274-0db1-4877-8757-f58ab5780672", "Reserve Rights", 97L, 0.0045180395383625487, null, 10588914L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/rsr.png" },
                    { "d488b33a-93ff-400b-b14b-15bb4f8e6c3a", "650", 0L, 615081473L, "XEC", "e6f7d708-d383-4984-91db-122dbcbad09f", "eCash", 83L, 3.1770908082477563E-05, null, 4034928L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xec.png" },
                    { "d4c96869-ae1a-43fd-b7ff-16755347baf2", "903", 25L, 537776849L, "INJ", "35627d9d-b4d0-4139-bb77-75c09e8b2088", "Injective Protocol", 88L, 6.7217437819127657, null, 107047190L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/inj.png" }
                });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "Uid", "Age", "AllTimeHighUSD", "Cap", "Code", "DeltaUid", "Name", "Rank", "Rate", "SiteUserId", "Volume", "png64" },
                values: new object[,]
                {
                    { "d4f71f3c-095a-41f9-a61a-f47cf2e5f3b8", "727", 188L, 694182713L, "MINA", "d67cb417-1191-452d-bcb0-c566e62022c0", "Mina Protocol", 75L, 0.78559999246932066, null, 48803309L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/mina.png" },
                    { "d67fbd84-ddc5-438e-a822-e6649923f2b0", "702", 495L, 1650816962L, "ICP", "b8855623-fa32-419a-a238-4fea85680ded", "Internet Computer", 36L, 5.4603279459398069, null, 44688712L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/icp.png" },
                    { "d93a67ef-378e-465f-85c4-08e46704de40", "4205", 413L, 6867505577L, "LTC", "24da6561-b53f-4be1-8b82-b27e48595fa7", "Litecoin", 14L, 94.466823379278523, null, 506762508L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ltc.png" },
                    { "dcae1df5-2ef8-4c01-a95b-3e3df90094a9", "2051", 4L, 484033579L, "LRC", "eb2dad6f-f6b9-4765-8d22-334167d00386", "Loopring", 94L, 0.36153227169751667, null, 26078150L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/lrc.png" },
                    { "dd60b469-d41d-4be4-a0c4-bf004c1cf18a", "839", 9L, 443724164L, "1INCH", "f9efa75b-cce9-491d-bc0a-fad4269dff00", "1inch", 99L, 0.54478528873423893, null, 25365079L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/1inch.png" },
                    { "de1f7fa5-4a64-4e32-b4b3-ec4345f3e1ee", "911", 663L, 1160144987L, "AAVE", "f202d52d-bd7a-432d-82ec-9baefe642ea7", "Aave", 48L, 80.770928125200655, null, 90749892L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/aave.png" },
                    { "e7e843d6-f373-4f29-bb94-519416689bc3", "3208", 1L, 80650366506L, "USDT", "56fbec66-7b2b-42dd-9848-6fc2aaa5634c", "Tether", 3L, 1.0008881832810113, null, 29981592764L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/usdt.png" },
                    { "e922cc44-5bd1-40fb-9b96-cf95871b74ae", "742", 4L, 780230689L, "_KLAY", "f295032f-ce01-48a7-8802-ffa658d45b1e", "Klaytn", 66L, 0.25288983619249283, null, 96165252L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/_klay.png" },
                    { "ee0b9381-1fb2-41f8-a6aa-3afc0a21d906", "392", 27L, 1651519237L, "APE", "3f67de36-5819-4013-9bda-76358df9d1e2", "ApeCoin", 35L, 4.4805947930215595, null, 197598811L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ape.png" },
                    { "f04aea14-7635-428e-8567-ebe00a5317aa", "590", 3L, 950876060L, "__BIT", "86c6ea59-967a-47c0-9cba-9130a0b145a2", "BITDAO", 54L, 0.52140798636966734, null, 4058412L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/__bit.png" },
                    { "f74d6c5c-3afb-4cb0-80ac-d997ab01ad13", "970", 8L, 1213382309L, "SAND", "da701a9d-18fc-4055-a0a1-7b5218639c3d", "The Sandbox", 46L, 0.6665903180573155, null, 116041705L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/sand.png" },
                    { "f88e6a29-d675-4b83-86b1-3b3a099df0b9", "2019", 3L, 14892005010L, "ADA", "883e879f-629f-4fcc-a939-07bf351c32f3", "Cardano", 7L, 0.42493925406676497, null, 400520948L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/ada.png" },
                    { "fb4cf138-2ac2-4e9c-8c0d-c6ddc12d6053", "1372", 1L, 699581929L, "CHZ", "e39b6fb4-4c54-48f8-a67b-1bc17698fb19", "Chiliz", 74L, 0.13090821005850312, null, 79719095L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/chz.png" },
                    { "fefecaec-5ac3-4925-87ca-bfe5db3d5e6a", "1838", 0L, 592646573L, "XDC", "12a0fdae-a703-4e52-9e41-854ca3a3b461", "XDC Network", 84L, 0.042856757030258409, null, 3944111L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/xdc.png" },
                    { "ffbae44b-7dab-432a-bfd4-de40be8fecab", "1532", 0L, 588833375L, "BTT", "a66db3ff-d0f9-4415-a8b9-93d988d8468a", "BitTorrent", 85L, 6.1889839871637984E-07, null, 9281947L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/btt.png" },
                    { "ffbe895f-6d1a-4ece-b397-fa6de58d2c62", "2081", 4356L, 2650155454L, "BCH", "18ce346f-557d-48a9-b56c-c168760902d0", "Bitcoin Cash", 27L, 136.86199605416891, null, 70687185L, "https://lcw.nyc3.cdn.digitaloceanspaces.com/production/currencies/64/bch.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e590081-b7b5-4ad1-9b11-76f9d8bddab2");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "009b97d0-35f9-472c-b5f6-3719496540ce");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "067c8c67-4e8d-4f3a-95a4-940f076b0d0d");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "081aeac0-e2f6-4779-bfb2-b14ee35f8200");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "10a44298-c9a1-46a9-b654-54db88ae1869");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "170cca9c-3459-435e-b048-179b19819c88");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "182f58e2-d4ea-45c0-927c-cac93713f01f");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "1e565033-830b-44d1-b489-58f269892d17");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "1ec67bdb-f3f6-423f-a1d0-118c1f8bd8f1");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "21306162-5fba-4196-b263-757f8ab934ad");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "25740240-c20a-41b0-893b-d0ba8b8df986");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "2937cd96-5358-4819-9cd0-9704dfda2aca");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "2b4f6d95-983f-44de-862c-282a44d93dc1");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "2b98c21c-894d-4a87-ad65-f902d9d784c8");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "2d428a13-db36-4d88-86cb-6e130eddbc9c");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "2ecc07d5-c086-4dc0-9e02-ca5cc742ddbf");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "2f1d8bc1-331d-469b-9e97-937b01d14093");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "2feb1110-3721-4152-bb9a-52f8c415a0cb");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "3294c8b7-8f10-4364-a39f-7fcecd87fd0a");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "33103bf4-495b-4818-afaf-8dd76d0ddf3d");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "3e29bb89-b21c-4d9b-9096-6b2b3b7d03ac");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "3e65bc00-e1e5-488e-9fb9-9c42e93f46e8");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "421a3f3e-fa92-4021-b4c8-65711ddc9b9e");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "46106ec2-1e3f-4d42-a395-ae6e8ffd83bd");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "47f18768-71b3-4b0f-a583-113e63338ed9");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "49d3883b-95a0-4f01-912b-4fc51c1fccf5");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "4b8f25e7-a5c8-4f39-9ca9-4afb7d1b06ce");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "4e6f8ae6-d2a9-4223-8a0b-51f2841fe9b2");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "4e78bfee-8e0f-4bf0-bd46-155c30480258");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "4ea72bac-fb00-4964-a6a2-726b1a2f04b4");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "50a060da-9326-4626-90af-1b40e019c8db");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "51f469e4-bd1f-429a-a101-94997d669b7f");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "5418b5bc-9ce5-4856-a425-4637a6b9c4c6");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "543b513d-2652-482f-b072-b4204c646c68");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "5bcef002-68db-497b-a329-bae2434539c1");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "6706d8a0-2039-4404-bec8-94d98d9240bf");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "6eeb8a05-bc80-4658-af09-41e2d914c89f");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "712659b5-8ecc-4900-985d-acfdf5f8798a");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "720a023c-0a96-4703-829b-6afdbf58ce29");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "720efa19-425f-4549-8f4d-9332e24adc30");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "726a595f-fce1-4aa6-8108-6862441002d3");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "75431122-53f8-4630-b207-868f5159830b");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "75c11d99-b70d-473f-b40d-11eb2d8311bc");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "76126682-369b-443e-9866-98510cc41e05");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "79758d13-9341-41ef-847f-cbc9c9adfb00");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "7a0aeee6-31b4-4cbd-864f-856b3ddf5ef5");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "7a1c62fd-314d-4c43-9a80-b7cfe682f127");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "7c5d7525-7ca3-43de-b4ef-000ef0416962");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "80991988-d0ea-40c6-815d-8688be7b019f");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "82e992e8-857a-4f05-be4f-03e8a49c0594");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "85041870-7421-42bf-a183-35056a6349e8");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "89fdd974-aac0-4afc-af87-a41975ed23eb");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "8a0c166e-ed8e-4caa-bdde-6c5bb3552b2e");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "8dd4bbd2-d874-409a-a0f3-323529a96324");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "910971f0-56f5-4be1-af5f-5eb8642a7f74");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "9254ac5a-d541-4f5c-bdda-e31093e8313d");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "9322b30e-e079-48c3-8a17-3ee0aa27a558");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "94593c6c-e6ff-4424-bc91-4017a41b1037");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "97d481d5-036f-41fa-b799-95c5c74dd163");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "9a39bd25-9b2f-43df-b44a-b6a2b1175c8a");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "9d43d0e4-1844-4010-ad4c-502cfdf15d7e");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "9de876d6-62b5-483f-b4fe-d04276601eda");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "a2b2d551-21df-491f-835b-c6beebb0b408");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "a563428a-03f6-4abd-8dc3-2fd11d1c55d5");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "a65575a9-4072-4789-a7c3-25401baf70d9");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "a6984976-327d-4f23-a3b0-74d433431036");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "a6ddd36b-4458-4148-8d75-b11a528d2907");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "a81a9705-f973-40fc-a482-f67e8eb47b21");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "ac1e2cf4-4e56-4ad6-ba48-a66cb4525da5");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "aea7ffb8-a85a-4aeb-9ea6-b3355f074eb0");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "aedd06fe-47f7-4bba-b716-1fafe9775b53");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "b052c72e-538c-4837-a60f-643296f69389");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "b0d77d1f-b5fe-474f-b65e-69327db127d0");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "b6099a35-5ac0-4e42-ae9e-84d8bb31ca90");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "b6efae7f-83ec-41c2-87f7-d4378d00ddb1");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "b83d2282-104c-41b8-bec4-b72a3891a291");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "bf4de514-bd16-47bd-9ed4-ed3ee82a8a2d");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c32fef2c-5f6a-4614-91a4-2cc3fa83a6d1");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c3812308-1f1f-4bb4-9f73-dec3edbde77f");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c41aa7fa-7982-4764-8c67-52061a3a7c9a");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c5af080b-aca1-467c-a0d8-7b75c0c68b4d");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "c88947ea-7ca9-4e2b-b2d7-0576fad2b782");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "cd32473f-b885-4957-8cb7-bb3bc6fd0a96");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "d488b33a-93ff-400b-b14b-15bb4f8e6c3a");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "d4c96869-ae1a-43fd-b7ff-16755347baf2");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "d4f71f3c-095a-41f9-a61a-f47cf2e5f3b8");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "d67fbd84-ddc5-438e-a822-e6649923f2b0");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "d93a67ef-378e-465f-85c4-08e46704de40");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "dcae1df5-2ef8-4c01-a95b-3e3df90094a9");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "dd60b469-d41d-4be4-a0c4-bf004c1cf18a");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "de1f7fa5-4a64-4e32-b4b3-ec4345f3e1ee");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "e7e843d6-f373-4f29-bb94-519416689bc3");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "e922cc44-5bd1-40fb-9b96-cf95871b74ae");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "ee0b9381-1fb2-41f8-a6aa-3afc0a21d906");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "f04aea14-7635-428e-8567-ebe00a5317aa");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "f74d6c5c-3afb-4cb0-80ac-d997ab01ad13");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "f88e6a29-d675-4b83-86b1-3b3a099df0b9");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "fb4cf138-2ac2-4e9c-8c0d-c6ddc12d6053");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "fefecaec-5ac3-4925-87ca-bfe5db3d5e6a");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "ffbae44b-7dab-432a-bfd4-de40be8fecab");

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "Uid",
                keyValue: "ffbe895f-6d1a-4ece-b397-fa6de58d2c62");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "01539b3d-ba30-4cbd-af2a-5e755f9da5cb");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "01954976-aa52-4e23-8398-950e48520695");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "0608eff1-8690-4e9c-84a5-1e31fa2f90bf");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "0ab416db-d658-44d0-80a6-4d9e7a89fa3f");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "0b06f4e2-7db0-40bb-accb-1c0217e736ae");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "0b2a0434-9e21-49a2-afaa-bb12ee3eec80");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "0d0b68a9-a84e-45d3-aebc-cbd4471bc8b7");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "0ecba28a-74c5-43ed-aecf-a8c0706b44e2");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "12a0fdae-a703-4e52-9e41-854ca3a3b461");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "18ce346f-557d-48a9-b56c-c168760902d0");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "198b9ff0-80c3-47d6-838d-b4ae9cc9b4a1");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "23bc1b0c-863a-48b4-9065-314a805e3f8a");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "24da6561-b53f-4be1-8b82-b27e48595fa7");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "27bd3fbc-464f-413d-86fa-d29480534cb4");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "2a2823b1-0c2d-44b8-9400-b1c2ea532e71");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "2bc3cbd0-9d10-4258-8a85-9e976f5c4b2e");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "2bd2f5ea-c6a8-4ada-81d0-aee6031dab92");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "2c07bd39-0abd-4ba2-a0f9-96841c4dfb1d");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "2cda2510-5294-413c-8e8b-394edf940605");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "3125e3f6-6264-4408-8433-ccdbc3f8d56d");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "31faf842-e214-41c6-8c0a-75ba32e51d36");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "3263aedb-1a1f-46b8-9636-ce44cb1674e5");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "331e2c91-9ebf-46e0-bc3c-a0740d856d72");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "35627d9d-b4d0-4139-bb77-75c09e8b2088");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "35d23e80-fefb-4242-938a-ce060a96b79b");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "3cbf5774-d7bf-4252-98d8-046d39a786fa");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "3f67de36-5819-4013-9bda-76358df9d1e2");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "40c822a5-9ba8-449a-9733-3ad8cea79852");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "40e84bad-f0aa-45ab-bf2a-02784c0be650");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "41d255ea-8acb-44a9-98a8-87c5e874c91a");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "4d345cc7-af65-4238-8909-4734c04f6830");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "4e9afe76-c1df-4b49-8cfb-792fc08f664e");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "4e9b379b-4d48-49c5-a798-503c4fc565ce");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "4f1d994e-5b37-48cb-bdfb-3ac1397f3753");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "4fdbce7d-bf41-4ec6-84e3-af90d83e4251");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "50fc142c-d6c0-4bbe-9a4f-f3afa8f099b6");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "56fbec66-7b2b-42dd-9848-6fc2aaa5634c");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "5773a323-e45f-4698-9bcd-f2ab0b5b83d2");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "5d1439ef-8b1a-41d8-a7cc-6907ac2cbb3b");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "62b1ce5c-2c27-41d5-bd60-165dd4509765");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "62fc596d-cd35-4c1f-8835-fa74b5f6dab7");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "699c6eb8-f196-4bf5-a06a-da573293799d");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "6b71f274-0db1-4877-8757-f58ab5780672");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "6f555fe7-9b31-401c-ad85-a4cab3363abb");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "6fba972a-3762-491f-840b-0882db77608b");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "779103b8-c7d9-4572-93b9-1552feb51904");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "7b007890-e446-43b5-840c-89268a84525b");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "86c6ea59-967a-47c0-9cba-9130a0b145a2");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "87eeeb5f-cfe5-48c3-94b5-227745889a70");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "883e879f-629f-4fcc-a939-07bf351c32f3");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "89989032-82e0-4d0e-ae03-3c930e7f01ee");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "8cfd1be0-2152-402a-930b-47ba17f90e25");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "8da370f8-3d53-494e-9a0c-85e070435be8");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "8f9ade29-3838-4dd0-a717-1f5b347131e3");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "91c00286-cd95-4978-8478-d3415eac2455");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "93c3fe03-bb76-40dc-897e-1ad5c271a049");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "94d66bf8-d083-4ce8-806b-bf84b5e836cd");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "9ba44d16-b0a3-4022-8a48-df4074a15b72");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "9e4796a7-8982-4e86-8e44-3a979bd53ff4");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "a3a9a5a9-9159-410a-ab78-24c12635084c");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "a5468475-cb7c-4454-9fea-b4dc0f65895c");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "a66db3ff-d0f9-4415-a8b9-93d988d8468a");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "b36cb1c3-8869-489d-8860-6b8e39702c86");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "b47fcfbb-50e8-4124-8667-a52786cbc08f");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "b8855623-fa32-419a-a238-4fea85680ded");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "b8c7c9a6-042d-4393-934c-8cc514ff2c57");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "bcb210ba-e1d5-4f5c-8419-40623343e4e3");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "bf67d307-2ae1-4577-a5ec-bb9a77a90c8a");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "c25893af-5928-42ed-a9f2-ee9c59285a9f");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "c379b96d-2a7d-4ba7-aac6-176a75c73399");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "c6ef4f63-6259-4749-bad2-94e54203e36f");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "ca6bcf6e-5678-40e4-abd8-f3a003a3ef16");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "cb879b9a-5e0c-4b78-a4c3-a7e11e92c2a4");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "cda1c5fd-3d46-4195-ac0d-3eeb89e62872");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "d1223fe0-34f6-4706-81dd-a6704b64aa6c");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "d1775cd6-8fae-41d6-869f-958783be28d0");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "d3b93074-5f69-4403-9086-3ce9e290c205");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "d67cb417-1191-452d-bcb0-c566e62022c0");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "d71c37f1-d1ef-49ad-bc4e-6c2ef9fecadc");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "d742b763-4ff2-4405-acca-935b45ee97e0");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "da701a9d-18fc-4055-a0a1-7b5218639c3d");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "deebc9ee-9bb2-4cd5-a017-2e2a75df0938");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "e06bd365-8ede-4223-b297-18103bfca820");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "e39b6fb4-4c54-48f8-a67b-1bc17698fb19");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "e4fd43ca-b0dc-44c1-a9b3-c656e0cebba5");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "e6f7d708-d383-4984-91db-122dbcbad09f");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "e7697da3-9b4c-4022-86cc-f56902773582");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "e9c6695b-e4eb-4845-a248-ef0b6164f361");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "eb2dad6f-f6b9-4765-8d22-334167d00386");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "ebb2cabc-0093-44ad-8973-55f1c987f7ff");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "ecab6faf-d9b4-4b9a-9635-bd59630f3568");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "f09994b4-adf0-4fff-9cdb-84dd4015860a");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "f15d07ad-c931-466d-ae91-26aa92734f1e");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "f202d52d-bd7a-432d-82ec-9baefe642ea7");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "f295032f-ce01-48a7-8802-ffa658d45b1e");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "f2b62dec-fedd-4103-9069-56a50e0feb1f");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "f56a2a04-d090-4423-aea0-8165d767a1b0");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "f7601c87-9b21-428e-aded-6cde50f9b614");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "f9efa75b-cce9-491d-bc0a-fad4269dff00");

            migrationBuilder.DeleteData(
                table: "Deltas",
                keyColumn: "Uid",
                keyValue: "fa519dd8-4314-4f9b-9b2b-5faf0008f95f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureContentType", "PictureData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7872ee76-a15c-414f-bbde-adcc75e11bcb", 0, "d09d4fe2-627a-4c5f-89e4-da9639d26662", "admin@admin.adm", true, "Super", "User", false, null, null, "SUPERUSER", "AQAAAAEAACcQAAAAEI9wXvpoUou2vt+tdJwdd0A1cl1DBJPIhoHoH4IdH6hFqThLlcEt4H09fxG7xuS9iQ==", null, false, null, null, "bd74c243-64f2-43de-a5d9-58ce45c3e77b", false, "superuser" });
        }
    }
}
