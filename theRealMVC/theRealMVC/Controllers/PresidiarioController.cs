using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using theRealMVC.Models;
using theRealMVC.Repositories;

namespace theRealMVC.Controllers
{
    public class PresidiarioController : Controller
    {
        private IPresidiarioRepository _PreRepository;
        private ICelaRepository _celaRepository;


        public PresidiarioController(IPresidiarioRepository presidiarioRepository, ICelaRepository celaRepository)
        {
            _celaRepository = celaRepository;
            _PreRepository = presidiarioRepository;
        }



        [HttpGet]
        public IActionResult Cadastrar(int codigo)
        {
            /*Fazemos toda essa parte de configuração para relacionar um presidiario a uma cela existente*/
            var lista = _celaRepository.Listar();
            ViewBag.celas = new SelectList(lista, "CelaId", "Nome");

            return View(new Presidiario() { CelaId = codigo});
        }

        [HttpPost]
        public IActionResult Cadastrar(Presidiario presidiario)
        {
            
            _PreRepository.Criar(presidiario);
            _PreRepository.Salvar();
            TempData["mensagem"] = "Cadastrado!!";

            return RedirectToAction("Listar", "Cela");
        }

        

    }
}
