using Newtonsoft.Json;
using System;
using System.Data;
using System.Windows.Forms;

namespace burger
{
  public partial class Form1 : Form
  {
    public string accessToken = "";
    public string pedidoId = "";
    public Form1()
    {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      try
      {
        DataTable dt = new DataTable();
        dt = DalHelper.GetClientes();
        dgvCli.DataSource = dt;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro : " + ex.Message);
      }
      try
      {
        DataTable dt = new DataTable();
        dt = DalHelper.GetPedidos();
        dgvPed.DataSource = dt;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro : " + ex.Message);
      }
      try
      {
        DataTable dt = new DataTable();
        dt = DalHelper.GetProdutos();
        dgvProd.DataSource = dt;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro : " + ex.Message);
      }
    }
    private void button6_Click(object sender, EventArgs e)
    {
      try{
        Endereco cep = new Endereco();
        Contato con = new Contato();  
        Cliente cli = new Cliente();
        
        cli.Contato = 1;
        con.Ddd = "11";
        con.Numero = txtTel.Text;

        cli.CEP = 1;
        cep.Bruto = txtCep.Text;
        cep.Uf = txtUf.Text;  
        cep.Bairro = txtBairro.Text;  
        cep.Logradouro = txtLog.Text;

        cli.Nome = txtNome.Text;
        cli.CPF = txtCpf.Text;
        cli.Pedidos = 0;

        cli.UF = "SP";
        cli.Bairro = txtBairro.Text;
        cli.Logradouro = txtLog.Text;
        
        DalHelper.AddCli(cli);
      }
      catch (Exception ex){
        MessageBox.Show("Erro : " + ex.Message);
      }
    } 
    private void button7_Click(object sender, EventArgs e)
    {
    }  
    private void button2_Click(object sender, EventArgs e)
    {
    }
  
    private void button3_Click(object sender, EventArgs e)
    {
    }
  
    private void button8_Click(object sender, EventArgs e)
    {
    }
  
    private void button3_Click_1(object sender, EventArgs e)
    {
      try
      {
        DataTable dt = new DataTable();
        dt = DalHelper.GetClientes();
        dgvCli.DataSource = dt;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro : " + ex.Message);
      }
    }
    
    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        DataTable dt = new DataTable();
        dt = DalHelper.GetPedidos();
        dgvPed.DataSource = dt;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro : " + ex.Message);
      }
    }
    
    private void button2_Click_1(object sender, EventArgs e)
    {
      try
      {
        DataTable dt = new DataTable();
        dt = DalHelper.GetProdutos();
        dgvProd.DataSource = dt;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro : " + ex.Message);
      }
    }
    
    private void tabControl1_Click(object sender, EventArgs e)
    {
      //MessageBox.Show("clicou");
    }
    
    private void textBox4_TextChanged(object sender, EventArgs e)
    {
    
    }
    
    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        DataGridViewRow row = this.dgvCli.Rows[e.RowIndex];
        txtId.Text = row.Cells["CLI_ID"].Value.ToString();
        txtNome.Text = row.Cells["Nome"].Value.ToString();
        txtCpf.Text = row.Cells["CPF"].Value.ToString();
        txtTel.Text = row.Cells["Telefone"].Value.ToString();
        txtCep.Text = row.Cells["CEP"].Value.ToString();
        txtNum.Text = row.Cells["Numero"].Value.ToString();
        txtComp.Text = row.Cells["Complemento"].Value.ToString();
        txtBairro.Text = row.Cells["Bairro"].Value.ToString();
        txtLog.Text = row.Cells["Logradouro"].Value.ToString();
      }
    }
    private void button8_Click_1(object sender, EventArgs e){
    }
    private void dgvProd_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      DataGridViewRow row = this.dgvProd.Rows[e.RowIndex];
      txtCodProd.Text = row.Cells["PROD_ID"].Value.ToString();
      txtNomeProd.Text = row.Cells["Nome"].Value.ToString();
      txtDescProd.Text = row.Cells["Descricao"].Value.ToString();
      cmbTipo.Text = row.Cells["Tipo"].Value.ToString();
      numValor.Text = row.Cells["Valor"].Value.ToString();
    }

    private void button18_Click(object sender, EventArgs e)
    {
      txtCodProd.Text = "";
      txtNomeProd.Text = "";
      txtDescProd.Text = "";
      cmbTipo.Text = "";
      numValor.Text = "";
    }

    private void button12_Click(object sender, EventArgs e)
    {
      try
      {
        Produto prod = new Produto();
        prod.Nome = txtNomeProd.Text;
        prod.Descricao = txtDescProd.Text;
        prod.Valor = (float)numValor.Value;
        prod.Tipo = 1;
        DalHelper.AddProd(prod);
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro : " + ex.Message);
      }
    }

    private void button5_Click(object sender, EventArgs e)
    {
      if (txtUser.Text == "admin" && txtPwd.Text == "admin")
      {
        tabControl1.Visible = true;
        panel2.Visible = false;
      }
      else
      {
        MessageBox.Show("Acesso negado!");
      }
    }

    private void button9_ClickAsync(object sender, EventArgs e)
    {
      button9.Enabled = false;  
      var resultado = Apis.ConsultarCep(txtCep.Text);
      txtLog.Text = resultado.Logradouro;
      txtBairro.Text = resultado.Bairro;
      txtUf.Text = resultado.Uf;
      button9.Enabled = true;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      txtId.Text = "";
      txtNome.Text = "";
      txtCpf.Text = "";
      txtTel.Text = "";
      txtCep.Text = "";
      txtNum.Text = "";
      txtComp.Text = "";
      txtBairro.Text = "";
      txtLog.Text = "";
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        button5.PerformClick();
      }
    }

    private void button21_Click(object sender, EventArgs e)
    {
      string result = MyClass.GetAccessToken();
      dynamic responseObject = JsonConvert.DeserializeObject(result);
      accessToken = responseObject.accessToken;
      rtb1.Text = accessToken;
      button21.Enabled = false;
    }

    private void button23_Click(object sender, EventArgs e)
    {
      string result = MyClass.Polling(accessToken);
      rtb1.Text = result;
    }

    private void button11_Click(object sender, EventArgs e)
    {
      MyClass.ConfirmarPedido(txtPedidoId.Text, accessToken);
    }

    private void button14_Click(object sender, EventArgs e)
    {
      MyClass.PrepararPedido(txtPedidoId.Text, accessToken);
    }

    private void button20_Click(object sender, EventArgs e)
    {
      MyClass.EntregarPedido(txtPedidoId.Text, accessToken);
    }

    private void button19_Click(object sender, EventArgs e)
    {
      MyClass.ProntoPedido(txtPedidoId.Text, accessToken);
    }

    private void button10_Click(object sender, EventArgs e)
    {
      string result = MyClass.DetalhesPedido(txtPedidoId.Text, accessToken);
      rtb1.Text = result;
    }

    private void button22_Click(object sender, EventArgs e)
    {
      MyClass.AcknowledgeEvent(accessToken, rtb1.Text);
    }

    private void button24_Click(object sender, EventArgs e)
    {
      string result = MyClass.GetMerchantStatus(accessToken);
      rtb1.Text = result;
    }
  }
}
