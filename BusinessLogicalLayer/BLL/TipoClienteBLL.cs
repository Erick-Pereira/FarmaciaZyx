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
    public class TipoClienteBLL
    {
        TipoClienteDAL tipoClienteDAL = new TipoClienteDAL();
        /// <summary>
        /// Instancia o metodo GetAll do TipoClienteDAL
        /// </summary>
        /// <returns>Retorna um DataResponse contendo todos os Tipos de Cliente cadastrados no banco de dados</returns>
        public DataResponse<TipoCliente> GetAll()
        {
            return tipoClienteDAL.GetAll();
        }
        /// <summary>
        /// Recebe um ID e instancia o metodo GetByID do TipoClienteDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um SingleResponse contendo um Tipo de Cliente referente ao ID informado</returns>
        public SingleResponse<TipoCliente> GetByID(int id)
        {
            return tipoClienteDAL.GetByID(id);
        }

    }
}
