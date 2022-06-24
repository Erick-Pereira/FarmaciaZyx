using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Saida
    {
        public int ID { get; set; }
        public DateTime DataSaida { get; set; }
        public double Valor { get; set; }
        public int FuncionarioId { get; set; }
        public int ClienteId { get; set; }
        public int FormaPagamento { get; set; }
        public double ValorTotal { get; set; }
        public double Desconto { get; set; }
        public List<ProdutoSaida> produtosSaidas { get; set; }
    }
}
