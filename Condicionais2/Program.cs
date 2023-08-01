using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool grupo = true;

        // if (idadeJoao >= 18 || grupo)

        // if (idadeJoao >= 18 && quantidadePessoas > 1) // operador condicional E

        if (idadeJoao >= 18 || quantidadePessoas >1)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
               Console.WriteLine("Não pode entrar!");
            }
                

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
