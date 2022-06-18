using DataAccessLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BLL
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
    }
}
