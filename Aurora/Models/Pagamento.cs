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
        public decimal taxaJurosParc = 12;


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

                    if (parcelasEscolhidas >= 6)
                    {

                        this.JurosTransacao = taxaJurosParc;
                        this.ValorBase = 100;
                        this.AplicarJuros = this.ValorBase * this.taxaJurosParc;
                    }
                    else
                    {
                        this.JurosTransacao = taxaJuros;
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
