using System;
using System.Globalization;

class Exercicio13
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o seu sexo colocando um caractere 'm' para masculino e 'f' para feminino.");
        char sexo = char.Parse(Console.ReadLine());

        while (sexo != 'm' && sexo != 'f')
        {
            Console.WriteLine("Por favor coloque caractere válido!");
            sexo = char.Parse(Console.ReadLine());
        }

        double altura;

        if (sexo == 'm')
        {
            Console.WriteLine("Digite a sua altura");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pesohomem = (72.7 * altura) - 58;

            Console.WriteLine("O peso ideal para você homem é: " +
            pesohomem.ToString("F2", CultureInfo.InvariantCulture));
        }
        else
        {
            Console.WriteLine("Digite a sua altura");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pesomulher = (62.1 * altura) - 44.7;

            Console.WriteLine("O peso ideal para você mulher é: " +
            pesomulher.ToString("F2", CultureInfo.InvariantCulture));
       
       //Quis utilizar o laço de repetição 
        }
    }
}