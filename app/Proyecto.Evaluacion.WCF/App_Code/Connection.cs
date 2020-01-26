using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;

/// <summary>
/// Descripción breve de Connection
/// </summary>
public class Connection
{
    SqlConnection connection;
    SqlCommand command;
    string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["EvaluacionesDB"].ConnectionString;

    public Connection()
    {
        connection = new SqlConnection(connectionstring);
        command = connection.CreateCommand();
    }

    public Usuario GetUsuario(int UsuarioId)
    {
        var result = new Usuario();
        try
        {
            command.CommandText = "select * from dbo.usuario where UsuarioId = @UsuarioId";
            command.Parameters.AddWithValue("UsuarioId", UsuarioId);
            command.CommandType = System.Data.CommandType.Text;

            connection.Open();

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                result.UsuarioId = Convert.ToInt32(reader[0]);
                result.Correo = Convert.ToString(reader[1]);
                result.Nombres = Convert.ToString(reader[2]);
                result.Eliminado = Convert.ToBoolean(reader[3]);
            }

            return result;
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
    }


    public int InsUsuario(Usuario usuario)
    {
        var result = new Usuario();
        try
        {
            command.CommandText = "INSERT INTO [dbo].[Usuario]([Correo],[Nombres],[Eliminado]) VALUES(@correo,@nombres,0)";
            command.Parameters.AddWithValue("correo", usuario.Correo);
            command.Parameters.AddWithValue("nombres", usuario.Nombres);
            command.CommandType = System.Data.CommandType.Text;

            connection.Open();

            return command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
    }

    public int UpdUsuario(Usuario usuario)
    {
        var result = new Usuario();
        try
        {
            command.CommandText = "Update [dbo].[Usuario] set Nombres = @Nombres where UsuarioId = @UsuarioId";
            command.Parameters.AddWithValue("Nombres", usuario.Nombres);
            command.Parameters.AddWithValue("UsuarioId", usuario.UsuarioId);
            command.CommandType = System.Data.CommandType.Text;

            connection.Open();

            var prueba = command.ExecuteNonQuery();

            return 0;
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
    }


}