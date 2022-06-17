﻿using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FuncionarioDAL : ICRUD<Funcionario>
    {
        public Response Insert(Funcionario funcionario)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"INSERT INTO FUNCIONARIOS (NOME,CPF,EMAIL,TELEFONE) VALUES (@NOME,@CPF,@EMAIL,@TELEFONE)";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\The_Shelow\Documents\FarmaciaZyx.mdf;Integrated Security=True;Connect Timeout=3";

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", funcionario.Nome);
            command.Parameters.AddWithValue("@CPF", funcionario.CPF);
            command.Parameters.AddWithValue("@EMAIL", funcionario.Email);
            command.Parameters.AddWithValue("@TELEFONE", funcionario.Telefone);

            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Funcionario cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FUNCIONARIO_EMAIL"))
                {
                    //RETORNAR MENSAGEM QUE O EMAIL TA DUPLICADO
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_FUNCIONARIO_CPF"))
                {
                    //RETORNAR MENSAGEM QUE O CPF TA DUPLICADO
                    return new Response("CPF já está em uso.", false);
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

        public Response Update(Funcionario funcionario)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"UPDATE FUNCIONARIO SET NOME = @NOME, EMAIL = @EMAIL, TELEFONE = @TELEFONE WHERE ID = @ID";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\The_Shelow\Documents\FarmaciaZyx.mdf;Integrated Security=True;Connect Timeout=3";

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", funcionario.Nome);
            command.Parameters.AddWithValue("@EMAIL", funcionario.Email);
            command.Parameters.AddWithValue("@TELEFONE", funcionario.Telefone);
            command.Parameters.AddWithValue("@ID", funcionario.ID);

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
                    return new Response("Funcionario excluido.", false);
                }
                return new Response("Funcionario alterado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FUNCIONARIO_EMAIL"))
                {
                    //RETORNAR MENSAGEM QUE O EMAIL TA DUPLICADO
                    return new Response("Email já está em uso.", false);
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

        public Response Delete(int id)
        {
            string sql = "DELETE FROM FUNCIONARIO WHERE ID = @ID";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\The_Shelow\Documents\FarmaciaZyx.mdf;Integrated Security=True;Connect Timeout=3";

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
                    return new Response("Funcionario excluído com sucesso.", true);
                }
                return new Response("Funcionario não excluído.", false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FUNCIONARIO_EMAIL"))
                {
                    //RETORNAR MENSAGEM QUE O EMAIL TA DUPLICADO
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_FUNCIONARIO_CPF"))
                {
                    //RETORNAR MENSAGEM QUE O CPF TA DUPLICADO
                    return new Response("CPF já está em uso.", false);
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

        public DataResponse<Funcionario> GetAll()
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME,CPF,EMAIL,TELEFONE FROM FUNCIONARIOS";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\The_Shelow\Documents\FarmaciaZyx.mdf;Integrated Security=True;Connect Timeout=3";
            SqlConnection connection = new SqlConnection(connectionString);
            //ADO.NET 
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Funcionario> funcionarios = new List<Funcionario>();
                //Enquanto houver registros, o loop será executado!
                while (reader.Read())
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario.ID = Convert.ToInt32(reader["ID"]);
                    funcionario.Nome = Convert.ToString(reader["NOME"]);
                    funcionario.CPF = Convert.ToString(reader["CPF"]);
                    funcionario.Email = Convert.ToString(reader["EMAIL"]);
                    funcionario.Telefone = Convert.ToString(reader["TELEFONE"]);
                    funcionarios.Add(funcionario);
                }
                return new DataResponse<Funcionario>("Fornecedor selecionados com sucesso!", true, funcionarios);
            }
            catch (Exception ex)
            {
                return new DataResponse<Funcionario>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
    public SingleResponse<Funcionario> GetByID(int id)
    {
        //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
        //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
        //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
        string sql = $"SELECT ID,NOME,CPF,EMAIL,TELEFONE FROM FUNCIONARIOS WHERE ID = @ID";

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Documents\AdultMovieLocatorDb.mdf;Integrated Security=True;Connect Timeout=3";

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
                Funcionario funcionario = new Funcionario();
                funcionario.ID = Convert.ToInt32(reader["ID"]);
                funcionario.Nome = Convert.ToString(reader["NOME"]);
                funcionario.CPF = Convert.ToString(reader["CPF"]);
                funcionario.Telefone = Convert.ToString(reader["TELEFONE"]);
                funcionario.Email = Convert.ToString(reader["EMAIL"]);
                return new SingleResponse<Funcionario>("Funcionario selecionado com sucesso!", true, funcionario);
            }
            return new SingleResponse<Funcionario>("Funcionario não encontrado!", false, null);
        }
        catch (Exception ex)
        {
            return new SingleResponse<Funcionario>("Erro no banco de dados, contate o administrador.", false, null);
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