using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floricultura
{
    public class VendaF
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public double Desconto { get; set; }
        public double Valorfinal { get; set; }
        public string FormaPagamento { get; set; }
        public DateTime Data { get; set; }

        public VendaF() 
        { 

        }

        public VendaF(int id,string descricao, int quantidade, double valor, double desconto, double valorfinal, string formapagamento, DateTime data)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Quantidade = quantidade;
            this.Valor = valor;
            this.Desconto = desconto;
            this.Valorfinal = valorfinal;
            this.FormaPagamento= formapagamento;
            this.Data = data;
        }

    }
}
