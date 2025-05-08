using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aurora
{
    public partial class CadastroProduto : Form
    {
        private string connectionBancoDeDados = "Server=localhost;Database=auroravendasdb;Uid=root;Pwd=admin;";
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void txtCodigoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorCusto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigoProduto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            

            
            // Criei as Strings e estou recuperando os valores digitado pelo usuário, estou tratando também os espaços em branco.
            string cadastroCodigo = txtCodigoProduto.Text.Trim();
            string cadastroNomeProduto = txtNomeProduto.Text.Trim();
            decimal cadastroValorCusto = txtValorCusto.Value;
            decimal cadastroValorVenda = txtValorVenda.Value;
            string cadastroQuantidade = txtQuantidade.Text.Trim();
            string cadastroCategoria = txtCategoria.Text.Trim();


            if (string.IsNullOrEmpty(cadastroNomeProduto))
            {
                MessageBox.Show("Cadastre um Produto");
                return;
            }

            if (cadastroValorCusto <= 0)
            {
                MessageBox.Show("Cadastre um valor de custo maior que R$ 0,00");
                return;
            }

            if (cadastroValorVenda <= 0)
            {
                MessageBox.Show("Cadastre um valor de venda maior que R$ 0,00");
                return;
            }

            if (string.IsNullOrEmpty(cadastroQuantidade))
            {
                MessageBox.Show("Cadastre a quantidade maior 0");
                return;
            }

            if (string.IsNullOrEmpty(cadastroCategoria))
            {
                MessageBox.Show("Cadastre uma categoria");
                return;
            }


            // Proximo passo vamos montar o comando SQL para realizar o INSERT no DB.
            string inserirProduto = @"INSERT INTO produtos (idprodutos, nome, valor_compra, valor_venda, quantidade, categoria) VALUES (@idProduto, @nomeProduto, @valorCusto, @valorVenda, @quantidade, @categoria);";

            // Vamos criar o construtor e em seguida abrir a conexão com o Banco de Dados utilizando o USING.

            using (MySqlConnection connectionAberta = new MySqlConnection(connectionBancoDeDados))
            {
                try 
                {
                    connectionAberta.Open(); // Abrimos a Conexão

                    using (MySqlCommand inserirCmd = new MySqlCommand(inserirProduto, connectionAberta)) 
                    {
                        inserirCmd.Parameters.AddWithValue("@idProduto", cadastroCodigo);
                        inserirCmd.Parameters.AddWithValue("@nomeProduto", cadastroNomeProduto);
                        inserirCmd.Parameters.AddWithValue("@valorCusto", cadastroValorCusto);
                        inserirCmd.Parameters.AddWithValue("@valorVenda", cadastroValorVenda);
                        inserirCmd.Parameters.AddWithValue("@quantidade", cadastroQuantidade);
                        inserirCmd.Parameters.AddWithValue("@categoria", cadastroCategoria);


                        //Executa o Comando
                        int rowsAffected = inserirCmd.ExecuteNonQuery();

                        //Agora vamos verificar se houve a inclusão do Produto no Banco de Dados:

                        if (rowsAffected > 0) 
                        {
                            MessageBox.Show($"O Produto: {cadastroNomeProduto} foi adicionado com Sucesso");
                        }
                        else 
                        {
                            MessageBox.Show("Erro ao adicionar o Produto, verifique os campos digitados.");
                        }
                    }
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível adicionar o Produto." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                {
                    txtCodigoProduto.Value = 0;
                    txtNomeProduto.Clear();
                    txtValorCusto.Value = 0;
                    txtValorVenda.Value = 0;
                    txtQuantidade.Value = 0;
                    txtCategoria.Clear();
                }
            
            }

        }
    }
}
