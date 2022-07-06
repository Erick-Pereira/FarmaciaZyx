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
    public class FormaPagamentoDAL
    {
        string connectionString = ConnectionString._connectionString;
        /// <summary>
        /// Acessa o banco de dados e retorna um DataResponse
        /// </summary>
        /// <returns>Retorna um DataResponse contendo todas as Formas de Pagamento cadastradas no banco de dados</returns>
        public DataResponse<FormaPagamento> GetAll()
        {
            string sql = $"SELECT ID,NOME FROM FORMAS_PAGAMENTO";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<FormaPagamento> formasPagamentos = new List<FormaPagamento>();
                while (reader.Read())
                {
                    FormaPagamento formaPagamento = new FormaPagamento();
                    formaPagamento.ID = Convert.ToInt32(reader["ID"]);
                    formaPagamento.Nome = Convert.ToString(reader["NOME"]);
                    formasPagamentos.Add(formaPagamento);
                }
                return new DataResponse<FormaPagamento>("Formas de Pagamento selecionadas com sucesso!", true, formasPagamentos);
            }
            catch (Exception ex)
            {
                return new DataResponse<FormaPagamento>("Erro no banco de dados, contate o administrador.", false, null);
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
        /// <returns>Retorna um SingleResponse contendo uma Forma de Pagamento referente ao ID informado</returns>
        public SingleResponse<FormaPagamento> GetByID(int id)
        {
            string sql = $"SELECT ID,NOME FROM FORMAS_PAGAMENTO WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    FormaPagamento formaPagamento = new FormaPagamento();
                    formaPagamento.ID = Convert.ToInt32(reader["ID"]);
                    formaPagamento.Nome = Convert.ToString(reader["NOME"]);
                    return new SingleResponse<FormaPagamento>("Forma de Pagamento selecionada com sucesso!", true, formaPagamento);
                }
                return new SingleResponse<FormaPagamento>("Forma de Pagamento não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<FormaPagamento>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
