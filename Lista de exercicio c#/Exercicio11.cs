using System;
using System.Globalization;

     class Exercicio11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primieiro número inteiro:");
            int a  = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número inteiro:");
            int b  = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número real:");
            double c  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int exercicio1 = (a * 2) * (b / 2);
            double exercicio2 = (a * 3.00) + c;
           double exercicio3 = Math.Pow(c, 3.00);
            Console.WriteLine($"Produto do dobro do primeiro com metade do segundo: {exercicio1}");
            Console.WriteLine($"Soma do triplo do primeiro com o terceiro:{exercicio2}");
            Console.WriteLine($"Terceiro elevado ao cubo:{exercicio3}");
        }
    }