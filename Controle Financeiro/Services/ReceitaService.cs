using Controle_Financeiro.DTOs;
using Controle_Financeiro.Interfaces;

namespace Controle_Financeiro.Services;

public class ReceitaService : IReceitaService
{
    public ReadReceita CreateReceita(CreateReceita createReceita)
    {
        var readReceita = new ReadReceita
        {
            Id = Guid.NewGuid(),
            Descricao = createReceita.Descricao,
            Valor = createReceita.Valor,
            Data = createReceita.Data
        };

        return readReceita;
    }

    public ReadReceita GetReceitaById(Guid id)
    {
        throw new NotImplementedException();
    }
}
