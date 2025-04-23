using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aurora
{
    public partial class AuroraVendas : Form
    {
        public AuroraVendas()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
           new CadastroCliente().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           new EditarCliente().Show();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            new CadastroProduto().Show();
        }

        private void btnEditarPrdutos_Click(object sender, EventArgs e)
        {
            new EditarProdutos().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PDV().Show();
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            new CancelarVenda().Show();
        }
    }
}
