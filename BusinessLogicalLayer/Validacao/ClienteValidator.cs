using DataAccessLayer;
using Entities;
using Shared;

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
            string erros = "";

            erros += stringValidator.ValidateNome(cliente.Nome);
            erros += stringValidator.ValidateCPF(cliente.CPF);
            erros += stringValidator.ValidateEmail(cliente.Email);
            erros += stringValidator.ValidateTelefone(cliente.Telefone1);
            erros += stringValidator.ValidateTelefone(cliente.Telefone2);
            //Sintaxe cliente.Endereco?.CEP verifica e só passaria o CEP informado caso a propriedade
            //Endereco de dentro do Cliente não seja nula, caso contrário, passará o valor padrão do CEP (que é uma string e vale null!)

            //CPF do cliente deve ser único
            // if (clienteDAL.(cliente.CPF).HasSuccess)
            {
                erros += "CPF já cadastrado.";
            }

            //Se encontramos erro
            if (erros.Length != 0)
            {
                return new Response(erros, false);
            }

            //Se chegou aqui, validamos com sucesso!
            cliente.Nome = (normatization.NormatizeName(cliente.Nome));
            return clienteDAL.Insert(cliente);
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