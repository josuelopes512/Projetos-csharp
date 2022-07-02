using System;

namespace ParesEntreCincoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                if (valor % 2 == 0) count++;
            }

            Console.WriteLine($"{count.ToString()} valores pares");
        }
    }
}
