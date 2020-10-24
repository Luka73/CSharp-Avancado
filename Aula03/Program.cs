using Aula03.Controller;
using Aula03.Entities;
using Aula03.Input;
using Aula03.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Inserir();

                /*FuncionarioService fs = new FuncionarioService();
                List<Funcionario> funcionarios = fs.LerArquivoJson();


                foreach(Funcionario f in funcionarios)
                {
                    Console.WriteLine(f.Nome + " possui as seguintes funções: ");
                    foreach(Funcao funcao in f.Funcoes)
                    {
                        Console.WriteLine(" - " + funcao.Descricao);
                    }
                    Console.WriteLine("*******************");
                }*/

                ClienteController cc = new ClienteController();
                //Cliente c = ClienteInput.GetClienteEndereco();
                //cc.CadastrarCliente(c);
                cc.ExcluirCliente(1);
                cc.ConsultarClientes();
                

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            

            Console.ReadKey();
        }

        public static void Inserir()
        {
            Console.WriteLine(" - Informações do Cliente - ");
            Cliente c = ClienteInput.GetClienteEndereco();

            Console.WriteLine("\n - Informações do Funcionário - ");
            Funcionario f = FuncionarioInput.GetFuncionarioSetor();

            Console.WriteLine("Informe as funções do Funcionário......: ");
            List<Funcao> funcoes = new List<Funcao>();

            while (true)
            {
                Funcao funcao = FuncaoInput.GetFuncao();
                funcoes.Add(funcao);
                Console.Write("Deseja inserir mais funções para este Funcionário? [S/N] ");
                string resposta = Console.ReadLine().ToUpper();
                if (resposta.Equals("N")) break;
            }

            f.Funcoes = funcoes;
            FuncionarioService fs = new FuncionarioService();
            fs.ExportarArquivoJson(f);
            ClienteService cs = new ClienteService();
            cs.ExportarArquivoJson(c);

            Console.WriteLine("\nInformações salvas com sucesso!");
        }
    }
}
