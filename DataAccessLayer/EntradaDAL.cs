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
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"INSERT INTO ENTRADAS (PRECO,FORNECEDOR_ID,FUNCIONARIO_ID,DATA_ENTRADA) VALUES (@PRECO,@FORNECEDOR_ID,@FUNCIONARIO_ID,@DATA_ENTRADA); SELECT SCOPE_IDENTITY()";



            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@PRECO", item.Valor);
            command.Parameters.AddWithValue("@FORNECEDOR_ID", item.FornecedorID);
            command.Parameters.AddWithValue("@FUNCIONARIO_ID", item.FuncionarioId);
            command.Parameters.AddWithValue("@DATA_ENTRADA", item.DataEntrada);

            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
            try
            {
                connection.Open();
                item.ID = Convert.ToInt32(command.ExecuteScalar());
                return new Response("Entrada cadastrado com sucesso.", true);
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
        public DataResponse<Entrada> GetAll()
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,PRECO,FORNECEDOR_ID,FUNCIONARIO_ID,DATA_ENTRADA FROM ENTRADAS";



            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Entrada> entradas = new List<Entrada>();
                //Enquanto houver registros, o loop será executado!
                while (reader.Read())
                {
                    Entrada entrada = new Entrada();
                    entrada.ID = Convert.ToInt32(reader["ID"]);
                    entrada.Valor = Convert.ToDouble(reader["PRECO"]);
                    entrada.FornecedorID = Convert.ToInt32(reader["FORNECEDOR_ID"]);
                    entrada.FuncionarioId = Convert.ToInt32(reader["FUNCIONARIO_ID"]);
                    entrada.DataEntrada = Convert.ToDateTime(reader["DATA_ENTRADA"]);
                    entradas.Add(entrada);
                }
                return new DataResponse<Entrada>("Endereço selecionados com sucesso!", true, entradas);
            }
            catch (Exception ex)
            {
                return new DataResponse<Entrada>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public SingleResponse<Entrada> GetByID(int id)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,PRECO,FORNECEDOR_ID,FUNCIONARIO_ID,DATA_ENTRADA FROM ENTRADAS WHERE ID = @ID";



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
                    Entrada entrada = new Entrada();
                    entrada.ID = Convert.ToInt32(reader["ID"]);
                    entrada.Valor = Convert.ToDouble(reader["PRECO"]);
                    entrada.FornecedorID = Convert.ToInt32(reader["FORNECEDOR_ID"]);
                    entrada.FuncionarioId = Convert.ToInt32(reader["FUNCIONARIO_ID"]);
                    entrada.DataEntrada = Convert.ToDateTime(reader["DATA_ENTRADA"]);
                    return new SingleResponse<Entrada>("Endereço selecionado com sucesso!", true, entrada);
                }
                return new SingleResponse<Entrada>("Endereço não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Entrada>("Erro no banco de dados, contate o administrador.", false, null);
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
