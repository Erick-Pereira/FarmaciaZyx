using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Generos
    {
        public string Nome { get; set; }
        public int ID { get; set; }

        public Generos(string nome, int iD)
        {
            Nome = nome;
            ID = iD;
        }
        public Generos()
        {

        }
    }
}
