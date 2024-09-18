using System;
using System.ComponentModel.DataAnnotations;

public class EstoqueAlimento
{
    [Key]
    public Guid ID { get; set; }
    [Required]
    [MaxLength(100)]
    public string Nome { get; set; }
    [Required]
    public int Quantidade { get; set; }
    [Required]
    public double Valor { get; set; }
    [Required]
    public DateTime Validade { get; set; }
    public int? IdProfissional { get; set; }
    [MaxLength(255)]
    public string ControleSaude { get; set; }
}
