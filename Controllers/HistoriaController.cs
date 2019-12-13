using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Controllers;
using RoleTopMVC.ViewModels;

namespace RoleTopem.Controllers
{
    public class HistoriaController : AbstractController
    {
                public IActionResult Index()
        {
            
            return View(new BaseViewModel()
            {
                NomeView = "Historia",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
                
            });
        }
    }
}
