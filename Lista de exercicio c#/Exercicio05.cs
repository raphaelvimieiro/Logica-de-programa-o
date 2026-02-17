using System;
using System.Globalization;

class Exercicio05
{
 static void Main(string[] args)
    
{

Console.WriteLine("Informe o valor de metros");
double metros = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double cm = metros * 100 ;
Console.WriteLine($"O valor em  {cm} cm "); 

Console.ReadKey();
}
}