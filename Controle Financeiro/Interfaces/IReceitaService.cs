using Controle_Financeiro.DTOs;

namespace Controle_Financeiro.Interfaces;

public interface IReceitaService
{
    ReadReceitaDto CreateReceita(CreateReceitaDto createReceita);
    void DeleteReceitaById(Guid id);
    List<ReadReceitaDto> GetAllReceitas();
    ReadReceitaDto GetReceitaById(Guid id);
}
