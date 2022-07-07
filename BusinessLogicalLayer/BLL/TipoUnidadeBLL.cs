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
    public class TipoUnidadeBLL
    {
        TipoUnidadeDAL tipoUnidadeDAL = new TipoUnidadeDAL();
        /// <summary>
        /// Instancia o metodo GetAll do TipoUnidadeDAL
        /// </summary>
        /// <returns>Retorna um DataResponse contendo todos os Tipos de Unidade cadastrados no banco de dados</returns>
        public DataResponse<TipoUnidade> GetAll()
        {
            return tipoUnidadeDAL.GetAll();
        }
        /// <summary>
        /// Recebe um ID e instancia o metodo GetByID do TipoUnidadeDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um SingleResponse contendo um Tipo de Unidade referente ao ID informado</returns>
        public SingleResponse<TipoUnidade> GetById(int id)
        {
            return tipoUnidadeDAL.GetByID(id);
        }
    }
}