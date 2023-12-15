using AutoMapper;
using Controle_Financeiro.DTOs;
using Controle_Financeiro.Models;

namespace Controle_Financeiro.Profiles;

public class ReceitaProfile : Profile
{
    public ReceitaProfile()
    {
        CreateMap<CreateReceitaDto, Receita>();
        CreateMap<Receita, ReadReceitaDto>()
            .ForMember(r => r.Data, opt => opt
            .MapFrom(r => r.Data.ToShortDateString()));
    }
}
