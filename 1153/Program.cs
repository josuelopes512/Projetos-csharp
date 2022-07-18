using System;

namespace _1153
{
    class Program
    {
        static void Main(string[] args)
        {
            long m=1;
            int valor = int.Parse(Console.ReadLine());

            for (int i = valor; i >=1; i--)
            {
                m *= i;
            }
            Console.WriteLine(m);
        }
    }
}
