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
      this.btnProntoPed = new System.Windows.Forms.Button();
      this.btnPreparaPed = new System.Windows.Forms.Button();
      this.btnConfirmaPed = new System.Windows.Forms.Button();
      this.comboBox4 = new System.Windows.Forms.ComboBox();
      this.txtPedidoId = new System.Windows.Forms.TextBox();
      this.label13 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.dgvPed = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
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
      this.dgvDetails.Location = new System.Drawing.Point(15, 417);
      this.dgvDetails.Name = "dgvDetails";
      this.dgvDetails.ReadOnly = true;
      this.dgvDetails.RowHeadersWidth = 51;
      this.dgvDetails.RowTemplate.Height = 24;
      this.dgvDetails.Size = new System.Drawing.Size(503, 184);
      this.dgvDetails.TabIndex = 53;
      // 
      // btnPol
      // 
      this.btnPol.Location = new System.Drawing.Point(462, 9);
      this.btnPol.Name = "btnPol";
      this.btnPol.Size = new System.Drawing.Size(80, 30);
      this.btnPol.TabIndex = 50;
      this.btnPol.Text = "Puxar";
      this.btnPol.UseVisualStyleBackColor = true;
      this.btnPol.Click += new System.EventHandler(this.btnPol_Click);
      // 
      // btnEntregaPed
      // 
      this.btnEntregaPed.Location = new System.Drawing.Point(610, 462);
      this.btnEntregaPed.Name = "btnEntregaPed";
      this.btnEntregaPed.Size = new System.Drawing.Size(80, 30);
      this.btnEntregaPed.TabIndex = 46;
      this.btnEntregaPed.Text = "Entregar";
      this.btnEntregaPed.UseVisualStyleBackColor = true;
      this.btnEntregaPed.Click += new System.EventHandler(this.btnEntregaPed_Click);
      // 
      // btnProntoPed
      // 
      this.btnProntoPed.Location = new System.Drawing.Point(610, 424);
      this.btnProntoPed.Name = "btnProntoPed";
      this.btnProntoPed.Size = new System.Drawing.Size(80, 30);
      this.btnProntoPed.TabIndex = 45;
      this.btnProntoPed.Text = "Pronto";
      this.btnProntoPed.UseVisualStyleBackColor = true;
      this.btnProntoPed.Click += new System.EventHandler(this.btnProntoPed_Click);
      // 
      // btnPreparaPed
      // 
      this.btnPreparaPed.Location = new System.Drawing.Point(524, 462);
      this.btnPreparaPed.Name = "btnPreparaPed";
      this.btnPreparaPed.Size = new System.Drawing.Size(80, 30);
      this.btnPreparaPed.TabIndex = 44;
      this.btnPreparaPed.Text = "Preparar";
      this.btnPreparaPed.UseVisualStyleBackColor = true;
      this.btnPreparaPed.Click += new System.EventHandler(this.btnPreparaPed_Click);
      // 
      // btnConfirmaPed
      // 
      this.btnConfirmaPed.Location = new System.Drawing.Point(524, 424);
      this.btnConfirmaPed.Name = "btnConfirmaPed";
      this.btnConfirmaPed.Size = new System.Drawing.Size(80, 30);
      this.btnConfirmaPed.TabIndex = 43;
      this.btnConfirmaPed.Text = "Confirmar";
      this.btnConfirmaPed.UseVisualStyleBackColor = true;
      this.btnConfirmaPed.Click += new System.EventHandler(this.btnConfirmaPed_Click);
      // 
      // comboBox4
      // 
      this.comboBox4.FormattingEnabled = true;
      this.comboBox4.Items.AddRange(new object[] {
            "fazendo",
            "entregue",
            "cancelado"});
      this.comboBox4.Location = new System.Drawing.Point(83, 46);
      this.comboBox4.Name = "comboBox4";
      this.comboBox4.Size = new System.Drawing.Size(148, 24);
      this.comboBox4.TabIndex = 38;
      // 
      // txtPedidoId
      // 
      this.txtPedidoId.Location = new System.Drawing.Point(83, 16);
      this.txtPedidoId.Name = "txtPedidoId";
      this.txtPedidoId.Size = new System.Drawing.Size(295, 22);
      this.txtPedidoId.TabIndex = 41;
      this.txtPedidoId.Text = "bfe4c61f-c20c-4cb2-ae47-af15208529f1";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(12, 50);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(63, 16);
      this.label13.TabIndex = 40;
      this.label13.Text = "Situação:";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(548, 9);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(39, 16);
      this.label10.TabIndex = 39;
      this.label10.Text = "Data:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(237, 50);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(51, 16);
      this.label7.TabIndex = 37;
      this.label7.Text = "Cliente:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(12, 19);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(67, 16);
      this.label6.TabIndex = 36;
      this.label6.Text = "id pedido:";
      // 
      // dgvPed
      // 
      this.dgvPed.AllowUserToAddRows = false;
      this.dgvPed.AllowUserToDeleteRows = false;
      this.dgvPed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgvPed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPed.Location = new System.Drawing.Point(15, 76);
      this.dgvPed.Name = "dgvPed";
      this.dgvPed.ReadOnly = true;
      this.dgvPed.RowHeadersWidth = 51;
      this.dgvPed.RowTemplate.Height = 24;
      this.dgvPed.Size = new System.Drawing.Size(675, 335);
      this.dgvPed.TabIndex = 35;
      this.dgvPed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPed_CellClick_1);
      this.dgvPed.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPed_CellFormatting);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(593, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(93, 20);
      this.label1.TabIndex = 55;
      this.label1.Text = "01-01-2023";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.Gold;
      this.label2.Location = new System.Drawing.Point(474, 46);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(44, 20);
      this.label2.TabIndex = 56;
      this.label2.Text = "msg";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(294, 50);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(44, 16);
      this.label3.TabIndex = 57;
      this.label3.Text = "label3";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.SeaGreen;
      this.ClientSize = new System.Drawing.Size(702, 613);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dgvDetails);
      this.Controls.Add(this.btnPol);
      this.Controls.Add(this.btnEntregaPed);
      this.Controls.Add(this.btnProntoPed);
      this.Controls.Add(this.btnPreparaPed);
      this.Controls.Add(this.btnConfirmaPed);
      this.Controls.Add(this.comboBox4);
      this.Controls.Add(this.txtPedidoId);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.dgvPed);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    private System.Windows.Forms.Button btnProntoPed;
    private System.Windows.Forms.Button btnPreparaPed;
    private System.Windows.Forms.Button btnConfirmaPed;
    private System.Windows.Forms.ComboBox comboBox4;
    private System.Windows.Forms.TextBox txtPedidoId;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.DataGridView dgvPed;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
  }
}

