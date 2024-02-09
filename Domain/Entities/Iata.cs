using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Iata : BaseDomainEntity
{
    public Aeroporto Aeroporto { get; set; } = new Aeroporto();

}
