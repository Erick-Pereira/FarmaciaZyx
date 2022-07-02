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
    public class TipoClienteDAL
    {
        string connectionString = ConnectionString._connectionString;
        public DataResponse<TipoCliente> GetAll()
        {
            string sql = $"SELECT ID,NOME FROM TIPOS_CLIENTES";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<TipoCliente> tipoClientes = new List<TipoCliente>();
                while (reader.Read())
                {
                    TipoCliente tipoCliente = new TipoCliente();
                    tipoCliente.ID = Convert.ToInt32(reader["ID"]);
                    tipoCliente.Nome = Convert.ToString(reader["NOME"]);
                    tipoClientes.Add(tipoCliente);
                }
                return new DataResponse<TipoCliente>("Tipos de Clientes selecionados com sucesso!", true, tipoClientes);
            }
            catch (Exception ex)
            {
                return new DataResponse<TipoCliente>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<TipoCliente> GetByID(int id)
        {
            string sql = $"SELECT ID,NOME FROM TIPOS_CLIENTES WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    TipoCliente tipoCliente = new TipoCliente();
                    tipoCliente.ID = Convert.ToInt32(reader["ID"]);
                    tipoCliente.Nome = Convert.ToString(reader["NOME"]);
                    return new SingleResponse<TipoCliente>("Tipo de Cliente selecionado com sucesso!", true, tipoCliente);
                }
                return new SingleResponse<TipoCliente>("Tipo de Cliente não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<TipoCliente>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
