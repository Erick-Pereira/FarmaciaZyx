using DataAccessLayer;
using Entities;
using Shared;
using System.Text;

namespace BusinessLogicalLayer
{
    //Projeto (Assembly) > Namespace > classe

    public class ClienteValidator
    {
        private StringValidator stringValidator = new StringValidator();
        private DateTimeValidator dateTimeValidator = new DateTimeValidator();
        private ClienteDAL clienteDAL = new ClienteDAL();

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
        public Response Validate(Cliente cliente)
        {
            StringBuilder erros = new StringBuilder();
            erros.AppendLine(stringValidator.ValidateNome(cliente.Nome));
            erros.AppendLine(stringValidator.ValidateCPF(cliente.CPF));
            erros.AppendLine(stringValidator.ValidateEmail(cliente.Email));
            erros.AppendLine(stringValidator.ValidateTelefone(cliente.Telefone1));
            erros.AppendLine(stringValidator.ValidateTelefone(cliente.Telefone2));
            erros.AppendLine(ValidateAge(cliente.DataNascimento));

            erros.AppendLine(ValidateRG(cliente.RG));
            if (string.IsNullOrWhiteSpace(erros.ToString().Trim()))
            {
                return new Response(erros.ToString(), true);
            }
            return new Response(erros.ToString().Trim(), false);
        }
    }
}