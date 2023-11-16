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
        List<Produto> produtos = new List<Produto>();
        public CadastrarProd()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
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
            txt_idproduto.Clear();
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
            produto.Id = Convert.ToInt32(txt_idproduto.Text);
            produto.Nome = txt_nomeproduto.Text;
            produto.Categoria = txt_categoriaproduto.Text;
            produto.Quantidade = Convert.ToInt32(txt_quantidade.Text);
            produto.Valor = Convert.ToDouble(txt_valorcomprado.Text);
            produto.Fornecedor = txt_fonecedor.Text;
            produto.Lucro = Convert.ToDouble(txt_lucro.Text);
            produto.Valorvenda = Convert.ToDouble(txt_valorfinal.Text);

            produtos.Add(produto);

        }
    }
}
