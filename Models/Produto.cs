using System;
using System.Collections.Generic;
namespace CRUD_MVC.Models
{
    public class Produto : IProduto
    {
        public long Codigo { get; set ; }
        public string Descricao { get; set; }
        public SituacaoProduto Situacao { get; set; }
        public Unidade Unidade { get; set ; }
        public double PesoLiquido { get; set; }
        public List<Embalagem> Embalagens { get; set; }

        /// <summary>
        /// Construtor da classe Produto
        /// </summary>
        public Produto(string descricao, SituacaoProduto situacao, Unidade unidade, double pesoLiquido, List<Embalagem> embalagens)
        {
            this.Descricao = descricao;
            this.Situacao = situacao;
            this.Unidade = Unidade;
            this.PesoLiquido = pesoLiquido;
            this.Embalagens = embalagens;
        }
    }
}
