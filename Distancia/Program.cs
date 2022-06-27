using System;

namespace Distancia
{
    class Program
    {
        static void Main(string[] args)
        {
            int min;
            string result;
            min = (60 * int.Parse(Console.ReadLine())) / 30;
            result = min.ToString();
            Console.WriteLine($"{result} minutos");
        }
    }
}
