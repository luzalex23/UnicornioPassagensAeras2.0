using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public class BaseDomainEntity
{
    public long Id { get; set; }  
    public string Name { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; }
}
