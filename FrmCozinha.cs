using Newtonsoft.Json;
using System;
using System.Data;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace burger
{
  public partial class FrmCozinha : Form
  {
    public string accessToken = "";
    public string pedidoId = "";
    private System.Windows.Forms.Timer timer2;
    public void InitTimer()
    {
      timer2 = new System.Windows.Forms.Timer();
      timer2.Tick += new EventHandler(timer2_Tick);
      timer2.Interval = 30000; // in miliseconds
      timer2.Start();
    }
    private void timer2_Tick(object sender, EventArgs e)
    {
      FazPol();
    }
    public FrmCozinha()
    {
      InitializeComponent();
    }
    private void PopulaPedido()
    {
      try
      {
        DataTable dt = new DataTable();
        dt = ClaMys.GetCozinha();
        dgvCozinha.DataSource = dt;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro : " + ex.Message);
      }
    }
    private void PlayAlertSound2()
    {
      using (var soundPlayer = new SoundPlayer())
      {
        string soundFilePath = "bell.wav";
        soundPlayer.SoundLocation = soundFilePath;
        soundPlayer.PlaySync();
      }
    }
    private void FazPol()
    {
      string result = FoodPro.Polling(accessToken);
      if (result != "")
      {
        FoodPro.AcknowledgeEvent(accessToken, result);
      }
      //pollresult = result;
      PopulaPedido();
      Console.WriteLine("Poll executado em: " + DateTime.Now.ToString("HH:mm:ss"));
    }
    private void Form4_Load(object sender, EventArgs e)
    {
      PopulaPedido();
      string result = FoodPro.GetAccessToken();
      dynamic responseObject = JsonConvert.DeserializeObject(result);
      accessToken = responseObject.accessToken;
      FoodPro.Polling(accessToken);
      Thread.Sleep(2000);
      FoodPro.Polling(accessToken);
      Thread.Sleep(2000);
      InitTimer();
    }
    private void btnProntoPed_Click(object sender, EventArgs e)
    {
      FoodPro.ProntoPedido(pedidoId, accessToken);
      ClaMys.AtualizaStatus(pedidoId,"RTP");
      btnProntoPed.Enabled = false;
      FazPol();
    }
    private void btnPreparaPed_Click(object sender, EventArgs e)
    {
      FoodPro.PrepararPedido(pedidoId, accessToken);
      ClaMys.AtualizaStatus(pedidoId, "PRE");
      btnPreparaPed.Enabled = false;
      FazPol();
    }
    private void dgvCozinha_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      DataGridViewRow row = this.dgvCozinha.Rows[e.RowIndex];
      string codigo = row.Cells["codigo"].Value.ToString();
      pedidoId = codigo;
      string estado = row.Cells["estado"].Value.ToString();
      if (estado == "confirmado")
      {
        btnPreparaPed.Enabled = true;
      }
      else
      {
        btnPreparaPed.Enabled = false;
      }
      if (estado == "preparando")
      {
        btnProntoPed.Enabled = true;
      }
      else
      {
        btnProntoPed.Enabled = false;
      }
      try
      {
        DataTable dt = new DataTable();
        dt = ClaMys.DetalhesPedido(codigo);
        dgvDelta.DataSource = dt;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro : " + ex.Message);
      }
    }
    private void dgvCozinha_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void dgvCozinha_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
      DataGridViewRow row = this.dgvCozinha.Rows[e.RowIndex];
      string estado = row.Cells["estado"].Value.ToString();
      if (estado == "confirmado")
      {
        PlayAlertSound2();
      }
    }
  }
}
