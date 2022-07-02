using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntradaView
    {
        public int ID { get; set; }
        public DateTime DataEntrada { get; set; }
        public double Valor { get; set; }
        public string Funcionario { get; set; }
        public string Fornecedor { get; set; }
        public List<ProdutosEntradaView> produtosEntradas { get; set; }
    }
}
