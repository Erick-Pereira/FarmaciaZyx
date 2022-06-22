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
    public class TipoFuncionarioDAL
    {
        string connectionString = ConnectionString._connectionString;
        public DataResponse<TipoFuncionario> GetAll()
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME FROM TIPOS_FUNCIONARIOS";
            
            SqlConnection connection = new SqlConnection(connectionString);
            //ADO.NET 
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<TipoFuncionario> tipoFuncionarios = new List<TipoFuncionario>();
                //Enquanto houver registros, o loop será executado!
                while (reader.Read())
                {
                    TipoFuncionario tipoFuncionario = new TipoFuncionario();
                    tipoFuncionario.ID = Convert.ToInt32(reader["ID"]);
                    tipoFuncionario.Nome = Convert.ToString(reader["NOME"]);
                    tipoFuncionarios.Add(tipoFuncionario);
                }
                return new DataResponse<TipoFuncionario>("Tipos de Funcionarios selecionados com sucesso!", true, tipoFuncionarios);
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
        public SingleResponse<TipoFuncionario> GetByID(int id)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME FROM TIPOS_FUNCIONARIOS WHERE ID = @ID";



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
                    TipoFuncionario tipoFuncionario = new TipoFuncionario();
                    tipoFuncionario.ID = Convert.ToInt32(reader["ID"]);
                    tipoFuncionario.Nome = Convert.ToString(reader["NOME"]);
                    return new SingleResponse<TipoFuncionario>("Tipo de Funcionario selecionado com sucesso!", true, tipoFuncionario);
                }
                return new SingleResponse<TipoFuncionario>("Tipo de Funcionario não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<TipoFuncionario>("Erro no banco de dados, contate o administrador.", false, null);
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
