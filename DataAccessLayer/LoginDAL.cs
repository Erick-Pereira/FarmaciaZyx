using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class LoginDAL
    {
        string connectionString = ConnectionString._connectionString;

        public SingleResponse<Funcionario> GetByEmail(string email)
        {
            string sql = $"SELECT ID,EMAIL,SENHA,TIPO_FUNCIONARIO_ID FROM FUNCIONARIOS WHERE EMAIL = @EMAIL";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@EMAIL", email);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario.ID = Convert.ToInt32(reader["ID"]);
                    funcionario.Email = Convert.ToString(reader["EMAIL"]);
                    funcionario.Senha = Convert.ToString(reader["SENHA"]);
                    funcionario.TipoFuncionarioId = Convert.ToInt32(reader["TIPO_FUNCIONARIO_ID"]);
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
    }
}
