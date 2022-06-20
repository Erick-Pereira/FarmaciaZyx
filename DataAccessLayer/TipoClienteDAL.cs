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
    public class TipoClienteDAL
    {
        string connectionString = ConnectionString._connectionString;
        public DataResponse<TipoFuncionario> GetAll()
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME FROM TIPOS_CLIENTES";

            SqlConnection connection = new SqlConnection(connectionString);
            //ADO.NET 
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<TipoFuncionario> tipoClientes = new List<TipoFuncionario>();
                //Enquanto houver registros, o loop será executado!
                while (reader.Read())
                {
                    TipoFuncionario tipoCliente = new TipoFuncionario();
                    tipoCliente.ID = Convert.ToInt32(reader["ID"]);
                    tipoCliente.Nome = Convert.ToString(reader["NOME"]);
                    tipoClientes.Add(tipoCliente);
                }
                return new DataResponse<TipoFuncionario>("Tipos de Funcionarios selecionados com sucesso!", true, tipoClientes);
            }
            catch (Exception ex)
            {
                return new DataResponse<TipoFuncionario>("Erro no banco de dados, contate o administrador.", false, null);
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
