using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Asilo.Models;  // Certifique-se de adicionar o namespace onde o modelo Documento está definido

[ApiController]
[Route("api/[controller]")]
public class DocumentosController : ControllerBase
{
    private readonly AsiloContext _context;

    public DocumentosController(AsiloContext context)
    {
        _context = context;
    }

    // GET: api/documentos
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var documentos = await _context.Documentos.ToListAsync();
        return Ok(documentos);
    }

    // POST: api/documentos
    [HttpPost]
    public async Task<IActionResult> Post(Documento documento)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _context.Documentos.Add(documento);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(Get), new { id = documento.Identidade }, documento);
    }

    // PUT: api/documentos/{identidade}
    [HttpPut("{identidade}")]
    public async Task<IActionResult> Put(string identidade, Documento documento)
    {
        if (identidade != documento.Identidade)
        {
            return BadRequest();
        }

        _context.Entry(documento).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!DocumentoExists(identidade))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // DELETE: api/documentos/{identidade}
    [HttpDelete("{identidade}")]
    public async Task<IActionResult> Delete(string identidade)
    {
        var documento = await _context.Documentos.FindAsync(identidade);
        if (documento == null)
        {
            return NotFound();
        }

        _context.Documentos.Remove(documento);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool DocumentoExists(string identidade)
    {
        return _context.Documentos.Any(d => d.Identidade == identidade);
    }
}
