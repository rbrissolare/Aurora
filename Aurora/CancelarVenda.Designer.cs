namespace Aurora
{
    partial class CancelarVenda
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
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dgvCancelarVendas = new System.Windows.Forms.DataGridView();
            this.idVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdVenda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelarVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(93, 6);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(81, 20);
            this.dtpInicio.TabIndex = 1;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // dtpFim
            // 
            this.dtpFim.CustomFormat = "dd/MM/yyyy";
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFim.Location = new System.Drawing.Point(259, 6);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(81, 20);
            this.dtpFim.TabIndex = 2;
            // 
            // dgvCancelarVendas
            // 
            this.dgvCancelarVendas.AllowUserToOrderColumns = true;
            this.dgvCancelarVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancelarVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVenda,
            this.idCliente,
            this.idDataVenda,
            this.idValorTotal});
            this.dgvCancelarVendas.Location = new System.Drawing.Point(12, 51);
            this.dgvCancelarVendas.Name = "dgvCancelarVendas";
            this.dgvCancelarVendas.ReadOnly = true;
            this.dgvCancelarVendas.Size = new System.Drawing.Size(441, 387);
            this.dgvCancelarVendas.TabIndex = 2;
            // 
            // idVenda
            // 
            this.idVenda.HeaderText = "ID Venda";
            this.idVenda.Name = "idVenda";
            this.idVenda.ReadOnly = true;
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "Nome Cliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            // 
            // idDataVenda
            // 
            this.idDataVenda.HeaderText = "Data Venda";
            this.idDataVenda.Name = "idDataVenda";
            this.idDataVenda.ReadOnly = true;
            // 
            // idValorTotal
            // 
            this.idValorTotal.HeaderText = "Valor Total";
            this.idValorTotal.Name = "idValorTotal";
            this.idValorTotal.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Período Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Período Final:";
            // 
            // txtIdVenda
            // 
            this.txtIdVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdVenda.Location = new System.Drawing.Point(535, 110);
            this.txtIdVenda.Name = "txtIdVenda";
            this.txtIdVenda.Size = new System.Drawing.Size(54, 20);
            this.txtIdVenda.TabIndex = 4;
            this.txtIdVenda.TextChanged += new System.EventHandler(this.txtIdVenda_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Digite o ID da Venda";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Location = new System.Drawing.Point(508, 149);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(110, 21);
            this.btnCancelarVenda.TabIndex = 5;
            this.btnCancelarVenda.Text = "Cancelar Venda";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            this.btnCancelarVenda.Click += new System.EventHandler(this.btnCancelarVenda_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(356, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // CancelarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 446);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCancelarVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCancelarVendas);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.dtpInicio);
            this.Name = "CancelarVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Venda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelarVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DataGridView dgvCancelarVendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn idValorTotal;
    }
}