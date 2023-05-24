namespace burger
{
  partial class FrmCozinha
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCozinha));
      this.dgvCozinha = new System.Windows.Forms.DataGridView();
      this.btnProntoPed = new System.Windows.Forms.Button();
      this.btnPreparaPed = new System.Windows.Forms.Button();
      this.dgvDelta = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dgvCozinha)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDelta)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvCozinha
      // 
      this.dgvCozinha.AllowUserToAddRows = false;
      this.dgvCozinha.AllowUserToDeleteRows = false;
      this.dgvCozinha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgvCozinha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCozinha.ColumnHeadersVisible = false;
      this.dgvCozinha.Location = new System.Drawing.Point(15, 17);
      this.dgvCozinha.Margin = new System.Windows.Forms.Padding(4);
      this.dgvCozinha.Name = "dgvCozinha";
      this.dgvCozinha.ReadOnly = true;
      this.dgvCozinha.RowHeadersVisible = false;
      this.dgvCozinha.RowHeadersWidth = 51;
      this.dgvCozinha.RowTemplate.Height = 24;
      this.dgvCozinha.Size = new System.Drawing.Size(462, 416);
      this.dgvCozinha.TabIndex = 0;
      this.dgvCozinha.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCozinha_CellClick);
      this.dgvCozinha.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCozinha_CellContentClick);
      this.dgvCozinha.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCozinha_RowsAdded);
      // 
      // btnProntoPed
      // 
      this.btnProntoPed.Enabled = false;
      this.btnProntoPed.Location = new System.Drawing.Point(485, 67);
      this.btnProntoPed.Margin = new System.Windows.Forms.Padding(4);
      this.btnProntoPed.Name = "btnProntoPed";
      this.btnProntoPed.Size = new System.Drawing.Size(100, 42);
      this.btnProntoPed.TabIndex = 46;
      this.btnProntoPed.Text = "Pronto";
      this.btnProntoPed.UseVisualStyleBackColor = true;
      this.btnProntoPed.Click += new System.EventHandler(this.btnProntoPed_Click);
      // 
      // btnPreparaPed
      // 
      this.btnPreparaPed.Enabled = false;
      this.btnPreparaPed.Location = new System.Drawing.Point(485, 17);
      this.btnPreparaPed.Margin = new System.Windows.Forms.Padding(4);
      this.btnPreparaPed.Name = "btnPreparaPed";
      this.btnPreparaPed.Size = new System.Drawing.Size(100, 42);
      this.btnPreparaPed.TabIndex = 47;
      this.btnPreparaPed.Text = "Preparar";
      this.btnPreparaPed.UseVisualStyleBackColor = true;
      this.btnPreparaPed.Click += new System.EventHandler(this.btnPreparaPed_Click);
      // 
      // dgvDelta
      // 
      this.dgvDelta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgvDelta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDelta.Location = new System.Drawing.Point(15, 440);
      this.dgvDelta.Name = "dgvDelta";
      this.dgvDelta.RowHeadersWidth = 51;
      this.dgvDelta.RowTemplate.Height = 24;
      this.dgvDelta.Size = new System.Drawing.Size(570, 195);
      this.dgvDelta.TabIndex = 48;
      // 
      // FrmCozinha
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.SeaGreen;
      this.ClientSize = new System.Drawing.Size(593, 647);
      this.Controls.Add(this.dgvDelta);
      this.Controls.Add(this.btnPreparaPed);
      this.Controls.Add(this.btnProntoPed);
      this.Controls.Add(this.dgvCozinha);
      this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "FrmCozinha";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "SGI - Pedidos";
      this.Load += new System.EventHandler(this.Form4_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvCozinha)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDelta)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvCozinha;
    private System.Windows.Forms.Button btnProntoPed;
    private System.Windows.Forms.Button btnPreparaPed;
    private System.Windows.Forms.DataGridView dgvDelta;
  }
}