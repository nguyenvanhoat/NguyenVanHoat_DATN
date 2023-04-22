using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Data.Migrations
{
    public partial class fix_dat_lich : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "06c30aaf-3007-4deb-8d5b-9b3b896d54e8", "3617cac6-065c-467b-a0cb-ffd0c610255c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "750ca4f8-4c02-4a36-a4ac-e0d35a00f3df", "4575a333-26fb-4aad-85ac-b8ae6b3af100" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "3617cac6-065c-467b-a0cb-ffd0c610255c");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "4575a333-26fb-4aad-85ac-b8ae6b3af100");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06c30aaf-3007-4deb-8d5b-9b3b896d54e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "750ca4f8-4c02-4a36-a4ac-e0d35a00f3df");

            migrationBuilder.AddColumn<string>(
                name: "GhiChu",
                table: "DatLich",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayHen",
                table: "DatLich",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "4d2b232a-ed61-4a22-bdf0-d7ac78f4765a", 0, "0b59fe32-5a27-44cc-bbe4-31b940be992a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEFt1RGC06xROM1rd6b6nAZrljt3dm8h44qmm8LK0YTXBmGbktv5tXwzREgK0GSXh6g==", null, false, "7e4fbc0c-38ef-445e-85a6-4d1fe2a16275", false, null, "user2@hotmail.com" },
                    { "bd7d8e72-d0ce-4eb1-a294-0f3c1451e60c", 0, "d6b4fffc-96e9-4bb4-a05b-beb03549a1a0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEKQ06qXkjK3XsukyeAgxgV9GYBbmn+pDXDmTqyd3GCICYP4ENe9P5H/rq/sKyvQ4sg==", null, false, "62f2041e-7ac3-4dfe-8725-0808bca43c8f", false, null, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15113cec-9a91-4ac1-a15a-fac1f0ca6e88", "9467fd1c-7a52-4d84-bcdb-2e3699b4ccea", "Admin", "ADMIN" },
                    { "dcd77a87-5d26-4b1e-b39c-271cafddd47a", "fad999e8-d8f3-4d46-94e2-ac647a252ab5", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dcd77a87-5d26-4b1e-b39c-271cafddd47a", "4d2b232a-ed61-4a22-bdf0-d7ac78f4765a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "15113cec-9a91-4ac1-a15a-fac1f0ca6e88", "bd7d8e72-d0ce-4eb1-a294-0f3c1451e60c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dcd77a87-5d26-4b1e-b39c-271cafddd47a", "4d2b232a-ed61-4a22-bdf0-d7ac78f4765a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "15113cec-9a91-4ac1-a15a-fac1f0ca6e88", "bd7d8e72-d0ce-4eb1-a294-0f3c1451e60c" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "4d2b232a-ed61-4a22-bdf0-d7ac78f4765a");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "bd7d8e72-d0ce-4eb1-a294-0f3c1451e60c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15113cec-9a91-4ac1-a15a-fac1f0ca6e88");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dcd77a87-5d26-4b1e-b39c-271cafddd47a");

            migrationBuilder.DropColumn(
                name: "GhiChu",
                table: "DatLich");

            migrationBuilder.DropColumn(
                name: "NgayHen",
                table: "DatLich");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "3617cac6-065c-467b-a0cb-ffd0c610255c", 0, "2a201bdd-efd2-41d8-a5b4-e35a99bb025e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEBZ36Yn1Q3mz6EcAUaQ2x4AcCBRrnYqIOuJi2qkdvolT9UF7DB8oHq2OmnDd/N9jZw==", null, false, "2b81cf2a-72fa-4cd1-b045-13753017e82d", false, null, "user3@hotmail.com" },
                    { "4575a333-26fb-4aad-85ac-b8ae6b3af100", 0, "41fc41d8-6781-4921-9fc0-37d175b5c155", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEBb+sZghK4uSmkqQGCRSea+6YBjIwCuARh1+aKKTEjyOlbshk5RTYitA5XeG56xB1g==", null, false, "3d939dc1-005d-4245-9c23-090f8b3acbe7", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "06c30aaf-3007-4deb-8d5b-9b3b896d54e8", "8814c24c-3f1f-4c9d-aae8-09a95eab0550", "Admin", "ADMIN" },
                    { "750ca4f8-4c02-4a36-a4ac-e0d35a00f3df", "1cb149e2-6505-49ce-af15-fcbabf7440f8", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "06c30aaf-3007-4deb-8d5b-9b3b896d54e8", "3617cac6-065c-467b-a0cb-ffd0c610255c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "750ca4f8-4c02-4a36-a4ac-e0d35a00f3df", "4575a333-26fb-4aad-85ac-b8ae6b3af100" });
        }
    }
}
