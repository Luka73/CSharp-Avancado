using Aula02.Entity;
using Aula02.Input;
using Aula02.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            try //tentativa
            {
                /*Funcionario funcionario = new Funcionario();

                Console.WriteLine("\n - CADASTRO DE FUNCIONÁRIOS - \n");

                funcionario.IdFuncionario = FuncionarioInput.LerIdFuncionario();
                funcionario.Nome = FuncionarioInput.LerNome();
                funcionario.Salario = FuncionarioInput.LerSalario();
                funcionario.DataAdmissao = FuncionarioInput.LerDataAdmissao();

                Console.WriteLine("\n - DADOS DO FUNCIONÁRIO - \n");
                Console.WriteLine("Código...........: " + funcionario.IdFuncionario);
                Console.WriteLine("Nome.............: " + funcionario.Nome);
                Console.WriteLine("Salário..........: " + funcionario.Salario);
                Console.WriteLine("Data de Admissão.: " + funcionario.DataAdmissao);

                //instanciando a classe FuncionarioService
                FuncionarioService service = new FuncionarioService();
                service.ExportarParaTxt(funcionario);
                service.ExportarParaXml(funcionario);
                service.ExportarParaJson(funcionario);

                Console.WriteLine("\nArquivoss gravados com sucesso.");*/

                FuncionarioService service = new FuncionarioService();
                List<Funcionario> list = service.LerArquivoXml();
                //string conteudo = service.LerArquivoTxt();
                //Console.WriteLine(conteudo);
                Console.WriteLine("teste");
            }
            catch (Exception e) //captura da exceção
            {
                Console.WriteLine("\nErro: " + e.Message);
            }

            Console.ReadKey(); //pausar
        }

    }
}
