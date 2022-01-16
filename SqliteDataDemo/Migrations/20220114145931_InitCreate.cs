using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SqliteDataDemo.Migrations
{
    public partial class InitCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PlateNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Built = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Colour = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Built", "Colour", "Name", "PlateNumber" },
                values: new object[] { 1, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black", "Black Panter", "G-BP-1" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Built", "Colour", "Name", "PlateNumber" },
                values: new object[] { 2, new DateTime(1990, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red", "Red Velvet", "G-RV-1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
