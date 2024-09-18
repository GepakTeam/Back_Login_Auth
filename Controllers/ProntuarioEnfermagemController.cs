using Asilo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class ProntuarioEnfermagemController : ControllerBase
{
    private readonly AsiloContext _context;

    public ProntuarioEnfermagemController(AsiloContext context)
    {
        _context = context;
    }

    // GET: api/ProntuarioEnfermagem
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var prontuarios = await _context.ProntuariosEnfermagem.ToListAsync();
        return Ok(prontuarios);
    }

    // GET: api/ProntuarioEnfermagem/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var prontuario = await _context.ProntuariosEnfermagem.FindAsync(id);
        if (prontuario == null)
            return NotFound();

        return Ok(prontuario);
    }

    // POST: api/ProntuarioEnfermagem
    [HttpPost]
    public async Task<IActionResult> Post(ProntuarioEnfermagem prontuario)
    {
        _context.ProntuariosEnfermagem.Add(prontuario);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = prontuario.ID }, prontuario);
    }

    // PUT: api/ProntuarioEnfermagem/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, ProntuarioEnfermagem prontuario)
    {
        var existingProntuario = await _context.ProntuariosEnfermagem.FindAsync(id);
        if (existingProntuario == null)
            return NotFound();

        // Atualiza todas as propriedades necessárias
        existingProntuario.Nome = prontuario.Nome;
        existingProntuario.Prontuario = prontuario.Prontuario;
        existingProntuario.DataNascimento = prontuario.DataNascimento;
        existingProntuario.DataExame = prontuario.DataExame;
        existingProntuario.NivelConciencia = prontuario.NivelConciencia;
        existingProntuario.PupilasSituacao = prontuario.PupilasSituacao;
        existingProntuario.PupilaPD = prontuario.PupilaPD;
        existingProntuario.PupilaPE = prontuario.PupilaPE;
        existingProntuario.Fotorreacao = prontuario.Fotorreacao;
        existingProntuario.SistemaCardioCirculatorio = prontuario.SistemaCardioCirculatorio;
        existingProntuario.CarotideosEsquerdo = prontuario.CarotideosEsquerdo;
        existingProntuario.CarotideosDireito = prontuario.CarotideosDireito;
        existingProntuario.BraquiaisEsquerdo = prontuario.BraquiaisEsquerdo;
        existingProntuario.BraquiaisDireito = prontuario.BraquiaisDireito;
        existingProntuario.RadiaisEsquerdo = prontuario.RadiaisEsquerdo;
        existingProntuario.RadiaisDireito = prontuario.RadiaisDireito;
        existingProntuario.FemoraisEsquerdo = prontuario.FemoraisEsquerdo;
        existingProntuario.FemoraisDireito = prontuario.FemoraisDireito;
        existingProntuario.PediososEsquerdo = prontuario.PediososEsquerdo;
        existingProntuario.PediososDireito = prontuario.PediososDireito;
        existingProntuario.PopliteosEsquerdo = prontuario.PopliteosEsquerdo;
        existingProntuario.PopliteosDireito = prontuario.PopliteosDireito;
        existingProntuario.PerfusaoPeriferica = prontuario.PerfusaoPeriferica;
        existingProntuario.Edema = prontuario.Edema;
        existingProntuario.Padrao = prontuario.Padrao;
        existingProntuario.MurmurioVesicular = prontuario.MurmurioVesicular;
        existingProntuario.ExpansaoTorax = prontuario.ExpansaoTorax;
        existingProntuario.RuidosAdventicios = prontuario.RuidosAdventicios;
        existingProntuario.AceitacaoDieta = prontuario.AceitacaoDieta;
        existingProntuario.Denticao = prontuario.Denticao;
        existingProntuario.Abdome = prontuario.Abdome;
        existingProntuario.Rha = prontuario.Rha;
        existingProntuario.Massa = prontuario.Massa;
        existingProntuario.Evacuacao = prontuario.Evacuacao;
        existingProntuario.Genito = prontuario.Genito;
        existingProntuario.Urina = prontuario.Urina;
        existingProntuario.Vesical = prontuario.Vesical;
        existingProntuario.Cutanea = prontuario.Cutanea;
        existingProntuario.Sensorial = prontuario.Sensorial;
        existingProntuario.Umidade = prontuario.Umidade;
        existingProntuario.Atividade = prontuario.Atividade;
        existingProntuario.Mobilidade = prontuario.Mobilidade;
        existingProntuario.Nutricao = prontuario.Nutricao;
        existingProntuario.Friccao = prontuario.Friccao;
        existingProntuario.DiagnosticosEnfermagem = prontuario.DiagnosticosEnfermagem;
        existingProntuario.ControleSinaisVitaisData = prontuario.ControleSinaisVitaisData;
        existingProntuario.ControleSinaisVitaisHorario = prontuario.ControleSinaisVitaisHorario;
        existingProntuario.ControleSinaisVitaisPa = prontuario.ControleSinaisVitaisPa;
        existingProntuario.ControleSinaisVitaisFc = prontuario.ControleSinaisVitaisFc;
        existingProntuario.ControleSinaisVitaisFr = prontuario.ControleSinaisVitaisFr;
        existingProntuario.ControleSinaisVitaisTemp = prontuario.ControleSinaisVitaisTemp;
        existingProntuario.ControleSinaisVitaisPvc = prontuario.ControleSinaisVitaisPvc;
        existingProntuario.ControleSinaisVitaisGlicemia = prontuario.ControleSinaisVitaisGlicemia;
        existingProntuario.ControleSinaisVitaisAnotacoes = prontuario.ControleSinaisVitaisAnotacoes;

        await _context.SaveChangesAsync();
        return NoContent();
    }

    // DELETE: api/ProntuarioEnfermagem/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var prontuario = await _context.ProntuariosEnfermagem.FindAsync(id);
        if (prontuario == null)
            return NotFound();

        _context.ProntuariosEnfermagem.Remove(prontuario);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
