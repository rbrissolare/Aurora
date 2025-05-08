using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Adiciona para se comunicar com MySql

namespace Aurora
{
    internal class Conexao // Mudei de Class1 para Conexao, definindo o nome da Classe.
    {
        private string conexaoString = ("server=localhost;port=3306;database=auroravendasdb;uid=root;pwd=admin;"); // Criei uma variável privada chamada conexaoString, contendo as informações do DB.

        public MySqlConnection conexao; // Criei o objeto que irá representar a conexão com o Banco.

        // Metodo Construtor:

        public Conexao()
        {
            conexao = new MySqlConnection(conexaoString); // O Metodo construtor sempre irá trazer o nome da class nesse caso Conexao. | Dentro do bloco eu delcaro o objeto criado acima que usamos para representar a conexão com o banco de dados, seguido do comando padrão e por fim, declaro a variavel conexaoString dentro do (conexaoString) parâmetros.
        }

        // Metodo TestarConexao tem o Objetivo de testar se a conexão com o DB é estabelecida corretamente.
        public bool TestarConexao()
        {
            try // O Bloco TRY é usado para para colocar instruções que podem gerar exceções (erros). Durante a execução.
            {
                conexao.Open(); // Irá realizar a abertura da conexão com o Banco
                conexao.Close(); // Irá realizar o fechamento da conexão com o Banco
                return true; // Caso as operações: conexao.Open() e conexao.Close() funcionem corretamente, irá retornar True, isso significa que o teste de conexão com o Banco foi realizado com sucesso.

            }
            catch (Exception) // Entretanto se algumas das operações: conexao.Open() ou conexao.Close() falhar, o catch irá capturar a exceção (o erro) e irá tratar no bloco abaixo.
            {
                System.Windows.Forms.MessageBox.Show("Erro ao conectar com o banco de dados. Verifique sua Conexão."); // Primeiro ele irá mostrar uma mensagem ao Usuário, informando o Erro ao se conectar ao DB.
                return false; // Segundo irá retornar False, encerrando a tentativa de conexão e encerrando todo o bloco/ação do usuário. Até que ela se repita.
            }
        }

    }
}
