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
        public DataResponse<TipoFuncionario> GetAll()
        {
            TipoFuncionarioDAL tipoFuncionarioDal = new TipoFuncionarioDAL();  
            DataResponse<TipoFuncionario> dataResponse = tipoFuncionarioDal.GetAll();
            if (dataResponse.HasSuccess)
            {
                    return new DataResponse<TipoFuncionario>("Login efetuado com sucesso", true, dataResponse.Dados);
            }
            else
            {
                return new DataResponse<TipoFuncionario>(dataResponse.Message, dataResponse.HasSuccess, null);
            }
        }

    }
}
