using System;
using System.Globalization;
class Exercicio06
{
  static void Main(string[] args)
{
    Console.WriteLine("Informe o valor do raio do circulo");
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double area = Math.PI * Math.Pow(raio,2);
Console.WriteLine($"O valor da área do circulo é {area:F4}");

}  
}
