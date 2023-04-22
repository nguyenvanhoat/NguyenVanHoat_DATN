using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Data.Migrations
{
    public partial class fix_dat_hang_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "TrangThai",
                table: "DatLich",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "1d0cb6b2-f7c9-48c6-bd11-7fd9d3b1f871", 0, "9ac5245a-c8de-4a2a-8c5b-2c3a9f98dcb7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAENG/wZpuXf+frX8its8RpoQ94n0GBkjNnJs/VJFSNwywJj/iaiUovLeEHtS0pwSqtA==", null, false, "db15a2d2-1666-49a5-b549-e2e1f8f26194", false, null, "user3@hotmail.com" },
                    { "6e16db58-8f2b-4377-8325-36c267454068", 0, "efd27f13-5135-4a32-aba8-c594dec61ff1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEA1BXwYtDFbdFydWfC5uxpHRvk13hNlQFhaxoPeM+k2An2yI4BpCVf9HmucjkPyOMA==", null, false, "ec172e51-9f90-4a56-80e0-8243ae6f5deb", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "55afa83f-7da9-4e52-b215-2e964e0788e9", "e8ea6158-6ebf-4e5b-b20c-72b761d90de5", "User", "USER" },
                    { "dec4d3c0-f30b-4084-bed9-59829da012b8", "c51cd27f-1e8f-487c-a5f5-e39faf1cd222", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dec4d3c0-f30b-4084-bed9-59829da012b8", "1d0cb6b2-f7c9-48c6-bd11-7fd9d3b1f871" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "55afa83f-7da9-4e52-b215-2e964e0788e9", "6e16db58-8f2b-4377-8325-36c267454068" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dec4d3c0-f30b-4084-bed9-59829da012b8", "1d0cb6b2-f7c9-48c6-bd11-7fd9d3b1f871" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "55afa83f-7da9-4e52-b215-2e964e0788e9", "6e16db58-8f2b-4377-8325-36c267454068" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "1d0cb6b2-f7c9-48c6-bd11-7fd9d3b1f871");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "6e16db58-8f2b-4377-8325-36c267454068");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55afa83f-7da9-4e52-b215-2e964e0788e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dec4d3c0-f30b-4084-bed9-59829da012b8");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "DatLich");

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
    }
}
