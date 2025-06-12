using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevotionNote.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anotacao",
                columns: table => new
                {
                    AnotacaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Anotacao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anotacao", x => x.AnotacaoId);
                });

            migrationBuilder.CreateTable(
                name: "Versiculo",
                columns: table => new
                {
                    IdVersiculos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Versiculo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    palavrasChave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDeInclusao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AnotacoesAnotacaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Versiculo", x => x.IdVersiculos);
                    table.ForeignKey(
                        name: "FK_Versiculo_Anotacao_AnotacoesAnotacaoId",
                        column: x => x.AnotacoesAnotacaoId,
                        principalTable: "Anotacao",
                        principalColumn: "AnotacaoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Versiculo_AnotacoesAnotacaoId",
                table: "Versiculo",
                column: "AnotacoesAnotacaoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Versiculo");

            migrationBuilder.DropTable(
                name: "Anotacao");
        }
    }
}
