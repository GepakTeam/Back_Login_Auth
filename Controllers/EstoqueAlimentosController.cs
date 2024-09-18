using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class EstoqueAlimentoController : ControllerBase
{
    private readonly AsiloContext _context;

    public EstoqueAlimentoController(AsiloContext context)
    {
        _context = context;
    }

    // GET: api/EstoqueAlimento
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var estoqueAlimentos = await _context.EstoqueAlimentos.ToListAsync();
        return Ok(estoqueAlimentos);
    }

    // GET: api/EstoqueAlimento/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var estoqueAlimento = await _context.EstoqueAlimentos.FindAsync(id);
        if (estoqueAlimento == null)
            return NotFound();

        return Ok(estoqueAlimento);
    }

    // POST: api/EstoqueAlimento
    [HttpPost]
    public async Task<IActionResult> Post(EstoqueAlimento estoqueAlimento)
    {
        estoqueAlimento.ID = Guid.NewGuid();
        _context.EstoqueAlimentos.Add(estoqueAlimento);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = estoqueAlimento.ID }, estoqueAlimento);
    }

    // PUT: api/EstoqueAlimento/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, EstoqueAlimento estoqueAlimento)
    {
        if (id != estoqueAlimento.ID)
            return BadRequest();

        _context.Entry(estoqueAlimento).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!EstoqueAlimentoExists(id))
                return NotFound();
            else
                throw;
        }

        return NoContent();
    }

    // DELETE: api/EstoqueAlimento/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var estoqueAlimento = await _context.EstoqueAlimentos.FindAsync(id);
        if (estoqueAlimento == null)
            return NotFound();

        _context.EstoqueAlimentos.Remove(estoqueAlimento);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool EstoqueAlimentoExists(Guid id)
    {
        return _context.EstoqueAlimentos.Any(e => e.ID == id);
    }
}
