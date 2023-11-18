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
    public partial class CadastrarProd : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Funcionario> funcionarios = new List<Funcionario>();
        List<Produto> produtos = new List<Produto>();
        List<VendaF> vendas = new List<VendaF>();
        public CadastrarProd(List<Cliente> lclientes, List<Funcionario> lfuncionarios, List<Produto> lprodutos, List<VendaF> lvendas)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            clientes = lclientes;
            funcionarios = lfuncionarios;
            produtos = lprodutos;
            vendas = lvendas;

        }

        private void txt_categoriaproduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_quantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
          
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            txt_nomeproduto.Clear();
            txt_categoriaproduto.Clear();
            txt_valorcomprado.Clear();
            txt_fonecedor.Clear();
            txt_lucro.Clear();
            txt_quantidade.Clear();
            txt_valorfinal.Clear();
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.IdProduto = ((produtos.Last().IdProduto) + 1);
            produto.Nome = txt_nomeproduto.Text;
            produto.Categoria = txt_categoriaproduto.Text;
            produto.Quantidade = Convert.ToInt32(txt_quantidade.Text);
            produto.Fornecedor = txt_fonecedor.Text;
            produto.Valor = Convert.ToDouble(txt_valorcomprado.Text);
            produto.Lucro = Convert.ToDouble(txt_lucro.Text);
            double calculo = (produto.Lucro / 100) * produto.Valor;
            produto.Valorvenda = calculo + produto.Valor;
            txt_valorfinal.Text = Convert.ToString(produto.Valorvenda);

            produtos.Add(produto);

        }

        private void bt_voltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuF menu = new MenuF(clientes, funcionarios, produtos, vendas);
            menu.ShowDialog();
        }
    }
}
