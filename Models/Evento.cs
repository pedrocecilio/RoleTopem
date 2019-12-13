using System;

namespace RoleTopem.Models
{
    public class Evento
    {
        public string NomeEvento {get;set;}
        public string TipoEvento {get;set;}
        public DateTime Inicio {get;set;}
        public DateTime Termino{get;set;}

        public DateTime DataDoPedido {get;set;}

        public Evento()
        {

        }


        public Evento(string NomeEvento, string TipoEvento, DateTime Inicio, DateTime Termino)
        {
            this.NomeEvento = NomeEvento;
            this.TipoEvento = TipoEvento;
            this.Inicio = Inicio;
            this.Termino = Termino;
        }
    }
}