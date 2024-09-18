using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class ProfissionaisController : ControllerBase
{
    private readonly AsiloContext _context;

    public ProfissionaisController(AsiloContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var profissionais = await _context.Profissionais.ToListAsync();
        return Ok(profissionais);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Profissional profissional)
    {
        profissional.ID_P = Guid.NewGuid();
        _context.Profissionais.Add(profissional);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = profissional.ID_P }, profissional);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, Profissional profissional)
    {
        var existingProfissional = await _context.Profissionais.FindAsync(id);
        if (existingProfissional == null)
            return NotFound();

        existingProfissional.Nome = profissional.Nome;
        existingProfissional.Idade = profissional.Idade;
        existingProfissional.CPF = profissional.CPF;
        existingProfissional.IdosoDependente = profissional.IdosoDependente;
        existingProfissional.Especializacao = profissional.Especializacao;
        existingProfissional.Telefone = profissional.Telefone;
        existingProfissional.Email = profissional.Email;

        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var profissional = await _context.Profissionais.FindAsync(id);
        if (profissional == null)
            return NotFound();

        _context.Profissionais.Remove(profissional);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
