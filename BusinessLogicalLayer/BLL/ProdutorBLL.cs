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
            ProdutoValidator produtoValidator = new ProdutoValidator();
            Response response = produtoValidator.Validate(item);
            if (response.HasSuccess)
            {
                return Insert(item);
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
    }
}
