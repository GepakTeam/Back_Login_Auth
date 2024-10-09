using System.ComponentModel.DataAnnotations;

public class LoginModel
{
    [Required]
    [EmailAddress] // Se você usar email como identificador, mantenha isso.
    public string Email { get; set; } // Ou mude para UserName caso precise

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    // Opção para manter o login persistente (caso deseje lembrar o usuário no navegador)
    public bool RememberMe { get; set; } = false;
}
