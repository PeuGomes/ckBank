using cxbank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cxbank_ADM.SistemaInterno
{
    public interface IAutenticavel
    {
        public bool Autenticar(string senha);
        

    }
}
