using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace Aurora
{
    public partial class CancelarVenda : Form
    {
        private string connectionBancoDeDadosCredenciais = "Server=localhost;Database=auroravendasdb;Uid=root;Pwd=w2e5d4cc;";
        public CancelarVenda()
        {
            InitializeComponent();
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var dateInicio = dtpInicio.Value.Date;
            var dateFim = dtpFim.Value.Date.AddDays(1).AddTicks(-1);

            MessageBox.Show($"Buscando vendas no período de {dateInicio} à {dateFim}", "Buscando...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            string buscarVendas = @"SELECT idvendas, idclientes, data_venda, valor_total FROM vendas WHERE data_venda BETWEEN @dataInicio AND @dataFim;";

            using (MySqlConnection conexaoDeAbrirBanco = new MySqlConnection(connectionBancoDeDadosCredenciais)) 
            {
                try
                {
                    conexaoDeAbrirBanco.Open();
                    using(MySqlCommand lerDadosVendas = new MySqlCommand(buscarVendas, conexaoDeAbrirBanco)) 
                    {
                        lerDadosVendas.Parameters.AddWithValue("@dataInicio", dateInicio);
                        lerDadosVendas.Parameters.AddWithValue("@dataFim", dateFim);

                        dgvCancelarVendas.Rows.Clear();

                        using (MySqlDataReader lendoDadosVendas = lerDadosVendas.ExecuteReader()) 
                        {
                            while (lendoDadosVendas.Read())
                            {
                                var idVenda = lendoDadosVendas.GetInt32("idvendas");
                                var idCliente = lendoDadosVendas.GetInt32("idclientes");
                                var dataVenda = lendoDadosVendas.GetDateTime("data_venda");
                                var valorTotal = lendoDadosVendas.GetDecimal("valor_total");

                                dgvCancelarVendas.Rows.Add(idVenda, idCliente, dataVenda, valorTotal);
                                
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            // CODIGO PARA CANCELAR //

            string recebeIDCancelarVendas = txtIdVenda.Text.Trim();

            using(MySqlConnection connectionDb = new MySqlConnection(connectionBancoDeDadosCredenciais))
            {
                connectionDb.Open();

                using (var cancelarVendas = connectionDb.BeginTransaction())
                {
                    try
                    {
                        var listaItens = new List<(int idProd, int Qnt)>();

                        string lerProdutosCancelamento = @"SELECT idvendas, idprodutos, quantidade,valor_unitario,valor_total,categoria FROM vendas_itens WHERE idvendas = @Idvendas;";
                        using(MySqlCommand lerProdutos = new MySqlCommand(lerProdutosCancelamento, connectionDb, cancelarVendas))
                        {
                            lerProdutos.Parameters.AddWithValue("@Idvendas", recebeIDCancelarVendas);
                            using (var lendoProdutos = lerProdutos.ExecuteReader())
                            {
                                
                                while (lendoProdutos.Read())
                                {
                                    int id = lendoProdutos.GetInt32("idprodutos");
                                    int qnt = lendoProdutos.GetInt32("quantidade");
                                    listaItens.Add((id,qnt));
                                }
                            }
                        }
                        
                        string removeVendaItens = @"DELETE FROM vendas_itens WHERE idvendas = @Idvendas;";

                        using (MySqlCommand executarCancelamentoProdutos = new MySqlCommand(removeVendaItens,connectionDb,cancelarVendas))
                        {
                            executarCancelamentoProdutos.Parameters.AddWithValue("@Idvendas", recebeIDCancelarVendas);
                            executarCancelamentoProdutos.ExecuteNonQuery();
                        }

                        string removeVendaVendas = @"DELETE FROM vendas WHERE idvendas = @IdVendas;";

                        using (MySqlCommand executarCancelamentoVendas = new MySqlCommand(removeVendaVendas, connectionDb, cancelarVendas))
                        {
                            executarCancelamentoVendas.Parameters.AddWithValue("@IdVendas", recebeIDCancelarVendas);
                            executarCancelamentoVendas.ExecuteNonQuery();
                        }

                        string atualizarEstoque = @"UPDATE produtos SET quantidade = quantidade + @qntCancelada WHERE idprodutos = @IdProdutos;";
                        using (MySqlCommand executarUpateEstoque = new MySqlCommand(atualizarEstoque, connectionDb, cancelarVendas))
                        {
                            foreach (var (idProd,Qnt) in listaItens)
                            {
                                executarUpateEstoque.Parameters.Clear();
                                executarUpateEstoque.Parameters.AddWithValue("@qntCancelada", Qnt);
                                executarUpateEstoque.Parameters.AddWithValue("@IdProdutos", idProd);
                                executarUpateEstoque.ExecuteNonQuery();
                            }
                        }
                        cancelarVendas.Commit();
                        MessageBox.Show("Venda cancelada com sucesso.");
                        this.Close();
                        new CancelarVenda().Show();
                    }
                    catch (Exception ex)
                    {
                        cancelarVendas.Rollback();
                        MessageBox.Show(ex.Message);
                        
                    }
                }
            }
        }

        private void txtIdVenda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
