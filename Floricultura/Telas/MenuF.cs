using Floricultura.classes;
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
    public partial class MenuF : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Funcionario> funcionarios = new List<Funcionario>();
        List<Produto> produtos = new List<Produto>();
        List<VendaF> vendas = new List<VendaF>();
        public MenuF(List<Cliente> lclientes, List<Funcionario> lfuncionarios, List<Produto> lprodutos, List<VendaF> lvendas)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            clientes = lclientes;
            funcionarios = lfuncionarios;
            produtos = lprodutos;
            vendas = lvendas;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarFunc funcionario = new CadastrarFunc(clientes, funcionarios, produtos, vendas);
            funcionario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroClien clien = new CadastroClien(clientes, funcionarios, produtos, vendas);
            clien.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarProd produto = new CadastrarProd(clientes, funcionarios, produtos, vendas);
            produto.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Venda venda = new Venda(clientes, funcionarios, produtos, vendas);
            venda.ShowDialog();
        }

        private void MenuF_Load(object sender, EventArgs e)
        {

        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(clientes, funcionarios, produtos, vendas);
            login.ShowDialog();
        }
    }
}
