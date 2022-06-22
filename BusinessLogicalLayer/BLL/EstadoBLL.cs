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
        public DataResponse<Estado> GetAll()
        {
            return estadoDAL.GetAll();
        }
    }
}
