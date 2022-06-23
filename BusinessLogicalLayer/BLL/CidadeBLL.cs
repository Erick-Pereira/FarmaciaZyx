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
    public class CidadeBLL
    {
        private CidadeDAL cidadeDAL = new CidadeDAL();

        public Response Delete(int id)
        {
            return cidadeDAL.Delete(id);
        }

        public DataResponse<Cidade> GetAll()
        {
            return cidadeDAL.GetAll();
        }

        public SingleResponse<Cidade> GetByID(int id)
        {
            return cidadeDAL.GetByID(id);
        }

    }
}
