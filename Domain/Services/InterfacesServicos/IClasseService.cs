﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.InterfacesServicos;

public interface IClasseService
{
    Task CriarClasse(Classe classe);
    Task AtualizarClasse(Classe classe);

}
