using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Data.Migrations
{
    public partial class add_giaXe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "GiaXe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MauXe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaXe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GiaXe_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_GiaXe_ProductId",
                table: "GiaXe",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GiaXe");

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
    }
}
