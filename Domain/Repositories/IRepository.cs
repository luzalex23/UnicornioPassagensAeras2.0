using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories;

public interface IRepository<T> where T : class
{
    Task Add(T objeto);
    Task Update(T objeto);
    Task Delete(T objeto);
    Task<T> GetEntityById(int id);
    Task<List<T>> List();
}
