using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace theRealMVC.Models
{
    public class Presidiario
    {
        public int PresidiarioId { get; set; }
        public string Nome { get; set; }
        public DateTime dataEntrada { get; set; }
        public DateTime dataSaida { get; set; }

        public NivelEscolaridade nivelEscolaridade { get; set; }
        public bool saidaTemporaria { get; set; }

        public Cela Cela { get; set; }
        public int CelaId { get; set; }
    }
}
