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
        public DataResponse<TipoCliente> GetAll()
        {
           
            DataResponse<TipoCliente> dataResponse = tipoClienteDAL.GetAll();
            if (dataResponse.HasSuccess)
            {
                return new DataResponse<TipoCliente>(dataResponse.Message, true, dataResponse.Dados);
            }
            else
            {
                return new DataResponse<TipoCliente>(dataResponse.Message, dataResponse.HasSuccess, null);
            }
        }
        public SingleResponse<TipoCliente> GetByID(int id)
        {
            
            SingleResponse<TipoCliente> singleResponse = tipoClienteDAL.GetByID(id);
            if (singleResponse.HasSuccess)
            {
                return new SingleResponse<TipoCliente>(singleResponse.Message, true, singleResponse.Item);
            }
            else
            {
                return new SingleResponse<TipoCliente>(singleResponse.Message, singleResponse.HasSuccess, null);
            }
        }

    }
}
