using System.ComponentModel.DataAnnotations;

namespace Asilo.Models
{
    public class Documento
    {
        [Key] // Define a chave primária
        [Required]
        public string Identidade { get; set; }

        [Required, MaxLength(11)]
        public string Cpf { get; set; }

        [Required, MaxLength(11)]
        public string CarteiraT { get; set; }

        [Required, MaxLength(12)]
        public string TituloE { get; set; }

        [Required, MaxLength(32)]
        public string CertidaoNasc { get; set; }
    }
}
