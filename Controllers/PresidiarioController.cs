using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _07_Fiap.WebAspNEt.Banco;
using _07_Fiap.WebAspNEt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace _07_Fiap.WebAspNEt.Controllers
{
    public class PresidiarioController : Controller
    {
        private BanguContext _context;
        public PresidiarioController(BanguContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Cadastrar()
        {
            ViewBag.celas = new SelectList(_context.Celas.ToList(), "CelaId", "Nome");
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Presidiario presidiario)
        {
            _context.Presidiarios.Add(presidiario);
            _context.SaveChanges();
            TempData["msg"] = "Castrado";
            return RedirectToAction("Cadastrar");
        }
    }
}