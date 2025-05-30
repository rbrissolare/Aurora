﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Win32.SafeHandles;
using MySql.Data.MySqlClient;


namespace Aurora
{
    public partial class PDV : Form
    {
        private string connectionBancoDeDadosCredenciais = "Server=localhost;Database=auroravendasdb;Uid=root;Pwd=admin;";


        public PDV()
        {
            InitializeComponent();
            this.KeyPreview = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string buscarCpf = txtBuscadorCpf.Text.Trim().Replace(",", "").Replace("-", "");

            string buscarClientePorCpf = "SELECT * FROM clientes where cpf = @cpf;";

            using (MySqlConnection conexaoAbrirBanco = new MySqlConnection(connectionBancoDeDadosCredenciais))
            {
                try
                {
                    conexaoAbrirBanco.Open();
                    using (MySqlCommand lerDadosCliente = new MySqlCommand(buscarClientePorCpf, conexaoAbrirBanco))
                    {
                        lerDadosCliente.Parameters.AddWithValue("@cpf", buscarCpf);

                        using (MySqlDataReader lendoDadosClientes = lerDadosCliente.ExecuteReader())
                        {
                            if (lendoDadosClientes.Read())
                            {
                                txtIdCliente.Text = lendoDadosClientes["idclientes"].ToString();
                                txtNome.Text = lendoDadosClientes["nome"].ToString();
                                txtCpf.Text = lendoDadosClientes["cpf"].ToString();
                                txtTelefone.Text = lendoDadosClientes["telefone"].ToString();
                                txtEndereco.Text = lendoDadosClientes["endereco"].ToString();
                                txtCep.Text = lendoDadosClientes["cep"].ToString();
                                txtCidade.Text = lendoDadosClientes["cidade"].ToString();
                                txtEstado.Text = lendoDadosClientes["estado"].ToString();
                                txtProfissao.Text = lendoDadosClientes["profissao"].ToString();
                            }
                            else
                            {
                               DialogResult resultadoPesquisaCliente = MessageBox.Show($"Nenhum cliente cadastrado com esse CPF: {txtBuscadorCpf.Text.Replace(",", ".").Replace(" ","").Trim()}. Deseja Cadastrar?", "Cliente não localizado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                switch (resultadoPesquisaCliente)
                                {
                                    case DialogResult.Yes:
                                        new CadastroCliente().Show();
                                        break;

                                    case DialogResult.No:
                                        MessageBox.Show("Digite o CPF novamente para realizar uma nova busca.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtBuscadorCpf.Clear();
                                        txtBuscadorCpf.Focus();
                                        return;
                                }
                            }




                        }


                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarProduto_Click_1(object sender, EventArgs e)
        {
            string buscadoraProduto = txtPesquisarProduto.Text.Trim();

            int idProduto;

            bool isNumerico = int.TryParse(buscadoraProduto, out idProduto);

            string buscarProdutoBanco;

            //string buscarProdutoBanco = "SELECT * FROM produtos where idprodutos = @idprodutos OR nome LIKE @nome;";

            if (isNumerico)
            {
                buscarProdutoBanco = "SELECT * FROM produtos where idprodutos = @idprodutos;";
            }
            else
            {
                buscarProdutoBanco = "SELECT * FROM produtos where nome LIKE @nome;";
            }



                using (MySqlConnection connectionBancoDB = new MySqlConnection(connectionBancoDeDadosCredenciais))
                {
                    try
                    {
                        connectionBancoDB.Open();

                        using (MySqlCommand buscador = new MySqlCommand(buscarProdutoBanco, connectionBancoDB))
                        {
                            if (isNumerico)
                        {
                            buscador.Parameters.AddWithValue("@idprodutos", buscadoraProduto);
                        }
                        else
                        {
                            buscador.Parameters.AddWithValue("@nome", "%" + buscadoraProduto + "%");
                        }

                            using (MySqlDataReader leitor = buscador.ExecuteReader())
                            {
                                if (leitor.Read())
                                {
                                    txtIdProduto.Text = leitor["idprodutos"].ToString();
                                    txtNomeProduto.Text = leitor["nome"].ToString();
                                    qntEstoque.Text = leitor["quantidade"].ToString();
                                    txtValorVenda.Text = leitor["valor_venda"].ToString();
                                    txtCategoriaProduto.Text = leitor["categoria"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show($"Nenhum Produto Encontrado com o ID: {buscadoraProduto} fornecido.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error ao Capturar os Dados do Produto" + ex.Message, "Critical!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        txtPesquisarProduto.Clear();
                    }
                }

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataSet1_Initialized(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {


        }

        private void CalcularTotal()
        {
            decimal soma = txtQuantidade.Value * txtValorVenda.Value;
            txtTotal.Text = soma.ToString("N2");

        }

        //private void CalcularEstoque()
        //{
        //    if (txtQuantidade.Value > qntEstoque.Value)
        //    {
        //        MessageBox.Show("Estoque Insuficiente!", "Erro Crítico!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        txtQuantidade.Value = 0;
        //        return;
        //    }

        //}

        public void txtQuantidade_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
            //CalcularEstoque();
        }

        public void txtValorVenda_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
            //CalcularEstoque();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNomeProduto.Clear();
            txtValorVenda.Value = 0;
            txtQuantidade.Value = 1;
            txtTotal.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems_1(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Metodo para adicionar a linha sempre que adicionar um novo produto no PDV.
        //private int linhaAtual = 1; // Começa a linha do tblExibirProdutos em 1

        //Metodo para calcular valor final da compra
        private decimal totalGeral = 0;

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            
            //Criar as strings para ser os valores nos campos
            string LerIdProduto = txtIdProduto.Text.Trim();
            string lerNomeProduto = txtNomeProduto.Text.Trim();
            string lerCategoria = txtCategoriaProduto.Text.Trim();
            decimal lerValorProduto = txtValorVenda.Value;
            decimal lerQuantidade = txtQuantidade.Value;
            decimal lerValorTotal = txtValorVenda.Value * txtQuantidade.Value;

            Button btnExluirProdutos = new Button();
            btnExluirProdutos.Text = "Excluir";



            //MessageBox.Show($"Produto: {lerNomeProduto} Valor UN(R$): {lerValorProduto} qnt: {lerQuantidade} Valor total(R$): {lerValorTotal}"); // consegui adicionar a quantidade em uma mensagem... agora preciso adicionar isso no tblExibirProdutos

            //Bom, agora para reflir os valores das strings criadas acimas, precisamos USAR O METODO CONSTRUTOR para construir as Labels no tblExibirProdutos e referenciar cada label em sua devida string.

            //Label lblNomeProduto = new Label();
            //lblNomeProduto.Text = lerNomeProduto.ToString();

            //Label lblValorProduto = new Label();
            //lblValorProduto.Text = lerValorProduto.ToString();

            //Label lblQuantidade = new Label();
            //lblQuantidade.Text = lerQuantidade.ToString();

            //Label lblValorTotal = new Label();
            //lblValorTotal.Text = lerValorTotal.ToString();


            ////Agora precisamos escolhr a posição (coluna/linha) no tblExibirProdutos.
            //tblExibirProdutos.RowCount = linhaAtual + 1; // SOMA A LINHA ATUAL CRIADA FORA DA VOID EM + 1

            //tblExibirProdutos.Controls.Add(lblNomeProduto, 0, linhaAtual);
            //tblExibirProdutos.Controls.Add(lblValorProduto, 1, linhaAtual);
            //tblExibirProdutos.Controls.Add(lblQuantidade, 2, linhaAtual);
            //tblExibirProdutos.Controls.Add(lblValorTotal, 3, linhaAtual);


            if (qntEstoque.Value <= 0) 
            {
              MessageBox.Show("Estoque Insuficiente!", "Erro Crítico!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNomeProduto.Clear();
                txtValorVenda.Value = 0;
                txtQuantidade.Value = 1;
                txtTotal.Clear();
                txtPesquisarProduto.Focus();

                return;              
            } 
            else if (txtQuantidade.Value > qntEstoque.Value)
            {
                MessageBox.Show("Quantidade não disponivel para venda!", "Erro Crítico!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if(txtNomeProduto.Text == "")
            {
                MessageBox.Show("Adicione ao menos um Produto!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                dataGridView1.Rows.Add(LerIdProduto, lerNomeProduto, lerCategoria, lerValorProduto, lerQuantidade, lerValorTotal, btnExluirProdutos.Text);
            }

            //linhaAtual++; // para a proxima adição.

            totalGeral += lerValorTotal;

            lblTotalGeral.Text = $"Total R$: {totalGeral.ToString("N2")}";

        }

        private void label16_Click(object sender, EventArgs e)
        {
           
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void qntEstoque_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            long novoIdVend = 0;

            DialogResult confirmaVenda = MessageBox.Show("Deseja finalizar a venda?", "Finalizar venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (confirmaVenda)
            {
                case DialogResult.Yes:
                    //Criar as Strings para Fazer o Insert no DB
                    string connStr = connectionBancoDeDadosCredenciais;
                    string recebeIDCliente = txtIdCliente.Text.Trim();
                    string recebeIDProduto = txtIdProduto.Text.Trim();
                    string recebeCategoriaProduto = txtCategoriaProduto.Text.Trim();


                    decimal recebeValorVenda = txtValorVenda.Value;
                    decimal recebeQuantidade = txtQuantidade.Value;
                    decimal recebeTotalProdutos = totalGeral;
                    decimal recebeTotal = txtValorVenda.Value * txtQuantidade.Value;

                    if (dataGridView1.Rows.Count <= 0)
                    {
                        MessageBox.Show("Adicione ao menos um Produto!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(txtIdCliente.Text))
                    {
                        MessageBox.Show("Adicione ao menos um Cliente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    //AQUI VOU APRENDER UM METODO CHAMADO TRANSACIONAL....//

                    using (var conn = new MySqlConnection(connStr))
                    {
                        conn.Open();

                        using (var tx = conn.BeginTransaction())
                        {
                            try
                            {
                                string sqlVenda = @"INSERT INTO vendas (idclientes, data_venda, valor_total) VALUES (@idCli, @data, @total);";
                                using (var cmdVenda = new MySqlCommand(sqlVenda, conn, tx))
                                {
                                    cmdVenda.Parameters.AddWithValue("@idCli", recebeIDCliente);
                                    cmdVenda.Parameters.AddWithValue("@data", DateTime.Now);
                                    cmdVenda.Parameters.AddWithValue("@total", recebeTotalProdutos);
                                    cmdVenda.ExecuteNonQuery();

                                   long novoIdVenda = cmdVenda.LastInsertedId;
                                   novoIdVend = cmdVenda.LastInsertedId;

                                    foreach (DataGridViewRow row in dataGridView1.Rows)
                                    {
                                        if (row.IsNewRow) continue;
                                        {
                                            var idProduto = row.Cells["idProd"].Value;
                                            var idCategoria = row.Cells["ctgProd"].Value;
                                            var idValorVenda = row.Cells["vendaProd"].Value;
                                            var idQuantidade = row.Cells["qntProd"].Value;
                                            var idTotal = row.Cells["totalProd"].Value;

                                            string sqlItem = @"INSERT INTO vendas_itens (idvendas, idprodutos, quantidade, valor_unitario, valor_total, categoria)
VALUES (@idVendas, @idProdutos, @quantidade, @valorUni, @valorTotal, @categoria);";

                                            using (var cmdItem = new MySqlCommand(sqlItem, conn, tx))
                                            {
                                                cmdItem.Parameters.AddWithValue("@idVendas", novoIdVenda);
                                                cmdItem.Parameters.AddWithValue("@idProdutos", idProduto);
                                                cmdItem.Parameters.AddWithValue("@quantidade", idQuantidade);
                                                cmdItem.Parameters.AddWithValue("@valorUni", idValorVenda);
                                                cmdItem.Parameters.AddWithValue("@valorTotal", idTotal);
                                                cmdItem.Parameters.AddWithValue("@categoria", idCategoria);
                                                cmdItem.ExecuteNonQuery();
                                            }

                                            string sqlUpd = @"UPDATE produtos SET quantidade = quantidade - @qnt WHERE idprodutos = @idProd;";
                                            using (var cmdUpd = new MySqlCommand(sqlUpd, conn, tx))
                                            {
                                                cmdUpd.Parameters.AddWithValue("@qnt", idQuantidade);
                                                cmdUpd.Parameters.AddWithValue("@idProd", idProduto);
                                                cmdUpd.ExecuteNonQuery();
                                            }
                                        }
                                        
                                    }
                                }

                                tx.Commit();
                                MessageBox.Show($"Venda Efetuada com Sucesso");
                                EmitirCupom.Imprimir((int)novoIdVend);
                                this.Close();
                                new PDV().Show();
                                                           
                               
                            }
                            catch (Exception ex)
                            {
                                tx.Rollback();
                                MessageBox.Show($"Erro ao finalizar venda: {ex.Message}");
                            }

                        }

                    }
                    break;

                case DialogResult.No:
                    return;

            }  
        }
        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PDV_Load(object sender, EventArgs e)
        {

        }

        private void tblExibirProdutos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_4(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Acao"].Index)
            {
                // Obtém a linha selecionada  
                DataGridViewRow linhaSelecionada = dataGridView1.Rows[e.RowIndex];

                // Exibe mensagem de confirmação  
                DialogResult confirmacao = MessageBox.Show(
                    $"Deseja remover o produto '{linhaSelecionada.Cells["nmdProd"].Value}' da lista?",
                    "Confirmar Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacao == DialogResult.Yes)
                {
                    var removeValorTotalProduto = dataGridView1.Rows[e.RowIndex].Cells["totalProd"].Value;
                    
                    // Remove a linha selecionada  
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                    if (removeValorTotalProduto != null && decimal.TryParse(removeValorTotalProduto.ToString(), out decimal valorProduto))
                    {
                        // Subtrai o valor do produto removido do total geral
                        totalGeral -= valorProduto;
                        lblTotalGeral.Text = $"Total R$: {totalGeral.ToString("N2")}";
                    }
                    else
                    {
                        MessageBox.Show("Erro ao calcular o valor total.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void txtPesquisarProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnPesquisarProduto_Click_1(sender, e);
            }
        }

        private void txtPesquisarProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void PDV_KeyDown(object sender, KeyEventArgs e)
        {

            string armazenaAtalho = e.KeyCode.ToString();

            switch (armazenaAtalho)
            {
                case var fUm when e.KeyCode == Keys.F1:
                    txtBuscadorCpf.Focus();
                    e.Handled = true;
                    break;

                case var fDois when e.KeyCode == Keys.F2:
                    txtPesquisarProduto.Focus();
                    e.Handled = true;
                    break;

                case var spaceAdd when e.KeyCode == Keys.Insert:
                    btnAdicionar_Click(sender, e);
                    e.Handled = true;
                    break;

                case var cancelaAdd when e.KeyCode == Keys.Delete:
                    btnCancelar_Click(sender, e);
                    e.Handled = true;
                    break;

                case var fDoze when e.KeyCode == Keys.F12:
                    btnFinalizarVenda_Click(sender,e);
                    e.Handled = true;
                    break;
            }
                            
            //if (e.KeyCode == Keys.F2)
            //{
            //    txtPesquisarProduto.Focus();
            //    e.Handled = true;
                
            //}
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void txtBuscadorCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnPesquisar_Click(sender,e);
            }
        }

        private void btnFinalizarVenda_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}



