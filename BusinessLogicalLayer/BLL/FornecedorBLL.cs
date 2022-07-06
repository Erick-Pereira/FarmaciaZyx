using DataAccessLayer;
using Entities;
using Shared;

namespace BusinessLogicalLayer
{
    public class FornecedorBLL : ICRUD<Fornecedor>
    {
        private FornecedorDAL fornecedorDAL = new FornecedorDAL();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Response Delete(int id)
        {
            return fornecedorDAL.Delete(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataResponse<Fornecedor> GetAll()
        {
            return fornecedorDAL.GetAll();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SingleResponse<Fornecedor> GetByID(int id)
        {
            return fornecedorDAL.GetByID(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Response Update(Fornecedor item)
        {
            return fornecedorDAL.Update(item);
        }
    }
}
