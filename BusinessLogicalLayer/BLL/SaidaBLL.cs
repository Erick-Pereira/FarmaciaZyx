using DataAccessLayer;
using Entities;
using Entities.Filters;
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
        /// <summary>
        /// Instancia o metodo GetAll do SaidaDAL
        /// </summary>
        /// <returns>Retorna um DataResponse contendo todas as Saidas cadastradas no banco de dados</returns>
        public DataResponse<SaidaView> GetAll()
        {
            return saidaDAL.GetAll();
        }
        /// <summary>
        /// Recebe um ID e instancia o metodo GetAllBySaidaID do ProdutosSaidasDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um DataResponse contendo ProdutosSaidas referentes ao ID informado </returns>
        public DataResponse<ProdutosSaidaView> GetAllBySaidaID(int id)
        {
            return produtosSaidasDAL.GetAllBySaidaID(id);
        }
        /// <summary>
        /// Recebe um ID e instancia o metodo GetByID do SaidaDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um SIngleResponse contendo uma Saida referente ao ID informado</returns>
        public SingleResponse<SaidaView> GetByID(int id)
        {
            return saidaDAL.GetSaidaViewByID(id);
        }
        /// <summary>
        /// Recebe uma Saida e instancia o metodo Insert do SaidaDAL e ProdutosSaidasDAL
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
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
        /// <summary>
        /// Recebe um FiltersSaida e instancia o GetByDate do SaidaDAL
        /// </summary>
        /// <param name="filtersSaida"></param>
        /// <returns>Retorna um DataResponse contendo todas as Saidas que foram efetuadas entre duas datas</returns>
        public DataResponse<SaidaView> GetByDate(FiltersSaida filtersSaida)
        {
            return saidaDAL.GetByDate(filtersSaida);
        }
    }
}