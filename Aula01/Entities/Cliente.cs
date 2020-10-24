using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Entities
{
    public class Cliente
    {
        private int codigo;
        private string nome;
        private string email;

        public Cliente()
        {

        }

        public Cliente(int codigo, string nome, string email)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.email = email;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
    }
}
