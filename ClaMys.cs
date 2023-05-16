using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace burger
{
  public class ClaMys
  {
    public static string mySkiString = "server=127.0.0.1;uid=root;pwd=swordfish47;database=burger934";
    public static bool DbConect()
    {
      MySqlConnection conn;
      try
      {
        conn = new MySqlConnection();
        conn.ConnectionString = mySkiString;
        conn.Open();
        return true;
      }
      catch (MySqlException ex)
      {
        MessageBox.Show(ex.Message);
        return false;
      }
    }
    public static bool VerificarCredenciais(string login, string senha)
    {
      bool credenciaisCorretas = false;
      using (MySqlConnection connection = new MySqlConnection(mySkiString))
      {
        connection.Open();
        string query = "SELECT COUNT(*) FROM usuario WHERE nick = @Login AND senha = @Senha";
        using (MySqlCommand command = new MySqlCommand(query, connection))
        {
          command.Parameters.AddWithValue("@Login", login);
          command.Parameters.AddWithValue("@Senha", senha);
          int count = Convert.ToInt32(command.ExecuteScalar());
          credenciaisCorretas = (count > 0);
        }
      }
      return credenciaisCorretas;
    }
    public static DataTable GetPedidos()
    {
      DataTable dt = new DataTable();
      try
      {
        using (var connection = new MySqlConnection(mySkiString))
        {
          connection.Open();
          using (var cmd = connection.CreateCommand())
          {
            cmd.CommandText = "SELECT * FROM v_pedidos";
            using (var da = new MySqlDataAdapter(cmd))
            {
              da.Fill(dt);
              return dt;
            }
          }
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public static DataTable GetClientes()
    {
      DataTable dt = new DataTable();
      try
      {
        using (var connection = new MySqlConnection(mySkiString))
        {
          connection.Open();
          using (var cmd = connection.CreateCommand())
          {
            cmd.CommandText = "SELECT * FROM v_clientes";
            using (var da = new MySqlDataAdapter(cmd))
            {
              da.Fill(dt);
              return dt;
            }
          }
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public static DataTable GetProdutos()
    {
      DataTable dt = new DataTable();
      try
      {
        using (var connection = new MySqlConnection(mySkiString))
        {
          connection.Open();
          using (var cmd = connection.CreateCommand())
          {
            cmd.CommandText = "SELECT * FROM v_prods";
            using (var da = new MySqlDataAdapter(cmd))
            {
              da.Fill(dt);
              return dt;
            }
          }
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}
