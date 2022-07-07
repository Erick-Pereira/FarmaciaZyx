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
    public class EnderecoBLL
    {
        private EnderecoDAL enderecoDAL = new EnderecoDAL();
        /// <summary>
        /// Recebe um ID e instancia o metodo Delete do EnderecoDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Delete(int id)
        {
            return enderecoDAL.Delete(id);
        }
        /// <summary>
        /// Instancia o metodo GetAll do EnderecoDAL
        /// </summary>
        /// <returns>Retorna um DataResponse contendo todos os Endereços cadastrados no banco de dados</returns>
        public DataResponse<Endereco> GetAll()
        {
            return enderecoDAL.GetAll();
        }
        /// <summary>
        /// Recebe um ID e instancia o metodo GetByID do EnderecoDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um SingleResponse contendo um Endereco referente ao ID informado</returns>
        public SingleResponse<Endereco> GetByID(int id)
        {
            return enderecoDAL.GetByID(id);
        }
    }
}
