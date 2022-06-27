using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class FuncionarioDAL : ICRUD<Funcionario>
    {
        string connectionString = ConnectionString._connectionString;
        public Response Insert(Funcionario funcionario)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"INSERT INTO FUNCIONARIOS (NOME,CPF,RG,TELEFONE,EMAIL,SENHA,ENDERECO_ID,TIPO_FUNCIONARIO_ID,GENEROS_ID, DATA_NASCIMENTO) VALUES (@NOME,@CPF,@RG,@TELEFONE,@EMAIL,@SENHA,@ENDERECO_ID,@TIPO_FUNCIONARIO_ID,@GENEROS_ID,@DATA_NASCIMENTO)";
            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", funcionario.Nome);
            command.Parameters.AddWithValue("@CPF", funcionario.CPF);
            command.Parameters.AddWithValue("@RG", funcionario.RG);
            command.Parameters.AddWithValue("@TELEFONE", funcionario.Telefone);
            command.Parameters.AddWithValue("@EMAIL", funcionario.Email);
            command.Parameters.AddWithValue("@SENHA", funcionario.Senha);
            command.Parameters.AddWithValue("@ENDERECO_ID", funcionario.EnderecoId);
            command.Parameters.AddWithValue("@TIPO_FUNCIONARIO_ID", funcionario.TipoFuncionarioId);
            command.Parameters.AddWithValue("@GENEROS_ID", funcionario.GerenoId);
            command.Parameters.AddWithValue("@DATA_NASCIMENTO", funcionario.DataNascimento);
            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Funcionario cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FUNCIONARIO_EMAIL"))
                {
                    //RETORNAR MENSAGEM QUE O EMAIL TA DUPLICADO
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_FUNCIONARIO_CPF"))
                {
                    //RETORNAR MENSAGEM QUE O CPF TA DUPLICADO
                    return new Response("CPF já está em uso.", false);
                }
                //SE NAO ENTROU EM NENHUM IF DE CIMA, SÓ PODE SER UM ERRO DE INFRAESTRUTURA
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }

        public Response Update(Funcionario funcionario)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"UPDATE FUNCIONARIOS SET NOME = @NOME,CPF = @CPF, TELEFONE = @TELEFONE, ENDERECO_ID = @ENDERECO_ID, TIPO_FUNCIONARIO_ID = @TIPO_FUNCIONARIO_ID, GENEROS_ID = @GENEROS_ID,DATA_NASCIMENTO = @DATA_NASCIMENTO WHERE ID = @ID";


            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", funcionario.Nome);
            command.Parameters.AddWithValue("@CPF", funcionario.CPF);
            command.Parameters.AddWithValue("@TELEFONE", funcionario.Telefone);
            command.Parameters.AddWithValue("@ENDERECO_ID", funcionario.EnderecoId);
            command.Parameters.AddWithValue("@TIPO_FUNCIONARIO_ID", funcionario.TipoFuncionarioId);
            command.Parameters.AddWithValue("@GENEROS_ID", funcionario.GerenoId);
            command.Parameters.AddWithValue("@ID", funcionario.ID);
            command.Parameters.AddWithValue("@DATA_NASCIMENTO", funcionario.DataNascimento);

            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Funcionario excluido.", false);
                }
                return new Response("Funcionario alterado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FUNCIONARIO_CPF"))
                {
                    //RETORNAR MENSAGEM QUE O CPF TA DUPLICADO
                    return new Response("CPF já existe.", false);
                }
                if (ex.Message.Contains("UQ_FUNCIONARIO_EMAIL"))
                {
                    //RETORNAR MENSAGEM QUE O EMAIL TA DUPLICADO
                    return new Response("Email já está em uso.", false);
                }
                //SE NAO ENTROU EM NENHUM IF DE CIMA, SÓ PODE SER UM ERRO DE INFRAESTRUTURA
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public Response UpdateSenha(Funcionario funcionario)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"UPDATE FUNCIONARIOS SET SENHA = @SENHA WHERE ID = @ID";


            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@SENHA", funcionario.Senha);
            command.Parameters.AddWithValue("@ID", funcionario.ID);

            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Funcionario excluido.", false);
                }
                return new Response("Funcionario alterado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FUNCIONARIO_CPF"))
                {
                    //RETORNAR MENSAGEM QUE O CPF TA DUPLICADO
                    return new Response("CPF já existe.", false);
                }
                if (ex.Message.Contains("UQ_FUNCIONARIO_EMAIL"))
                {
                    //RETORNAR MENSAGEM QUE O EMAIL TA DUPLICADO
                    return new Response("Email já está em uso.", false);
                }
                //SE NAO ENTROU EM NENHUM IF DE CIMA, SÓ PODE SER UM ERRO DE INFRAESTRUTURA
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public Response Delete(int id)
        {
            string sql = "DELETE FROM FUNCIONARIOS WHERE ID = @ID";


            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
            try
            {
                connection.Open();
                int qtdLinhasExcluidas = command.ExecuteNonQuery();
                if (qtdLinhasExcluidas == 1)
                {
                    return new Response("Funcionario excluído com sucesso.", true);
                }
                return new Response("Funcionario não excluído.", false);
            }
            catch (Exception ex)
            {
                //SE NAO ENTROU EM NENHUM IF DE CIMA, SÓ PODE SER UM ERRO DE INFRAESTRUTURA
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }

        public DataResponse<Funcionario> GetAll()
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME,CPF,RG,EMAIL,TELEFONE,ENDERECO_ID,TIPO_FUNCIONARIO_ID,GENEROS_ID,DATA_NASCIMENTO FROM FUNCIONARIOS";
            SqlConnection connection = new SqlConnection(connectionString);
            //ADO.NET 
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Funcionario> funcionarios = new List<Funcionario>();
                //Enquanto houver registros, o loop será executado!
                while (reader.Read())
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario.ID = Convert.ToInt32(reader["ID"]);
                    funcionario.Nome = Convert.ToString(reader["NOME"]);
                    funcionario.CPF = Convert.ToString(reader["CPF"]);
                    funcionario.RG = Convert.ToString(reader["RG"]);
                    funcionario.Email = Convert.ToString(reader["EMAIL"]);
                    funcionario.Telefone = Convert.ToString(reader["TELEFONE"]);
                    funcionario.EnderecoId = Convert.ToInt32(reader["ENDERECO_ID"]);
                    funcionario.TipoFuncionarioId = Convert.ToInt32(reader["TIPO_FUNCIONARIO_ID"]);
                    funcionario.GerenoId = Convert.ToInt32(reader["GENEROS_ID"]);
                    funcionario.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                    funcionarios.Add(funcionario);
                }
                return new DataResponse<Funcionario>("Funcionarios selecionados com sucesso!", true, funcionarios);
            }
            catch (Exception ex)
            {
                return new DataResponse<Funcionario>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public SingleResponse<Funcionario> GetByID(int id)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME,RG,CPF,EMAIL,TELEFONE,ENDERECO_ID,TIPO_FUNCIONARIO_ID,GENEROS_ID, DATA_NASCIMENTO FROM FUNCIONARIOS WHERE ID = @ID";


            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                //Enquanto houver registros, o loop será executado!
                if (reader.Read())
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario.ID = Convert.ToInt32(reader["ID"]);
                    funcionario.Nome = Convert.ToString(reader["NOME"]);
                    funcionario.CPF = Convert.ToString(reader["CPF"]);
                    funcionario.RG = Convert.ToString(reader["RG"]);
                    funcionario.Telefone = Convert.ToString(reader["TELEFONE"]);
                    funcionario.Email = Convert.ToString(reader["EMAIL"]);
                    funcionario.EnderecoId = Convert.ToInt32(reader["ENDERECO_ID"]);
                    funcionario.TipoFuncionarioId = Convert.ToInt32(reader["TIPO_FUNCIONARIO_ID"]);
                    funcionario.GerenoId = Convert.ToInt32(reader["GENEROS_ID"]);
                    funcionario.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);

                    return new SingleResponse<Funcionario>("Funcionario selecionado com sucesso!", true, funcionario);
                }
                return new SingleResponse<Funcionario>("Funcionario não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Funcionario>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public SingleResponse<Funcionario> GetSenhaByID(int id)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,SENHA FROM FUNCIONARIOS WHERE ID = @ID";


            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                //Enquanto houver registros, o loop será executado!
                if (reader.Read())
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario.ID = Convert.ToInt32(reader["ID"]);
                    funcionario.Senha = Convert.ToString(reader["SENHA"]);
                    return new SingleResponse<Funcionario>("Funcionario selecionado com sucesso!", true, funcionario);
                }
                return new SingleResponse<Funcionario>("Funcionario não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Funcionario>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public DataResponse<Funcionario> GetAllByEnderecoId(int idEndereco)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME,CPF,RG,EMAIL,TELEFONE,ENDERECO_ID,TIPO_FUNCIONARIO_ID,GENEROS_ID, DATA_NASCIMENTO FROM FUNCIONARIOS WHERE ENDERECO_ID = @ENDERECO_ID";
            SqlConnection connection = new SqlConnection(connectionString);
            //ADO.NET 
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ENDERECO_ID", idEndereco);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Funcionario> funcionarios = new List<Funcionario>();
                //Enquanto houver registros, o loop será executado!
                while (reader.Read())
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario.ID = Convert.ToInt32(reader["ID"]);
                    funcionario.Nome = Convert.ToString(reader["NOME"]);
                    funcionario.CPF = Convert.ToString(reader["CPF"]);
                    funcionario.RG = Convert.ToString(reader["RG"]);
                    funcionario.Email = Convert.ToString(reader["EMAIL"]);
                    funcionario.Telefone = Convert.ToString(reader["TELEFONE"]);
                    funcionario.EnderecoId = Convert.ToInt32(reader["ENDERECO_ID"]);
                    funcionario.TipoFuncionarioId = Convert.ToInt32(reader["TIPO_FUNCIONARIO_ID"]);
                    funcionario.GerenoId = Convert.ToInt32(reader["GENEROS_ID"]);
                    funcionario.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                    funcionarios.Add(funcionario);
                }
                return new DataResponse<Funcionario>("Funcionarios selecionados com sucesso!", true, funcionarios);
            }
            catch (Exception ex)
            {
                return new DataResponse<Funcionario>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
    }
}