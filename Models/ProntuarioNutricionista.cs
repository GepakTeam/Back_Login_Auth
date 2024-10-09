namespace Asilo.Models
{
    public class ProntuarioNutricionista
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public DateTime DataAvaliacao { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string MotivoConsulta { get; set; }
        public string EncaminhadoPor { get; set; }
        public string Convenio { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Escolaridade { get; set; }
        public string Profissao { get; set; }
        public int NumeroPessoasCasa { get; set; }
        public int NumeroAdulto { get; set; }
        public int NumeroCrianca { get; set; }
        public string EstadoCivil { get; set; }
        public bool ProblemaSaude { get; set; }
        public string QualProblemaSaude { get; set; }
        public bool Diabetes { get; set; }
        public bool Hipertensao { get; set; }
        public bool Obesidade { get; set; }
        public bool Dislipidemia { get; set; }
        public string OutrosProblemas { get; set; }

        // Antecedentes familiares
        public bool AntecedenteDiabetes { get; set; }
        public bool AntecedenteHipertensao { get; set; }
        public bool AntecedenteObesidade { get; set; }
        public bool AntecedenteDislipidemia { get; set; }
        public string OutrosAntecedentes { get; set; }

        public string HabitoIntestinal { get; set; }
        public string CaracteristicaFezes { get; set; }
        public string HabitoUrinario { get; set; }
        public int HorasSono { get; set; }
        public bool AtividadeFisica { get; set; }
        public string FrequenciaAtividadeFisica { get; set; }
        public bool Fuma { get; set; }
        public string QuantoFuma { get; set; }
        public string HaQuantoTempoFuma { get; set; }
        public bool FazUsoBebidaAlcoolica { get; set; }
        public string TipoBebida { get; set; }
        public string HaQuantoTempoBebida { get; set; }
        public bool FazUsoLaxante { get; set; }
        public string PorQuantoTempoLaxante { get; set; }
        public bool FazUsoMedicamento { get; set; }
        public string HaQuantoTempoMedicamento { get; set; }
        public string QuaisMedicamentos { get; set; }
        public bool IntoleranciaOuAversaoAlimentar { get; set; }
        public string QualIntolerancia { get; set; }
        public string HaQuantoTempoIntolerancia { get; set; }
        public bool ControleAlimentacao { get; set; }
        public string QualControleAlimentacao { get; set; }
        public bool AlteracaoPeso { get; set; }
        public string EmQuantoTempo { get; set; }
        public string ConsumoAgua { get; set; }
        public string ConsumoCafe { get; set; }
        public string ConsumoMensalSal { get; set; }
        public string ConsumoAcucar { get; set; }
        public string ConsumoOleoBanha { get; set; }
        public string OndeFazRefeicoes { get; set; }
        public string QuemPreparaRefeicoes { get; set; }
        public string VelocidadeRefeicao { get; set; }
        public string AcompanhamentoRefeicao { get; set; }
        public string PreferenciasAlimentares { get; set; }
        public string RestricoesAlimentares { get; set; }
    }
}
