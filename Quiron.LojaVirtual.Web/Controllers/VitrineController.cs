using Quiron.LojaVirtual.Dominio.Repositorio;
using System.Linq;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;

        public int ProdutosPorPagina = 3;
        // GET: Vitirne
        public ActionResult LsitaProdutos(int pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos
                                .OrderBy(p => p.Descricao)
                                .Skip((pagina - 1) * ProdutosPorPagina)
                                .Take(ProdutosPorPagina);
                            
            return View(produtos);
        }
    }
}