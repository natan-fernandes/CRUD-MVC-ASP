using System;

namespace CRUD_MVC.Models
{
    public class Embalagem : IEmbalagem
    {
        public long Id {get; set;}
        public long IdUnidade { get; set; }
        public double FatorDeConversao { get; set; }
        public long IdSituacao { get; set; }


        /// <summary>
        /// O EntityFramework precisa desse construtor vazio p/ criar os controladores
        /// <para>Não utilize este construtor</para>
        /// </summary>
        [Obsolete]
        public Embalagem() { }

        /// <summary>
        /// Construtor da classe Embalagem
        /// </summary>
        public Embalagem(long idUnidade, double fatorDeConversao, long idSituacao)
        {
            this.IdUnidade = idUnidade;
            this.FatorDeConversao = fatorDeConversao;
            this.IdSituacao = idSituacao;
        }

    }
}
