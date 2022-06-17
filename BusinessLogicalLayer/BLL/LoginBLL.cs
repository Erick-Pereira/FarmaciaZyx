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
        
        public Response Logar(Login login)
        {
           
            LoginDAL loginDAL = new LoginDAL();
            SingleResponse<Funcionario> singleResponse =  loginDAL.GetByEmail(login.Email);
            if (singleResponse.HasSuccess)
            {
               if(login.Senha == singleResponse.Item.Senha)
                {
                    return new Response("Login efetuado com sucesso", true);
                }
               return new Response("Email ou senha esta incorreto",true);
            }
           else
            {
                return new Response(singleResponse.Message, singleResponse.HasSuccess);
            }
        }

    }
}
