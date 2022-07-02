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
    public class EntradaDAL
    {
        string connectionString = ConnectionString._connectionString;
        public Response Insert(Entrada item)
        {
            string sql = $"INSERT INTO ENTRADAS (PRECO,FORNECEDOR_ID,FUNCIONARIO_ID,DATA_ENTRADA) VALUES (@PRECO,@FORNECEDOR_ID,@FUNCIONARIO_ID,@DATA_ENTRADA); SELECT SCOPE_IDENTITY()";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@PRECO", item.Valor);
            command.Parameters.AddWithValue("@FORNECEDOR_ID", item.FornecedorID);
            command.Parameters.AddWithValue("@FUNCIONARIO_ID", item.FuncionarioId);
            command.Parameters.AddWithValue("@DATA_ENTRADA", item.DataEntrada);
            try
            {
                connection.Open();
                item.ID = Convert.ToInt32(command.ExecuteScalar());
                return new Response("Entrada cadastrado com sucesso.", true);
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
        public DataResponse<EntradaView> GetAll()
        {
            string sql = $"SELECT E.ID,E.PRECO,E.DATA_ENTRADA,FO.RAZAO_SOCIAL AS FORNECEDORES,FU.NOME AS FUNCIONARIOS FROM ENTRADAS E INNER JOIN FORNECEDORES FO ON E.FORNECEDOR_ID = FO.ID INNER JOIN FUNCIONARIOS FU ON E.FUNCIONARIO_ID = FU.ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<EntradaView> entradas = new List<EntradaView>();
                //Enquanto houver registros, o loop será executado!
                while (reader.Read())
                {
                    EntradaView entrada = new EntradaView();
                    entrada.ID = Convert.ToInt32(reader["ID"]);
                    entrada.Valor = Convert.ToDouble(reader["PRECO"]);
                    entrada.Fornecedor = Convert.ToString(reader["FORNECEDORES"]);
                    entrada.Funcionario = Convert.ToString(reader["FUNCIONARIOS"]);
                    entrada.DataEntrada = Convert.ToDateTime(reader["DATA_ENTRADA"]);
                    entradas.Add(entrada);
                }
                return new DataResponse<EntradaView>("Entrada selecionada com sucesso!", true, entradas);
            }
            catch (Exception ex)
            {
                return new DataResponse<EntradaView>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<EntradaView> GetByID(int id)
        {
            string sql = $"SELECT E.ID,E.PRECO,E.DATA_ENTRADA,FO.RAZAO_SOCIAL AS FORNECEDORES,FU.NOME AS FUNCIONARIOS FROM ENTRADAS E INNER JOIN FORNECEDORES FO ON E.FORNECEDOR_ID = FO.ID INNER JOIN FUNCIONARIOS FU ON E.FUNCIONARIO_ID = FU.ID WHERE E.ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    EntradaView entrada = new EntradaView();
                    entrada.ID = Convert.ToInt32(reader["ID"]);
                    entrada.Valor = Convert.ToDouble(reader["PRECO"]);
                    entrada.Fornecedor = Convert.ToString(reader["FORNECEDORES"]);
                    entrada.Funcionario = Convert.ToString(reader["FUNCIONARIOS"]);
                    entrada.DataEntrada = Convert.ToDateTime(reader["DATA_ENTRADA"]);
                    return new SingleResponse<EntradaView>("Entrada selecionada com sucesso!", true, entrada);
                }
                return new SingleResponse<EntradaView>("Entrada não encontrada!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<EntradaView>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
