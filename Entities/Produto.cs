namespace Entities
{
    public class Produto
    {
        public Produto()
        {
        }

        public Produto(string nome, string descricao, string laboratorio, double qtdEstoque)
        {
            Nome = nome;
            Descricao = descricao;
            Laboratorio = laboratorio;
            QtdEstoque = qtdEstoque;
        }

        public Produto(int iD, string nome, string descricao, string laboratorio, double qtdEstoque)
        {
            ID = iD;
            Nome = nome;
            Descricao = descricao;
            Laboratorio = laboratorio;
            QtdEstoque = qtdEstoque;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Laboratorio { get; set; }
        public double QtdEstoque { get; set; }
    }
}
