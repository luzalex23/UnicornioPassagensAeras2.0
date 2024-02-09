using Application.DTOs;
using Domain.Entities;

namespace Application.Services.Interfaces;

public interface IAeroportoAppService : IGenericAppService<AeroportoDTO>
{
    Task<List<AeroportoDTO>> ListarAeroportosPorNome(string nome);
    Task<AeroportoDTO> GetAeroportoById(long id);
   // Task<List<AeroportoDTO>> GetAeroportosByCidade(string nomeCidade);
}

