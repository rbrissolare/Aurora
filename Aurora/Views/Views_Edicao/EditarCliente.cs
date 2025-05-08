using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace Aurora
{
    public partial class EditarCliente : Form
    {
        private string connectionString = "Server=localhost;Database=auroravendasdb;Uid=root;Pwd=admin;";
        public EditarCliente()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Suponha que txtBuscaCPF é um TextBox onde o usuário informa o CPF para buscar
            string cpfBusca = txtBuscaCPF.Text.Trim().Replace(".", "").Replace("-", "").Replace(",", "");
            txtBuscaCPF.Clear();

            // Query para buscar o cliente pelo CPF
            string query = "SELECT * FROM clientes WHERE cpf = @cpf;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cpf", cpfBusca);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                                     
                                txtNome.Text = reader["nome"].ToString();
                                txtCpf.Text = reader["cpf"].ToString();
                                txtTelefone.Text = reader["telefone"].ToString();
                                txtEndereco.Text = reader["endereco"].ToString();
                                txtCep.Text = reader["cep"].ToString();
                                txtCidade.Text = reader["cidade"].ToString();
                                txtEstado.Text = reader["estado"].ToString();
                                txtProfissao.Text = reader["profissao"].ToString();
                                txtRenda.Text = reader["renda"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Nenhum cliente encontrado com o CPF informado.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar cliente: " + ex.Message);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // 1. Coletar os valores das textboxes
            string nome = txtNome.Text.Trim();
            string cpf = txtCpf.Text.Trim().Replace(".", "").Replace("-", "").Replace(",", "");
            string telefone = txtTelefone.Text.Trim().Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            string endereco = txtEndereco.Text.Trim();
            string cep = txtCep.Text.Trim().Replace("-", "");
            string cidade = txtCidade.Text.Trim();
            string estado = txtEstado.Text.Trim().ToUpper();
            string profissao = txtProfissao.Text.Trim();

            // Aqui, como é valor monetário, convertemos a string para decimal.
            // É importante capturar exceções de conversão, caso o usuário digite algo inválido.
            decimal renda;
            if (!decimal.TryParse(txtRenda.Text.Replace(",", "."),
                                  System.Globalization.NumberStyles.Any,
                                  System.Globalization.CultureInfo.InvariantCulture,
            out renda))

            {
                MessageBox.Show("Valor de renda inválido. Verifique o campo antes de salvar.");
                return; // Cancela a operação se a renda não for válida
            }

            // 2. Montar o comando SQL de UPDATE com parâmetros
            string sql = @"
        UPDATE clientes 
        SET nome = @nome,
            cpf = @cpf,
            telefone = @telefone,
            endereco = @endereco,
            cep = @cep,
            cidade = @cidade,
            estado = @estado,
            profissao = @profissao,
            renda = @renda
        WHERE cpf = @cpf;
    ";

            // 3. Abrir a conexão com o banco de dados
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // Abre a conexão

                    // 4. Criar o comando e associar parâmetros
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@cpf", cpf);
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@endereco", endereco);
                        cmd.Parameters.AddWithValue("@cep", cep);
                        cmd.Parameters.AddWithValue("@cidade", cidade);
                        cmd.Parameters.AddWithValue("@estado", estado);
                        cmd.Parameters.AddWithValue("@profissao", profissao);
                        cmd.Parameters.AddWithValue("@renda", renda);

                        // 5. Executar o comando
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Se rowsAffected > 0, significa que ao menos um registro foi inserido.
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cliente salvo com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma linha foi inserida. Verifique o comando SQL.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 6. Tratar exceções
                    MessageBox.Show("Erro ao salvar cliente: " + ex.Message);
                }
                finally
                {
                    // O using já cuida de fechar a conexão.
                    
                    txtNome.Clear();
                    txtCpf.Clear();
                    txtTelefone.Clear();
                    txtEndereco.Clear();
                    txtCep.Clear();
                    txtCidade.Clear();
                    txtEstado.Clear();
                    txtProfissao.Clear();
                    txtRenda.Clear();



                }
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRenda_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        
        }

        private void txtBuscaCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}