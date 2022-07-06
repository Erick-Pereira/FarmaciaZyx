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
        /// <summary>
        /// Acessa o banco de dados e retorna um DataResponse
        /// </summary>
        /// <returns>Retorna um DataResponse contendo todos os Laboratorios cadastrados no banco</returns>
        public DataResponse<Laboratorio> GetAll()
        {
            string sql = $"SELECT ID,NOME,CNPJ FROM LABORATORIOS";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Laboratorio> tipoClientes = new List<Laboratorio>();
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
            finally
            {
                connection.Dispose();
            }
        }
        /// <summary>
        /// Recebe um Laboratorio e insere no banco de dados
        /// </summary>
        /// <param name="laboratorio"></param>
        /// <returns>Retorna um Response informando se teve sucesso</returns>
        public Response Insert(Laboratorio laboratorio)
        {
            string sql = $"INSERT INTO LABORATORIOS (NOME,CNPJ) VALUES (@NOME,@CNPJ)";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", laboratorio.Nome);
            command.Parameters.AddWithValue("@CNPJ", laboratorio.CNPJ);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Laboratorio cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_LABORATORIOS_CNPJ"))
                {
                    return new Response("CNPJ já está em uso.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }
        /// <summary>
        /// Recebe um ID e Retorna um SingleResponse
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um SingleReponse contendo o Laboratorio referente ao ID informado</returns>
        public SingleResponse<Laboratorio> GetByID(int id)
        {
            string sql = $"SELECT ID,NOME,CNPJ FROM LABORATORIOS WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
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
            finally
            {
                connection.Dispose();
            }
        }
        /// <summary>
        /// Recebe um ID, acessa o banco de dados e deleta um Laboratorio
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um Reponse informando se teve sucesso</returns>
        public Response Delete(int id)
        {
            string sql = "DELETE FROM LABORATORIOS WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
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
                    return new Response("Não é possivel excluir um Laboratorio que tenha um produto cadastrado.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }
        /// <summary>
        /// Recebe um Laboratorio e faz o update no banco de dados
        /// </summary>
        /// <param name="laboratorio"></param>
        /// <returns>Retorna Reponse informando se teve sucesso</returns>
        public Response Update(Laboratorio laboratorio)
        {
            string sql = $"UPDATE LABORATORIOS SET NOME = @NOME CNPJ = @CNPJ WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", laboratorio.Nome);
            command.Parameters.AddWithValue("@CNPJ", laboratorio.CNPJ);
            command.Parameters.AddWithValue("@ID", laboratorio.ID);
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
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }

    }
}
