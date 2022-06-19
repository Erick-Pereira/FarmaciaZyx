using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class ProdutoValidator
    {
        /// <summary>
        /// Verifica se o nome esta vazio ou se é apenas espaços em branco
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>Retorna uma string contendo o erro, "" se não houver erro</returns>
        private string ValidateNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                return "Nome deve ser informado.";
            }
            return "";
        }
        /// <summary>
        /// Verifica se a descrição esta vazia ou se é apenas espaços em branco
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>Retorna uma string contendo o erro, "" se não houver erro</returns>
        private string ValidateDescricao(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
            {
                return "Descrição deve ser informada.";
            }
            return "";
        }
        /// <summary>
        /// Verifica se o nome do laboratorio esta vazio ou se é apenas espaços em branco
        /// </summary>
        /// <param name="laboratorio"></param>
        /// <returns>Retorna uma string contendo o erro, "" se não houver erro</returns>
        private string ValidateLaboratorio(string laboratorio)
        {
            if (string.IsNullOrWhiteSpace(laboratorio))
            {
                return "Laboratorio deve ser informada.";
            }
            return "";
        }
        /// <summary>
        /// Faz a validação se tudo esta dentro dos padrões
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="descricao"></param>
        /// <param name="laboratorio"></param>
        /// <returns>Retorna uma string contendo os erros, "" se não houver erros</returns>
        public string Validate(string nome, string descricao, string laboratorio)
        {
            StringBuilder erros = new StringBuilder();
            erros.AppendLine(ValidateNome(nome));
            erros.AppendLine(ValidateDescricao(descricao));
            erros.AppendLine(ValidateLaboratorio(laboratorio));
            return erros.ToString();
        }
    }
}
