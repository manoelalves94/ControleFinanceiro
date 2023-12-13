using Controle_Financeiro.DTOs;
using Controle_Financeiro.Models;

namespace Controle_Financeiro.Interfaces;

public interface IReceitaRepository
{
    ReadReceita AddNewReceita(CreateReceita createReceita);
    List<ReadReceita> GetAllReceitas();
}
