using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");
        char letra = 'a'; //tipo char armazena somente uma letra ou um cacarter especial
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65+1);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Cursos de tecnologia";
        Console.WriteLine(primeiraFrase);
               
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' '; //tipo char recebe um espaço

        string cursos = @"Cursos disponíveis: " +
            "- Go " +
            "- C# " +
            "- Python " +
            " - Java";
        Console.WriteLine(cursos);


        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
