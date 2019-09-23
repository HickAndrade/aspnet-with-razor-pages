using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_AulaPerdida.Models;
using _01_AulaPerdida.Persistences;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace _01_AulaPerdida.Controllers
{
    public class MedalhaController : Controller
    {
        private RacerContext _context;

        public MedalhaController(RacerContext context)
        {
            _context = context;
        }

        public IActionResult Listar(int corridaBusca) {

            CarregarListaMedalhas();
            return View(_context.Medalhas.Include(m => m.Corrida).
                Where(m => m.CorridaId == corridaBusca ||
            corridaBusca == 0
            ).ToList());
        }



        private void CarregarListaMedalhas() {

            var lista = _context.Corridas.ToList();
            ViewBag.corridas = new SelectList(lista,"CorridaId","Nome");

        }


        [HttpGet]
        public IActionResult Cadastrar()
        {
            CarregarListaMedalhas();
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Medalha medalha) {

            _context.Medalhas.Add(medalha);
            _context.SaveChanges();
            TempData["mensagem"] = "Cadastrado";

            return RedirectToAction("Listar");
        }



    }
}