using DataAccessLayer;
using Entities;
using Entities.Filters;
using Shared;

namespace BusinessLogicalLayer
{
    public class ClienteBLL : ICRUD<Cliente>
    {
        private ClienteDAL clienteDAL = new ClienteDAL();
        /// <summary>
        /// Recebe um ID e instancia o metodo Delete do ClienteDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Delete(int id)
        {
            return clienteDAL.Delete(id);
        }
        /// <summary>
        /// Instancia o metedo GetAll do ClienteDAL
        /// </summary>
        /// <returns>Retorna um DataResponse contendo todos os Clientes cadastrados no banco de dados</returns>
        public DataResponse<Cliente> GetAll()
        {
            return clienteDAL.GetAll();
        }
        /// <summary>
        /// Instancia o metedo GetAll do ClienteDAL
        /// </summary>
        /// <returns>Retorna um DataResponse contendo todos os Clientes cadastrados no banco de dados</returns>
        public DataResponse<ClienteView> GetAllClienteView()
        {
            return clienteDAL.GetAllClienteView();
        }
        /// <summary>
        /// Recebe um ID e instancia o metodo GetById do ClienteDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um SingleResponse contendo o Cliente referente ao ID informado</returns>
        public SingleResponse<Cliente> GetByID(int id)
        {
            return clienteDAL.GetByID(id);
        }
        /// <summary>
        /// Recebe uma string contendo um CPF e instancia o metodo GetByCPF do ClienteDAL
        /// </summary>
        /// <param name="cPF"></param>
        /// <returns>Retorna um SingleResponse contendo o Cliente refente ao CPF informado</returns>
        public SingleResponse<Cliente> GetByCPF(string cPF)
        {
            return clienteDAL.GetByCPF(cPF);
        }
        /// <summary>
        /// Recebe um Cliente, valida e instancia o metodo Insert do ClienteDAL
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Insert(Cliente item)
        {
            ClienteValidator clienteValidator = new ClienteValidator();
            Response response = clienteValidator.Validate(item);
            if (response.HasSuccess)
            {
                return clienteDAL.Insert(item);
            }
            return new Response(response.Message, false);
        }
        /// <summary>
        /// Recebe um Cliente e instancia o metodo Update do ClienteDAL
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Update(Cliente item)
        {
            return clienteDAL.Update(item);
        }
        /// <summary>
        /// Recebe um Cliente e instancia o metodo UpdatePontos do ClienteDAL
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response WithdrawPontos(Cliente item)
        {
            item.Pontos = item.Pontos - 10;
            if(item.Pontos < 0)
            {
                item.Pontos = 0;
            }
            return clienteDAL.UpdatePontos(item);
        }
        /// <summary>
        /// Recebe um Cliente e o Valor da compra, calcula quantos pontos o cliente ganhou,
        /// depois instancia o metodo UpdatePontos do ClienteDAL
        /// </summary>
        /// <param name="item"></param>
        /// <param name="Valor"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response GivePontos(Cliente item, double Valor)
        {
            int pontos = (int)Valor / 10;
            item.Pontos += pontos;
            return clienteDAL.UpdatePontos(item);
        }
        /// <summary>
        /// Recebe um Cliente e verifica se o Cliente tem mais de 10 Pontos
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>retorna um Double contendo a porcentagem maxima de desconto que o cliente pode ter</returns>
        public double VerifyIfHasDesconto(Cliente cliente)
        {
            if(cliente.Pontos >= 10)
            {
                return 10;
            }
            return 0;
        }
        /// <summary>
        /// Recebe um FilterCPF e instancia o metodo GetOnlyByCpf do ClienteDAL
        /// </summary>
        /// <param name="cPF"></param>
        /// <returns>Retorna um SingleResponse contendo o cliente referente ao CPF informado</returns>
        public SingleResponse<ClienteView> GetOnlyByCpf(FilterCPF cPF)
        {
            return clienteDAL.GetOnlyByCpf(cPF);
        }
    }
}