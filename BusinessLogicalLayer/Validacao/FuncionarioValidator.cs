using DataAccessLayer;
using Entities;
using Shared;
using System.Text;

namespace BusinessLogicalLayer
{
    public class FuncionarioValidator
    {
        private StringValidator stringValidator = new StringValidator();
        private DateTimeValidator dateTimeValidator = new DateTimeValidator();
        private FuncionarioDAL funcionarioDAL = new FuncionarioDAL();

        private string ValidateRG(string rG)
        {
            rG = rG.Replace(".", "");
            if (string.IsNullOrWhiteSpace(rG))
            {
                return "RG precisa ser informado";
            }
                return "";
        }
        private string ValidateAge(DateTime dataNascimento)
        {
            string data = dataNascimento.ToString();
            data = data.Replace("/", " ");
            if (!string.IsNullOrWhiteSpace(data))
            {
                if (16 > dateTimeValidator.CalculateAge(dataNascimento))
                {
                    return "Idade minima de 16 anos";
                }
                return "";
            }
            return "Data de nascimento deve ser informada";
        }
        public Response Validate(Funcionario funcionario)
        {
            StringBuilder erros = new StringBuilder();

            erros.AppendLine(stringValidator.ValidateNome(funcionario.Nome));
            erros.AppendLine(stringValidator.ValidateCPF(funcionario.CPF));
            erros.AppendLine(stringValidator.ValidateEmail(funcionario.Email));
            erros.AppendLine(stringValidator.ValidateTelefone(funcionario.Telefone));
            erros.AppendLine(ValidateRG(funcionario.RG));
            erros.AppendLine(ValidateAge(funcionario.DataNascimento));
            if (string.IsNullOrWhiteSpace(erros.ToString().Trim()))
            {
                return new Response(erros.ToString().Trim(), true);
            }
            return new Response(erros.ToString().Trim(), false);
        }

    }
}

