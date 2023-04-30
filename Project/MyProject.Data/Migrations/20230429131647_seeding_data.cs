using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Data.Migrations
{
    public partial class seeding_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "60bd92e1-3bd3-4eb3-8ab2-f22780d3969f", "7f63742b-0707-4b6f-b563-23a550908cb0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "402e59b8-2337-48bc-bedc-66258f9e5140", "b0d1a007-c0ef-4aa9-99be-cd58cc662dfc" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "7f63742b-0707-4b6f-b563-23a550908cb0");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "b0d1a007-c0ef-4aa9-99be-cd58cc662dfc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "402e59b8-2337-48bc-bedc-66258f9e5140");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60bd92e1-3bd3-4eb3-8ab2-f22780d3969f");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "0dbff263-7b0b-4e73-a770-36a9eff24467", 0, "67722bfd-f294-4388-9525-4271c6fc0d13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEOzFq0kky2sDMkuhcYJPIC67/ZdQE1GI0ueNw4uucaHEKB5Lz3ZeFOg8W+MavRdOzQ==", null, false, "92060b9e-d598-40d3-83a6-2d04a1f77a56", false, null, "user3@hotmail.com" },
                    { "9dec3a26-fc57-4066-972b-b2c60ca61c6e", 0, "e05295a4-6167-4faf-8329-87d29c9e5d47", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEBwSXEZ16HH0/dY08IggcGzdwvAAnmHWq241jKqe3sgvPiBM13QrcHiaEU/kFaNChQ==", null, false, "492bbcaf-e1d0-4173-a9ea-0c6eff52b0ba", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "19451fd7-5cd9-47ab-beb7-ccf6a2ad9b30", "9414e386-d2e2-4f99-8ad3-6f3c7fadde6e", "Admin", "ADMIN" },
                    { "62f6c31b-f35e-4d89-a9bb-194c9aa2ce49", "d22be018-5951-47e0-9b97-86cc9a9a627c", "User", "USER" },
                    { "f185f2bd-cc64-4263-b064-7a43246560bb", "cc15264f-fa68-4799-bc6d-50733762012b", "Saler", "SALER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "19451fd7-5cd9-47ab-beb7-ccf6a2ad9b30", "0dbff263-7b0b-4e73-a770-36a9eff24467" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "62f6c31b-f35e-4d89-a9bb-194c9aa2ce49", "9dec3a26-fc57-4066-972b-b2c60ca61c6e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f185f2bd-cc64-4263-b064-7a43246560bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "19451fd7-5cd9-47ab-beb7-ccf6a2ad9b30", "0dbff263-7b0b-4e73-a770-36a9eff24467" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "62f6c31b-f35e-4d89-a9bb-194c9aa2ce49", "9dec3a26-fc57-4066-972b-b2c60ca61c6e" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "0dbff263-7b0b-4e73-a770-36a9eff24467");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "9dec3a26-fc57-4066-972b-b2c60ca61c6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19451fd7-5cd9-47ab-beb7-ccf6a2ad9b30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62f6c31b-f35e-4d89-a9bb-194c9aa2ce49");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "7f63742b-0707-4b6f-b563-23a550908cb0", 0, "67de3d47-2347-4253-8981-e45480b2d70c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEIC/tNSCn2+JbNxccHL0e/DZ8qIm79Xlq0+5ebjgJqLHUjeGC2dMj6Viz8zE8iO38Q==", null, false, "0a4eb73d-fedf-41a6-b314-78b4bb2eaf94", false, null, "user3@hotmail.com" },
                    { "b0d1a007-c0ef-4aa9-99be-cd58cc662dfc", 0, "12812da3-6a94-4832-83c1-82f76fa0682f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEJ+fqf6+wgXvQSwoWq0Vj0DGiH+0s+YIxyvEfIDIKvG4CilnwyFZzYN0X7SXei99fg==", null, false, "e95f6d43-6d58-4b65-850b-47e3856f3b64", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "402e59b8-2337-48bc-bedc-66258f9e5140", "42ebdb3a-7e56-4fb8-a3eb-be479ec89db9", "User", "USER" },
                    { "60bd92e1-3bd3-4eb3-8ab2-f22780d3969f", "b7dbbf44-590c-4ab9-8c06-5667f9a5dcde", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "60bd92e1-3bd3-4eb3-8ab2-f22780d3969f", "7f63742b-0707-4b6f-b563-23a550908cb0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "402e59b8-2337-48bc-bedc-66258f9e5140", "b0d1a007-c0ef-4aa9-99be-cd58cc662dfc" });
        }
    }
}
