using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class BairroDAL : ICRUD<Bairro>
    {
        string connectionString = ConnectionString._connectionString;
        /// <summary>
        /// Recebe um Bairro e insere no banco de dados
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Insert(Bairro item)
        {
            string sql = $"INSERT INTO BAIRROS (NOME_BAIRRO,CIDADE_ID) VALUES (@NOME_BAIRRO,@CIDADE_ID); SELECT SCOPE_IDENTITY()";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME_BAIRRO", item.NomeBairro);
            command.Parameters.AddWithValue("@CIDADE_ID", item.CidadeId);
            try
            {
                connection.Open();
                item.ID = Convert.ToInt32(command.ExecuteScalar());
                return new Response("Bairro cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_ENDERECOS_BAIRRO"))
                {
                    //RETORNAR MENSAGEM QUE O CPF TA DUPLICADO
                    return new Response("Não é possivel excluir um bairro que tenha um endereço cadastrado.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }
        /// <summary>
        /// Recebe um Bairro e faz o update no banco de dados
        /// </summary>
        /// <param name="bairro"></param>
        /// <returns>Retorna um Response se teve sucesso</returns>
        public Response Update(Bairro bairro)
        {
            string sql = $"UPDATE BAIRROS SET NOME_BAIRRO = @NOME_BAIRRO, CIDADE_ID = @CIDADE_ID WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME_BAIRRO", bairro.NomeBairro);
            command.Parameters.AddWithValue("@CIDADE_ID", bairro.CidadeId);
            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Bairro excluido.", false);
                }
                return new Response("Bairro alterado com sucesso.", true);
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
        /// Recebe um ID, acessa o banco de dados e deleta um Bairro
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Delete(int id)
        {
            string sql = "DELETE FROM BAIRROS WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                int qtdLinhasExcluidas = command.ExecuteNonQuery();
                if (qtdLinhasExcluidas == 1)
                {
                    return new Response("Bairro excluído com sucesso.", true);
                }
                return new Response("Bairro não excluído.", false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_ENDERECOS_BAIRRO"))
                {
                    //RETORNAR MENSAGEM QUE O CPF TA DUPLICADO
                    return new Response("Não é possivel excluir um Bairro que tenha um Endereço cadastrado.", false);
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
        /// <returns>Retorna um DataResponse contendo todos os Bairros cadastrados no banco de dados</returns>
        public DataResponse<Bairro> GetAll()
        {
            string sql = $"SELECT ID,NOME_BAIRRO,CIDADE_ID FROM BAIRROS";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Bairro> bairros = new List<Bairro>();
                while (reader.Read())
                {
                    Bairro bairro = new Bairro();
                    bairro.ID = Convert.ToInt32(reader["ID"]);
                    bairro.NomeBairro = Convert.ToString(reader["NOME_BAIRRO"]);
                    bairro.CidadeId = Convert.ToInt32(reader["CIDADE_ID"]);
                    bairros.Add(bairro);
                }
                return new DataResponse<Bairro>("Bairros selecionados com sucesso!", true, bairros);
            }
            catch (Exception ex)
            {
                return new DataResponse<Bairro>("Erro no banco de dados, contate o administrador.", false, null);
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
        /// <returns>Retorna um SingleResponse contendo o Bairro referente ao ID informado</returns>
        public SingleResponse<Bairro> GetByID(int id)
        {
            string sql = $"SELECT ID,NOME_BAIRRO,CIDADE_ID FROM BAIRROS WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Bairro bairro = new Bairro();
                    bairro.ID = Convert.ToInt32(reader["ID"]);
                    bairro.NomeBairro = Convert.ToString(reader["NOME_BAIRRO"]);
                    bairro.CidadeId = Convert.ToInt32(reader["CIDADE_ID"]);
                    return new SingleResponse<Bairro>("Bairro selecionado com sucesso!", true, bairro);
                }
                return new SingleResponse<Bairro>("Bairro não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Bairro>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        /// <summary>
        /// Recebe um Bairro e retorna um SingleResponse
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna um SingleResponse contendo o Bairro com mesmo e com mesmo ID de Cidade</returns>
        public SingleResponse<Bairro> GetByNameAndCidadeId(Bairro item)
        {
            string sql = $"SELECT ID,NOME_BAIRRO,CIDADE_ID FROM BAIRROS WHERE NOME_BAIRRO = @NOME_BAIRRO AND CIDADE_ID = @CIDADE_ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME_BAIRRO", item.NomeBairro);
            command.Parameters.AddWithValue("@CIDADE_ID", item.CidadeId);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Bairro bairro = new Bairro();
                    bairro.ID = Convert.ToInt32(reader["ID"]);
                    bairro.NomeBairro = Convert.ToString(reader["NOME_BAIRRO"]);
                    bairro.CidadeId = Convert.ToInt32(reader["CIDADE_ID"]);
                    return new SingleResponse<Bairro>("Bairro selecionado com sucesso!", true, bairro);
                }
                return new SingleResponse<Bairro>("Bairro não encontrado!", true, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Bairro>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
