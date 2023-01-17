using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marvin.IDP.Migrations
{
    public partial class AddActivationAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("39f14084-708b-4e53-aa85-90fee153a670"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("43dbae7f-159e-4e95-8e92-91d2754858b3"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4a9146e1-f4c4-4cd5-bd51-9e70d632d274"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("5dbf4bf8-7e76-42bd-a102-d12b66dbc1ef"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7f637922-2bc5-42a3-9f5e-15d85e85383c"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("a4f5a311-ba17-4077-bed3-b1a6406034e7"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("bc956fd0-0e5b-442c-a1fb-adb6586eccc7"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("dc0e9ea7-1887-4f87-a6cc-150a866a20ec"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecurityCode",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecurityCodeExpirationDate",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("1653f4f8-a4f4-437e-890e-f46e7361dcc5"), "e4baad01-36dc-4a3b-855a-2c96e037b30b", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("1cc2542c-d2cc-4809-919a-5c2f4dc113fe"), "fc3bd62e-3fb3-4c7f-a397-6e74a77b8b45", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("38365f18-a053-4a4b-9de7-a629d36893e2"), "8373610a-5dcf-4abc-ada9-38a3f127dfda", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("3a124709-e93d-457b-9a25-3b19510d2312"), "8fda0c50-8a2d-4f11-8d03-aff722ef14f5", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("70e9a106-be2b-43ff-8266-65a0985d44ae"), "6d131d11-ad03-42b0-b655-e24bce52b757", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("9847723e-8b7a-4fb9-b530-a13b7752fb83"), "aacab4aa-8db4-441c-bffd-c1610287470c", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("d39cf56e-a7d2-43a2-ba8d-9db7fab300b3"), "1f52c6f5-77c1-4989-8ae4-6162408b9d26", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("f4eebb0f-7b6c-4ed3-a430-a8a10b003512"), "9fd4c568-acb1-4540-adb6-20d416d6cdf7", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                columns: new[] { "ConcurrencyStamp", "Email" },
                values: new object[] { "d4d8ffc8-1ffc-4182-97aa-6eb371a1fc40", "david@someprovider.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "Email" },
                values: new object[] { "2199ab3a-d991-43be-975c-931b0908f34a", "emma@someprovider.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("1653f4f8-a4f4-437e-890e-f46e7361dcc5"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("1cc2542c-d2cc-4809-919a-5c2f4dc113fe"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("38365f18-a053-4a4b-9de7-a629d36893e2"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("3a124709-e93d-457b-9a25-3b19510d2312"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("70e9a106-be2b-43ff-8266-65a0985d44ae"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("9847723e-8b7a-4fb9-b530-a13b7752fb83"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("d39cf56e-a7d2-43a2-ba8d-9db7fab300b3"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("f4eebb0f-7b6c-4ed3-a430-a8a10b003512"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCodeExpirationDate",
                table: "Users");

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("39f14084-708b-4e53-aa85-90fee153a670"), "4fc9f181-b1b8-4dc2-8146-d55fb1ab7442", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("43dbae7f-159e-4e95-8e92-91d2754858b3"), "8eda3ece-8ba3-4ada-8715-c67bf758dec9", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("4a9146e1-f4c4-4cd5-bd51-9e70d632d274"), "db10bf26-93c9-4cdc-97cc-46254010ad23", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("5dbf4bf8-7e76-42bd-a102-d12b66dbc1ef"), "2a270e5d-dcf8-4b69-af33-2304f0480018", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("7f637922-2bc5-42a3-9f5e-15d85e85383c"), "3503d356-9a21-4e03-b252-6871596bf741", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("a4f5a311-ba17-4077-bed3-b1a6406034e7"), "f3db97a6-a546-4cf4-9adc-ccd83c50e3f9", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("bc956fd0-0e5b-442c-a1fb-adb6586eccc7"), "090d3f35-f1b5-4a0e-a471-feadda997533", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("dc0e9ea7-1887-4f87-a6cc-150a866a20ec"), "a22c76a1-2cc7-4d43-9716-ebace2a164d8", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "6cbc2382-689d-49ff-bacc-a003b46f712c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "ca8e41f1-b0ac-48bc-a7d3-adeabe631d19");
        }
    }
}
