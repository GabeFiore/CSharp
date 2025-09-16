using System;

class Programa
{
    static void Main()
    {
        int[] numerosSecretos = {4, 21, 43, 38, 27, 25, 11};

        while (true)
        {
            Console.Write("Digite um palpite de 0 à 50 (digite um número negativo para sair): ");
            int palpite = int.Parse(Console.ReadLine());

            if (palpite < 0)
            {
                Console.WriteLine("Programa finalizado!");
                return;
            }

            bool acertou = false;

            foreach (int numero in numerosSecretos)
            {
                if (numero % 2 == 0)
                {
                    continue;
                }

                if (palpite == numero)
                {
                    Console.WriteLine("Acertou, parabéns!");
                    acertou = true;
                    break; 
                }
            }

            if (!acertou)
            {
                Console.WriteLine("Não acertou, tente outro.");
            }
        }
    }
}
