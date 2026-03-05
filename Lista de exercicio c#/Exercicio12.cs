using System;
using System.Globalization;

    internal class Exercicio12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua altura:");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pesoIdeal = (72.7 * altura) - 58;
            Console.WriteLine($"O seu peso ideial é {pesoIdeal:F2}");

        }
    }

