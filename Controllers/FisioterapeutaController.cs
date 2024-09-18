using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class FisioterapeutaController : ControllerBase
{
    private readonly AsiloContext _context;

    public FisioterapeutaController(AsiloContext context)
    {
        _context = context;
    }

    
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var prontuarios = await _context.ProntuariosFisioterapeuta.ToListAsync();
        return Ok(prontuarios);
    }

    
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var prontuario = await _context.ProntuariosFisioterapeuta.FindAsync(id);
        if (prontuario == null)
            return NotFound();

        return Ok(prontuario);
    }


    [HttpPost]
    public async Task<IActionResult> Post(ProntuarioFisioterapeuta prontuario)
    {
        prontuario.ID = Guid.NewGuid();
        _context.ProntuariosFisioterapeuta.Add(prontuario);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = prontuario.ID }, prontuario);
    }

    
    [HttpPut("{id}")]


public async Task<IActionResult> Put(Guid id, ProntuarioFisioterapeuta prontuario)
{
    var existingProntuario = await _context.ProntuariosFisioterapeuta.FindAsync(id);
    if (existingProntuario == null)
        return NotFound();

    existingProntuario.DataAvaliacao = prontuario.DataAvaliacao;
    existingProntuario.Nome = prontuario.Nome;
    existingProntuario.Sexo = prontuario.Sexo;
    existingProntuario.Idade = prontuario.Idade;
    existingProntuario.DataNascimento = prontuario.DataNascimento;
    existingProntuario.EstadoCivil = prontuario.EstadoCivil;
    existingProntuario.Telefone = prontuario.Telefone;
    existingProntuario.Endereco = prontuario.Endereco;
    existingProntuario.ExamesComplementares = prontuario.ExamesComplementares;
    existingProntuario.Medicamentos = prontuario.Medicamentos;
    existingProntuario.DiagnosticoClinicoPatologico = prontuario.DiagnosticoClinicoPatologico;
    existingProntuario.QueixaPrincipal = prontuario.QueixaPrincipal;
    existingProntuario.HMA = prontuario.HMA;
    existingProntuario.AVD = prontuario.AVD;
    existingProntuario.AparelhoLocomotor = prontuario.AparelhoLocomotor;
    existingProntuario.AparelhoCardioRespiratorio = prontuario.AparelhoCardioRespiratorio;
    existingProntuario.AparelhoCardioVascular = prontuario.AparelhoCardioVascular;
    existingProntuario.Ginecologico = prontuario.Ginecologico;
    existingProntuario.Outros = prontuario.Outros;
    existingProntuario.DificuldadeComunicacao = prontuario.DificuldadeComunicacao;
    existingProntuario.TipoMedicamento = prontuario.TipoMedicamento;
    existingProntuario.Dosagem = prontuario.Dosagem;
    existingProntuario.Frequencia = prontuario.Frequencia;
    existingProntuario.RemedioSemPrescricao = prontuario.RemedioSemPrescricao;
    existingProntuario.HabilidadeManusear = prontuario.HabilidadeManusear;
    existingProntuario.FrequenciaRefeicoes = prontuario.FrequenciaRefeicoes;
    existingProntuario.DietaEspecial = prontuario.DietaEspecial;
    existingProntuario.IngestaoAlcool = prontuario.IngestaoAlcool;
    existingProntuario.IngestaoHidrica = prontuario.IngestaoHidrica;
    existingProntuario.UsaProtese = prontuario.UsaProtese;
    existingProntuario.Apetite = prontuario.Apetite;
    existingProntuario.PorqueApetite = prontuario.PorqueApetite;
    existingProntuario.Demencia = prontuario.Demencia;
    existingProntuario.EscalaDepressao = prontuario.EscalaDepressao;
    existingProntuario.EstadoEmocional = prontuario.EstadoEmocional;
    existingProntuario.Peso = prontuario.Peso;
    existingProntuario.Altura = prontuario.Altura;
    existingProntuario.PA = prontuario.PA;
    existingProntuario.AuscultaCardiaca = prontuario.AuscultaCardiaca;
    existingProntuario.FrequenciaCardiaca = prontuario.FrequenciaCardiaca;
    existingProntuario.AuscultaPulmonar = prontuario.AuscultaPulmonar;
    existingProntuario.FrequenciaRespiratoria = prontuario.FrequenciaRespiratoria;
    existingProntuario.PadraoRespiratorio = prontuario.PadraoRespiratorio;
    existingProntuario.OmbroFlexaoVR = prontuario.OmbroFlexaoVR;
    existingProntuario.OmbroFlexaoAdmDireito = prontuario.OmbroFlexaoAdmDireito;
    existingProntuario.OmbroFlexaoAdmEsquerdo = prontuario.OmbroFlexaoAdmEsquerdo;
    existingProntuario.OmbroExtensaoVR = prontuario.OmbroExtensaoVR;
    existingProntuario.OmbroExtensaoAdmDireito = prontuario.OmbroExtensaoAdmDireito;
    existingProntuario.OmbroExtensaoAdmEsquerdo = prontuario.OmbroExtensaoAdmEsquerdo;
    existingProntuario.OmbroAducaoVR = prontuario.OmbroAducaoVR;
    existingProntuario.OmbroAducaoAdmDireito = prontuario.OmbroAducaoAdmDireito;
    existingProntuario.OmbroAducaoAdmEsquerdo = prontuario.OmbroAducaoAdmEsquerdo;
    existingProntuario.OmbroAbducaoVR = prontuario.OmbroAbducaoVR;
    existingProntuario.OmbroAbducaoAdmDireito = prontuario.OmbroAbducaoAdmDireito;
    existingProntuario.OmbroAbducaoAdmEsquerdo = prontuario.OmbroAbducaoAdmEsquerdo;
    existingProntuario.OmbroRotInternaVR = prontuario.OmbroRotInternaVR;
    existingProntuario.OmbroRotInternaAdmDireito = prontuario.OmbroRotInternaAdmDireito;
    existingProntuario.OmbroRotInternaAdmEsquerdo = prontuario.OmbroRotInternaAdmEsquerdo;
    existingProntuario.OmbroRotExternaVR = prontuario.OmbroRotExternaVR;
    existingProntuario.OmbroRotExternaAdmDireito = prontuario.OmbroRotExternaAdmDireito;
    existingProntuario.OmbroRotExternaAdmEsquerdo = prontuario.OmbroRotExternaAdmEsquerdo;
    existingProntuario.CotoveloFlexaoVR = prontuario.CotoveloFlexaoVR;
    existingProntuario.CotoveloFlexaoAdmDireito = prontuario.CotoveloFlexaoAdmDireito;
    existingProntuario.CotoveloFlexaoAdmEsquerdo = prontuario.CotoveloFlexaoAdmEsquerdo;
    existingProntuario.CotoveloExtensaoVR = prontuario.CotoveloExtensaoVR;
    existingProntuario.CotoveloExtensaoAdmDireito = prontuario.CotoveloExtensaoAdmDireito;
    existingProntuario.CotoveloExtensaoAdmEsquerdo = prontuario.CotoveloExtensaoAdmEsquerdo;
    existingProntuario.PunhoExtensaoVR = prontuario.PunhoExtensaoVR;
    existingProntuario.PunhoExtensaoAdmDireito = prontuario.PunhoExtensaoAdmDireito;
    existingProntuario.PunhoExtensaoAdmEsquerdo = prontuario.PunhoExtensaoAdmEsquerdo;
    existingProntuario.PunhoFlexaoVR = prontuario.PunhoFlexaoVR;
    existingProntuario.PunhoFlexaoAdmDireito = prontuario.PunhoFlexaoAdmDireito;
    existingProntuario.PunhoFlexaoAdmEsquerdo = prontuario.PunhoFlexaoAdmEsquerdo;
    existingProntuario.PunhoDesvioUlnarVR = prontuario.PunhoDesvioUlnarVR;
    existingProntuario.PunhoDesvioUlnarAdmDireito = prontuario.PunhoDesvioUlnarAdmDireito;
    existingProntuario.PunhoDesvioUlnarAdmEsquerdo = prontuario.PunhoDesvioUlnarAdmEsquerdo;
    existingProntuario.PunhoDesvioRadialVR = prontuario.PunhoDesvioRadialVR;
    existingProntuario.PunhoDesvioRadialAdmDireito = prontuario.PunhoDesvioRadialAdmDireito;
    existingProntuario.PunhoDesvioRadialAdmEsquerdo = prontuario.PunhoDesvioRadialAdmEsquerdo;
    existingProntuario.QuadrilFlexaoVR = prontuario.QuadrilFlexaoVR;
    existingProntuario.QuadrilFlexaoAdmDireito = prontuario.QuadrilFlexaoAdmDireito;
    existingProntuario.QuadrilFlexaoAdmEsquerdo = prontuario.QuadrilFlexaoAdmEsquerdo;
    existingProntuario.QuadrilExtensaoVR = prontuario.QuadrilExtensaoVR;
    existingProntuario.QuadrilExtensaoAdmDireito = prontuario.QuadrilExtensaoAdmDireito;
    existingProntuario.QuadrilExtensaoAdmEsquerdo = prontuario.QuadrilExtensaoAdmEsquerdo;
    existingProntuario.QuadrilAducaoVR = prontuario.QuadrilAducaoVR;
    existingProntuario.QuadrilAducaoAdmDireito = prontuario.QuadrilAducaoAdmDireito;
    existingProntuario.QuadrilAducaoAdmEsquerdo = prontuario.QuadrilAducaoAdmEsquerdo;
    existingProntuario.QuadrilAbducaoVR = prontuario.QuadrilAbducaoVR;
    existingProntuario.OmbroAbducaoAdmDireito = prontuario.OmbroAbducaoAdmDireito;
    existingProntuario.OmbroAbducaoAdmEsquerdo = prontuario.QuadrilAbducaoAdmEsquerdo;
    existingProntuario.QuadrilRotInternaVR = prontuario.QuadrilRotInternaVR;
    existingProntuario.QuadrilRotInternaAdmDireito = prontuario.QuadrilRotInternaAdmDireito;
    existingProntuario.QuadrilRotInternaAdmEsquerdo = prontuario.QuadrilRotInternaAdmEsquerdo;
    existingProntuario.QuadrilRotExternaVR = prontuario.QuadrilRotExternaVR;
    existingProntuario.QuadrilRotExternaAdmDireito = prontuario.QuadrilRotExternaAdmDireito;
    existingProntuario.QuadrilRotExternaAdmEsquerdo = prontuario.QuadrilRotExternaAdmEsquerdo;
    existingProntuario.JoelhoFlexaoVR = prontuario.JoelhoFlexaoVR;
    existingProntuario.JoelhoFlexaoAdmDireito = prontuario.JoelhoFlexaoAdmDireito;
    existingProntuario.JoelhoFlexaoAdmEsquerdo = prontuario.JoelhoFlexaoAdmEsquerdo;
    existingProntuario.JoelhoExtensaoVR = prontuario.JoelhoExtensaoVR;
    existingProntuario.JoelhoExtensaoAdmDireito = prontuario.JoelhoExtensaoAdmDireito;
    existingProntuario.JoelhoExtensaoAdmEsquerdo = prontuario.JoelhoExtensaoAdmEsquerdo;
    existingProntuario.TornozeloEversaoVR = prontuario.TornozeloEversaoVR;
    existingProntuario.TornozeloEversaoAdmDireito = prontuario.TornozeloEversaoAdmDireito;
    existingProntuario.TornozeloEversaoAdmEsquerdo = prontuario.TornozeloEversaoAdmEsquerdo;
    existingProntuario.TornozeloDorsiflexaoVR = prontuario.TornozeloDorsiflexaoVR;
    existingProntuario.TornozeloDorsiflexaoAdmDireito = prontuario.TornozeloDorsiflexaoAdmDireito;
    existingProntuario.TornozeloDorsiflexaoAdmEsquerdo = prontuario.TornozeloDorsiflexaoAdmEsquerdo;
    existingProntuario.TornozeloFlexaoPlantarVR = prontuario.TornozeloFlexaoPlantarVR;
    existingProntuario.TornozeloFlexaoPlantarAdmDireito = prontuario.TornozeloFlexaoPlantarAdmDireito;
    existingProntuario.TornozeloFlexaoPlantarAdmEsquerdo = prontuario.TornozeloFlexaoPlantarAdmEsquerdo;
    existingProntuario.TornozeloInversaoVR = prontuario.TornozeloInversaoVR;
    existingProntuario.TornozeloInversaoAdmDireito = prontuario.TornozeloInversaoAdmDireito;
    existingProntuario.TornozeloInversaoAdmEsquerdo = prontuario.TornozeloInversaoAdmEsquerdo;
    existingProntuario.TempoQuedas = prontuario.TempoQuedas;
    existingProntuario.FrequenciaQuedas = prontuario.FrequenciaQuedas;
    existingProntuario.LocalQuedas = prontuario.LocalQuedas;
    existingProntuario.Reflexo = prontuario.Reflexo;
    existingProntuario.EquilibrioSentado = prontuario.EquilibrioSentado;
    existingProntuario.EquilibrioEmPe = prontuario.EquilibrioEmPe;
    existingProntuario.EquilibrioSinalRosemberg = prontuario.EquilibrioSinalRosemberg;
    existingProntuario.AtividadeVidaDiaria = prontuario.AtividadeVidaDiaria;
    existingProntuario.EscalaDor = prontuario.EscalaDor;
    existingProntuario.RegiaoDor = prontuario.RegiaoDor;
    existingProntuario.PeSagital = prontuario.PeSagital;
    existingProntuario.PeFrontal = prontuario.PeFrontal;
    existingProntuario.JoelhoSagital = prontuario.JoelhoSagital;
    existingProntuario.JoelhoFrontal = prontuario.JoelhoFrontal;
    existingProntuario.CinturaPelvicaSagital = prontuario.CinturaPelvicaSagital;
    existingProntuario.CinturaPelvicaFrontal = prontuario.CinturaPelvicaFrontal;
    existingProntuario.ColunaSagital = prontuario.ColunaSagital;
    existingProntuario.ColunaFrontal = prontuario.ColunaFrontal;
    existingProntuario.CinturaEscapularSagital = prontuario.CinturaEscapularSagital;
    existingProntuario.CinturaEscapularFrontal = prontuario.CinturaEscapularFrontal;
    existingProntuario.CabecaSagital = prontuario.CabecaSagital;
    existingProntuario.CabecaFrontal = prontuario.CabecaFrontal;
    existingProntuario.AvaliacaoMarcha = prontuario.AvaliacaoMarcha;
    existingProntuario.Observacoes = prontuario.Observacoes;
    existingProntuario.DiagnosticoFuncional = prontuario.DiagnosticoFuncional;
    existingProntuario.ObjetivosFisioterapicos = prontuario.ObjetivosFisioterapicos;

    await _context.SaveChangesAsync();
    return NoContent();
}


        
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var prontuario = await _context.ProntuariosFisioterapeuta.FindAsync(id);
        if (prontuario == null)
            return NotFound();

        _context.ProntuariosFisioterapeuta.Remove(prontuario);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
