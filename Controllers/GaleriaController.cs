using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Controllers;
using RoleTopMVC.ViewModels;

namespace RoleTopem.Controllers
{
    public class GaleriaController : AbstractController
    {
                public IActionResult Index()
        {
            
            return View();
            
        }

    }
}