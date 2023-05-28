using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Data.Migrations
{
    public partial class hehi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b83ae960-3d51-494e-a15f-4e31bac13dd1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95979789-a4d8-43a3-8664-b140cc2c2b4d", "322fc767-f40e-49c3-be9d-293bebaed84b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3c6fe526-498c-4237-b88b-519d3a6c3f2b", "77012b70-cf1f-4e4d-9200-2d59532118d5" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "322fc767-f40e-49c3-be9d-293bebaed84b");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "77012b70-cf1f-4e4d-9200-2d59532118d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c6fe526-498c-4237-b88b-519d3a6c3f2b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95979789-a4d8-43a3-8664-b140cc2c2b4d");

            migrationBuilder.CreateTable(
                name: "BaoHanh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayMua = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoMay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaoHanh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietBaoHanh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChiTiet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaoHanhId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietBaoHanh", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietBaoHanh_BaoHanh_BaoHanhId",
                        column: x => x.BaoHanhId,
                        principalTable: "BaoHanh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietBaoHanh_BaoHanhId",
                table: "ChiTietBaoHanh",
                column: "BaoHanhId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietBaoHanh");

            migrationBuilder.DropTable(
                name: "BaoHanh");

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
                    { "322fc767-f40e-49c3-be9d-293bebaed84b", 0, "12241018-c3ca-4ffb-9f1c-e34549bfdc4e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAELSpD7H5mWRCdZSF0H6y/rcwihZe4Klmb1U2pebZPmU1+QBuj1R+u5HyHyQLbHXXLQ==", null, false, "9e585a1c-4fe5-4c5f-8f80-853abd882bc6", false, null, "user2@hotmail.com" },
                    { "77012b70-cf1f-4e4d-9200-2d59532118d5", 0, "2f12df36-3c6b-4a14-b5b7-a04c62ceada6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEIxSyJDfhElneJyb0XXuq7Xn8I5AMJAVdb/LMrya34XtVdrbBpithH5uMvI3a6J8Jg==", null, false, "80c82b45-757a-4005-a47c-f1b671560fba", false, null, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c6fe526-498c-4237-b88b-519d3a6c3f2b", "97bfb112-247f-4479-a7af-0b72130a36b0", "Admin", "ADMIN" },
                    { "95979789-a4d8-43a3-8664-b140cc2c2b4d", "5ec11642-f25a-4377-ab8c-0cee1e3047ee", "User", "USER" },
                    { "b83ae960-3d51-494e-a15f-4e31bac13dd1", "b6309c59-def7-4a0d-be8d-882b5b8bd3b8", "Saler", "SALER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "95979789-a4d8-43a3-8664-b140cc2c2b4d", "322fc767-f40e-49c3-be9d-293bebaed84b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3c6fe526-498c-4237-b88b-519d3a6c3f2b", "77012b70-cf1f-4e4d-9200-2d59532118d5" });
        }
    }
}
