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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Response Delete(int id)
        {
            return enderecoDAL.Delete(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataResponse<Endereco> GetAll()
        {
            return enderecoDAL.GetAll();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SingleResponse<Endereco> GetByID(int id)
        {
            return enderecoDAL.GetByID(id);
        }


    }
}
