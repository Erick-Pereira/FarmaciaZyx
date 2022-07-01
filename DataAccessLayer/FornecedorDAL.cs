using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class FornecedorDAL : ICRUD<Fornecedor>
    {
        string connectionString = ConnectionString._connectionString;
        public Response Insert(Fornecedor fornecedor)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"INSERT INTO FORNECEDORES (RAZAO_SOCIAL,CNPJ,NOME_CONTATO,TELEFONE,EMAIL) VALUES (@RAZAO_SOCIAL,@CNPJ,@NOME_CONTATO,@TELEFONE,@EMAIL)";
            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@RAZAO_SOCIAL", fornecedor.RazaoSocial);
            command.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);
            command.Parameters.AddWithValue("@NOME_CONTATO", fornecedor.NomeContato);
            command.Parameters.AddWithValue("@TELEFONE", fornecedor.Telefone);
            command.Parameters.AddWithValue("@EMAIL", fornecedor.Email);

            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Fornecedor cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FORNECEDORES_EMAIL"))
                {
                    //RETORNAR MENSAGEM QUE O EMAIL TA DUPLICADO
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_FORNECEDORES_CNPJ"))
                {
                    //RETORNAR MENSAGEM QUE O CPF TA DUPLICADO
                    return new Response("CNPJ já está em uso.", false);
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

        public Response Update(Fornecedor fornecedor)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"UPDATE FORNECEDORES SET RAZAO_SOCIAL = @RAZAO_SOCIAL, EMAIL = @EMAIL, TELEFONE = @TELEFONE, NOME_CONTATO = @NOME_CONTATO WHERE ID = @ID";

            

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@RAZAO_SOCIAL", fornecedor.RazaoSocial);
            command.Parameters.AddWithValue("@EMAIL", fornecedor.Email);
            command.Parameters.AddWithValue("@TELEFONE", fornecedor.Telefone);
            command.Parameters.AddWithValue("@NOME_CONTATO", fornecedor.NomeContato);
            command.Parameters.AddWithValue("@ID", fornecedor.ID);

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
                    return new Response("Fornecedor excluido.", false);
                }
                return new Response("Fornecedor alterado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FORNECEDORES_EMAIL"))
                {
                    //RETORNAR MENSAGEM QUE O EMAIL TA DUPLICADO
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_FORNECEDORES_CNPJ"))
                {
                    //RETORNAR MENSAGEM QUE O CPF TA DUPLICADO
                    return new Response("CNPJ já está em uso.", false);
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
            string sql = "DELETE FROM FORNECEDORES WHERE ID = @ID";

            

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
                    return new Response("Fornecedor excluído com sucesso.", true);
                }
                return new Response("Fornecedor não excluído.", false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_ENTRADAS_FORNECEDOR"))
                {
                    //RETORNAR MENSAGEM QUE O EMAIL TA DUPLICADO
                    return new Response("Não é possivel excluir um Fornecedor que tenha uma Entrada cadastrada.", false);
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

        public DataResponse<Fornecedor> GetAll()
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,RAZAO_SOCIAL,CNPJ,NOME_CONTATO,TELEFONE,EMAIL FROM FORNECEDORES";

            

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Fornecedor> fornecedores = new List<Fornecedor>();
                //Enquanto houver registros, o loop será executado!
                while (reader.Read())
                {
                    Fornecedor fornecedor = new Fornecedor();
                    fornecedor.ID = Convert.ToInt32(reader["ID"]);
                    fornecedor.RazaoSocial = Convert.ToString(reader["RAZAO_SOCIAL"]);
                    fornecedor.CNPJ = Convert.ToString(reader["CNPJ"]);
                    fornecedor.NomeContato = Convert.ToString(reader["NOME_CONTATO"]);
                    fornecedor.Telefone = Convert.ToString(reader["TELEFONE"]);
                    fornecedor.Email = Convert.ToString(reader["EMAIL"]);
                    fornecedores.Add(fornecedor);
                }
                return new DataResponse<Fornecedor>("Fornecedor selecionados com sucesso!", true, fornecedores);
            }
            catch (Exception ex)
            {
                return new DataResponse<Fornecedor>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public SingleResponse<Fornecedor> GetByID(int id)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,RAZAO_SOCIAL,CNPJ,NOME_CONTATO,TELEFONE,EMAIL FROM FORNECEDORES WHERE ID = @ID";

            

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
                    Fornecedor fornecedor = new Fornecedor();
                    fornecedor.ID = Convert.ToInt32(reader["ID"]);
                    fornecedor.RazaoSocial = Convert.ToString(reader["RAZAO_SOCIAL"]);
                    fornecedor.CNPJ = Convert.ToString(reader["CNPJ"]);
                    fornecedor.NomeContato = Convert.ToString(reader["NOME_CONTATO"]);
                    fornecedor.Telefone = Convert.ToString(reader["TELEFONE"]);
                    fornecedor.Email = Convert.ToString(reader["EMAIL"]);
                    return new SingleResponse<Fornecedor>("Fornecedor selecionado com sucesso!", true, fornecedor);
                }
                return new SingleResponse<Fornecedor>("Fornecedor não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Fornecedor>("Erro no banco de dados, contate o administrador.", false, null);
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

