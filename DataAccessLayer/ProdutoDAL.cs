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
    public class ProdutoDAL : ICRUD<Produto>
    {
        string connectionString = ConnectionString._connectionString;

        public Response Insert(Produto produto)
        {
            string sql = $"INSERT INTO PRODUTOS (NOME,DESCRICAO,LABORATORIO_ID,QTD_ESTOQUE,TIPO_UNIDADE_ID,VALOR) VALUES (@NOME,@DESCRICAO,@LABORATORIO_ID,@QTD_ESTOQUE,@TIPO_UNIDADE_ID,@VALOR)";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", produto.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", produto.Descricao);
            command.Parameters.AddWithValue("@LABORATORIO_ID", produto.LaboratorioId);
            command.Parameters.AddWithValue("@QTD_ESTOQUE", produto.QtdEstoque);
            command.Parameters.AddWithValue("@TIPO_UNIDADE_ID", produto.TipoUnidadeId);
            command.Parameters.AddWithValue("@VALOR", produto.Valor);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Produto cadastrado com sucesso.", true);
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

        public Response Update(Produto produto)
        {
            string sql = $"UPDATE PRODUTOS SET NOME = @NOME, DESCRICAO = @DESCRICAO, LABORATORIO_ID = @LABORATORIO_ID, QTD_ESTOQUE = @QTD_ESTOQUE, TIPO_UNIDADE_ID = @TIPO_UNIDADE_ID, VALOR = @VALOR WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", produto.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", produto.Descricao);
            command.Parameters.AddWithValue("@LABORATORIO_ID", produto.LaboratorioId);
            command.Parameters.AddWithValue("@QTD_ESTOQUE", produto.QtdEstoque);
            command.Parameters.AddWithValue("@TIPO_UNIDADE_ID", produto.TipoUnidadeId);
            command.Parameters.AddWithValue("@VALOR", produto.Valor);
            command.Parameters.AddWithValue("@ID", produto.ID);
            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Produto excluido.", false);
                }
                return new Response("Produto alterado com sucesso.", true);
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
        public Response UpdateValueAndInventory(Produto produto)
        {
            string sql = $"UPDATE PRODUTOS SET VALOR = @VALOR, QTD_ESTOQUE = @QTD_ESTOQUE WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@VALOR", produto.Valor);
            command.Parameters.AddWithValue("@QTD_ESTOQUE", produto.QtdEstoque);
            command.Parameters.AddWithValue("@ID", produto.ID);
            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Produto excluido.", false);
                }
                return new Response("Produto alterado com sucesso.", true);
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
        public Response Delete(int id)
        {
            string sql = "DELETE FROM PRODUTOS WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                int qtdLinhasExcluidas = command.ExecuteNonQuery();
                if (qtdLinhasExcluidas == 1)
                {
                    return new Response("Produto excluído com sucesso.", true);
                }
                return new Response("Produto não excluído.", false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_PRODUTOS_SAIDA_PRODUTOS"))
                {
                    return new Response("Não é possivel excluir um Produto que tenha uma Venda cadastrada.", false);
                }
                if (ex.Message.Contains("FK_PRODUTOS_ENTRADAS_PRODUTOS"))
                {
                    return new Response("Não é possivel excluir um Produto que tenha uma Entrada cadastrada.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<Produto> GetAll()
        {
            string sql = $"SELECT ID,NOME,DESCRICAO,LABORATORIO_ID,QTD_ESTOQUE,TIPO_UNIDADE_ID,VALOR FROM PRODUTOS";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Produto> produtos = new List<Produto>();
                while (reader.Read())
                {
                    Produto produto = new Produto();
                    produto.ID = Convert.ToInt32(reader["ID"]);
                    produto.Nome = Convert.ToString(reader["NOME"]);
                    produto.Descricao = Convert.ToString(reader["DESCRICAO"]);
                    produto.LaboratorioId = Convert.ToInt32(reader["LABORATORIO_ID"]);
                    produto.QtdEstoque = Convert.ToDouble(reader["QTD_ESTOQUE"]);
                    produto.TipoUnidadeId = Convert.ToInt32(reader["TIPO_UNIDADE_ID"]);
                    produto.Valor = Convert.ToDouble(reader["VALOR"]);

                    produtos.Add(produto);
                }
                return new DataResponse<Produto>("Produto selecionados com sucesso!", true, produtos);
            }
            catch (Exception ex)
            {
                return new DataResponse<Produto>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<Produto> GetByID(int id)
        {
            string sql = $"SELECT ID,NOME,DESCRICAO,LABORATORIO_ID,QTD_ESTOQUE,TIPO_UNIDADE_ID,VALOR FROM PRODUTOS WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Produto produto = new Produto();
                    produto.ID = Convert.ToInt32(reader["ID"]);
                    produto.Nome = Convert.ToString(reader["NOME"]);
                    produto.Descricao = Convert.ToString(reader["DESCRICAO"]);
                    produto.LaboratorioId = Convert.ToInt32(reader["LABORATORIO_ID"]);
                    produto.QtdEstoque = Convert.ToDouble(reader["QTD_ESTOQUE"]);
                    produto.TipoUnidadeId = Convert.ToInt32(reader["TIPO_UNIDADE_ID"]);
                    produto.Valor = Convert.ToDouble(reader["VALOR"]);

                    return new SingleResponse<Produto>("Produto selecionado com sucesso!", true, produto);
                }
                return new SingleResponse<Produto>("Produto não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Produto>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<Produto> GetByName(string nome)
        {
            string sql = $"SELECT ID,NOME,DESCRICAO,LABORATORIO_ID,QTD_ESTOQUE,TIPO_UNIDADE_ID FROM PRODUTOS WHERE NOME = @NOME";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", nome);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                //Enquanto houver registros, o loop será executado!
                if (reader.Read())
                {
                    Produto produto = new Produto();
                    produto.ID = Convert.ToInt32(reader["ID"]);
                    produto.Nome = Convert.ToString(reader["NOME"]);
                    produto.Descricao = Convert.ToString(reader["DESCRICAO"]);
                    produto.LaboratorioId = Convert.ToInt32(reader["LABORATORIO_ID"]);
                    produto.QtdEstoque = Convert.ToDouble(reader["QTD_ESTOQUE"]);
                    produto.TipoUnidadeId = Convert.ToInt32(reader["TIPO_UNIDADE_ID"]);
                    return new SingleResponse<Produto>("Produto selecionado com sucesso!", true, produto);
                }
                return new SingleResponse<Produto>("Produto não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Produto>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
