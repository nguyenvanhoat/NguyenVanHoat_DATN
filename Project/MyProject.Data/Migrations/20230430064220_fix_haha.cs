using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Data.Migrations
{
    public partial class fix_haha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Reason",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

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
    }
}
