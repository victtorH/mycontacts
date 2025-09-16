using AspNetCoreGeneratedDocument;
using CreatedMVC.Models;
using CreatedMVC.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CreatedMVC.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;

        public ContatoController(IContatoRepositorio contatoRepositorio) 
        {
         _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatoRepositorio.ListarTodos();
            return View(contatos);
        }
        public IActionResult Created()
        {
            return View();
        }
        public IActionResult Update(int id)
        {
            var contato = _contatoRepositorio.BuscarPorId(id);
            return View(contato);
        }

        
        public IActionResult Deleted(int id)
        {
            var contato = _contatoRepositorio.BuscarPorId(id);
            return View(contato);
        }
       

        [HttpPost]
        [ActionName("Created")]
        public IActionResult Created(ContatoModel contato)
        {
            try
            {
                if (!ModelState.IsValid) return View(contato);

                TempData["MensagemSucesso"] = "Contato cadastrado com sucesso";

                _contatoRepositorio.Adicionar(contato);
                return RedirectToAction("Index");
                
            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Ops, Não foi possivel terminar a ação: {error.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ActionName("Update")]
        public IActionResult Update(ContatoModel contato)
        {

            if (!ModelState.IsValid) return View(contato);

            _contatoRepositorio.Atualizar(contato);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ActionName("Deleted")]
        public IActionResult Deleted(ContatoModel contato)
        {
            _contatoRepositorio.Deletar(contato);
            return RedirectToAction("Index");
        }

    }
}
