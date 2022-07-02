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
    public class TipoUnidadeDAL
    {
        string connectionString = ConnectionString._connectionString;
        public DataResponse<TipoUnidade> GetAll()
        {
            string sql = $"SELECT ID,NOME,CASAS_DECIMAIS FROM TIPOS_UNIDADES";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<TipoUnidade> tipoUnidades = new List<TipoUnidade>();
                while (reader.Read())
                {
                    TipoUnidade tipoUnidade = new TipoUnidade();
                    tipoUnidade.ID = Convert.ToInt32(reader["ID"]);
                    tipoUnidade.Nome = Convert.ToString(reader["NOME"]);
                    tipoUnidade.CasasDecimais = Convert.ToInt32(reader["CASAS_DECIMAIS"]);
                    tipoUnidades.Add(tipoUnidade);
                }
                return new DataResponse<TipoUnidade>("Tipos de Unidade selecionados com sucesso!", true, tipoUnidades);
            }
            catch (Exception ex)
            {
                return new DataResponse<TipoUnidade>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<TipoUnidade> GetByID(int id)
        {
            string sql = $"SELECT ID,NOME,CASAS_DECIMAIS FROM TIPOS_UNIDADES WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    TipoUnidade tipoUnidade = new TipoUnidade();
                    tipoUnidade.ID = Convert.ToInt32(reader["ID"]);
                    tipoUnidade.Nome = Convert.ToString(reader["NOME"]);
                    tipoUnidade.CasasDecimais = Convert.ToInt32(reader["CASAS_DECIMAIS"]);
                    return new SingleResponse<TipoUnidade>("Tipo de Unidade selecionado com sucesso!", true, tipoUnidade);
                }
                return new SingleResponse<TipoUnidade>("Tipo de Unidade não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<TipoUnidade>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
