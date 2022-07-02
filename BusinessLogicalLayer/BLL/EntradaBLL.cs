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
    public class EntradaBLL
    {
        EntradaDAL entradaDAL = new EntradaDAL();
        ProdutosEntradasDAL produtosEntradasDAL = new ProdutosEntradasDAL();

        public DataResponse<EntradaView> GetAll()
        {
            return entradaDAL.GetAll();
        }
        public SingleResponse<EntradaView> GetByID(int id)
        {
            return entradaDAL.GetByID(id);
        }
        public DataResponse<ProdutosEntradaView> GetAllBySaidaID(int id)
        {
            return produtosEntradasDAL.GetAllBySaidaID(id);
        }

        public Response Insert(Entrada item)
        {
            Response response = new Response();
            using (TransactionScope scope = new TransactionScope())
            {
                response = entradaDAL.Insert(item);
                for (int i = 0; i < item.produtosEntradas.Count; i++)
                {
                    item.produtosEntradas[i].EntradaID = item.ID;
                    response = produtosEntradasDAL.Insert(item.produtosEntradas[i]);
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
