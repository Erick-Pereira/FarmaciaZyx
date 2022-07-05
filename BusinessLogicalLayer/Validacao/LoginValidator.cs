using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class LoginValidator
    {
        /// <summary>
        /// Verifica se o email esta vazio ou se é apenas espaços em branco
        /// </summary>
        /// <param name="senha"></param>
        /// <returns>string contendo o erro, "" se não houver erro</returns>
        private string ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return "Email deve ser informado.";
            }
            return "";
        }
        /// <summary>
        /// Verifica se a senha esta vazia ou se é apenas espaços em branco
        /// </summary>
        /// <param name="senha"></param>
        /// <returns>string contendo o erro, "" se não houver erro</returns>
        private string ValidateSenha(string senha)
        {
            if (string.IsNullOrWhiteSpace(senha))
            {
                return "Senha deve ser informado.";
            }
            return "";
        }
        /// <summary>
        /// Recebe um login e faz as validação
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns>Retorna um response com uma string vazia e boolean true caso tudo esteja certo</returns>
        public Response Validate(Login login)
        {
            StringBuilder erros = new StringBuilder();
            StringValidator stringValidator = new StringValidator();
            erros.AppendLine(ValidateEmail(login.Email));
            erros.AppendLine(ValidateSenha(login.Senha));
            string erro = Regex.Replace(erros.ToString(), @"\s+", "");

            if (string.IsNullOrWhiteSpace(erro))
            {
                return new Response(erro, true);
            }
            return new Response(erro, false);
        }
    }
}
