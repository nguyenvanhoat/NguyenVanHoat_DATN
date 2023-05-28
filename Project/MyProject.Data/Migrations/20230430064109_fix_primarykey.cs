using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Data.Migrations
{
    public partial class fix_primarykey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

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

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "OrderDetails",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Color" });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "1a6ecddf-29b1-475f-a0ae-e4383d96d1af", 0, "60b58989-db1f-47e1-ba55-b85de7f43474", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEHPRKfFlGORjzvP1/h5l9GQaMqf98BxBVKcD7Hzw9h4IuZmzB69+YI/aOkhUc91h+Q==", null, false, "4885992c-faa6-46a8-a668-6ec4e54f841d", false, null, "user3@hotmail.com" },
                    { "bbced83a-0def-48fc-9872-c28ae1a0cbc6", 0, "ec43c1a1-c1c7-427c-a003-3f0a0be1357c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEEqJIZFmJLuMKqn7NsZ5L/VV9SD5XeV4BLoxxKVet0aPv31DfIAlFOoRL2mnUjl0lg==", null, false, "d5b9c00c-261f-43d2-8cce-d77feb2fde2d", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3209a4fe-1641-43e0-8d31-cee9d272686c", "15716236-3f7b-4ed2-8aa7-66be47d5fa3a", "Saler", "SALER" },
                    { "909fbfa2-c37f-44f6-bbb0-9557834021b9", "bdfb64a2-08b0-4502-acf4-bd7b77c3615a", "User", "USER" },
                    { "ed2558e7-4819-4dc8-8356-f323c1f7aa81", "8ed2455d-2698-4bf6-9884-7e9a3aabb661", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ed2558e7-4819-4dc8-8356-f323c1f7aa81", "1a6ecddf-29b1-475f-a0ae-e4383d96d1af" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "909fbfa2-c37f-44f6-bbb0-9557834021b9", "bbced83a-0def-48fc-9872-c28ae1a0cbc6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3209a4fe-1641-43e0-8d31-cee9d272686c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ed2558e7-4819-4dc8-8356-f323c1f7aa81", "1a6ecddf-29b1-475f-a0ae-e4383d96d1af" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "909fbfa2-c37f-44f6-bbb0-9557834021b9", "bbced83a-0def-48fc-9872-c28ae1a0cbc6" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "1a6ecddf-29b1-475f-a0ae-e4383d96d1af");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "bbced83a-0def-48fc-9872-c28ae1a0cbc6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "909fbfa2-c37f-44f6-bbb0-9557834021b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed2558e7-4819-4dc8-8356-f323c1f7aa81");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId" });

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
    }
}
