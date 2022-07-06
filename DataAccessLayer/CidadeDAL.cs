using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class CidadeDAL : ICRUD<Cidade>
    {
        string connectionString = ConnectionString._connectionString;
        /// <summary>
        /// Recebe uma Cidade e insere no banco de dados
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Insert(Cidade item)
        {
            string sql = $"INSERT INTO CIDADES (NOME_CIDADE,ESTADO_ID) VALUES (@NOME_CIDADE,@ESTADO_ID); SELECT SCOPE_IDENTITY()";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME_CIDADE", item.NomeCidade);
            command.Parameters.AddWithValue("@ESTADO_ID", item.EstadoId);
            try
            {
                connection.Open();
                item.ID = Convert.ToInt32(command.ExecuteScalar());
                return new Response("Cidade cadastrado com sucesso.", true);
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
        /// <summary>
        /// Recebe uma Cidade e faz o update no banco de dados
        /// </summary>
        /// <param name="cidade"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Update(Cidade cidade)
        {
            string sql = $"UPDATE CIDADES SET NOME_CIDADE = @NOME_CIDADE, ESTADO_ID = @ESTADO_ID WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME_CIDADE", cidade.NomeCidade);
            command.Parameters.AddWithValue("@ESTADO_ID", cidade.EstadoId);
            command.Parameters.AddWithValue("@ID", cidade.ID);
            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Cidade excluida.", false);
                }
                return new Response("Cidade alterado com sucesso.", true);
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
        /// <summary>
        /// Recebe um ID, acessa o banco de dados e deleta uma Cidade
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Delete(int id)
        {
            string sql = "DELETE FROM CIDADES WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                int qtdLinhasExcluidas = command.ExecuteNonQuery();
                if (qtdLinhasExcluidas == 1)
                {
                    return new Response("Cidade excluída com sucesso.", true);
                }
                return new Response("Cidade não excluída.", false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_BAIRROS_CIDADE"))
                {
                    return new Response("Não é possivel excluir uma Cidade que tenha um Bairro cadastrado.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }
        /// <summary>
        /// Acessa o banco de dados e retorna um DataResponse
        /// </summary>
        /// <returns>Retorna um DataResponse </returns>
        public DataResponse<Cidade> GetAll()
        {
            string sql = $"SELECT ID,NOME_CIDADE,ESTADO_ID FROM CIDADES";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Cidade> cidades = new List<Cidade>();
                while (reader.Read())
                {
                    Cidade cidade = new Cidade();
                    cidade.ID = Convert.ToInt32(reader["ID"]);
                    cidade.NomeCidade = Convert.ToString(reader["NOME_CIDADE"]);
                    cidade.EstadoId = Convert.ToInt32(reader["ESTADO_ID"]);
                    cidades.Add(cidade);
                }
                return new DataResponse<Cidade>("Cidades selecionados com sucesso!", true, cidades);
            }
            catch (Exception ex)
            {
                return new DataResponse<Cidade>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        /// <summary>
        /// Recebe um ID e retorna um SingleResponse
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um SingleResponse contendo uma Cidade referente ao ID informado</returns>
        public SingleResponse<Cidade> GetByID(int id)
        {
            string sql = $"SELECT ID,NOME_CIDADE,ESTADO_ID FROM CIDADES WHERE ID = @ID"; 
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Cidade cidade = new Cidade();
                    cidade.ID = Convert.ToInt32(reader["ID"]);
                    cidade.NomeCidade = Convert.ToString(reader["NOME_CIDADE"]);
                    cidade.EstadoId = Convert.ToInt32(reader["ESTADO_ID"]);
                    return new SingleResponse<Cidade>("Cidade selecionado com sucesso!", true, cidade);
                }
                return new SingleResponse<Cidade>("Cidade não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Cidade>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        /// <summary>
        /// Recebe uma Cidade e retorna um SingleResponse
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna um SingleResponse contendo uma Cidade com mesmo nome e ID do Estado</returns>
        public SingleResponse<Cidade> GetByNameAndEstadoId(Cidade item)
        {
            string sql = $"SELECT ID,NOME_CIDADE,ESTADO_ID FROM CIDADES WHERE NOME_CIDADE = @NOME_CIDADE AND ESTADO_ID = @ESTADO_ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME_CIDADE", item.NomeCidade);
            command.Parameters.AddWithValue("@ESTADO_ID", item.EstadoId);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Cidade cidade = new Cidade();
                    cidade.ID = Convert.ToInt32(reader["ID"]);
                    cidade.NomeCidade = Convert.ToString(reader["NOME_CIDADE"]);
                    cidade.EstadoId = Convert.ToInt32(reader["ESTADO_ID"]);
                    return new SingleResponse<Cidade>("Cidade selecionado com sucesso!", true, cidade);
                }
                return new SingleResponse<Cidade>("Cidade não encontrado!", true, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Cidade>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
