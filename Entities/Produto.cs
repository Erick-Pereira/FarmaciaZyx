namespace Entities
{
    public class Produto
    {
        public Produto()
        {
        }

        public Produto(string nome, string descricao, int laboratorioId, double qtdEstoque)
        {
            Nome = nome;
            Descricao = descricao;
            LaboratorioId = laboratorioId;
            QtdEstoque = qtdEstoque;
        }

        public Produto(int iD, string nome, string descricao, int laboratorioId, double qtdEstoque)
        {
            ID = iD;
            Nome = nome;
            Descricao = descricao;
            LaboratorioId = laboratorioId;
            QtdEstoque = qtdEstoque;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int LaboratorioId { get; set; }
        public double QtdEstoque { get; set; }
    }
}
