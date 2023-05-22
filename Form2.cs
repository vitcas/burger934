using System;
using System.Windows.Forms;

namespace burger
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }

    private void btnEntrar_Click(object sender, EventArgs e)
    {
      if (ClaMys.VerificarCredenciais(txtUser.Text, txtPwd.Text))
      {
        if (ClaMys.ChecaGestor(txtUser.Text)){
          this.Hide();
          var form2 = new Form3();
          form2.Closed += (s, args) => this.Close();
          form2.Show();
        }
        else {
          this.Hide();
          var form2 = new Form1();
          form2.Closed += (s, args) => this.Close();
          form2.Show();
        }
      }
      else
      {
        MessageBox.Show("Acesso negado!");
      }
    }
  }
}
