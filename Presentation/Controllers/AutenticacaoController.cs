using Domain.Services.InterfacesServicos;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models;

namespace Presentation.Controllers;
public class AutenticacaoController : Controller
{
    [HttpGet]
    public ActionResult Login()
    {
        return View();
    }
    private readonly IAutenticacaoGestorService _autenticacaoGestorService;

    public AutenticacaoController(IAutenticacaoGestorService autenticacaoGestorService)
    {
        _autenticacaoGestorService = autenticacaoGestorService;
    }

    [HttpPost]
    public async Task<ActionResult<string>> Login([FromBody] LoginModel model)
    {
        var token = await _autenticacaoGestorService.AutenticarGestor(model.Username, model.Password);

        if (token != null)
        {
            return RedirectToAction("Index", "Dashboard");
        }
        return Unauthorized(new { Message = "Credenciais inválidas." });
    }

}
