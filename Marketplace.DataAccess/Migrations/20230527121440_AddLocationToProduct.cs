using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marketplace.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddLocationToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Location" },
                values: new object[] { new DateTime(2023, 5, 27, 14, 14, 40, 311, DateTimeKind.Local).AddTicks(22), "Kumanovo" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Location" },
                values: new object[] { new DateTime(2023, 5, 27, 14, 14, 40, 311, DateTimeKind.Local).AddTicks(36), "Kumanovo" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Location" },
                values: new object[] { new DateTime(2023, 5, 27, 14, 14, 40, 311, DateTimeKind.Local).AddTicks(46), "Kumanovo" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 14, 43, 25, 816, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 14, 43, 25, 816, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 14, 43, 25, 816, DateTimeKind.Local).AddTicks(7445));
        }
    }
}
