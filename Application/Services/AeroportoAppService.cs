using Application.DTOs;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Services.InterfacesServicos;

namespace Application.Services;

public class AeroportoAppService : IAeroportoAppService
{
    private readonly IAeroportoService _aeroportoService;
    private readonly IMapper _mapper;

    public AeroportoAppService(IAeroportoService aeroportoService, IMapper mapper)
    {
        _aeroportoService = aeroportoService;
        _mapper = mapper;
    }

    public async Task Add(AeroportoDTO aeroportoDTO)
    {
        var aeroporto = _mapper.Map<Aeroporto>(aeroportoDTO);
        await _aeroportoService.Add(aeroporto);
    }

    public async Task Update(AeroportoDTO aeroportoDTO)
    {
        var aeroporto = _mapper.Map<Aeroporto>(aeroportoDTO);
        await _aeroportoService.Update(aeroporto);
    }

    public async Task Delete(AeroportoDTO aeroportoDTO)
    {
        var aeroporto = _mapper.Map<Aeroporto>(aeroportoDTO);
        await _aeroportoService.Delete(aeroporto);
    }

    public async Task<AeroportoDTO> GetEntityById(long id)
    {
        var aeroporto = await _aeroportoService.GetById(id);
        return _mapper.Map<AeroportoDTO>(aeroporto);
    }

    public async Task<List<AeroportoDTO>> List()
    {
        var aeroportos = await _aeroportoService.List();
        return _mapper.Map<List<AeroportoDTO>>(aeroportos);
    }

    public async Task<List<AeroportoDTO>> ListarAeroportosPorNome(string nome)
    {
        var aeroportos = await _aeroportoService.ListarAeroportoPorNome(nome);
        return _mapper.Map<List<AeroportoDTO>>(aeroportos);
    }

    public async Task<AeroportoDTO> GetAeroportoById(long id)
    {
        var aeroporto = await _aeroportoService.GetById(id);
        return _mapper.Map<AeroportoDTO>(aeroporto);
    }
}
