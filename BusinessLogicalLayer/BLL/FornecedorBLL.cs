using DataAccessLayer;
using Entities;
using Shared;

namespace BusinessLogicalLayer
{
    public class FornecedorBLL : ICRUD<Fornecedor>
    {
        private FornecedorDAL fornecedorDAL = new FornecedorDAL();
        /// <summary>
        /// Recebe um ID e instancia o metodo Delete do FornecedorDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Delete(int id)
        {
            return fornecedorDAL.Delete(id);
        }
        /// <summary>
        /// Instancia o metodo GetAll do FornecedorDAL
        /// </summary>
        /// <returns>Retorna um DataResponse contendo todos os Fornecedores cadastrados no banco de dados</returns>
        public DataResponse<Fornecedor> GetAll()
        {
            return fornecedorDAL.GetAll();
        }
        /// <summary>
        /// Recebe um ID e instancia o metodo GetByID do FornecedorDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um SingleResponse contendo um Fornecedor referente ao ID informado</returns>
        public SingleResponse<Fornecedor> GetByID(int id)
        {
            return fornecedorDAL.GetByID(id);
        }
        /// <summary>
        /// Recebe um Fornecedor e instancia o metodo Insert do FornecedorDAL
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Insert(Fornecedor item)
        {
            FornecedorValidator produtoValidator = new FornecedorValidator();
            Response response = produtoValidator.Validate(item);
            if (response.HasSuccess)
            {
                return fornecedorDAL.Insert(item);
            }
            return new Response(response.Message, false);
            
        }
        /// <summary>
        /// Recebe um Fornecedor e instancia o metodo Update do FornecedorDAL
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Update(Fornecedor item)
        {
            return fornecedorDAL.Update(item);
        }
    }
}
