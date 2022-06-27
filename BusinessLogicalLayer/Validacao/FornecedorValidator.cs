using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class FornecedorValidator
    {
        StringValidator stringValidator = new StringValidator();
        /// <summary>
        /// Verifica se o nome esta vazio ou se é apenas espaços em branco
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>Retorna uma string contendo o erro, "" se não houver erro</returns>
        private string ValidateRazaoSocial(string razaoSocial)
        {
            if (string.IsNullOrWhiteSpace(razaoSocial))
            {
                return "Nome deve ser informado.";
            }
            return "";
        }
        internal static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

        internal string ValidateCNPJ(string cnpj)
        {
            if (string.IsNullOrWhiteSpace(cnpj))
            {
                return "CNPJ deve ser informado.";
            }
            if (IsCnpj(cnpj))
            {
                return "";
            }
            return "CNPJ invalido.";
        }
        /// <summary>
        /// Verifica se o nome para contato esta vazio ou se é apenas espaços em branco
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>Retorna uma string contendo o erro, "" se não houver erro</returns>
        private string ValidateNomeContato(string nomeContato)
        {
            if (string.IsNullOrWhiteSpace(nomeContato))
            {
                return "Nome para contato deve ser informado.";
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
        public Response Validate(Fornecedor fornecedor)
        {
            StringBuilder erros = new StringBuilder();
            erros.AppendLine(ValidateRazaoSocial(fornecedor.RazaoSocial));
            erros.AppendLine(ValidateCNPJ(fornecedor.CNPJ));
            erros.AppendLine(stringValidator.ValidateEmail(fornecedor.Email));
            erros.AppendLine(ValidateNomeContato(fornecedor.NomeContato));
            erros.AppendLine(stringValidator.ValidateTelefone(fornecedor.Telefone));

            //erros.AppendLine(ValidateLaboratorio(produto.LaboratorioId));
            if (string.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString().Trim(), true);
            }
            return new Response(erros.ToString().Trim(), false);
        }
    }
}

