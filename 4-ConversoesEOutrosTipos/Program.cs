using System;
class Programa
{
    static void Main(string[] args)
    {
        double salario;
        salario = 3000.15;
        // int salarioInteiro = salario;   Não compila, pois um inteiro não recebe um double
        int salarioInteiro = (int)salario; // Compila, pois Converte tipo double para inteiro
        
        // O long é um tipo de variável de 64 bits
        long x;
        x = 2000000000000000000;

        short y;//o short é um variável de 32 bits
        y = 15000;

        float altura;
        altura = 1.62f; //utiliza-se o f para dizer ao compilador que estamos cientes da perca de precição ao usar o float

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
