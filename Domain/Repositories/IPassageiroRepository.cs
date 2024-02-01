using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories;

public interface IPassageiroRepository : IRepository<Passageiro>
{
    Task<Passageiro> GetPassageiroByCPF(string cpf);
    Task<Passageiro> GetPassageiroByName(string nome);
    Task<Passageiro> GetPassageiroByIdade(int idade);


}
