using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TreinoPS.Models;
using TreinoPS.Repositories;

namespace TreinoPS.Controllers
{
    public class CarroController : Controller
    {
        private ICarroRepository _carRepository;


        public CarroController(ICarroRepository carRepository)
        {
            _carRepository = carRepository;
        }


        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Cadastrar(Carro carro)
        {
            _carRepository.Criar(carro);
            _carRepository.Salvar();
            TempData["msg"] = "Cadastrado!!";
            return RedirectToAction("Listar");
        }

    }
}