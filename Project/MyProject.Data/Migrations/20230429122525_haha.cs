using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Data.Migrations
{
    public partial class haha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91ae4711-06ea-4cd9-b26e-ab950a9fa8e5", "deefce8e-3bff-415b-b195-2bbb9348b7f0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "279e1cf9-04bb-48e4-a6d2-12b68a3093b2", "f0fee473-1e96-491c-9851-03fe30ed695f" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "deefce8e-3bff-415b-b195-2bbb9348b7f0");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "f0fee473-1e96-491c-9851-03fe30ed695f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "279e1cf9-04bb-48e4-a6d2-12b68a3093b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91ae4711-06ea-4cd9-b26e-ab950a9fa8e5");

            migrationBuilder.DropColumn(
                name: "ShipAddress",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShipEmail",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShipName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShipPhoneNumber",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Carts");

            migrationBuilder.AddColumn<string>(
                name: "ShipAddress",
                table: "Orders",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShipEmail",
                table: "Orders",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShipName",
                table: "Orders",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShipPhoneNumber",
                table: "Orders",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "deefce8e-3bff-415b-b195-2bbb9348b7f0", 0, "fd523f12-9503-4ae4-98b9-1d3f21d6b1f9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEFV09dwc41G9g/c7+lDdvAmzBHTNqvN5LUQ7qI0rgoutYIHkcqfLHJDkghPZFEso7g==", null, false, "0ab7bd5c-fb04-4d90-9bb4-971cc052e0d8", false, null, "user3@hotmail.com" },
                    { "f0fee473-1e96-491c-9851-03fe30ed695f", 0, "676fc632-eb38-4d2f-bce8-db65504a02ed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEBsgpKSwyxEcl4GnbZXiWG/I4qdBH5zRpwu5zJRkuAAVOue6AsYaz+3kZ2MgJSfelQ==", null, false, "7172e0f7-d82c-48ce-b574-ef128a060ac0", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "279e1cf9-04bb-48e4-a6d2-12b68a3093b2", "f78207ed-87e7-4525-9e47-0f842907b10a", "User", "USER" },
                    { "91ae4711-06ea-4cd9-b26e-ab950a9fa8e5", "6aa0ad1f-697e-4e94-b28b-378e8290927f", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "91ae4711-06ea-4cd9-b26e-ab950a9fa8e5", "deefce8e-3bff-415b-b195-2bbb9348b7f0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "279e1cf9-04bb-48e4-a6d2-12b68a3093b2", "f0fee473-1e96-491c-9851-03fe30ed695f" });
        }
    }
}
