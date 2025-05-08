using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace Aurora
{
    public class BuscarVendasDB
    {

        public static List<Produto> BuscarItensdaVenda(int idVenda)
        {
            string conexao = "Server=localhost;Database=auroravendasdb;Uid=root;Pwd=admin;";

            List<Produto> lista = new List<Produto>();

            string sql = @"SELECT 
                            p.nome,
                            vi.quantidade,
                            vi.valor_unitario AS ValorUnitario
                        FROM vendas_itens vi
                        JOIN produtos p ON p.idprodutos = vi.idprodutos
                        WHERE vi.idvendas = @idvendas;";

            using (MySqlConnection conexaoAberta = new MySqlConnection(conexao))
            {
                try
                {
                    conexaoAberta.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conexaoAberta))
                    {
                        cmd.Parameters.AddWithValue("@idvendas", idVenda);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Produto produto = new Produto
                                {
                                    Nome = reader.GetString("nome"),
                                    Quantidade = reader.GetInt32("quantidade"),
                                    ValorUnitario = reader.GetDecimal("ValorUnitario")
                                };

                                lista.Add(produto);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar itens da venda: " + ex.Message);
                }
            }
            return lista;
        }
    }
}
