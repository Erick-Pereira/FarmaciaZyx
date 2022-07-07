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
    public class BairroBLL
    {
        private BairroDAL bairroDAL = new BairroDAL();

        /// <summary>
        /// Recebe um ID e instancia o metodo Delete do BairroDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Delete(int id)
        {
            return bairroDAL.Delete(id);
        }
        /// <summary>
        /// Instancia o metodo GetAll do BairroDAL
        /// </summary>
        /// <returns>Retorna um DataResponse contendo todos os Bairros cadastrados no banco de dados</returns>
        public DataResponse<Bairro> GetAll()
        {
            return bairroDAL.GetAll();
        }
        /// <summary>
        /// Recebe um ID e instancia o metodo GetByID do BairroDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um SingleResponse contendo um Bairro referente ao ID informado</returns>
        public SingleResponse<Bairro> GetByID(int id)
        {
            return bairroDAL.GetByID(id);
        }


    }
}
