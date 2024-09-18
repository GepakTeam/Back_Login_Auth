using System;
using System.ComponentModel.DataAnnotations;

public class ProntuarioFisioterapeuta
{
    [Key]
    public Guid ID { get; set; }

    [Required]
    public DateTime DataAvaliacao { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nome { get; set; }

    [Required]
    public bool Sexo { get; set; }

    [MaxLength(3)]
    public string Idade { get; set; }

    public DateTime DataNascimento { get; set; }

    public bool EstadoCivil { get; set; }

    [MaxLength(15)]
    public string Telefone { get; set; }

    [MaxLength(200)]
    public string Endereco { get; set; }

    [MaxLength(500)]
    public string ExamesComplementares { get; set; }

    [MaxLength(500)]
    public string Medicamentos { get; set; }

    [MaxLength(500)]
    public string DiagnosticoClinicoPatologico { get; set; }

    [MaxLength(500)]
    public string QueixaPrincipal { get; set; }

    [MaxLength(500)]
    public string HMA { get; set; }

    [MaxLength(500)]
    public string AVD { get; set; }

    [MaxLength(500)]
    public string AparelhoLocomotor { get; set; }

    [MaxLength(500)]
    public string AparelhoCardioRespiratorio { get; set; }

    [MaxLength(500)]
    public string AparelhoCardioVascular { get; set; }

    [MaxLength(500)]
    public string Ginecologico { get; set; }

    [MaxLength(500)]
    public string Outros { get; set; }

    public bool DificuldadeComunicacao { get; set; }

    [MaxLength(100)]
    public string TipoMedicamento { get; set; }

    [MaxLength(100)]
    public string Dosagem { get; set; }

    [MaxLength(100)]
    public string Frequencia { get; set; }

    [MaxLength(500)]
    public string RemedioSemPrescricao { get; set; }

    [MaxLength(100)]
    public string HabilidadeManusear { get; set; }

    [MaxLength(100)]
    public string FrequenciaRefeicoes { get; set; }

    [MaxLength(100)]
    public string DietaEspecial { get; set; }

    [MaxLength(100)]
    public string IngestaoAlcool { get; set; }

    [MaxLength(100)]
    public string IngestaoHidrica { get; set; }

    public bool UsaProtese { get; set; }

    public bool Apetite { get; set; }

    [MaxLength(500)]
    public string PorqueApetite { get; set; }

    [MaxLength(500)]
    public string Demencia { get; set; }

    [MaxLength(100)]
    public string EscalaDepressao { get; set; }

    [MaxLength(100)]
    public string EstadoEmocional { get; set; }

    [MaxLength(10)]
    public string Peso { get; set; }

    [MaxLength(10)]
    public string Altura { get; set; }

    [MaxLength(10)]
    public string PA { get; set; }

    [MaxLength(500)]
    public string AuscultaCardiaca { get; set; }

    [MaxLength(100)]
    public string FrequenciaCardiaca { get; set; }

    [MaxLength(500)]
    public string AuscultaPulmonar { get; set; }

    [MaxLength(100)]
    public string FrequenciaRespiratoria { get; set; }

    [MaxLength(100)]
    public string PadraoRespiratorio { get; set; }

    // Ombro - Flexão
    [MaxLength(100)]
    public string OmbroFlexaoVR { get; set; }

    [MaxLength(100)]
    public string OmbroFlexaoAdmDireito { get; set; }

    [MaxLength(100)]
    public string OmbroFlexaoAdmEsquerdo { get; set; }

    // Ombro - Extensão
    [MaxLength(100)]
    public string OmbroExtensaoVR { get; set; }

    [MaxLength(100)]
    public string OmbroExtensaoAdmDireito { get; set; }

    [MaxLength(100)]
    public string OmbroExtensaoAdmEsquerdo { get; set; }

    // Ombro - Adução
    [MaxLength(100)]
    public string OmbroAducaoVR { get; set; }

    [MaxLength(100)]
    public string OmbroAducaoAdmDireito { get; set; }

    [MaxLength(100)]
    public string OmbroAducaoAdmEsquerdo { get; set; }

    // Ombro - Abdução
    [MaxLength(100)]
    public string OmbroAbducaoVR { get; set; }

    [MaxLength(100)]
    public string OmbroAbducaoAdmDireito { get; set; }

    [MaxLength(100)]
    public string OmbroAbducaoAdmEsquerdo { get; set; }

    // Ombro - Rotação Interna
    [MaxLength(100)]
    public string OmbroRotInternaVR { get; set; }

    [MaxLength(100)]
    public string OmbroRotInternaAdmDireito { get; set; }

    [MaxLength(100)]
    public string OmbroRotInternaAdmEsquerdo { get; set; }

    // Ombro - Rotação Externa
    [MaxLength(100)]
    public string OmbroRotExternaVR { get; set; }

    [MaxLength(100)]
    public string OmbroRotExternaAdmDireito { get; set; }

    [MaxLength(100)]
    public string OmbroRotExternaAdmEsquerdo { get; set; }

    // Cotovelo - Flexão
    [MaxLength(100)]
    public string CotoveloFlexaoVR { get; set; }

    [MaxLength(100)]
    public string CotoveloFlexaoAdmDireito { get; set; }

    [MaxLength(100)]
    public string CotoveloFlexaoAdmEsquerdo { get; set; }

    // Cotovelo - Extensão
    [MaxLength(100)]
    public string CotoveloExtensaoVR { get; set; }

    [MaxLength(100)]
    public string CotoveloExtensaoAdmDireito { get; set; }

    [MaxLength(100)]
    public string CotoveloExtensaoAdmEsquerdo { get; set; }

    // Punho - Extensão
    [MaxLength(100)]
    public string PunhoExtensaoVR { get; set; }

    [MaxLength(100)]
    public string PunhoExtensaoAdmDireito { get; set; }

    [MaxLength(100)]
    public string PunhoExtensaoAdmEsquerdo { get; set; }

    // Punho - Flexão
    [MaxLength(100)]
    public string PunhoFlexaoVR { get; set; }

    [MaxLength(100)]
    public string PunhoFlexaoAdmDireito { get; set; }

    [MaxLength(100)]
    public string PunhoFlexaoAdmEsquerdo { get; set; }

    // Punho - Desvio Ulnar
    [MaxLength(100)]
    public string PunhoDesvioUlnarVR { get; set; }

    [MaxLength(100)]
    public string PunhoDesvioUlnarAdmDireito { get; set; }

    [MaxLength(100)]
    public string PunhoDesvioUlnarAdmEsquerdo { get; set; }

    // Punho - Desvio Radial
    [MaxLength(100)]
    public string PunhoDesvioRadialVR { get; set; }

    [MaxLength(100)]
    public string PunhoDesvioRadialAdmDireito { get; set; }

    [MaxLength(100)]
    public string PunhoDesvioRadialAdmEsquerdo { get; set; }

    // Quadril - Flexão
    [MaxLength(100)]
    public string QuadrilFlexaoVR { get; set; }

    [MaxLength(100)]
    public string QuadrilFlexaoAdmDireito { get; set; }

    [MaxLength(100)]
    public string QuadrilFlexaoAdmEsquerdo { get; set; }

    // Quadril - Extensão
    [MaxLength(100)]
    public string QuadrilExtensaoVR { get; set; }

    [MaxLength(100)]
    public string QuadrilExtensaoAdmDireito { get; set; }

    [MaxLength(100)]
    public string QuadrilExtensaoAdmEsquerdo { get; set; }

    // Quadril - Adução
    [MaxLength(100)]
    public string QuadrilAducaoVR { get; set; }

    [MaxLength(100)]
    public string QuadrilAducaoAdmDireito { get; set; }

    [MaxLength(100)]
    public string QuadrilAducaoAdmEsquerdo { get; set; }

    // Quadril - Abdução
    [MaxLength(100)]
    public string QuadrilAbducaoVR { get; set; }

    [MaxLength(100)]
    public string QuadrilAbducaoAdmDireito { get; set; }

    [MaxLength(100)]
    public string QuadrilAbducaoAdmEsquerdo { get; set; }

    // Quadril - Rotação Interna
    [MaxLength(100)]
    public string QuadrilRotInternaVR { get; set; }

    [MaxLength(100)]
    public string QuadrilRotInternaAdmDireito { get; set; }

    [MaxLength(100)]
    public string QuadrilRotInternaAdmEsquerdo { get; set; }

    // Quadril - Rotação Externa
    [MaxLength(100)]
    public string QuadrilRotExternaVR { get; set; }

    [MaxLength(100)]
    public string QuadrilRotExternaAdmDireito { get; set; }

    [MaxLength(100)]
    public string QuadrilRotExternaAdmEsquerdo { get; set; }

    // Joelho - Flexão
    [MaxLength(100)]
    public string JoelhoFlexaoVR { get; set; }

    [MaxLength(100)]
    public string JoelhoFlexaoAdmDireito { get; set; }

    [MaxLength(100)]
    public string JoelhoFlexaoAdmEsquerdo { get; set; }

    // Joelho - Extensão
    [MaxLength(100)]
    public string JoelhoExtensaoVR { get; set; }

    [MaxLength(100)]
    public string JoelhoExtensaoAdmDireito { get; set; }

    [MaxLength(100)]
    public string JoelhoExtensaoAdmEsquerdo { get; set; }

    // Tornozelo - Eversão
    [MaxLength(100)]
    public string TornozeloEversaoVR { get; set; }

    [MaxLength(100)]
    public string TornozeloEversaoAdmDireito { get; set; }

    [MaxLength(100)]
    public string TornozeloEversaoAdmEsquerdo { get; set; }

    // Tornozelo - Dorsiflexão
    [MaxLength(100)]
    public string TornozeloDorsiflexaoVR { get; set; }

    [MaxLength(100)]
    public string TornozeloDorsiflexaoAdmDireito { get; set; }

    [MaxLength(100)]
    public string TornozeloDorsiflexaoAdmEsquerdo { get; set; }

    // Tornozelo - Flexão Plantar
    [MaxLength(100)]
    public string TornozeloFlexaoPlantarVR { get; set; }

    [MaxLength(100)]
    public string TornozeloFlexaoPlantarAdmDireito { get; set; }

    [MaxLength(100)]
    public string TornozeloFlexaoPlantarAdmEsquerdo { get; set; }

    // Tornozelo - Inversão
    [MaxLength(100)]
    public string TornozeloInversaoVR { get; set; }

    [MaxLength(100)]
    public string TornozeloInversaoAdmDireito { get; set; }

    [MaxLength(100)]
    public string TornozeloInversaoAdmEsquerdo { get; set; }

    [MaxLength(100)]
    public string TempoQuedas { get; set; }

    [MaxLength(100)]
    public string FrequenciaQuedas { get; set; }

    [MaxLength(100)]
    public string LocalQuedas { get; set; }

    public bool Reflexo { get; set; }

    [MaxLength(100)]
    public string EquilibrioSentado { get; set; }

    [MaxLength(100)]
    public string EquilibrioEmPe { get; set; }

    [MaxLength(100)]
    public string EquilibrioSinalRosemberg { get; set; }

    [MaxLength(500)]
    public string AtividadeVidaDiaria { get; set; }

    [MaxLength(100)]
    public string EscalaDor { get; set; }

    [MaxLength(100)]
    public string RegiaoDor { get; set; }

    [MaxLength(100)]
    public string PeSagital { get; set; }

    [MaxLength(100)]
    public string PeFrontal { get; set; }

    [MaxLength(100)]
    public string JoelhoSagital { get; set; }

    [MaxLength(100)]
    public string JoelhoFrontal { get; set; }

    [MaxLength(100)]
    public string CinturaPelvicaSagital { get; set; }

    [MaxLength(100)]
    public string CinturaPelvicaFrontal { get; set; }

    [MaxLength(100)]
    public string ColunaSagital { get; set; }

    [MaxLength(100)]
    public string ColunaFrontal { get; set; }

    [MaxLength(100)]
    public string CinturaEscapularSagital { get; set; }

    [MaxLength(100)]
    public string CinturaEscapularFrontal { get; set; }

    [MaxLength(100)]
    public string CabecaSagital { get; set; }

    [MaxLength(100)]
    public string CabecaFrontal { get; set; }

    [MaxLength(500)]
    public string AvaliacaoMarcha { get; set; }

    [MaxLength(1000)]
    public string Observacoes { get; set; }

    [MaxLength(500)]
    public string DiagnosticoFuncional { get; set; }

    [MaxLength(500)]
    public string ObjetivosFisioterapicos { get; set; }
}
