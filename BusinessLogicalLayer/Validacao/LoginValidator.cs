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
        /// Verifica se a senha esta vazia ou se é apenas espaços em branco
        /// </summary>
        /// <param name="senha"></param>
        /// <returns>string contendo o erro, "" se não houver erro</returns>
        public string ValidateSenha(string senha)
        {
            if (string.IsNullOrWhiteSpace(senha))
            {
                return "Senha deve ser informado.";
            }
            //Se chegou aqui, o nome ta certinho e retornamos "";
            return "";
        }
        /// <summary>
        /// Faz as validações
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns>string contendo os erros, "" se não houver erros</returns>
        public string Validate(string email, string senha)
        {
            StringBuilder erros = new StringBuilder();
            StringValidator stringValidator = new StringValidator();
            erros.AppendLine(stringValidator.ValidateEmail(email));
            erros.AppendLine(ValidateSenha(senha));
            return erros.ToString();
        }
    }
}
