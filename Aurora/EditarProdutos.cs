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
    public partial class EditarProdutos : Form
    {
        private string connectionBancoDeDados = "Server=localhost;Database=auroravendasdb;Uid=root;Pwd=adming;";
        public EditarProdutos()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string buscadoraProduto = txtPesquisarProduto.Text.Trim();

            string buscarProdutoBanco = "SELECT * FROM produtos where idprodutos = @idprodutos";

            using (MySqlConnection connectionBancoDB = new MySqlConnection(connectionBancoDeDados))
            {
                try
                {
                    connectionBancoDB.Open();

                    using(MySqlCommand buscador = new MySqlCommand(buscarProdutoBanco, connectionBancoDB)) 
                    {
                        buscador.Parameters.AddWithValue("@idprodutos", buscadoraProduto);

                        using(MySqlDataReader leitor = buscador.ExecuteReader()) 
                        {
                            if (leitor.Read())
                            {
                                txtCodigoProduto.Text = leitor["idprodutos"].ToString();
                                txtNomeProduto.Text = leitor["nome"].ToString();
                                txtValorCusto.Text = leitor["valor_compra"].ToString();
                                txtValorVenda.Text = leitor["valor_venda"].ToString();
                                txtQuantidade.Text = leitor["quantidade"].ToString();
                                txtCategoria.Text = leitor["categoria"].ToString();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Criei as Strings e estou recuperando os valores digitado pelo usuário, estou tratando também os espaços em branco.
            string cadastroCodigo = txtCodigoProduto.Text.Trim();
            string cadastroNomeProduto = txtNomeProduto.Text.Trim();
            decimal cadastroValorCusto = txtValorCusto.Value;
            decimal cadastroValorVenda = txtValorVenda.Value;
            string cadastroQuantidade = txtQuantidade.Text.Trim();
            string cadastroCategoria = txtCategoria.Text.Trim();

            // Proximo passo vamos montar o comando SQL para realizar o INSERT no DB.
            string atualizaProduto = @"
        UPDATE produtos 
        SET nome = @nomeProduto,
            valor_compra = @valorCompra,
            valor_venda = @valorVenda,
            quantidade = @quantidade,
            categoria = @categoria
        WHERE idprodutos = @idprodutos;
    ";

            // Vamos criar o construtor e em seguida abrir a conexão com o Banco de Dados utilizando o USING.

            using (MySqlConnection connectionAberta = new MySqlConnection(connectionBancoDeDados))
            {
                try
                {
                    connectionAberta.Open(); // Abrimos a Conexão

                    using (MySqlCommand inserirCmd = new MySqlCommand(atualizaProduto, connectionAberta))
                    {
                        inserirCmd.Parameters.AddWithValue("@idprodutos", cadastroCodigo);                
                        inserirCmd.Parameters.AddWithValue("@nomeProduto", cadastroNomeProduto);
                        inserirCmd.Parameters.AddWithValue("@valorCompra", cadastroValorCusto);
                        inserirCmd.Parameters.AddWithValue("@valorVenda", cadastroValorVenda);
                        inserirCmd.Parameters.AddWithValue("@quantidade", cadastroQuantidade);
                        inserirCmd.Parameters.AddWithValue("@categoria", cadastroCategoria);


                        //Executa o Comando
                        int rowsAffected = inserirCmd.ExecuteNonQuery();

                        //Agora vamos verificar se houve a inclusão do Produto no Banco de Dados:

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"O Produto: {cadastroNomeProduto} foi atualizado com Sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Erro ao atualizar o Produto, verifique os campos digitados.");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível adicionar o Produto." + ex.Message, "Critical!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
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


