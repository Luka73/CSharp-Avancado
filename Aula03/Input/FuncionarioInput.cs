using Aula03.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Input
{
    public class FuncionarioInput
    {
        public static int LerId()
        {
            Console.Write("Informe o código do Funcionario........: ");
            return int.Parse(Console.ReadLine());
        }
        public static string LerNome()
        {
            Console.Write("Informe o nome do funcionário..........: ");
            return Console.ReadLine();
        }

        public static DateTime LerDataNascimento()
        {
            Console.Write("Informe a data de nascimento...........: ");
            return DateTime.Parse(Console.ReadLine());
        }

        public static string LerCpf()
        {
            Console.Write("Informe o CPF..........................: ");
            return Console.ReadLine();
        }
        public static decimal LerSalario()
        {
            Console.Write("Informe o salário......................: ");
            return decimal.Parse(Console.ReadLine());
        }

        public static Funcionario GetFuncionario()
        {
            Funcionario f = new Funcionario();
            f.IdFuncionario = LerId();
            f.Nome = LerNome();
            f.DataNascimento = LerDataNascimento();
            f.Cpf = LerCpf();
            f.Salario = LerSalario();
            return f;
        }

        public static Funcionario GetFuncionarioSetor()
        {
            Funcionario f = GetFuncionario();
            Setor s = SetorInput.GetSetor();
            f.Setor = s;
            return f;
        }
    }
}
