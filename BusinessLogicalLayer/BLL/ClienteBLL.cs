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

        public SingleResponse<Cliente> GetByCPF(string cPF)
        {
            return clienteDAL.GetByCPF(cPF);
        }
        public Response Insert(Cliente item)
        {
            //NAO ESQUEÇAM DAS VALIDAÇÕES!
            //SE EXISTIREM NO OBJETO CLIENTE, RETORNAR ERROS!!
            //NÃO ACESSAR O DAL CASO O OBJETO CLIENTE ESTEJA INCORRETO!!!!
            ClienteValidator clienteValidator = new ClienteValidator();
            Response response = clienteValidator.Validate(item);
            if (response.HasSuccess)
            {
                return clienteDAL.Insert(item);
            }
            return new Response(response.Message, false);
        }
        public Response Update(Cliente item)
        {
            return clienteDAL.Update(item);
        }
        public Response WithdrawPontos(Cliente item)
        {
            item.Pontos = item.Pontos - 10;
            if(item.Pontos < 0)
            {
                item.Pontos = 0;
            }
            return clienteDAL.UpdatePontos(item);
        }
        public Response GivePontos(Cliente item, double Valor)
        {
            int pontos = (int)Valor / 10;
            item.Pontos += pontos;
            return clienteDAL.UpdatePontos(item);
        }
        public double VerifyIfHasDesconto(Cliente cliente)
        {
            if(cliente.Pontos >= 10)
            {
                return 10;
            }
            return 0;
        }
    }
}