using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using theRealMVC.Models;
using theRealMVC.Repositories;
using theRealMVC.ViewModels;

namespace theRealMVC.Controllers
{
    public class CelaController : Controller
    {
        private ICelaRepository _celaRepository;
        private IPresidiarioRepository _preRepository;

        public CelaController(ICelaRepository celaRepository,IPresidiarioRepository preRepository)
        {
            _preRepository = preRepository;
            _celaRepository = celaRepository;
        }


        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Cadastrar(Cela cela)
        {
            if (ModelState.IsValid)
            {
                _celaRepository.Criar(cela);
                _celaRepository.Save();
                TempData["mensagem"] = "Cadastrado!!";
                return RedirectToAction("Listar");
            }
            else
            {
                return View();
            }
        }


        [HttpGet]
        public IActionResult Listar() {
            var lista = _preRepository.Listar();

            return View(_celaRepository.Listar());
        }


        [HttpGet]
        public IActionResult Detalhar(int codigo) {
            var presidiarios = _preRepository.FindBy(p => p.CelaId == codigo);

            var cela = _celaRepository.findById(codigo);

            /*O ocupação está tirando a porcentagem de pessoas que estão dentro da cela, pegando o tanto de presidiarios e relacionando
             * com a quantidade maxima da cela */
            /*Aqui eu peguei a model que faz a junção das outras duas e referencio elas aos objetos criados dentro dessa action*/
            var juntar = new DetalheCelaViewModel()
            {
                Presidiarios = presidiarios,
                Cela = cela,
                Ocupacao = ((float)presidiarios.Count/(float)cela.QuantidadeMaxima)*100

            };
            return View(juntar);
        }

        [HttpPost]
        public IActionResult SaidaTemp(int codigo)
        {
            var presidiario = _preRepository.findById(codigo);

            presidiario.saidaTemporaria = !presidiario.saidaTemporaria;
            _preRepository.Atualizar(presidiario);
            _preRepository.Salvar();


            return RedirectToAction("Detalhar", new { codigo = presidiario.CelaId });
        }


    }
}