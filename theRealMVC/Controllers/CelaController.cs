using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using theRealMVC.Models;
using theRealMVC.Repositories;
using theRealMVC.ViewModels;

namespace theRealMVC.Controllers
{
    /**Fiz uma controller nova para tentar colocar o presidiario dentro da cela e aumentar a quantidade de presidiarios fazendo uma
     controller e chamando a ViewModel para pegar informações da outra model */


    public class CelaController : Controller
    {
        private ICelaRepository _celaRepository;
        private IPresidiarioRepository _preRepository;

        public CelaController(ICelaRepository celaRepository, IPresidiarioRepository preRepository)
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
            _celaRepository.Criar(cela);
            _celaRepository.Save();
            TempData["mensagem"] = "Cadastrado!!";

            return RedirectToAction("Listar");
        }


        [HttpGet]
        public IActionResult Listar()
        {
            var lista = _preRepository.Listar();

            return View(_celaRepository.Listar());
        }


        [HttpGet]
        public IActionResult Detalhar(int codigo)
        {
            var presidiarios = _preRepository.FindBy(p => p.CelaId == codigo);

            var cela = _celaRepository.findById(codigo);

            /*O ocupação está tirando a porcentagem de pessoas que estão dentro da cela, pegando o tanto de presidiarios e relacionando
             * com a quantidade maxima da cela */
            /*Aqui eu peguei a model que faz a junção das outras duas e referencio elas aos objetos criados dentro dessa action*/
            var juntar = new DetalheCelaViewModel()
            {
                Presidiarios = presidiarios,
                Cela = cela,
                Ocupacao = ((float)presidiarios.Count / (float)cela.QuantidadeMaxima) * 100

            };
            return View(juntar);
        }
    
    [HttpGet]
    public IActionResult CadastrarP(int codigo, Presidiario presidiario)
    {
            var cela = _celaRepository.findById(codigo);

        var juntar = new DetalheCelaViewModel()
        {
            Cela = cela
        };

        return View(juntar);
    }

    [HttpPost]
    public IActionResult CadastrarP(int codigo, Cela cela, Presidiario pre)
    {
        
            _preRepository.Criar(pre);
       _celaRepository.Atualizar(cela);
        _preRepository.Salvar();
            _celaRepository.Save();
        TempData["mensagem"] = "Cadastrado";
        return RedirectToAction("Listar");
    }
}
}
