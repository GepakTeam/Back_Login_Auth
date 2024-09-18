using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asilo.Models
{
    public class Anamnese
    {
        [required]
        public string Interdicao { get; set; } //Motivo da interdição

        [MaxLength(100)]
        public string RelacaoAmigavel { get; set; } //Relação amigável com parentes

        [MaxLength(100)]
        public string RelacaoDistanciados { get; set; } //Relação distanciada com parentes
        //
        [MaxLength(100)]
        public string relacaoConflituosa { get; set; } // Relação conflituosa com parentes
    }

    internal class requiredAttribute : Attribute
    {
    }
}