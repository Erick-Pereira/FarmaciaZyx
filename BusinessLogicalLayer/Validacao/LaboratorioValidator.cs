using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    internal class LaboratorioValidator
    {
        /// <summary>
        /// Verifica se o laboratorio esta vazio ou se é apenas espaços em branco
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>Retorna uma string contendo o erro, "" se não houver erro</returns>
        private string ValidateLaboratorio(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                return "Laboratorio deve ser informado.";
            }
            return "";
        }
        public Response Validate(Laboratorio laboratorio)
        {
            StringBuilder erros = new StringBuilder();
            StringValidator stringValidator = new StringValidator();
            erros.AppendLine(ValidateLaboratorio(laboratorio.Nome));
            if (string.IsNullOrWhiteSpace(erros.ToString().Trim()))
            {
                return new Response(erros.ToString(), true);
            }
            return new Response(erros.ToString().Trim(), false);
        }
    }
}
