using DataAccessLayer;
using Entities;
using Shared;

namespace BusinessLogicalLayer
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
            FornecedorValidator produtoValidator = new FornecedorValidator();
            Response response = produtoValidator.Validate(item);
            if (response.HasSuccess)
            {
                return fornecedorDAL.Insert(item);
            }
            return new Response(response.Message, false);
            
        }

        public Response Update(Fornecedor item)
        {
            return fornecedorDAL.Update(item);
        }
    }
}
