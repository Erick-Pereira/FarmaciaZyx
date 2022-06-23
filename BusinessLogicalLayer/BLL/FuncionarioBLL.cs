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

        public FuncionarioBLL()
        {
        }

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

        public Response Insert(FuncionarioComEndereco funcionarioComEndereco)
        {
            Response response = new Response();
            FuncionarioValidator funcionarioValidator = new FuncionarioValidator();
            StringValidator stringValidator = new StringValidator();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(stringValidator.ValidateCEP(funcionarioComEndereco.Endereco.CEP));
            stringBuilder.AppendLine(stringValidator.ValidateSenha(funcionarioComEndereco.Funcionario.Senha));
            stringBuilder.AppendLine(funcionarioValidator.Validate(funcionarioComEndereco.Funcionario).Message);
            string erros = stringBuilder.ToString().Trim();
            if (string.IsNullOrWhiteSpace(erros))
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    bool HasFound = false;
                    Cidade cidade = new Cidade();
                    Bairro bairro = new Bairro();
                    FuncionarioDAL funcionarioDAL = new FuncionarioDAL();
                    EnderecoDAL enderecoDAL = new EnderecoDAL();
                    CidadeDAL cidadeDAL = new CidadeDAL();
                    BairroDAL bairroDAL = new BairroDAL();
                    SingleResponse<Cidade> responseCidade = cidadeDAL.GetByNameAndEstadoId(funcionarioComEndereco.Cidade);
                    if (responseCidade.HasSuccess && responseCidade.Item != null)
                    {
                        funcionarioComEndereco.Bairro.CidadeId = responseCidade.Item.ID;
                        SingleResponse<Bairro> responseBairro = bairroDAL.GetByNameAndCidadeId(funcionarioComEndereco.Bairro);
                        if (responseBairro.HasSuccess && responseBairro.Item != null)
                        {
                            funcionarioComEndereco.Bairro.ID = responseBairro.Item.ID;
                            funcionarioComEndereco.Endereco.BairroID = responseBairro.Item.ID;
                            SingleResponse<Endereco> responseEndereco = enderecoDAL.GetByEndereco(funcionarioComEndereco.Endereco);
                            if (responseEndereco.HasSuccess && responseEndereco.Item != null)
                            {
                                funcionarioComEndereco.Funcionario.EnderecoId = responseEndereco.Item.ID;
                                response = funcionarioDAL.Insert(funcionarioComEndereco.Funcionario);
                            }
                            else if (responseEndereco.HasSuccess && responseEndereco.Item == null)
                            {
                                response = enderecoDAL.Insert(funcionarioComEndereco.Endereco);
                                response = funcionarioDAL.Insert(funcionarioComEndereco.Funcionario);
                            }
                            else
                            {
                                return responseEndereco;
                            }
                        }
                        else if (responseBairro.HasSuccess && responseBairro.Item == null)
                        {
                            response = bairroDAL.Insert(funcionarioComEndereco.Bairro);
                            response = enderecoDAL.Insert(funcionarioComEndereco.Endereco);
                            response = funcionarioDAL.Insert(funcionarioComEndereco.Funcionario);
                        }
                        else
                        {
                            return responseBairro;
                        }
                    }
                    else if (responseCidade.HasSuccess && responseCidade.Item == null)
                    {
                        response = cidadeDAL.Insert(funcionarioComEndereco.Cidade);
                        response = bairroDAL.Insert(funcionarioComEndereco.Bairro);
                        response = enderecoDAL.Insert(funcionarioComEndereco.Endereco);
                        response = funcionarioDAL.Insert(funcionarioComEndereco.Funcionario);
                    }
                    else
                    {
                        return responseCidade;
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

        public Response Update(Funcionario item)
        {
            return funcionarioDAL.Update(item);
        }

    }
}
