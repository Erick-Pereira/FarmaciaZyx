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
        private Normatization normatization = new Normatization();
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
        public Response Validate(Cliente cliente)
        {
            StringBuilder erros = new StringBuilder();
            erros.AppendLine(stringValidator.ValidateNome(cliente.Nome));
            erros.AppendLine(stringValidator.ValidateCPF(cliente.CPF));
            erros.AppendLine(stringValidator.ValidateEmail(cliente.Email));
            erros.AppendLine(stringValidator.ValidateTelefone(cliente.Telefone1));
            erros.AppendLine(stringValidator.ValidateTelefone(cliente.Telefone2));
            erros.AppendLine(ValidateRG(cliente.RG));
            if (string.IsNullOrWhiteSpace(erros.ToString().Trim()))
            {
                return new Response(erros.ToString(), true);
            }
            return new Response(erros.ToString().Trim(), false);
        }
    }
}