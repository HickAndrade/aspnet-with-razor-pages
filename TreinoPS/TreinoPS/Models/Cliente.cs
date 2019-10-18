using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreinoPS.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public IList<Carro> Carros { get; set; }


    }
}
