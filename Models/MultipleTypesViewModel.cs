using System.Collections.Generic;

namespace CRUD_MVC.Models
{
    public class MultipleTypesViewModel
    {
        public IEnumerable<Produto> Produto { get; set; }
        public IEnumerable<SituacaoProduto> SituacaoProduto { get; set; }
        public IEnumerable<SituacaoProdutoEmbalagem> SituacaoProdutoEmabalagem { get; set; }
        public IEnumerable<Embalagem> Embalagem { get; set; }
        public IEnumerable<Unidade> Unidade { get; set; }
    }
}
