using Newtonsoft.Json;
using System;
using System.Data;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace burger
{
  public partial class Form1 : Form
  {
    public string accessToken = "";
    public string pedidoId = "";
    public string pollresult = "";
    private static System.Timers.Timer timer;
    public Form1()
    {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      PopulaPedido();
      string formattedDate = DateTime.Now.ToString("dd-MM-yyyy");
      label1.Text = formattedDate;  
      string result = FoodPro.GetAccessToken();
      dynamic responseObject = JsonConvert.DeserializeObject(result);
      accessToken = responseObject.accessToken;
      FoodPro.Polling(accessToken);
      Thread.Sleep(2000); 
      FoodPro.Polling(accessToken);
      //Thread.Sleep(2000);
      //string result2 = FoodPro.GetMerchantStatus(accessToken);
    }
    private void PopulaPedido() {
      try
      {
        DataTable dt = new DataTable();
        dt = ClaMys.GetPedidos();
        dgvPed.DataSource = dt;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro : " + ex.Message);
      }
    }
    private void PlayAlertSound()
    {
        using (var soundPlayer = new SoundPlayer())
        {
          string soundFilePath = "whistle.wav";
          soundPlayer.SoundLocation = soundFilePath;
          soundPlayer.PlaySync();
        }
    }
    private void FazPol() {
      string result = FoodPro.Polling(accessToken);
      if (result != "")
      {
        if (ClaMys.InsertPedidos(result, accessToken) > 0)
        {
          PlayAlertSound();
        }
        FoodPro.AcknowledgeEvent(accessToken, result);
      }
      pollresult = result;
      PopulaPedido();
      Console.WriteLine("Poll executado em: " + DateTime.Now.ToString("HH:mm:ss"));
    }
    private void dgvPed_CellClick_1(object sender, DataGridViewCellEventArgs e)
    {
      DataGridViewRow row = this.dgvPed.Rows[e.RowIndex];
      string codigo = row.Cells["codigo"].Value.ToString();
      txtPedidoId.Text = codigo;  
      comboBox4.Text = row.Cells["estado"].Value.ToString();
      try
      {
        DataTable dt = new DataTable();
        dt = ClaMys.DetalhesPedido(codigo);
        dgvDetails.DataSource = dt;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro : " + ex.Message);
      }
    }
    private void btnConfirmaPed_Click(object sender, EventArgs e)
    {
      FoodPro.ConfirmarPedido(txtPedidoId.Text, accessToken);
      label2.Text = "Confirmado!";
    }
    private void btnPreparaPed_Click(object sender, EventArgs e)
    {
      FoodPro.PrepararPedido(txtPedidoId.Text, accessToken);
      label2.Text = "Preparando!";
    }
    private void btnEntregaPed_Click(object sender, EventArgs e)
    {
      FoodPro.EntregarPedido(txtPedidoId.Text, accessToken);
      label2.Text = "Saiu para entrega!";
    }
    private void btnProntoPed_Click(object sender, EventArgs e)
    {
      FoodPro.ProntoPedido(txtPedidoId.Text, accessToken);
      label2.Text = "Pedido pronto!";
    }
    private void btnPol_Click(object sender, EventArgs e)
    {
      FazPol();
    }
    private void dgvPed_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      string estado = e.Value.ToString();
      if (e.ColumnIndex == dgvPed.Columns["estado"].Index)    
      switch (estado)
      {
        case "novo":
          dgvPed.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Khaki;
          break;
        case "confirmado":
          dgvPed.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Aquamarine;
          break;
        case "cancelado":
          dgvPed.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
          break;
        case "pronto":
          dgvPed.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Aquamarine;
          break;
        case "enviado":
          dgvPed.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Aquamarine;
          break;
        case "concluido":
          dgvPed.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleGreen;
          break;
        case "preparando":
          dgvPed.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Aquamarine;
          break;
      }
    }
  }
}