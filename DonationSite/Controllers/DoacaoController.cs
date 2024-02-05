using Donation.Data;
using Donation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Donation.Controllers
{
    public class DoacaoController : Controller
    {
        readonly private AplicationDBContext _db;
        public DoacaoController(AplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<DoacaoModel> doacoes = _db.Doacoes;
            return View(doacoes);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Adquirir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            DoacaoModel doacao = _db.Doacoes.FirstOrDefault(x => x.id == id);

            if (doacao == null)
            {
                return NotFound();
            }
            return View(doacao);
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            DoacaoModel doacao = _db.Doacoes.FirstOrDefault(x => x.id == id);

            if (doacao == null)
            {
                return NotFound();
            }
            return View(doacao);
        }

  

        [HttpPost]
        public IActionResult Cadastrar(DoacaoModel doacoes)
        {
            if (ModelState.IsValid)
            {
                _db.Doacoes.Add(doacoes);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Editar(DoacaoModel doacao)
        {
            if (ModelState.IsValid)
            {
                _db.Doacoes.Update(doacao);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Adquirir(DoacaoModel doacao)
        {
            if (ModelState.IsValid)
            {
                doacao.ativo = false;
                _db.Doacoes.Update(doacao);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        
    }
}
