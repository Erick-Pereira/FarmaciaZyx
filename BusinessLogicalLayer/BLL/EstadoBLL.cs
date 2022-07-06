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
    public class EstadoBLL
    {
        EstadoDAL estadoDAL = new EstadoDAL();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataResponse<Estado> GetAll()
        {
            return estadoDAL.GetAll();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SingleResponse<Estado> GetByID(int id)
        {
            return estadoDAL.GetByID(id);
        }
    }
}
