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
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnIniciarVenda = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.btnEditarPrdutos = new System.Windows.Forms.Button();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(169, 12);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(114, 35);
            this.btnCadastrarCliente.TabIndex = 2;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente (F3)";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnIniciarVenda
            // 
            this.btnIniciarVenda.Location = new System.Drawing.Point(15, 12);
            this.btnIniciarVenda.Name = "btnIniciarVenda";
            this.btnIniciarVenda.Size = new System.Drawing.Size(114, 35);
            this.btnIniciarVenda.TabIndex = 3;
            this.btnIniciarVenda.Text = "Iniciar Venda (F1)";
            this.btnIniciarVenda.UseVisualStyleBackColor = true;
            this.btnIniciarVenda.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(169, 73);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(114, 35);
            this.btnEditarCliente.TabIndex = 4;
            this.btnEditarCliente.Text = "Editar Cliente (F4)";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Location = new System.Drawing.Point(329, 12);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(114, 35);
            this.btnCadastrarProduto.TabIndex = 5;
            this.btnCadastrarProduto.Text = "Cadastrar Produto (F5)";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // btnEditarPrdutos
            // 
            this.btnEditarPrdutos.Location = new System.Drawing.Point(329, 73);
            this.btnEditarPrdutos.Name = "btnEditarPrdutos";
            this.btnEditarPrdutos.Size = new System.Drawing.Size(114, 35);
            this.btnEditarPrdutos.TabIndex = 6;
            this.btnEditarPrdutos.Text = "Editar Produtos (F6)";
            this.btnEditarPrdutos.UseVisualStyleBackColor = true;
            this.btnEditarPrdutos.Click += new System.EventHandler(this.btnEditarPrdutos_Click);
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Location = new System.Drawing.Point(15, 73);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(114, 35);
            this.btnCancelarVenda.TabIndex = 7;
            this.btnCancelarVenda.Text = "Cancelar Vendas (F2)";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            this.btnCancelarVenda.Click += new System.EventHandler(this.btnCancelarVenda_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Relatorios (F7)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AuroraVendas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Aurora.Properties.Resources.backgroundTelaLogin;
            this.ClientSize = new System.Drawing.Size(494, 196);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelarVenda);
            this.Controls.Add(this.btnEditarPrdutos);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnIniciarVenda);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Name = "AuroraVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aurora Vendas";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.AuroraVendas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AuroraVendas_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnIniciarVenda;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnEditarPrdutos;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Button button1;
    }
}