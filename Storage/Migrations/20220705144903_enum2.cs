using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class enum2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Category", "Count", "Description", "Name", "Orderdate", "Price", "Shelf" },
                values: new object[,]
                {
                    { 1, 0, 12, "Krocket-spel för högst 4 personer.", "Krocket-spel", new DateTime(2022, 7, 5, 16, 49, 3, 323, DateTimeKind.Local).AddTicks(8614), 230, "R1:H1:V1" },
                    { 2, 0, 4, "Extra klubba till krocket-spel.", "Extra Krocket-klubba", new DateTime(2022, 7, 5, 16, 49, 3, 327, DateTimeKind.Local).AddTicks(190), 110, "R1:H1:V2" },
                    { 3, 0, 7, "Extra klot till krocket-spel.", "Extra Krocket-klot", new DateTime(2022, 7, 5, 16, 49, 3, 327, DateTimeKind.Local).AddTicks(221), 72, "R1:H1:V3" },
                    { 4, 2, 25, "Plåster för tårna.", "Tå-plåster", new DateTime(2022, 7, 5, 16, 49, 3, 327, DateTimeKind.Local).AddTicks(226), 23, "R1:H2:V1" },
                    { 5, 1, 19, "Hjälm", "Hjälm", new DateTime(2022, 7, 5, 16, 49, 3, 327, DateTimeKind.Local).AddTicks(229), 249, "R1:H3:V1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
