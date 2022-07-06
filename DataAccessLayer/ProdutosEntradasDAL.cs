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
        /// <summary>
        /// Recebe um ID e retorna um DataResponse
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um DataResponse contendo todos os ProdutosEntrada referente ao ID informado</returns>
        public DataResponse<ProdutosEntradaView> GetAllByEntradaID(int id)
        {
            string sql = $"SELECT PE.ENTRADA_ID,PE.QUANTIDADE,PE.VALOR_UNITARIO,P.NOME AS PRODUTO,P.DESCRICAO,P.VALOR,L.NOME AS LABORATORIOS,TU.NOME AS TIPOS_UNIDADES FROM PRODUTOS_ENTRADAS PE INNER JOIN PRODUTOS P ON PE.PRODUTO_ID = P.ID INNER JOIN LABORATORIOS L ON P.LABORATORIO_ID = L.ID INNER JOIN TIPOS_UNIDADES TU ON P.TIPO_UNIDADE_ID = TU.ID WHERE PE.ENTRADA_ID = @ENTRADA_ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ENTRADA_ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<ProdutosEntradaView> produtosEntradas = new List<ProdutosEntradaView>();
                while (reader.Read())
                {
                    ProdutosEntradaView entrada = new ProdutosEntradaView();
                    ProdutoView produtoView = new ProdutoView();
                    entrada.Produto = produtoView;
                    entrada.EntradaID = Convert.ToInt32(reader["ENTRADA_ID"]);
                    entrada.ValorUnitario = Convert.ToDouble(reader["VALOR_UNITARIO"]);
                    entrada.Produto.Descricao = Convert.ToString(reader["DESCRICAO"]);
                    entrada.Produto.Valor = Convert.ToDouble(reader["VALOR"]);
                    entrada.Quantidade = Convert.ToDouble(reader["QUANTIDADE"]);
                    entrada.Produto.Laboratorio = Convert.ToString(reader["LABORATORIOS"]);
                    entrada.Produto.TipoUnidade = Convert.ToString(reader["TIPOS_UNIDADES"]);
                    entrada.Produto.Nome = Convert.ToString(reader["PRODUTO"]);
                    produtosEntradas.Add(entrada);
                }
                return new DataResponse<ProdutosEntradaView>("ProdutosEntradas selecionados com sucesso!", true, produtosEntradas);
            }
            catch (Exception ex)
            {
                return new DataResponse<ProdutosEntradaView>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        /// <summary>
        /// Recebe um ProdutosEntrada e insere no banco de dados
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Insert(ProdutosEntrada item)
        {
            string sql = $"INSERT INTO PRODUTOS_ENTRADAS (ENTRADA_ID,PRODUTO_ID,QUANTIDADE,VALOR_UNITARIO) VALUES (@ENTRADA_ID,@PRODUTO_ID,@QUANTIDADE,@VALOR_UNITARIO) ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ENTRADA_ID", item.EntradaID);
            command.Parameters.AddWithValue("@PRODUTO_ID", item.ProdutoId);
            command.Parameters.AddWithValue("@QUANTIDADE", item.Quantidade);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", item.ValorUnitario);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("ProdutosEntrada cadastrada com sucesso.", true);
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
