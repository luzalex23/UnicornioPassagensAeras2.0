using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.InterfacesServicos;

public interface IServiceGeneric<T> where T : class
{
    Task<T>GetById(int id);
    Task<T> GetByIdAsync(int id);
    Task<List<T>> List();

}
