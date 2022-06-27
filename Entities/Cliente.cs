namespace Entities
{
    public class Cliente
    {
        public Cliente()
        {
        }

        public Cliente(int iD, string nome, string rG, string cPF, string telefone1, string telefone2, string email, int pontos, int tipoClienteId, int generoId, DateTime dataNascimento)
        {
            ID = iD;
            Nome = nome;
            RG = rG;
            CPF = cPF;
            Telefone1 = telefone1;
            Telefone2 = telefone2;
            Email = email;
            Pontos = pontos;
            TipoClienteId = tipoClienteId;
            GeneroId = generoId;
            DataNascimento = dataNascimento;
        }

        public Cliente(string nome, string rG, string cPF, string telefone1, string telefone2, string email, int pontos, int tipoClienteId, int generoId, DateTime dataNascimento)
        {
            Nome = nome;
            RG = rG;
            CPF = cPF;
            Telefone1 = telefone1;
            Telefone2 = telefone2;
            Email = email;
            Pontos = pontos;
            TipoClienteId = tipoClienteId;
            GeneroId = generoId;
            DataNascimento = dataNascimento;
        }

        public Cliente(string nome, string rG, string cPF, string telefone1, string telefone2, string email, int tipoClienteId, int generoId, DateTime dataNascimento)
        {
            Nome = nome;
            RG = rG;
            CPF = cPF;
            Telefone1 = telefone1;
            Telefone2 = telefone2;
            Email = email;
            TipoClienteId = tipoClienteId;
            GeneroId = generoId;
            DataNascimento = dataNascimento;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }
        public int Pontos { get; set; }
        public int TipoClienteId { get; set; }
        public int GeneroId { get;set; }
        public DateTime DataNascimento { get; set; }
    }
}
