namespace Entities
{
    public class Produto
    {
        public Produto()
        {
        }

        public Produto(string nome, string descricao, int laboratorioId, double qtdEstoque, int tipoUnidadeId)
        {
            Nome = nome;
            Descricao = descricao;
            LaboratorioId = laboratorioId;
            QtdEstoque = qtdEstoque;
            TipoUnidadeId = tipoUnidadeId;
        }

        public Produto(int iD, string nome, string descricao, int laboratorioId, double qtdEstoque, int tipoUnidadeId)
        {
            ID = iD;
            Nome = nome;
            Descricao = descricao;
            LaboratorioId = laboratorioId;
            QtdEstoque = qtdEstoque;
            TipoUnidadeId = tipoUnidadeId;      
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int LaboratorioId { get; set; }
        public double QtdEstoque { get; set; }
        public int TipoUnidadeId { get; set; }
    }
}
