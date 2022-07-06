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
        /// <summary>
        /// Recebe o ID de uma saida e retorna uma DataResponse
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um DataResponse contendo todos os ProdutosSaida que tão cadastrados na Saida</returns>
        public DataResponse<ProdutosSaidaView> GetAllBySaidaID(int id)
        {
            string sql = $"SELECT PS.SAIDA_ID,PS.QUANTIDADE,PS.VALOR_UNITARIO,P.NOME AS PRODUTO,P.DESCRICAO,P.VALOR,L.NOME AS LABORATORIOS,TU.NOME AS TIPOS_UNIDADES FROM PRODUTOS_SAIDA PS INNER JOIN PRODUTOS P ON PS.PRODUTO_ID = P.ID INNER JOIN LABORATORIOS L ON P.LABORATORIO_ID = L.ID INNER JOIN TIPOS_UNIDADES TU ON P.TIPO_UNIDADE_ID = TU.ID WHERE PS.SAIDA_ID = @SAIDA_ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@SAIDA_ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<ProdutosSaidaView> produtoSaidas = new List<ProdutosSaidaView>();
                while (reader.Read())
                {
                    ProdutosSaidaView saida = new ProdutosSaidaView();
                    ProdutoView produtoView = new ProdutoView();
                    saida.Produto = produtoView;
                    saida.SaidaID = Convert.ToInt32(reader["SAIDA_ID"]);
                    saida.ValorUnitario = Convert.ToDouble(reader["VALOR_UNITARIO"]);
                    saida.Produto.Descricao = Convert.ToString(reader["DESCRICAO"]);
                    saida.Produto.Valor = Convert.ToDouble(reader["VALOR"]);
                    saida.Quantidade = Convert.ToDouble(reader["QUANTIDADE"]);
                    saida.Produto.Laboratorio = Convert.ToString(reader["LABORATORIOS"]);
                    saida.Produto.TipoUnidade = Convert.ToString(reader["TIPOS_UNIDADES"]);
                    saida.Produto.Nome = Convert.ToString(reader["PRODUTO"]);
                    produtoSaidas.Add(saida);
                }
                return new DataResponse<ProdutosSaidaView>("ProdutosSaidas selecionados com sucesso!", true, produtoSaidas);
            }
                catch (Exception ex)
            {
                return new DataResponse<ProdutosSaidaView>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        /// <summary>
        /// Recebe um ProdutoSaida e insere no banco de dados
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna um Reponse informando se teve sucesso</returns>
        public Response Insert(ProdutosSaida item)
        {
            string sql = $"INSERT INTO PRODUTOS_SAIDA (SAIDA_ID,PRODUTO_ID,QUANTIDADE,VALOR_UNITARIO) VALUES (@SAIDA_ID,@PRODUTO_ID,@QUANTIDADE,@VALOR_UNITARIO) ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@SAIDA_ID", item.SaidaId);
            command.Parameters.AddWithValue("@PRODUTO_ID", item.ProdutoId);
            command.Parameters.AddWithValue("@QUANTIDADE", item.Quantidade);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", item.ValorUnitario);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("ProdutosSaidas cadastrada com sucesso.", true);
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
    }
}
