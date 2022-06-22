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
        public DataResponse<TipoFuncionario> GetAll()
        {
            
            DataResponse<TipoFuncionario> dataResponse = tipoFuncionarioDal.GetAll();
            if (dataResponse.HasSuccess)
            {
                    return new DataResponse<TipoFuncionario>(dataResponse.Message, true, dataResponse.Dados);
            }
            else
            {
                return new DataResponse<TipoFuncionario>(dataResponse.Message, dataResponse.HasSuccess, null);
            }
        }
        public SingleResponse<TipoFuncionario> GetByID(int id)
        {
           
            SingleResponse<TipoFuncionario> singleResponse = tipoFuncionarioDal.GetByID(id);
            if (singleResponse.HasSuccess)
            {
                return new SingleResponse<TipoFuncionario>(singleResponse.Message, true, singleResponse.Item);
            }
            else
            {
                return new SingleResponse<TipoFuncionario>(singleResponse.Message, singleResponse.HasSuccess, null);
            }
        }
    }
}
