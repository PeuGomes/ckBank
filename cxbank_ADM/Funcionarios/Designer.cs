using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cxbank_ADM.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 3500)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }

        public override double getBonificacao()
        {
            return Salario * 0.17;
        }
    }
}