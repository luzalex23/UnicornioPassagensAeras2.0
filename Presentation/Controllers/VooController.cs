using Domain.Entities;
using Domain.Services.InterfacesServicos;
using Microsoft.AspNetCore.Mvc;
using Presentation.ViewModel;

namespace Presentation.Controllers;

public class VooController : Controller
{
    private readonly IVooService _vooService;
    private readonly ICidadeService _cidadeService;

    public VooController(IVooService vooService, ICidadeService cidadeService)
    {
        _vooService = vooService;
        _cidadeService = cidadeService;
    }

  

    public async Task<IActionResult> Index()
    {
      /*  var voos = await _vooAppService.List();
        var voosViewModel = _mapper.Map<List<VooViewModel>>(voos);*/
        return View();
    }

    [HttpGet]
    public IActionResult Cadastrar()
    {
        ViewBag.Cidades = _cidadeService.List().Result;
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(Voo voo)
    {
        _vooService.CriarVoo(voo);
        return RedirectToAction("Index");
    }

    // Alterar Preços das Passagens
    [HttpGet]
    public IActionResult AlterarPrecos(int id)
    {
        var voo = _vooService.GetById(id).Result;
        ViewBag.Cidades = _cidadeService.List().Result;
        return View(voo);
    }

    [HttpPost]
    public IActionResult AlterarPrecos(Voo voo)
    {
        _vooService.AtualizarVoo(voo);
        return RedirectToAction("Index");
    }

}
