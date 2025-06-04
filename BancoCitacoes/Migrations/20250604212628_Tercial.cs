using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BancoCitacoes.Migrations
{
    /// <inheritdoc />
    public partial class Tercial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BancoFrases",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataInclusao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Citacoes = table.Column<string>(type: "TEXT", nullable: false),
                    Autores = table.Column<string>(type: "TEXT", nullable: false),
                    Tags = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BancoFrases", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BancoFrases");
        }
    }
}
