using System;

namespace MyApp
{
    internal class Program
    {
        /// <summary>
        /// Recebe um nome como parâmetro e retorna uma saudação personalizada.
        /// </summary>
        /// <param name="nome"> Nome de usuario </param>
        /// <returns></returns>
        static String Saudacao(String nome)
        {
            return "Oi " + nome + ", tudo bem?";
        }

        /// <summary>
        /// Soma dois números inteiros e retorna o resultado.
        /// </summary>
        /// <param name="numero1"> Primeiro numero a ser somado </param>
        /// <param name="numero2"> Segundo numero a ser somado </param>
        /// <returns></returns>
        static int AddNumbers(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        /// <summary>
        /// Calcula a area de um retangulo
        /// </summary>
        /// <param name="comprimento"> Valor do comprimento do retangulo </param>
        /// <param name="largura"> Largura do retangulo </param>
        /// <returns></returns>
        static double CalculateRectangleArea(double comprimento, double largura)
        {
            return comprimento * largura;
        }

        /// <summary>
        /// Calcula a area de um triangulo
        /// </summary>
        /// <param name="basetriangulo"> Valor da base do triangulo </param>
        /// <param name="altura"> A altura do triangulo </param>
        /// <returns></returns>
        static double CalculateTriangleArea(double basetriangulo, double altura)
        {
            return (basetriangulo * altura) / 2;
        }

        /// <summary>
        /// Multiplica dois numeros inteiros e retorna o resultado
        /// </summary>
        /// <param name="num1"> O primeiro numero inteiro </param>
        /// <param name="num2"> O segundo numero inteiro </param>
        /// <returns></returns>
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        /// <summary>
        /// Multiplica dois numeros de ponto flutuante e retorna o resultado
        /// </summary>
        /// <param name="num1"> O primeiro numero double </param>
        /// <param name="num2"> O segundo numero double </param>
        /// <returns></returns>
        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Saudacao("Gabriel"));

            Console.WriteLine(AddNumbers(2, 6));
            Console.WriteLine(AddNumbers(12, 28));

            Console.WriteLine(CalculateRectangleArea(10, 5));
            Console.WriteLine(CalculateTriangleArea(6, 8));

            Console.WriteLine(Multiply(4, 4));
            Console.WriteLine(Multiply(2.8, 6.2));
            
        }
    }
}
