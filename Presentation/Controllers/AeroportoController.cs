using Application.DTOs;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

public class AeroportoController : Controller
{
    private readonly IAeroportoAppService _aeroportoAppService;
    private readonly IIataAppService _iataAppService;
    private readonly ICidadeAppService _cidadeAppService;

    public AeroportoController(IAeroportoAppService aeroportoAppService, IIataAppService iataAppService, ICidadeAppService cidadeAppService)
    {
        _aeroportoAppService = aeroportoAppService ?? throw new ArgumentNullException(nameof(aeroportoAppService));
        _iataAppService = iataAppService ?? throw new ArgumentNullException(nameof(iataAppService));
        _cidadeAppService = cidadeAppService ?? throw new ArgumentNullException(nameof(cidadeAppService));
    }
    public IActionResult Index()
    {
        return View();

    }

    public IActionResult Cadastrar()
    {
        ViewBag.Cidades = _cidadeAppService.List().Result.Select(c => new SelectListItem { Value = c.CidadeID.ToString(), Text = $"{c.Nome}, {c.UnidadeFederativa}" }).ToList();
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Cadastrar(AeroportoDTO aeroportoDTO, IataDTO iataDTO)
    {
        if (ModelState.IsValid)
        {
            try
            {
                await _aeroportoAppService.Add(aeroportoDTO);

                iataDTO.CodigoIATA = aeroportoDTO.CodigoIATA;
                await _iataAppService.Add(iataDTO);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Erro ao cadastrar Aeroporto: {ex.Message}");
            }
        }

        ViewBag.Cidades = _cidadeAppService.List().Result.Select(c => new SelectListItem { Value = c.CidadeID.ToString(), Text = $"{c.Nome}, {c.UnidadeFederativa}" }).ToList();
        return View(aeroportoDTO);
    }
}
