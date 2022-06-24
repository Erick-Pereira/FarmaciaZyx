using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Laboratorio
    {
        public Laboratorio()
        {
        }

        public Laboratorio(string nome, string cNPJ)
        {
            Nome = nome;
            CNPJ = cNPJ;
        }

        public Laboratorio(int iD, string nome, string cNPJ)
        {
            ID = iD;
            Nome = nome;
            CNPJ = cNPJ;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
    }
}
