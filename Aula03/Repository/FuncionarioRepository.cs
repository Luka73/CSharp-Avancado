using Aula03.Entities;
using Aula03.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Repository
{
    public class FuncionarioRepository : IBaseRepository<Funcionario>
    {
        public void Insert(Funcionario obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Funcionario obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Funcionario SelectById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
