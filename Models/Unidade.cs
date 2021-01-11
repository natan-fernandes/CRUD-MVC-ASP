using System;
using System.ComponentModel.DataAnnotations;

namespace CRUD_MVC.Models
{
    public enum UnidadeEnum : int
    {
        Caixa = 1,
        Quilograma = 2,
        Litro = 3,
        Peça = 4,
        Pacote = 5,
        Unidade = 6
    }
    public class Unidade : IUnidade
    {
        [Key]
        public long Id { get; set; }
        public string Descricao { get; set; }

        public string Abreviatura { get; set; }

        /// <summary>
        /// O EntityFramework precisa desse construtor vazio p/ criar os controladores
        /// <para>Não utilize este construtor</para>
        /// </summary>
        [Obsolete]
        public Unidade() { }

        /// <summary>
        /// Construtor da classe Unidade
        /// </summary>
        public Unidade(string descricao, string abreviatura)
        {
            this.Descricao = descricao;
            this.Abreviatura = abreviatura;
        }
    }
}
