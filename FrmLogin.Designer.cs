namespace burger
{
  partial class FrmLogin
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
      this.panel2 = new System.Windows.Forms.Panel();
      this.label4 = new System.Windows.Forms.Label();
      this.btnEntrar = new System.Windows.Forms.Button();
      this.txtPwd = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtUser = new System.Windows.Forms.TextBox();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.Black;
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel2.Controls.Add(this.label4);
      this.panel2.Controls.Add(this.btnEntrar);
      this.panel2.Controls.Add(this.txtPwd);
      this.panel2.Controls.Add(this.label5);
      this.panel2.Controls.Add(this.txtUser);
      this.panel2.Location = new System.Drawing.Point(73, 40);
      this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(304, 220);
      this.panel2.TabIndex = 1;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label4.Location = new System.Drawing.Point(53, 35);
      this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(63, 20);
      this.label4.TabIndex = 3;
      this.label4.Text = "Usuário:";
      // 
      // btnEntrar
      // 
      this.btnEntrar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEntrar.Location = new System.Drawing.Point(112, 135);
      this.btnEntrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.btnEntrar.Name = "btnEntrar";
      this.btnEntrar.Size = new System.Drawing.Size(75, 34);
      this.btnEntrar.TabIndex = 3;
      this.btnEntrar.Text = "Entrar";
      this.btnEntrar.UseVisualStyleBackColor = true;
      this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
      // 
      // txtPwd
      // 
      this.txtPwd.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPwd.Location = new System.Drawing.Point(122, 74);
      this.txtPwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.txtPwd.Name = "txtPwd";
      this.txtPwd.PasswordChar = '*';
      this.txtPwd.Size = new System.Drawing.Size(117, 25);
      this.txtPwd.TabIndex = 2;
      this.txtPwd.Text = "qwerty1234";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label5.Location = new System.Drawing.Point(53, 74);
      this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(54, 20);
      this.label5.TabIndex = 4;
      this.label5.Text = "Senha:";
      // 
      // txtUser
      // 
      this.txtUser.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUser.Location = new System.Drawing.Point(122, 32);
      this.txtUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.txtUser.Name = "txtUser";
      this.txtUser.Size = new System.Drawing.Size(117, 25);
      this.txtUser.TabIndex = 1;
      this.txtUser.Text = "ai.ohto";
      this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.SeaGreen;
      this.ClientSize = new System.Drawing.Size(438, 315);
      this.Controls.Add(this.panel2);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.MaximizeBox = false;
      this.Name = "Form2";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "SGI - Login";
      this.Load += new System.EventHandler(this.Form2_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
      this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnEntrar;
    private System.Windows.Forms.TextBox txtPwd;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtUser;
  }
}