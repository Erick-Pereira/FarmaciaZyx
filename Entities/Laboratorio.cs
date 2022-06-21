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

        public Laboratorio(string nome)
        {
            Nome = nome;
        }

        public Laboratorio(int iD, string nome)
        {
            ID = iD;
            Nome = nome;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
    }
}
