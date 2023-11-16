using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floricultura
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CadastrarFunc funcionario = new CadastrarFunc();
            funcionario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroClien clien = new CadastroClien();
            clien.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastrarProd produto = new CadastrarProd();
            produto.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda();
            venda.ShowDialog();
        }
    }
}
