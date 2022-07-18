using System;

namespace _1144
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            int a=0, b=0, c=0, d=0;

            for (int i = 1; i <= valor; i++)
            {
                a = i*i;
                b = i*i*i;
                Console.WriteLine($"{i} {a} {b}");
                c = a+1;
                d = b+1;
                Console.WriteLine($"{i} {c} {d}");
            }
        }
    }
}
