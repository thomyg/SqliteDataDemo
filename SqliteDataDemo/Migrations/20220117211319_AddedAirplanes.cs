﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SqliteDataDemo.Migrations
{
    public partial class AddedAirplanes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airplanes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    EngineCount = table.Column<int>(type: "INTEGER", nullable: false),
                    Reach = table.Column<int>(type: "INTEGER", nullable: false),
                    HomeAirPort = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airplanes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airplanes");
        }
    }
}
