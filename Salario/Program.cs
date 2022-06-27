using System;
using System.Globalization;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double c; 
            string result;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            result = (b*c).ToString("F2", CultureInfo.InvariantCulture);

            Console.WriteLine($"NUMBER = {a}");
            Console.WriteLine($"SALARY = U$ {result}");
        }
    }
}
