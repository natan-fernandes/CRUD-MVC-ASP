using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUD_MVC.Models
{
    interface IProduto
    {
        long Codigo { get; set; }
        string Descricao { get; set; }
        long IdSituacao { get; set; }
        long IdUnidade { get; set; }
        double PesoLiquido { get; set; }

        /// <summary>
        /// Separado por virgulas
        /// </summary>
        string IdEmbalagens { get; set; }
    }
}
