using cxbank_ADM.Funcionarios;
using cxbank_ADM.ParceriaComercial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cxbank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if(usuarioAutenticado == true)
            {
                Console.WriteLine("Bem Vindo ao Sistema. ");
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta! ");
                return false;
            }
        }

    }
}
