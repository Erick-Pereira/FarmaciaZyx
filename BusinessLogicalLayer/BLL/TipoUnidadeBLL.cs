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
        public DataResponse<TipoUnidade> GetAll()
        {
            TipoUnidadeDAL tipoUnidadeDAL = new TipoUnidadeDAL();
            DataResponse<TipoUnidade> dataResponse = tipoUnidadeDAL.GetAll();
            if (dataResponse.HasSuccess)
            {
                return new DataResponse<TipoUnidade>(dataResponse.Message, true, dataResponse.Dados);
            }
            else
            {
                return new DataResponse<TipoUnidade>(dataResponse.Message, dataResponse.HasSuccess, null);
            }
        }
        public SingleResponse<TipoUnidade> GetById(int id)
        {
            TipoUnidadeDAL tipoUnidadeDAL = new TipoUnidadeDAL();
            SingleResponse<TipoUnidade> singleResponse = tipoUnidadeDAL.GetByID(id);
            if (singleResponse.HasSuccess)
            {
                return new SingleResponse<TipoUnidade>(singleResponse.Message, true, singleResponse.Item);
            }
            else
            {
                return new SingleResponse<TipoUnidade>(singleResponse.Message, singleResponse.HasSuccess, null);
            }
        }
    }
}