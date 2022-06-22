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

        public Response Validate(Cliente cliente)
        {
            StringBuilder erros = new StringBuilder();
            erros.AppendLine(stringValidator.ValidateNome(cliente.Nome));
            erros.AppendLine(stringValidator.ValidateCPF(cliente.CPF));
            erros.AppendLine(stringValidator.ValidateEmail(cliente.Email));
            erros.AppendLine(stringValidator.ValidateTelefone(cliente.Telefone1));
            erros.AppendLine(stringValidator.ValidateTelefone(cliente.Telefone2));
            //cliente.Nome = (normatization.NormatizeName(cliente.Nome));
            //Sintaxe cliente.Endereco?.CEP verifica e só passaria o CEP informado caso a propriedade
            //Endereco de dentro do Cliente não seja nula, caso contrário, passará o valor padrão do CEP (que é uma string e vale null!)
            if (string.IsNullOrWhiteSpace(erros.ToString().Trim()))
            {
                return new Response(erros.ToString(), true);
            }
            return new Response(erros.ToString().Trim(), false);
        }
    }
}