using System;
using System.Collections;

namespace _1176
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long a = 0, b = 1, c = 0;
            ArrayList inputs = new ArrayList();

            for (int i = 0; i < n; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                if (valor == 0) inputs.Add($"Fib({valor}) = 0");
                else
                {
                    for (int k = 0; k < valor; k++)
                    {
                        a = b;
                        b = c;
                        c = a + b;
                    }
                    inputs.Add($"Fib({valor}) = {c}");
                    a = 0;
                    b = 1;
                    c = 0;
                }
            }
            foreach (var item in inputs) Console.WriteLine($"{item}");
            
        }
    }
}
