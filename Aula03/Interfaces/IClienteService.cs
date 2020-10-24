using Aula03.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Interfaces
{
    public interface IClienteService
    {
        void ExportarArquivoJson(Cliente cliente);
        List<Cliente> LerArquivoJson();
    }
}
