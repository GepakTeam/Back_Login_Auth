using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asilo.Models;
[ApiController]
[Route("api/[controller]")]
public class ProntuariosController : ControllerBase
{
    private readonly AsiloContext _context;

    public ProntuariosController(AsiloContext context)
    {
        _context = context;
    }

    // [HttpGet]
    // public async Task<IActionResult> GetAll(){
    //     var prontuarios = await _context.ProntuariosIndividuais.ToListAsync();
    //     return Ok(prontuarios);
    // }
    [HttpGet]
    public async Task<IActionResult> Listar()
    {
        var prontuarios = await _context.ProntuariosIndividuais.ToListAsync();
        return Ok(prontuarios);
    }

    // [HttpGet]
    // public async Task<IActionResult> Get()
    // {
    //     var prontuarios = await _context.ProntuariosIndividuais.ToListAsync();
    //     return Ok(prontuarios);
    // }

    [HttpPost]
    public async Task<IActionResult> Post(ProntuarioIndividual prontuario)
    {
        prontuario.Id = Guid.NewGuid();
        _context.ProntuariosIndividuais.Add(prontuario);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Listar), new { id = prontuario.Id }, prontuario);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, ProntuarioIndividual prontuario)
    {
        var existingProntuario = await _context.ProntuariosIndividuais.FindAsync(id);
        if (existingProntuario == null)
            return NotFound();

        // Atualiza todos os campos do prontuário
        existingProntuario.Nome = prontuario.Nome;
        existingProntuario.DataNascimento = prontuario.DataNascimento;
        existingProntuario.Idade = prontuario.Idade;
        existingProntuario.LocalNascimento = prontuario.LocalNascimento;
        existingProntuario.Sexo = prontuario.Sexo;
        existingProntuario.Raca = prontuario.Raca;
        existingProntuario.Telefone = prontuario.Telefone;
        existingProntuario.NomeMae = prontuario.NomeMae;
        existingProntuario.NomePai = prontuario.NomePai;
        existingProntuario.NomeResponsavel = prontuario.NomeResponsavel;
        existingProntuario.Endereco = prontuario.Endereco;
        existingProntuario.Cep = prontuario.Cep;
        existingProntuario.PontoReferencia = prontuario.PontoReferencia;
        existingProntuario.Rg = prontuario.Rg;
        existingProntuario.Cpf = prontuario.Cpf;
        existingProntuario.CarteiraTrabalho = prontuario.CarteiraTrabalho;
        existingProntuario.TituloEleitoral = prontuario.TituloEleitoral;
        existingProntuario.CertidaoNascimento = prontuario.CertidaoNascimento;
        existingProntuario.RelacaoAmigavel = prontuario.RelacaoAmigavel;
        existingProntuario.RelacaoDistanciados = prontuario.RelacaoDistanciados;
        existingProntuario.RelacaoConflituosa = prontuario.RelacaoConflituosa;
        existingProntuario.QuemResideCasa = prontuario.QuemResideCasa;
        existingProntuario.Filho = prontuario.Filho;
        existingProntuario.QntFilho = prontuario.QntFilho;
        existingProntuario.ComQuemMoraFilhos = prontuario.ComQuemMoraFilhos;
        existingProntuario.Moradia = prontuario.Moradia;
        existingProntuario.Doenca = prontuario.Doenca;
        existingProntuario.Deficiencia = prontuario.Deficiencia;
        existingProntuario.QuaisDeficiencias = prontuario.QuaisDeficiencias;
        existingProntuario.Saude = prontuario.Saude;
        existingProntuario.AtividadesLazer = prontuario.AtividadesLazer;
        existingProntuario.Parceiros = prontuario.Parceiros;
        existingProntuario.Acompanhamento = prontuario.Acompanhamento;
        existingProntuario.QualMedicacao = prontuario.QualMedicacao;
        existingProntuario.PlanoSaude = prontuario.PlanoSaude;
        existingProntuario.QualPlanoSaude = prontuario.QualPlanoSaude;
        existingProntuario.UsoDroga = prontuario.UsoDroga;
        existingProntuario.QuaisDrogasUsou = prontuario.QuaisDrogasUsou;
        existingProntuario.HistoricoUso = prontuario.HistoricoUso;
        existingProntuario.AtendimentoPsicologico = prontuario.AtendimentoPsicologico;
        existingProntuario.LocalAtendimentoPsicologico = prontuario.LocalAtendimentoPsicologico;
        existingProntuario.TratamentoPsiquiatrico = prontuario.TratamentoPsiquiatrico;
        existingProntuario.LocalTratamentoPsiquiatrico = prontuario.LocalTratamentoPsiquiatrico;
        existingProntuario.TomaAlgumTipoMedicamento = prontuario.TomaAlgumTipoMedicamento;
        existingProntuario.MotivoEncaminhamentoPsicologico = prontuario.MotivoEncaminhamentoPsicologico;

        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var prontuario = await _context.ProntuariosIndividuais.FindAsync(id);
        if (prontuario == null)
            return NotFound();

        _context.ProntuariosIndividuais.Remove(prontuario);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
