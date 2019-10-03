using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theRealMVC.Models;

namespace theRealMVC.ViewModels
{
    public class DetalheCelaViewModel
    {
        public IList<Presidiario> Presidiarios { get; set; }
        public Cela Cela { get; set; }

        public float Ocupacao{ get; set; }
    }
}
