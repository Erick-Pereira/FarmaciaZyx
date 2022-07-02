using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SaidaView
    {
        public int ID { get; set; }
        public DateTime DataSaida { get; set; }
        public double Valor { get; set; }
        public string Funcionario { get; set; }
        public string Cliente { get; set; }
        public string FormaPagamento { get; set; }
        public double ValorTotal { get; set; }
        public double Desconto { get; set; }
        public List<ProdutosSaidaView> produtosSaidas { get; set; }
    }
}
