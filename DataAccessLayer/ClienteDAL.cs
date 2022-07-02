using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ClienteDAL : ICRUD<Cliente>
    {

        string connectionString = ConnectionString._connectionString;

        public Response Insert(Cliente cliente)
        {
            string sql = $"INSERT INTO CLIENTES (NOME,RG,CPF,TELEFONE1,TELEFONE2,EMAIL,PONTOS,TIPO_CLIENTE_ID,GENEROS_ID,DATA_NASCIMENTO) VALUES (@NOME,@RG,@CPF,@TELEFONE1,@TELEFONE2,@EMAIL,@PONTOS,@TIPO_CLIENTE_ID,@GENEROS_ID,@DATA_NASCIMENTO)";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", cliente.Nome);
            command.Parameters.AddWithValue("@RG", cliente.RG);
            command.Parameters.AddWithValue("@CPF", cliente.CPF);
            command.Parameters.AddWithValue("@TELEFONE1", cliente.Telefone1);
            command.Parameters.AddWithValue("@TELEFONE2", cliente.Telefone2);
            command.Parameters.AddWithValue("@EMAIL", cliente.Email);
            command.Parameters.AddWithValue("@PONTOS", cliente.Pontos);
            command.Parameters.AddWithValue("@TIPO_CLIENTE_ID", cliente.TipoClienteId);
            command.Parameters.AddWithValue("@GENEROS_ID", cliente.GeneroId);
            command.Parameters.AddWithValue("@DATA_NASCIMENTO", cliente.DataNascimento);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Cliente cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_CLIENTES_EMAIL"))
                {
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_CLIENTES_CPF"))
                {
                    return new Response("CPF já está em uso.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response Update(Cliente cliente)
        {
            string sql = $"UPDATE CLIENTES SET NOME = @NOME, RG = @RG, CPF = @CPF,EMAIL = @EMAIL, TELEFONE1 = @TELEFONE1, TELEFONE2 = @TELEFONE2,PONTOS = @PONTOS,TIPO_CLIENTE_ID = @TIPO_CLIENTE_ID,GENEROS_ID = @GENEROS_ID,DATA_NASCIMENTO = @DATA_NASCIMENTO WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", cliente.Nome);
            command.Parameters.AddWithValue("@RG", cliente.RG);
            command.Parameters.AddWithValue("@CPF", cliente.CPF);
            command.Parameters.AddWithValue("@EMAIL", cliente.Email);
            command.Parameters.AddWithValue("@TELEFONE1", cliente.Telefone1);
            command.Parameters.AddWithValue("@TELEFONE2", cliente.Telefone2);
            command.Parameters.AddWithValue("@PONTOS", cliente.Pontos);
            command.Parameters.AddWithValue("@TIPO_CLIENTE_ID", cliente.TipoClienteId);
            command.Parameters.AddWithValue("@GENEROS_ID", cliente.GeneroId);
            command.Parameters.AddWithValue("@DATA_NASCIMENTO", cliente.DataNascimento);
            command.Parameters.AddWithValue("@ID", cliente.ID);
            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Cliente excluido.", false);
                }
                return new Response("Cliente alterado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_CLIENTES_EMAIL"))
                {
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_CLIENTES_CPF"))
                {
                    return new Response("CPF já está em uso.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response UpdatePontos(Cliente cliente)
        {
            string sql = $"UPDATE CLIENTES SET PONTOS = @PONTOS WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@PONTOS", cliente.Pontos);
            command.Parameters.AddWithValue("@ID", cliente.ID);
            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Cliente excluido.", false);
                }
                return new Response("Cliente alterado com sucesso.", true);
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
            string sql = "DELETE FROM CLIENTES WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                int qtdLinhasExcluidas = command.ExecuteNonQuery();
                if (qtdLinhasExcluidas == 1)
                {
                    return new Response("Cliente excluído com sucesso.", true);
                }
                return new Response("Cliente não excluído.", false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_SAIDAS_CLIENTE"))
                {
                    return new Response("Não é possivel excluir uma Cliente que tenha uma Venda cadastrada.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<ClienteView> GetAllClienteView()
        {
            string sql = $"SELECT C.ID,C.NOME,C.RG,C.CPF,C.TELEFONE1,C.TELEFONE2,C.EMAIL,C.PONTOS,C.DATA_NASCIMENTO,TP.NOME AS TIPOS_CLIENTES,G.NOME AS GENEROS FROM CLIENTES C INNER JOIN TIPOS_CLIENTES TP ON C.TIPO_CLIENTE_ID = TP.ID INNER JOIN GENEROS G ON C.GENEROS_ID = G.ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<ClienteView> clientes = new List<ClienteView>();
                while (reader.Read())
                {
                    ClienteView cliente = new ClienteView();
                    cliente.ID = Convert.ToInt32(reader["ID"]);
                    cliente.Nome = Convert.ToString(reader["NOME"]);
                    cliente.RG = Convert.ToString(reader["RG"]);
                    cliente.CPF = Convert.ToString(reader["CPF"]);
                    cliente.Telefone1 = Convert.ToString(reader["TELEFONE1"]);
                    cliente.Telefone2 = Convert.ToString(reader["TELEFONE2"]);
                    cliente.Email = Convert.ToString(reader["EMAIL"]);
                    cliente.Pontos = Convert.ToInt32(reader["PONTOS"]);
                    cliente.TipoCliente = Convert.ToString(reader["TIPOS_CLIENTES"]);
                    cliente.Genero = Convert.ToString(reader["GENEROS"]);
                    cliente.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                    clientes.Add(cliente);
                }
                return new DataResponse<ClienteView>("Clientes selecionados com sucesso!", true, clientes);
            }
            catch (Exception ex)
            {
                return new DataResponse<ClienteView>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<Cliente> GetAll()
        {
            string sql = $"SELECT ID,NOME,RG,CPF,TELEFONE1,TELEFONE2,EMAIL,PONTOS,TIPO_CLIENTE_ID, GENEROS_ID, DATA_NASCIMENTO FROM CLIENTES";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Cliente> clientes = new List<Cliente>();
                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.ID = Convert.ToInt32(reader["ID"]);
                    cliente.Nome = Convert.ToString(reader["NOME"]);
                    cliente.RG = Convert.ToString(reader["RG"]);
                    cliente.CPF = Convert.ToString(reader["CPF"]);
                    cliente.Telefone1 = Convert.ToString(reader["TELEFONE1"]);
                    cliente.Telefone2 = Convert.ToString(reader["TELEFONE2"]);
                    cliente.Email = Convert.ToString(reader["EMAIL"]);
                    cliente.Pontos = Convert.ToInt32(reader["PONTOS"]);
                    cliente.TipoClienteId = Convert.ToInt32(reader["TIPO_CLIENTE_ID"]);
                    cliente.GeneroId = Convert.ToInt32(reader["GENEROS_ID"]);
                    cliente.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                    clientes.Add(cliente);
                }
                return new DataResponse<Cliente>("Clientes selecionados com sucesso!", true, clientes);
            }
            catch (Exception ex)
            {
                return new DataResponse<Cliente>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<Cliente> GetByID(int id)
        {
            string sql = $"SELECT ID,NOME,RG,CPF,TELEFONE1,TELEFONE2,EMAIL,PONTOS,TIPO_CLIENTE_ID,GENEROS_ID, DATA_NASCIMENTO FROM CLIENTES WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.ID = Convert.ToInt32(reader["ID"]);
                    cliente.Nome = Convert.ToString(reader["NOME"]);
                    cliente.RG = Convert.ToString(reader["RG"]);
                    cliente.CPF = Convert.ToString(reader["CPF"]);
                    cliente.Telefone1 = Convert.ToString(reader["TELEFONE1"]);
                    cliente.Telefone2 = Convert.ToString(reader["TELEFONE2"]);
                    cliente.Email = Convert.ToString(reader["EMAIL"]);
                    cliente.Pontos = Convert.ToInt32(reader["PONTOS"]);
                    cliente.TipoClienteId = Convert.ToInt32(reader["TIPO_CLIENTE_ID"]);
                    cliente.GeneroId = Convert.ToInt32(reader["GENEROS_ID"]);
                    cliente.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                    return new SingleResponse<Cliente>("Cliente selecionado com sucesso!", true, cliente);
                }
                return new SingleResponse<Cliente>("Cliente não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Cliente>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<Cliente> GetByCPF(string cPF)
        {
            string sql = $"SELECT ID,NOME,RG,CPF,TELEFONE1,TELEFONE2,EMAIL,PONTOS,TIPO_CLIENTE_ID,GENEROS_ID, DATA_NASCIMENTO FROM CLIENTES WHERE CPF = @CPF";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CPF", cPF);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.ID = Convert.ToInt32(reader["ID"]);
                    cliente.Nome = Convert.ToString(reader["NOME"]);
                    cliente.RG = Convert.ToString(reader["RG"]);
                    cliente.CPF = Convert.ToString(reader["CPF"]);
                    cliente.Telefone1 = Convert.ToString(reader["TELEFONE1"]);
                    cliente.Telefone2 = Convert.ToString(reader["TELEFONE2"]);
                    cliente.Email = Convert.ToString(reader["EMAIL"]);
                    cliente.Pontos = Convert.ToInt32(reader["PONTOS"]);
                    cliente.TipoClienteId = Convert.ToInt32(reader["TIPO_CLIENTE_ID"]);
                    cliente.GeneroId = Convert.ToInt32(reader["GENEROS_ID"]);
                    cliente.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                    return new SingleResponse<Cliente>("Cliente selecionado com sucesso!", true, cliente);
                }
                return new SingleResponse<Cliente>("Cliente não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Cliente>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
