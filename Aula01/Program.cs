using Aula01.Entities;
using Aula01.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o código do cliente: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome do cliente: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o email do cliente: ");
            string email = Console.ReadLine();

            Cliente c1 = new Cliente(codigo, nome, email);

            ClienteService cs = new ClienteService();
            cs.GravarArquivo(c1);

            Console.WriteLine("\nArquivo gravado com sucesso!");
            Console.ReadKey();
        }
    }
}
