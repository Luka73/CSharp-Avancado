using Aula03.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Input
{
    public class FuncaoInput
    {
        public static int LerId()
        {
            Console.Write("Informe o código da função.............: ");
            return int.Parse(Console.ReadLine());
        }

        public static string LerDescricao()
        {
            Console.Write("Informe a descrição da função..........: ");
            return Console.ReadLine();
        }

        public static Funcao GetFuncao()
        {
            Funcao f = new Funcao();
            f.IdFuncao = LerId();
            f.Descricao = LerDescricao();
            return f;
        }
    }
}
