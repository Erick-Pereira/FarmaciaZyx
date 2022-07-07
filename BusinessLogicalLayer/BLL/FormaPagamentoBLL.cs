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
        /// <summary>
        /// Instancia o metodo GetAll do FormaPagamentoDAL
        /// </summary>
        /// <returns>Retorna um DataResponse contendo todas as Formas de Pagamento cadastradas no banco de dados</returns>
        public DataResponse<FormaPagamento> GetAll()
        {
            return formaPagamentoDAL.GetAll();
        }
        /// <summary>
        /// Recebe um ID e instancia o metodo GetById
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um SingleResponse contendo uma Forma de pagamento referente ao ID informado</returns>
        public SingleResponse<FormaPagamento> GetById(int id)
        {
            return formaPagamentoDAL.GetByID(id);
        }
    }
}
