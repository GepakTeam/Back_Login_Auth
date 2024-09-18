using System;
using System.ComponentModel.DataAnnotations;

public class Profissional
{
    [Key]
    public Guid ID_P { get; set; }
    [Required]
    [MaxLength(100)]
    public string Nome { get; set; }
    public int? Idade { get; set; }
    [Required]
    [MaxLength(11)]
    public string CPF { get; set; }
    public bool IdosoDependente { get; set; }
    [MaxLength(100)]
    public string Especializacao { get; set; }
    [MaxLength(20)]
    public string Telefone { get; set; }
    [MaxLength(100)]
    public string Email { get; set; }
   
}
