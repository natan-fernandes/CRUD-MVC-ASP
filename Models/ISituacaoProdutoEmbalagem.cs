using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_MVC.Models
{
    interface ISituacaoProdutoEmbalagem
    {
        long Id { get; set; }
        string Descricao { get; set; }
    }
}
