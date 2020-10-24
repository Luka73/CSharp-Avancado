using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Entities
{
    public class Funcao
    {
        #region Atributos
        private int idFuncao;
        private string descricao;
        #endregion

        #region Construtores
        public Funcao()
        {

        }
        public Funcao(int idFuncao, string descricao)
        {
            this.idFuncao = idFuncao;
            this.descricao = descricao;
        }
        #endregion

        #region Encapsulamentos
        public int IdFuncao { get => idFuncao; set => idFuncao = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        #endregion
    }
}
