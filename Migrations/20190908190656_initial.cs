using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherStation.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeatherStats",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateStamp = table.Column<DateTime>(nullable: false),
                    TempFahrenheit = table.Column<decimal>(nullable: false),
                    TempCelsius = table.Column<decimal>(nullable: false),
                    Pressure = table.Column<decimal>(nullable: false),
                    Humidity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherStats", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherStats");
        }
    }
}
