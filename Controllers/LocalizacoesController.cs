// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using System.Threading.Tasks;
// using System.Net.Http;
// using Asilo.Models;

// [ApiController]
// [Route("api/[controller]")]
// public class LocalizacoesController : ControllerBase
// {
//     private readonly AsiloContext _context;
//     private readonly IHttpClientFactory _httpClientFactory;

//     public LocalizacoesController(AsiloContext context, IHttpClientFactory httpClientFactory)
//     {
//         _context = context;
//         _httpClientFactory = httpClientFactory;
//     }

//     // GET: api/Localizacoes
//     [HttpGet]
//     public async Task<IActionResult> Get()
//     {
//         var localizacoes = await _context.Localizacoes.ToListAsync();
//         return Ok(localizacoes);
//     }

//     // POST: api/Localizacoes
//     [HttpPost]
//     public async Task<IActionResult> Post(Localizacao localizacao)
//     {
//         if (!ModelState.IsValid)
//         {
//             return BadRequest(ModelState);
//         }

//         var localizacaoCompleta = await CompletarCamposLocalizacao(localizacao.Cep);
//         if (localizacaoCompleta == null)
//         {
//             return NotFound("CEP não encontrado.");
//         }

//         localizacao.logradouro = localizacaoCompleta.logradouro;
//         localizacao.complemento = localizacaoCompleta.complemento;
//         localizacao.Cidade = localizacaoCompleta.localidade; // Aqui ajustamos para localidade, que corresponde à cidade

//         _context.Localizacoes.Add(localizacao);
//         await _context.SaveChangesAsync();
//         return CreatedAtAction(nameof(Get), new { id = localizacao.Cep }, localizacao);
//     }

//     // PUT: api/Localizacoes/{cep}
//     [HttpPut("{cep}")]
//     public async Task<IActionResult> Put(string cep, Localizacao localizacao)
//     {
//         if (cep != localizacao.Cep)
//         {
//             return BadRequest();
//         }

//         var existingLocalizacao = await _context.Localizacoes.FindAsync(cep);
//         if (existingLocalizacao == null)
//         {
//             return NotFound();
//         }

//         var localizacaoCompleta = await CompletarCamposLocalizacao(localizacao.Cep);
//         if (localizacaoCompleta == null)
//         {
//             return NotFound("CEP não encontrado.");
//         }

//         existingLocalizacao.numero = localizacao.numero;
//         existingLocalizacao.logradouro = localizacaoCompleta.logradouro;
//         existingLocalizacao.complemento = localizacaoCompleta.complemento;
//         existingLocalizacao.Cidade = localizacaoCompleta.localidade; // Aqui ajustamos para localidade, que corresponde à cidade

//         await _context.SaveChangesAsync();
//         return NoContent();
//     }

//     // DELETE: api/Localizacoes/{cep}
//     [HttpDelete("{cep}")]
//     public async Task<IActionResult> Delete(string cep)
//     {
//         var localizacao = await _context.Localizacoes.FindAsync(cep);
//         if (localizacao == null)
//         {
//             return NotFound();
//         }

//         _context.Localizacoes.Remove(localizacao);
//         await _context.SaveChangesAsync();
//         return NoContent();
//     }

//     private async Task<ViaCepResponse> CompletarCamposLocalizacao(string cep)
//     {
//         var client = _httpClientFactory.CreateClient();
//         var response = await client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
//         if (!response.IsSuccessStatusCode)
//         {
//             return null;
//         }

//         var viaCepResponse = await response.Content.ReadAs.......Async<ViaCepResponse>();
//         if (viaCepResponse == null)
//         {
//             return null;
//         }

//         return viaCepResponse;
//     }

//     private void Async<T>()
//     {
//         throw new NotImplementedException();
//     }
// }

// public class Localizacao
// {
//     internal string logradouro;
//     internal string complemento;
//     internal int numero;

//     public string Cep { get; internal set; }
//     public string Cidade { get; internal set; }
// }