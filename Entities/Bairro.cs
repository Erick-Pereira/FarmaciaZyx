namespace Entities
{
    public class Bairro
    {
        public Bairro()
        {
        }

        public Bairro(string nomeBairro)
        {
            NomeBairro = nomeBairro;
        }

        public Bairro(string nomeBairro, int cidadeId)
        {
            NomeBairro = nomeBairro;
            CidadeId = cidadeId;
        }

        public Bairro(int iD, string nomeBairro, int cidadeId)
        {
            ID = iD;
            NomeBairro = nomeBairro;
            CidadeId = cidadeId;
        }

        public int ID { get; set; }
        public string NomeBairro { get; set; }
        public int CidadeId { get; set; }
    }
}
