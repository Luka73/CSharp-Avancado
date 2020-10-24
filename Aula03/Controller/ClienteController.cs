using Aula03.Entities;
using Aula03.Input;
using Aula03.Repository;
using Aula03.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Controller
{
    public class ClienteController
    {
        private ClienteService clienteService;
        private ClienteRepository clienteRepository;
        private EnderecoRepository enderecoRepository;


        public ClienteController()
        {
            clienteService = new ClienteService();
            clienteRepository = new ClienteRepository();
            enderecoRepository = new EnderecoRepository();
        }
        public void InserirJson(Cliente cliente)
        {
            clienteService.ExportarArquivoJson(cliente);
        }

        public Cliente GetClienteFromJson(int id)
        {
            List<Cliente> clientes = clienteService.LerArquivoJson();
            Cliente result = (from c in clientes where c.IdCliente == id
                         select c).FirstOrDefault();
            return result;
        }

        public List<Cliente> GetAllClientesFromJson()
        {
            return clienteService.LerArquivoJson();
        }

        public void CadastrarCliente(Cliente cliente)
        {
            Console.WriteLine("\n CADASTRO DE CLIENTE \n");
            clienteRepository.Insert(cliente);
            enderecoRepository.Insert(cliente.Endereco);
            Console.WriteLine("\nCLIENTE CADASTRADO COM SUCESSO.");
        }

        public void AtualizarClinete(Cliente cliente)
        {
            Console.WriteLine("\n ATUALIZAÇÃO DE CLIENTE \n");
            clienteRepository.Update(cliente);
            Console.WriteLine("\nCLIENTE ATUALIZADO COM SUCESSO.");
        }

        public void ExcluirCliente(int id)
        {
            Console.WriteLine("EXCLUSÃO DE CLIENTE");
            clienteRepository.Delete(id);
            Console.WriteLine("CLIENTE EXCLUÍDO COM SUCESSO.");
        }

        public void ConsultarClientes()
        {
            Console.WriteLine("CONSULTAR TODOS OS CLIENTES");
            List<Cliente> lista = clienteRepository.SelectAll();

            foreach (var item in lista)
            {
                Console.WriteLine("Id do Cliente..: " + item.IdCliente);
                Console.WriteLine("Nome...........: " + item.Nome);
                Console.WriteLine("Data Nasc......: " + item.DataNascimento.ToString("dd/MM/yyyy"));

                Endereco endereco = enderecoRepository.SelectByIdCliente(item.IdCliente);
                if (endereco != null)
                {
                    Console.WriteLine("Logradouro.....: " + endereco.Logradouro);
                    Console.WriteLine("Bairro.........: " + endereco.Bairro);
                    Console.WriteLine("Cidade.........: " + endereco.Cidade);
                    Console.WriteLine("Estado.........: " + endereco.Estado);
                    Console.WriteLine("Cep............: " + endereco.Cep);
                }
                Console.WriteLine("*****************************");
            }
        }

        public void ConsultarClientePorId(int id)
        {
            Console.WriteLine("CONSULTAR CLIENTE POR ID");
            Cliente cliente = clienteRepository.SelectById(id);

            if (cliente != null)
            {
                Console.WriteLine("Id do Cliente..: " + cliente.IdCliente);
                Console.WriteLine("Nome...........: " + cliente.Nome);
                Console.WriteLine("Data Nasc......: " + cliente.DataNascimento.ToString("dd/MM/yyyy"));
            }
            else
            {
                Console.WriteLine("\nCLIENTE NÃO FOI ENCONTRADO");
            }
        }
    }
}
