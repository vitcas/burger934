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
        this.Hide();
        int valor = ClaMys.GetCargoById(txtUser.Text);
        switch (valor)
        {
          case 1: //adm          
            var form1 = new FrmGestor();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            break;
          case 2: // cozinheiro
            var form2 = new FrmCozinha();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            break;
          case 3: //atendente
            var form3 = new FrmAtendente();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
            break;
          default:
            Console.WriteLine("erro");
            break;
        }
      }
      else
      {
        MessageBox.Show("Acesso negado!");
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
