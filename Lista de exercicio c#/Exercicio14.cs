using System;
using System.Globalization;

    class Exercicio14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Limite de peso para carga de peixe é de 50.00 Kg");
            Console.Write("Informe o peso da mercadoria:");
            double pesoPeixe = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            if (pesoPeixe > 50.00)
            {
                Console.WriteLine("Limite de peso excedida!");
                double multa = (pesoPeixe - 50.00) * 4.00;
                Console.WriteLine($"O peso do peixe é:{pesoPeixe:F2} Kg");
                Console.WriteLine("MULTA: R$" + multa.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Carga dentro do limite permitido!");

            }

        }
    }

// Neste exercício  quis trablhar como poderia estar acrescentando duas casas decimais utilizando intrpolação e a concatenação