using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClienteLabs.Migrations
{
    /// <inheritdoc />
    public partial class Atualizacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Generos_GeneroId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_GeneroId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "GeneroId",
                table: "Clientes");

            migrationBuilder.AddColumn<string>(
                name: "ClienteCPFCNPJ",
                table: "Generos",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Generos_ClienteCPFCNPJ",
                table: "Generos",
                column: "ClienteCPFCNPJ");

            migrationBuilder.AddForeignKey(
                name: "FK_Generos_Clientes_ClienteCPFCNPJ",
                table: "Generos",
                column: "ClienteCPFCNPJ",
                principalTable: "Clientes",
                principalColumn: "CPFCNPJ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Generos_Clientes_ClienteCPFCNPJ",
                table: "Generos");

            migrationBuilder.DropIndex(
                name: "IX_Generos_ClienteCPFCNPJ",
                table: "Generos");

            migrationBuilder.DropColumn(
                name: "ClienteCPFCNPJ",
                table: "Generos");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Clientes");

            migrationBuilder.AddColumn<int>(
                name: "GeneroId",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_GeneroId",
                table: "Clientes",
                column: "GeneroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Generos_GeneroId",
                table: "Clientes",
                column: "GeneroId",
                principalTable: "Generos",
                principalColumn: "GeneroId");
        }
    }
}
