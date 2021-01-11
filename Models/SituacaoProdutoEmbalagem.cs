using System;

namespace CRUD_MVC.Models
{

    public enum SituacaoProdutoEmabalagemEnum : int
    {
        Inativo = 1,
        Ativo = 2,
    }
    public class SituacaoProdutoEmbalagem : ISituacaoProdutoEmbalagem
    {
        public long Id { get; set; }
        public string Descricao { get; set; }

        /// <summary>
        /// O EntityFramework precisa desse construtor vazio p/ criar os controladores
        /// <para>Não utilize este construtor</para>
        /// </summary>
        [Obsolete]
        public SituacaoProdutoEmbalagem() { }

        /// <summary>
        /// Construtor da classe SituacaoProdutoEmbalagem
        /// </summary>
        public SituacaoProdutoEmbalagem(string descricao)
        {
            this.Descricao = descricao;
        }
    }
}
