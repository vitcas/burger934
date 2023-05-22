using System;
using System.Data;
using System.Windows.Forms;

namespace burger
{
  public partial class Form3 : Form
  {
    public Form3()
    {
      InitializeComponent();
    }

    private void Form3_Load(object sender, EventArgs e)
    {
      try
      {
        DataTable dt = new DataTable();
        dt = ClaMys.GetClientes();
        dgvCli.DataSource = dt;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro : " + ex.Message);
      }
      try
      {
        DataTable dt = new DataTable();
        dt = ClaMys.GetProdutos();
        dgvProd.DataSource = dt;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro : " + ex.Message);
      }
    }

    private void btnAdcCliente_Click(object sender, EventArgs e)
    {
      try
      {
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
      catch (Exception ex)
      {
        MessageBox.Show("Erro : " + ex.Message);
      }
    }

    private void dgvCli_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        DataGridViewRow row = this.dgvCli.Rows[e.RowIndex];
        txtId.Text = row.Cells["id"].Value.ToString();
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

    private void dgvProd_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      DataGridViewRow row = this.dgvProd.Rows[e.RowIndex];
      txtCodProd.Text = row.Cells["iD"].Value.ToString();
      txtNomeProd.Text = row.Cells["Nome"].Value.ToString();
      txtDescProd.Text = row.Cells["Descricao"].Value.ToString();
      cmbTipo.Text = row.Cells["categoria"].Value.ToString();
      numValor.Text = row.Cells["Valor"].Value.ToString();
    }

    private void btnLimpaProd_Click(object sender, EventArgs e)
    {
      txtCodProd.Text = "";
      txtNomeProd.Text = "";
      txtDescProd.Text = "";
      cmbTipo.Text = "";
      numValor.Text = "";
    }

    private void btnAdcProduto_Click(object sender, EventArgs e)
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

    private void btnLimpaCliente_Click(object sender, EventArgs e)
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

    private void btnConsultaCep_Click(object sender, EventArgs e)
    {
      btnConsultaCep.Enabled = false;
      var resultado = Apis.ConsultarCep(txtCep.Text);
      txtLog.Text = resultado.Logradouro;
      txtBairro.Text = resultado.Bairro;
      txtUf.Text = resultado.Uf;
      btnConsultaCep.Enabled = true;
    }
  }
}
