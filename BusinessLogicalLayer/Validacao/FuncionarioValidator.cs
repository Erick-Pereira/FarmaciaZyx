using DataAccessLayer;
using Entities;
using Shared;

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
            string erros = "";

            erros += stringValidator.ValidateNome(funcionario.Nome);
            erros += stringValidator.ValidateCPF(funcionario.CPF);
            erros += stringValidator.ValidateEmail(funcionario.Email);
            erros += stringValidator.ValidateTelefone(funcionario.Telefone);
            //Sintaxe cliente.Endereco?.CEP verifica e só passaria o CEP informado caso a propriedade
            //Endereco de dentro do Cliente não seja nula, caso contrário, passará o valor padrão do CEP (que é uma string e vale null!)
            //erros += stringValidator.ValidateCEP(funcionario.);


            //CPF do cliente deve ser único
            // if (funcionarioDAL.Exists(funcionario.CPF).HasSuccess)
            {
                erros += "CPF já cadastrado.";
            }

            //Se encontramos erro
            if (erros.Length != 0)
            {
                return new Response(erros, false);
            }

            //Se chegou aqui, validamos com sucesso!
            funcionario.Nome = (normatization.NormatizeName(funcionario.Nome));
            return funcionarioDAL.Insert(funcionario);
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

