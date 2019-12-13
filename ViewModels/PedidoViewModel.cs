using System.Collections.Generic;
using RoleTopem.Models;
using RoleTopMVC.ViewModels;

namespace RoleTopem.ViewModels
{
         public class PedidoViewModel : BaseViewModel
    {
        public List<Evento> Eventos {get;set;}
        public string NomeUsuario {get;set;}
        public Cliente Cliente {get;set;}

        public PedidoViewModel()
        {
            this.Eventos = new List<Evento>();
            this.NomeUsuario = "Jovem";
            this.Cliente = new Cliente();
        }
    }
}