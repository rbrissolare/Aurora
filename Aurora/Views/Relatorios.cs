using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;


namespace Aurora
{
    public partial class Relatorios : Form
    {
        private string connectionBancoDeDadosCredenciais = "Server=localhost;Database=auroravendasdb;Uid=root;Pwd=admin;";


        public Relatorios()
        {
            InitializeComponent();
        }


        private void carregarLabelNomeCategoria()
        {
            label1.Text = cboxCategorias.Text;
        }

        private void carregarCategorias()
        {
            string consultarCategoria = @"SELECT DISTINCT categoria FROM produtos;";
            string valorCategorias = cboxCategorias.Text;




            using (MySqlConnection conexaoAbrirDB = new MySqlConnection(connectionBancoDeDadosCredenciais))
            {
                try
                {
                    conexaoAbrirDB.Open();
                    using (MySqlCommand cmd = new MySqlCommand(consultarCategoria, conexaoAbrirDB))
                    {
                        using (MySqlDataReader lerDados = cmd.ExecuteReader())
                        {
                            while (lerDados.Read())
                            {

                                var categoriaProduto = lerDados.GetString("categoria");

                                cboxCategorias.Items.Add(categoriaProduto);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarLabelNomeCategoria();
        }


        private void Relatorios_Load(object sender, EventArgs e)
        {
            carregarCategorias();

        }

        private void dtpFim_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string apontadorDB = connectionBancoDeDadosCredenciais;
            string consultarCategoria = @"SELECT DISTINCT categoria FROM produtos;";

            using (MySqlConnection conexaoAbrirDB = new MySqlConnection(apontadorDB))
            {
                try
                {
                    conexaoAbrirDB.Open();
                    using (MySqlCommand cmd = new MySqlCommand(consultarCategoria, conexaoAbrirDB))
                    {
                        using (MySqlDataReader lerDados = cmd.ExecuteReader())
                        {
                            while (lerDados.Read())
                            {

                                var categoriaProduto = lerDados.GetString("categoria");

                                cboxCategorias.Items.Add(categoriaProduto);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (string.IsNullOrEmpty(cboxCategorias.SelectedItem?.ToString()))
            {
                DialogResult resultado = MessageBox.Show("Selecione uma Categoria!", "Erro Sistematico", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                switch (resultado)
                {
                    case DialogResult.OK:
                        break;

                    case DialogResult.Cancel:
                        MessageBox.Show("Cancelado com sucesso", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                }
            }

            dvgRelatorio.Rows.Clear();

            var dateInicio = dtpInicio.Value.Date;
            var dateFim = dtpFim.Value.Date.AddDays(1).AddTicks(-1);

            string sql = @"SELECT 
                p.idprodutos, 
                p.nome, 
                p.categoria,
                p.valor_compra,
                p.valor_venda,
                p.quantidade,
                v.data_venda,
                SUM(vi.quantidade) AS quantidade_vendida, 
                SUM(vi.valor_total) AS valor_total,
                v.idvendas
            FROM produtos p
            JOIN vendas_itens vi ON vi.idprodutos = p.idprodutos
            INNER JOIN vendas v ON v.idvendas = vi.idvendas
            AND v.data_venda BETWEEN @dataInicio AND @dataFim";
            

            if (cboxCategorias.SelectedItem.ToString() != "Todas")
            {
                sql += " AND p.categoria = @categoria";
            }

            sql += " GROUP BY p.idprodutos, p.nome, p.categoria, p.valor_venda, v.idvendas, p.quantidade, v.data_venda;";

            using (MySqlConnection conexaoAbrirDB = new MySqlConnection(connectionBancoDeDadosCredenciais))
            {
                try
                {
                    conexaoAbrirDB.Open();
                    using(MySqlCommand cmd = new MySqlCommand(sql, conexaoAbrirDB))
                    {
                        cmd.Parameters.AddWithValue("@dataInicio", dateInicio);
                        cmd.Parameters.AddWithValue("@dataFim", dateFim);
                        cmd.Parameters.AddWithValue("@categoria", cboxCategorias.SelectedItem);


                        using (MySqlDataReader lerDados = cmd.ExecuteReader())
                        {
                            while (lerDados.Read())
                            {
                                var idProduto = lerDados.GetInt32("idprodutos");
                                var nomeProduto = lerDados.GetString("nome");
                                var valorCompra = lerDados.GetDecimal("valor_compra");
                                var valorVenda = lerDados.GetDecimal("valor_venda");
                                var quantidadeEstoque = lerDados["quantidade"];
                                var quantidadeVendida = lerDados.GetInt32("quantidade_vendida");
                                var totalBruto = lerDados.GetDecimal("valor_total");

                                decimal liquido = valorVenda - valorCompra;
                                decimal margem = (liquido / valorVenda) * 100;

                                margem = Math.Round(margem, 2);
                                string porcetagem = "%";
                                string reais = "R$ ";

                                decimal procurarLiquido = valorCompra * quantidadeVendida;
                                decimal totalLiquido = totalBruto - procurarLiquido;

                                int row = dvgRelatorio.Rows.Add();
                                dvgRelatorio.Rows[row].Cells["idprodutos"].Value = idProduto;
                                dvgRelatorio.Rows[row].Cells["nome"].Value = nomeProduto;
                                dvgRelatorio.Rows[row].Cells["categoriaProd"].Value = lerDados["categoria"];
                                dvgRelatorio.Rows[row].Cells["dataVenda"].Value = lerDados["data_venda"];
                                dvgRelatorio.Rows[row].Cells["quantidade"].Value = quantidadeEstoque;
                                dvgRelatorio.Rows[row].Cells["valor_compra"].Value = reais + valorCompra;
                                dvgRelatorio.Rows[row].Cells["valor_venda"].Value = reais + valorVenda;
                                dvgRelatorio.Rows[row].Cells["qnt_vendida"].Value = quantidadeVendida;
                                dvgRelatorio.Rows[row].Cells["idvendas"].Value = lerDados["idvendas"];
                                dvgRelatorio.Rows[row].Cells["margem"].Value = margem + porcetagem;
                                dvgRelatorio.Rows[row].Cells["total_liquido"].Value = reais + totalLiquido;
                                dvgRelatorio.Rows[row].Cells["total_bruto"].Value = reais + totalBruto;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void cboxCategorias_ControlRemoved(object sender, ControlEventArgs e)
        {

        }
    }
}
