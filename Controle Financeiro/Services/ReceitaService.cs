using AutoMapper;
using Controle_Financeiro.Data;
using Controle_Financeiro.DTOs;
using Controle_Financeiro.Interfaces;
using Controle_Financeiro.Models;

namespace Controle_Financeiro.Services;

public class ReceitaService : IReceitaService
{
    private IReceitaRepository _repository;
    private IMapper _mapper;

    public ReceitaService(IReceitaRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public ReadReceitaDto CreateReceita(CreateReceitaDto createReceita)
    {
        if (_repository.GetAllReceitas().Any(r => r.Descricao == createReceita.Descricao && r.Data.Split('/')[2] == createReceita.Data.Year.ToString() && r.Data.Split('/')[1] == createReceita.Data.ToString().Split('/')[1]))
            throw new Exception("Receita com a mesma descrição já cadastrada neste mês.");

        var receita = _mapper.Map<Receita>(createReceita);

        var readReceita = _repository.AddNewReceita(receita);

        return readReceita;
    }

    public void DeleteReceitaById(Guid id)
    {
        GetReceitaById(id);

        _repository.DeleteReceita(id);
    }

    public List<ReadReceitaDto> GetAllReceitas()
    {
        return _repository.GetAllReceitas();
    }

    public ReadReceitaDto GetReceitaById(Guid id)
    {
        var readReceita = GetAllReceitas().FirstOrDefault(r => r.Id == id);

        return readReceita ?? throw new Exception("Id informado não existe.");
    }
}
