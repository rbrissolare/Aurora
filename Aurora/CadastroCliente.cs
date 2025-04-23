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
    public partial class CadastroCliente : Form
    {
        // AQUI: Declare a string de conexão como campo da classe
        private string connectionString = "Server=localhost;Database=auroravendasdb;Uid=root;Pwd=w2e5d4cc;";
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             // 1. Coletar os valores das textboxes
            string nome = txtNome.Text.Trim();
            string cpf = txtCpf.Text.Trim().Replace(".", "").Replace("-", "").Replace(",", "");   // se estiver mascarado
            string telefone = txtTelefone.Text.Trim().Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            string endereco = txtEndereco.Text.Trim();
            string cep = txtCep.Text.Trim().Replace("-", "");
            string cidade = txtCidade.Text.Trim();
            string estado = txtEstado.Text.Trim().ToUpper();  // Caso queira padronizar UF em maiúsculo
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

            // 2. Montar o comando SQL de INSERT com parâmetros
            string sql = @"
        INSERT INTO clientes 
        (nome, cpf, telefone, endereco, cep, cidade, estado, profissao, renda) 
        VALUES 
        (@nome, @cpf, @telefone, @endereco, @cep, @cidade, @estado, @profissao, @renda);
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
                    // O using já cuida de fechar a conexão, mas você pode
                    // colocar código adicional aqui se precisar.
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

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
