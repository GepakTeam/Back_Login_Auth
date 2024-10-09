using Asilo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Asilo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProntuarioNutricionistaController : ControllerBase
    {
        private readonly AsiloContext _context;

        public ProntuarioNutricionistaController(AsiloContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var prontuarios = await _context.ProntuariosNutricionista.ToListAsync();
            return Ok(prontuarios);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var prontuario = await _context.ProntuariosNutricionista.FindAsync(id);
            if (prontuario == null)
                return NotFound();

            return Ok(prontuario);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ProntuarioNutricionista prontuario)
        {
            prontuario.ID = Guid.NewGuid();
            _context.ProntuariosNutricionista.Add(prontuario);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = prontuario.ID }, prontuario);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, ProntuarioNutricionista prontuario)
        {
            var existingProntuario = await _context.ProntuariosNutricionista.FindAsync(id);
            if (existingProntuario == null)
                return NotFound();

            existingProntuario.DataAvaliacao = prontuario.DataAvaliacao;
            existingProntuario.Nome = prontuario.Nome;
            existingProntuario.Idade = prontuario.Idade;
            existingProntuario.DataNascimento = prontuario.DataNascimento;
            existingProntuario.MotivoConsulta = prontuario.MotivoConsulta;
            existingProntuario.EncaminhadoPor = prontuario.EncaminhadoPor;
            existingProntuario.Convenio = prontuario.Convenio;
            existingProntuario.Telefone = prontuario.Telefone;
            existingProntuario.Endereco = prontuario.Endereco;
            existingProntuario.Escolaridade = prontuario.Escolaridade;
            existingProntuario.Profissao = prontuario.Profissao;
            existingProntuario.NumeroPessoasCasa = prontuario.NumeroPessoasCasa;
            existingProntuario.NumeroAdulto = prontuario.NumeroAdulto;
            existingProntuario.NumeroCrianca = prontuario.NumeroCrianca;
            existingProntuario.EstadoCivil = prontuario.EstadoCivil;
            existingProntuario.ProblemaSaude = prontuario.ProblemaSaude;
            existingProntuario.QualProblemaSaude = prontuario.QualProblemaSaude;
            existingProntuario.Diabetes = prontuario.Diabetes;
            existingProntuario.Hipertensao = prontuario.Hipertensao;
            existingProntuario.Obesidade = prontuario.Obesidade;
            existingProntuario.Dislipidemia = prontuario.Dislipidemia;
            existingProntuario.OutrosProblemas = prontuario.OutrosProblemas;
            existingProntuario.AntecedenteDiabetes = prontuario.AntecedenteDiabetes;
            existingProntuario.AntecedenteHipertensao = prontuario.AntecedenteHipertensao;
            existingProntuario.AntecedenteObesidade = prontuario.AntecedenteObesidade;
            existingProntuario.AntecedenteDislipidemia = prontuario.AntecedenteDislipidemia;
            existingProntuario.OutrosAntecedentes = prontuario.OutrosAntecedentes;
            existingProntuario.HabitoIntestinal = prontuario.HabitoIntestinal;
            existingProntuario.CaracteristicaFezes = prontuario.CaracteristicaFezes;
            existingProntuario.HabitoUrinario = prontuario.HabitoUrinario;
            existingProntuario.HorasSono = prontuario.HorasSono;
            existingProntuario.AtividadeFisica = prontuario.AtividadeFisica;
            existingProntuario.FrequenciaAtividadeFisica = prontuario.FrequenciaAtividadeFisica;
            existingProntuario.Fuma = prontuario.Fuma;
            existingProntuario.QuantoFuma = prontuario.QuantoFuma;
            existingProntuario.HaQuantoTempoFuma = prontuario.HaQuantoTempoFuma;
            existingProntuario.FazUsoBebidaAlcoolica = prontuario.FazUsoBebidaAlcoolica;
            existingProntuario.TipoBebida = prontuario.TipoBebida;
            existingProntuario.HaQuantoTempoBebida = prontuario.HaQuantoTempoBebida;
            existingProntuario.FazUsoLaxante = prontuario.FazUsoLaxante;
            existingProntuario.PorQuantoTempoLaxante = prontuario.PorQuantoTempoLaxante;
            existingProntuario.FazUsoMedicamento = prontuario.FazUsoMedicamento;
            existingProntuario.HaQuantoTempoMedicamento = prontuario.HaQuantoTempoMedicamento;
            existingProntuario.QuaisMedicamentos = prontuario.QuaisMedicamentos;
            existingProntuario.IntoleranciaOuAversaoAlimentar = prontuario.IntoleranciaOuAversaoAlimentar;
            existingProntuario.QualIntolerancia = prontuario.QualIntolerancia;
            existingProntuario.HaQuantoTempoIntolerancia = prontuario.HaQuantoTempoIntolerancia;
            existingProntuario.ControleAlimentacao = prontuario.ControleAlimentacao;
            existingProntuario.QualControleAlimentacao = prontuario.QualControleAlimentacao;
            existingProntuario.AlteracaoPeso = prontuario.AlteracaoPeso;
            existingProntuario.EmQuantoTempo = prontuario.EmQuantoTempo;
            existingProntuario.ConsumoAgua = prontuario.ConsumoAgua;
            existingProntuario.ConsumoCafe = prontuario.ConsumoCafe;
            existingProntuario.ConsumoMensalSal = prontuario.ConsumoMensalSal;
            existingProntuario.ConsumoAcucar = prontuario.ConsumoAcucar;
            existingProntuario.ConsumoOleoBanha = prontuario.ConsumoOleoBanha;
            existingProntuario.OndeFazRefeicoes = prontuario.OndeFazRefeicoes;
            existingProntuario.QuemPreparaRefeicoes = prontuario.QuemPreparaRefeicoes;
            existingProntuario.VelocidadeRefeicao = prontuario.VelocidadeRefeicao;
            existingProntuario.AcompanhamentoRefeicao = prontuario.AcompanhamentoRefeicao;
            existingProntuario.PreferenciasAlimentares = prontuario.PreferenciasAlimentares;
            existingProntuario.RestricoesAlimentares = prontuario.RestricoesAlimentares;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var prontuario = await _context.ProntuariosNutricionista.FindAsync(id);
            if (prontuario == null)
                return NotFound();

            _context.ProntuariosNutricionista.Remove(prontuario);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
