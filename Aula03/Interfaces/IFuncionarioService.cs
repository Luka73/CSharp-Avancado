using Aula03.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Interfaces
{
    public interface IFuncionarioService
    {
        void ExportarArquivoJson(Funcionario funcionario);
        List<Funcionario> LerArquivoJson();
    }
}
