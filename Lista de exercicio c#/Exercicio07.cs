using System;


class Exercicio07
{
 static void Main(string[]args){

Console.WriteLine("Digite o lado do quadrado: ");
int lado = int.Parse(Console.ReadLine());

Console.WriteLine($"Lado = {lado}");

int area = lado * lado;

Console.WriteLine($"Área = {area}");

int dobroarea = area *2;

Console.WriteLine($"Dobro da área = {dobroarea}");

Console.ReadKey();
 }
}