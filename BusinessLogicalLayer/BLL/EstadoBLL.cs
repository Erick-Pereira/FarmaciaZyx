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
    public class EstadoBLL
    {
        EstadoDAL estadoDAL = new EstadoDAL();
        /// <summary>
        /// Instancia o metodo GetAll do EstadoDAL
        /// </summary>
        /// <returns>Retorna um DataResponse contendo todos os Estados cadastrados no banco de dados </returns>
        public DataResponse<Estado> GetAll()
        {
            return estadoDAL.GetAll();
        }
        /// <summary>
        /// Instancia o metodo GetByID do EstadoDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um SingleResponse contendo um Estado referente ao ID informado</returns>
        public SingleResponse<Estado> GetByID(int id)
        {
            return estadoDAL.GetByID(id);
        }
    }
}
