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
    public class EnderecoRepository : IBaseRepository<Endereco>
    {
        private readonly string connectionString;

        public EnderecoRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings
            ["banco"].ConnectionString;

        }

        public void Insert(Endereco obj)
        {
            string query = "insert into Endereco(Logradouro, Bairro, Cidade, Estado, " 
                            + "Cep, IdCliente) values(@Logradouro, @Bairro, @Cidade, "
                            + "@Estado, @Cep, @IdCliente)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Logradouro", obj.Logradouro);
                command.Parameters.AddWithValue("@Bairro", obj.Bairro);
                command.Parameters.AddWithValue("@Cidade", obj.Cidade);
                command.Parameters.AddWithValue("@Estado", obj.Estado);
                command.Parameters.AddWithValue("@Cep", obj.Cep);
                command.Parameters.AddWithValue("@IdCliente", obj.IdCliente);
                command.ExecuteNonQuery();
            }
        }

        public void Update(Endereco obj)
        {
            string query = "update Endereco set Logradouro = @Logradouro, "
                + "Bairro = @Bairro, Cidade = @Cidade, Estado = @Estado, "
                + "Cep = @Cep IdCliente = @IdCliente where IdEndereco = @IdEndereco";

            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Logradouro", obj.Logradouro);
                command.Parameters.AddWithValue("@Bairro", obj.Bairro);
                command.Parameters.AddWithValue("@Cidade", obj.Cidade);
                command.Parameters.AddWithValue("@Estado", obj.Estado);
                command.Parameters.AddWithValue("@Cep", obj.Cep);
                command.Parameters.AddWithValue("IdCliente", obj.IdCliente);
                command.Parameters.AddWithValue("@IdEndereco", obj.IdEndereco);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            string query = "delete from Endereco where IdEndereco = @IdEndereco";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdEndereco", id);
                command.ExecuteNonQuery();
            }
        }

        public List<Endereco> SelectAll()
        {
            string query = "select * from Endereco";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                List<Endereco> lista = new List<Endereco>();

                while (reader.Read())
                {
                    Endereco endereco = new Endereco();
                    endereco.IdEndereco = Convert.ToInt32(reader["IdEndereco"]);
                    endereco.Logradouro = Convert.ToString(reader["Logradouro"]);
                    endereco.Bairro = Convert.ToString(reader["Bairro"]);
                    endereco.Cidade = Convert.ToString(reader["Cidade"]);
                    endereco.Estado = Convert.ToString(reader["Estado"]);
                    endereco.Cep = Convert.ToString(reader["Cep"]);
                    endereco.IdCliente = Convert.ToInt32(reader["IdCliente"]);
                    lista.Add(endereco);
                }
                return lista;
            }
        }
        public Endereco SelectById(int id)
        {
            string query = "select * from Endereco where IdEndereco = @IdEndereco";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdEndereco", id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) 
                {
                    Endereco endereco = new Endereco();
                    endereco.IdEndereco = Convert.ToInt32(reader["IdEndereco"]);
                    endereco.Logradouro = Convert.ToString(reader["Logradouro"]);
                    endereco.Bairro = Convert.ToString(reader["Bairro"]);
                    endereco.Cidade = Convert.ToString(reader["Cidade"]);
                    endereco.Estado = Convert.ToString(reader["Estado"]);
                    endereco.Cep = Convert.ToString(reader["Cep"]);
                    endereco.IdCliente = Convert.ToInt32(reader["IdCliente"]);

                    return endereco; 
                }

                return null; 
            }
        }
    
        public Endereco SelectByIdCliente(int id)
        {
            string query = "select * from Endereco where IdCliente = @IdCliente";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdCliente", id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Endereco endereco = new Endereco();
                    endereco.IdEndereco = Convert.ToInt32(reader["IdEndereco"]);
                    endereco.Logradouro = Convert.ToString(reader["Logradouro"]);
                    endereco.Bairro = Convert.ToString(reader["Bairro"]);
                    endereco.Cidade = Convert.ToString(reader["Cidade"]);
                    endereco.Estado = Convert.ToString(reader["Estado"]);
                    endereco.Cep = Convert.ToString(reader["Cep"]);
                    endereco.IdCliente = Convert.ToInt32(reader["IdCliente"]);
                    return endereco;
                }

                return null;
            }
        }
    }
}
