using Controle_Financeiro.DTOs;
using Controle_Financeiro.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Controle_Financeiro.Controllers;

[ApiController]
[Route("[controller]")]
public class ReceitaController : ControllerBase
{
    private IReceitaService receitaService;

    public ReceitaController(IReceitaService _receitaService)
    {
        receitaService = _receitaService;
    }

    [HttpPost]
    public IActionResult CreateReceita([FromBody] CreateReceitaDto createReceita)
    {
        var readReceita = receitaService.CreateReceita(createReceita);

        return CreatedAtAction(nameof(GetReceitaById), new { id = readReceita.Id }, readReceita);
    }

    [HttpGet("{id}")]
    public IActionResult GetReceitaById(Guid id)
    {
        var readReceita = receitaService.GetReceitaById(id);

        return Ok(readReceita);
    }

    [HttpGet("/receitas")]
    public IActionResult GetAllReceitas()
    {
        var readReceitas = receitaService.GetAllReceitas();

        return Ok(readReceitas);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteReceitaById(Guid id)
    {
        receitaService.DeleteReceitaById(id);

        return NoContent();
    }
}
