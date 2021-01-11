using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_MVC.Models
{
    interface ISituacaoProduto
    {
        long Id { get; set; }
        string Descricao { get; set; }
    }
}
