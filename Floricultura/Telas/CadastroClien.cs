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
        public CadastroClien()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            
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
            cliente.ClienteID = Convert.ToInt32(txt_idcliente.Text);
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
            txt_idcliente.Clear();
            txt_cpfcliente.Clear();
            txt_emailcliente.Clear();
            txt_enderecocliente.Clear();
            txt_telefonecliente.Clear();
        }
    }
}
