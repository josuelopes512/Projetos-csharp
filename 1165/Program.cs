using System;
using System.Collections;

namespace _1165
{
    class Program
    {
        static void Main(string[] args)
        {
            int count, x, n = int.Parse(Console.ReadLine());
            ArrayList inputs = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                count = 0;
                x = int.Parse(Console.ReadLine());
                for (int j = 2; j < x; j++) if (x % j == 0) count++;
                if (count == 0) inputs.Add($"{x} eh primo");
                else inputs.Add($"{x} nao eh primo");
            }
            foreach (var item in inputs) Console.WriteLine(item);
        }
    }
}
