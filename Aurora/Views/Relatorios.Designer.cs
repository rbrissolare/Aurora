namespace Aurora
{
    partial class Relatorios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.cboxCategorias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dvgRelatorio = new System.Windows.Forms.DataGridView();
            this.idprodutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvendas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qnt_vendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_liquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_bruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(12, 12);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(81, 20);
            this.dtpInicio.TabIndex = 0;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // dtpFim
            // 
            this.dtpFim.CustomFormat = "dd/MM/yyyy";
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFim.Location = new System.Drawing.Point(109, 12);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(81, 20);
            this.dtpFim.TabIndex = 1;
            this.dtpFim.ValueChanged += new System.EventHandler(this.dtpFim_ValueChanged);
            // 
            // cboxCategorias
            // 
            this.cboxCategorias.BackColor = System.Drawing.SystemColors.Window;
            this.cboxCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategorias.FormattingEnabled = true;
            this.cboxCategorias.Items.AddRange(new object[] {
            "Todas"});
            this.cboxCategorias.Location = new System.Drawing.Point(207, 12);
            this.cboxCategorias.Name = "cboxCategorias";
            this.cboxCategorias.Size = new System.Drawing.Size(166, 21);
            this.cboxCategorias.Sorted = true;
            this.cboxCategorias.TabIndex = 2;
            this.cboxCategorias.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cboxCategorias.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.cboxCategorias_ControlRemoved);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "categoria";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(384, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(93, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dvgRelatorio
            // 
            this.dvgRelatorio.AllowUserToAddRows = false;
            this.dvgRelatorio.AllowUserToDeleteRows = false;
            this.dvgRelatorio.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgRelatorio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgRelatorio.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dvgRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgRelatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodutos,
            this.idvendas,
            this.nome,
            this.valor_compra,
            this.valor_venda,
            this.quantidade,
            this.categoriaProd,
            this.dataVenda,
            this.margem,
            this.qnt_vendida,
            this.total_liquido,
            this.total_bruto});
            this.dvgRelatorio.Location = new System.Drawing.Point(19, 64);
            this.dvgRelatorio.Name = "dvgRelatorio";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgRelatorio.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgRelatorio.Size = new System.Drawing.Size(1244, 332);
            this.dvgRelatorio.TabIndex = 5;
            // 
            // idprodutos
            // 
            this.idprodutos.HeaderText = "idProduto";
            this.idprodutos.Name = "idprodutos";
            // 
            // idvendas
            // 
            this.idvendas.HeaderText = "idVenda";
            this.idvendas.Name = "idvendas";
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome Produto";
            this.nome.Name = "nome";
            // 
            // valor_compra
            // 
            this.valor_compra.HeaderText = "Valor Compra";
            this.valor_compra.Name = "valor_compra";
            // 
            // valor_venda
            // 
            this.valor_venda.HeaderText = "Valor Venda";
            this.valor_venda.Name = "valor_venda";
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade em Estoque";
            this.quantidade.Name = "quantidade";
            // 
            // categoriaProd
            // 
            this.categoriaProd.HeaderText = "Categoria";
            this.categoriaProd.Name = "categoriaProd";
            // 
            // dataVenda
            // 
            this.dataVenda.HeaderText = "Data";
            this.dataVenda.Name = "dataVenda";
            // 
            // margem
            // 
            this.margem.HeaderText = "Lucro (%)";
            this.margem.Name = "margem";
            // 
            // qnt_vendida
            // 
            this.qnt_vendida.HeaderText = "Qnt. Vendida";
            this.qnt_vendida.Name = "qnt_vendida";
            // 
            // total_liquido
            // 
            this.total_liquido.HeaderText = "Total Líquido (R$)";
            this.total_liquido.Name = "total_liquido";
            // 
            // total_bruto
            // 
            this.total_bruto.HeaderText = "Total Bruto (R$)";
            this.total_bruto.Name = "total_bruto";
            // 
            // Relatorios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1271, 401);
            this.Controls.Add(this.dvgRelatorio);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxCategorias);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.dtpInicio);
            this.Name = "Relatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.Relatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgRelatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.ComboBox cboxCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dvgRelatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn margem;
        private System.Windows.Forms.DataGridViewTextBoxColumn qnt_vendida;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_liquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_bruto;
    }
}