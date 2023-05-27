using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace burger
{
  public class ClaMys
  {
    public static string mySkiString = "server=delli3-mysql.at.remote.it;port=33001;uid=cecilia;pwd=2rTcx6scfUBAZjkZ;database=burger934";
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
    public static int GetCargoById(string quem)
    {
      using (var connection = new MySqlConnection(mySkiString))
      {
        connection.Open();
        using (var command = new MySqlCommand("SELECT id_cargo FROM usuario WHERE nick = @nick", connection))
        {
          command.Parameters.AddWithValue("@nick", quem);
          var cargo = command.ExecuteScalar();
          return (int)cargo;
        }
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
    public static bool VerificaPedido(string codigo)
    {
      bool existe = false;
      using (MySqlConnection connection = new MySqlConnection(mySkiString))
      {
        connection.Open();
        string query = "SELECT COUNT(*) FROM pedido WHERE id = @codigo";
        using (MySqlCommand command = new MySqlCommand(query, connection))
        {
          command.Parameters.AddWithValue("@codigo", codigo);
          int count = Convert.ToInt32(command.ExecuteScalar());
          existe = (count > 0);
        }
      }
      return existe;
    }
    public static DataTable GetPedidos(string filtro)
    {
      string consulta = "SELECT * FROM v_pedidos2 where estado not like 'concluido' and estado not like 'cancelado'; ";
      if (filtro != "todos")
        consulta = "SELECT * FROM v_pedidos2 where estado like @filtro";
      DataTable dt = new DataTable();
      try
      {
        using (var connection = new MySqlConnection(mySkiString))
        {
          connection.Open();
          using (var cmd = connection.CreateCommand())
          {
            cmd.CommandText = consulta;
            cmd.Parameters.AddWithValue("@filtro", filtro);
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
    public static DataTable GetCozinha()
    {
      string formattedDate = DateTime.Now.ToString("yyyy-MM-dd");
      DataTable dt = new DataTable();
      try
      {
        using (var connection = new MySqlConnection(mySkiString))
        {
          connection.Open();
          using (var cmd = connection.CreateCommand())
          {
            cmd.CommandText = "SELECT codigo,horap,estado FROM v_cozinha WHERE datap = @fdata AND estado = 'confirmado' OR estado = 'preparando'; ";
            cmd.Parameters.AddWithValue("@fdata", formattedDate);
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
    public static DataTable GetUsuarios()
    {
      DataTable dt = new DataTable();
      try
      {
        using (var connection = new MySqlConnection(mySkiString))
        {
          connection.Open();
          using (var cmd = connection.CreateCommand())
          {
            cmd.CommandText = "SELECT * FROM v_usuarios";
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
    public static DataTable DetalhesPedido(string id)
    {
      DataTable dt = new DataTable();
      try
      {
        using (var connection = new MySqlConnection(mySkiString))
        {
          connection.Open();
          using (var cmd = connection.CreateCommand())
          {
            cmd.CommandText = "select SUBSTRING(ip.id_pedido, 1, 8) as pedido, produto.nome as item, ip.quantidade as qtd from item_pedido ip inner join produto on ip.id_produto = produto.id where id_pedido = @id";
            cmd.Parameters.AddWithValue("@id", id);
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
    public static void InsertItensPed(string json) {
      DetalhesPedido detalhes = JsonConvert.DeserializeObject<DetalhesPedido>(json);
      int npedidos = detalhes.Items.Length;
      for (int i = 0; i < npedidos; i++)
      {
        using (var connection = new MySqlConnection(mySkiString))
        {
          connection.Open();
          using (var cmd = connection.CreateCommand())
          {
            cmd.CommandText = "INSERT INTO item_pedido (id_pedido, id_produto, quantidade) VALUES (@idped, @idprod, @qtd)";
            cmd.Parameters.AddWithValue("@idped", detalhes.Id);
            cmd.Parameters.AddWithValue("@idprod", detalhes.Items[i].ExternalCode);
            cmd.Parameters.AddWithValue("@qtd", detalhes.Items[i].Quantity);
            cmd.ExecuteNonQuery();
          }
        }
      }
      Console.WriteLine("detalhes capturados");
    }
    public static int InsertPedidos(string json, string token)
    {
      string detalhesjson = "";
      int tempedido = 0;
      try
      {
        List<Pedido> pedidos = JsonConvert.DeserializeObject<List<Pedido>>(json);
        using (var connection = new MySqlConnection(mySkiString))
        {
          connection.Open();
          foreach (var pedido in pedidos)
          {
            string jsonevento = JsonConvert.SerializeObject(pedido);            
            if (!VerificaPedido(pedido.orderId))
            {
              tempedido++;
              using (var cmd = connection.CreateCommand())
              {
                cmd.CommandText = "INSERT INTO pedido (id, dataped, estado) VALUES (@id, @dataped, @estado)";
                cmd.Parameters.AddWithValue("@id", pedido.orderId);
                cmd.Parameters.AddWithValue("@dataped", pedido.createdAt);
                cmd.Parameters.AddWithValue("@estado", pedido.code);
                cmd.ExecuteNonQuery();
              }
              detalhesjson = FoodPro.DetaPedido(pedido.orderId, token);
              InsertItensPed(detalhesjson);
              DetalhesPedido detalhes = JsonConvert.DeserializeObject<DetalhesPedido>(detalhesjson);
              using (var cmd = connection.CreateCommand())
              {
                cmd.CommandText = "UPDATE pedido SET nome_cli=@nome, valor_total=@total WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", pedido.orderId);
                cmd.Parameters.AddWithValue("@nome", detalhes.Customer.Name);
                cmd.Parameters.AddWithValue("@total", detalhes.Total.OrderAmount);
                cmd.ExecuteNonQuery();
              }             
            }
            if (pedido.code == "CON") {
              AtualizaStatus(pedido.orderId, pedido.code);
            }
          }
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
      return tempedido;
    }
    public static void AtualizaStatus(string pedido, string estado) {
      using (var connection = new MySqlConnection(mySkiString))
      {
        connection.Open();
        using (var cmd = connection.CreateCommand())
        {
          cmd.CommandText = "UPDATE pedido SET estado=@estado WHERE id=@id";
          cmd.Parameters.AddWithValue("@id", pedido);
          cmd.Parameters.AddWithValue("@estado", estado);
          cmd.ExecuteNonQuery();
        }
      }
    }
  }
}
