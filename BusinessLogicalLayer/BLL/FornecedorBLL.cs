using DataAccessLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BLL
{
    public class FornecedorBLL : ICRUD<Fornecedor>
    {
        private FornecedorDAL fornecedorDAL = new FornecedorDAL();

        public Response Delete(int id)
        {
            return fornecedorDAL.Delete(id);
        }

        public DataResponse<Fornecedor> GetAll()
        {
            return fornecedorDAL.GetAll();
        }

        public SingleResponse<Fornecedor> GetByID(int id)
        {
            return fornecedorDAL.GetByID(id);
        }

        public Response Insert(Fornecedor item)
        {
            //NAO ESQUEÇAM DAS VALIDAÇÕES!
            //SE EXISTIREM NO OBJETO CLIENTE, RETORNAR ERROS!!
            //NÃO ACESSAR O DAL CASO O OBJETO CLIENTE ESTEJA INCORRETO!!!!
            return fornecedorDAL.Insert(item);
        }

        public Response Update(Fornecedor item)
        {
            return fornecedorDAL.Update(item);
        }
    }
}
