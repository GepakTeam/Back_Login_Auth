using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class ProntuarioPsicologoController : ControllerBase
{
    private readonly AsiloContext _context;

    public ProntuarioPsicologoController(AsiloContext context)
    {
        _context = context;
    }

    
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var prontuarios = await _context.ProntuariosPsicologo.ToListAsync();
        return Ok(prontuarios);
    }

    
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var prontuario = await _context.ProntuariosPsicologo.FindAsync(id);
        if (prontuario == null)
            return NotFound();

        return Ok(prontuario);
    }

    
    [HttpPost]
    public async Task<IActionResult> Post(ProntuarioPsicologo prontuario)
    {
        _context.ProntuariosPsicologo.Add(prontuario);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = prontuario.ID }, prontuario);
    }


    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, ProntuarioPsicologo prontuario)
    {
        var existingProntuario = await _context.ProntuariosPsicologo.FindAsync(id);
        if (existingProntuario == null)
            return NotFound();

        existingProntuario.Nome = prontuario.Nome;
        existingProntuario.DataNascimento = prontuario.DataNascimento;
        existingProntuario.RG = prontuario.RG;
        existingProntuario.CPF = prontuario.CPF;
        existingProntuario.Responsavel = prontuario.Responsavel;
        existingProntuario.Endereco = prontuario.Endereco;
        existingProntuario.Municipio = prontuario.Municipio;
        existingProntuario.Saude = prontuario.Saude;
        existingProntuario.Consciente = prontuario.Consciente;
        existingProntuario.Religiao = prontuario.Religiao;
        existingProntuario.Filho = prontuario.Filho;
        existingProntuario.QntFilho = prontuario.QntFilho;
        existingProntuario.Acolhimento = prontuario.Acolhimento;
        existingProntuario.Historico = prontuario.Historico;

        await _context.SaveChangesAsync();
        return NoContent();
    }

   
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var prontuario = await _context.ProntuariosPsicologo.FindAsync(id);
        if (prontuario == null)
            return NotFound();

        _context.ProntuariosPsicologo.Remove(prontuario);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
