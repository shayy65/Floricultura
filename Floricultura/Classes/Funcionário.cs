using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Floricultura.classes
{
    public class Funcionario
    {
        public int FuncionarioID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string CTPS { get; set; }
        public string Cargo { get; set; }
        public string CargaHoraria { get; set; }
        public double Salario { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(int funcionarioID, string nome, string cpf, string rg, string ctps, string cargo, string cargahoraria, double salario, string email, string telefone, string endereco, string usuario, string senha)
        {
            FuncionarioID = funcionarioID;
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
            CargaHoraria = cargahoraria;
            CPF = cpf;
            Endereco = endereco;
            Email = email;
            Telefone = telefone;
            RG = rg;
            CTPS = ctps;
            Usuario = usuario;
            Senha = senha;
        }

        
        
    }
}