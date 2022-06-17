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
    public class FuncionarioBLL : ICRUD<Funcionario>
    {
        private FuncionarioDAL funcionarioDAL = new FuncionarioDAL();

        public Response Delete(int id)
        {
            return funcionarioDAL.Delete(id);
        }

        public DataResponse<Funcionario> GetAll()
        {
            return funcionarioDAL.GetAll();
        }

        public SingleResponse<Funcionario> GetByID(int id)
        {
            return funcionarioDAL.GetByID(id);
        }

        public Response Insert(Funcionario item)
        {
            //NAO ESQUEÇAM DAS VALIDAÇÕES!
            //SE EXISTIREM NO OBJETO CLIENTE, RETORNAR ERROS!!
            //NÃO ACESSAR O DAL CASO O OBJETO CLIENTE ESTEJA INCORRETO!!!!
            return funcionarioDAL.Insert(item);
        }

        public Response Update(Funcionario item)
        {
            return funcionarioDAL.Update(item);
        }

    }
}
