using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aurora
{
    public class EmitirCupom
    {
        private static string connectionString = "Server=localhost;Database=auroravendasdb;Uid=root;Pwd=admin;";

        public static void Imprimir (int idVenda)
        {
            List<Produto> produtos = BuscarVendasDB.BuscarItensdaVenda(idVenda);

            if (produtos.Count == 0)
            {
                throw new Exception("Nenhum item encontrado para essa esta venda.");
            }

            string textoCupom = MontarTexto(produtos, idVenda);
            ExibirOuImprimir(textoCupom);
        }

        private static List<Produto> BuscarItensdaVenda(int idVenda)
        {
            List<Produto> lista = new List<Produto>();

            string sql = @"SELECT 
                                p.nome,
                                vi.quantidade,
                                vi.valor_unitario AS ValorUnitario
                            FROM vendas_itens vi
                            JOIN produtos p ON p.idprodutos = vi.idprodutos
                            WHERE vi.idvendas = @idvendas;";

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
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
                    MessageBox.Show("Erro ao carregar itens da venda: " + ex.Message);
                }
            }

            return lista;
        }

        private static string MontarTexto(List<Produto> produtos, int idVenda)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LOJA AURORA");
            sb.AppendLine("Rua das Flores, 123 - Centro");
            sb.AppendLine("-----------------------------");
            sb.AppendLine("ITEM       QTD   VL UNIT\n");

            foreach (var produto in produtos)
            {
                sb.AppendLine($"{produto.Nome,-10} {produto.Quantidade,3} R${produto.ValorUnitario,7:N2}");
            }

            decimal total = produtos.Sum(p => p.Total);
            sb.AppendLine("\n-----------------------------");
            sb.AppendLine($"TOTAL:     R${total,15:N2}");
            sb.AppendLine("\n\n");
            sb.AppendLine("\x1B\x69"); // Comando ESC/POS para cortar papel

            return sb.ToString();
        }

        private static void ExibirOuImprimir(string texto)
        {
            // Mostra o cupom no MessageBox (temporariamente)
            MessageBox.Show(texto, "Emitindo Cupom");

            // Futuramente, aqui entra o código para imprimir:
            // Bematech.ImprimirTexto(texto, "Bematech MP-4200 TH");
        }
    }
}
