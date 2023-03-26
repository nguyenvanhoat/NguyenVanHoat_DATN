using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Data.Migrations
{
    public partial class addtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "PhieuNhap",
                columns: table => new
                {
                    MaPhieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BenGiao = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NgayGiao = table.Column<DateTime>(type: "DateTime", maxLength: 50, nullable: false),
                    NguoiNhan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuNhap", x => x.MaPhieu);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuNhap",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhieuNhapId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DVT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuNhap", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuNhap_PhieuNhap_PhieuNhapId",
                        column: x => x.PhieuNhapId,
                        principalTable: "PhieuNhap",
                        principalColumn: "MaPhieu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuNhap_Product_ProductId",
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

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuNhap_PhieuNhapId",
                table: "ChiTietPhieuNhap",
                column: "PhieuNhapId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuNhap_ProductId",
                table: "ChiTietPhieuNhap",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietPhieuNhap");

            migrationBuilder.DropTable(
                name: "PhieuNhap");

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
    }
}
