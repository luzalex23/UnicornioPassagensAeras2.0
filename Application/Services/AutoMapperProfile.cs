using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Services;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Aeroporto, AeroportoDTO>().ReverseMap();
        CreateMap<Iata, IataDTO>().ReverseMap();
        CreateMap<Cidade, CidadeDTO>()
            .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.UnidadeFederativa, opt => opt.MapFrom(src => src.UF)).ReverseMap();
    }
}
