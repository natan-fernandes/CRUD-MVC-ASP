using Microsoft.EntityFrameworkCore;

namespace CRUD_MVC.Models
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Embalagem> Embalagens { get; set; }
        public DbSet<SituacaoProduto> DefSituacaoProduto { get; set; }
        public DbSet<SituacaoProdutoEmbalagem> DefSituacaoProdutoEmbalagem { get; set; }
        public DbSet<Unidade> DefUnidade { get; set; }
    }
}
