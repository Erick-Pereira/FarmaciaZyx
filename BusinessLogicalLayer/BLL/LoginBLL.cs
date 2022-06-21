using DataAccessLayer;
using Entities;
using Shared;
using System.Text;

namespace BusinessLogicalLayer
{
    public class LoginBLL
    {
        /// <summary>
        /// Faz as validações do login, se email existir no banco de dados, verifica se a senha é a mesma.
        /// Se for, o login é efetuado.
        /// </summary>
        /// <param name="login"></param>
        /// <returns>SingleResponse<Funcionario></returns>
        public SingleResponse<Funcionario> Logar(Login login)
        {
            LoginDAL loginDAL = new LoginDAL();
            LoginValidator loginValidator = new LoginValidator();
            Response response = loginValidator.Validate(login);
            if (response.HasSuccess)
            {
                SingleResponse<Funcionario> singleResponse = loginDAL.GetByEmail(login.Email);
                if (singleResponse.HasSuccess)
                {
                    if (login.Senha == singleResponse.Item.Senha)
                    {
                        return new SingleResponse<Funcionario>("Login efetuado com sucesso", true, singleResponse.Item);
                    }
                    return new SingleResponse<Funcionario>("Email ou senha esta incorreto", false, singleResponse.Item);
                }
                return new SingleResponse<Funcionario>("Email ou senha esta incorreto", false, singleResponse.Item);
            }
                return new SingleResponse<Funcionario>(response.Message, false, null);
        }

    }
}
