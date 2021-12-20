using AppLaercio.Models;
using AppLaercio.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;

namespace AppLaercio.Controllers
{
    [Route("Viagem")]
    public class ViagemController : Controller
    {
        [HttpGet]
        [Route("Gerenciar")]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();

            ViewData["viagens"] = dbcontext.Viagens.Where(p => p.Id > 0).ToList();
            return View();
        }

        [HttpPost]
        [Route("Gerenciar")]
        public IActionResult Index(Viagem viagens)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(viagens);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

       

        [HttpPost]
        [Route("Deletar")]
        public IActionResult Deletar(Viagem viagens)
        {
            var dbcontext = new Contexto();

            var viagemDelete = dbcontext.Viagens.Find(viagens.Id);
            dbcontext.Remove(viagemDelete);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
        
        [HttpPost]
        [Route("Atualizar")]
        public IActionResult Atualizar(Viagem novosDadosViagens)
        {
            var dbcontext = new Contexto();

            var antigosDadosViagens= dbcontext.Viagens.Find(novosDadosViagens.Id);

            antigosDadosViagens.Viajante = novosDadosViagens.Viajante;
            antigosDadosViagens.Destino = novosDadosViagens.Destino;
            antigosDadosViagens.TemGuia = novosDadosViagens.TemGuia;

            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
        
    }
}