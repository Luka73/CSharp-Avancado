using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Entities
{
    public class Setor
    {
        #region Atributos
        private int idSetor;
        private string nome;
        #endregion

        #region Construtores
        public Setor()
        {

        }
        public Setor(int idSetor, string nome)
        {
            this.idSetor = idSetor;
            this.nome = nome;
        }
        #endregion

        #region Encapsulamentos
        public int IdSetor { get => idSetor; set => idSetor = value; }
        public string Nome { get => nome; set => nome = value; }
        #endregion
    }
}
