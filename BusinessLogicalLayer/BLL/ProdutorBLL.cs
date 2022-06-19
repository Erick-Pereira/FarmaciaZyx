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
    public class ProdutorBLL : ICRUD<Produto>
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
            return produtoDAL.Insert(item);
        }

        public Response Update(Produto item)
        {
            return produtoDAL.Update(item);
        }

        public Response CreateProduto(Produto item)
        {
            ProdutoValidator produtoValidator = new ProdutoValidator();
            string erros = produtoValidator.Validate(item.Nome,item.Descricao,item.Laboratorio);
            if (string.IsNullOrWhiteSpace(erros))
            {
                return Insert(item);
            }
            return new Response(erros, false);
        }
    }
}
