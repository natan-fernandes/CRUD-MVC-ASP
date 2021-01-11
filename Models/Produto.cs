using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUD_MVC.Models
{
    public class Produto : IProduto
    {
        [Key]
        public long Codigo { get; set ; }
        public string Descricao { get; set; }
        public long IdSituacao { get; set; }
        public long IdUnidade { get; set ; }
        public double PesoLiquido { get; set; }
        
        /// <summary>
        /// Separado por virgulas
        /// </summary>
        public string IdEmbalagens { get; set; }

        /// <summary>
        /// O EntityFramework precisa desse construtor vazio p/ criar os controladores
        /// <para>Não utilize este construtor</para>
        /// </summary>
        [Obsolete]
        public Produto() { }

        /// <summary>
        /// Construtor da classe Produto
        /// </summary>
        public Produto(string descricao, long idSituacao, long idUnidade, double pesoLiquido, string idEmbalagens)
        {
            this.Descricao = descricao;
            this.IdSituacao = idSituacao;
            this.IdUnidade = idUnidade;
            this.PesoLiquido = pesoLiquido;
            this.IdEmbalagens = idEmbalagens;
        }
    }
}
