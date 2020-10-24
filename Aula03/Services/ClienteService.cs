using Aula03.Entities;
using Aula03.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Services
{
    public class ClienteService : IClienteService
    {
        private static string path = "C:\\Users\\Luana\\source\\repos\\CSharpAvancado\\Aula03\\Arquivos\\";
        private static string arquivoJson = path + "cliente.json";
        public void ExportarArquivoJson(Cliente cliente)
        {
            List<Cliente> clientes = new List<Cliente>();

            if (File.Exists(arquivoJson))
            {
                var result = LerArquivoJson();
                if (result != null)
                    clientes = LerArquivoJson();
            }

            using (StreamWriter sw = new StreamWriter(arquivoJson))
            {
                clientes.Add(cliente);
                string jsonData = JsonConvert.SerializeObject(clientes, Formatting.Indented);
                sw.Write(jsonData);
            }
        }

        public List<Cliente> LerArquivoJson()
        {
            using (StreamReader sw = new StreamReader(arquivoJson))
            {
                string json = sw.ReadToEnd();
                List<Cliente> clientes = JsonConvert.DeserializeObject<List<Cliente>>(json);
                return clientes;
            }
        }
    }
}
