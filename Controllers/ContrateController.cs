using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Controllers;

namespace RoleTopem.Controllers
{
    public class ContrateController: AbstractController
    {
                public IActionResult Index()
        {
            
            return View();
            
        }
    
    }
}