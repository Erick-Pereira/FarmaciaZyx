namespace Entities
{
    public class Endereco
    {
        public Endereco()
        {
        }

        public Endereco(int iD, string cEP, string logradouro, string numeroCasa, int bairroID)
        {
            ID = iD;
            CEP = cEP;
            Logradouro = logradouro;
            NumeroCasa = numeroCasa;
            BairroID = bairroID;
        }

        public int ID { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string NumeroCasa { get; set; }
        public int BairroID { get; set; }
    }
}
