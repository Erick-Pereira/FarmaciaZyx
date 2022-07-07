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
    public class GeneroBLL
    {

        GeneroDAL generoDAL = new GeneroDAL();
        /// <summary>
        /// Instancia o metodo GetAll do GeneroDAL
        /// </summary>
        /// <returns>Retorna DataResponse contendo todos os Generos cadastrados no banco de dados</returns>
        public DataResponse<Generos> GetAll()
        {
            return generoDAL.GetAll();
        }
        /// <summary>
        /// Recebe um ID e instancia o metodo GetByID do GeneroDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um SingleResponse contendo o Genero referente ao ID</returns>
        public SingleResponse<Generos> GetByID(int id)
        {

            return generoDAL.GetByID(id);
        }
    }
}
