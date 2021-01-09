namespace CRUD_MVC.Models
{
    public class Embalagem : IEmbalagem
    {
        public Unidade Unidade { get; set; }
        public double FatorDeConversao { get; set; }
        public SituacaoProdutoEmbalagem Situacao { get; set; }


        public Embalagem(Unidade unidade, double fatorDeConversao, SituacaoProdutoEmbalagem situacao)
        {
            this.Unidade = unidade;
            this.FatorDeConversao = fatorDeConversao;
            this.Situacao = situacao;
        }

    }
}
