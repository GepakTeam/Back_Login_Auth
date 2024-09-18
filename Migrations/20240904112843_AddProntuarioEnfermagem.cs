using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asilo.Migrations
{
    /// <inheritdoc />
    public partial class AddProntuarioEnfermagem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enfermagens");

            migrationBuilder.CreateTable(
                name: "ProntuariosEnfermagem",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataExame = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NivelConciencia = table.Column<bool>(type: "bit", nullable: false),
                    PupilasSituacao = table.Column<bool>(type: "bit", nullable: false),
                    PupilaPD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PupilaPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fotorreacao = table.Column<bool>(type: "bit", nullable: false),
                    SistemaCardioCirculatorio = table.Column<bool>(type: "bit", nullable: false),
                    CarotideosEsquerdo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarotideosDireito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BraquiaisEsquerdo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BraquiaisDireito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RadiaisEsquerdo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RadiaisDireito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FemoraisEsquerdo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FemoraisDireito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PediososEsquerdo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PediososDireito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PopliteosEsquerdo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PopliteosDireito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PerfusaoPeriferica = table.Column<bool>(type: "bit", nullable: false),
                    Edema = table.Column<bool>(type: "bit", nullable: false),
                    Padrao = table.Column<bool>(type: "bit", nullable: false),
                    MurmurioVesicular = table.Column<bool>(type: "bit", nullable: false),
                    ExpansaoTorax = table.Column<bool>(type: "bit", nullable: false),
                    RuidosAdventicios = table.Column<bool>(type: "bit", nullable: false),
                    AceitacaoDieta = table.Column<bool>(type: "bit", nullable: false),
                    Denticao = table.Column<bool>(type: "bit", nullable: false),
                    Abdome = table.Column<bool>(type: "bit", nullable: false),
                    Rha = table.Column<bool>(type: "bit", nullable: false),
                    Massa = table.Column<bool>(type: "bit", nullable: false),
                    Evacuacao = table.Column<bool>(type: "bit", nullable: false),
                    Genito = table.Column<bool>(type: "bit", nullable: false),
                    Urina = table.Column<bool>(type: "bit", nullable: false),
                    Vesical = table.Column<bool>(type: "bit", nullable: false),
                    Cutanea = table.Column<bool>(type: "bit", nullable: false),
                    Sensorial = table.Column<bool>(type: "bit", nullable: false),
                    Umidade = table.Column<bool>(type: "bit", nullable: false),
                    Atividade = table.Column<bool>(type: "bit", nullable: false),
                    Mobilidade = table.Column<bool>(type: "bit", nullable: false),
                    Nutricao = table.Column<bool>(type: "bit", nullable: false),
                    Friccao = table.Column<bool>(type: "bit", nullable: false),
                    DiagnosticosEnfermagem = table.Column<bool>(type: "bit", nullable: false),
                    ControleSinaisVitaisData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ControleSinaisVitaisHorario = table.Column<TimeSpan>(type: "time", nullable: false),
                    ControleSinaisVitaisPa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ControleSinaisVitaisFc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ControleSinaisVitaisFr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ControleSinaisVitaisTemp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ControleSinaisVitaisPvc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ControleSinaisVitaisGlicemia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ControleSinaisVitaisAnotacoes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProntuariosEnfermagem", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProntuariosEnfermagem");

            migrationBuilder.CreateTable(
                name: "Enfermagens",
                columns: table => new
                {
                    EnfermagemID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Anotacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Controle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Diuresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Enfermeira = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    FR = table.Column<int>(type: "int", nullable: true),
                    Glicosmetria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P = table.Column<int>(type: "int", nullable: true),
                    PA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PVC = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Residente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    T = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enfermagens", x => x.EnfermagemID);
                });
        }
    }
}
