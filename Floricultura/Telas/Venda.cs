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
        public Venda()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_finalizar_Click(object sender, EventArgs e)
        {

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
            txt_formapagamento.Clear();
        }
    }
}
