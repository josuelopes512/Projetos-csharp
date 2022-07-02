using System;
using System.Globalization;

namespace QuadradoDePares
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            if (valor >= 5 && valor <=2000)
            {
                for (int i = 1; i < valor+1; i++)
                {
                    if (i % 2 == 0) Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
                    
                }
            }
        }
    }
}
