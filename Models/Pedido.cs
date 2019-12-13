using System;
using RoleTopem.Enums;

namespace RoleTopem.Models
{
    public class Pedido
    {
    
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}
        public Evento Evento {get;set;}

        public DateTime DataDoPedido {get;set;}

        public uint Status {get;set;}

        public Pedido()
        {
            this.Cliente = new Cliente();
            this.Evento = new Evento();
            this.Id = 0;
            this.Status = (uint) StatusPedido.PENDENTE; 
        }
    }
}