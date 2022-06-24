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
    public class LaboratorioDAL
    {
        string connectionString = ConnectionString._connectionString;
        public DataResponse<Laboratorio> GetAll()
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME,CNPJ FROM LABORATORIOS";

            SqlConnection connection = new SqlConnection(connectionString);
            //ADO.NET 
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Laboratorio> tipoClientes = new List<Laboratorio>();
                //Enquanto houver registros, o loop será executado!
                while (reader.Read())
                {
                    Laboratorio tipoCliente = new Laboratorio();
                    tipoCliente.ID = Convert.ToInt32(reader["ID"]);
                    tipoCliente.Nome = Convert.ToString(reader["NOME"]);
                    tipoCliente.CNPJ = Convert.ToString(reader["CNPJ"]);

                    tipoClientes.Add(tipoCliente);
                }
                return new DataResponse<Laboratorio>("Laboratorios selecionados com sucesso!", true, tipoClientes);
            }
            catch (Exception ex)
            {
                return new DataResponse<Laboratorio>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public Response Insert(Laboratorio laboratorio)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"INSERT INTO LABORATORIOS (NOME,CNPJ) VALUES (@NOME,@CNPJ)";



            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", laboratorio.Nome);
            command.Parameters.AddWithValue("@CNPJ", laboratorio.CNPJ);




            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Laboratorio cadastrado com sucesso.", true);
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
        public SingleResponse<Laboratorio> GetByID(int id)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME,CNPJ FROM LABORATORIOS WHERE ID = @ID";



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
                    Laboratorio laboratorio = new Laboratorio();
                    laboratorio.ID = Convert.ToInt32(reader["ID"]);
                    laboratorio.Nome = Convert.ToString(reader["NOME"]);
                    laboratorio.CNPJ = Convert.ToString(reader["CNPJ"]);

                    return new SingleResponse<Laboratorio>("Laboratorio selecionado com sucesso!", true, laboratorio);
                }
                return new SingleResponse<Laboratorio>("Tipo de Cliente não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Laboratorio>("Erro no banco de dados, contate o administrador.", false, null);
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
            string sql = "DELETE FROM LABORATORIOS WHERE ID = @ID";



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
                    return new Response("Laboratorio excluído com sucesso.", true);
                }
                return new Response("Laboratorio não excluído.", false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_PRODUTOS_LABORATORIO_ID"))
                {
                    //RETORNAR MENSAGEM QUE O CPF TA DUPLICADO
                    return new Response("Não é possivel excluir um Laboratorio que tenha um produto cadastrado.", false);
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

        public Response Update(Laboratorio laboratorio)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"UPDATE LABORATORIOS SET NOME = @NOME CNPJ = @CNPJ WHERE ID = @ID";


            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", laboratorio.Nome);
            command.Parameters.AddWithValue("@CNPJ", laboratorio.CNPJ);

            command.Parameters.AddWithValue("@ID", laboratorio.ID);

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
                    return new Response("Laboratorio excluido.", false);
                }
                return new Response("Laboratorio alterado com sucesso.", true);
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
