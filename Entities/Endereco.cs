namespace Entities
{
    public class Endereco
    {
        public Endereco()
        {
        }

        public Endereco(string cEP, string numeroCasa, string rua, string complemento)
        {
            CEP = cEP;
            NumeroCasa = numeroCasa;
            Rua = rua;
            Complemento = complemento;
        }

        public Endereco(string cEP, string numeroCasa, int bairroID, string rua, string complemento)
        {
            CEP = cEP;
            NumeroCasa = numeroCasa;
            BairroID = bairroID;
            Rua = rua;
            Complemento = complemento;
        }

        public Endereco(int iD, string cEP, string numeroCasa, int bairroID, string rua, string complemento)
        {
            ID = iD;
            CEP = cEP;
            NumeroCasa = numeroCasa;
            BairroID = bairroID;
            Rua = rua;
            Complemento = complemento;
        }

        public int ID { get; set; }
        public string CEP { get; set; }
        public string NumeroCasa { get; set; }
        public int BairroID { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
    }
}
