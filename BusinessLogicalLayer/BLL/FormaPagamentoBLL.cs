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
    public class FormaPagamentoBLL
    {
        FormaPagamentoDAL formaPagamentoDAL = new FormaPagamentoDAL();
        public DataResponse<FormaPagamento> GetAll()
        {
            DataResponse<FormaPagamento> dataResponse = formaPagamentoDAL.GetAll();
            if (dataResponse.HasSuccess)
            {
                return new DataResponse<FormaPagamento>(dataResponse.Message, true, dataResponse.Dados);
            }
            else
            {
                return new DataResponse<FormaPagamento>(dataResponse.Message, dataResponse.HasSuccess, null);
            }
        }

        public SingleResponse<FormaPagamento> GetById(int id)
        {
            SingleResponse<FormaPagamento> singleResponse = formaPagamentoDAL.GetByID(id);
            if (singleResponse.HasSuccess)
            {
                return new SingleResponse<FormaPagamento>(singleResponse.Message, true, singleResponse.Item);
            }
            else
            {
                return new SingleResponse<FormaPagamento>(singleResponse.Message, singleResponse.HasSuccess, null);
            }
        }
    }
}
