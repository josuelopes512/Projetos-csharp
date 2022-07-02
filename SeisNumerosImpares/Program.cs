using System;

namespace SeisNumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int count=0, valor = int.Parse(Console.ReadLine());
            while (count < 6)
            {
                if (valor % 2 != 0)
                {
                    Console.WriteLine(valor);
                    count++;
                }
                valor++;
            }
        }
    }
}
