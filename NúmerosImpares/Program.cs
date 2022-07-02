using System;

namespace NúmerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            for (int i = 0; i < valor+1; i++){
                if (!(i % 2 == 0)) Console.WriteLine(i.ToString());
            }
        }
    }
}
