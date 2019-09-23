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
        public string Nome { get; set; }

        public float Distancia { get; set; }

        public bool Premiacao { get; set; }

        public Categoria Categoria{ get; set; }



        //Relacionamentos

        //um-para-muitos
        public IList<Medalha> Medalhas { get; set; }

        //um-para-um
        public int TrajetoId { get; set; }
        public Trajeto Trajeto { get; set; }

        //muitos-para-muitos
        public IList<CorridaAtleta> CorridaAtletas { get; set; }





    }
}
