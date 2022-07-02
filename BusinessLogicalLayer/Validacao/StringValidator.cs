using System.Text.RegularExpressions;

namespace BusinessLogicalLayer
{
    public class StringValidator
    {
        //private const int MAXIMO_CARACTERES_NOME = 100;

        /// <summary>
        /// Verifica algumas regras para o nome, como:
        /// 1)Apenas alfabeto romano
        /// 2)Apenas um espaço entre nome e sobrenome
        /// 3)Mínimo de 3 caracteres
        /// 4)Mínimo de 2 entre nome e sobrenome
        /// </summary>
        /// <param name="nome">Nome a ser validado</param>
        /// <returns>Retorna vazio "" caso o nome esteja correto</returns>
        public string ValidateNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                return "Nome deve ser informado.";
            }
            //Trim -> Remove espaços em branco do começo e do fim da string (mas não do meio)
            nome = nome.Trim();
            //Função que remove os espaços extra entre as strings (deixando apenas um)
            nome = Regex.Replace(nome, @"\s+", " ");
            if (nome.Length < 3)
            {
                return "Nome deve conter no mínimo 3 caracteres.";
            }
            string[] nomes = nome.Split(" ");
            if (nomes.Length <= 1)
            {
                return "Nome completo deve ser informado.";
            }
            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i].Length < 2)
                {
                    return "Nome/Sobrenome deve possuir ao menos 2 caractere.";
                }
            }
            string regex = @"^[a-zA-Záâãéêíïóõôüúç ÁÂÃÉÊÍÏÓÔÜÚÇ]+$";
            if (!Regex.IsMatch(nome, regex))
            {
                return "Nome deve conter apenas caracteres do alfabeto romano.";
            }
            if (nome.Length > 100)
            {
                return "Nome não pode conter mais que 100 caracteres.";
            }
            return "";
        }

        /// <summary>
        /// Executa validação de CPF utilizando as regras disponibilizadas pela Receita Federal
        /// </summary>
        /// <param name="cpf">Cpf a ser validado</param>
        /// <returns>Retorna "" se o CPF está válido, caso contrário retorna a mensagem de erro</returns>
        public string ValidateCPF(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
            {
                return "CPF deve ser informado.";
            }

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return "CPF deve conter 11 caracteres";
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            bool ehValido = cpf.EndsWith(digito);
            if (!ehValido)
            {
                return "CPF com formato inválido.";
            }
            return "";
        }

        /// <summary>
        /// Verifica se o Email esta dentro dos padrões
        /// </summary>
        /// <param name="email">Senha a ser validada</param>
        /// <returns>Retorna vazio "" caso o Email esteja correto</returns>
        public string ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return "Email deve ser informado.";
            }

            email = email.Trim();

            if (email.Length < 5)
            {
                return "Email não pode conter menos que 5 caracteres.";
            }

            if (email.Length > 100)
            {
                return "Email não pode conter mais que 100 caracteres.";
            }

            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (!Regex.IsMatch(email, pattern))
            {
                return "Email inválido.";
            }
            return "";
        }

        /// <summary>
        /// Verifica se o CEP esta dentro dos padrões
        /// </summary>
        /// <param name="cep">Senha a ser validada</param>
        /// <returns>Retorna vazio "" caso o CEP esteja correto</returns>
        public string ValidateCEP(string cep)
        {
            if (string.IsNullOrWhiteSpace(cep))
            {
                return "CEP deve ser informado.";
            }
            cep = cep.Trim();
            cep = cep.Replace("-", "").Replace(".", "");

            if (cep.Length != 8)
            {
                return "CEP deve conter 8 dígitos (sem considerar hífen/ponto).";
            }
            int temp = 0;
            if (!int.TryParse(cep, out temp))
            {
                return "CEP em formato incorreto.";
            }
            return "";
        }
        /// <summary>
        /// Verifica se o telefone esta dentro dos padrões
        /// </summary>
        /// <param name="telefone">Senha a ser validada</param>
        /// <returns>Retorna vazio "" caso o telefone esteja correto</returns>
        public string ValidateTelefone(string telefone)
        {
            if (string.IsNullOrWhiteSpace(telefone))
            {
                return "Telefone deve ser informado.";
            }
            telefone = telefone.Trim();
            telefone = telefone.Replace("(", "")
                               .Replace(")", "")
                               .Replace("-", "")
                               .Replace(" ", "")
                               .Replace(".", "")
                               .Replace("+", "");
            if (telefone.Length != 8 && telefone.Length != 9 && telefone.Length != 11 && telefone.Length != 13)
            {
                return "Telefone deve conter 8, 9, 11 ou 13 dígitos.";
            }
            long temp;
            if (!long.TryParse(telefone, out temp))
            {
                return "Telefone inválido.";
            }
            return "";
        }
        /// <summary>
        /// Verifica se a senha esta dentro dos padrões
        /// </summary>
        /// <param name="senha">Senha a ser validada</param>
        /// <returns>Retorna vazio "" caso a senha esteja correta</returns>
        public string ValidateSenha(string senha)
        {
            if (string.IsNullOrWhiteSpace(senha))
            {
                return "Senha deve ser informado.";
            }
            if (senha.Contains(" "))
            {
                return "Senha não deve conter espaço.";
            }
            if (senha.Length < 8)
            {
                return "Senha deve conter no mínimo 8 caracteres.";
            }
            if (senha.Length > 20)
            {
                return "senha não pode conter mais que 20 caracteres.";
            }
            return "";
        }
        public string ValidateIfSenha1EqualsToSenha2(string senha1, string senha2)
        {
            if (senha1 != senha2)
            {
                return "Senhas não correspondem";
            }
            return "";
        }
    }
}
