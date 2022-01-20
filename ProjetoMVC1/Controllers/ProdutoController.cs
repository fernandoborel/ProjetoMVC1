using Microsoft.AspNetCore.Mvc;

namespace ProjetoMVC1.Controllers
{
    public class ProdutoController : Controller
    {
        List<Models.ProductViewModel> produtos = new List<Models.ProductViewModel>();

        public IActionResult Index()
        {
            return View(produtos);
        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Novo(Models.ProductViewModel produto)
        {
            produtos.Add(produto);
            return View("Index", produtos);
        }
    }
}
