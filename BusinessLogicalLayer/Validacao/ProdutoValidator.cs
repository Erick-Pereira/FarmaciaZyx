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

        private string ValidateUnidade(Produto produto)
        {
            int conversao = 0;
            if(produto.TipoUnidadeId == 1)
            {
                if(int.TryParse(produto.QtdEstoque.ToString(), out conversao))
                {
                    return "";
                }
                return "Quantidade em estoque não compativel com Unidade";
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
        /// Recebe um produto e faz as validações
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="descricao"></param>
        /// <param name="laboratorio"></param>
        /// <returns>Retorna um response com uma string vazia e boolean true caso tudo esteja certo</returns>
        public Response Validate(Produto produto)
        {
            StringBuilder erros = new StringBuilder();
            erros.AppendLine(ValidateNome(produto.Nome));
            erros.AppendLine(ValidateDescricao(produto.Descricao));
            erros.AppendLine(ValidateUnidade(produto));
            string erro = erros.ToString();

            //erros.AppendLine(ValidateLaboratorio(produto.LaboratorioId));
            if (string.IsNullOrWhiteSpace(erro))
            {
                return new Response(erro, true);
            }
            return new Response(erro, false);
        }
    }
}
