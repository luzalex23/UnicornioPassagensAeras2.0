using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.InterfacesServicos;

public interface IServiceGeneric<T> where T : class
{
    Task<T>GetById(long id);
    Task<List<T>> List();
    Task Add(T objeto);
    Task Update(T objeto);
    Task Delete(T objeto);

}
