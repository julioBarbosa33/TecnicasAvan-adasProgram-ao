using Microsoft.AspNetCore.Mvc;
using TimesCrud.Data;
using TimesCrud.Models;

namespace TimesCrud.Controllers
{
    public class JogadorController : Controller
    {
        readonly private ApplicationDbContext _db;
        
        public JogadorController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Jogador> jogadores = _db.Jogadores;
            return View(jogadores);
        }

        public IActionResult Cadastrar () 
        { 
            return View();
        }
        [HttpPost]

        public IActionResult Cadastrar(Jogador jogador)
        {
            if(ModelState.IsValid)
            {
                _db.Jogadores.Add(jogador);
                _db.SaveChanges();

                return RedirectToAction("Index");  
            }

            return View();
        }
        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Jogador jogador = _db.Jogadores.FirstOrDefault(x => x.Id == id);

            if (jogador == null)
            {
                return NotFound();
            }

            return View(jogador);
        }

        [HttpPost]
        public IActionResult Editar(Jogador jogador)
        {
            if (ModelState.IsValid)
            {
                _db.Jogadores.Update(jogador);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(jogador);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Jogador jogador = _db.Jogadores.FirstOrDefault(x => x.Id == id);

            if (jogador == null)
            {
                return NotFound();
            }

            return View(jogador);
        }

        [HttpPost]
        public IActionResult Excluir(Jogador jogador)
        {
            if (jogador == null)
            {
                return NotFound();
            }

            _db.Jogadores.Remove(jogador);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}