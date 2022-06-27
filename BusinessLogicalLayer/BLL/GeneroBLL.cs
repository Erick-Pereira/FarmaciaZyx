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
        public DataResponse<Generos> GetAll()
        {

            DataResponse<Generos> dataResponse = generoDAL.GetAll();
            if (dataResponse.HasSuccess)
            {
                return new DataResponse<Generos>(dataResponse.Message, true, dataResponse.Dados);
            }
            else
            {
                return new DataResponse<Generos>(dataResponse.Message, dataResponse.HasSuccess, null);
            }
        }
        public SingleResponse<Generos> GetByID(int id)
        {

            SingleResponse<Generos> singleResponse = generoDAL.GetByID(id);
            if (singleResponse.HasSuccess)
            {
                return new SingleResponse<Generos>(singleResponse.Message, true, singleResponse.Item);
            }
            else
            {
                return new SingleResponse<Generos>(singleResponse.Message, singleResponse.HasSuccess, null);
            }
        }
    }
}
