using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;

namespace ProgramacaoVisual.Controllers
{
    public class PessoasController : Controller
    {

        public static IList<Pessoa> pessoaList = new List<Pessoa>
        {
            new Pessoa { Id = 1, Nome = "Kaue"},
            new Pessoa { Id = 2, Nome = "Joao"}, 
            new Pessoa { Id = 3, Nome = "pedr"}
        };

        public IActionResult Index()
        {

            var viewModel = new PessoaViewModel
            {
                Items = pessoaList
            };

            return View(viewModel);
            
        }
    }
}