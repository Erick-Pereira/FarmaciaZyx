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
        LaboratorioDAL laboratorioDAL = new LaboratorioDAL();
        public Response Insert(Laboratorio item)
        {
            LaboratorioValidator laboratorioValidator = new LaboratorioValidator();
            Response response = laboratorioValidator.Validate(item);
            if (response.HasSuccess)
            {
                return laboratorioDAL.Insert(item);
            }
            return new Response(response.Message, false);
        }
        public DataResponse<Laboratorio> GetAll()
        {
           
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
