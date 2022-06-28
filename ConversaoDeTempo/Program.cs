using System;
using System.Globalization;

namespace ConversaoDeTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, h, m, s;

            n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            h = Math.Floor(n/3600);
            m = Math.Floor((n - (h*3600))/60);
            s = Math.Floor(n%60);

            Console.WriteLine($"{h}:{m}:{s}");
        }
    }
}
