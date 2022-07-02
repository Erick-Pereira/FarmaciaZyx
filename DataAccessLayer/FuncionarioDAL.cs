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
            string sql = $"INSERT INTO FUNCIONARIOS (NOME,CPF,RG,TELEFONE,EMAIL,SENHA,ENDERECO_ID,TIPO_FUNCIONARIO_ID,GENEROS_ID, DATA_NASCIMENTO) VALUES (@NOME,@CPF,@RG,@TELEFONE,@EMAIL,@SENHA,@ENDERECO_ID,@TIPO_FUNCIONARIO_ID,@GENEROS_ID,@DATA_NASCIMENTO)";
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
            command.Parameters.AddWithValue("@GENEROS_ID", funcionario.GeneroId);
            command.Parameters.AddWithValue("@DATA_NASCIMENTO", funcionario.DataNascimento);
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
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_FUNCIONARIO_CPF"))
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

        public Response Update(Funcionario funcionario)
        {
            string sql = $"UPDATE FUNCIONARIOS SET NOME = @NOME,RG = @RG ,  CPF = @CPF, TELEFONE = @TELEFONE,EMAIL = @EMAIL, ENDERECO_ID = @ENDERECO_ID, TIPO_FUNCIONARIO_ID = @TIPO_FUNCIONARIO_ID, GENEROS_ID = @GENEROS_ID,DATA_NASCIMENTO = @DATA_NASCIMENTO WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", funcionario.Nome);
            command.Parameters.AddWithValue("@RG", funcionario.RG);
            command.Parameters.AddWithValue("@CPF", funcionario.CPF);
            command.Parameters.AddWithValue("@TELEFONE", funcionario.Telefone);
            command.Parameters.AddWithValue("@EMAIL", funcionario.Email);
            command.Parameters.AddWithValue("@ENDERECO_ID", funcionario.EnderecoId);
            command.Parameters.AddWithValue("@TIPO_FUNCIONARIO_ID", funcionario.TipoFuncionarioId);
            command.Parameters.AddWithValue("@GENEROS_ID", funcionario.GeneroId);
            command.Parameters.AddWithValue("@ID", funcionario.ID);
            command.Parameters.AddWithValue("@DATA_NASCIMENTO", funcionario.DataNascimento);
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
                    return new Response("CPF já existe.", false);
                }
                if (ex.Message.Contains("UQ_FUNCIONARIO_EMAIL"))
                {
                    return new Response("Email já está em uso.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public Response UpdateSenha(Funcionario funcionario)
        {
            string sql = $"UPDATE FUNCIONARIOS SET SENHA = @SENHA WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@SENHA", funcionario.Senha);
            command.Parameters.AddWithValue("@ID", funcionario.ID);
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
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public Response Delete(int id)
        {
            string sql = "DELETE FROM FUNCIONARIOS WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
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
                if (ex.Message.Contains("FK_ENTRADAS_FUNCIONARIO"))
                {
                    return new Response("Não é possivel excluir um Funcionario que tenha uma Entrada cadastrada", false);
                }
                if (ex.Message.Contains("FK_SAIDAS_FUNCIONARIO"))
                {
                    return new Response("Não é possivel excluir um Funcionario que tenha uma Venda cadastrada", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public DataResponse<FuncionarioView> GetAllFuncionarioView()
        {
            string sql = $"SELECT F.ID,F.NOME,F.CPF,F.RG,F.EMAIL,F.TELEFONE,F.DATA_NASCIMENTO, TF.NOME AS TIPOS_FUNCIONARIOS, G.NOME AS GENEROS FROM FUNCIONARIOS F INNER JOIN TIPOS_FUNCIONARIOS TF ON F.TIPO_FUNCIONARIO_ID = TF.ID INNER JOIN GENEROS G ON F.GENEROS_ID = G.ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<FuncionarioView> funcionarios = new List<FuncionarioView>();
                while (reader.Read())
                {
                    FuncionarioView funcionario = new FuncionarioView();
                    funcionario.ID = Convert.ToInt32(reader["ID"]);
                    funcionario.Nome = Convert.ToString(reader["NOME"]);
                    funcionario.CPF = Convert.ToString(reader["CPF"]);
                    funcionario.RG = Convert.ToString(reader["RG"]);
                    funcionario.Email = Convert.ToString(reader["EMAIL"]);
                    funcionario.Telefone = Convert.ToString(reader["TELEFONE"]);
                    funcionario.TipoFuncionario = Convert.ToString(reader["TIPOS_FUNCIONARIOS"]);
                    funcionario.Genero = Convert.ToString(reader["GENEROS"]);
                    funcionario.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                    funcionarios.Add(funcionario);
                }
                return new DataResponse<FuncionarioView>("Funcionarios selecionados com sucesso!", true, funcionarios);
            }
            catch (Exception ex)
            {
                return new DataResponse<FuncionarioView>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public DataResponse<Funcionario> GetAll()
        {
            string sql = $"SELECT ID,NOME,CPF,RG,EMAIL,TELEFONE,ENDERECO_ID,TIPO_FUNCIONARIO_ID,GENEROS_ID,DATA_NASCIMENTO FROM FUNCIONARIOS";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Funcionario> funcionarios = new List<Funcionario>();
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
                    funcionario.GeneroId = Convert.ToInt32(reader["GENEROS_ID"]);
                    funcionario.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                    funcionarios.Add(funcionario);
                }
                return new DataResponse<Funcionario>("Funcionarios selecionados com sucesso!", true, funcionarios);
            }
            catch (Exception ex)
            {
                return new DataResponse<Funcionario>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<Funcionario> GetByID(int id)
        {
            string sql = $"SELECT ID,NOME,RG,CPF,EMAIL,TELEFONE,ENDERECO_ID,TIPO_FUNCIONARIO_ID,GENEROS_ID, DATA_NASCIMENTO FROM FUNCIONARIOS WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
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
                    funcionario.GeneroId = Convert.ToInt32(reader["GENEROS_ID"]);
                    funcionario.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);

                    return new SingleResponse<Funcionario>("Funcionario selecionado com sucesso!", true, funcionario);
                }
                return new SingleResponse<Funcionario>("Funcionario não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Funcionario>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<Funcionario> GetSenhaByID(int id)
        {
            string sql = $"SELECT ID,SENHA FROM FUNCIONARIOS WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
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
            finally
            {
                connection.Dispose();
            }
        }
        public DataResponse<Funcionario> GetAllByEnderecoId(int idEndereco)
        {
            string sql = $"SELECT ID,NOME,CPF,RG,EMAIL,TELEFONE,ENDERECO_ID,TIPO_FUNCIONARIO_ID,GENEROS_ID, DATA_NASCIMENTO FROM FUNCIONARIOS WHERE ENDERECO_ID = @ENDERECO_ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ENDERECO_ID", idEndereco);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Funcionario> funcionarios = new List<Funcionario>();
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
                    funcionario.GeneroId = Convert.ToInt32(reader["GENEROS_ID"]);
                    funcionario.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                    funcionarios.Add(funcionario);
                }
                return new DataResponse<Funcionario>("Funcionarios selecionados com sucesso!", true, funcionarios);
            }
            catch (Exception ex)
            {
                return new DataResponse<Funcionario>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}