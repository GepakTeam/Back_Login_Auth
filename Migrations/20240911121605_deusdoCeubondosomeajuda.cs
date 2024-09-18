using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asilo.Migrations
{
    /// <inheritdoc />
    public partial class deusdoCeubondosomeajuda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UsoDrogas",
                table: "ProntuariosIndividuais",
                newName: "TomaAlgumTipoMedicamento");

            migrationBuilder.RenameColumn(
                name: "UsaMedicamento",
                table: "ProntuariosIndividuais",
                newName: "TituloEleitoral");

            migrationBuilder.RenameColumn(
                name: "ResidenciaFixa",
                table: "ProntuariosIndividuais",
                newName: "Rg");

            migrationBuilder.RenameColumn(
                name: "MotivoEncaminhamento",
                table: "ProntuariosIndividuais",
                newName: "RelacaoDistanciados");

            migrationBuilder.RenameColumn(
                name: "Lazer",
                table: "ProntuariosIndividuais",
                newName: "RelacaoConflituosa");

            migrationBuilder.RenameColumn(
                name: "Genero",
                table: "ProntuariosIndividuais",
                newName: "UsoDroga");

            migrationBuilder.RenameColumn(
                name: "AtendimentoPsiquiatrico",
                table: "ProntuariosIndividuais",
                newName: "TratamentoPsiquiatrico");

            migrationBuilder.AddColumn<bool>(
                name: "Acompanhamento",
                table: "ProntuariosIndividuais",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AtividadesLazer",
                table: "ProntuariosIndividuais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CarteiraTrabalho",
                table: "ProntuariosIndividuais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "ProntuariosIndividuais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CertidaoNascimento",
                table: "ProntuariosIndividuais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ComQuemMoraFilhos",
                table: "ProntuariosIndividuais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "ProntuariosIndividuais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Deficiencia",
                table: "ProntuariosIndividuais",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Doenca",
                table: "ProntuariosIndividuais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "ProntuariosIndividuais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Filho",
                table: "ProntuariosIndividuais",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Idade",
                table: "ProntuariosIndividuais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LocalAtendimentoPsicologico",
                table: "ProntuariosIndividuais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LocalTratamentoPsiquiatrico",
                table: "ProntuariosIndividuais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Moradia",
                table: "ProntuariosIndividuais",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MotivoEncaminhamentoPsicologico",
                table: "ProntuariosIndividuais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Parceiros",
                table: "ProntuariosIndividuais",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PlanoSaude",
                table: "ProntuariosIndividuais",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PontoReferencia",
                table: "ProntuariosIndividuais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QntFilho",
                table: "ProntuariosIndividuais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QuaisDeficiencias",
                table: "ProntuariosIndividuais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QuaisDrogasUsou",
                table: "ProntuariosIndividuais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QualMedicacao",
                table: "ProntuariosIndividuais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QualPlanoSaude",
                table: "ProntuariosIndividuais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QuemResideCasa",
                table: "ProntuariosIndividuais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Raca",
                table: "ProntuariosIndividuais",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RelacaoAmigavel",
                table: "ProntuariosIndividuais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Saude",
                table: "ProntuariosIndividuais",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Sexo",
                table: "ProntuariosIndividuais",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acompanhamento",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "AtividadesLazer",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "CarteiraTrabalho",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "Cep",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "CertidaoNascimento",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "ComQuemMoraFilhos",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "Deficiencia",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "Doenca",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "Filho",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "Idade",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "LocalAtendimentoPsicologico",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "LocalTratamentoPsiquiatrico",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "Moradia",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "MotivoEncaminhamentoPsicologico",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "Parceiros",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "PlanoSaude",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "PontoReferencia",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "QntFilho",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "QuaisDeficiencias",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "QuaisDrogasUsou",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "QualMedicacao",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "QualPlanoSaude",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "QuemResideCasa",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "Raca",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "RelacaoAmigavel",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "Saude",
                table: "ProntuariosIndividuais");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "ProntuariosIndividuais");

            migrationBuilder.RenameColumn(
                name: "UsoDroga",
                table: "ProntuariosIndividuais",
                newName: "Genero");

            migrationBuilder.RenameColumn(
                name: "TratamentoPsiquiatrico",
                table: "ProntuariosIndividuais",
                newName: "AtendimentoPsiquiatrico");

            migrationBuilder.RenameColumn(
                name: "TomaAlgumTipoMedicamento",
                table: "ProntuariosIndividuais",
                newName: "UsoDrogas");

            migrationBuilder.RenameColumn(
                name: "TituloEleitoral",
                table: "ProntuariosIndividuais",
                newName: "UsaMedicamento");

            migrationBuilder.RenameColumn(
                name: "Rg",
                table: "ProntuariosIndividuais",
                newName: "ResidenciaFixa");

            migrationBuilder.RenameColumn(
                name: "RelacaoDistanciados",
                table: "ProntuariosIndividuais",
                newName: "MotivoEncaminhamento");

            migrationBuilder.RenameColumn(
                name: "RelacaoConflituosa",
                table: "ProntuariosIndividuais",
                newName: "Lazer");
        }
    }
}
