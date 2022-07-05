using DataAccessLayer;
using Entities;
using Shared;
using System.Text;
using System.Text.RegularExpressions;

namespace BusinessLogicalLayer
{
    //Projeto (Assembly) > Namespace > classe

    public class ClienteValidator
    {
        private StringValidator stringValidator = new StringValidator();
        private DateTimeValidator dateTimeValidator = new DateTimeValidator();

        /// <summary>
        /// Verifica se o RG foi informado
        /// </summary>
        /// <param name="rG"></param>
        /// <returns>Retorna vazio "" se o RG foi informado</returns>
        private string ValidateRG(string rG)
        {
            rG = rG.Replace(".", "");
            if (string.IsNullOrWhiteSpace(rG))
            {
                return "RG precisa ser informado";
            }
            return "";
        }
        /// <summary>
        /// Recebe data de nascimento e verifica se a pessoa é maior do que a idade minima
        /// </summary>
        /// <param name="dataNascimento"></param>
        /// <returns>Retorna vazio "" se estiver tudo certo</returns>
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
        /// <summary>
        /// Valida o Cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>Retorna um response com uma string vazia e boolean true caso tudo esteja certo</returns>
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
            string erro = Regex.Replace(erros.ToString(), @"\s+", "");

            if (string.IsNullOrWhiteSpace(erro))
            {
                return new Response(erro, true);
            }
            return new Response(erro, false);
        }
    }
}