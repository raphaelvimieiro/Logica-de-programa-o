using System;
using System.Globalization;

namespace PrimerioProjeto
{
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho em metros quadrados da área a ser pintada:");
               double area = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double litros = area / 3.0;
            int latas = (int)Math.Ceiling(litros / 18);
            double preco = latas * 80;
            Console.WriteLine($"O número de latas necessárias é:{latas}" );
            Console.WriteLine($"Litros necessários:{litros}lata(s)" );
            Console.WriteLine("O preço total é: R$" + preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

