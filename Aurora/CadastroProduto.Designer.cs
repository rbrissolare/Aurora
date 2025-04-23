namespace Aurora
{
    partial class CadastroProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtValorCusto = new System.Windows.Forms.NumericUpDown();
            this.txtValorVenda = new System.Windows.Forms.NumericUpDown();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Custo (R$):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor Venda (R$): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cadasto de Produtos";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.AcceptsTab = true;
            this.txtNomeProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNomeProduto.Location = new System.Drawing.Point(117, 104);
            this.txtNomeProduto.MaxLength = 80;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(237, 20);
            this.txtNomeProduto.TabIndex = 2;
            // 
            // txtValorCusto
            // 
            this.txtValorCusto.DecimalPlaces = 2;
            this.txtValorCusto.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtValorCusto.Location = new System.Drawing.Point(111, 144);
            this.txtValorCusto.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.txtValorCusto.Name = "txtValorCusto";
            this.txtValorCusto.Size = new System.Drawing.Size(243, 20);
            this.txtValorCusto.TabIndex = 3;
            this.txtValorCusto.ThousandsSeparator = true;
            this.txtValorCusto.ValueChanged += new System.EventHandler(this.txtValorCusto_ValueChanged);
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.DecimalPlaces = 2;
            this.txtValorVenda.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtValorVenda.Location = new System.Drawing.Point(111, 189);
            this.txtValorVenda.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(243, 20);
            this.txtValorVenda.TabIndex = 4;
            this.txtValorVenda.ThousandsSeparator = true;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtQuantidade.Location = new System.Drawing.Point(86, 231);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(268, 20);
            this.txtQuantidade.TabIndex = 5;
            this.txtQuantidade.Tag = "";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(442, 103);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(114, 35);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(477, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sair";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCodigoProduto.InterceptArrowKeys = false;
            this.txtCodigoProduto.Location = new System.Drawing.Point(71, 68);
            this.txtCodigoProduto.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(283, 20);
            this.txtCodigoProduto.TabIndex = 1;
            this.txtCodigoProduto.ValueChanged += new System.EventHandler(this.txtCodigoProduto_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Categoria:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(85, 271);
            this.txtCategoria.MaxLength = 45;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(269, 20);
            this.txtCategoria.TabIndex = 6;
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodigoProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.txtValorCusto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroProduto";
            this.Text = "Cadastro de Produto";
            ((System.ComponentModel.ISupportInitialize)(this.txtValorCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.NumericUpDown txtValorCusto;
        private System.Windows.Forms.NumericUpDown txtValorVenda;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtCodigoProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCategoria;
    }
}