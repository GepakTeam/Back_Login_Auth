    namespace Asilo.Models
    {
        public class ProntuarioEnfermagem
        {
            public Guid ID { get; set; }
            public string Nome { get; set; }
            public string Prontuario { get; set; }
            public DateTime DataNascimento { get; set; }
            public DateTime DataExame { get; set; }
            public bool NivelConciencia { get; set; }
            public bool PupilasSituacao { get; set; }
            public string PupilaPD { get; set; }
            public string PupilaPE { get; set; }
            public bool Fotorreacao { get; set; }
            public bool SistemaCardioCirculatorio { get; set; }
            public string CarotideosEsquerdo { get; set; }
            public string CarotideosDireito { get; set; }
            public string BraquiaisEsquerdo { get; set; }
            public string BraquiaisDireito { get; set; }
            public string RadiaisEsquerdo { get; set; }
            public string RadiaisDireito { get; set; }
            public string FemoraisEsquerdo { get; set; }
            public string FemoraisDireito { get; set; }
            public string PediososEsquerdo { get; set; }
            public string PediososDireito { get; set; }
            public string PopliteosEsquerdo { get; set; }
            public string PopliteosDireito { get; set; }
            public bool PerfusaoPeriferica { get; set; }
            public bool Edema { get; set; }
            public bool Padrao { get; set; }
            public bool MurmurioVesicular { get; set; }
            public bool ExpansaoTorax { get; set; }
            public bool RuidosAdventicios { get; set; }
            public bool AceitacaoDieta { get; set; }
            public bool Denticao { get; set; }
            public bool Abdome { get; set; }
            public bool Rha { get; set; }
            public bool Massa { get; set; }
            public bool Evacuacao { get; set; }
            public bool Genito { get; set; }
            public bool Urina { get; set; }
            public bool Vesical { get; set; }
            public bool Cutanea { get; set; }
            public bool Sensorial { get; set; }
            public bool Umidade { get; set; }
            public bool Atividade { get; set; }
            public bool Mobilidade { get; set; }
            public bool Nutricao { get; set; }
            public bool Friccao { get; set; }
            public bool DiagnosticosEnfermagem { get; set; }
            public DateTime ControleSinaisVitaisData { get; set; }
            public DateTime ControleSinaisVitaisHorario { get; set; }
            public string ControleSinaisVitaisPa { get; set; }
            public string ControleSinaisVitaisFc { get; set; }
            public string ControleSinaisVitaisFr { get; set; }
            public string ControleSinaisVitaisTemp { get; set; }
            public string ControleSinaisVitaisPvc { get; set; }
            public string ControleSinaisVitaisGlicemia { get; set; }
            public string ControleSinaisVitaisAnotacoes { get; set; }
        }
    }
