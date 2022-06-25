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
    public class ProdutosEntradasDAL
    {
        string connectionString = ConnectionString._connectionString;
        public DataResponse<ProdutosEntrada> GetAllByEntradaID(int id)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ENTRADA_ID,PRODUTO_ID,QUANTIDADE,VALOR_UNITARIO FROM PRODUTOS_ENTRADAS WHERE ENTRADA_ID = @ENTRADA_ID";



            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<ProdutosEntrada> produtosEntradas = new List<ProdutosEntrada>();
                //Enquanto houver registros, o loop será executado!
                while (reader.Read())
                {
                    ProdutosEntrada entrada = new ProdutosEntrada();
                    entrada.EntradaID = Convert.ToInt32(reader["ENTRADA_ID"]);
                    entrada.ProdutoId = Convert.ToInt32(reader["PRODUTO_ID"]);
                    entrada.Quantidade = Convert.ToDouble(reader["QUANTIDADE"]);
                    entrada.ValorUnitario = Convert.ToDouble(reader["VALOR_UNITARIO"]);
                    produtosEntradas.Add(entrada);
                }
                return new DataResponse<ProdutosEntrada>("Endereço selecionados com sucesso!", true, produtosEntradas);
            }
            catch (Exception ex)
            {
                return new DataResponse<ProdutosEntrada>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public Response Insert(ProdutosEntrada item)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"INSERT INTO PRODUTOS_ENTRADAS (ENTRADA_ID,PRODUTO_ID,QUANTIDADE,VALOR_UNITARIO) VALUES (@ENTRADA_ID,@PRODUTO_ID,@QUANTIDADE,@VALOR_UNITARIO) ";
            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ENTRADA_ID", item.EntradaID);
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
    }
}
