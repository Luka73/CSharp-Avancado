using Aula03.Entities;
using Aula03.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Repository
{
    public class ClienteRepository : IBaseRepository<Cliente>
    {
        private string connectionString;

        public ClienteRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings
            ["banco"].ConnectionString;
        }
        public void Insert(Cliente obj)
        {
            string query = "insert into Cliente(Nome, DataNascimento, Email, Telefone) "
                         + "values(@Nome, @DataNascimento, @Email, @Telefone); SELECT SCOPE_IDENTITY()";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", obj.Nome);
                command.Parameters.AddWithValue("@DataNascimento", obj.DataNascimento);
                command.Parameters.AddWithValue("@Email", obj.Email);
                command.Parameters.AddWithValue("@Telefone", obj.Telefone);

                int idCliente = Convert.ToInt32(command.ExecuteScalar());
                if(obj.Endereco != null)
                {
                    obj.Endereco.IdCliente = idCliente;
                    EnderecoRepository enderecoRepository = new EnderecoRepository();
                    enderecoRepository.Insert(obj.Endereco);
                }
            }
        }

        public void Update(Cliente obj)
        {
            string query = "update Cliente set Nome = @Nome, " 
                            + "DataNascimento = @DataNascimento, Email "
                            + "Telefone = @Telefone where IdCliente = @IdCliente";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", obj.Nome);
                command.Parameters.AddWithValue("@DataNascimento", obj.DataNascimento);
                command.Parameters.AddWithValue("@Email", obj.Email);
                command.Parameters.AddWithValue("@Telefone", obj.Telefone);
                command.Parameters.AddWithValue("@IdCliente", obj.IdCliente);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            string query = "delete from Cliente where IdCliente = @IdCliente";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); 
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdCliente", id);
                command.ExecuteNonQuery();
            }
        }

        public List<Cliente> SelectAll()
        {
            string query = "select * from Cliente";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                List<Cliente> lista = new List<Cliente>();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = Convert.ToInt32(reader["IdCliente"]);
                    cliente.Nome = Convert.ToString(reader["Nome"]);
                    cliente.DataNascimento = Convert.ToDateTime(reader["DataNascimento"]);
                    cliente.Email = Convert.ToString(reader["Email"]);
                    cliente.Telefone = Convert.ToString(reader["Telefone"]);
                    lista.Add(cliente);
                }
                return lista;
            }
        }

        public Cliente SelectById(int id)
        {
            string query = "select * from Cliente where IdCliente = @IdCliente";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdCliente", id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = Convert.ToInt32(reader["IdCliente"]);
                    cliente.Nome = Convert.ToString(reader["Nome"]);
                    cliente.DataNascimento = Convert.ToDateTime(reader["DataNascimento"]);
                    return cliente;
                }

                return null; 
            }

        }
    }
}
