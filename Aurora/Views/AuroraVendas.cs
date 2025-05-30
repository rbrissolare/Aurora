﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Aurora.Models;
using Mysqlx.Cursor;

namespace Aurora
{
    public partial class AuroraVendas : Form
    {
        public AuroraVendas()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            bool verificarSeCadastrarClienteAberta = Application.OpenForms.OfType<CadastroCliente>().Any();
            if (verificarSeCadastrarClienteAberta)
            {
                MessageBox.Show("A janela de cadastros de clientes já está aberta.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var form = Application.OpenForms.OfType<CadastroCliente>().FirstOrDefault();
                if(form != null)
                {
                    form.BringToFront();
                    form.WindowState = FormWindowState.Normal;
                }
            }
            else
            {
                new CadastroCliente().Show();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool verificarSeEditarClienteAberta = Application.OpenForms.OfType<EditarCliente>().Any();

            if (verificarSeEditarClienteAberta)
            {
                MessageBox.Show("A janela de editar clientes já está aberta.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                var form = Application.OpenForms.OfType<EditarCliente>().FirstOrDefault();
                if(form != null)
                {
                    form.BringToFront();
                    form.WindowState = FormWindowState.Normal;
                }
            }
            else
            {
                new EditarCliente().Show();
            }
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            bool verificarSeCadastrarProdutoAberta = Application.OpenForms.OfType<CadastroProduto>().Any();

            if (verificarSeCadastrarProdutoAberta)
            {
                MessageBox.Show("A janela de cadastro de produtos já está aberta.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                var form = Application.OpenForms.OfType<CadastroProduto>().FirstOrDefault();
                if (form != null)
                {
                    form.BringToFront();
                    form.WindowState = FormWindowState.Normal;
                }
            }
            else
            {
                new CadastroProduto().Show();
            }
        }

        private void btnEditarPrdutos_Click(object sender, EventArgs e)
        {
            
            bool verificarSeTelaEditarProdutosAberta = Application.OpenForms.OfType<EditarProdutos>().Any();

            if (verificarSeTelaEditarProdutosAberta)
            {
                MessageBox.Show("A janela de edição de produtos já está aberta.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                var form = Application.OpenForms.OfType<EditarProdutos>().FirstOrDefault();
                if (form != null)
                {
                    form.BringToFront();
                    form.WindowState = FormWindowState.Normal;
                }

            }
            else
            {
                new EditarProdutos().Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool verificarSeTelaPDVAberta = Application.OpenForms.OfType<PDV>().Any();
            if (verificarSeTelaPDVAberta)
            {
                MessageBox.Show("A janela de PDV já está aberta.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                var form = Application.OpenForms.OfType<PDV>().FirstOrDefault();
                if(form != null)
                {
                    form.BringToFront();
                    form.WindowState = FormWindowState.Maximized;
                }
            }
            else
            {
                new PDV().Show();
            }
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            bool verificarSeTelaCancelarVendaAberta = Application.OpenForms.OfType<CancelarVenda>().Any();
            if (verificarSeTelaCancelarVendaAberta)
            {
                MessageBox.Show("A janela de cancelar vendas já está aberta.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                var form = Application.OpenForms.OfType<CancelarVenda>().FirstOrDefault();

                if(form != null)
                {
                    form.BringToFront();
                    form.WindowState = FormWindowState.Normal;
                }

            }
            else
            {
                new CancelarVenda().Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool verificarSeTelaRelatoriosAberta = Application.OpenForms.OfType<Relatorios>().Any();
            if (verificarSeTelaRelatoriosAberta)
            {
                MessageBox.Show("A janela de relatórios já está aberta.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                var form = Application.OpenForms.OfType<Relatorios>().FirstOrDefault();
                if(form != null)
                {
                    form.BringToFront();
                    form.WindowState = FormWindowState.Maximized;
                }

            }
            else
            {
                new Relatorios().Show();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int idVenda = 103;
            List<Produto> produtos = BuscarVendasDB.BuscarItensdaVenda(idVenda);

            if(produtos.Count == 0)
            {
                MessageBox.Show("Nenhum produto encontrado com esse ID");
                return;
            }

            StringBuilder sb = new StringBuilder();
            foreach (var produto in produtos)
            {
                sb.AppendLine($"Nome: {produto.Nome}");
                sb.AppendLine($"Quantidade: {produto.Quantidade}");
                sb.AppendLine($"Valor Unitário: {produto.ValorUnitario:N2}");
                sb.AppendLine($"Total: R$ {produto.Total:N2}");
                sb.AppendLine("-----------------------------");
            }

            MessageBox.Show(sb.ToString(), "Itens da Venda");

        }

        private void AuroraVendas_Load(object sender, EventArgs e)
        {

        }

        private async void AuroraVendas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case var PDV when e.KeyCode == Keys.F1:
                    button1_Click(sender, e);
                    e.Handled = true;
                    break;

                case var cancelarVenda when e.KeyCode == Keys.F2:
                    btnCancelarVenda_Click(sender, e);
                    e.Handled = true;
                    break;

                case var cadastroCliente when e.KeyCode == Keys.F3:
                    btnCadastrarCliente_Click(sender, e);
                    e.Handled = true;
                    break;
                case var editarCliente when e.KeyCode == Keys.F4:
                    button2_Click(sender, e);
                    e.Handled = true;
                    break;
                case var cadastrarProduto when e.KeyCode == Keys.F5:
                    btnCadastrarProduto_Click(sender, e);
                    e.Handled = true;
                    break;
                case var editarProduto when e.KeyCode == Keys.F6:
                    btnEditarPrdutos_Click(sender, e);
                    e.Handled = true;
                    break;
                case var relatorios when e.KeyCode == Keys.F7:
                    button1_Click_1(sender, e);
                    e.Handled = true;
                    break;

                case var sair when e.KeyCode == Keys.F12:
                    DialogResult resultado = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    e.Handled = true;

                    if (resultado == DialogResult.Yes)
                    {
                        using (var loading = new LoadingForm())
                        {
                          
                            Application.ExitThread();
                        }
                    }
                    else
                    {
                        return;
                    }
                    break;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            decimal ValorTransacao = 1000;

            int Parcelas = 7;


            string creditoAVista = "CREDITO_A_VISTA";
            string creditoParceladoLoja = "CREDITO_PARCELADO_LOJA";
            string creditoParceladoCliente = "CREDITO_PARCELADO_CLIENTE";

            Pagamento pagamento = new Pagamento();

            switch (creditoParceladoLoja)
            {
                case "CREDITO_A_VISTA":
                    pagamento.NomeTransacao = "CREDITO_A_VISTA";
                    pagamento.ParcelasTransacao = new List<int> { Parcelas }; // Atribuir uma lista de inteiros
                    pagamento.ObterTransacao(pagamento.NomeTransacao, pagamento.ParcelasTransacao);

                    decimal valorComJuros = ValorTransacao / pagamento.ValorBase;
                    decimal buscarJuros = valorComJuros * pagamento.taxaJuros;
                    decimal valorTotalTransacaoFinal = ValorTransacao + buscarJuros;

                    MessageBox.Show($"Total da venda com juros: {valorTotalTransacaoFinal:C}");

                    break;

                case "CREDITO_PARCELADO_LOJA":
                    pagamento.NomeTransacao = "CREDITO_PARCELADO_LOJA";
                    pagamento.ParcelasTransacao = new List<int> { Parcelas }; // Atribuir uma lista de inteiros
                    pagamento.ObterTransacao(pagamento.NomeTransacao, pagamento.ParcelasTransacao);

                    decimal valorComJurosParceladoLoja = ValorTransacao / pagamento.ValorBase;

                    if(Parcelas == 6)
                    {
                      decimal buscarJurosParceladoLoja = valorComJurosParceladoLoja * pagamento.taxaJurosParcSix;
                      decimal valorTotalTransacaoFinalParceladoLoja = ValorTransacao + buscarJurosParceladoLoja;
                      decimal parcelamentos = valorTotalTransacaoFinalParceladoLoja / Parcelas;
                      MessageBox.Show($"Total da venda com juros: {valorTotalTransacaoFinalParceladoLoja:C}.\n\nParcelado em {Parcelas}x de {parcelamentos:C} mensal", $"Crédito Parcelamento Loja: {Parcelas} parcelas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Parcelas == 7)
                    {
                        decimal buscarJurosParceladoLoja = valorComJurosParceladoLoja * pagamento.taxaJurosParcSeven;
                        decimal valorTotalTransacaoFinalParceladoLoja = ValorTransacao + buscarJurosParceladoLoja;
                        decimal parcelamentos = valorTotalTransacaoFinalParceladoLoja / Parcelas;
                        MessageBox.Show($"Total da venda com juros: {valorTotalTransacaoFinalParceladoLoja:C}.\n\nParcelado em {Parcelas}x de {parcelamentos:C} mensal", $"Crédito Parcelamento Loja: {Parcelas} parcelas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Parcelas == 8)
                    {
                        decimal buscarJurosParceladoLoja = valorComJurosParceladoLoja * pagamento.taxaJurosParcEight;
                        decimal valorTotalTransacaoFinalParceladoLoja = ValorTransacao + buscarJurosParceladoLoja;
                        decimal parcelamentos = valorTotalTransacaoFinalParceladoLoja / Parcelas;
                        MessageBox.Show($"Total da venda com juros: {valorTotalTransacaoFinalParceladoLoja:C}.\n\nParcelado em {Parcelas}x de {parcelamentos:C} mensal", $"Crédito Parcelamento Loja: {Parcelas} parcelas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Parcelas == 9)
                    {
                        decimal buscarJurosParceladoLoja = valorComJurosParceladoLoja * pagamento.taxaJurosParcNine;
                        decimal valorTotalTransacaoFinalParceladoLoja = ValorTransacao + buscarJurosParceladoLoja;
                        decimal parcelamentos = valorTotalTransacaoFinalParceladoLoja / Parcelas;
                        MessageBox.Show($"Total da venda com juros: {valorTotalTransacaoFinalParceladoLoja:C}.\n\nParcelado em {Parcelas}x de {parcelamentos:C} mensal", $"Crédito Parcelamento Loja: {Parcelas} parcelas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(Parcelas == 10)
                    {
                        decimal buscarJurosParceladoLoja = valorComJurosParceladoLoja * pagamento.taxaJurosParcTen;
                        decimal valorTotalTransacaoFinalParceladoLoja = ValorTransacao + buscarJurosParceladoLoja;
                        decimal parcelamentos = valorTotalTransacaoFinalParceladoLoja / Parcelas;
                        MessageBox.Show($"Total da venda com juros: {valorTotalTransacaoFinalParceladoLoja:C}.\n\nParcelado em {Parcelas}x de {parcelamentos:C} mensal", $"Crédito Parcelamento Loja: {Parcelas} parcelas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        decimal buscarJurosParceladoLoja = valorComJurosParceladoLoja * pagamento.taxaJuros;
                        decimal valorTotalTransacaoFinalParceladoLoja = ValorTransacao + buscarJurosParceladoLoja;
                        decimal parcelamentos = valorTotalTransacaoFinalParceladoLoja / Parcelas;
                        MessageBox.Show($"Total da venda com juros: {valorTotalTransacaoFinalParceladoLoja:C}.\n\nParcelado em {Parcelas}x de {parcelamentos:C} mensal", $"Crédito Parcelamento Loja: {Parcelas} parcelas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case "CREDITO_PARCELADO_CLIENTE":
                    pagamento.NomeTransacao = "CREDITO_PARCELADO_CLIENTE";
                    pagamento.ParcelasTransacao = new List<int> { Parcelas }; // Atribuir uma lista de inteiros
                    pagamento.ObterTransacao(pagamento.NomeTransacao, pagamento.ParcelasTransacao);

                    decimal valorComJurosParceladoCliente = ValorTransacao / pagamento.ValorBase;

                    if (Parcelas == 12)
                    {
                        decimal buscarJurosParceladoLoja = valorComJurosParceladoCliente * pagamento.JurosTransacao;
                        decimal valorTotalTransacaoFinalParceladoLoja = ValorTransacao + buscarJurosParceladoLoja + pagamento.taxaJurosParcelamentoCliente;
                        decimal parcelamentos = valorTotalTransacaoFinalParceladoLoja / Parcelas;
                        MessageBox.Show($"Total da venda com juros: {valorTotalTransacaoFinalParceladoLoja:C}.\n\nParcelado em {Parcelas}x de {parcelamentos:C} mensal", $"Crédito Parcelamento Loja: {Parcelas} parcelas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Parcelas == 14)
                    {
                        decimal buscarJurosParceladoLoja = valorComJurosParceladoCliente * pagamento.JurosTransacao;
                        decimal valorTotalTransacaoFinalParceladoLoja = ValorTransacao + buscarJurosParceladoLoja + pagamento.taxaJurosParcelamentoCliente;
                        decimal parcelamentos = valorTotalTransacaoFinalParceladoLoja / Parcelas;
                        MessageBox.Show($"Total da venda com juros: {valorTotalTransacaoFinalParceladoLoja:C}.\n\nParcelado em {Parcelas}x de {parcelamentos:C} mensal", $"Crédito Parcelamento Loja: {Parcelas} parcelas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Parcelas == 16)
                    {
                        decimal buscarJurosParceladoLoja = valorComJurosParceladoCliente * pagamento.JurosTransacao;
                        decimal valorTotalTransacaoFinalParceladoLoja = ValorTransacao + buscarJurosParceladoLoja + pagamento.taxaJurosParcelamentoCliente;
                        decimal parcelamentos = valorTotalTransacaoFinalParceladoLoja / Parcelas;
                        MessageBox.Show($"Total da venda com juros: {valorTotalTransacaoFinalParceladoLoja:C}.\n\nParcelado em {Parcelas}x de {parcelamentos:C} mensal", $"Crédito Parcelamento Loja: {Parcelas} parcelas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Parcelas == 18)
                    {
                        decimal buscarJurosParceladoLoja = valorComJurosParceladoCliente * pagamento.JurosTransacao;
                        decimal valorTotalTransacaoFinalParceladoLoja = ValorTransacao + buscarJurosParceladoLoja + pagamento.taxaJurosParcelamentoCliente;
                        decimal parcelamentos = valorTotalTransacaoFinalParceladoLoja / Parcelas;
                        MessageBox.Show($"Total da venda com juros: {valorTotalTransacaoFinalParceladoLoja:C}.\n\nParcelado em {Parcelas}x de {parcelamentos:C} mensal", $"Crédito Parcelamento Loja: {Parcelas} parcelas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Parcelas == 20)
                    {
                        decimal buscarJurosParceladoLoja = valorComJurosParceladoCliente * pagamento.JurosTransacao;
                        decimal valorTotalTransacaoFinalParceladoLoja = ValorTransacao + buscarJurosParceladoLoja + pagamento.taxaJurosParcelamentoCliente;
                        decimal parcelamentos = valorTotalTransacaoFinalParceladoLoja / Parcelas;
                        MessageBox.Show($"Total da venda com juros: {valorTotalTransacaoFinalParceladoLoja:C}.\n\nParcelado em {Parcelas}x de {parcelamentos:C} mensal", $"Crédito Parcelamento Loja: {Parcelas} parcelas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        decimal buscarJurosParceladoLoja = valorComJurosParceladoCliente * pagamento.JurosTransacao;
                        decimal valorTotalTransacaoFinalParceladoLoja = ValorTransacao + buscarJurosParceladoLoja + pagamento.taxaJurosParcelamentoCliente;
                        decimal parcelamentos = valorTotalTransacaoFinalParceladoLoja / Parcelas;
                        MessageBox.Show($"Total da venda com juros: {valorTotalTransacaoFinalParceladoLoja:C}.\n\nParcelado em {Parcelas}x de {parcelamentos:C} mensal", $"Crédito Parcelamento Loja: {Parcelas} parcelas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

            }
        }
    }
}
