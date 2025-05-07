namespace Aurora
{
    partial class PDV
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
            this.txtBuscadorCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblDadosCliente = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProfissao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPesquisarProduto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValorVenda = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTotalGeral = new System.Windows.Forms.Label();
            this.qntEstoque = new System.Windows.Forms.NumericUpDown();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmdProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctgProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendaProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acao = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.txtCategoriaProduto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qntEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar Cliente:";
            // 
            // txtBuscadorCpf
            // 
            this.txtBuscadorCpf.Location = new System.Drawing.Point(109, 24);
            this.txtBuscadorCpf.Mask = "000.000.000-00";
            this.txtBuscadorCpf.Name = "txtBuscadorCpf";
            this.txtBuscadorCpf.Size = new System.Drawing.Size(89, 20);
            this.txtBuscadorCpf.TabIndex = 1;
            this.txtBuscadorCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscadorCpf_KeyPress);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(204, 22);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(85, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar (F1)";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblDadosCliente
            // 
            this.lblDadosCliente.AutoSize = true;
            this.lblDadosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosCliente.Location = new System.Drawing.Point(86, 63);
            this.lblDadosCliente.Name = "lblDadosCliente";
            this.lblDadosCliente.Size = new System.Drawing.Size(160, 25);
            this.lblDadosCliente.TabIndex = 34;
            this.lblDadosCliente.Text = "Dados Cliente";
            this.lblDadosCliente.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(58, 100);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(232, 20);
            this.txtNome.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nome:";
            // 
            // txtCpf
            // 
            this.txtCpf.Enabled = false;
            this.txtCpf.Location = new System.Drawing.Point(58, 131);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(232, 20);
            this.txtCpf.TabIndex = 37;
            this.txtCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCpf_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "CPF:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(57, 159);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(232, 20);
            this.txtTelefone.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Telefone:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(58, 192);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(232, 20);
            this.txtEndereco.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Endereço:";
            // 
            // txtCep
            // 
            this.txtCep.Enabled = false;
            this.txtCep.Location = new System.Drawing.Point(58, 223);
            this.txtCep.Mask = "00000-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(232, 20);
            this.txtCep.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "CEP:";
            // 
            // txtCidade
            // 
            this.txtCidade.AcceptsTab = true;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(58, 256);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ShortcutsEnabled = false;
            this.txtCidade.Size = new System.Drawing.Size(232, 20);
            this.txtCidade.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Cidade:";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(57, 292);
            this.txtEstado.Mask = "AA";
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(232, 20);
            this.txtEstado.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Estado:";
            // 
            // txtProfissao
            // 
            this.txtProfissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtProfissao.Enabled = false;
            this.txtProfissao.Location = new System.Drawing.Point(58, 327);
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.Size = new System.Drawing.Size(232, 20);
            this.txtProfissao.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Profissão:";
            // 
            // txtPesquisarProduto
            // 
            this.txtPesquisarProduto.Location = new System.Drawing.Point(508, 43);
            this.txtPesquisarProduto.Name = "txtPesquisarProduto";
            this.txtPesquisarProduto.Size = new System.Drawing.Size(150, 20);
            this.txtPesquisarProduto.TabIndex = 53;
            this.txtPesquisarProduto.TextChanged += new System.EventHandler(this.txtPesquisarProduto_TextChanged);
            this.txtPesquisarProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisarProduto_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(449, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Pesquisa:";
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Location = new System.Drawing.Point(664, 41);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(92, 23);
            this.btnPesquisarProduto.TabIndex = 54;
            this.btnPesquisarProduto.Text = "Pesquisar (F2)";
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click_1);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNomeProduto.Enabled = false;
            this.txtNomeProduto.Location = new System.Drawing.Point(515, 96);
            this.txtNomeProduto.MaxLength = 80;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(243, 20);
            this.txtNomeProduto.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Nome do Produto:";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(409, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Valor Venda (R$): ";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(515, 162);
            this.txtQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(243, 20);
            this.txtQuantidade.TabIndex = 60;
            this.txtQuantidade.Tag = "";
            this.txtQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantidade.ValueChanged += new System.EventHandler(this.txtQuantidade_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(422, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 59;
            this.label13.Text = "Quantidade:";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.DecimalPlaces = 2;
            this.txtValorVenda.Enabled = false;
            this.txtValorVenda.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtValorVenda.Location = new System.Drawing.Point(515, 129);
            this.txtValorVenda.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(243, 20);
            this.txtValorVenda.TabIndex = 58;
            this.txtValorVenda.ThousandsSeparator = true;
            this.txtValorVenda.ValueChanged += new System.EventHandler(this.txtValorVenda_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(453, 199);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 61;
            this.label14.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(511, 195);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(247, 20);
            this.txtTotal.TabIndex = 62;
            this.txtTotal.TextChanged += new System.EventHandler(this.TxtTotal_TextChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(528, 247);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(111, 23);
            this.btnAdicionar.TabIndex = 63;
            this.btnAdicionar.Text = "Adicionar (Insert)";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(645, 247);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 23);
            this.btnCancelar.TabIndex = 64;
            this.btnCancelar.Text = "Cancelar (Del)";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTotalGeral
            // 
            this.lblTotalGeral.AutoSize = true;
            this.lblTotalGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGeral.Location = new System.Drawing.Point(771, 607);
            this.lblTotalGeral.Name = "lblTotalGeral";
            this.lblTotalGeral.Size = new System.Drawing.Size(99, 25);
            this.lblTotalGeral.TabIndex = 66;
            this.lblTotalGeral.Text = "Total R$:";
            this.lblTotalGeral.Click += new System.EventHandler(this.label16_Click);
            // 
            // qntEstoque
            // 
            this.qntEstoque.Enabled = false;
            this.qntEstoque.Location = new System.Drawing.Point(711, 162);
            this.qntEstoque.Name = "qntEstoque";
            this.qntEstoque.Size = new System.Drawing.Size(47, 20);
            this.qntEstoque.TabIndex = 72;
            this.qntEstoque.Tag = "";
            this.qntEstoque.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qntEstoque.Visible = false;
            this.qntEstoque.ValueChanged += new System.EventHandler(this.qntEstoque_ValueChanged);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Location = new System.Drawing.Point(555, 559);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(123, 37);
            this.btnFinalizarVenda.TabIndex = 73;
            this.btnFinalizarVenda.Text = "Finalizar Venda (F12)";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            this.btnFinalizarVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnFinalizarVenda_KeyDown);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(243, 100);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(47, 20);
            this.txtIdCliente.TabIndex = 74;
            this.txtIdCliente.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProd,
            this.nmdProd,
            this.ctgProd,
            this.vendaProd,
            this.qntProd,
            this.totalProd,
            this.acao});
            this.dataGridView1.Location = new System.Drawing.Point(766, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 579);
            this.dataGridView1.TabIndex = 75;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_4);
            // 
            // idProd
            // 
            this.idProd.HeaderText = "ID";
            this.idProd.Name = "idProd";
            // 
            // nmdProd
            // 
            this.nmdProd.HeaderText = "Produto";
            this.nmdProd.Name = "nmdProd";
            // 
            // ctgProd
            // 
            this.ctgProd.HeaderText = "Categoria";
            this.ctgProd.Name = "ctgProd";
            // 
            // vendaProd
            // 
            this.vendaProd.HeaderText = "Valor Venda";
            this.vendaProd.Name = "vendaProd";
            // 
            // qntProd
            // 
            this.qntProd.HeaderText = "Qnt";
            this.qntProd.Name = "qntProd";
            // 
            // totalProd
            // 
            this.totalProd.HeaderText = "Total";
            this.totalProd.Name = "totalProd";
            // 
            // acao
            // 
            this.acao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.acao.HeaderText = "Ação";
            this.acao.Name = "acao";
            this.acao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.acao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.acao.Width = 57;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Enabled = false;
            this.txtIdProduto.Location = new System.Drawing.Point(709, 96);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(49, 20);
            this.txtIdProduto.TabIndex = 76;
            this.txtIdProduto.Visible = false;
            // 
            // txtCategoriaProduto
            // 
            this.txtCategoriaProduto.Enabled = false;
            this.txtCategoriaProduto.Location = new System.Drawing.Point(664, 96);
            this.txtCategoriaProduto.Name = "txtCategoriaProduto";
            this.txtCategoriaProduto.Size = new System.Drawing.Size(94, 20);
            this.txtCategoriaProduto.TabIndex = 77;
            this.txtCategoriaProduto.Visible = false;
            // 
            // PDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1675, 641);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.lblTotalGeral);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPesquisarProduto);
            this.Controls.Add(this.txtPesquisarProduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtProfissao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDadosCliente);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtBuscadorCpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qntEstoque);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.txtCategoriaProduto);
            this.Name = "PDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PDV_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PDV_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qntEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtBuscadorCpf;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblDadosCliente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProfissao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPesquisarProduto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown txtValorVenda;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTotalGeral;
        private System.Windows.Forms.NumericUpDown qntEstoque;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.TextBox txtCategoriaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmdProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctgProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendaProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalProd;
        private System.Windows.Forms.DataGridViewButtonColumn acao;
    }
}