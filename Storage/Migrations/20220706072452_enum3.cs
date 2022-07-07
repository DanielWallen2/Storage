using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class enum3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "Orderdate",
                value: new DateTime(2022, 7, 6, 9, 24, 51, 722, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "Orderdate",
                value: new DateTime(2022, 7, 6, 9, 24, 51, 726, DateTimeKind.Local).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "Orderdate",
                value: new DateTime(2022, 7, 6, 9, 24, 51, 726, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "Orderdate",
                value: new DateTime(2022, 7, 6, 9, 24, 51, 726, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "Orderdate",
                value: new DateTime(2022, 7, 6, 9, 24, 51, 726, DateTimeKind.Local).AddTicks(1437));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "Orderdate",
                value: new DateTime(2022, 7, 5, 16, 49, 3, 323, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "Orderdate",
                value: new DateTime(2022, 7, 5, 16, 49, 3, 327, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "Orderdate",
                value: new DateTime(2022, 7, 5, 16, 49, 3, 327, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "Orderdate",
                value: new DateTime(2022, 7, 5, 16, 49, 3, 327, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "Orderdate",
                value: new DateTime(2022, 7, 5, 16, 49, 3, 327, DateTimeKind.Local).AddTicks(229));
        }
    }
}
