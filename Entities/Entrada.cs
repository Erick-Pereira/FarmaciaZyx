using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Entrada
    {
            public int ID { get; set; }
            public DateTime DataEntrada { get; set; }
            public double Valor { get; set; }
            public int FuncionarioId { get; set; }
            public int FornecedorID { get; set; }
            public int FormaPagamento { get; set; }
            public double Desconto { get; set; }
            public List<ProdutosEntrada> produtosEntradas { get; set; }
    }
}
