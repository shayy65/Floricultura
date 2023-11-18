using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floricultura.classes
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public string Fornecedor { get; set; }
        public double Lucro { get; set; }
        public double Valorvenda { get; set; }
        
        

        public Produto()
        {

        }

        public Produto(int idproduto, double valor, string nome, string categoria, int quantidade,
        string fornecedor)
        {
            IdProduto = idproduto;
            Valor = valor;
            Nome = nome;
            Categoria = categoria;
            Quantidade = quantidade;
            Fornecedor = fornecedor;
            
        }           
        
    }
}
