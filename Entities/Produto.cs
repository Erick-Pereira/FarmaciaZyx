namespace Entities
{
    public class Produto
    {
        public Produto()
        {
        }

        public Produto(string nome, string descricao, int laboratorioId, int tipoUnidadeId, double valor)
        {
            Nome = nome;
            Descricao = descricao;
            LaboratorioId = laboratorioId;
            TipoUnidadeId = tipoUnidadeId;
            Valor = valor;
        }

        public Produto(string nome, string descricao, int laboratorioId, double qtdEstoque, int tipoUnidadeId, double valor)
        {
            Nome = nome;
            Descricao = descricao;
            LaboratorioId = laboratorioId;
            QtdEstoque = qtdEstoque;
            TipoUnidadeId = tipoUnidadeId;
            Valor = valor;
        }

        public Produto(int iD, string nome, string descricao, int laboratorioId, double qtdEstoque, int tipoUnidadeId, double valor)
        {
            ID = iD;
            Nome = nome;
            Descricao = descricao;
            LaboratorioId = laboratorioId;
            QtdEstoque = qtdEstoque;
            TipoUnidadeId = tipoUnidadeId;
            Valor = valor;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int LaboratorioId { get; set; }
        public double QtdEstoque { get; set; }
        public int TipoUnidadeId { get; set; }
        public double Valor { get; set; }
    }
}
