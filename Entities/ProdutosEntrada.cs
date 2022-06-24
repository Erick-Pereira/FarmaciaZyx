using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProdutosEntrada
    {
        public int EntradaID { get; set; }
        public int ProdutoId { get; set; }
        public double Quantidade { get; set; }
        public double ValorUnitario { get; set; }
    }
}
