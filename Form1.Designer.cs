namespace burger
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.dgvDetails = new System.Windows.Forms.DataGridView();
      this.btnPol = new System.Windows.Forms.Button();
      this.btnEntregaPed = new System.Windows.Forms.Button();
      this.btnConfirmaPed = new System.Windows.Forms.Button();
      this.comboBox4 = new System.Windows.Forms.ComboBox();
      this.txtPedidoId = new System.Windows.Forms.TextBox();
      this.label13 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.dgvPed = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPed)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvDetails
      // 
      this.dgvDetails.AllowUserToAddRows = false;
      this.dgvDetails.AllowUserToDeleteRows = false;
      this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgvDetails.BackgroundColor = System.Drawing.Color.DimGray;
      this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDetails.Location = new System.Drawing.Point(645, 117);
      this.dgvDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.dgvDetails.Name = "dgvDetails";
      this.dgvDetails.ReadOnly = true;
      this.dgvDetails.RowHeadersWidth = 51;
      this.dgvDetails.RowTemplate.Height = 24;
      this.dgvDetails.Size = new System.Drawing.Size(447, 264);
      this.dgvDetails.TabIndex = 53;
      // 
      // btnPol
      // 
      this.btnPol.Enabled = false;
      this.btnPol.Location = new System.Drawing.Point(861, 65);
      this.btnPol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnPol.Name = "btnPol";
      this.btnPol.Size = new System.Drawing.Size(100, 42);
      this.btnPol.TabIndex = 50;
      this.btnPol.Text = "Puxar";
      this.btnPol.UseVisualStyleBackColor = true;
      this.btnPol.Visible = false;
      this.btnPol.Click += new System.EventHandler(this.btnPol_Click);
      // 
      // btnEntregaPed
      // 
      this.btnEntregaPed.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEntregaPed.Location = new System.Drawing.Point(753, 65);
      this.btnEntregaPed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnEntregaPed.Name = "btnEntregaPed";
      this.btnEntregaPed.Size = new System.Drawing.Size(100, 42);
      this.btnEntregaPed.TabIndex = 46;
      this.btnEntregaPed.Text = "Entregar";
      this.btnEntregaPed.UseVisualStyleBackColor = true;
      this.btnEntregaPed.Click += new System.EventHandler(this.btnEntregaPed_Click);
      // 
      // btnConfirmaPed
      // 
      this.btnConfirmaPed.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnConfirmaPed.Location = new System.Drawing.Point(645, 65);
      this.btnConfirmaPed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnConfirmaPed.Name = "btnConfirmaPed";
      this.btnConfirmaPed.Size = new System.Drawing.Size(100, 42);
      this.btnConfirmaPed.TabIndex = 43;
      this.btnConfirmaPed.Text = "Confirmar";
      this.btnConfirmaPed.UseVisualStyleBackColor = true;
      this.btnConfirmaPed.Click += new System.EventHandler(this.btnConfirmaPed_Click);
      // 
      // comboBox4
      // 
      this.comboBox4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comboBox4.FormattingEnabled = true;
      this.comboBox4.Items.AddRange(new object[] {
            "novo",
            "confirmado",
            "preparando",
            "pronto",
            "enviado",
            "concluido",
            "cancelado"});
      this.comboBox4.Location = new System.Drawing.Point(645, 425);
      this.comboBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.comboBox4.Name = "comboBox4";
      this.comboBox4.Size = new System.Drawing.Size(135, 31);
      this.comboBox4.TabIndex = 38;
      // 
      // txtPedidoId
      // 
      this.txtPedidoId.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPedidoId.Location = new System.Drawing.Point(116, 25);
      this.txtPedidoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtPedidoId.Name = "txtPedidoId";
      this.txtPedidoId.ReadOnly = true;
      this.txtPedidoId.Size = new System.Drawing.Size(361, 30);
      this.txtPedidoId.TabIndex = 41;
      this.txtPedidoId.Text = "bfe4c61f-c20c-4cb2-ae47-af15208529f1";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.Location = new System.Drawing.Point(645, 397);
      this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(93, 23);
      this.label13.TabIndex = 40;
      this.label13.Text = "Filtrar por:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(15, 28);
      this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(72, 23);
      this.label6.TabIndex = 36;
      this.label6.Text = "Pedido:";
      // 
      // dgvPed
      // 
      this.dgvPed.AllowUserToAddRows = false;
      this.dgvPed.AllowUserToDeleteRows = false;
      this.dgvPed.AllowUserToResizeRows = false;
      this.dgvPed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgvPed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPed.ColumnHeadersVisible = false;
      this.dgvPed.Location = new System.Drawing.Point(19, 65);
      this.dgvPed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.dgvPed.Name = "dgvPed";
      this.dgvPed.ReadOnly = true;
      this.dgvPed.RowHeadersWidth = 51;
      this.dgvPed.RowTemplate.Height = 24;
      this.dgvPed.Size = new System.Drawing.Size(618, 525);
      this.dgvPed.TabIndex = 35;
      this.dgvPed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPed_CellClick_1);
      this.dgvPed.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPed_CellFormatting);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(500, 21);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(137, 30);
      this.label1.TabIndex = 55;
      this.label1.Text = "01-01-2023";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.Gold;
      this.label2.Location = new System.Drawing.Point(655, 554);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(44, 20);
      this.label2.TabIndex = 56;
      this.label2.Text = "msg";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.SeaGreen;
      this.ClientSize = new System.Drawing.Size(1105, 609);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dgvDetails);
      this.Controls.Add(this.btnPol);
      this.Controls.Add(this.btnEntregaPed);
      this.Controls.Add(this.btnConfirmaPed);
      this.Controls.Add(this.comboBox4);
      this.Controls.Add(this.txtPedidoId);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.dgvPed);
      this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "SGI - Pedidos";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPed)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion
    private System.Windows.Forms.DataGridView dgvDetails;
    private System.Windows.Forms.Button btnPol;
    private System.Windows.Forms.Button btnEntregaPed;
    private System.Windows.Forms.Button btnConfirmaPed;
    private System.Windows.Forms.ComboBox comboBox4;
    private System.Windows.Forms.TextBox txtPedidoId;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.DataGridView dgvPed;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}

