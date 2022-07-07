using DataAccessLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class ProdutoBLL : ICRUD<Produto>
    {
        ProdutoDAL produtoDAL = new ProdutoDAL();

        /// <summary>
        /// Recebe um ID e instancia o metodo Delete do ProdutoDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Delete(int id)
        {
            return produtoDAL.Delete(id);
        }
        /// <summary>
        /// Instancia o metodo GetAll do ProdutoDAL
        /// </summary>
        /// <returns>Retorna um DataResponse </returns>
        public DataResponse<Produto> GetAll()
        {
            return produtoDAL.GetAll();
        }
        /// <summary>
        /// Recebe um ID e instancia o metodo GetById
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um SingleResponse contendo o Produto referente ao ID informado</returns>
        public SingleResponse<Produto> GetByID(int id)
        {
            return produtoDAL.GetByID(id);
        }
        /// <summary>
        /// Recebe um Produto e instancia o metodo Insert do ProdutoDAL
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Insert(Produto item)
        {
            ProdutoValidator produtoValidator = new ProdutoValidator();
            Response response = produtoValidator.Validate(item);
            if (response.HasSuccess)
            {
                return produtoDAL.Insert(item);
            }
            return new Response(response.Message, false);
        }
        /// <summary>
        /// Recebe um Produto e instancia o metodo Update do ProdutoDAL
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Update(Produto item)
        {
            return produtoDAL.Update(item);
        }
        /// <summary>
        /// Recebe um Produto e instancia o metodo UpdateValueAndInventory do ProdutoDAL
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response UpdateValueAndInventory(Produto item)
        {
            return produtoDAL.UpdateValueAndInventory(item);
        }
        /// <summary>
        /// Recebe uma lista de Produtos e instancia o metodo CalculateNewValue do ProdutoDAL
        /// </summary>
        /// <param name="produtos"></param>
        /// <returns>Retorna um DataResponse contendo uma lista de produtos com o valor atualizado</returns>
        public DataResponse<Produto> CalculateNewValue(List<Produto> produtos)
        {
            SingleResponse<Produto> singleResponse = new SingleResponse<Produto>();
            for (int i = 0; i < produtos.Count; i++)
            {
                singleResponse = produtoDAL.GetByID(produtos[i].ID);
                if (singleResponse.HasSuccess)
                {
                    produtos[i].Valor = ((singleResponse.Item.Valor * singleResponse.Item.QtdEstoque) + (produtos[i].Valor * produtos[i].QtdEstoque)) / (produtos[i].QtdEstoque + singleResponse.Item.QtdEstoque);
                    produtos[i].Valor = Math.Round(produtos[i].Valor, 2);
                }
                else
                {
                    break;
                }
            }
            return new DataResponse<Produto>(singleResponse.Message, singleResponse.HasSuccess, produtos);
        }

        /// <summary>
        /// Recebe dois Produtos e calcula o novo Valor
        /// </summary>
        /// <param name="OldProduto"></param>
        /// <param name="NewProduto"></param>
        /// <returns>Retorna um double contendo o novo Valor</returns>
        public double CalculateNewValueWithProdutos(Produto OldProduto, Produto NewProduto)
        {
            double valor = ((OldProduto.Valor * OldProduto.QtdEstoque) + (NewProduto.Valor * NewProduto.QtdEstoque)) / (NewProduto.QtdEstoque + OldProduto.QtdEstoque);
            return Math.Round(valor, 2);
        }
        /// <summary>
        /// Recebe uma lista de Produtos e calcula o estoque
        /// </summary>
        /// <param name="produtos"></param>
        /// <returns>Retorna um DataResponse com o estoque atualizado</returns>
        public DataResponse<Produto> CalculateInventory(List<Produto> produtos)
        {
            List<Produto> produtosWithEstoque = new List<Produto>();
            for (int i = 0; i < produtos.Count; i++)
            {
                produtosWithEstoque.Add(produtoDAL.GetByID(produtos[i].ID).Item);
                if (produtosWithEstoque[i].QtdEstoque >= produtos[i].QtdEstoque)
                {
                    produtosWithEstoque[i].QtdEstoque -= produtos[i].QtdEstoque;
                }
                else
                {
                    return new DataResponse<Produto>($"Não é possivel vender mais do que o estoque! Produto: {produtosWithEstoque[i].Nome}, Estoque: {produtosWithEstoque[i].QtdEstoque}",false,null);
                }
            }
            return new DataResponse<Produto>("Calculo efetuado com sucesso", true, produtosWithEstoque);
        }
    }
}


