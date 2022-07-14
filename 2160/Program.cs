using System;

namespace _2160
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.Length > 80) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
