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

        public DataResponse<Entrada> GetAll()
        {
            DataResponse<Entrada> dataResponse = entradaDAL.GetAll();
            for (int i = 0; i < dataResponse.Dados.Count ; i++)
            {
                dataResponse.Dados[i].produtosEntradas = produtosEntradasDAL.GetAllByEntradaID(dataResponse.Dados[i].ID).Dados;
            }
            return dataResponse;
        }

        public SingleResponse<Entrada> GetByID(int id)
        {
            SingleResponse<Entrada> singleResponse = entradaDAL.GetByID(id);
            singleResponse.Item.produtosEntradas =  produtosEntradasDAL.GetAllByEntradaID(id).Dados;
            return singleResponse;
        }

        public Response Insert(Entrada item)
        {
            Response response = new Response();
            using (TransactionScope scope = new TransactionScope())
            {
               
                
                //INSERE UM ENDEREÇO NO BANCO E JÁ VINCULA O ID DESTE ENDEREÇO COM O SELECT NO BANCO 
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
            }//scope.Dispose();
            return response;
        }
}
}
