using System;
using System.Globalization;

namespace AumentoDeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double reajuste, value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int percentual = 0;
            if (value >= 0.00 && value <= 400.00) percentual = 15;
            else if (value >= 400.01 && value <= 800.00) percentual = 12;
            else if (value >= 800.01 && value <= 1200.00) percentual = 10;
            else if (value >= 1200.01 && value <= 2000.00) percentual = 7;
            else if (value > 2000.00) percentual = 4;

            reajuste = (value * percentual)/100;
            value += reajuste;
            
            Console.WriteLine($"Novo salario: {value.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Em percentual: {percentual.ToString()} %");
        }
    }
}
