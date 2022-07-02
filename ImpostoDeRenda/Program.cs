using System;
using System.Globalization;

namespace ImpostoDeRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (value >= 0.00 && value <= 2000.00){
                Console.WriteLine("Isento");
            }
            else{
                value -= 2000.00;
                if (value <= 1000.00){
                    n1 = value*0.08;
                    Console.WriteLine($"R$ {n1.ToString("F2", CultureInfo.InvariantCulture)}");
                }
                else{
                    n1 = 80.00;
                    value -= 1000.00;
                    if (value <= 1500.00){
                        n2 = value*0.18;
                        Console.WriteLine($"R$ {(n1+n2).ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                    else{
                        n2 = 270.00;
                        value -= 1500.00;
                        n3 = value*0.28;
                        Console.WriteLine($"R$ {(n1+n2+n3).ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }
            }
        }
    }
}
