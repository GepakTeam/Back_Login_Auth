using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

[Route("api/[controller]")]
[ApiController]
public class IndividualController : ControllerBase
{
    private static List<IndividualDto> _individuals = new List<IndividualDto>();

    // GET: api/individual
    [HttpGet]
    public ActionResult<IEnumerable<IndividualDto>> Get()
    {
        return Ok(_individuals);
    }

    // GET: api/individual/5
    [HttpGet("{index}")]
    public ActionResult<IndividualDto> Get(int index)
    {
        if (index < 0 || index >= _individuals.Count)
        {
            return NotFound();
        }
        return Ok(_individuals[index]);
    }

    // POST: api/individual
    [HttpPost]
    public ActionResult Post([FromBody] IndividualDto individual)
    {
        _individuals.Add(individual);
        return CreatedAtAction(nameof(Get), new { index = _individuals.Count - 1 }, individual);
    }

    // PUT: api/individual/5
    [HttpPut("{index}")]
    public ActionResult Put(int index, [FromBody] IndividualDto individual)
    {
        if (index < 0 || index >= _individuals.Count)
        {
            return NotFound();
        }
        
        _individuals[index].Nome = individual.Nome;
        _individuals[index].NomePai = individual.NomePai;
        _individuals[index].NomeMae = individual.NomeMae;
        _individuals[index].NomeResponsavel = individual.NomeResponsavel;
        
        return NoContent();
    }

    // DELETE: api/individual/5
    [HttpDelete("{index}")]
    public ActionResult Delete(int index)
    {
        if (index < 0 || index >= _individuals.Count)
        {
            return NotFound();
        }
        
        _individuals.RemoveAt(index);
        return NoContent();
    }
}
