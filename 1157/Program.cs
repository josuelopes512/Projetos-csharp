using System;

namespace _1157
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= valor; i++)
            {
                if(valor % i == 0) Console.WriteLine(i);
            }
            
        }
    }
}
