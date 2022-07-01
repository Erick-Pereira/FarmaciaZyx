namespace Entities
{
    public class Funcionario
    {
        public Funcionario()
        {
        }

        public Funcionario(int iD, string nome, string cPF, string rG, string telefone, string email, string senha, int enderecoId, int tipoFuncionarioId, int generoId, DateTime dataNascimento)
        {
            ID = iD;
            Nome = nome;
            CPF = cPF;
            RG = rG;
            Telefone = telefone;
            Email = email;
            Senha = senha;
            EnderecoId = enderecoId;
            TipoFuncionarioId = tipoFuncionarioId;
            GeneroId = generoId;
            DataNascimento = dataNascimento;
        }

        public Funcionario(string nome, string cPF, string rG, string telefone, string email, string senha, int enderecoId, int tipoFuncionarioId, int generoId, DateTime dataNascimento)
        {
            Nome = nome;
            CPF = cPF;
            RG = rG;
            Telefone = telefone;
            Email = email;
            Senha = senha;
            EnderecoId = enderecoId;
            TipoFuncionarioId = tipoFuncionarioId;
            GeneroId = generoId;
            DataNascimento = dataNascimento;
        }

        public Funcionario(string nome, string cPF, string rG, string telefone, string email, string senha, int tipoFuncionarioId, int generoId, DateTime dataNascimento)
        {
            Nome = nome;
            CPF = cPF;
            RG = rG;
            Telefone = telefone;
            Email = email;
            Senha = senha;
            TipoFuncionarioId = tipoFuncionarioId;
            GeneroId = generoId;
            DataNascimento = dataNascimento;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int EnderecoId { get; set; }
        public int TipoFuncionarioId { get; set; }
        public int GeneroId { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
