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
        [Required(ErrorMessage = "Nome Obrigatorio!!")]
        public string Nome { get; set; }

        [Required]
        
        public float Area { get; set; }

        [Display(Name ="Quantidade Maxíma")]
        [Range(1, 250)]
        public int QuantidadeMaxima { get; set; }


        public IList<Presidiario> Presidiarios { get; set; }
    }
}
