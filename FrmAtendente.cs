using Newtonsoft.Json;
using System;
using System.Data;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace burger
{
  public partial class FrmAtendente : Form
  {
    public string accessToken = "";
    public string pedidoId = "";
    public string pollresult = "";
    private System.Windows.Forms.Timer timer1;
    public void InitTimer()
    {
      timer1 = new System.Windows.Forms.Timer();
      timer1.Tick += new EventHandler(timer1_Tick);
      timer1.Interval = 30000; // in miliseconds
      timer1.Start();
    }
    private void timer1_Tick(object sender, EventArgs e)
    {
      FazPol();
    }
    public FrmAtendente()
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
      Thread.Sleep(2000);
      string result2 = FoodPro.GetMerchantStatus(accessToken);
      dynamic responseObject2 = JsonConvert.DeserializeObject(result2);
      Console.WriteLine(responseObject2[0].state);
      InitTimer();
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
      string estado = row.Cells["estado"].Value.ToString();
      if (estado == "novo")
      {
        btnConfirmaPed.Enabled = true;
      }
      else {
        btnConfirmaPed.Enabled = false;
      }
      if (estado == "pronto")
      {
        btnEntregaPed.Enabled = true;
      }
      else
      {
        btnEntregaPed.Enabled = false;
      }
      txtPedidoId.Text = codigo;  
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
      ClaMys.AtualizaStatus(txtPedidoId.Text, "CFM");
      btnConfirmaPed.Enabled = false;
      FazPol();
      Console.WriteLine("Confirmado!");
    }
    private void btnEntregaPed_Click(object sender, EventArgs e)
    {
      FoodPro.EntregarPedido(txtPedidoId.Text, accessToken);
      ClaMys.AtualizaStatus(txtPedidoId.Text, "DSP");
      btnEntregaPed.Enabled = false;
      FazPol();
      Console.WriteLine("Saiu para entrega!");
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
          dgvPed.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Cyan;
          break;
        case "cancelado":
          dgvPed.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
          break;
        case "pronto":
          dgvPed.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Violet;
          break;
        case "enviado":
          dgvPed.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DodgerBlue;
          break;
        case "concluido":
          dgvPed.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleGreen;
          break;
        case "preparando":
          dgvPed.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Thistle;
          break;
      }
    }
  }
}