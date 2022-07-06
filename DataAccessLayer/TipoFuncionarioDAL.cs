using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TipoFuncionarioDAL
    {
        string connectionString = ConnectionString._connectionString;
        /// <summary>
        /// Acessa o banco de dados e retorna um DataResponse
        /// </summary>
        /// <returns>Retorna um DataResponse contendo todos os tipos de funcionario cadastrados no banco </returns>
        public DataResponse<TipoFuncionario> GetAll()
        {
            string sql = $"SELECT ID,NOME FROM TIPOS_FUNCIONARIOS";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<TipoFuncionario> tipoFuncionarios = new List<TipoFuncionario>();
                while (reader.Read())
                {
                    TipoFuncionario tipoFuncionario = new TipoFuncionario();
                    tipoFuncionario.ID = Convert.ToInt32(reader["ID"]);
                    tipoFuncionario.Nome = Convert.ToString(reader["NOME"]);
                    tipoFuncionarios.Add(tipoFuncionario);
                }
                return new DataResponse<TipoFuncionario>("Tipos de Funcionarios selecionados com sucesso!", true, tipoFuncionarios);
            }
            catch (Exception ex)
            {
                return new DataResponse<TipoFuncionario>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        /// <summary>
        /// Recebe um ID, acessa o banco de dados e retorna um SingleResponse
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um SingleResponse contendo um tipo de funcionario cadastrada no banco de dados</returns>
        public SingleResponse<TipoFuncionario> GetByID(int id)
        {
            string sql = $"SELECT ID,NOME FROM TIPOS_FUNCIONARIOS WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    TipoFuncionario tipoFuncionario = new TipoFuncionario();
                    tipoFuncionario.ID = Convert.ToInt32(reader["ID"]);
                    tipoFuncionario.Nome = Convert.ToString(reader["NOME"]);
                    return new SingleResponse<TipoFuncionario>("Tipo de Funcionario selecionado com sucesso!", true, tipoFuncionario);
                }
                return new SingleResponse<TipoFuncionario>("Tipo de Funcionario não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<TipoFuncionario>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
