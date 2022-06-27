using System;
using System.Globalization;

namespace SalarioComBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string result, nome;
            double a, b;
            
            nome = Console.ReadLine();
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            result = (a + (b*15)/100).ToString("F2", CultureInfo.InvariantCulture);

            Console.WriteLine($"TOTAL = R$ {result}");
        }
    }
}
