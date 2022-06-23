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
    public class EnderecoBLL
    {
        private EnderecoDAL enderecoDAL = new EnderecoDAL();

        public Response Delete(int id)
        {
            return enderecoDAL.Delete(id);
        }

        public DataResponse<Endereco> GetAll()
        {
            return enderecoDAL.GetAll();
        }

        public SingleResponse<Endereco> GetByID(int id)
        {
            return enderecoDAL.GetByID(id);
        }


    }
}
