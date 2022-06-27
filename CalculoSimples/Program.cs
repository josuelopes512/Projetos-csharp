using System;
using System.Globalization;

namespace CalculoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada_1, entrada_2;
            string result;
            double tmp;

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

            tmp = ((entrada_1_double[entrada_1.Length-2]) * (entrada_1_double[entrada_1.Length-1])) + ((entrada_2_double[entrada_2.Length-2]) * (entrada_2_double[entrada_2.Length-1]));
            result = tmp.ToString("F2", CultureInfo.InvariantCulture);
            Console.WriteLine($"VALOR A PAGAR: R$ {result}");

        }
    }
}
