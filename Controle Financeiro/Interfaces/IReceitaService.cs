using Controle_Financeiro.DTOs;

namespace Controle_Financeiro.Interfaces;

public interface IReceitaService
{
    ReadReceita CreateReceita(CreateReceita createReceita);
    ReadReceita GetReceitaById(Guid id);
}
