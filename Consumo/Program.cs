using System;
using System.Globalization;

namespace Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, total;
            string result;
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            total = a/b;
            
            result = total.ToString("F3", CultureInfo.InvariantCulture);

            Console.WriteLine($"{result} km/l");


        }
    }
}
