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
        
        public Response Delete(int id)
        {
            return produtoDAL.Delete(id);
        }

        public DataResponse<Produto> GetAll()
        {
            return produtoDAL.GetAll();
        }

        public SingleResponse<Produto> GetByID(int id)
        {
            return produtoDAL.GetByID(id);
        }

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
        public SingleResponse<Produto> GetByNome(string nome)
        {
            return produtoDAL.GetByName(nome);
        }
        public Response Update(Produto item)
        {
            return produtoDAL.Update(item);
        }
        public DataResponse<Produto> CalculateNewValue(List<Produto> produtos)
        {
            SingleResponse<Produto> singleResponse = new SingleResponse<Produto>();
            for (int i = 0; i < produtos.Count ; i++)
            {
                singleResponse = produtoDAL.GetByID(produtos[i].ID);
                if (singleResponse.HasSuccess)
                {
                    produtos[i].Valor = (singleResponse.Item.Valor * singleResponse.Item.QtdEstoque) + (produtos[i].Valor * produtos[i].QtdEstoque) / (produtos[i].QtdEstoque + singleResponse.Item.QtdEstoque);
                }
                else
                {
                    break;
                }
            }
            if (singleResponse.HasSuccess)
            {
                return new DataResponse<Produto>(singleResponse.Message, true, produtos);
            }
            return new DataResponse<Produto>(singleResponse.Message, false, null);
            
           
        }
    }
}
