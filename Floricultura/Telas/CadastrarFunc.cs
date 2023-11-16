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
        List<Funcionario> funcionarios = new List<Funcionario>();
        Login login = new Login();
        public CadastrarFunc()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        
        
        public bool Verificarusuario(string usuariologin, string senhalogin)
        {
            Funcionario adm = new Funcionario();
            adm.Usuario = "administrador";
            adm.Senha = "senha";

            funcionarios.Add(adm);

            foreach (var funcionario in funcionarios)
            {
                if (usuariologin == funcionario.Usuario && senhalogin == funcionario.Senha)
                {
                    return true; 
                }
                
            }
            return false;
            
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
            txt_idfuncionario.Clear();
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
            funcionario.FuncionarioID = Convert.ToInt32(txt_idfuncionario.Text);
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

            foreach(Funcionario f in funcionarios)
            {
                MessageBox.Show($"{f.Nome}");
            }
           


            
        }

    }
}
