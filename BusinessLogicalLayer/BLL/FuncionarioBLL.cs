using DataAccessLayer;
using Entities;
using Shared;
using System.Text;
using System.Text.RegularExpressions;
using System.Transactions;

namespace BusinessLogicalLayer
{
    public class FuncionarioBLL : ICRUD<Funcionario>
    {
        private FuncionarioDAL funcionarioDAL = new FuncionarioDAL();
        /// <summary>
        /// Recebe um ID e instancia o metodo Delete do FuncionarioDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Delete(int id)
        {
            return funcionarioDAL.Delete(id);
        }
        /// <summary>
        /// Instancia o metodo GetAll do FuncionarioDAL
        /// </summary>
        /// <returns>Retorna um DataResponse contendo todos os Funcionarios cadastrados no banco de dados</returns>
        public DataResponse<Funcionario> GetAll()
        {
            return funcionarioDAL.GetAll();
        }
        /// <summary>
        /// Instancia o metodo GetAllFuncionarioView do FuncionarioDAL
        /// </summary>
        /// <returns>Retorna um DataResponse contendo todos os Funcionarios cadastrados no banco de dados</returns>
        public DataResponse<FuncionarioView> GetAllFuncionarioView()
        {
            return funcionarioDAL.GetAllFuncionarioView();
        }
        /// <summary>
        /// Recebe um ID e instancia o metodo GetAllByEnderecoId do FuncionarioDAL
        /// </summary>
        /// <param name="enderecoId"></param>
        /// <returns>Retorna um DataResponse contendo todos os Funcionarios relacionados ao ID informado</returns>
        public DataResponse<Funcionario> GetAllByEnderecoId(int enderecoId)
        {
            return funcionarioDAL.GetAllByEnderecoId(enderecoId);
        }
        /// <summary>
        /// Recebe um ID e instancia o metodo GetById do FuncionarioDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um SingleResponse com um Funcionario referente ao ID informado</returns>
        public SingleResponse<Funcionario> GetByID(int id)
        {
            return funcionarioDAL.GetByID(id);
        }
        /// <summary>
        /// Recebe um ID e instancia o metodo GetSenhaById do FuncionarioDAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um SingleResponse contendo um Funcionario apenas com ID e Senha</returns>
        public SingleResponse<Funcionario> GetSenhaByID(int id)
        {
            return funcionarioDAL.GetSenhaByID(id);
        }
        /// <summary>
        /// Recebe um FuncionarioComEndereco,Faz validações e insere no banco de dados
        /// </summary>
        /// <param name="funcionarioComEndereco"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response InsertFuncionarioComEndereco(FuncionarioComEndereco funcionarioComEndereco)
        {
            Response response = new Response();
            FuncionarioValidator funcionarioValidator = new FuncionarioValidator();
            StringValidator stringValidator = new StringValidator();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(stringValidator.ValidateCEP(funcionarioComEndereco.Endereco.CEP));
            stringBuilder.AppendLine(funcionarioValidator.Validate(funcionarioComEndereco.Funcionario).Message);
            string erros = stringBuilder.ToString().Trim();
            if (string.IsNullOrWhiteSpace(erros))
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    Cidade cidade = new Cidade();
                    Bairro bairro = new Bairro();
                    FuncionarioDAL funcionarioDAL = new FuncionarioDAL();
                    EnderecoDAL enderecoDAL = new EnderecoDAL();
                    CidadeDAL cidadeDAL = new CidadeDAL();
                    BairroDAL bairroDAL = new BairroDAL();
                    SingleResponse<Cidade> responseCidade = cidadeDAL.GetByNameAndEstadoId(funcionarioComEndereco.Cidade);
                    if (responseCidade.HasSuccess && responseCidade.Item != null)
                    {
                        //Se tiver uma cidade com mesmo nome, ele entra no if
                        funcionarioComEndereco.Bairro.CidadeId = responseCidade.Item.ID;
                        SingleResponse<Bairro> responseBairro = bairroDAL.GetByNameAndCidadeId(funcionarioComEndereco.Bairro);
                        if (responseBairro.HasSuccess && responseBairro.Item != null)
                        {
                            //Se tiver um bairro com mesmo nome e cidade, ele entra no if
                            funcionarioComEndereco.Bairro.ID = responseBairro.Item.ID;
                            funcionarioComEndereco.Endereco.BairroID = responseBairro.Item.ID;
                            SingleResponse<Endereco> responseEndereco = enderecoDAL.GetByEndereco(funcionarioComEndereco.Endereco);
                            if (responseEndereco.HasSuccess && responseEndereco.Item != null)
                            {
                                //Se tiver um Endereço igual, ele entra no if
                                //e insere apenas o funcionario
                                funcionarioComEndereco.Funcionario.EnderecoId = responseEndereco.Item.ID;
                                response = funcionarioDAL.Insert(funcionarioComEndereco.Funcionario);
                            }
                            else if (responseEndereco.HasSuccess && responseEndereco.Item == null)
                            {
                                //se ele acessou o banco de dados, mas não achou nenhum Endereço igual, ele entra no if
                                // e insere o Endereço e funcionario
                                response = enderecoDAL.Insert(funcionarioComEndereco.Endereco);
                                funcionarioComEndereco.Funcionario.EnderecoId = funcionarioComEndereco.Endereco.ID;
                                response = funcionarioDAL.Insert(funcionarioComEndereco.Funcionario);
                            }
                            else
                            {
                                //se ele não conseguiu acessar o banco de dados, retorna o erro
                                response = responseEndereco;
                                return response;
                            }
                        }
                        else if (responseBairro.HasSuccess && responseBairro.Item == null)
                        {
                            //se ele conseguiu acessar o banco de dados, mas não achou nenhum Bairro igual
                            //Cadastra o bairro, endereço e o funcionario
                            response = bairroDAL.Insert(funcionarioComEndereco.Bairro);
                            funcionarioComEndereco.Endereco.BairroID = funcionarioComEndereco.Bairro.ID;
                            response = enderecoDAL.Insert(funcionarioComEndereco.Endereco);
                            funcionarioComEndereco.Funcionario.EnderecoId = funcionarioComEndereco.Endereco.ID;
                            response = funcionarioDAL.Insert(funcionarioComEndereco.Funcionario);
                        }
                        else
                        {
                            //se ele não conseguiu acessar o banco de dados, retorna o erro
                            response = responseBairro;
                            return response;
                        }
                    }
                    else if (responseCidade.HasSuccess && responseCidade.Item == null)
                    {
                        //Se conseguiu acessar o banco de dados, mas não achou nenhuma cidade igual
                        //cadastra Cidade,Bairro,Endereço e o funcionario
                        response = cidadeDAL.Insert(funcionarioComEndereco.Cidade);
                        funcionarioComEndereco.Bairro.CidadeId = funcionarioComEndereco.Cidade.ID;
                        response = bairroDAL.Insert(funcionarioComEndereco.Bairro);
                        funcionarioComEndereco.Endereco.BairroID = funcionarioComEndereco.Bairro.ID;
                        response = enderecoDAL.Insert(funcionarioComEndereco.Endereco);
                        funcionarioComEndereco.Funcionario.EnderecoId = funcionarioComEndereco.Endereco.ID;
                        response = funcionarioDAL.Insert(funcionarioComEndereco.Funcionario);
                    }
                    else
                    {
                        //se ele não conseguiu acessar o banco de dados, retorna o erro
                        response = responseCidade;
                        return response;
                    }
                    scope.Complete();
                }
            }//scope.Dispose();
            return response;
        }
        public Response Insert(Funcionario item)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Recebe um FuncionarioComEndereco,Faz validações e faz o update no banco de dados
        /// </summary>
        /// <param name="funcionarioComEndereco"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response UpdateFuncionarioComEndereco(FuncionarioComEndereco funcionarioComEndereco)
        {
            Response response = new Response();
            FuncionarioValidator funcionarioValidator = new FuncionarioValidator();
            StringValidator stringValidator = new StringValidator();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(stringValidator.ValidateCEP(funcionarioComEndereco.Endereco.CEP));
            stringBuilder.AppendLine(funcionarioValidator.Validate(funcionarioComEndereco.Funcionario).Message);
            string erros = stringBuilder.ToString().Trim();
            if (string.IsNullOrWhiteSpace(erros))
            {
                //Se ele passou por todas as validações e não tem nada de irregular, ele entra if
                using (TransactionScope scope = new TransactionScope())
                {
                    Cidade cidade = new Cidade();
                    Bairro bairro = new Bairro();
                    FuncionarioDAL funcionarioDAL = new FuncionarioDAL();
                    EnderecoDAL enderecoDAL = new EnderecoDAL();
                    CidadeDAL cidadeDAL = new CidadeDAL();
                    BairroDAL bairroDAL = new BairroDAL();
                    int enderecoIdVelho = funcionarioComEndereco.Funcionario.EnderecoId;
                    DataResponse<Funcionario> dataResponseEnderecos = funcionarioDAL.GetAllByEnderecoId(enderecoIdVelho);
                    if (dataResponseEnderecos.Dados.Count != 1)
                    {
                        //Se a quantidade de Funcionarios no endereços for diferente que 1, ele entra no if
                        SingleResponse<Cidade> responseCidade = cidadeDAL.GetByNameAndEstadoId(funcionarioComEndereco.Cidade);
                        if (responseCidade.HasSuccess && responseCidade.Item != null)
                        {
                            //Se tiver uma cidade com mesmo nome, ele entra no if
                            funcionarioComEndereco.Bairro.CidadeId = responseCidade.Item.ID;
                            SingleResponse<Bairro> responseBairro = bairroDAL.GetByNameAndCidadeId(funcionarioComEndereco.Bairro);
                            if (responseBairro.HasSuccess && responseBairro.Item != null)
                            {
                                //Se tiver um bairro com mesmo nome e cidade, ele entra no if
                                funcionarioComEndereco.Bairro.ID = responseBairro.Item.ID;
                                funcionarioComEndereco.Endereco.BairroID = responseBairro.Item.ID;
                                SingleResponse<Endereco> responseEndereco = enderecoDAL.GetByEndereco(funcionarioComEndereco.Endereco);
                                if (responseEndereco.HasSuccess && responseEndereco.Item != null)
                                {
                                    //Se tiver um Endereço igual, ele entra no if
                                    //e faz o update apenas do funcionario
                                    funcionarioComEndereco.Funcionario.EnderecoId = responseEndereco.Item.ID;
                                    response = funcionarioDAL.Update(funcionarioComEndereco.Funcionario);
                                }
                                else if (responseEndereco.HasSuccess && responseEndereco.Item == null)
                                {
                                    //se ele acessou o banco de dados, mas não achou nenhum Endereço igual, ele entra no if
                                    // e faz o cadastro do Endereço e faz o update do funcionario
                                    response = enderecoDAL.Insert(funcionarioComEndereco.Endereco);
                                    funcionarioComEndereco.Funcionario.EnderecoId = funcionarioComEndereco.Endereco.ID;
                                    response = funcionarioDAL.Update(funcionarioComEndereco.Funcionario);
                                }
                                else
                                {
                                    //se ele não conseguiu acessar o banco de dados, retorna o erro
                                    response = responseEndereco;
                                    return response;
                                }
                            }
                            else if (responseBairro.HasSuccess && responseBairro.Item == null)
                            {
                                //se ele conseguiu acessar o banco de dados, mas não achou nenhum Bairro igual
                                //Cadastra o bairro e o endereço e faz o update do funcionario
                                response = bairroDAL.Insert(funcionarioComEndereco.Bairro);
                                funcionarioComEndereco.Endereco.BairroID = funcionarioComEndereco.Bairro.ID;
                                response = enderecoDAL.Insert(funcionarioComEndereco.Endereco);
                                funcionarioComEndereco.Funcionario.EnderecoId = funcionarioComEndereco.Endereco.ID;
                                response = funcionarioDAL.Update(funcionarioComEndereco.Funcionario);
                            }
                            else
                            {
                                //se ele não conseguiu acessar o banco de dados, retorna o erro
                                response = responseBairro;
                                return response;
                            }
                        }
                        else if (responseCidade.HasSuccess && responseCidade.Item == null)
                        {
                            //Se conseguiu acessar o banco de dados, mas não achou nenhuma cidade igual
                            //cadastra Cidade,Bairro,Endereço e faz o update do funcionario
                            response = cidadeDAL.Insert(funcionarioComEndereco.Cidade);
                            funcionarioComEndereco.Bairro.CidadeId = funcionarioComEndereco.Cidade.ID;
                            response = bairroDAL.Insert(funcionarioComEndereco.Bairro);
                            funcionarioComEndereco.Endereco.BairroID = funcionarioComEndereco.Bairro.ID;
                            response = enderecoDAL.Insert(funcionarioComEndereco.Endereco);
                            funcionarioComEndereco.Funcionario.EnderecoId = funcionarioComEndereco.Endereco.ID;
                            response = funcionarioDAL.Update(funcionarioComEndereco.Funcionario);
                        }
                        else
                        {
                            //se ele não conseguiu acessar o banco de dados, retorna o erro
                            response = responseCidade;
                            return response;
                        }
                    }
                    else
                    {
                        //Se não tem mais de um Funcionario no endereço, entra no enlse
                        SingleResponse<Cidade> responseCidade = cidadeDAL.GetByNameAndEstadoId(funcionarioComEndereco.Cidade);
                        if (responseCidade.HasSuccess && responseCidade.Item != null)
                        {
                            //Se conseguiu acessar o banco e achou uma cidade, entra no if
                            funcionarioComEndereco.Bairro.CidadeId = responseCidade.Item.ID;
                            SingleResponse<Bairro> responseBairro = bairroDAL.GetByNameAndCidadeId(funcionarioComEndereco.Bairro);
                            if (responseBairro.HasSuccess && responseBairro.Item != null)
                            {
                                //Se conseguiu acessar o banco e achou um bairro, entra no if
                                funcionarioComEndereco.Bairro.ID = responseBairro.Item.ID;
                                funcionarioComEndereco.Endereco.BairroID = responseBairro.Item.ID;
                                SingleResponse<Endereco> responseEndereco = enderecoDAL.GetByEndereco(funcionarioComEndereco.Endereco);
                                if (responseEndereco.HasSuccess && responseEndereco.Item != null)
                                {
                                    //se conseguiu acessar o banco e achou um endereço, faz o update do funcionario
                                    funcionarioComEndereco.Funcionario.EnderecoId = responseEndereco.Item.ID;
                                    response = funcionarioDAL.Update(funcionarioComEndereco.Funcionario);
                                }
                                else if (responseEndereco.HasSuccess && responseEndereco.Item == null)
                                {
                                    //se ele conseguiu acessar o banco, mas não achou um endereço, faz o update do Endereço e do Funcionario
                                    response = enderecoDAL.Update(funcionarioComEndereco.Endereco);
                                    funcionarioComEndereco.Funcionario.EnderecoId = funcionarioComEndereco.Endereco.ID;
                                    response = funcionarioDAL.Update(funcionarioComEndereco.Funcionario);
                                }
                                else
                                {
                                    //se ele não conseguiu acessar o banco de dados, retorna o erro
                                    response = responseEndereco;
                                    return response;
                                }
                            }
                            else if (responseBairro.HasSuccess && responseBairro.Item == null)
                            {
                                //Se conseguiu entrar no banco, mas não achou um Bairro, faz o insert do Bairro e update do Endereço e Funcionario
                                response = bairroDAL.Insert(funcionarioComEndereco.Bairro);
                                funcionarioComEndereco.Endereco.BairroID = funcionarioComEndereco.Bairro.ID;
                                response = enderecoDAL.Update(funcionarioComEndereco.Endereco);
                                funcionarioComEndereco.Funcionario.EnderecoId = funcionarioComEndereco.Endereco.ID;
                                response = funcionarioDAL.Update(funcionarioComEndereco.Funcionario);
                            }
                            else
                            {
                                //se ele não conseguiu acessar o banco de dados, retorna o erro
                                response = responseBairro;
                                return response;
                            }
                        }
                        else if (responseCidade.HasSuccess && responseCidade.Item == null)
                        {
                            //Se conseguiu acessar o banco de dados, mas não achou uma cidade,
                            //faz o Inset da Cidade e Bairro e faz o Update do Endereço e Funcionario
                            response = cidadeDAL.Insert(funcionarioComEndereco.Cidade);
                            funcionarioComEndereco.Bairro.CidadeId = funcionarioComEndereco.Cidade.ID;
                            response = bairroDAL.Insert(funcionarioComEndereco.Bairro);
                            funcionarioComEndereco.Endereco.BairroID = funcionarioComEndereco.Bairro.ID;
                            response = enderecoDAL.Update(funcionarioComEndereco.Endereco);
                            funcionarioComEndereco.Funcionario.EnderecoId = funcionarioComEndereco.Endereco.ID;
                            response = funcionarioDAL.Update(funcionarioComEndereco.Funcionario);
                        }
                        else
                        {
                            //se ele não conseguiu acessar o banco de dados, retorna o erro
                            response = responseCidade;
                            return response;
                        }
                        dataResponseEnderecos = funcionarioDAL.GetAllByEnderecoId(enderecoIdVelho);
                        if (dataResponseEnderecos.Dados.Count == 0)
                        {
                            //Se não há mais funcionarios no Endereço antigo, deleta o Endereço
                            Response responseDelete = enderecoDAL.Delete(enderecoIdVelho);
                            if (!responseDelete.HasSuccess)
                            {
                                //Caso não tenha sucesso, retorna um Response informando o erro
                                return responseDelete;
                            }
                        }
                    }
                    scope.Complete();
                }
            }
            //scope.Dispose();
            return response;
        }
        /// <summary>
        /// Recebe um Funcionario e instancia o metodo Update do FuncionarioDAL
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Update(Funcionario item)
        {
            return funcionarioDAL.Update(item);
        }
        /// <summary>
        /// Recebe um Funcionario e instancia o metodo UpdateSenha
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response UpdateSenha(Funcionario item)
        {
            return funcionarioDAL.UpdateSenha(item);
        }

    }
}
