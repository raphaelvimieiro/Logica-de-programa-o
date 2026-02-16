using System;


class Exercicio03 {

    static void Main(string[] args){
      
 Console.WriteLine("----- SOMA DE DOIS NÚMEROS -----");

    

Console.WriteLine("Digite o valor do primeiro número") ;
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do segundo número");
double  b = double.Parse(Console.ReadLine());
    
Console.WriteLine($"O valor de A = {a} e B = {b}");

double  soma = a + b;
   
Console.WriteLine($"{a} + {b} = {soma}");
     

Console.ReadKey();


    }
}