using System;
using System.Globalization;

namespace PositivosEMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            int pos=0;
            double soma=0;
            for (int i = 0; i < 6; i++)
            {
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (valor > 0){
                    soma += valor; 
                    pos++;
                } 
            }
            Console.WriteLine($"{pos} valores positivos");
            Console.WriteLine((soma/pos).ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
