﻿using Domain.Entities;
using Domain.Repositories;
using Domain.Services.InterfacesServicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services;

public class ClasseService : IClasseService
{
    private readonly IClasseRepository _classeRepository;
    public ClasseService(IClasseRepository classeRepository)
    {
        _classeRepository = classeRepository;
    }
    public async Task AtualizarClasse(Classe classe)
    {
        await _classeRepository.Update(classe);
    }

    public async Task CriarClasse(Classe classe)
    {
        await _classeRepository.Add(classe);
    }
}
