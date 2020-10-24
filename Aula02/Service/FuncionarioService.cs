using Aula02.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Aula02.Service
{
    public class FuncionarioService
    {
        private string path = "C:\\Users\\Luana\\source\\repos\\CSharpAvancado\\Aula02\\Persistence\\";

        //método para exportar os dados do funcionário para arquivo de extensão .TXT
        public void ExportarParaTxt(Funcionario funcionario)
        {

            if (!Directory.Exists(path)) //verificar se a pasta não existe
            {
                Directory.CreateDirectory(path);  //criando a pasta
            }

            //abrindo o arquivo em modo de escrita.
            using (StreamWriter writer = new StreamWriter(path + "funcionario.txt", true))
            {
                writer.WriteLine("DADOS DO FUNCIONÁRIO:\n");

                writer.WriteLine("Código...........: " + funcionario.IdFuncionario);
                writer.WriteLine("Nome.............: " + funcionario.Nome);
                writer.WriteLine("Salário..........: " + funcionario.Salario);
                writer.WriteLine("Data de Admissão.: " + funcionario.DataAdmissao);
            }
        }


        public string LerArquivoTxt()  //método para ler o conteudo do arquivo
        {
            using (StreamReader streamReader = new StreamReader(path + "funcionario.txt"))
            {
                string conteudo = streamReader.ReadToEnd();  //ler o texto contido no arquivo
                return conteudo; //retornando a variavel
            }
        }

        public void ExportarParaXml(Funcionario funcionario)
        {
            if (!Directory.Exists(path)) //verificar se a pasta não existe
            {
                Directory.CreateDirectory(path);  //criando a pasta
            }

            XDocument doc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));
            XElement root = new XElement("funcionarios");

            XElement child = new XElement("funcionario");
            child.Add(new XElement("idFuncionario", funcionario.IdFuncionario));
            child.Add(new XElement("nome", funcionario.Nome));
            child.Add(new XElement("salario", funcionario.Salario));
            child.Add(new XElement("dataAdmissao", funcionario.DataAdmissao));

            root.Add(child);

            if (File.Exists(path + "funcionario.xml"))
            {
                doc = XDocument.Load(path + "funcionario.xml");
                var result = doc.Descendants("funcionarios");
                result.Last().Add(child);
            } else
            {
                doc.Add(root);
            }

            doc.Save(path + "funcionario.xml");
        }

        public List<Funcionario> LerArquivoXml() 
        {
            XDocument xdoc = XDocument.Load(path + "funcionario.xml");

            var result = from q in xdoc.Descendants("funcionario")
                         select new
                         {
                             IdFuncionario = q.Element("idFuncionario").Value,
                             Nome = q.Element("nome").Value,
                             Salario = q.Element("salario").Value,
                             DataAdmissao = q.Element("dataAdmissao").Value
                         };

            List<Funcionario> list = new List<Funcionario>();
            foreach (var f in result)
            {
                Funcionario func = new Funcionario(
                                        int.Parse(f.IdFuncionario),
                                        f.Nome,
                                        decimal.Parse(f.Salario),
                                        DateTime.Parse(f.DataAdmissao));
                list.Add(func);
            }

            return list;
        }

        public void ExportarParaJson(Funcionario funcionario)
        {
            if (!Directory.Exists(path)) //verificar se a pasta não existe
            {
                Directory.CreateDirectory(path);  //criando a pasta
            }

            using (StreamWriter sw = new StreamWriter(path + "funcionario.json", true))
            {
                //converter os dados do Funcionario para JSON
                string dados = JsonConvert.SerializeObject(funcionario, Newtonsoft.Json.Formatting.Indented);
                sw.WriteLine(dados); //escrever no arquivo
            }
        }

        public List<Funcionario> LerArquivoJson()
        {
            using (StreamReader sw = new StreamReader(path + "funcionario.json"))
            {
                string json = sw.ReadToEnd();
                List<Funcionario> funcionarios = JsonConvert.DeserializeObject<List<Funcionario>>(json);
                return funcionarios;
            }
        }
    }
}
