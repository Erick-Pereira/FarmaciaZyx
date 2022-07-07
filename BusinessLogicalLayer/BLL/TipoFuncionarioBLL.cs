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
    public class TipoFuncionarioBLL
    {
        TipoFuncionarioDAL tipoFuncionarioDal = new TipoFuncionarioDAL();
        /// <summary>
        /// Instancia o metodo GetAll do TipoFuncionarioDAL
        /// </summary>
        /// <returns>Retorna um DataResponse contendo todos os Tipos de Funcionario cadastrados no banco de dados</returns>
        public DataResponse<TipoFuncionario> GetAll()
        {
           return tipoFuncionarioDal.GetAll();
        }
        /// <summary>
        /// Recebe um ID e instancia o metodo GetByID do TipoFuncionarioDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um SingleResponse contendo um Tipo de Funcionario referente ao ID informado</returns>
        public SingleResponse<TipoFuncionario> GetByID(int id)
        {
            return tipoFuncionarioDal.GetByID(id);
        }
    }
}
