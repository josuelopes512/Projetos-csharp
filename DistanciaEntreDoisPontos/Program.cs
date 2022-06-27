using System;
using System.Globalization;

namespace DistanciaEntreDoisPontos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada_1, entrada_2;
            double distancia, soma;
            string result;

            entrada_1 = Console.ReadLine().Split(' ');
            entrada_2 = Console.ReadLine().Split(' ');

            double[] entrada_1_double = new double[entrada_1.Length];
            double[] entrada_2_double = new double[entrada_2.Length];

            for (int i = 0; i < entrada_1_double.Length; i++)
            {   
                entrada_1_double[i] = double.Parse(entrada_1[i], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < entrada_2_double.Length; i++)
            {   
                entrada_2_double[i] = double.Parse(entrada_2[i], CultureInfo.InvariantCulture);
            }

            soma = Math.Pow((entrada_2_double[0] - entrada_1_double[0]), 2);
            soma += Math.Pow((entrada_2_double[entrada_2_double.Length-1] - entrada_1_double[entrada_2_double.Length-1]), 2);
            distancia = Math.Sqrt(soma);

            result = distancia.ToString("F4", CultureInfo.InvariantCulture);

            Console.WriteLine($"{result}");
        }
    }
}
