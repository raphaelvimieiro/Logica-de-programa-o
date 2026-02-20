using System;

using System.Globalization;

class Exercicio10
{
    static void Main(string[] args)
    {
Console.WriteLine("Informe quantos graus Celsius:");
double cel = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

double faren = 	( cel * 9/5.0) + 32.0;
Console.WriteLine($"{cel:F1}°C = {faren:F1}°F ");

    }
}