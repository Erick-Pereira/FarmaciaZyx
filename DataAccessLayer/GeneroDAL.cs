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
    public class GeneroDAL
    {
        string connectionString = ConnectionString._connectionString;
        public DataResponse<Generos> GetAll()
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME FROM GENEROS";

            SqlConnection connection = new SqlConnection(connectionString);
            //ADO.NET 
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Generos> generos = new List<Generos>();
                //Enquanto houver registros, o loop será executado!
                while (reader.Read())
                {
                    Generos genero = new Generos();
                    genero.ID = Convert.ToInt32(reader["ID"]);
                    genero.Nome = Convert.ToString(reader["NOME"]);
                    generos.Add(genero);
                }
                return new DataResponse<Generos>("Tipos de Clientes selecionados com sucesso!", true, generos);
            }
            catch (Exception ex)
            {
                return new DataResponse<Generos>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public SingleResponse<Generos> GetByID(int id)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME FROM GENEROS WHERE ID = @ID";



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
                    Generos genero = new Generos();
                    genero.ID = Convert.ToInt32(reader["ID"]);
                    genero.Nome = Convert.ToString(reader["NOME"]);
                    return new SingleResponse<Generos>("Tipo de Cliente selecionado com sucesso!", true, genero);
                }
                return new SingleResponse<Generos>("Tipo de Cliente não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Generos>("Erro no banco de dados, contate o administrador.", false, null);
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
