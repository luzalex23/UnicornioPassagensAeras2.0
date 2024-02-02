﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.InterfacesServicos;

public interface IAutenticacaoGestorService
{
    Task<string> AutenticarGestor(string username, string password);
}
