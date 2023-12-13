using Controle_Financeiro.Data;
using Controle_Financeiro.DTOs;
using Controle_Financeiro.Interfaces;
using Controle_Financeiro.Models;

namespace Controle_Financeiro.Repository;

public class ReceitaRepository : IReceitaRepository
{
    private ControleFinanceiroContext _context;

    public ReceitaRepository(ControleFinanceiroContext context)
    {
        _context = context;
    }

    public ReadReceita AddNewReceita(CreateReceita createReceita)
    {
        var receita = new Receita { Data = createReceita.Data, Descricao = createReceita.Descricao, Valor = createReceita.Valor };
        _context.Receitas.Add(receita);
        _context.SaveChanges();

        var readReceita = new ReadReceita { Id = receita.Id, Data = receita.Data, Descricao = receita.Descricao, Valor = receita.Valor };
        return readReceita;
    }

    public List<ReadReceita> GetAllReceitas()
    {
        var receitas = _context.Receitas.ToList();
        var readReceitas = new List<ReadReceita>();

        foreach (var receita in receitas)
        {
            readReceitas.Add(new ReadReceita { Id = receita.Id, Data = receita.Data, Descricao = receita.Descricao, Valor = receita.Valor });
        }

        return readReceitas;
    }
}
