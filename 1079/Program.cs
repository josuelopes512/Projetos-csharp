using System;
using System.Globalization;

namespace _1079
{
    class Program
    {
        static double[] StringToDoubleVec(string[] value){
            double[] new_value = new double[value.Length];
            for (int i = 0; i < new_value.Length; i++) new_value[i] = double.Parse(value[i], CultureInfo.InvariantCulture);
            return new_value;
        }
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            double[] medias = new double[valor];
            for (int i = 0; i < valor; i++)
            {
                double[] m = StringToDoubleVec(Console.ReadLine().Split(' '));
                medias[i] = (double)(((m[0] * 2) + (m[1] * 3) + (m[2] * 5))/(2+3+5));
            }
            for (int i = 0; i < valor; i++) Console.WriteLine(medias[i].ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
