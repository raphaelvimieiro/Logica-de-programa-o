using System; 

class URI {

    static void Main(string[] args) { 

/* #### Exercicio 002
Faça um Programa que peça um número e então mostre a mensagem O número
informado foi [número]. */

Console.WriteLine("Digite um número");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"O número informado foi {number}");



    }

}