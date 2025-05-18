using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aurora.Views
{
    public partial class AutoCloseMessageBox : Form
    {
        private Timer timer;
        public AutoCloseMessageBox()
        {
            InitializeComponent();
        }

        public AutoCloseMessageBox(string v)
        {
        }

        public AutoCloseMessageBox(string message, int durationMs)
        {
            InitializeComponent();

            // Configuração da mensagem
            Label label = new Label()
            {
                Text = message,
                AutoSize = true,
                Location = new Point(10, 10)
            };
            Controls.Add(label);

            // Propriedades do formulário
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            ControlBox = false;
            TopMost = true; // Isso força a janela a aparecer na frente
            ShowInTaskbar = false;
            ClientSize = new Size(label.Width + 55, label.Height + 55);

            // Timer para fechar automaticamente
            timer = new Timer();
            timer.Interval = durationMs;
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                Close();
            };
            timer.Start();

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Bloqueia ESC, ALT+F4 e qualquer tecla de atalho
            if (keyData == Keys.Escape || keyData == (Keys.Alt | Keys.F4))
            {
                return true; // Ignora
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public static void Show(string message, int durationMs = 3000)
        {
            AutoCloseMessageBox box = new AutoCloseMessageBox(message, durationMs);
            box.Focus();
            box.WindowState = FormWindowState.Normal;
            box.ShowDialog();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
