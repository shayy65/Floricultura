using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floricultura.classes
{
    public class Cliente
    {
            public int ClienteID { get; set; }
            public string Nome { get; set; }
            public string CPF { get; set; }
            public string Email { get; set; }
            public string Telefone { get; set; }
            public string Endereco { get; set; }

            public Cliente()
            {

            }

            public Cliente(int clienteID, string nome, string email, string telefone, string cpf, string endereco)
            {
                ClienteID = clienteID;
                Nome = nome;
                Email = email;
                Telefone = telefone;
                CPF = cpf;
                Endereco = endereco;
            }

    }
}
