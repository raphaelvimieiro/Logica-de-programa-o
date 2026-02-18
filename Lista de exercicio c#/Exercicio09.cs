using System;

using System.Globalization;

class Exercicio09
{
 static void Main(string [] args)
{
   Console.WriteLine("Quanto você ganha por hora ? ");
double  salariohora = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o número de horas trabalhadas no mês: ");
double horastrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double salariototal = salariohora * horastrabalhadas;
Console.WriteLine($"Seu salário do mês é: R$ {salariototal:C2}");

Console.ReadKey();

}   
}
