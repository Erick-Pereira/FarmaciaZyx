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
    public class GeneroDAL
    {
        string connectionString = ConnectionString._connectionString;
        public DataResponse<Generos> GetAll()
        {
            string sql = $"SELECT ID,NOME FROM GENEROS";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Generos> generos = new List<Generos>();
                while (reader.Read())
                {
                    Generos genero = new Generos();
                    genero.ID = Convert.ToInt32(reader["ID"]);
                    genero.Nome = Convert.ToString(reader["NOME"]);
                    generos.Add(genero);
                }
                return new DataResponse<Generos>("Tipos de Clientes selecionados com sucesso!", true, generos);
            }
            catch (Exception ex)
            {
                return new DataResponse<Generos>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<Generos> GetByID(int id)
        {
            string sql = $"SELECT ID,NOME FROM GENEROS WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Generos genero = new Generos();
                    genero.ID = Convert.ToInt32(reader["ID"]);
                    genero.Nome = Convert.ToString(reader["NOME"]);
                    return new SingleResponse<Generos>("Tipo de Cliente selecionado com sucesso!", true, genero);
                }
                return new SingleResponse<Generos>("Tipo de Cliente não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Generos>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
