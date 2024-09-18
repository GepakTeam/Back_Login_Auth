using Asilo.Models;
using Asilo.Models.Account;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class AsiloContext : IdentityDbContext<User>{
    public AsiloContext(DbContextOptions<AsiloContext> options) : base(options) { }

    public DbSet<ProntuarioIndividual> ProntuariosIndividuais { get; set; }
    public DbSet<Profissional> Profissionais { get; set; }
    public DbSet<EstoqueAlimento> EstoqueAlimentos { get; set; }
    public DbSet<ProntuarioPsicologo> ProntuariosPsicologo { get; set; }

    public DbSet<ProntuarioEnfermagem> ProntuariosEnfermagem { get; set; }
    public DbSet<ProntuarioFisioterapeuta> ProntuariosFisioterapeuta { get; set; }

    public DbSet<IndividualDto> IndividualDtos {get; set;}
    // public DbSet<ViaCepResponse> Localizacoes { get; set; }
    public DbSet<Documento> Documentos {get; set;}
    public object ProntuariosFisioterapeutas { get; internal set; }
    public object ProntuarioEnfermagem { get; internal set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Configurações adicionais do modelo
    }
}
