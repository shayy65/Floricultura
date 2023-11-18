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
    public partial class Venda : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Funcionario> funcionarios = new List<Funcionario>();
        List<Produto> produtos = new List<Produto>();
        List<VendaF> vendas = new List<VendaF>();
        public Venda(List<Cliente> lclientes, List<Funcionario> lfuncionarios, List<Produto> lprodutos, List<VendaF> lvendas)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            clientes = lclientes;
            funcionarios = lfuncionarios;
            produtos = lprodutos;
            vendas = lvendas;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_finalizar_Click(object sender, EventArgs e)
        {
            VendaF venda = new VendaF();
            venda.Id= ((vendas.Last().Id) + 1);
            venda.Descricao = txt_descricao.Text;
            venda.Quantidade = Convert.ToInt32(txt_quantidade.Text);
            venda.Desconto = Convert.ToDouble(txt_desconto.Text);
            venda.FormaPagamento = cbox_formapag.Text;

            bool validar = true;
            foreach(var produto in produtos)
            {
                if (Convert.ToInt32(txt_quantidade.Text) <= produto.Quantidade)
                {
                    validar = false;
                    produto.Quantidade -= Convert.ToInt32(txt_quantidade.Text);
                    venda.Data = Convert.ToDateTime(mask_datahora.Text);
                    venda.Valor = Convert.ToDouble(txt_valor.Text) * venda.Quantidade;
                    double calculo = (venda.Desconto / 100) * venda.Valor;
                    venda.Valorfinal = calculo - venda.Valor;

                    txt_valorfinal.Text = Convert.ToString(venda.Valorfinal);
                    vendas.Add(venda);

                    dataGrid_venda.DataSource = null;
                    dataGrid_venda.Refresh();
                    dataGrid_venda.DataSource = vendas;
                    MessageBox.Show(produto.Quantidade.ToString());
                }
            }
            if(validar)
            {
                MessageBox.Show("Quantidade insuficiente no estoque");
            }

        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            txt_ID.Clear();
            txt_nome.Clear();
            txt_quantidade.Clear();
            txt_valor.Clear();
            txt_valorfinal.Clear();
            txt_desconto.Clear();
            txt_descricao.Clear();
            mask_datahora.Clear();
            cbox_formapag.SelectedIndex = -1;
        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {
            bool validar = true;
            foreach (var produo in produtos)
            {
                if (Convert.ToInt32(txt_ID.Text) == produo.IdProduto)
                {
                    validar = false;
                    txt_nome.Text = produo.Nome;
                    txt_valor.Text = produo.Valorvenda.ToString();
                }
            }
            if (validar)
            {
                MessageBox.Show("Produto não encontrado.");
            }
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuF menu = new MenuF(clientes, funcionarios, produtos, vendas);
            menu.ShowDialog();
        }
    }
}
