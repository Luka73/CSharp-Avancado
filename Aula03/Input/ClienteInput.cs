using Aula03.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Input
{
    public class ClienteInput
    {
        public static int LerId()
        {
            Console.Write("Informe o código do Cliente............: ");
            return int.Parse(Console.ReadLine());
        }
        public static string LerNome()
        {
            Console.Write("Informe o nome do cliente..............: ");
            return Console.ReadLine();
        }

        public static DateTime LerDataNascimento()
        {
            Console.Write("Informe a data de nascimento...........: ");
            return DateTime.Parse(Console.ReadLine());
        }

        public static string LerEmail()
        {
            Console.Write("Informe o email........................: ");
            return Console.ReadLine();
        }

        public static string LerTelefone()
        {
            Console.Write("Informe o telefone.....................: ");
            return Console.ReadLine();
        }

        public static Cliente GetCliente()
        {
            Cliente c = new Cliente();
            c.Nome = LerNome();
            c.DataNascimento = LerDataNascimento();
            c.Email = LerEmail();
            c.Telefone = LerTelefone();
            return c;
        }

        public static Cliente GetClienteEndereco()
        {
            Cliente c = GetCliente();
            c.Endereco = EnderecoInput.GetEndereco();
            return c;
        }
    }
}
