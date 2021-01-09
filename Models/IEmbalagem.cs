namespace CRUD_MVC.Models
{
    interface IEmbalagem
    {
        Unidade Unidade { get; set; }
        double FatorDeConversao { get; set; }
        SituacaoProdutoEmbalagem Situacao { get; set; }
    }
}
