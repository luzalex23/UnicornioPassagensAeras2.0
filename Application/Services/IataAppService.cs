using Application.DTOs;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Services;
using Domain.Services.InterfacesServicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services;

public class IataAppService : IIataAppService
{
    private readonly IIataService _iataService;
    private readonly IMapper _mapper;

    public IataAppService(IIataService iataService, IMapper mapper)
    {
        _iataService = iataService ?? throw new ArgumentNullException(nameof(iataService));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }
    public async Task Add(IataDTO iataDTO)
    {
        try
        {
            var iata = _mapper.Map<Iata>(iataDTO);
            await _iataService.Add(iata);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao cadastrar IATA: {ex.Message}");
            throw;
        }
    }
    public async Task Delete(IataDTO iataDTO)
    {
        var iata = _mapper.Map<Iata>(iataDTO);
        await _iataService.Delete(iata);

    }

    public async Task<List<IataDTO>> GetIataIdByAeroporto(long iataId)
    {
        try
        {
            var iataList = await _iataService.GetById(iataId);

            var iataDTOList = _mapper.Map<List<IataDTO>>(iataList);

            return iataDTOList;
        }
        catch (Exception ex)
        {
   
            Console.WriteLine($"Erro ao obter IATA por Aeroporto: {ex.Message}");
            throw;
        }
    }

    public async Task<List<IataDTO>> List()
    {
        var iata = await _iataService.List();
        return _mapper.Map<List<IataDTO>>(iata);

    }

    public async Task Update(IataDTO iataDTO)
    {
        var iata = _mapper.Map<Iata>(iataDTO);
        await _iataService.Update(iata);
    }
}
