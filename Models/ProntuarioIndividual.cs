// Models/ProntuarioIndividual.cs
using System;
using System.ComponentModel.DataAnnotations;

public class ProntuarioIndividual
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Idade { get; set; }
    public string LocalNascimento { get; set; }
    public bool Sexo { get; set; }
    public bool Raca { get; set; }
    public string Telefone { get; set; }
    public string NomeMae { get; set; }
    public string NomePai { get; set; }
    public string NomeResponsavel { get; set; }
    public string Endereco { get; set; }
    public string Cep { get; set; }
    public string PontoReferencia { get; set; }
    public string Rg { get; set; }
    public string Cpf { get; set; }
    public string CarteiraTrabalho { get; set; }
    public string TituloEleitoral { get; set; }
    public string CertidaoNascimento { get; set; }
    public string RelacaoAmigavel { get; set; }
    public string RelacaoDistanciados { get; set; }
    public string RelacaoConflituosa { get; set; }
    public string QuemResideCasa { get; set; }
    public bool Filho { get; set; }
    public string QntFilho { get; set; }
    public string ComQuemMoraFilhos { get; set; }
    public bool Moradia { get; set; }
    public string Doenca { get; set; }
    public bool Deficiencia { get; set; }
    public string QuaisDeficiencias { get; set; }
    public bool Saude { get; set; }
    public string AtividadesLazer { get; set; }
    public bool Parceiros { get; set; }
    public bool Acompanhamento { get; set; }
    public string QualMedicacao { get; set; }
    public bool PlanoSaude { get; set; }
    public string QualPlanoSaude { get; set; }
    public bool UsoDroga { get; set; }
    public string QuaisDrogasUsou { get; set; }
    public string HistoricoUso { get; set; }
    public bool AtendimentoPsicologico { get; set; }
    public string LocalAtendimentoPsicologico { get; set; }
    public bool TratamentoPsiquiatrico { get; set; }
    public string LocalTratamentoPsiquiatrico { get; set; }
    public string TomaAlgumTipoMedicamento { get; set; }
    public string MotivoEncaminhamentoPsicologico { get; set; }
}
