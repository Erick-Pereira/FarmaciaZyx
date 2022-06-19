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
    public class LaboratorioBLL
    {
        public DataResponse<Laboratorio> GetAll()
        {
            LaboratorioDAL laboratorioDAL = new LaboratorioDAL();
            DataResponse<Laboratorio> dataResponse = laboratorioDAL.GetAll();
            if (dataResponse.HasSuccess)
            {
                return new DataResponse<Laboratorio>(dataResponse.Message, true, dataResponse.Dados);
            }
            else
            {
                return new DataResponse<Laboratorio>(dataResponse.Message, dataResponse.HasSuccess, null);
            }
        }
    }
}
