using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application.Services.Interfaces;
using Domain.Entities;
using AutoMapper;
using Presentation.ViewModel;

public class AeroportoController : Controller
{
    private readonly IAeroportoAppService _aeroportoAppService;
    private readonly IMapper _mapper;

    public AeroportoController(IAeroportoAppService aeroportoAppService, IMapper mapper)
    {
        _aeroportoAppService = aeroportoAppService;
        _mapper = mapper;
    }
    public ActionResult Index()
    {
        return View();
    }
   /* public async Task<IActionResult> Index()
    {
        var aeroportos = await _aeroportoAppService.List();
        return View(aeroportos);
    }*/

    public IActionResult Criar()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Criar([Bind("CodigoIATA, Nome, NomeCidade")] AeroportoViewModel aeroportoViewModel)
    {
        if (ModelState.IsValid)
        {
            var aeroporto = _mapper.Map<Aeroporto>(aeroportoViewModel);

            await _aeroportoAppService.CriarAeroporto(aeroporto);

            return RedirectToAction(nameof(Index));
        }

        return View(aeroportoViewModel);
    }


    private AeroportoViewModel MapToAeroportoViewModel(Aeroporto aeroporto)
    {
        return new AeroportoViewModel
        {
            Id = aeroporto.Id,
            CodigoIATA = aeroporto.CodigoIATA,
            Nome = aeroporto.Name,
            NomeCidade = aeroporto.Cidade?.Name
        };
    }

    public async Task<IActionResult> Detalhes(long id)
    {
        var aeroporto = await _aeroportoAppService.GetEntityById((int)id);
        if (aeroporto == null)
        {
            return NotFound();
        }

        return View(aeroporto);
    }

    public async Task<IActionResult> Editar(long id)
    {
        var aeroporto = await _aeroportoAppService.GetEntityById((int)id);
        if (aeroporto == null)
        {
            return NotFound();
        }

        var aeroportoViewModel = _mapper.Map<AeroportoViewModel>(aeroporto);
        return View(aeroportoViewModel);
    }


    [HttpPost]
    public async Task<IActionResult> Editar(long id, AeroportoViewModel aeroportoViewModel)
    {
        if (id != aeroportoViewModel.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                var aeroporto = _mapper.Map<Aeroporto>(aeroportoViewModel);

                await _aeroportoAppService.Update(aeroporto);
            }
            catch
            {
                return View(aeroportoViewModel);
            }

            return RedirectToAction(nameof(Index));
        }

        return View(aeroportoViewModel);
    }

    public async Task<IActionResult> Excluir(long id)
    {
        var aeroporto = await _aeroportoAppService.GetEntityById((int)id);
        if (aeroporto == null)
        {
            return NotFound();
        }

        return View(aeroporto);
    }

    [HttpPost, ActionName("Excluir")]
    public async Task<IActionResult> ConfirmarExclusao(long id)
    {
        var aeroporto = await _aeroportoAppService.GetEntityById((int)id);

        await _aeroportoAppService.Delete(aeroporto);

        return RedirectToAction(nameof(Index));
    }

}
