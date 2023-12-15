using AutoMapper;
using Controle_Financeiro.Data;
using Controle_Financeiro.DTOs;
using Controle_Financeiro.Interfaces;
using Controle_Financeiro.Models;

namespace Controle_Financeiro.Repository;

public class ReceitaRepository : IReceitaRepository
{
    private ControleFinanceiroContext _context;
    private IMapper _mapper;

    public ReceitaRepository(ControleFinanceiroContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public ReadReceitaDto AddNewReceita(Receita receita)
    {
        _context.Receitas.Add(receita);
        _context.SaveChanges();

        var readReceita = _mapper.Map<ReadReceitaDto>(receita);
        return readReceita;
    }

    public void DeleteReceita(Guid id)
    {
        var receita = _context.Receitas.First(r => r.Id == id);

        _context.Receitas.Remove(receita);
        _context.SaveChanges();
    }

    public List<ReadReceitaDto> GetAllReceitas()
    {
        var receitas = _context.Receitas.ToList();
        var readReceitas = _mapper.Map<List<ReadReceitaDto>>(receitas);

        return readReceitas;
    }
}
