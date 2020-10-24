using Aula03.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Input
{
    public class EnderecoInput
    {
        public static int LerId()
        {
            Console.Write("Informe o código do endereço...........: ");
            return int.Parse(Console.ReadLine());
        }

        public static string LerLogradouro()
        {
            Console.Write("Informe o logradouro...................: ");
            return Console.ReadLine();
        }

        public static string LerBairro()
        {
            Console.Write("Informe o bairo........................: ");
            return Console.ReadLine();
        }

        public static string LerCidade()
        {
            Console.Write("Informe a cidade.......................: ");
            return Console.ReadLine();
        }

        public static string LerEstado()
        {
            Console.Write("Informe o estado.......................: ");
            return Console.ReadLine();
        }

        public static string LerCep()
        {
            Console.Write("Informe o CEP..........................: ");
            return Console.ReadLine();
        }

        public static Endereco GetEndereco()
        {
            Endereco e = new Endereco();
            e.Logradouro = EnderecoInput.LerLogradouro();
            e.Bairro = EnderecoInput.LerBairro();
            e.Cidade = EnderecoInput.LerCidade();
            e.Estado = EnderecoInput.LerEstado();
            e.Cep = EnderecoInput.LerCep();
            return e;
        }
    }
}
