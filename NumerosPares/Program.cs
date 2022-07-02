using System;

namespace NumerosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100+1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
    }
}
