using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs;

public class AeroportoDTO
{
    public long AeroportoID { get; set; }
    public string Nome { get; set; }
    public string CodigoIATA { get; set; }
    public long CidadeID { get; set; }
    public long IataID { get; set; }

}
