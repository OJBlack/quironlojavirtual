using Quiron.LojaVirtual.Dominio.Entidades;
using System.Collections.Generic;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EFdbContext contexto = new EFdbContext();

        public IEnumerable<Produto> Produtos
        {
            get { return contexto.Produtos; }
        }
    }
}
