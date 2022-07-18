using System;

namespace _1143
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
            {
                Console.WriteLine($"{i} {i*i} {i*i*i}");
            }
        }
    }
}
