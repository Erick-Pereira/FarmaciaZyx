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
        private Normatization normatization = new Normatization();
        private FuncionarioDAL funcionarioDAL = new FuncionarioDAL();

        private string ValidateRG(string rG)
        {
            rG = rG.Replace(".", "");
            if (string.IsNullOrWhiteSpace(rG))
            {
                return "RG precisa ser informado";
            }
            if (stringValidator.validateRg(rG))
            {
                return "";
            }
            return "RG Invalido";
        }
        public Response Validate(Funcionario funcionario)
        {
            StringBuilder erros = new StringBuilder();

            erros.AppendLine(stringValidator.ValidateNome(funcionario.Nome));
            erros.AppendLine(stringValidator.ValidateCPF(funcionario.CPF));
            erros.AppendLine(stringValidator.ValidateEmail(funcionario.Email));
            erros.AppendLine(stringValidator.ValidateTelefone(funcionario.Telefone));
            erros.AppendLine(ValidateRG(funcionario.RG));
            if (string.IsNullOrWhiteSpace(erros.ToString().Trim()))
            {
                return new Response(erros.ToString().Trim(), true);
            }
            return new Response(erros.ToString().Trim(), false);
            //Se chegou aqui, validamos com sucesso!


        }

    }
}

