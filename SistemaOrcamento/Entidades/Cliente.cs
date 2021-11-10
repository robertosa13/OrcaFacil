using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOrcamento.Entidades
{
    public class Cliente
    {
        int id_cliente;
        string nome;
        string email;
        string cpf;
        string endereco;

     
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
    }
}
