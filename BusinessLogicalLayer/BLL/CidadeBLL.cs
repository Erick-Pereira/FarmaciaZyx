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
    public class CidadeBLL
    {
        private CidadeDAL cidadeDAL = new CidadeDAL();
        /// <summary>
        /// Recebe um ID e instancia o Delete do CidadeDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Delete(int id)
        {
            return cidadeDAL.Delete(id);
        }
        /// <summary>
        /// Instancia o metodo GetAll do CidadeDAL
        /// </summary>
        /// <returns>Retorna um DataResponse contendo todas as cidade cadastradas no banco de dados</returns>
        public DataResponse<Cidade> GetAll()
        {
            return cidadeDAL.GetAll();
        }
        /// <summary>
        /// Recebe um ID e instancia o metodo GetById do CidadeDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um SingleResponse contendo uma Cidade referente ao ID informado</returns>
        public SingleResponse<Cidade> GetByID(int id)
        {
            return cidadeDAL.GetByID(id);
        }

    }
}
