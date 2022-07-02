using System;
using System.Globalization;

namespace NumerosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            
            for (int i = 0; i < 6; i++)
            {
                double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (num > 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"{count.ToString()} valores positivos");
        }
    }
}
