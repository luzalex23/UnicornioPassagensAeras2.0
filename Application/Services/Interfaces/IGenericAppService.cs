using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces;

public interface IGenericAppService<T> where T : class
{
    Task Add(T objeto);
    Task Update(T objeto);
    Task Delete(T objeto);
    Task<T> GetEntityById(int Id);
    Task<List<T>> List();
}
