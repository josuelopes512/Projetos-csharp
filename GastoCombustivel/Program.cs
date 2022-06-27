using System;
using System.Globalization;

namespace GastoCombustivel
{
    public class Program
    {
        static void Main(string[] args){
            int tempo, velocidade;
            double media, km;
            string result;

            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            km = tempo * velocidade;
            media = km/12;

            result = media.ToString("F3", CultureInfo.InvariantCulture);
            Console.WriteLine($"{result}");
        }
    }
}