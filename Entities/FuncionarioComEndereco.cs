using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class FuncionarioComEndereco
    {
        public FuncionarioComEndereco()
        {
        }

        public FuncionarioComEndereco(Funcionario funcionario, Endereco endereco, Bairro bairro, Cidade cidade, int tipoFuncionarioId)
        {
            this.Funcionario = funcionario;
            this.Endereco = endereco;
            Bairro = bairro;
            Cidade = cidade;
            TipoFuncionarioId = tipoFuncionarioId;
        }

        public Funcionario Funcionario { get; set; }
        public Endereco Endereco { get; set; }
        public Bairro Bairro { get; set; }
        public Cidade Cidade { get; set; }
        public int TipoFuncionarioId { get; set; }
    }
}

