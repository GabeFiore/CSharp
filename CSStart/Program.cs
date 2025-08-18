using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;

            Console.WriteLine("Digite o primeiro número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            n2 = int.Parse(Console.ReadLine());

            int n3 = n1 + n2;

            Console.Write("A soma dos números é: " + n3 + ". Portanto, ");

            if (n3 == 0) {
                Console.WriteLine("n3 is zero");
            }
            else if (n3 < 0)
            {
                Console.WriteLine("n3 is negative");
            }
            else if (n3 > 0)
            {
                Console.WriteLine("n3 is positive");
            }
        }
    }
}