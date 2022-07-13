using System;

namespace _1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10+1; i++) Console.WriteLine($"{i} x {n} = {i*n}");
        }
    }
}
