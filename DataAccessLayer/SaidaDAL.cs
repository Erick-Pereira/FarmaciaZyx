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
    public class SaidaDAL
    {
        string connectionString = ConnectionString._connectionString;
        public Response Insert(Saida item)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"INSERT INTO SAIDAS (VALOR,CLIENTE_ID,FUNCIONARIO_ID,DATA_SAIDA,FORMA_PAGAMENTO_ID,VALOR_TOTAL,DESCONTO) VALUES (@VALOR,@CLIENTE_ID,@FUNCIONARIO_ID,@DATA_SAIDA,@FORMA_PAGAMENTO_ID,@VALOR_TOTAL,@DESCONTO); SELECT SCOPE_IDENTITY()";



            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@VALOR", item.Valor);
            command.Parameters.AddWithValue("@VALOR_TOTAL", item.ValorTotal);
            command.Parameters.AddWithValue("@CLIENTE_ID", item.ClienteId);
            command.Parameters.AddWithValue("@FUNCIONARIO_ID", item.FuncionarioId);
            command.Parameters.AddWithValue("@DATA_SAIDA", item.DataSaida);
            command.Parameters.AddWithValue("@FORMA_PAGAMENTO_ID", item.FormaPagamento);
            command.Parameters.AddWithValue("@DESCONTO", item.Desconto);


            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
            try
            {
                connection.Open();
                item.ID = Convert.ToInt32(command.ExecuteScalar());
                return new Response("Saida cadastrada com sucesso.", true);
            }
            catch (Exception ex)
            {
                //SE NAO ENTROU EM NENHUM IF DE CIMA, SÓ PODE SER UM ERRO DE INFRAESTRUTURA
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public DataResponse<Saida> GetAll()
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,VALOR,CLIENTE_ID,FUNCIONARIO_ID,DATA_SAIDA,FORMA_PAGAMENTO_ID,DESCONTO,VALOR_TOTAL FROM SAIDAS";



            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Saida> saidas = new List<Saida>();
                //Enquanto houver registros, o loop será executado!
                while (reader.Read())
                {
                    Saida saida = new Saida();
                    saida.ID = Convert.ToInt32(reader["ID"]);
                    saida.Valor = Convert.ToDouble(reader["VALOR"]);
                    saida.ClienteId = Convert.ToInt32(reader["CLIENTE_ID"]);
                    saida.FuncionarioId = Convert.ToInt32(reader["FUNCIONARIO_ID"]);
                    saida.DataSaida = Convert.ToDateTime(reader["DATA_SAIDA"]);
                    saida.FormaPagamento = Convert.ToInt32(reader["FORMA_PAGAMENTO_ID"]);
                    saida.Desconto = Convert.ToDouble(reader["DESCONTO"]);
                    saida.ValorTotal = Convert.ToDouble(reader["VALOR_TOTAL"]);

                    saidas.Add(saida);
                }
                return new DataResponse<Saida>("Saidas selecionados com sucesso!", true, saidas);
            }
            catch (Exception ex)
            {
                return new DataResponse<Saida>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public SingleResponse<Saida> GetByID(int id)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,VALOR,CLIENTE_ID,FUNCIONARIO_ID,DATA_SAIDA,FORMA_PAGAMENTO_ID,DESCONTO,VALOR_TOTAL FROM SAIDAS WHERE ID = @ID";



            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                //Enquanto houver registros, o loop será executado!
                if (reader.Read())
                {
                    Saida saida = new Saida();
                    saida.ID = Convert.ToInt32(reader["ID"]);
                    saida.Valor = Convert.ToDouble(reader["VALOR"]);
                    saida.ClienteId = Convert.ToInt32(reader["CLIENTE_ID"]);
                    saida.FuncionarioId = Convert.ToInt32(reader["FUNCIONARIO_ID"]);
                    saida.DataSaida = Convert.ToDateTime(reader["DATA_SAIDA"]);
                    saida.FormaPagamento = Convert.ToInt32(reader["FORMA_PAGAMENTO_ID"]);
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
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
    }
}
