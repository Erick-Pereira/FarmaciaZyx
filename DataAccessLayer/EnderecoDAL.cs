using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class EnderecoDAL : ICRUD<Endereco>
    {
        string connectionString = ConnectionString._connectionString;
        public Response Insert(Endereco item)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"INSERT INTO ENDERECOS (CEP,NUMERO_CASA,BAIRRO_ID,RUA,COMPLEMENTO) VALUES (@CEP,@NUMERO_CASA,@BAIRRO_ID,@RUA,@COMPLEMENTO); SELECT SCOPE_IDENTITY()";



            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CEP", item.CEP);
            command.Parameters.AddWithValue("@NUMERO_CASA", item.NumeroCasa);
            command.Parameters.AddWithValue("@BAIRRO_ID", item.BairroID);
            command.Parameters.AddWithValue("@RUA", item.Rua);
            command.Parameters.AddWithValue("@COMPLEMENTO", item.Complemento);


            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
            try
            {
                connection.Open();
                item.ID = Convert.ToInt32(command.ExecuteScalar());
                return new Response("Endereco cadastrado com sucesso.", true);
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

        public Response Update(Endereco endereco)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"UPDATE ENDERECOS SET CEP = @CEP, NUMERO_CASA = @NUMERO_CASA, BAIRRO_ID = @BAIRRO_ID, RUA = @RUA, COMPLEMENTO = @COMPLEMENTO WHERE ID = @ID";

            

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CEP", endereco.CEP);
            command.Parameters.AddWithValue("@NUMERO_CASA", endereco.NumeroCasa);
            command.Parameters.AddWithValue("@BAIRRO_ID", endereco.BairroID);
            command.Parameters.AddWithValue("@RUA", endereco.Rua);
            command.Parameters.AddWithValue("@COMPLEMENTO", endereco.Complemento);
            command.Parameters.AddWithValue("@ID", endereco.ID);

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
                    return new Response("Endereço excluido.", false);
                }
                return new Response("Endereço alterado com sucesso.", true);
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

        public Response Delete(int id)
        {
            string sql = "DELETE FROM ENDERECOS WHERE ID = @ID";

            

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
                    return new Response("Endereço excluído com sucesso.", true);
                }
                return new Response("Endereço não excluído.", false);
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

        public DataResponse<Endereco> GetAll()
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,CEP,NUMERO_CASA,BAIRRO_ID,RUA,COMPLEMENTO FROM ENDERECOS";

            

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Endereco> enderecos = new List<Endereco>();
                //Enquanto houver registros, o loop será executado!
                while (reader.Read())
                {
                    Endereco endereco = new Endereco();
                    endereco.ID = Convert.ToInt32(reader["ID"]);
                    endereco.CEP = Convert.ToString(reader["CEP"]);
                    endereco.Rua = Convert.ToString(reader["RUA"]);
                    endereco.Complemento = Convert.ToString(reader["COMPLEMENTO"]);

                    endereco.NumeroCasa = Convert.ToString(reader["NUMERO_CASA"]);
                    endereco.BairroID = Convert.ToInt32(reader["BAIRRO_ID"]);

                    enderecos.Add(endereco);
                }
                return new DataResponse<Endereco>("Endereço selecionados com sucesso!", true, enderecos);
            }
            catch (Exception ex)
            {
                return new DataResponse<Endereco>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public SingleResponse<Endereco> GetByID(int id)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,CEP,NUMERO_CASA,BAIRRO_ID,RUA,COMPLEMENTO FROM ENDERECOS WHERE ID = @ID";

            

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
                    Endereco endereco = new Endereco();
                    endereco.ID = Convert.ToInt32(reader["ID"]);
                    endereco.CEP = Convert.ToString(reader["CEP"]);
                    endereco.Rua = Convert.ToString(reader["RUA"]);
                    endereco.Complemento = Convert.ToString(reader["COMPLEMENTO"]);
                    endereco.NumeroCasa = Convert.ToString(reader["NUMERO_CASA"]);
                    endereco.BairroID = Convert.ToInt32(reader["BAIRRO_ID"]);
                    return new SingleResponse<Endereco>("Endereço selecionado com sucesso!", true, endereco);
                }
                return new SingleResponse<Endereco>("Endereço não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Endereco>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public SingleResponse<Endereco> GetByEndereco(Endereco item)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,CEP,NUMERO_CASA,BAIRRO_ID,RUA,COMPLEMENTO FROM ENDERECOS WHERE CEP = @CEP AND NUMERO_CASA = @NUMERO_CASA AND BAIRRO_ID = @BAIRRO_ID AND RUA = @RUA";



            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CEP", item.CEP);
            command.Parameters.AddWithValue("@NUMERO_CASA", item.NumeroCasa);
            command.Parameters.AddWithValue("@BAIRRO_ID", item.BairroID);
            command.Parameters.AddWithValue("@RUA", item.Rua);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                //Enquanto houver registros, o loop será executado!
                if (reader.Read())
                {
                    Endereco endereco = new Endereco();
                    endereco.ID = Convert.ToInt32(reader["ID"]);
                    endereco.CEP = Convert.ToString(reader["CEP"]);
                    endereco.Rua = Convert.ToString(reader["RUA"]);
                    endereco.Complemento = Convert.ToString(reader["COMPLEMENTO"]);
                    endereco.NumeroCasa = Convert.ToString(reader["NUMERO_CASA"]);
                    endereco.BairroID = Convert.ToInt32(reader["BAIRRO_ID"]);
                    return new SingleResponse<Endereco>("Endereço selecionado com sucesso!", true, endereco);
                }
                return new SingleResponse<Endereco>("Endereço não encontrado!", true, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Endereco>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public SingleResponse<Endereco> CountById(int id)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT COUNT(*) FROM FUNCIONARIOS WHERE ENDERECO = @ID";



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
                    Endereco endereco = new Endereco();
                    endereco.ID = Convert.ToInt32(reader["ID"]);
                    endereco.CEP = Convert.ToString(reader["CEP"]);
                    endereco.Rua = Convert.ToString(reader["RUA"]);
                    endereco.Complemento = Convert.ToString(reader["COMPLEMENTO"]);
                    endereco.NumeroCasa = Convert.ToString(reader["NUMERO_CASA"]);
                    endereco.BairroID = Convert.ToInt32(reader["BAIRRO_ID"]);
                    return new SingleResponse<Endereco>("Endereço selecionado com sucesso!", true, endereco);
                }
                return new SingleResponse<Endereco>("Endereço não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Endereco>("Erro no banco de dados, contate o administrador.", false, null);
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
