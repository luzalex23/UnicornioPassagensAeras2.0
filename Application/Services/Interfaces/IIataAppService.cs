using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces;

public interface IIataAppService : IGenericAppService<IataDTO>
{
    Task<List<IataDTO>> GetIataIdByAeroporto(long iataId);

}
