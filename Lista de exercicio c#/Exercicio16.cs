using System;
using System.Globalization;

namespace PrimerioProjeto
{
   class Exercicio16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho em metros quadrados da área a ser pintada:");
            double area = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double litrosNecessarios  = area / 3.0;
            int latas = (int)Math.Ceiling(litrosNecessarios / 18);
            double precoTotal = latas * 80.0;

            Console.WriteLine($"O número de latas necessárias é:{latas}" );
            Console.WriteLine($"Necessário {litrosNecessarios:F2} litros" );
            Console.WriteLine("O preço total é: R$" + precoTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
