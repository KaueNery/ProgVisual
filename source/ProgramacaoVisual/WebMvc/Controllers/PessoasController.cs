using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;

namespace ProgramacaoVisual.Controllers
{
    public class PessoasController : Controller
    {

        public static IList<Pessoa> pessoaList = new List<Pessoa>
        {
            new Pessoa { Id = 1, Nome = "Kaue", Cargo="Cargo2"},
            new Pessoa { Id = 2, Nome = "Joao" , Cargo="Cargo1"}, 
            new Pessoa { Id = 3, Nome = "pedr", Cargo="cargo2"}
        };

        public IActionResult Index()
        {

            var viewModel = new PessoaViewModel
            {
                Items = pessoaList
            };

            return View(viewModel);
            
        }

        public IActionResult Create()
        {
            return View();
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Nome")]Pessoa newPessoa)
        {
            if(!ModelState.IsValid)
                return View(newPessoa);

       
            return RedirectToAction(nameof(Index));
        }
    }
}