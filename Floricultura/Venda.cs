using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floricultura
{
    public class Venda
    {
        public int IdVenda { get; set; }
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

        public Venda(int idvenda, string descricao, double quantidade, double valor, double desconto, double valorfinal, DateTime data, string formapagamento)
        {
            IdVenda = idvenda;
            Descricao = descricao;
            Quantidade = quantidade;
            Valor = valor;
            Desconto = desconto;
            Valorfinal = valorfinal;
            Data = data;
            FormaPagamento = formapagamento;
        }
    }
}
