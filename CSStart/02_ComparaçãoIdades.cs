using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarando variáveis
            int idade1 = 0;
            int idade2 = 0;

            //Entrada de dados
            Console.WriteLine("Digite o nome da primeira pessoa:");
            string nome1 = Console.ReadLine();
            Console.WriteLine("Digite a idade do " + nome1 + ":");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa:");
            string nome2 = Console.ReadLine();
            Console.WriteLine("Digite a idade do " + nome2 + ":");
            idade2 = int.Parse(Console.ReadLine());

            //Comparação de idades usando if-else
            if (idade1 > idade2)
            {
                //Concatenação com o operador +
                Console.WriteLine(nome1 + " é mais velho que " + nome2 + ".");
            }
            else if (idade1 < idade2)
            {
                Console.WriteLine(nome2 + " é mais velho que " + nome1 + ".");
            }
            else
            {
                // Interpolação de strings (usando $"{}")
                Console.WriteLine($"{nome1} e {nome2} têm a mesma idade.");
            }
        }
    }
}
