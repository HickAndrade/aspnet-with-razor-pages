using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using theRealMVC.Repositories;

namespace theRealMVC.Controllers
{
    public class PresidiarioController : Controller
    {
        private IPresidiarioRepository _PreRepository;



        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}