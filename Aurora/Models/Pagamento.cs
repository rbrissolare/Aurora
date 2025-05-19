using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aurora.Models
{
    
    public class Pagamento
    {
        decimal valorJuros = 100;
        public decimal taxaJuros = 5;
        public decimal taxaJurosParcSix = 6.49m + 0.49m * 2;
        public decimal taxaJurosParcSeven = 7.49m + 0.69m * 2;
        public decimal taxaJurosParcEight = 8.49m + 1.79m * 2;
        public decimal taxaJurosParcNine = 9.49m + 2.89m * 2;
        public decimal taxaJurosParcTen = 10.49m + 3.89m * 2;
        public decimal taxaJurosParcelamentoCliente = 0.49m * 2;



        public int IdTransacao { get; set; } // ID da transação
        public string NomeTransacao { get; set; } // CRÉDITO - DÉBITO - PIX - DINHEIRO

        public string TipoTransacao { get; set; } // CRÉDITO PARCELADO LOJA - CRÉDITO PARCELADO CLIENTE - CRÉDITO A VISTA - DÉBITO - A VISTA

        public List<int> ParcelasTransacao { get; set; } // 1 - 2 - 3 - 4 - 5 - 6 - 7 - 8 - 9 - 10

        public decimal ValorBase { get; set; } // Valor Base

        public DateTime DataTransacao { get; set; } // Data da transação

        public string StatusTransacao { get; set; } // PAGO - PENDENTE - CANCELADO

        public decimal JurosTransacao { get; set; } // Aplicação de Juros ex: 1.2% / 1.4% / 1.6%

        public decimal AplicarJuros { get; set; }


        public void ObterTransacao(string nomeTransacao, List<int> ParcelasTransacao)
        {
            switch (nomeTransacao)
            {
                case "CREDITO_A_VISTA":
                    MessageBox.Show("Transação de crédito selecionada.");
                    this.TipoTransacao = "CRÉDITO A VISTA";
                    this.ParcelasTransacao = new List<int> { 1 };
                    this.JurosTransacao = taxaJuros;
                    this.ValorBase = 100;
                    this.AplicarJuros = this.ValorBase * this.taxaJuros;


                    break;

                case "CREDITO_PARCELADO_LOJA":
                    MessageBox.Show("Transação de crédito (parcelamento loja) selecionada.");
                    this.TipoTransacao = "CRÉDITO A PARCELADO LOJA";
                    this.ParcelasTransacao = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                    int parcelasEscolhidas = ParcelasTransacao.Max();

                    if (parcelasEscolhidas == 6)
                    {

                        this.JurosTransacao = taxaJurosParcSix;
                        this.ValorBase = 100;
                        this.AplicarJuros = this.ValorBase * this.taxaJurosParcSix;
                    }
                    else if (parcelasEscolhidas == 7)
                    {
                        this.JurosTransacao = taxaJurosParcSeven;
                        this.ValorBase = 100;
                        this.AplicarJuros = this.ValorBase * this.taxaJurosParcSeven;

                    }
                    else if (parcelasEscolhidas == 8)
                    {
                        this.JurosTransacao = taxaJurosParcEight;
                        this.ValorBase = 100;
                        this.AplicarJuros = this.ValorBase * this.taxaJurosParcEight;
                    }
                    else if (parcelasEscolhidas == 9)
                    {
                        this.JurosTransacao = taxaJurosParcNine;
                        this.ValorBase = 100;
                        this.AplicarJuros = this.ValorBase * this.taxaJurosParcNine;
                    }
                    else if (parcelasEscolhidas == 10)
                    {
                        this.JurosTransacao = taxaJurosParcTen;
                        this.ValorBase = 100;
                        this.AplicarJuros = this.ValorBase * this.taxaJurosParcTen;
                    }
                    else
                    {
                        this.JurosTransacao = taxaJuros;
                        this.ValorBase = 100;
                        this.AplicarJuros = this.ValorBase * this.taxaJuros;
                    }
                    break;

                case "CREDITO_PARCELADO_CLIENTE":
                    MessageBox.Show("Transação de crédito (parcelamento cliente) selecionada.");
                    this.TipoTransacao = "CRÉDITO A PARCELADO LOJA";
                    this.ParcelasTransacao = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                    int parcelasEscolhidasCliente = ParcelasTransacao.Max();                    


                    if (parcelasEscolhidasCliente == 12)
                    {

                        this.JurosTransacao = (taxaJurosParcSix * 12) + taxaJurosParcelamentoCliente;
                        this.ValorBase = 100;
                        this.AplicarJuros = this.ValorBase * this.taxaJurosParcSix;
                    }
                    else if (parcelasEscolhidasCliente == 14)
                    {
                        this.JurosTransacao = (taxaJurosParcSeven * 14) + taxaJurosParcelamentoCliente;
                        this.ValorBase = 100;
                        this.AplicarJuros = this.ValorBase * this.taxaJurosParcSeven;

                    }
                    else if (parcelasEscolhidasCliente == 16)
                    {
                        this.JurosTransacao = (taxaJurosParcEight * 16) + taxaJurosParcelamentoCliente;
                        this.ValorBase = 100;
                        this.AplicarJuros = this.ValorBase * this.taxaJurosParcEight;
                    }
                    else if (parcelasEscolhidasCliente == 18)
                    {
                        this.JurosTransacao = (taxaJurosParcNine * 18) + taxaJurosParcelamentoCliente;
                        this.ValorBase = 100;
                        this.AplicarJuros = this.ValorBase * this.taxaJurosParcNine;
                    }
                    else if (parcelasEscolhidasCliente == 20)
                    {
                        this.JurosTransacao = (taxaJurosParcTen * 20) + taxaJurosParcelamentoCliente;
                        this.ValorBase = 100;
                        this.AplicarJuros = this.ValorBase * this.taxaJurosParcTen;
                    }
                    else
                    {
                        this.JurosTransacao = (taxaJurosParcTen * 24 * taxaJurosParcelamentoCliente) + (taxaJurosParcelamentoCliente * taxaJurosParcelamentoCliente);
                        this.ValorBase = 100;
                        this.AplicarJuros = this.ValorBase * this.taxaJuros;
                    }
                    break;

                case "DEBITO":
                    MessageBox.Show("Transação de débito selecionada.");
                    return;

                case "PIX":
                    MessageBox.Show("Transação de PIX selecionada.");
                    return;

                case "DINHEIRO":
                    MessageBox.Show("Transação de dinheiro selecionada.");
                    return;

                default:
                    MessageBox.Show("Transação inválida.");
                    break;

            }

        }

    }  
}
