using System;

class Program
{
    static void Main(string[] args)
    {
        // Definindo tamanhos 
        int tamanhoTriangulo = 6;
        int tamanhoCubo = 5;
        int tamanhoLosango = 4;

        //Chamando as funções para desenhar as formas
        Console.WriteLine("--- Triângulo ---");
        DesenharTriangulo(tamanhoTriangulo);

        Console.WriteLine("\n--- Cubo ---");
        DesenharCubo(tamanhoCubo);

        Console.WriteLine("\n--- Losango ---");
        DesenharLosango(tamanhoLosango);
    }

    // Desenhando o Triângulo:
    static void DesenharTriangulo(int linhas)
    {
        for (int i = 1; i <= linhas; i++)
        {
            // Espaços
            for (int j = 1; j <= linhas - i; j++)
            {
                Console.Write(" ");
            }

            // Estrelas
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    static void DesenharCubo(int tamanho)
    {
        // Parte superior 
        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < tamanho; j++)
            {
                Console.Write("*");
            }

            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }

            Console.WriteLine("*");
        }

        // Laterais do cubo
        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                Console.Write("*");
            }

            for (int j = 0; j < tamanho; j++)
            {
                Console.Write(" ");
            }

            Console.WriteLine("*");
        }

        // Base do cubo
        for (int j = 0; j < tamanho * 2 + 1; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }


    // Desenhando o Losango
    static void DesenharLosango(int linhas)
    {
        // Metade superior (for dentro de for)
        for (int i = 1; i <= linhas; i++)
        {
            for (int j = 1; j <= linhas - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        // Metade inferior (usando new string)
        for (int i = linhas - 1; i >= 1; i--)
        {
            Console.Write(new string(' ', linhas - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
    }
}
