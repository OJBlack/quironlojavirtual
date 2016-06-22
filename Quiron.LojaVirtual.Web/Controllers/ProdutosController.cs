using Quiron.LojaVirtual.Dominio.Repositorio;
using System.Linq;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        // GET: Produtos

        private ProdutosRepositorio _repositorio;
        public ActionResult Index()
        {
            _repositorio = new ProdutosRepositorio();

            var produto = _repositorio.Produtos.Take(10);

            return View(produto);
        }
    }
}