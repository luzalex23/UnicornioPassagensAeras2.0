using AutoMapper;
using Domain.Entities;
using Presentation.ViewModel;

namespace Presentation.MappingProfiles;

public class AeroportoProfile : Profile
{
    public AeroportoProfile()
    {
        CreateMap<Aeroporto, AeroportoViewModel>()
            .ForMember(dest => dest.NomeCidade, opt => opt.MapFrom(src => src.Cidade.Name));

        CreateMap<AeroportoViewModel, Aeroporto>()
            .ForMember(dest => dest.Cidade, opt => opt.MapFrom(src => new Cidade { Name = src.NomeCidade }));

    }
}
