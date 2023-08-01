using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Testa Ponto Flutuante");

        double salario = 3000.10;

        Console.WriteLine(salario);
        Console.WriteLine("meu salario é " + salario);

        //int valor = 12.5;             // não compila.
        //Console.WriteLine(valor);

        //int valor2 = 0.0;
        // não compila.
        //Console.WriteLine(valor2);

        double teste = 125.50;        // compila
        Console.WriteLine(teste);
            
        //int valor3 = teste;          // não compila.
        //Console.WriteLine(teste);



    }
}