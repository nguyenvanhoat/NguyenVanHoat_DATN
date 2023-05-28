using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Data.Migrations
{
    public partial class add_someone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AppUser_UserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Product_ProductId",
                table: "Reviews");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d762af3-a88f-4105-ab6b-223f7db50e73");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "52c11b90-9e4b-4789-99eb-eed6391b35c0", "a71e2063-a8a2-4006-aff4-fc174f43f6e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "48c3dbde-3243-4775-9a5a-837e9efb7009", "a8f2cdad-7f9f-40cf-aee5-7cf55a087d4e" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "a71e2063-a8a2-4006-aff4-fc174f43f6e4");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "a8f2cdad-7f9f-40cf-aee5-7cf55a087d4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48c3dbde-3243-4775-9a5a-837e9efb7009");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52c11b90-9e4b-4789-99eb-eed6391b35c0");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "3914e352-8e65-4044-8e1d-d2c6aac0564d", 0, "92e24cfa-11bf-4393-8ff7-95181f5ee216", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEEBAj26K9Ju6fALUiUeAvYMmAVyZAFkTEPCXfYnz2LdxU66cawfc86MGYHpJhKeo0w==", null, false, "9ca3abd2-572c-4608-b486-99d2a2b87506", false, null, "user3@hotmail.com" },
                    { "957cf4b6-d279-4287-abf4-81f2e644ff72", 0, "58af9760-5e5a-4fe5-8994-b001d6bc5940", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEBN1gUROz8rLfixRiy1kbr3bd02oQbTjjZymyk5R0TX64nn8CA3sMewAqI4BlJrk9A==", null, false, "8219c868-527c-456d-b1f5-c687689003dd", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "35c92cf8-0beb-4ae0-9d36-9dbd069cdd86", "cc71fd2d-1891-467d-90fc-64a47f844ac5", "Saler", "SALER" },
                    { "b03ba7c7-a4ab-41ef-9285-13f0dc6a3e57", "5435aefe-d812-41c8-af29-3181bfa4494d", "Admin", "ADMIN" },
                    { "c853efd4-4cc8-4ffa-b87a-60d2733ee39e", "93534cfc-f301-46d6-bb57-6f71832aee75", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b03ba7c7-a4ab-41ef-9285-13f0dc6a3e57", "3914e352-8e65-4044-8e1d-d2c6aac0564d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c853efd4-4cc8-4ffa-b87a-60d2733ee39e", "957cf4b6-d279-4287-abf4-81f2e644ff72" });

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AppUser_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Product_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AppUser_UserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Product_ProductId",
                table: "Reviews");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35c92cf8-0beb-4ae0-9d36-9dbd069cdd86");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b03ba7c7-a4ab-41ef-9285-13f0dc6a3e57", "3914e352-8e65-4044-8e1d-d2c6aac0564d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c853efd4-4cc8-4ffa-b87a-60d2733ee39e", "957cf4b6-d279-4287-abf4-81f2e644ff72" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "3914e352-8e65-4044-8e1d-d2c6aac0564d");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "957cf4b6-d279-4287-abf4-81f2e644ff72");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b03ba7c7-a4ab-41ef-9285-13f0dc6a3e57");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c853efd4-4cc8-4ffa-b87a-60d2733ee39e");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "a71e2063-a8a2-4006-aff4-fc174f43f6e4", 0, "0415d4be-da1a-4e4b-9dd6-45bb63f7245d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEPR/N8XNH7xG+sbjASY7rbXXL3Lw4tO1O++TilHuwk/V96iXw4YQpbOF9dGh9Y9NFQ==", null, false, "72dfe976-f9c8-4f8f-9a3b-55b612996424", false, null, "user2@hotmail.com" },
                    { "a8f2cdad-7f9f-40cf-aee5-7cf55a087d4e", 0, "e49e85a0-e49c-4b4b-a9b9-019dbd2a4cb4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAECEAhaxTlmrksYKFSP8UuY07/f2DV5tpOcjKYWXz/+U5nYZWqHPMX7dMWVdweOv+Ag==", null, false, "59cfc2d9-7d87-4d90-a788-81de2ae5de81", false, null, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d762af3-a88f-4105-ab6b-223f7db50e73", "440517ac-4fb6-42fc-a8f1-e67bc084b640", "Saler", "SALER" },
                    { "48c3dbde-3243-4775-9a5a-837e9efb7009", "b604c20b-be09-4393-9b7a-0eff3e1f5fee", "Admin", "ADMIN" },
                    { "52c11b90-9e4b-4789-99eb-eed6391b35c0", "d6bf0bfc-e5dd-4eb1-8477-683fe006ac13", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "52c11b90-9e4b-4789-99eb-eed6391b35c0", "a71e2063-a8a2-4006-aff4-fc174f43f6e4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "48c3dbde-3243-4775-9a5a-837e9efb7009", "a8f2cdad-7f9f-40cf-aee5-7cf55a087d4e" });

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AppUser_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Product_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
