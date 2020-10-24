using Aula03.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Input
{
    public class SetorInput
    {
        public static int LerId()
        {
            Console.Write("Informe o código do setor..............: ");
            return int.Parse(Console.ReadLine());
        }

        public static string LerNome()
        {
            Console.Write("Informe o nome do setor................: ");
            return Console.ReadLine();
        }

        public static Setor GetSetor()
        {
            Setor s = new Setor();
            s.IdSetor = LerId();
            s.Nome = LerNome();
            return s;
        }
    }
}
