namespace Entities
{
    public class Cidade
    {
        public Cidade()
        {
        }

        public Cidade(string nomeCidade, int estadoId)
        {
            NomeCidade = nomeCidade;
            EstadoId = estadoId;
        }

        public Cidade(int iD, string nomeCidade, int estadoId)
        {
            ID = iD;
            NomeCidade = nomeCidade;
            EstadoId = estadoId;
        }

        public int ID { get; set; }
        public string NomeCidade { get; set; }
        public int EstadoId { get; set; }
    }
}
