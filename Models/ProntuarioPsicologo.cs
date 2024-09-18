using System;
using System.ComponentModel.DataAnnotations;

public class ProntuarioPsicologo
{
    [Key]
    public Guid ID { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nome { get; set; }

    [Required]
    public DateTime DataNascimento { get; set; }

    [Required]
    [MaxLength(20)]
    public string RG { get; set; }

    [Required]
    [MaxLength(20)]
    public string CPF { get; set; }

    [MaxLength(100)]
    public string Responsavel { get; set; }

    [MaxLength(200)]
    public string Endereco { get; set; }

    [MaxLength(100)]
    public string Municipio { get; set; }

    [MaxLength(100)]
    public string Saude { get; set; }

    public bool Consciente { get; set; }

    [MaxLength(100)]
    public string Religiao { get; set; }

    public bool Filho { get; set; }

    [MaxLength(3)]
    public string QntFilho { get; set; }

    [MaxLength(500)]
    public string Acolhimento { get; set; }

    [MaxLength(1000)]
    public string Historico { get; set; }
}