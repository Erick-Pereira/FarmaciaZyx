using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Funcionario
    {
        public Funcionario()
        {
        }

        public Funcionario(int iD, string nome, string cPF, string rG, string telefone, string email, string senha, Endereco endereco, int tipoFuncionarioId)
        {
            ID = iD;
            Nome = nome;
            CPF = cPF;
            RG = rG;
            Telefone = telefone;
            Email = email;
            Senha = senha;
            Endereco = endereco;
            TipoFuncionarioId = tipoFuncionarioId;
        }

        public int ID { get;  set; }
        public string Nome { get;  set; }
        public string CPF { get;  set; }
        public string RG { get;  set; }
        public string Telefone { get;  set; }
        public string Email { get;  set; }
        public string Senha { get;  set; }
        public Endereco Endereco { get;  set; }
        public int TipoFuncionarioId { get;  set; }
    }
}
