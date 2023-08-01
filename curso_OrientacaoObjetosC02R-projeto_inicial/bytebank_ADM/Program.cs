
using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;
using System.Runtime.CompilerServices;

Console.WriteLine("Projeto Inicial");

#region
//Funcionario pedro = new Funcionario("123456789");
//pedro.Nome = "Pedro Malazarte";
//pedro.Cpf = "123456789";
//pedro.Salario = 2000;

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor ("987654321");
//roberta.Nome = "Roberta Silva";
////roberta.Cpf = "987654321";
////roberta.Salario = 5000;

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
////gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);


////Funcionario andre = new Funcionario();
////andre.Nome = "Andre";
////andre.Cpf = "546.879.157-20";
////andre.Salario = 2000;

////Diretor maria = new Diretor();
////maria.Nome = "Maria";
////maria.Cpf = "454.658.148-3";
////maria.Salario = 5000;

////gerenciador.Registrar(maria);
////gerenciador.Registrar(andre);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);

//Console.WriteLine( "Total de funcionários: " + Funcionario.TotalDeFuncionarios );

////pedro.AumentarSalario();
//roberta.AumentarSalario();

////Console.WriteLine("Novo Salário do Pedro: " +pedro.Salario);
//Console.WriteLine("Novo Salário da Roberta: " + roberta.Salario)
#endregion

//CalculaBonificação();

//CalculaBonificação()
/*
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
    Designer ulisses = new Designer("123456");
    ulisses.Nome = "Ulises Souza";

    Diretor paula = new Diretor("987456");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("74581");
    igor.Nome = "Igor Dias";

    GerenteDeConta camila = new GerenteDeConta("852654");
    camila.Nome = "Camila Olivveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);

    Console.WriteLine("Total de Bonificação: " + gerenciador.TotalDeBonificacao);
    */
UsarSistema();
    void UsarSistema()
    {
        SistemaInterno sistemas = new SistemaInterno();

        Diretor Ingrid = new Diretor("852741");
        Ingrid.Nome = "Ingrid Novaes";
        Ingrid.Senha = "123";

    GerenteDeContas Ursula = new GerenteDeContas("546789");
            Ursula.Nome = "Ursula Alcantara";
            Ursula.Senha = "321";

    //    Auxiliar henrique = new Auxiliar("857914");
    //    henrique.Nome = "Henrique Silva";
    //    henrique.Senha = "852";

    //    Designer clovis = new Designer("951753");
    //clovis.Nome = "Clovis Santos";
    //    clovis.Senha = "654";
    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = ("999");

    
    sistemas.Logar(Ingrid, "123");
    sistemas.Logar(Ursula, "963");
    sistemas.Logar(caio, "999");
    //sistemas.Logar(henrique,"963");
    //sistemas.Logar(clovis, "963");

}
