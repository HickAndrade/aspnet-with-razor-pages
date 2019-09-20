using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_AulaPerdida.Models
{
    public class Atleta
{
    public int AtletaId { get; set; }
    public string Nome { get; set; }

    public DateTime DataNascimento { get; set; }

    public bool Profissional { get; set; }

    public IList<CorridaAtleta>  CorridaAtletas { get; set; }

    }
}
