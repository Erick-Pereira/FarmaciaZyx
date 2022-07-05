using DataAccessLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class DALValidator
    {

        FuncionarioDAL funcionarioDAL = new FuncionarioDAL();

        /// <summary>
        /// Verifica se há um funcionario no banco de dados, caso não tenha, cria um admin padrão
        /// </summary>
        public void Verify()
        {
            DataResponse<Funcionario> dataResponse = funcionarioDAL.GetAll();
            if(dataResponse.Dados.Count == 0)
            {
                Hash hash = new Hash();
                string senha = hash.ComputeSha256Hash("12345678");
                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
                Funcionario funcionario = new Funcionario("Admin","","","","admin@admin.com",senha, 1,1,1,dateTime);
                funcionarioDAL.Insert(funcionario);
            }
        }
    }
}
