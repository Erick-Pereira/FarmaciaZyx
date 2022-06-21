using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        /// Faz as validações
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns>string contendo os erros, "" se não houver erros</returns>
        public Response Validate(Login login)
        {
            StringBuilder erros = new StringBuilder();
            StringValidator stringValidator = new StringValidator();
            erros.AppendLine(ValidateEmail(login.Email));
            erros.AppendLine(ValidateSenha(login.Senha));
            if (string.IsNullOrWhiteSpace(erros.ToString().Trim()))
            {
                return new Response(erros.ToString(), true);
            }
            return new Response(erros.ToString().Trim(), false);
        }
    }
}
