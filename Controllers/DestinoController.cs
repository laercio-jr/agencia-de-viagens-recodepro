using AppLaercio.Models;
using AppLaercio.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLaercio.Controllers
{

    [Route("Destinos")]
    public class DestinoController : Controller
    {
        [HttpGet]
        [Route("Cadastrar")]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();

            ViewData["viagens"] = dbcontext.Viagens.Where(p => p.Id > 0).ToList();
            return View();
        }

        [HttpPost]
        [Route("Cadastrar")]
        public IActionResult Index(Viagem viagens)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(viagens);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
