using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Data.Migrations
{
    public partial class add_ii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f9a1ed0-7380-4c16-894d-ad476a38fe49");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "851dab50-a24e-4c97-ac94-15ffad69c3de", "3f8d6aed-385e-43d0-ab68-930aad5008af" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "60224f15-f72c-4676-a5b7-c1c24b832cbb", "c59c017c-0df2-4c9c-a10a-e8f879a47bac" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "3f8d6aed-385e-43d0-ab68-930aad5008af");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "c59c017c-0df2-4c9c-a10a-e8f879a47bac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60224f15-f72c-4676-a5b7-c1c24b832cbb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "851dab50-a24e-4c97-ac94-15ffad69c3de");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "322fc767-f40e-49c3-be9d-293bebaed84b", 0, "12241018-c3ca-4ffb-9f1c-e34549bfdc4e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAELSpD7H5mWRCdZSF0H6y/rcwihZe4Klmb1U2pebZPmU1+QBuj1R+u5HyHyQLbHXXLQ==", null, false, "9e585a1c-4fe5-4c5f-8f80-853abd882bc6", false, null, "user2@hotmail.com" },
                    { "77012b70-cf1f-4e4d-9200-2d59532118d5", 0, "2f12df36-3c6b-4a14-b5b7-a04c62ceada6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEIxSyJDfhElneJyb0XXuq7Xn8I5AMJAVdb/LMrya34XtVdrbBpithH5uMvI3a6J8Jg==", null, false, "80c82b45-757a-4005-a47c-f1b671560fba", false, null, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c6fe526-498c-4237-b88b-519d3a6c3f2b", "97bfb112-247f-4479-a7af-0b72130a36b0", "Admin", "ADMIN" },
                    { "95979789-a4d8-43a3-8664-b140cc2c2b4d", "5ec11642-f25a-4377-ab8c-0cee1e3047ee", "User", "USER" },
                    { "b83ae960-3d51-494e-a15f-4e31bac13dd1", "b6309c59-def7-4a0d-be8d-882b5b8bd3b8", "Saler", "SALER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "95979789-a4d8-43a3-8664-b140cc2c2b4d", "322fc767-f40e-49c3-be9d-293bebaed84b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3c6fe526-498c-4237-b88b-519d3a6c3f2b", "77012b70-cf1f-4e4d-9200-2d59532118d5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b83ae960-3d51-494e-a15f-4e31bac13dd1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95979789-a4d8-43a3-8664-b140cc2c2b4d", "322fc767-f40e-49c3-be9d-293bebaed84b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3c6fe526-498c-4237-b88b-519d3a6c3f2b", "77012b70-cf1f-4e4d-9200-2d59532118d5" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "322fc767-f40e-49c3-be9d-293bebaed84b");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "77012b70-cf1f-4e4d-9200-2d59532118d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c6fe526-498c-4237-b88b-519d3a6c3f2b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95979789-a4d8-43a3-8664-b140cc2c2b4d");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "3f8d6aed-385e-43d0-ab68-930aad5008af", 0, "f5b16a7c-804b-4259-be81-66f8c1d4a711", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEJsi61Llo73JgDhsm7unzw025HO2TbZhZWiFxosV30aAq6+/rSlIOf13IdQqCuroMg==", null, false, "839aff8c-becb-4f83-8604-c5686a3bac02", false, null, "user3@hotmail.com" },
                    { "c59c017c-0df2-4c9c-a10a-e8f879a47bac", 0, "8293d805-a24d-49b8-a2cb-386a0a0aa84a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEOyGzSQCyFsQza4t81bVZUfSrMHg+Cpy68VqOQlrU69U001DFl0OismvEaJEUd8lEg==", null, false, "a70f7701-a272-4ff9-8bf0-0d5ee88a8a70", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "60224f15-f72c-4676-a5b7-c1c24b832cbb", "d59a095d-f38f-438b-b5ee-4eb33d760e4f", "User", "USER" },
                    { "7f9a1ed0-7380-4c16-894d-ad476a38fe49", "cdade1bb-7734-42dd-acf3-b79d6c11ead4", "Saler", "SALER" },
                    { "851dab50-a24e-4c97-ac94-15ffad69c3de", "8f42bd7b-a50b-481f-b62d-fa9dc1753540", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "851dab50-a24e-4c97-ac94-15ffad69c3de", "3f8d6aed-385e-43d0-ab68-930aad5008af" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "60224f15-f72c-4676-a5b7-c1c24b832cbb", "c59c017c-0df2-4c9c-a10a-e8f879a47bac" });
        }
    }
}
