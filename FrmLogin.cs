using System;
using System.Windows.Forms;

namespace burger
{
  public partial class FrmLogin : Form
  {
    public FrmLogin()
    {
      InitializeComponent();
    }
    private void btnEntrar_Click(object sender, EventArgs e)
    {
      if (ClaMys.VerificarCredenciais(txtUser.Text, txtPwd.Text))
      {
        int valor = ClaMys.GetCargoById(txtUser.Text);
        switch (valor)
        {
          case 1: //adm
            Console.WriteLine("Valor é 1");
            this.Hide();
            var form1 = new FrmGestor();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            break;
          case 2: // cozinheiro
            Console.WriteLine("Valor é 2");
            this.Hide();
            var form2 = new FrmCozinha();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            break;
          case 3: //atendente
            Console.WriteLine("Valor é 3");
            this.Hide();
            var form3 = new FrmAtendente();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
            break;
          default:
            Console.WriteLine("Valor não corresponde a nenhum caso");
            break;
        }
      }
      else
      {
        MessageBox.Show("Acesso negado!");
      }
    }

    private void Form2_Load(object sender, EventArgs e)
    {

    }

    private void Form2_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)13)
      {
        btnEntrar.PerformClick();
      }
    }

    private void Form2_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Return)
      {
        MessageBox.Show("Enter pressed");
      }
    }

    private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)13)
      {
        btnEntrar.PerformClick();
      }
    }
  }
}
