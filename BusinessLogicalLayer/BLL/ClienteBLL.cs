using DataAccessLayer;
using Entities;
using Shared;

namespace BusinessLogicalLayer
{
    public class ClienteBLL : ICRUD<Cliente>
    {
        private ClienteDAL clienteDAL = new ClienteDAL();

        public Response Delete(int id)
        {
            return clienteDAL.Delete(id);
        }

        public DataResponse<Cliente> GetAll()
        {
            return clienteDAL.GetAll();
        }

        public SingleResponse<Cliente> GetByID(int id)
        {
            return clienteDAL.GetByID(id);
        }

        public Response Insert(Cliente item)
        {
            //NAO ESQUEÇAM DAS VALIDAÇÕES!
            //SE EXISTIREM NO OBJETO CLIENTE, RETORNAR ERROS!!
            //NÃO ACESSAR O DAL CASO O OBJETO CLIENTE ESTEJA INCORRETO!!!!
            return clienteDAL.Insert(item);
        }

        public Response Update(Cliente item)
        {
            return clienteDAL.Update(item);
        }
    }
    //kkk
}