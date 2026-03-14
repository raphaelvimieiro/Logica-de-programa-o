using System;
using System.Globalization;


    internal class Exercicio15
    {
        static void Main(string[] args)
        {
            Console.Write("Informe quanto você ganha por hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe quantas horas você trabalha por mês: ");
            double horasTrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioBruto = valorHora * horasTrabalhadas;
            Console.WriteLine("Salário bruto: " + salarioBruto.ToString("F2", CultureInfo.InvariantCulture));

            double inss = salarioBruto * 0.08;
            double impostoDeRenda = salarioBruto * 0.11;
            double sindicato = salarioBruto * 0.05;
            double salarioLiquido = salarioBruto - (inss + impostoDeRenda + sindicato);

            Console.WriteLine($"Salário Bruto : R${salarioBruto:F2}");
            Console.WriteLine($"INSS (8%): R${inss:F2}");
            Console.WriteLine($"Imposto de Renda (11%): R${impostoDeRenda:F2}");
            Console.WriteLine($"Sindicato (5%): R${sindicato:F2}");
            Console.WriteLine($"Salário Líquido: R${salarioLiquido:F2}");

        }
    }
