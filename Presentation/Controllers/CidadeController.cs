using Application.DTOs;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;
public class CidadeController : Controller
{
    private readonly ICidadeAppService _cidadeAppService;

    public CidadeController(ICidadeAppService cidadeAppService)
    {
        _cidadeAppService = cidadeAppService ?? throw new ArgumentNullException(nameof(cidadeAppService));
    }

    public async Task<IActionResult> Index()
    {
        var cidades = await _cidadeAppService.List();
        return View(cidades);
    }

    public IActionResult Cadastrar()
    {
        return View();
    }

  [HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Cadastrar(CidadeDTO cidadeDTO)
{
    if (ModelState.IsValid)
    {
        if (cidadeDTO.UnidadeFederativa == null)
        {
            ModelState.AddModelError(nameof(CidadeDTO.UnidadeFederativa), "A Unidade Federativa é obrigatória.");
            return View(cidadeDTO);
        }

        try
        {
            await _cidadeAppService.Add(cidadeDTO);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", $"Erro ao cadastrar Cidade: {ex.Message}");
        }
    }

    return View(cidadeDTO);
}

}
