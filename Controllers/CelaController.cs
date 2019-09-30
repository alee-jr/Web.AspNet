using System;
using System.Linq;
using _07_Fiap.WebAspNEt.Banco;
using _07_Fiap.WebAspNEt.Models;
using Microsoft.AspNetCore.Mvc;

namespace _07_Fiap.WebAspNEt.Controllers
{
    public class CelaController : Controller
    {
        private BanguContext _context;
        public CelaController(BanguContext context)
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
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Cela cela)
        {
            _context.Celas.Add(cela);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado";
            return RedirectToAction("Listar");
        }
        [HttpGet]
        public IActionResult Listar()
        {
            return View(_context.Celas.ToList());
        }
        [HttpGet]
        public IActionResult detalhesCela(int id)
        {
            Cela cela = _context.Celas.Find(id);
            decimal atual = _context.Presidiarios.Where(p => p.CelaId == id).Count();
            decimal porcentagem = Math.Round(Convert.ToDecimal(atual / cela.QuantidadeMaxima * 100),1);
            ViewBag.atual = atual;
            ViewBag.porcentagem = porcentagem;
            return View(cela);
        }
    }
}