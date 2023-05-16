using System;
using System.Data;
using System.Data.SQLite;

namespace burger
{
  public class DalHelper
  {
    private static SQLiteConnection sqliteConnection;
    public DalHelper() { }
    private static SQLiteConnection DbConnection()
    {
      sqliteConnection = new SQLiteConnection("Data Source=934.db; Version=3;");
      sqliteConnection.Open();
      return sqliteConnection;
    }
    public static void Login() {
      
    }
    public static DataTable GetClientes()
    {
      SQLiteDataAdapter da = null;
      DataTable dt = new DataTable();
      try
      {
        using (var cmd = DbConnection().CreateCommand())
        {
          cmd.CommandText = "SELECT * FROM v_clientes";
          da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
          da.Fill(dt);
          return dt;
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public static DataTable GetPedidos()
    {
      SQLiteDataAdapter da = null;
      DataTable dt = new DataTable();
      try
      {
        using (var cmd = DbConnection().CreateCommand())
        {
          cmd.CommandText = "SELECT * FROM v_pedidos";
          da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
          da.Fill(dt);
          return dt;
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public static DataTable GetCozinheiros()
    {
      SQLiteDataAdapter da = null;
      DataTable dt = new DataTable();
      try
      {
        using (var cmd = DbConnection().CreateCommand())
        {
          cmd.CommandText = "SELECT * FROM Cozinheiros";
          da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
          da.Fill(dt);
          return dt;
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public static DataTable GetEntregadores()
    {
      SQLiteDataAdapter da = null;
      DataTable dt = new DataTable();
      try
      {
        using (var cmd = DbConnection().CreateCommand())
        {
          cmd.CommandText = "SELECT * FROM Entregadores";
          da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
          da.Fill(dt);
          return dt;
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public static DataTable GetProdutos()
    {
      SQLiteDataAdapter da = null;
      DataTable dt = new DataTable();
      try
      {
        using (var cmd = DbConnection().CreateCommand())
        {
          cmd.CommandText = "SELECT * FROM v_prods";
          da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
          da.Fill(dt);
          return dt;
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public static DataTable GetCliente(int id)
    {
      SQLiteDataAdapter da = null;
      DataTable dt = new DataTable();
      try
      {
        using (var cmd = DbConnection().CreateCommand())
        {
          cmd.CommandText = "SELECT * FROM Clientes Where Id=" + id;
          da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
          da.Fill(dt);
          return dt;
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public static void AddCli(Cliente cliente)
    {
      try
      {
        using (var cmd = DbConnection().CreateCommand())
        {
          cmd.CommandText = "INSERT INTO Clientes(COM_ID,CEP_ID,CPF,Nome,Numero,Complemento,Ped_Realizados) values (@tel,@cep,@cpf,@nome,@num,@comp,@ped)";
          cmd.Parameters.AddWithValue("@tel", cliente.Contato);
          cmd.Parameters.AddWithValue("@cep", cliente.CEP);
          cmd.Parameters.AddWithValue("@cpf", cliente.CPF);
          cmd.Parameters.AddWithValue("@nome", cliente.Nome);
          cmd.Parameters.AddWithValue("@num", cliente.Número);
          cmd.Parameters.AddWithValue("@comp", cliente.Complemento);
          cmd.Parameters.AddWithValue("@ped", cliente.Pedidos);
          cmd.ExecuteNonQuery();
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public static void AddTel(Contato contato)
    {
      try
      {
        using (var cmd = DbConnection().CreateCommand())
        {
          cmd.CommandText = "INSERT INTO COMUNICACAO(DDD,Numero) values (@ddd,@num)";
          cmd.Parameters.AddWithValue("@ddd", contato.Ddd);
          cmd.Parameters.AddWithValue("@num", contato.Numero);
          cmd.ExecuteNonQuery();
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public static void AddCep(Endereco endereco)
    {
      try
      {
        using (var cmd = DbConnection().CreateCommand())
        {
          cmd.CommandText = "INSERT INTO CEP(CEP,Logradouro,Bairro,UF) values (@cep,@log,@bar,@uf)";
          cmd.Parameters.AddWithValue("@cep", endereco.Bruto);
          cmd.Parameters.AddWithValue("@log", endereco.Logradouro);
          cmd.Parameters.AddWithValue("@bar", endereco.Bairro);
          cmd.Parameters.AddWithValue("@uf", endereco.Uf);
          cmd.ExecuteNonQuery();
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public static void AddProd(Produto produto)
    {
      try
      {
        using (var cmd = DbConnection().CreateCommand())
        {
          cmd.CommandText = "INSERT INTO PRODUTOS(Nome,Descricao,Valor,Tipo_ID) values (@nome,@desc,@valor,@tipo)";
          cmd.Parameters.AddWithValue("@nome", produto.Nome);
          cmd.Parameters.AddWithValue("@desc", produto.Descricao);
          cmd.Parameters.AddWithValue("@valor", produto.Valor);
          cmd.Parameters.AddWithValue("@tipo", produto.Tipo);
          cmd.ExecuteNonQuery();
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public static void Update(Cliente cliente)
    {
      try
      {
        using (var cmd = new SQLiteCommand(DbConnection()))
        {
          cmd.CommandText = "UPDATE Clientes SET Nome=@Nome, Email=@Email WHERE Id=@Id";
          cmd.Parameters.AddWithValue("@codigo", cliente.Id);
          cmd.Parameters.AddWithValue("@tel", cliente.Contato);
          cmd.Parameters.AddWithValue("@cep", cliente.CEP);
          cmd.Parameters.AddWithValue("@cpf", cliente.CPF);
          cmd.Parameters.AddWithValue("@nome", cliente.Nome);
          cmd.Parameters.AddWithValue("@num", cliente.Número);
          cmd.Parameters.AddWithValue("@comp", cliente.Complemento);
          cmd.Parameters.AddWithValue("@ped", cliente.Pedidos);
          cmd.ExecuteNonQuery();
        };
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public static void Delete(int Id)
    {
      try
      {
        using (var cmd = new SQLiteCommand(DbConnection()))
        {
          cmd.CommandText = "DELETE FROM Clientes Where Id=@Id";
          cmd.Parameters.AddWithValue("@Id", Id);
          cmd.ExecuteNonQuery();
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}