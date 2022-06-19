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
        public DataResponse<TipoCliente> GetAll()
        {
            TipoClienteDAL tipoClienteDAL = new TipoClienteDAL();
            DataResponse<TipoCliente> dataResponse = tipoClienteDAL.GetAll();
            if (dataResponse.HasSuccess)
            {
                return new DataResponse<TipoCliente>("Login efetuado com sucesso", true, dataResponse.Dados);
            }
            else
            {
                return new DataResponse<TipoCliente>(dataResponse.Message, dataResponse.HasSuccess, null);
            }
        }

    }
}
