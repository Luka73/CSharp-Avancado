using Aula03.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Aula03.Interfaces;

namespace Aula03.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        private static string path = "C:\\Users\\Luana\\source\\repos\\CSharpAvancado\\Aula03\\Arquivos\\";
        private static string arquivoJson = path + "funcionario.json";
        public void ExportarArquivoJson(Funcionario funcionario)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            if (File.Exists(arquivoJson))
            {
                var result = LerArquivoJson();
                if (result != null)
                    funcionarios = LerArquivoJson();
            }

            using (StreamWriter sw = new StreamWriter(arquivoJson, true))
            {
                funcionarios.Add(funcionario);
                string jsonData = JsonConvert.SerializeObject(funcionarios, Formatting.Indented);
                sw.Write(jsonData);
            }
        }

        public List<Funcionario> LerArquivoJson()
        {
            using (StreamReader sw = new StreamReader(arquivoJson))
            {
                string json = sw.ReadToEnd();
                List<Funcionario> funcionarios = JsonConvert.DeserializeObject<List<Funcionario>>(json);
                return funcionarios;
            }
        }
    }

    
}
