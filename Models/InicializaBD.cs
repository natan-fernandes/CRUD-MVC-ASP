using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_MVC.Models
{
    public static class InicializaBD
    {
        public static void Initialize(ProdutoContext produtoContext)
        {
            produtoContext.Database.EnsureCreated();

            if (produtoContext.Produtos.Any())
                return;

            #region Criando tabela unidades
            string[,] unidades = new string[6,2] {
                { "CX", "Caixa" },
                { "KG", "Quilograma"},
                { "L", "Litro" },
                { "PC", "Peça" },
                { "PCT", "Pacote" },
                { "UN", "Unidade" }
            };

            for (int i = 0; i < unidades.Length/2; i++)
            { 
                Unidade un = new Unidade(unidades[i,1], unidades[i,0]);
                produtoContext.DefUnidade.Add(un);
            }

            #endregion

            #region Criando tabela SituacaoProduto
            string[] situacoesProduto = {
                "Inativo",
                "Ativo",
                "Bloqueado"
            };

            for (int i = 0; i < situacoesProduto.Length; i++)
            {
                SituacaoProduto sp = new SituacaoProduto(situacoesProduto[i]);
                produtoContext.DefSituacaoProduto.Add(sp);
            }

            #endregion

            #region Criando tabela SituacaoProdutoEmbalagem
            string[] situacoesProdutoEmbalagem = {
                "Inativo",
                "Ativo"
            };

            for (int i = 0; i < situacoesProdutoEmbalagem.Length; i++)
            {
                SituacaoProdutoEmbalagem spe = new SituacaoProdutoEmbalagem(situacoesProdutoEmbalagem[i]);
                produtoContext.DefSituacaoProdutoEmbalagem.Add(spe);
            }

            #endregion


            /* Pre-adicionando produtos e embalagens pra testar */


            Produto p = new Produto("LEITE", (long)SituacaoProdutoEnum.Ativo, (long)UnidadeEnum.Litro, 15.00, "6");
            produtoContext.Produtos.Add(p);


            p = new Produto("MANTEIGA", (long)SituacaoProdutoEnum.Ativo, (long)UnidadeEnum.Unidade, 0.30, "4");
            produtoContext.Produtos.Add(p);

            p = new Produto("PAO", (long)SituacaoProdutoEnum.Ativo, (long)UnidadeEnum.Quilograma, 0.50, "3");
            produtoContext.Produtos.Add(p);
            
            p = new Produto("PRESUNTO", (long)SituacaoProdutoEnum.Ativo, (long)UnidadeEnum.Peça, 5.00, "2");
            produtoContext.Produtos.Add(p);

            p = new Produto("AGUA", (long)SituacaoProdutoEnum.Bloqueado, (long)UnidadeEnum.Litro, 5.00, "5"); 
            produtoContext.Produtos.Add(p);
            
            p = new Produto("BALA", (long)SituacaoProdutoEnum.Inativo, (long)UnidadeEnum.Caixa, 1.00, "1");
            produtoContext.Produtos.Add(p);


            Embalagem e = new Embalagem((long)UnidadeEnum.Caixa, 1, (long)SituacaoProdutoEmabalagemEnum.Inativo); //1
            produtoContext.Embalagens.Add(e);

            e = new Embalagem((long)UnidadeEnum.Peça, 1, (long)SituacaoProdutoEmabalagemEnum.Ativo); //2
            produtoContext.Embalagens.Add(e);

            e = new Embalagem((long)UnidadeEnum.Quilograma, 1, (long)SituacaoProdutoEmabalagemEnum.Ativo); //3
            produtoContext.Embalagens.Add(e);

            e = new Embalagem((long)UnidadeEnum.Unidade, 1, (long)SituacaoProdutoEmabalagemEnum.Ativo); //4
            produtoContext.Embalagens.Add(e);

            e = new Embalagem((long)UnidadeEnum.Litro, 1, (long)SituacaoProdutoEmabalagemEnum.Inativo); //5
            produtoContext.Embalagens.Add(e);

            e = new Embalagem((long)UnidadeEnum.Litro, 1, (long)SituacaoProdutoEmabalagemEnum.Ativo); //6
            produtoContext.Embalagens.Add(e);


            produtoContext.SaveChanges();

        }
    }
}
