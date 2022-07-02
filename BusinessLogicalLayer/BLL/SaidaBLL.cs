using DataAccessLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BusinessLogicalLayer
{
    public class SaidaBLL
    {
        SaidaDAL saidaDAL = new SaidaDAL();
        ProdutosSaidasDAL produtosSaidasDAL = new ProdutosSaidasDAL();

        public DataResponse<SaidaView> GetAll()
        {
            return saidaDAL.GetAllSaidaView();
        }
        public DataResponse<ProdutosSaidaView> GetAllProdutosSaidaViewBySaidaID(int id)
        {
            return produtosSaidasDAL.GetAllProdutosSaidaViewBySaidaID(id);
        }
        public SingleResponse<SaidaView> GetByID(int id)
        {
            return saidaDAL.GetSaidaViewByID(id);
        }

        public Response Insert(Saida item)
        {
            Response response = new Response();
            using (TransactionScope scope = new TransactionScope())
            {
                response = saidaDAL.Insert(item);
                for (int i = 0; i < item.produtosSaidas.Count; i++)
                {
                    item.produtosSaidas[i].SaidaId = item.ID;
                    response = produtosSaidasDAL.Insert(item.produtosSaidas[i]);
                }
                if (!response.HasSuccess)
                {
                    return response;
                }
                scope.Complete();
            }
            return response;
        }
    }
}