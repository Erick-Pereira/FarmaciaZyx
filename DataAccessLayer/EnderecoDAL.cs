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
            string sql = $"INSERT INTO ENDERECOS (CEP,NUMERO_CASA,BAIRRO_ID,RUA,COMPLEMENTO) VALUES (@CEP,@NUMERO_CASA,@BAIRRO_ID,@RUA,@COMPLEMENTO); SELECT SCOPE_IDENTITY()";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CEP", item.CEP);
            command.Parameters.AddWithValue("@NUMERO_CASA", item.NumeroCasa);
            command.Parameters.AddWithValue("@BAIRRO_ID", item.BairroID);
            command.Parameters.AddWithValue("@RUA", item.Rua);
            command.Parameters.AddWithValue("@COMPLEMENTO", item.Complemento);
            try
            {
                connection.Open();
                item.ID = Convert.ToInt32(command.ExecuteScalar());
                return new Response("Endereço cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_FUNCIONARIOS_ENDERECO"))
                {
                    return new Response("Não é possivel excluir um Endereço que tenha um Funcionario cadastrado.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response Update(Endereco endereco)
        {
            string sql = $"UPDATE ENDERECOS SET CEP = @CEP, NUMERO_CASA = @NUMERO_CASA, BAIRRO_ID = @BAIRRO_ID, RUA = @RUA, COMPLEMENTO = @COMPLEMENTO WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CEP", endereco.CEP);
            command.Parameters.AddWithValue("@NUMERO_CASA", endereco.NumeroCasa);
            command.Parameters.AddWithValue("@BAIRRO_ID", endereco.BairroID);
            command.Parameters.AddWithValue("@RUA", endereco.Rua);
            command.Parameters.AddWithValue("@COMPLEMENTO", endereco.Complemento);
            command.Parameters.AddWithValue("@ID", endereco.ID);
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
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response Delete(int id)
        {
            string sql = "DELETE FROM ENDERECOS WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
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
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<Endereco> GetAll()
        {
            string sql = $"SELECT ID,CEP,NUMERO_CASA,BAIRRO_ID,RUA,COMPLEMENTO FROM ENDERECOS";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Endereco> enderecos = new List<Endereco>();
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
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<Endereco> GetByID(int id)
        {
            string sql = $"SELECT ID,CEP,NUMERO_CASA,BAIRRO_ID,RUA,COMPLEMENTO FROM ENDERECOS WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
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
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<Endereco> GetByEndereco(Endereco item)
        {
            string sql = $"SELECT ID,CEP,NUMERO_CASA,BAIRRO_ID,RUA,COMPLEMENTO FROM ENDERECOS WHERE CEP = @CEP AND NUMERO_CASA = @NUMERO_CASA AND BAIRRO_ID = @BAIRRO_ID AND RUA = @RUA";
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
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<Endereco> CountById(int id)
        {
            string sql = $"SELECT COUNT(*) FROM FUNCIONARIOS WHERE ENDERECO = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
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
            finally
            {
                connection.Dispose();
            }
        }
    }
}
