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
    public class ProdutosSaidasDAL
    {
        string connectionString = ConnectionString._connectionString;
        public DataResponse<ProdutoSaida> GetAllBySaidaID(int id)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT PRODUTO_ID,SAIDA_ID,QUANTIDADE,VALOR_UNITARIO FROM PRODUTOS_SAIDA WHERE SAIDA_ID = @SAIDA_ID";



            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<ProdutoSaida> produtoSaidas = new List<ProdutoSaida>();
                //Enquanto houver registros, o loop será executado!
                while (reader.Read())
                {
                    ProdutoSaida saida = new ProdutoSaida();
                    saida.SaidaId = Convert.ToInt32(reader["ENTRADA_ID"]);
                    saida.ProdutoId = Convert.ToInt32(reader["PRODUTO_ID"]);
                    saida.Quantidade = Convert.ToDouble(reader["QUANTIDADE"]);
                    saida.ValorUnitario = Convert.ToDouble(reader["VALOR_UNITARIO"]);
                    produtoSaidas.Add(saida);
                }
                return new DataResponse<ProdutoSaida>("ProdutosSaidas selecionados com sucesso!", true, produtoSaidas);
            }
            catch (Exception ex)
            {
                return new DataResponse<ProdutoSaida>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public Response Insert(ProdutoSaida item)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"INSERT INTO PRODUTOS_SAIDA (SAIDA_ID,PRODUTO_ID,QUANTIDADE,VALOR_UNITARIO) VALUES (@SAIDA_ID,@PRODUTO_ID,@QUANTIDADE,@VALOR_UNITARIO) ";
            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@SAIDA_ID", item.SaidaId);
            command.Parameters.AddWithValue("@PRODUTO_ID", item.ProdutoId);
            command.Parameters.AddWithValue("@QUANTIDADE", item.Quantidade);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", item.ValorUnitario);

            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
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
    }
}
