using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class FuncionarioComEnderecoView
    {
        public FuncionarioView Funcionario { get; set; }
        public Endereco Endereco { get; set; }
        public Bairro Bairro { get; set; }
        public Cidade Cidade { get; set; }
    }
}
