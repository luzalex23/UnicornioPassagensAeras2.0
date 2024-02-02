﻿using Domain.Entities;
using Domain.Repositories;
using Domain.Services.InterfacesServicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services;

public class AeroportoService : IAeroportoService
{
    private readonly IAeroportoRepository _aeroportoRepository;
    public AeroportoService(IAeroportoRepository aeroportoRepository)
    {
        _aeroportoRepository = aeroportoRepository;
    }

    public async Task AtualizarAeroporto(Aeroporto aeroporto)
    {
        await _aeroportoRepository.Update(aeroporto);

    }

    public async Task CriarAeroporto(Aeroporto aeroporto)
    {
        var existingAeroporto = _aeroportoRepository.GetAeroportoByCodigoIATA(aeroporto.CodigoIATA);
        if (existingAeroporto != null)
        {
            throw new InvalidOperationException("Aeroporto com o mesmo CodigoIATA já existe.");
        }

        await _aeroportoRepository.Add(aeroporto);
    }

    public async Task<Aeroporto> GetAeroportoByCodigoIATA(string codigoIATA)
    {
        return await _aeroportoRepository.GetAeroportoByCodigoIATA(codigoIATA);
    }

    public async Task<List<Aeroporto>> ListarAeroportoPorNome(string nome)
    {
        return await _aeroportoRepository.ListarAeroportoPorNome(nome);
    }
}
