using DataAccessLayer;
using Entities;
using Shared;
using System.Text;

namespace BusinessLogicalLayer
{
    public class LoginBLL
    {
        public string Validate(string email, string senha)
        {
            StringBuilder erros = new StringBuilder();
            StringValidator stringValidator = new StringValidator();
            erros.AppendLine(stringValidator.ValidateEmail(email));
            erros.AppendLine(stringValidator.ValidateSenha(senha));
            return erros.ToString();
        }
        public SingleResponse<Funcionario> Logar(Login login)
        {
            LoginDAL loginDAL = new LoginDAL();
            SingleResponse<Funcionario> singleResponse = loginDAL.GetByEmail(login.Email);
            if (singleResponse.HasSuccess)
            {
                if (login.Senha == singleResponse.Item.Senha)
                {
                    return new SingleResponse<Funcionario>("Login efetuado com sucesso", true, singleResponse.Item);
                }
                return new SingleResponse<Funcionario>("Email ou senha esta incorreto", true, singleResponse.Item);
            }
            else
            {
                return new SingleResponse<Funcionario>(singleResponse.Message, singleResponse.HasSuccess, null);
            }
        }

    }
}
