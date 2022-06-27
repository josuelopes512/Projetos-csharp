using System;
using System.Globalization;

namespace Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, volume;
            string result;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            volume = (4.0/3.0) * 3.14159 * Math.Pow(raio, 3);

            result = volume.ToString("F3", CultureInfo.InvariantCulture);

            Console.WriteLine($"VOLUME = {result}");
        }
    }
}
