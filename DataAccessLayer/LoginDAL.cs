using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class LoginDAL
    {
        public SingleResponse<Funcionario> GetByEmail(string email)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,EMAIL,SENHA,TIPO_FUNCIONARIO_ID FROM FUNCIONARIOS WHERE EMAIL = @EMAIL";

            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\The_Shelow\Documents\FarmaciaZyx.mdf; Integrated Security = True; Connect Timeout = 3";

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@EMAIL", email);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                //Enquanto houver registros, o loop será executado!
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
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
    }
}
