using System;
using System.Globalization;

namespace Triangulo
{
    class Program
    {
        static double[] StringToDoubleVec(string[] value){
            double[] new_value = new double[value.Length];
            for (int i = 0; i < new_value.Length; i++)
            {
                new_value[i] = double.Parse(value[i], CultureInfo.InvariantCulture);
            }
            return new_value;
        }

        static void Main(string[] args)
        {
            double[] vetor = StringToDoubleVec(Console.ReadLine().Split(' '));
            double a, b, c;
            string result;
            a = vetor[0]; b = vetor[1]; c = vetor[2];

            if (a < b + c && b < a + c && c < a + b)
            {
                result = (a+b+c).ToString("F1", CultureInfo.InvariantCulture);
                Console.WriteLine($"Perimetro = {result}");
            }
            else
            {
                result = ((c * (a + b))/2).ToString("F1", CultureInfo.InvariantCulture);
                Console.WriteLine($"Area = {result}");
            }
        }
    }
}
