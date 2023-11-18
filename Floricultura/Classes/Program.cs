using Floricultura.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floricultura
{
    public static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Cliente> clientes = new List<Cliente>();
            List<Funcionario> funcionarios = new List<Funcionario>();
            Funcionario adm = new Funcionario();
            adm.Usuario = "administrador";
            adm.Senha = "senha";
            funcionarios.Add(adm);

            List<Produto> produtos= new List<Produto>();
            Produto produto = new Produto();
            produtos.Add(produto);
            List<VendaF> vendas= new List<VendaF>();
            VendaF venda = new VendaF();
            vendas.Add(venda);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio(clientes, funcionarios, produtos, vendas));
            
            
        }
    }
}
