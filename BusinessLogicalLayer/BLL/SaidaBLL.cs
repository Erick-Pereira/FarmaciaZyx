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

        public DataResponse<Saida> GetAll()
        {
            DataResponse<Saida> dataResponse = saidaDAL.GetAll();
            for (int i = 0; i < dataResponse.Dados.Count; i++)
            {
                dataResponse.Dados[i].produtosSaidas = produtosSaidasDAL.GetAllBySaidaID(dataResponse.Dados[i].ID).Dados;
            }
            return dataResponse;
        }

        public SingleResponse<Saida> GetByID(int id)
        {
            SingleResponse<Saida> singleResponse = saidaDAL.GetByID(id);
            if (singleResponse.HasSuccess)
            {
                singleResponse.Item.produtosSaidas = produtosSaidasDAL.GetAllBySaidaID(singleResponse.Item.ID).Dados;
            }
            return singleResponse;
        }

        public Response Insert(Saida item)
        {
            Response response = new Response();
            using (TransactionScope scope = new TransactionScope())
            {


                //INSERE UM ENDEREÇO NO BANCO E JÁ VINCULA O ID DESTE ENDEREÇO COM O SELECT NO BANCO 
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
            }//scope.Dispose();
            return response;
        }
    }
}