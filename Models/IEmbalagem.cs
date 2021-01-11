namespace CRUD_MVC.Models
{
    interface IEmbalagem
    {
        long Id { get; set; }
        long IdUnidade { get; set; }
        double FatorDeConversao { get; set; }
        long IdSituacao { get; set; }
    }
}
