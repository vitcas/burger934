namespace burger
{
  partial class Form4
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
      this.dgvCozinha = new System.Windows.Forms.DataGridView();
      this.btnProntoPed = new System.Windows.Forms.Button();
      this.btnPreparaPed = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgvCozinha)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvCozinha
      // 
      this.dgvCozinha.AllowUserToAddRows = false;
      this.dgvCozinha.AllowUserToDeleteRows = false;
      this.dgvCozinha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCozinha.Location = new System.Drawing.Point(12, 12);
      this.dgvCozinha.Name = "dgvCozinha";
      this.dgvCozinha.ReadOnly = true;
      this.dgvCozinha.RowHeadersWidth = 51;
      this.dgvCozinha.RowTemplate.Height = 24;
      this.dgvCozinha.Size = new System.Drawing.Size(240, 150);
      this.dgvCozinha.TabIndex = 0;
      // 
      // btnProntoPed
      // 
      this.btnProntoPed.Location = new System.Drawing.Point(98, 168);
      this.btnProntoPed.Name = "btnProntoPed";
      this.btnProntoPed.Size = new System.Drawing.Size(80, 30);
      this.btnProntoPed.TabIndex = 46;
      this.btnProntoPed.Text = "Pronto";
      this.btnProntoPed.UseVisualStyleBackColor = true;
      // 
      // btnPreparaPed
      // 
      this.btnPreparaPed.Location = new System.Drawing.Point(12, 168);
      this.btnPreparaPed.Name = "btnPreparaPed";
      this.btnPreparaPed.Size = new System.Drawing.Size(80, 30);
      this.btnPreparaPed.TabIndex = 47;
      this.btnPreparaPed.Text = "Preparar";
      this.btnPreparaPed.UseVisualStyleBackColor = true;
      // 
      // Form4
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.SeaGreen;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnPreparaPed);
      this.Controls.Add(this.btnProntoPed);
      this.Controls.Add(this.dgvCozinha);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form4";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "SGI - Pedidos";
      ((System.ComponentModel.ISupportInitialize)(this.dgvCozinha)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvCozinha;
    private System.Windows.Forms.Button btnProntoPed;
    private System.Windows.Forms.Button btnPreparaPed;
  }
}