using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_AulaPerdida.Persistences;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _01_AulaPerdida.Controllers
{
    public class CorridaController : Controller
    {
        private RacerContext _context;


        public CorridaController(RacerContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IActionResult Listar() {
            return View(_context.Corridas.Include(c => c.Trajeto).ToList());

        }

        //Pesquisar por nome, podendo pesquisar o trajeto também (Eu acho)
        [HttpGet]
        public IActionResult Pesquisar(string termoPesquisa) {
            var lista = _context.Corridas
                     .Where(c => c.Nome.Contains(termoPesquisa))
                     .Include(c => c.Trajeto).ToList();

            return View();
        }








    }
}