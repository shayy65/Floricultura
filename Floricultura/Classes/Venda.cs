using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floricultura.classes
{
    internal class Venda
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Quantidade { get; set; }
        public double Valor { get; set; }
        public double Desconto { get; set; }
        public double Valorfinal { get; set; }
        public DateTime Data { get; set; }
        public string FormaPagamento { get; set; }
        
        public Venda()
        {

        }

        public Venda(int id, string descricao, double quantidade, double valor,double desconto,double valorfinal, DateTime data, string formapagamento)
        {
            Id = id;
            Descricao = descricao;
            Quantidade = quantidade;
            Valor = valor;
            Desconto = desconto;
            Valorfinal = valorfinal;
            Data = data;
            FormaPagamento= formapagamento;
        }


    }
}
