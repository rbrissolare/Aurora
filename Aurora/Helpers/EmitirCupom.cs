using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aurora.Models;
using Aurora.Views;
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

            Cliente cliente = BuscarClienteDaVenda.BuscarClientePorVenda(idVenda);
            string textoCupom = MontarTexto(produtos, cliente, idVenda);
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

        private static string MontarTexto(List<Produto> produtos, Cliente cliente, int idVenda)
        {
            StringBuilder sb = new StringBuilder();

            // Reinicializa impressora
            sb.Append("\x1B\x40");
            sb.Append("\x1B\x74\x03"); // Define a tabela de caracteres para CP850 (acentuação correta)

            // Centraliza
            sb.Append("\x1B\x61\x01");
            sb.AppendLine("LOJA AURORA");
            sb.AppendLine("CNPJ: 00.000.000/0000-00");
            sb.AppendLine("Rua das Flores, 123 - Centro");
            sb.AppendLine("-----------------------------");

            // Alinhamento à esquerda
            sb.Append("\x1B\x61\x00");
            sb.AppendLine("CUPOM NÃO FISCAL\n");

            if (cliente != null)
            {
                // Negrito (liga)
                sb.Append("\x1B\x45\x01");
                sb.AppendLine($"Cliente: {cliente.Nome.ToUpper()}");
                sb.AppendLine($"CPF: {long.Parse(cliente.Cpf).ToString(@"000\.000\.000\-00")}\n");
                // Negrito (desliga)
                sb.Append("\x1B\x45\x00");
            }
            else
            {
                sb.Append("\x1B\x45\x01");
                sb.AppendLine("Cliente: Não cadastrado");
                sb.Append("\x1B\x45\x00");
            }
            
            sb.AppendLine("-----------------------------");
            // Data e hora
            sb.AppendLine($"Data: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine("ITEM       QTD   VL UNIT\n");



            foreach (var produto in produtos)
            {
                sb.AppendLine($"{produto.Nome,-10} {produto.Quantidade,3} R${produto.ValorUnitario,7:N2}");
            }

            decimal total = produtos.Sum(p => p.Total);
            sb.AppendLine("\n-----------------------------");
            sb.Append("\x1B\x45\x01"); // Negrito
            sb.AppendLine($"TOTAL:     R${total,15:N2}\n");
            sb.Append("\x1B\x45\x00"); // Negrito off

            // Centraliza e adiciona mensagem de agradecimento
            sb.Append("\x1B\x61\x01");
            sb.AppendLine("OBRIGADO PELA PREFERÊNCIA!");
            sb.AppendLine("Volte sempre!\n\n");

            sb.AppendLine("\n\n");
            sb.AppendLine("\x1B\x69"); // Comando ESC/POS para cortar papel


            return sb.ToString();
        }

        private static void ExibirOuImprimir(string texto)
        {
            // 🧾 Mostra a mensagem pelo tempo real da emissão
            AutoCloseMessageBox.Show("\nEmitindo Cupom");

            // Futuramente, aqui entra o código para imprimir:
            string nomeImpressora = "MP-4200 TH";

            bool sucesso = Bematech.ImprimirCupom(texto, nomeImpressora);

            if (!sucesso)
            {
                MessageBox.Show("Falha ao Imprimir o Cupom. Verifique a conexão com a impressora.");
            }
        }
    }
}
