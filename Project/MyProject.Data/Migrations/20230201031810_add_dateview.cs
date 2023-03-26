using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Data.Migrations
{
    public partial class add_dateview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cb12a212-7a7c-4680-bd35-ef14ed3237a8", "b1265968-01bb-4b60-acd5-3fd73544fee6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bae76389-f934-4fe0-bdd5-aea22ed08877", "ce2c2be7-9330-4168-b4d3-ef045a7c045e" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "b1265968-01bb-4b60-acd5-3fd73544fee6");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "ce2c2be7-9330-4168-b4d3-ef045a7c045e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bae76389-f934-4fe0-bdd5-aea22ed08877");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb12a212-7a7c-4680-bd35-ef14ed3237a8");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateView",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "da2b2d18-805d-4338-b002-9a575a181e42", 0, "c0f680a6-01e6-413b-8021-dfc644575339", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEDds1bEjNjOswj11oJESd2BIUHbHxylhMcYi399QvA6cq1gzi3hs40ZfHEpc49k0CQ==", null, false, "5f17ebb1-3048-44d9-abed-e3cfc198358a", false, null, "user3@hotmail.com" },
                    { "dcadd39c-9834-4500-b81b-88812b7475c7", 0, "92c71b5e-59c9-4b1d-8e6a-d0844597d539", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEDgYuKTaMnYBB9eojQiQkkiY65RbXvBkonf9JrSVG3pyDK46jAl8NX9QPsZ+BU2kwA==", null, false, "4f873b46-5db4-4164-8257-01782fdaee05", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "429abc3a-3fa6-4b89-8ea3-1db9bb88eae2", "a625aade-a363-4f44-a6a8-5fb9771f345a", "Admin", "ADMIN" },
                    { "4757a971-3bd4-4e63-970c-589aa1660816", "ad559ce6-d343-426f-b665-fdba5158b531", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "429abc3a-3fa6-4b89-8ea3-1db9bb88eae2", "da2b2d18-805d-4338-b002-9a575a181e42" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4757a971-3bd4-4e63-970c-589aa1660816", "dcadd39c-9834-4500-b81b-88812b7475c7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "429abc3a-3fa6-4b89-8ea3-1db9bb88eae2", "da2b2d18-805d-4338-b002-9a575a181e42" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4757a971-3bd4-4e63-970c-589aa1660816", "dcadd39c-9834-4500-b81b-88812b7475c7" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "da2b2d18-805d-4338-b002-9a575a181e42");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "dcadd39c-9834-4500-b81b-88812b7475c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "429abc3a-3fa6-4b89-8ea3-1db9bb88eae2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4757a971-3bd4-4e63-970c-589aa1660816");

            migrationBuilder.DropColumn(
                name: "DateView",
                table: "Reviews");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "b1265968-01bb-4b60-acd5-3fd73544fee6", 0, "dfea3f41-4c80-4950-a022-a0cb1e1431de", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEJbjrNxCQXpsKeNh/IysP7LrtiUxyGCXwdYaNlbtKuzzJjI6KLV8mJGzebVpyU22Qw==", null, false, "be087318-4ded-4007-8658-bdee1caf8290", false, null, "user2@hotmail.com" },
                    { "ce2c2be7-9330-4168-b4d3-ef045a7c045e", 0, "a2818f24-11df-455f-9b40-341f1cc2b0ff", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEDjoUsDcroUX28xYA5UJhQ3vlUoRcXNzbRfHnGVYsG/gH2MbTLrOSyqd3k72/DCTiw==", null, false, "55054ef9-5b59-4144-8e76-2eaf097ca617", false, null, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bae76389-f934-4fe0-bdd5-aea22ed08877", "aafcc3e1-a6d1-4e64-9cc1-af16bc7f300f", "Admin", "ADMIN" },
                    { "cb12a212-7a7c-4680-bd35-ef14ed3237a8", "4353b677-53b4-415c-8ad8-5fdd880e339e", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cb12a212-7a7c-4680-bd35-ef14ed3237a8", "b1265968-01bb-4b60-acd5-3fd73544fee6" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bae76389-f934-4fe0-bdd5-aea22ed08877", "ce2c2be7-9330-4168-b4d3-ef045a7c045e" });
        }
    }
}
