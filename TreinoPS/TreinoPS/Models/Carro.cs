using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreinoPS.Models
{
    public class Carro
    {
        public int CarroId { get; set; }
        public string  Modelo { get; set; }
        public string Placa { get; set; }
        public int Ano { get; set; }

        public bool Blindado { get; set; }

        public Porte Porte { get; set; }


        /*Um P Muitos*/
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }


    }
}
