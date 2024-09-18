using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asilo.Migrations
{
    /// <inheritdoc />
    public partial class NewMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Psicologos");

            migrationBuilder.AddColumn<string>(
                name: "Prontuario",
                table: "ProntuariosEnfermagem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ProntuariosPsicologo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RG = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Responsavel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Municipio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Saude = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Consciente = table.Column<bool>(type: "bit", nullable: false),
                    Religiao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Filho = table.Column<bool>(type: "bit", nullable: false),
                    QntFilho = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Acolhimento = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Historico = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProntuariosPsicologo", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProntuariosPsicologo");

            migrationBuilder.DropColumn(
                name: "Prontuario",
                table: "ProntuariosEnfermagem");

            migrationBuilder.CreateTable(
                name: "Psicologos",
                columns: table => new
                {
                    AtendimentoPsicologicoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnotacaoPsicologa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeResidente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PsicologoResponsavel = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Psicologos", x => x.AtendimentoPsicologicoID);
                });
        }
    }
}
