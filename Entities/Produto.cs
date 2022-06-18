namespace Entities
{
    public class Produto
    {
        public Produto()
        {
        }

        public Produto(int iD, string nome, string descricao, string laboratorio, string qtdEstoque)
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
        public string QtdEstoque { get; set; }
    }
}
