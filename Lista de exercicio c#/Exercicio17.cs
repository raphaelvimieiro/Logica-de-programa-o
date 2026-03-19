using System;
using System.Globalization;

namespace PrimerioProjeto
{
   class Exercicio17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho em metros quadrado da área a ser pintada:");
            double areaSerPintada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double litrosNecessario = (areaSerPintada / 6.0)*1.10;

            double quantidadeDeLatas = Math.Ceiling(litrosNecessario / 18.0);
            double precoLata = quantidadeDeLatas * 80.0;

            double quantidadeGaloes = Math.Ceiling(litrosNecessario / 3.6);
            double precoGalao = quantidadeGaloes * 25.0;

            int latasInteiras = (int)(litrosNecessario /18.0);
            double litrosRestante= litrosNecessario % 18.0;
            double galoesParaResto = Math.Ceiling(litrosRestante / 3.6);
            double precoTotal = (latasInteiras * 80.0) + (galoesParaResto * 25.0);

            Console.WriteLine($"Litros necessários: {litrosNecessario:F2} litros");
           
            Console.WriteLine($"Preço total usando apenas latas de 18 litros: R$ {precoLata:F2}");
            Console.WriteLine($"Preço total usando apenas galões de 3.6 litros: R$ {precoGalao:F2}");
            Console.WriteLine($"O valor mais barato é: R$ {Math.Min(precoLata, precoGalao):F2}");
            Console.WriteLine($"Quantidade de latas necessárias: {Math.Ceiling(quantidadeDeLatas):F2}");
            Console.WriteLine($"Litros restante: {litrosRestante:F2}");
            Console.WriteLine($"Quantidade de galões para o restante: {Math.Ceiling(galoesParaResto):F2}");
            Console.WriteLine($"Preço total usando latas inteiras e galões para o restante: R$ {precoTotal:F2}");
        }
    }
}