using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "acee7a80-a14a-4632-830d-ad621e65970c", "68c57454-a761-479d-95ff-9e06ff902c35" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1fc1a334-88eb-4a3e-a6d1-d710e33b8eac", "7d33b7f9-aceb-418a-9ab1-906fac3b367b" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "68c57454-a761-479d-95ff-9e06ff902c35");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "7d33b7f9-aceb-418a-9ab1-906fac3b367b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fc1a334-88eb-4a3e-a6d1-d710e33b8eac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "acee7a80-a14a-4632-830d-ad621e65970c");

            migrationBuilder.AlterColumn<int>(
                name: "SoLuong",
                table: "ChiTietPhieuNhap",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "1df619eb-5390-4552-b973-e4d0ec924bec", 0, "691eea2e-8a1c-493e-93ed-38c51d79bf49", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEAeNY7vGxROREpUy0WjtdAtq50Zf7hpJjyb2b7aS0Z8HXp+0KZ/CZhGTMbHRPLtNFg==", null, false, "f1303270-824f-45ee-bbb2-1856131637c2", false, null, "user3@hotmail.com" },
                    { "b109e291-9200-40df-b0f0-a278e6445da3", 0, "03d26c1a-284e-463d-b00d-d3059a24573c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEHlLzNnu37aaUl7ooLAyFn+SrVWRZmUrXKtTElkhtA6w9HiU3r77zlouwqHSAYcmCg==", null, false, "0c1d08cf-e1be-4b15-9bfd-fbef0b87b5d5", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c8ade27d-bb0c-41c9-ba4f-fe224efbd31f", "d2fdec47-a5d3-48ee-be50-c7a88a1411b2", "Admin", "ADMIN" },
                    { "d0ecfe2f-67f2-480f-89fd-549751ff8f68", "7014480a-01e7-48cb-be88-1577d5e863e8", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c8ade27d-bb0c-41c9-ba4f-fe224efbd31f", "1df619eb-5390-4552-b973-e4d0ec924bec" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d0ecfe2f-67f2-480f-89fd-549751ff8f68", "b109e291-9200-40df-b0f0-a278e6445da3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c8ade27d-bb0c-41c9-ba4f-fe224efbd31f", "1df619eb-5390-4552-b973-e4d0ec924bec" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d0ecfe2f-67f2-480f-89fd-549751ff8f68", "b109e291-9200-40df-b0f0-a278e6445da3" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "1df619eb-5390-4552-b973-e4d0ec924bec");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "b109e291-9200-40df-b0f0-a278e6445da3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8ade27d-bb0c-41c9-ba4f-fe224efbd31f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0ecfe2f-67f2-480f-89fd-549751ff8f68");

            migrationBuilder.AlterColumn<string>(
                name: "SoLuong",
                table: "ChiTietPhieuNhap",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "68c57454-a761-479d-95ff-9e06ff902c35", 0, "9c93b975-476e-4a76-af45-1cbb6d800d5e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEENCpCNosrqk6bVFsxts/moFwRYLrXW7UpbzlpSmQ3J+LUosAldOTYbxSsE7S3z1Eg==", null, false, "24404076-2887-4e3e-a59d-9151b450db55", false, null, "user3@hotmail.com" },
                    { "7d33b7f9-aceb-418a-9ab1-906fac3b367b", 0, "641ebe62-b5aa-4672-b975-eb89acba7399", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEFDTgZuHO0oiA9CCZrfzA1AYI3DoopaQS+d+Kg/hIKFcHzpFxSCKHgp8MyepARLr/Q==", null, false, "410e12b8-b32d-4ddb-a6c8-f6223f80719f", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1fc1a334-88eb-4a3e-a6d1-d710e33b8eac", "4416ac19-04c8-4cbe-bee1-2861aa5ec2c5", "User", "USER" },
                    { "acee7a80-a14a-4632-830d-ad621e65970c", "5288112d-393a-4083-87b0-e4dd8a652c83", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "acee7a80-a14a-4632-830d-ad621e65970c", "68c57454-a761-479d-95ff-9e06ff902c35" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1fc1a334-88eb-4a3e-a6d1-d710e33b8eac", "7d33b7f9-aceb-418a-9ab1-906fac3b367b" });
        }
    }
}
