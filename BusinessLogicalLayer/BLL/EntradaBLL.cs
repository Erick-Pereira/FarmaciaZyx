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
    public class EntradaBLL
    {
        EntradaDAL entradaDAL = new EntradaDAL();
        ProdutosEntradasDAL produtosEntradasDAL = new ProdutosEntradasDAL();
        /// <summary>
        /// Instancia o metodo GetAll do entradaDAL
        /// </summary>
        /// <returns>Retorna um DataResponse contendo todas as Entradas registradas no banco de dados</returns>
        public DataResponse<EntradaView> GetAll()
        {
            return entradaDAL.GetAll();
        }
        /// <summary>
        /// Recebe um ID e instancia o metodo GetByID do entradaDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna uma Entrada referente ao ID informado</returns>
        public SingleResponse<EntradaView> GetByID(int id)
        {
            return entradaDAL.GetByID(id);
        }
        /// <summary>
        ///  Recebe um ID e instancia o metodo GetAllByEntraID do ProdutosEntradasDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um dal com todos os Produtos registrados na entrada</returns>
        public DataResponse<ProdutosEntradaView> GetAllByEntraID(int id)
        {
            return produtosEntradasDAL.GetAllByEntradaID(id);
        }
        /// <summary>
        /// Recebe uma Entrada e instancia o metodo Insert do entradaDAL e ProdutosEntradasDAL
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
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
        /// <summary>
        /// Recebe um FiltersEntrada e instancia o metodo GetByDate do EntradaDAL
        /// </summary>
        /// <param name="filtersEntrada"></param>
        /// <returns>Retorna um DataResponse contendo todas as entradas que foram efetuadas entre duas datas</returns>
        public DataResponse<EntradaView> GetByDate(FiltersEntrada filtersEntrada)
        {
            return entradaDAL.GetByDate(filtersEntrada);
        }
    }
}
