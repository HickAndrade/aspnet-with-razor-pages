using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _01_AulaPerdida.Models
{
    public class Trajeto
{
    public int TrajetoId { get; set; }
    public float Distancia { get; set; }

    [Display(Name = "Data de inicio")]
    public string LocalInicio { get; set; }

}
}
