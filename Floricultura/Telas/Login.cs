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
        
        public Login()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarFunc fun = new CadastrarFunc();
            Menu menu = new Menu();
            

            string usuariologin = txt_usuario.Text;
            string senhalogin = txt_senha.Text;

            if(fun.Verificarusuario(usuariologin, senhalogin) == true)
            {
                MessageBox.Show("Sim");
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("nao");
            }
           
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
