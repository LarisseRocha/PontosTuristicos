using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteNewcon.Migrations
{
    public partial class criarMigrs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Datacriacao",
                table: "PontoTuristico",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Datacriacao",
                table: "PontoTuristico");
        }
    }
}
