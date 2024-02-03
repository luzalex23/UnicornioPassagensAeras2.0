using Domain.Entities;
using Domain.Services;
using Domain.Services.InterfacesServicos;
using Microsoft.AspNetCore.Mvc;
using Presentation.ViewModel;

namespace Presentation.Controllers;

public class PassagemController : Controller
{
    private readonly IPassagemService _passagemService;
    private readonly IVooService _vooService;
    private readonly IClasseService _classeService;
    public PassagemController(IPassagemService passagemService, IVooService vooService, IClasseService classeService)
    {
        _passagemService = passagemService;
        _vooService = vooService;
        _classeService = classeService;
    }
    public IActionResult Index()
    {
        var passagens = _passagemService.List();
        return View(passagens);
    }
    public IActionResult ComprarPassagem()
    {
        var voos = _vooService.ListarVoosDisponiveis("Origem", "Destino", DateTime.Now, null);
        var classe = _classeService.List();

        var compra = new Compra()
        {
            Voo = voos,
            //Classe = classe
        };

        return View(compra);
    }

    /*[HttpPost]
    public IActionResult ComprarPassagem(Compra compra)
    {
        if (ModelState.IsValid)
        {
            var passagensCompradas = _passagemService.CriarPassagem(
                compra.Voo,
                compra.
            );

            if (passagensCompradas.Any())
            {
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Erro ao comprar passagens.");
            }
        }
    }*/
}
