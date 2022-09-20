using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace theRealMVC.Models
{
    public class Cela
    {
        public int CelaId { get; set; }
        public string Nome { get; set; }
        public float Area { get; set; }

        [Display(Name ="Quantidade Maxíma")]
        public int QuantidadeMaxima { get; set; }


        public IList<Presidiario> Presidiarios { get; set; }
    }
}
