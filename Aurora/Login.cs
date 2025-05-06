using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aurora
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            Conexao conexao = new Conexao(); // Trago a Classe Conexao do ConexaoDB.cs, em seguida criei uma variavel local chamada conexao, crio uma instancia new com a Classe Conexao do ConexaoDB.cs

            if (!conexao.TestarConexao()) // Utilizei a Negação ! para inverter o valor BOOL retornado pelo metodo TestarConexao(). Se TestarConexao() retornar true, o operador ! converte em false e o bloco If não é executado, permitindo que o código continue.
            {
                return; // Por outro lado, se o metodo TestarConexao() retornar False a negação ! converte em true, e então o bloco If é executado, interrompendo a execução com o return.
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Application.Exit();  
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

     
        private void button1_Click(object sender, EventArgs e)
        {
           
            // Vou criar as variaveis locais para armazenar o que os usuarios digitaram, em seguida vou remover os espaços em brancos usando o Trim().
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();
            string query = "SELECT COUNT(*) FROM usuarios WHERE login = @login AND senha = @senha;";


            // Agora vou novamente testar a conexão com o banco de dados.

            Conexao conexaoBD = new Conexao();

            if (!conexaoBD.TestarConexao()) 
            {
                return;
            }

            // Depois que a Conexão foi testada e aprovada pelo IF, seguimos... neste momento precisamos definir a consulta SQL.

            // Vou criar uma string chamada QUERY que irá selecionar a tabela usuarios na coluna LOGIN E SENHA.

            

            // A partir daqui, podemos abrir a conexão com o Banco de Dados, utilizando o Try para tratar possíveis exceções.

            try
            {
                conexaoBD.conexao.Open(); // Aqui já abrimos a conexão com o Banco de Dados.

                // Após abrir a conexão com o DB, precisamos criar um comando para preparar a execução da consulta SQL com os parametros que serão definidos a seguir:

                using (MySqlCommand cmd = new MySqlCommand(query, conexaoBD.conexao))
                {
                    cmd.Parameters.AddWithValue("@login", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    //  Com o comando preparado para execução, precisamos executar a Consulta SQL e Obter o RESULTADO

                    int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                
                // Esse metodo acima irá converter e retornar o primeiro valor da primeira coluna do conjunto de resultados.

                // Agora vamos iniciar a verificação de resultados:

                    if (resultado > 0)
                    {
                        //MessageBox.Show("Login efetuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Agora vamos adicionar abertura do Sistema após a mensagem de Login:

                       
                        new AuroraVendas().Show(); //Abre a Tela principal do Sistema.
                        this.Hide(); //Esconde a Tela de Login.
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }

            //Capturar qualquer exceção que ocorrer durante a execução do bloco Try.

            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao tentar efetuar o login:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Este bloco é executado independente de ter ocorrido ou não uma exceção, para que possamos finalizar a conexão com DB.

            finally
            {
                if (conexaoBD.conexao.State == System.Data.ConnectionState.Open) 
                {
                    conexaoBD.conexao.Close();
                }
            
            }
     
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // uma das formas de usar não é a mais adequada
            {
                button1_Click(sender, e);
            }
        }
    }
}