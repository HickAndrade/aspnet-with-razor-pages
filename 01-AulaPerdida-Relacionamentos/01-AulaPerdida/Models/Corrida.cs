using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_AulaPerdida.Models
{
    public class Corrida
{

        [HiddenInput]
        public int CorridaId { get; set; }
        public int Nome { get; set; }

        public float Distancia { get; set; }

        public bool Premiacao { get; set; }

        public Categoria Categoria{ get; set; }


        public IList<CorridaAtleta> CorridaAtletas { get; set; }
    }
}
