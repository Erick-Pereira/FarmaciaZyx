using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProdutoView
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Laboratorio { get; set; }
        public double QtdEstoque { get; set; }
        public string TipoUnidade { get; set; }
        public double Valor { get; set; }
    }
}
