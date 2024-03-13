using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Representante = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Telefone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Documento = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Tipo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Logradouro = table.Column<string>(type: "text", nullable: true),
                    Numero = table.Column<int>(type: "integer", nullable: true),
                    Complemento = table.Column<string>(type: "text", nullable: true),
                    Cep = table.Column<string>(type: "text", nullable: true),
                    ClienteId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enderecos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_ClienteId",
                table: "Enderecos",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
