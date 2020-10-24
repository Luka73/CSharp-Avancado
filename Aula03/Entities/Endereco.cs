using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Entities
{
    public class Endereco
    {
        #region Atributos
        private int idEndereco;
        private string logradouro;
        private string bairro;
        private string cidade;
        private string estado;
        private string cep;
        private int idCliente;
        #endregion

        #region Construtores
        public Endereco()
        {

        }

        public Endereco(int idEndereco, string logradouro, string bairro, string cidade, string estado, string cep, int idCliente)
        {
            this.idEndereco = idEndereco;
            this.logradouro = logradouro;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
            this.idCliente = idCliente;
        }
        #endregion

        #region Encapsulamentos
        public int IdEndereco { get => idEndereco; set => idEndereco = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cep { get => cep; set => cep = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        #endregion
    }
}
