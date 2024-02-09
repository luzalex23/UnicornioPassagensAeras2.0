using Application.DTOs;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Services.InterfacesServicos;

namespace Application.Services;
public class CidadeAppService : ICidadeAppService
{
    private readonly ICidadeService _cidadeService;
    private readonly IMapper _mapper;

    public CidadeAppService(ICidadeService cidadeService, IMapper mapper)
    {
        _cidadeService = cidadeService;
        _mapper = mapper;
    }

    public async Task Update(CidadeDTO cidadeDTO)
    {
        var cidade = _mapper.Map<Cidade>(cidadeDTO);
        await _cidadeService.Update(cidade);
    }

    public async Task Delete(CidadeDTO cidadeDTO)
    {
        var cidade = _mapper.Map<Cidade>(cidadeDTO);
        await _cidadeService.Delete(cidade);
    }

    public async Task<CidadeDTO> GetEntityById(int id)
    {
        var cidade = await _cidadeService.GetById(id);
        return _mapper.Map<CidadeDTO>(cidade);
    }

    public async Task<List<CidadeDTO>> List()
    {
        var cidades = await _cidadeService.List();
        return _mapper.Map<List<CidadeDTO>>(cidades);
    }
    public async Task Add(CidadeDTO cidadeDTO)
    {
        var cidade = _mapper.Map<Cidade>(cidadeDTO);
        await _cidadeService.Add(cidade);
    }
}
