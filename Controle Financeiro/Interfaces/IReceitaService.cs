using Controle_Financeiro.DTOs;

namespace Controle_Financeiro.Interfaces;

public interface IReceitaService
{
    ReadReceita CreateReceita(CreateReceita createReceita);
    List<ReadReceita> GetAllReceitas();
    ReadReceita GetReceitaById(Guid id);
}
