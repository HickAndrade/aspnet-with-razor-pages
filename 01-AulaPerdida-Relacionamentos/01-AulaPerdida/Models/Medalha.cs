using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_AulaPerdida.Models
{
    public class Medalha
{
    public int MedalhaId { get; set; }
    public CategoriaMedalha Categoria { get; set; }

    public float Peso { get; set; }

    public int Quantidade { get; set; }
}
}
