using Controle_Financeiro.Data;
using Controle_Financeiro.DTOs;
using Controle_Financeiro.Interfaces;
using Controle_Financeiro.Models;

namespace Controle_Financeiro.Services;

public class ReceitaService : IReceitaService
{
    private IReceitaRepository _repository;

    public ReceitaService(IReceitaRepository repository)
    {
        _repository = repository;
    }

    public ReadReceita CreateReceita(CreateReceita createReceita)
    {
        if (_repository.GetAllReceitas().Any(r => r.Descricao == createReceita.Descricao && r.Data.Year == createReceita.Data.Year && r.Data.Month == createReceita.Data.Month))
            throw new Exception("Receita com a mesma descrição já cadastrada neste mês.");

        ReadReceita readReceita = _repository.AddNewReceita(createReceita);

        return readReceita;
    }

    public List<ReadReceita> GetAllReceitas()
    {
        return _repository.GetAllReceitas().ToList();
    }

    public ReadReceita GetReceitaById(Guid id)
    {
        var readReceita = GetAllReceitas().FirstOrDefault(r => r.Id == id);

        return readReceita ?? throw new Exception("Id informado não existe.");
    }
}
