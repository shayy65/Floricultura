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
    public partial class CadastroClien : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Funcionario> funcionarios = new List<Funcionario>();
        List<Produto> produtos = new List<Produto>();
        List<VendaF> vendas = new List<VendaF>();
        public CadastroClien(List<Cliente> lclientes, List<Funcionario> lfuncionarios, List<Produto> lprodutos, List<VendaF> lvendas)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            clientes = lclientes;
            funcionarios = lfuncionarios;
            produtos = lprodutos;
            vendas = lvendas;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CadastroClien_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_enderecocliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.ClienteID = ((clientes.Last().ClienteID) + 1);
            cliente.Nome = txt_nomecliente.Text;
            cliente.CPF = txt_cpfcliente.Text;
            cliente.Email = txt_emailcliente.Text;
            cliente.Telefone = txt_telefonecliente.Text;
            cliente.Endereco = txt_enderecocliente.Text;

            clientes.Add(cliente);
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            txt_nomecliente.Clear();
            txt_cpfcliente.Clear();
            txt_emailcliente.Clear();
            txt_enderecocliente.Clear();
            txt_telefonecliente.Clear();
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuF menu = new MenuF(clientes, funcionarios, produtos, vendas);
            menu.ShowDialog();
        }
    }
}
