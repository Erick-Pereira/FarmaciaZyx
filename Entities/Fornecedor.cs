namespace Entities
{
    public class Fornecedor
    {
        public Fornecedor()
        {
        }

        public Fornecedor(int iD, string razaoSocial, string cNPJ, string nomeContato, string telefone, string email)
        {
            ID = iD;
            RazaoSocial = razaoSocial;
            CNPJ = cNPJ;
            NomeContato = nomeContato;
            Telefone = telefone;
            Email = email;
        }

        public int ID { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string NomeContato { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
