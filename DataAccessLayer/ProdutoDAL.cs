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
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"INSERT INTO PRODUTOS (NOME,DESCRICAO,LABORATORIO_ID,QTD_ESTOQUE,TIPO_UNIDADE_ID,VALOR) VALUES (@NOME,@DESCRICAO,@LABORATORIO_ID,@QTD_ESTOQUE,@TIPO_UNIDADE_ID,@VALOR)";



            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", produto.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", produto.Descricao);
            command.Parameters.AddWithValue("@LABORATORIO_ID", produto.LaboratorioId);
            command.Parameters.AddWithValue("@QTD_ESTOQUE", produto.QtdEstoque);
            command.Parameters.AddWithValue("@TIPO_UNIDADE_ID", produto.TipoUnidadeId);
            command.Parameters.AddWithValue("@VALOR", produto.Valor);




            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Produto cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_PRODUTOS_ENTRADAS_PRODUTOS"))
                {
                    //RETORNAR MENSAGEM QUE O CPF TA DUPLICADO
                    return new Response("Não é possivel excluir um Produto que tenha uma Entrada cadastrada.", false);
                }
                if (ex.Message.Contains("FK_PRODUTOS_SAIDA_PRODUTOS"))
                {
                    //RETORNAR MENSAGEM QUE O CPF TA DUPLICADO
                    return new Response("Não é possivel excluir um Produto que tenha uma Venda cadastrada.", false);
                }
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

        public Response Update(Produto produto)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"UPDATE PRODUTOS SET NOME = @NOME, DESCRICAO = @DESCRICAO, LABORATORIO_ID = @LABORATORIO_ID, QTD_ESTOQUE = @QTD_ESTOQUE, TIPO_UNIDADE_ID = @TIPO_UNIDADE_ID, VALOR = @VALOR WHERE ID = @ID";



            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", produto.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", produto.Descricao);
            command.Parameters.AddWithValue("@LABORATORIO_ID", produto.LaboratorioId);
            command.Parameters.AddWithValue("@QTD_ESTOQUE", produto.QtdEstoque);
            command.Parameters.AddWithValue("@TIPO_UNIDADE_ID", produto.TipoUnidadeId);
            command.Parameters.AddWithValue("@VALOR", produto.Valor);
            command.Parameters.AddWithValue("@ID", produto.ID);

            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
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
        public Response UpdateValueAndInventory(Produto produto)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"UPDATE PRODUTOS SET VALOR = @VALOR, QTD_ESTOQUE = @QTD_ESTOQUE WHERE ID = @ID";



            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@VALOR", produto.Valor);
            command.Parameters.AddWithValue("@QTD_ESTOQUE", produto.QtdEstoque);
            command.Parameters.AddWithValue("@ID", produto.ID);

            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
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
        public Response Delete(int id)
        {
            string sql = "DELETE FROM PRODUTOS WHERE ID = @ID";



            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
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
                    //RETORNAR MENSAGEM QUE O CPF TA DUPLICADO
                    return new Response("Não é possivel excluir um Produto que tenha uma Venda cadastrada.", false);
                }
                if (ex.Message.Contains("FK_PRODUTOS_ENTRADAS_PRODUTOS"))
                {
                    //RETORNAR MENSAGEM QUE O CPF TA DUPLICADO
                    return new Response("Não é possivel excluir um Produto que tenha uma Entrada cadastrada.", false);
                }
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

        public DataResponse<Produto> GetAll()
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME,DESCRICAO,LABORATORIO_ID,QTD_ESTOQUE,TIPO_UNIDADE_ID,VALOR FROM PRODUTOS";



            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Produto> produtos = new List<Produto>();
                //Enquanto houver registros, o loop será executado!
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
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public SingleResponse<Produto> GetByID(int id)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME,DESCRICAO,LABORATORIO_ID,QTD_ESTOQUE,TIPO_UNIDADE_ID,VALOR FROM PRODUTOS WHERE ID = @ID";



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
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public SingleResponse<Produto> GetByName(string nome)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME,DESCRICAO,LABORATORIO_ID,QTD_ESTOQUE,TIPO_UNIDADE_ID FROM PRODUTOS WHERE NOME = @NOME";



            //ADO.NET 
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
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
    }
}
