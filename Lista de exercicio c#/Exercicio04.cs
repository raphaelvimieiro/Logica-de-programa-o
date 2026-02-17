using System;

class Exercicio04
{
    static void Main(string[] args)
    {
        
Console.WriteLine("Informe a primeira nota:");
double nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota:");
double nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota:");
double nota3 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a quarta nota:");
double nota4 = double.Parse(Console.ReadLine());

Console.WriteLine($"Nota 1: {nota1}" );
Console.WriteLine($"Nota 2: {nota2}");
Console.WriteLine($"Nota 3: {nota3}");
Console.WriteLine($"Nota 4: {nota4}");

double media = (nota1+nota2+nota3+nota4)/4.0;
Console.WriteLine($"A média do bimestre foi {media}");
  
Console.ReadKey();
  
    }

}