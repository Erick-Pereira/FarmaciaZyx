using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class EstadoDAL : ICRUD<Estado>
    {

        string connectionString = ConnectionString._connectionString;
        /// <summary>
        /// Recebe um Estado e insere no banco de dados
        /// </summary>
        /// <param name="estado"></param>
        /// <returns>Retorna um Response informado se teve sucesso</returns>
        public Response Insert(Estado estado)
        {
            string sql = $"INSERT INTO ESTADOS (NOME_ESTADO,SIGLA) VALUES (@NOME_ESTADO,@SIGLA)";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME_ESTADO", estado.NomeEstado);
            command.Parameters.AddWithValue("@SIGLA", estado.Sigla);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Estado cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_ESTADOS_SIGLA"))
                {
                    return new Response("Estado sigla já está em uso.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }
        /// <summary>
        /// Recebe um Estado e faz o update no banco de dados
        /// </summary>
        /// <param name="estado"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Update(Estado estado)
        {
            string sql = $"UPDATE ESTADOS SET NOME_ESTADO = @NOME_ESTADO, SIGLA = @SIGLA WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME_ESTADO", estado.NomeEstado);
            command.Parameters.AddWithValue("@SIGLA", estado.Sigla);
            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Estado excluido.", false);
                }
                return new Response("Estado alterado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_ESTADOS_SIGLA"))
                {
                    return new Response("Estado sigla já está em uso.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }
        /// <summary>
        /// Recebe um ID, acessa o banco de dados e deleta um Estado
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Delete(int id)
        {
            string sql = "DELETE FROM ESTADOS WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                int qtdLinhasExcluidas = command.ExecuteNonQuery();
                if (qtdLinhasExcluidas == 1)
                {
                    return new Response("Estado excluído com sucesso.", true);
                }
                return new Response("Estado não excluído.", false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_CIDADES_ESTADO"))
                {
                    return new Response("Não é possivel excluir um Estado que tenha uma Cidade cadastrada.", false);
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
        /// <returns>Retorna um DataResponse contendo todos os estados cadastrados no banco de dados</returns>
        public DataResponse<Estado> GetAll()
        {
            string sql = $"SELECT ID,NOME_ESTADO,SIGLA FROM ESTADOS";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Estado> estados = new List<Estado>();
                while (reader.Read())
                {
                    Estado estado = new Estado();
                    estado.ID = Convert.ToInt32(reader["ID"]);
                    estado.NomeEstado = Convert.ToString(reader["NOME_ESTADO"]);
                    estado.Sigla = Convert.ToString(reader["SIGLA"]);
                    estados.Add(estado);
                }
                return new DataResponse<Estado>("Estados selecionados com sucesso!", true, estados);
            }
            catch (Exception ex)
            {
                return new DataResponse<Estado>("Erro no banco de dados, contate o administrador.", false, null);
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
        /// <returns>Retorna um SingleResponse com o Estado referente ao ID informado</returns>
        public SingleResponse<Estado> GetByID(int id)
        {
            string sql = $"SELECT ID,NOME_ESTADO,SIGLA FROM ESTADOS WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Estado estado = new Estado();
                    estado.ID = Convert.ToInt32(reader["ID"]);
                    estado.NomeEstado = Convert.ToString(reader["NOME_ESTADO"]);
                    estado.Sigla = Convert.ToString(reader["SIGLA"]);
                    return new SingleResponse<Estado>("Estado selecionado com sucesso!", true, estado);
                }
                return new SingleResponse<Estado>("Estado não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Estado>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
