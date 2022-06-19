using DataAccessLayer;
using Entities;
using Shared;
using System.Text;

namespace BusinessLogicalLayer
{
    //Projeto (Assembly) > Namespace > classe

    public class ClienteValidator
    {
        private StringValidator stringValidator = new StringValidator();
        private DateTimeValidator dateTimeValidator = new DateTimeValidator();
        private Normatization normatization = new Normatization();
        private ClienteDAL clienteDAL = new ClienteDAL();

        public Response Validate(Cliente cliente)
        {
            StringBuilder erros = new StringBuilder();
            erros.AppendLine(stringValidator.ValidateNome(cliente.Nome));
            erros.AppendLine(stringValidator.ValidateCPF(cliente.CPF));
            erros.AppendLine(stringValidator.ValidateEmail(cliente.Email));
            erros.AppendLine(stringValidator.ValidateTelefone(cliente.Telefone1));
            erros.AppendLine(stringValidator.ValidateTelefone(cliente.Telefone2));
            //cliente.Nome = (normatization.NormatizeName(cliente.Nome));
            //Sintaxe cliente.Endereco?.CEP verifica e só passaria o CEP informado caso a propriedade
            //Endereco de dentro do Cliente não seja nula, caso contrário, passará o valor padrão do CEP (que é uma string e vale null!)
            if (string.IsNullOrWhiteSpace(erros.ToString().Trim()))
            {
                return new Response(erros.ToString(), true);
            }
            return new Response(erros.ToString().Trim(), false);
        }

    }

    //class Carro
    //{
    //    public Carro(string marca, Motor motorizacao)
    //    {
    //        Marca = marca;
    //        Motorizacao = motorizacao;
    //    }

    //    //Retorna true se o carro for cantar pneu (apenas veiculos com mais de 200 cv ou 6 cilindros no mínimo)
    //    public bool Acelerar()
    //    {
    //        if(this.Motorizacao?.CV > 200 || this.Motorizacao.QtdCilindros >= 6)
    //        {
    //            return true;
    //        }
    //        return false;
    //    }

    //    public string Marca { get; set; }
    //    public Motor Motorizacao { get; set; }
    //}
    //class Motor
    //{
    //    public int CV { get; set; }
    //    public int QtdCilindros { get; set; }
    //}



}