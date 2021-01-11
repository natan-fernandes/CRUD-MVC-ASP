using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_MVC.Models
{
    public enum SituacaoProdutoEnum : int
    {
        Inativo = 1,
        Ativo = 2,
        Bloqueado = 3
    }

    public class SituacaoProduto : ISituacaoProduto
    {
        public long Id { get; set; }
        public string Descricao { get; set; }

        /// <summary>
        /// O EntityFramework precisa desse construtor vazio p/ criar os controladores
        /// <para>Não utilize este construtor</para>
        /// </summary>
        [Obsolete]
        public SituacaoProduto() { }

        /// <summary>
        /// Construtor da classe SituacaoProduto
        /// </summary>
        public SituacaoProduto(string descricao)
        {
            this.Descricao = descricao;
        }
    }
}
