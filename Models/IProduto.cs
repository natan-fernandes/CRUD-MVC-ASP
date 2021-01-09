using System.Collections.Generic;

namespace CRUD_MVC.Models
{
    interface IProduto
    {
        long Codigo { get; set; }
        string Descricao { get; set; }
        SituacaoProduto Situacao { get; set; }
        Unidade Unidade { get; set; }
        double PesoLiquido { get; set; }
        List<Embalagem>Embalagens { get; set; }
    }
}
