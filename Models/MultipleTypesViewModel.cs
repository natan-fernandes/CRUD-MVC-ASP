using System.Collections.Generic;

namespace CRUD_MVC.Models
{
    public class MultipleTypesViewModel
    {
        public IEnumerable<Produto> Produto { get; set; }
        public IEnumerable<SituacaoProduto> SituacaoProduto { get; set; }
    }
}
