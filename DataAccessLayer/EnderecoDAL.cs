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
    public class EnderecoDAL:ICRUD<Endereco>
    { 

        public Response Insert(Endereco endereco)
    {
        //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
        //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
        //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
        string sql = $"INSERT INTO ENDERECO (CEP,LOGRADOURO,NUMERO_CASA,BAIRRO_ID) VALUES (@CEP,@LOGRADOURO,@NUMERO_CASA,@BAIRRO_ID)";

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\The_Shelow\Documents\FarmaciaZyx.mdf;Integrated Security=True;Connect Timeout=3";

        //ADO.NET 
        SqlConnection connection = new SqlConnection(connectionString);

        SqlCommand command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@CEP", endereco.CEP);
        command.Parameters.AddWithValue("@LOGRADOURO", endereco.Logradouro);
        command.Parameters.AddWithValue("@NUMERO_CASA", endereco.NumeroCasa);
        command.Parameters.AddWithValue("@BAIRRO_ID", endereco.BairroID);
        //Estamos conectados na base de dados
        //try catch
        //try catch finally
        //try finally
        try
        {
            connection.Open();
            command.ExecuteNonQuery();
            return new Response("Endereco cadastrado com sucesso.", true);
        }
        catch (Exception ex)
        {
            if (ex.Message.Contains("UQ_CLIENTES_EMAIL"))
            {
                //RETORNAR MENSAGEM QUE O EMAIL TA DUPLICADO
                return new Response("Email já está em uso.", false);
            }
            if (ex.Message.Contains("UQ_CLIENTES_CPF"))
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

    public Response Update(Endereco endereco)
    {
        //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
        //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
        //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
        string sql = $"UPDATE ENDERECO SET CEP = @CEP, LOGRADOURO = @LOGRADOURO, NUMERO_CASA = @NUMERO_CASA, BAIRRO_ID = @BAIRRO_ID WHERE ID = @ID";

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\The_Shelow\Documents\FarmaciaZyx.mdf;Integrated Security=True;Connect Timeout=3";

        //ADO.NET 
        SqlConnection connection = new SqlConnection(connectionString);

        SqlCommand command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@CEP", endereco.CEP);
        command.Parameters.AddWithValue("@LOGRADOURO", endereco.Logradouro);
        command.Parameters.AddWithValue("@NUMERO_CASA", endereco.NumeroCasa);
        command.Parameters.AddWithValue("@BAIRRO_ID", endereco.BairroID);
        command.Parameters.AddWithValue("@ID", endereco.ID);

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
                return new Response("Endereço excluido.", false);
            }
            return new Response("Endereço alterado com sucesso.", true);
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
        string sql = "DELETE FROM ENDERECO WHERE ID = @ID";

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
                return new Response("Endereço excluído com sucesso.", true);
            }
            return new Response("Endereço não excluído.", false);
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

    public DataResponse<Endereco> GetAll()
    {
        //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
        //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
        //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
        string sql = $"SELECT ID,CEP,LOGRADOURO,NUMERO_CASA,BAIRRO_ID FROM ENDERECO";

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\The_Shelow\Documents\FarmaciaZyx.mdf;Integrated Security=True;Connect Timeout=3";

        //ADO.NET 
        SqlConnection connection = new SqlConnection(connectionString);

        SqlCommand command = new SqlCommand(sql, connection);
        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Endereco> enderecos = new List<Endereco>();
            //Enquanto houver registros, o loop será executado!
            while (reader.Read())
            {
                    Endereco endereco = new Endereco();
                    endereco.ID = Convert.ToInt32(reader["ID"]);
                    endereco.CEP = Convert.ToString(reader["CEP"]);
                    endereco.Logradouro = Convert.ToString(reader["LOGRADOURO"]);
                    endereco.NumeroCasa = Convert.ToString(reader["NUMERO_CASA"]);
                    endereco.BairroID = Convert.ToInt32(reader["BAIRRO_ID"]);
                   
                    enderecos.Add(endereco);
            }
            return new DataResponse<Endereco>("Endereço selecionados com sucesso!", true, enderecos);
        }
        catch (Exception ex)
        {
            return new DataResponse<Endereco>("Erro no banco de dados, contate o administrador.", false, null);
        }
        //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
        finally
        {
            //Fecha a conexão
            connection.Dispose();
        }
    }
    public SingleResponse<Endereco> GetByID(int id)
    {
        //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
        //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
        //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
        string sql = $"SELECT ID,CEP,LOGRADOURO,NUMERO_CASA,BAIRRO_ID FROM ENDERECO WHERE ID = @ID";

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\The_Shelow\Documents\FarmaciaZyx.mdf;Integrated Security=True;Connect Timeout=3";

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
                    Endereco endereco = new Endereco();
                    endereco.ID = Convert.ToInt32(reader["ID"]);
                    endereco.CEP = Convert.ToString(reader["CEP"]);
                    endereco.Logradouro = Convert.ToString(reader["LOGRADOURO"]);
                    endereco.NumeroCasa = Convert.ToString(reader["NUMERO_CASA"]);
                    endereco.BairroID = Convert.ToInt32(reader["BAIRRO_ID"]);  
                return new SingleResponse<Endereco>("Endereço selecionado com sucesso!", true, endereco);
            }
            return new SingleResponse<Endereco>("Endereço não encontrado!", false, null);
        }
        catch (Exception ex)
        {
            return new SingleResponse<Endereco>("Erro no banco de dados, contate o administrador.", false, null);
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
