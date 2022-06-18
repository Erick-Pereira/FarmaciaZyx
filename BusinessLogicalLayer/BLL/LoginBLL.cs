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
    public class LoginBLL
    {
        
        public SingleResponse<Funcionario> Logar(Login login)
        {
           
            LoginDAL loginDAL = new LoginDAL();
            SingleResponse<Funcionario> singleResponse =  loginDAL.GetByEmail(login.Email);
            if (singleResponse.HasSuccess)
            {
               if(login.Senha == singleResponse.Item.Senha)
                {
                    return new SingleResponse<Funcionario>("Login efetuado com sucesso", true, singleResponse.Item);
                }
               return new SingleResponse<Funcionario>("Email ou senha esta incorreto",true, singleResponse.Item);
            }
           else
            {
                return new SingleResponse<Funcionario>(singleResponse.Message, singleResponse.HasSuccess,null);
            }
        }

    }
}
