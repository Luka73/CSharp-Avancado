using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Entities
{
    public class Funcionario : Pessoa
    {
        #region Atributos
        private int idFuncionario;
        private string cpf;
        private decimal salario;
        private Setor setor;
        private List<Funcao> funcoes;
        #endregion

        #region Construtores
        public Funcionario()
        {

        }
        public Funcionario(int idFuncionario, string cpf, decimal salario, Setor setor, List<Funcao> funcoes)
        {
            this.idFuncionario = idFuncionario;
            this.cpf = cpf;
            this.salario = salario;
            this.setor = setor;
            this.funcoes = funcoes;
        }
        #endregion

        #region Encapsulamentos
        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public decimal Salario { get => salario; set => salario = value; }
        public Setor Setor { get => setor; set => setor = value; }
        public List<Funcao> Funcoes { get => funcoes; set => funcoes = value; }
        #endregion
    }
}
