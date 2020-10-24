using Aula01.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Services
{
    public class ClienteService
    {
        public void GravarArquivo(Cliente cliente)
        {
            string path = "C:\\Users\\Luana\\source\\repos\\CSharpAvancado\\Aula01\\Persistence\\clientes.txt";

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("Código...: " + cliente.Codigo);
                sw.WriteLine("Nome.....: " + cliente.Nome);
                sw.WriteLine("Email....: " + cliente.Email);
                sw.WriteLine("********************************");
                sw.WriteLine("\n");
            }
        }
    }
}
