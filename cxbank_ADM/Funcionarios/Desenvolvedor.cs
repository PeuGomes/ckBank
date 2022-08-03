﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cxbank_ADM.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(cpf, 3500)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 0.10;
        }

        public override double getBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
