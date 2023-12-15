using Controle_Financeiro.DTOs;
using Controle_Financeiro.Models;

namespace Controle_Financeiro.Interfaces;

public interface IReceitaRepository
{
    ReadReceitaDto AddNewReceita(Receita receita);
    void DeleteReceita(Guid id);
    List<ReadReceitaDto> GetAllReceitas();
}
