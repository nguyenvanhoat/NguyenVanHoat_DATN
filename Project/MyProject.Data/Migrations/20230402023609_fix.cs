using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Data.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shop_AppUser_UserId",
                table: "Shop");

            migrationBuilder.DropIndex(
                name: "IX_Shop_UserId",
                table: "Shop");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a69796cc-6f75-4811-a89d-2244e23107ed", "df6494a6-ae50-492a-b0f4-88ff3c8b2154" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "af5da499-bd2a-4feb-aae9-41a2cea36b90", "e1b39594-bc4f-44d8-98bc-5dd831b978b0" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "df6494a6-ae50-492a-b0f4-88ff3c8b2154");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "e1b39594-bc4f-44d8-98bc-5dd831b978b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a69796cc-6f75-4811-a89d-2244e23107ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af5da499-bd2a-4feb-aae9-41a2cea36b90");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Shop");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "703ffc74-e086-4870-9f3f-f2e7961f1540", 0, "f3f6c669-b6c6-41ec-8fb9-9c4bdfbbeb77", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEOkPyAOgOVjRgH1ucXPaV/4SLGkHzwB2W1n2XQHPeciWKhFcjJPJDTxoeoQPwleGqA==", null, false, "1f3804e2-eff9-4fb9-9848-feca5372ea03", false, null, "user3@hotmail.com" },
                    { "f214d665-87d4-417c-9eef-c245a6385ff9", 0, "8d1e2b8d-5975-48e5-a1fe-a8c279520da1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAELXuS0b7Ey81w0cG5G42e+n+QS3+mHqPSoVU2gj/IE7vBXFufMu7mwD8eOeNV5JPCQ==", null, false, "69c9c986-2c49-44c3-af08-664a9e17cebe", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "092cc63d-21e2-4cec-b59b-142e2a89c0d8", "3bd70995-0f68-41a3-8ee9-b6c6aff55edd", "User", "USER" },
                    { "82187aee-aceb-4b9a-916a-cab61bed08a9", "143527d6-76e9-4e05-9fb1-4457ca03477a", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "82187aee-aceb-4b9a-916a-cab61bed08a9", "703ffc74-e086-4870-9f3f-f2e7961f1540" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "092cc63d-21e2-4cec-b59b-142e2a89c0d8", "f214d665-87d4-417c-9eef-c245a6385ff9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "82187aee-aceb-4b9a-916a-cab61bed08a9", "703ffc74-e086-4870-9f3f-f2e7961f1540" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "092cc63d-21e2-4cec-b59b-142e2a89c0d8", "f214d665-87d4-417c-9eef-c245a6385ff9" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "703ffc74-e086-4870-9f3f-f2e7961f1540");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "f214d665-87d4-417c-9eef-c245a6385ff9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "092cc63d-21e2-4cec-b59b-142e2a89c0d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82187aee-aceb-4b9a-916a-cab61bed08a9");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Shop",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "df6494a6-ae50-492a-b0f4-88ff3c8b2154", 0, "5c318f4a-dc64-406c-80eb-8fc8b8dc6785", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEGOFCmlBVUL9dTcWGE8ggFed4U2AOvJ/sW7NhlVxtHvCwNGUYzvXC+NZGv19mHTUBw==", null, false, "e19cfdaa-cf5e-4365-9a6b-5e1cee024271", false, null, "user2@hotmail.com" },
                    { "e1b39594-bc4f-44d8-98bc-5dd831b978b0", 0, "c59335ba-cb84-4d32-84af-1aa51eb45df6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAELXVNX/Ds33OZvKmNDercaI4GbJZO0WcVrLG1UcrP1T3OYI+5dYRd1gHNLRDXNBPIQ==", null, false, "ca3f539d-4377-45b1-994f-61c95fc259d2", false, null, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a69796cc-6f75-4811-a89d-2244e23107ed", "e769fea2-3ef9-4fd4-81f7-c33df9c717ff", "User", "USER" },
                    { "af5da499-bd2a-4feb-aae9-41a2cea36b90", "6ea82e95-d312-4e34-926a-cc6db1d912df", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a69796cc-6f75-4811-a89d-2244e23107ed", "df6494a6-ae50-492a-b0f4-88ff3c8b2154" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "af5da499-bd2a-4feb-aae9-41a2cea36b90", "e1b39594-bc4f-44d8-98bc-5dd831b978b0" });

            migrationBuilder.CreateIndex(
                name: "IX_Shop_UserId",
                table: "Shop",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shop_AppUser_UserId",
                table: "Shop",
                column: "UserId",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
