using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Marketplace.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProductAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductionYear = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "Description", "LastModified", "Price", "ProductionYear", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 19, 13, 13, 50, 62, DateTimeKind.Local).AddTicks(3996), "Agila", null, 2000, 2010, "Opel" },
                    { 2, new DateTime(2023, 5, 19, 13, 13, 50, 62, DateTimeKind.Local).AddTicks(4049), "A6", null, 3000, 2015, "Audi" },
                    { 3, new DateTime(2023, 5, 19, 13, 13, 50, 62, DateTimeKind.Local).AddTicks(4053), "106", null, 4000, 2018, "Peugeot" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
