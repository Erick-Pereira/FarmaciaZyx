using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProdutosEntradaView
    {
        public int EntradaID { get; set; }
        public ProdutoView Produto { get; set; }
        public double Quantidade { get; set; }
        public double ValorUnitario { get; set; }
    }
}
