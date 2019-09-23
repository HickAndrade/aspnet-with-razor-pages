using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_AulaPerdida.Models;
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
        public IActionResult Pesquisar(string termoPesquisa) {

            var lista = _context.Corridas.Where(c => c.Nome.Contains(termoPesquisa)).
                Include(c => c.Trajeto).ToList();

            return View("listar", lista);
        }

        [HttpGet]
        public IActionResult Listar() {
            return View(_context.Corridas.Include(c=> c.Trajeto).ToList());
        }

        [HttpGet]
        public IActionResult Cadastrar() {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Corrida corrida)
        {
            _context.Corridas.Add(corrida);
            _context.SaveChanges();
            TempData["mensagem"] = "Cadastrado!!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int id) {

            return View(_context.Corridas.Find(id));

        }

        [HttpPost]
        public IActionResult Editar(Corrida corrida)
        {
            _context.Corridas.Update(corrida);
            _context.SaveChanges();
            TempData["mensagem"] = "Editado!!";
            return RedirectToAction("Listar");

        }
            [HttpPost]
        public IActionResult Deletar(int caralho)
        {
            var corrida = _context.Corridas.Find(caralho);
            _context.Corridas.Remove(corrida);
            _context.SaveChanges();
            TempData["mensagem"] = "Deletado!!";
            return RedirectToAction("Listar");
        }








    }
}