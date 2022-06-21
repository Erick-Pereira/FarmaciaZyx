using DataAccessLayer;
using Entities;
using Shared;
using System.Text;

namespace BusinessLogicalLayer
{
    public class FuncionarioValidator
    {
        private StringValidator stringValidator = new StringValidator();
        private DateTimeValidator dateTimeValidator = new DateTimeValidator();
        private Normatization normatization = new Normatization();
        private FuncionarioDAL funcionarioDAL = new FuncionarioDAL();

        public Response Validate(Funcionario funcionario)
        {
            StringBuilder erros = new StringBuilder();

            erros.AppendLine(stringValidator.ValidateNome(funcionario.Nome));
            erros.AppendLine(stringValidator.ValidateCPF(funcionario.CPF));
            erros.AppendLine(stringValidator.ValidateEmail(funcionario.Email));
            erros.AppendLine(stringValidator.ValidateTelefone(funcionario.Telefone));
            //Sintaxe cliente.Endereco?.CEP verifica e só passaria o CEP informado caso a propriedade
            //Endereco de dentro do Cliente não seja nula, caso contrário, passará o valor padrão do CEP (que é uma string e vale null!)
            //erros += stringValidator.ValidateCEP(funcionario.);
            funcionario.Nome = (normatization.NormatizeName(funcionario.Nome));
            if (string.IsNullOrWhiteSpace(erros.ToString().Trim()))
            {
                
                return funcionarioDAL.Insert(funcionario);
            }
            return new Response(erros.ToString().Trim(), false);
            //Se chegou aqui, validamos com sucesso!
            
            
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

