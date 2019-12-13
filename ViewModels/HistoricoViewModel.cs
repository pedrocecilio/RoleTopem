using System.Collections.Generic;
using RoleTopem.Models;
using RoleTopMVC.ViewModels;

namespace RoleTopem.ViewModels
{
    public class HistoricoViewModel : BaseViewModel
    {
        public List<Pedido> Pedidos {get;set;}
    }
}