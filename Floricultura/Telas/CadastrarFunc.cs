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
    public partial class CadastrarFunc : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Funcionario> funcionarios = new List<Funcionario>();
        List<Produto> produtos = new List<Produto>();
        List<VendaF> vendas = new List<VendaF>();
        public CadastrarFunc(List<Cliente> lclientes, List<Funcionario> lfuncionarios, List<Produto> lprodutos, List<VendaF> lvendas)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            clientes = lclientes;
            funcionarios = lfuncionarios;
            produtos = lprodutos;
            vendas = lvendas;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            txt_nomefuncionario.Clear();
            mask_cpffuncionario.Clear();
            txt_rgfuncionario.Clear();
            txt_ctpsfuncionario.Clear();
            txt_cargahoraria.Clear();
            txt_cargofuncionario.Clear();
            txt_salario.Clear();
            mask_telefonefuncionario.Clear();
            txt_usuariofuncionario.Clear();
            txt_senhafuncionario.Clear();
            txt_emailfuncionario.Clear();
            txt_enderecofuncionario.Clear();
        }

        private void CadastrarFunc_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            
            Funcionario funcionario = new Funcionario();
            funcionario.FuncionarioID = ((funcionarios.Last().FuncionarioID)+1);
            funcionario.Nome = txt_nomefuncionario.Text;
            funcionario.CPF = mask_cpffuncionario.Text;
            funcionario.RG = txt_rgfuncionario.Text;
            funcionario.CTPS = txt_ctpsfuncionario.Text;
            funcionario.Cargo = txt_cargofuncionario.Text;
            funcionario.CargaHoraria = txt_cargahoraria.Text;
            funcionario.Salario = Convert.ToDouble(txt_salario.Text);
            funcionario.Telefone = mask_telefonefuncionario.Text;
            funcionario.Email= txt_emailfuncionario.Text;
            funcionario.Endereco = txt_enderecofuncionario.Text;
            funcionario.Usuario = txt_usuariofuncionario.Text;
            funcionario.Senha = txt_senhafuncionario.Text;

            funcionarios.Add(funcionario);

        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuF menu = new MenuF(clientes, funcionarios, produtos, vendas);
            menu.ShowDialog();
        }
    }
}
