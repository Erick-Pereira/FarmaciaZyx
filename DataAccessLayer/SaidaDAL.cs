using Entities;
using Entities.Filters;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SaidaDAL
    {
        string connectionString = ConnectionString._connectionString;
        /// <summary>
        /// Recebe uma Saida e insere no banco de dados
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna um Response dizendo se teve sucesso ou não</returns>
        public Response Insert(Saida item)
        {
            string sql = $"INSERT INTO SAIDAS (VALOR,CLIENTE_ID,FUNCIONARIO_ID,DATA_SAIDA,FORMA_PAGAMENTO_ID,VALOR_TOTAL,DESCONTO) VALUES (@VALOR,@CLIENTE_ID,@FUNCIONARIO_ID,@DATA_SAIDA,@FORMA_PAGAMENTO_ID,@VALOR_TOTAL,@DESCONTO); SELECT SCOPE_IDENTITY()";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@VALOR", item.Valor);
            command.Parameters.AddWithValue("@VALOR_TOTAL", item.ValorTotal);
            command.Parameters.AddWithValue("@CLIENTE_ID", item.ClienteId);
            command.Parameters.AddWithValue("@FUNCIONARIO_ID", item.FuncionarioId);
            command.Parameters.AddWithValue("@DATA_SAIDA", item.DataSaida);
            command.Parameters.AddWithValue("@FORMA_PAGAMENTO_ID", item.FormaPagamentoId);
            command.Parameters.AddWithValue("@DESCONTO", item.Desconto);
            try
            {
                connection.Open();
                item.ID = Convert.ToInt32(command.ExecuteScalar());
                return new Response("Saida cadastrada com sucesso.", true);
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
        /// Acessa o banco de dados e retorna um DataResponse
        /// </summary>
        /// <returns>Retorna um Data Response contendo todas as Saidas cadastradas no banco de dados</returns>
        public DataResponse<SaidaView> GetAll()
        {
            string sql = $"SELECT S.ID,S.VALOR,S.DATA_SAIDA,S.VALOR_TOTAL,S.DESCONTO,C.NOME AS CLIENTES,FU.NOME AS FUNCIONARIOS,FP.NOME AS FORMAS_PAGAMENTOS FROM SAIDAS S INNER JOIN CLIENTES C ON S.CLIENTE_ID = C.ID INNER JOIN FUNCIONARIOS FU ON S.FUNCIONARIO_ID = FU.ID INNER JOIN FORMAS_PAGAMENTO FP ON S.FORMA_PAGAMENTO_ID = FP.ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<SaidaView> saidas = new List<SaidaView>();
                while (reader.Read())
                {
                    SaidaView saida = new SaidaView();
                    saida.ID = Convert.ToInt32(reader["ID"]);
                    saida.Valor = Convert.ToDouble(reader["VALOR"]);
                    saida.Cliente = Convert.ToString(reader["CLIENTES"]);
                    saida.Funcionario = Convert.ToString(reader["FUNCIONARIOS"]);
                    saida.DataSaida = Convert.ToDateTime(reader["DATA_SAIDA"]);
                    saida.FormaPagamento = Convert.ToString(reader["FORMAS_PAGAMENTOS"]);
                    saida.Desconto = Convert.ToDouble(reader["DESCONTO"]);
                    saida.ValorTotal = Convert.ToDouble(reader["VALOR_TOTAL"]);

                    saidas.Add(saida);
                }
                return new DataResponse<SaidaView>("Saidas selecionados com sucesso!", true, saidas);
            }
            catch (Exception ex)
            {
                return new DataResponse<SaidaView>("Erro no banco de dados, contate o administrador.", false, null);
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
        /// <returns>Retorna um SingleResponse contendo uma Saida referente ao ID informado</returns>
        public SingleResponse<SaidaView> GetSaidaViewByID(int id)
        {
            string sql = $"SELECT S.ID,S.VALOR,S.DATA_SAIDA,S.VALOR_TOTAL,S.DESCONTO,C.NOME AS CLIENTES,FU.NOME AS FUNCIONARIOS,FP.NOME AS FORMAS_PAGAMENTOS FROM SAIDAS S INNER JOIN CLIENTES C ON S.CLIENTE_ID = C.ID INNER JOIN FUNCIONARIOS FU ON S.FUNCIONARIO_ID = FU.ID INNER JOIN FORMAS_PAGAMENTO FP ON S.FORMA_PAGAMENTO_ID = FP.ID WHERE S.ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    SaidaView saida = new SaidaView();
                    saida.ID = Convert.ToInt32(reader["ID"]);
                    saida.Valor = Convert.ToDouble(reader["VALOR"]);
                    saida.Cliente = Convert.ToString(reader["CLIENTES"]);
                    saida.Funcionario = Convert.ToString(reader["FUNCIONARIOS"]);
                    saida.DataSaida = Convert.ToDateTime(reader["DATA_SAIDA"]);
                    saida.FormaPagamento = Convert.ToString(reader["FORMAS_PAGAMENTOS"]);
                    saida.Desconto = Convert.ToDouble(reader["DESCONTO"]);
                    saida.ValorTotal = Convert.ToDouble(reader["VALOR_TOTAL"]);
                    return new SingleResponse<SaidaView>("Saida selecionada com sucesso!", true, saida);
                }
                return new SingleResponse<SaidaView>("Saida não encontrada!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<SaidaView>("Erro no banco de dados, contate o administrador.", false, null);
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
        /// <returns>Retorna um SingleResponse com uma Saida referente ao ID informado</returns>
        public SingleResponse<Saida> GetByID(int id)
        {
            string sql = $"SELECT ID,VALOR,CLIENTE_ID,FUNCIONARIO_ID,DATA_SAIDA,FORMA_PAGAMENTO_ID,DESCONTO,VALOR_TOTAL FROM SAIDAS WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Saida saida = new Saida();
                    saida.ID = Convert.ToInt32(reader["ID"]);
                    saida.Valor = Convert.ToDouble(reader["VALOR"]);
                    saida.ClienteId = Convert.ToInt32(reader["CLIENTE_ID"]);
                    saida.FuncionarioId = Convert.ToInt32(reader["FUNCIONARIO_ID"]);
                    saida.DataSaida = Convert.ToDateTime(reader["DATA_SAIDA"]);
                    saida.FormaPagamentoId = Convert.ToInt32(reader["FORMA_PAGAMENTO_ID"]);
                    saida.Desconto = Convert.ToDouble(reader["DESCONTO"]);
                    saida.ValorTotal = Convert.ToDouble(reader["VALOR_TOTAL"]);
                    return new SingleResponse<Saida>("Saida selecionada com sucesso!", true, saida);
                }
                return new SingleResponse<Saida>("Saida não encontrada!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Saida>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        /// <summary>
        /// Recebe um FiltersSaida e retorna um DataResponse
        /// </summary>
        /// <param name="dataSaida"></param>
        /// <returns>Retorna um DataResponse contendo todas as Saidas que foram efetuadas entre duas datas</returns>
        public DataResponse<SaidaView> GetByDate(FiltersSaida dataSaida)
        {
            string sql = $"SELECT  S.ID, S.VALOR,C.NOME 'CLIENTE',F.NOME 'FUNCIONARIO',S.DATA_SAIDA,FP.NOME 'FORMA_DE_PAGAMENTO',S.VALOR_TOTAL,S.DESCONTO FROM SAIDAS S INNER JOIN CLIENTES C ON S.CLIENTE_ID = C.ID INNER JOIN FUNCIONARIOS F ON S.FUNCIONARIO_ID = F.ID INNER JOIN FORMAS_PAGAMENTO FP ON S.FORMA_PAGAMENTO_ID = FP.ID AND DATA_SAIDA BETWEEN @DATA_INICIAL AND @DATA_FINAL";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@DATA_INICIAL", dataSaida.Inicio);
            command.Parameters.AddWithValue("@DATA_FINAL", dataSaida.Fim);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                List<SaidaView> saidasView = new List<SaidaView>();
                while (reader.Read())
                {
                    SaidaView saida = new SaidaView();
                    saida.ID = Convert.ToInt32(reader["ID"]);
                    saida.Valor = Convert.ToDouble(reader["VALOR"]);
                    saida.Cliente = Convert.ToString(reader["CLIENTE"]);
                    saida.Funcionario = Convert.ToString(reader["FUNCIONARIO"]);
                    saida.DataSaida = Convert.ToDateTime(reader["DATA_SAIDA"]);
                    saida.FormaPagamento = Convert.ToString(reader["FORMA_DE_PAGAMENTO"]);
                    saida.Desconto = Convert.ToDouble(reader["DESCONTO"]);
                    saida.ValorTotal = Convert.ToDouble(reader["VALOR_TOTAL"]);
                    saidasView.Add(saida);
                }
                return new DataResponse<SaidaView>("Saidas selecionados com sucesso!", true, saidasView);
            }
            catch (Exception ex)
            {
                return new DataResponse<SaidaView>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
