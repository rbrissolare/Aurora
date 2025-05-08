using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aurora
{
    public partial class LoadingForm : Form
    {
        private readonly int duracaoTotal = 18000; // 5 segundos
        private readonly int intervalo = 2000;    // 1 segundo
        private Timer timer;
        private int mensagemAtual = 0;
        private int tempoDecorrido = 0;
        private string[] mensagens = new string[]
                        {
                "Loading...",
                "Aguarde um momento...",
                "Salvando...",
                "0%...",
                "1%...",
                "2%...",
                "3%...",
                "50%...",
                "100%..."


            };

        public LoadingForm()
        {
            InitializeComponent();



            LabelStatus.Text = mensagens[0];

            timer = new Timer();
            timer.Interval = intervalo; // 2 segundos
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            mensagemAtual = (mensagemAtual +1) % mensagens.Length;
            LabelStatus.Text = mensagens[mensagemAtual];

            tempoDecorrido += intervalo;
            if (tempoDecorrido >= duracaoTotal)
            {
                timer.Stop();
                this.Close(); // Fecha o formulário e libera o ShowDialog
            }

        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
