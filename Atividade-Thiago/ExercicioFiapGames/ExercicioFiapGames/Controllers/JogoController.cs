using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExercicioFiapGames.Models;
using ExercicioFiapGames.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExercicioFiapGames.Controllers
{
    public class JogoController : Controller
    {

        private IJogoRepository _repository;



        public JogoController(IJogoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Jogo jogo)
        {
            _repository.Criar(jogo);
            _repository.Salvar();
            TempData["mensagem"] = "Cadastrado!!";
            return View("Cadastrar");
        }


        [HttpGet]
        public IActionResult Listar() {

            return View(_repository.Listar());
        }







    }
}