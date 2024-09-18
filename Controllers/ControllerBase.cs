using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class BaseController<TEntity, TContext> : ControllerBase
    where TEntity : class
    where TContext : DbContext
{
    private readonly TContext _context;

    public BaseController(TContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TEntity>>> GetAll()
    {
        return await _context.Set<TEntity>().ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TEntity>> GetById(int id)
    {
        var entity = await _context.Set<TEntity>().FindAsync(id);

        if (entity == null)
        {
            return NotFound();
        }

        return entity;
    }

    [HttpPost]
    public async Task<ActionResult<TEntity>> Create(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = GetEntityId(entity) }, entity);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, TEntity entity)
    {
        if (GetEntityId(entity) != id)
        {
            return BadRequest();
        }

        _context.Entry(entity).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!EntityExists(id))
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

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var entity = await _context.Set<TEntity>().FindAsync(id);
        if (entity == null)
        {
            return NotFound();
        }

        _context.Set<TEntity>().Remove(entity);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool EntityExists(int id)
    {
        return _context.Set<TEntity>().Find(id) != null;
    }

    private int GetEntityId(TEntity entity)
    {
        var propertyInfo = entity.GetType().GetProperty("ID");
        if (propertyInfo != null)
        {
            return (int)propertyInfo.GetValue(entity);
        }

        propertyInfo = entity.GetType().GetProperty($"{typeof(TEntity).Name}ID");
        if (propertyInfo != null)
        {
            return (int)propertyInfo.GetValue(entity);
        }

        throw new System.Exception("ID property not found");
    }
}
