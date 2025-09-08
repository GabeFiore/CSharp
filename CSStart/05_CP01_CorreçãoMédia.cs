// Projeto de Avaliação (Revisado) - Variante 3: Cálculo de média de três notas
// Este programa deve solicitar o nome do estudante e três notas, calcular e exibir a média.
// Vários erros foram introduzidos na declaração dos tipos, controle de loop e operações aritméticas.


using System;

namespace CP01 
{
    internal class Program 
    {
        static void Main()
        {
            Console.WriteLine("Digite o nome do estudante:");
            string nome = Console.ReadLine(); // estava como int e o correto é string
            
            double soma = 0;

            for (int i = 1; i <= 3; i++) // i estava como =0 portanto ia ler 4 notas
            {
                Console.WriteLine("Digite a nota " + i + ":");
                double nota = double.Parse(Console.ReadLine()); // estava como string e neste caso tem que converter pra double

                soma = soma + nota;
            }

            double media = soma / 3; //dividindo por 3 notas
            Console.WriteLine("A média do estudante " + nome + " é " + media);
        }
    }
}
