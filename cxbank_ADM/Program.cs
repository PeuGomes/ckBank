using cxbank_ADM.Funcionarios;
using cxbank_ADM.ParceriaComercial;
using cxbank_ADM.SistemaInterno;
using cxbank_ADM.Utilitario;


//CalcularBonificacao();
UsarSistema();
//Console.WriteLine("Seja Bem-Vindo ao Cxbank Administração! \n");


Console.WriteLine("\n");

//Console.WriteLine("### Calculando Bonificação ###");

/*
static void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciadorBonificacao = new GerenciadorDeBonificacao();

    Designer pedro = new Designer("833.222.048-39");
    pedro.Nome = "Pedro";

    Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20");
    guilherme.Nome = "Guilherme";

    Diretor roberta = new Diretor("159.753.398-04");
    roberta.Nome = "Roberta";

    Auxiliar igor = new Auxiliar("981.198.778-53");
    igor.Nome = "Igor";

    GerenteDeContas camila = new GerenteDeContas("326.985.628-89");
    camila.Nome = "Camila";

    gerenciadorBonificacao.Registrar(guilherme);
    gerenciadorBonificacao.Registrar(pedro);
    gerenciadorBonificacao.Registrar(roberta);
    gerenciadorBonificacao.Registrar(igor);
    gerenciadorBonificacao.Registrar(camila);

    Console.WriteLine("Total de bonificações do mês " + gerenciadorBonificacao.getBonificacao());
}
*/

void UsarSistema()
{
    SistemaInterno sistemainterno = new SistemaInterno();

    Diretor paulo = new Diretor("143.567.234-05");
    paulo.Nome = "Paulo";
    paulo.Senha = "267";

    GerenteDeContas claudia = new GerenteDeContas("456.123.342-09");
    claudia.Nome = "Claudia";
    claudia.Senha = "369";

    ParceiroComercial ana = new ParceiroComercial();
    ana.Senha = "456";

    sistemainterno.Logar(paulo, "267");
    sistemainterno.Logar(claudia, "369");
    sistemainterno.Logar(ana, "456");
}

Console.ReadKey();