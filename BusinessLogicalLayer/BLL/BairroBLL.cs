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
    public class BairroBLL
    {
        private BairroDAL bairroDAL = new BairroDAL();

        public Response Delete(int id)
        {
            return bairroDAL.Delete(id);
        }

        public DataResponse<Bairro> GetAll()
        {
            return bairroDAL.GetAll();
        }

        public SingleResponse<Bairro> GetByID(int id)
        {
            return bairroDAL.GetByID(id);
        }


    }
}
