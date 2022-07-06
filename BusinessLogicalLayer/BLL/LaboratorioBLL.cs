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
    public class LaboratorioBLL:ICRUD<Laboratorio>
    {
        LaboratorioDAL laboratorioDAL = new LaboratorioDAL();
        /// <summary>
        /// Recebe um laboratorio, faz validações e instancia o metodo Insert do LaboratorioDAL
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
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
        /// <summary>
        /// Instancia o metodo GetAll do LaboratorioDAL
        /// </summary>
        /// <returns>Retorna um DataResponse contendo todos os Laboratorios cadastrados no banco de dados</returns>
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
        /// <summary>
        /// Recebe um ID e instancia o metodo GetByID do LaboratorioDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um SingleResponse contendo o Laboratorio referente ao Id informado</returns>
        public SingleResponse<Laboratorio> GetByID(int id)
        {
            
            SingleResponse<Laboratorio> singleResponse = laboratorioDAL.GetByID(id);
            if (singleResponse.HasSuccess)
            {
                return new SingleResponse<Laboratorio>(singleResponse.Message, true, singleResponse.Item);
            }
            else
            {
                return new SingleResponse<Laboratorio>(singleResponse.Message, singleResponse.HasSuccess, null);
            }
        }
        /// <summary>
        /// Recebe um Laboratorio e instancia o metodo Update do LaboratorioDAL
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Update(Laboratorio item)
        {
            return laboratorioDAL.Update(item);
        }
        /// <summary>
        /// Recebe um ID e instancia o metodo Delete do LaboratorioDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Delete(int id)
        {
            return laboratorioDAL.Delete(id);
        }
    }
}
