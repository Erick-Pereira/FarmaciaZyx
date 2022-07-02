using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ClienteView
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }
        public int Pontos { get; set; }
        public string TipoCliente { get; set; }
        public string Genero { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
