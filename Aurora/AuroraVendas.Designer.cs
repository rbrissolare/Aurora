namespace Aurora
{
    partial class AuroraVendas
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblUsuarioSistema = new System.Windows.Forms.Label();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnIniciarVenda = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.btnEditarPrdutos = new System.Windows.Forms.Button();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CausesValidation = false;
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.No;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy H:m";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(800, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblUsuarioSistema
            // 
            this.lblUsuarioSistema.AutoSize = true;
            this.lblUsuarioSistema.Location = new System.Drawing.Point(1499, 12);
            this.lblUsuarioSistema.Name = "lblUsuarioSistema";
            this.lblUsuarioSistema.Size = new System.Drawing.Size(73, 13);
            this.lblUsuarioSistema.TabIndex = 1;
            this.lblUsuarioSistema.Text = "nome_usuario";
            this.lblUsuarioSistema.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(169, 45);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(114, 35);
            this.btnCadastrarCliente.TabIndex = 2;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente (F3)";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnIniciarVenda
            // 
            this.btnIniciarVenda.Location = new System.Drawing.Point(15, 45);
            this.btnIniciarVenda.Name = "btnIniciarVenda";
            this.btnIniciarVenda.Size = new System.Drawing.Size(114, 35);
            this.btnIniciarVenda.TabIndex = 3;
            this.btnIniciarVenda.Text = "Iniciar Venda (F1)";
            this.btnIniciarVenda.UseVisualStyleBackColor = true;
            this.btnIniciarVenda.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(169, 105);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(114, 35);
            this.btnEditarCliente.TabIndex = 4;
            this.btnEditarCliente.Text = "Editar Cliente (F4)";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Location = new System.Drawing.Point(329, 45);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(114, 35);
            this.btnCadastrarProduto.TabIndex = 5;
            this.btnCadastrarProduto.Text = "Cadastrar Produto (F5)";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // btnEditarPrdutos
            // 
            this.btnEditarPrdutos.Location = new System.Drawing.Point(329, 105);
            this.btnEditarPrdutos.Name = "btnEditarPrdutos";
            this.btnEditarPrdutos.Size = new System.Drawing.Size(114, 35);
            this.btnEditarPrdutos.TabIndex = 6;
            this.btnEditarPrdutos.Text = "Editar Produtos (F6)";
            this.btnEditarPrdutos.UseVisualStyleBackColor = true;
            this.btnEditarPrdutos.Click += new System.EventHandler(this.btnEditarPrdutos_Click);
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Location = new System.Drawing.Point(15, 105);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(114, 35);
            this.btnCancelarVenda.TabIndex = 7;
            this.btnCancelarVenda.Text = "Cancelar Vendas (F2)";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            this.btnCancelarVenda.Click += new System.EventHandler(this.btnCancelarVenda_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Relatorios (F7)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(802, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // AuroraVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelarVenda);
            this.Controls.Add(this.btnEditarPrdutos);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnIniciarVenda);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.lblUsuarioSistema);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "AuroraVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aurora Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AuroraVendas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AuroraVendas_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblUsuarioSistema;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnIniciarVenda;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnEditarPrdutos;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}