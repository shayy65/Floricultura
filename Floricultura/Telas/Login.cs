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
    public partial class Login : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Funcionario> funcionarios = new List<Funcionario>();
        List<Produto> produtos = new List<Produto>();
        List<VendaF> vendas = new List<VendaF>();
        public Login(List<Cliente> lclientes, List<Funcionario> lfuncionarios, List<Produto> lprodutos, List<VendaF> lvendas)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            clientes = lclientes;
            funcionarios = lfuncionarios;
            produtos = lprodutos;
            vendas = lvendas;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            bool validar = true;


                foreach (var funcionario in funcionarios)
                {
                if (txt_usuario.Text == funcionario.Usuario && txt_senha.Text == funcionario.Senha)
                {
                    validar = false;
                    MenuF menu = new MenuF(clientes, funcionarios, produtos, vendas);
                    this.Hide();
                    menu.ShowDialog();
                }

                }
                if (validar)
                {
                    MessageBox.Show("Usuário ou Senha Incorretos");
                }
            
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio(clientes, funcionarios, produtos, vendas);
            inicio.ShowDialog();
        }
    }
}
