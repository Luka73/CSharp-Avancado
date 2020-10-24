using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Entities
{
    public class Cliente : Pessoa
    {
        #region Atributos
        private int idCliente;
        private string email;
        private string telefone;
        private Endereco endereco;
        #endregion

        #region Construtores
        public Cliente()
        {

        }
        public Cliente(int idCliente, string email, string telefone, Endereco endereco)
        {
            this.idCliente = idCliente;
            this.email = email;
            this.telefone = telefone;
            this.endereco = endereco;
        }
        #endregion

        #region Encapsulamentos
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public Endereco Endereco { get => endereco; set => endereco = value; }
        #endregion
    }
}
