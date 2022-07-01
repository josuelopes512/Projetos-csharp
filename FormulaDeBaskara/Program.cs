using System;
using System.Globalization;

namespace FormulaDeBaskara
{
    class Program
    {
        static double[] StringToDoubleVec(string[] value){
            double[] new_value = new double[value.Length];
            for (int i = 0; i < new_value.Length; i++)
            {
                try
                {
                    new_value[i] = double.Parse(value[i], CultureInfo.InvariantCulture);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("ERROR");
                }
            }
            return new_value;
        }

        static void Main(string[] args)
        {
            double[] input;
            double a, b, c, r1, r2, delta;
            string str_input = Console.ReadLine(); 
            input = StringToDoubleVec(str_input.Split(' '));
            a = input[0];
            b = input[1];
            c = input[2];
            delta = Math.Pow(b, 2) - (4 * a *c);

            if (delta >= 0 && a != 0)
            {                
                r1 = (-b+Math.Sqrt(delta))/(2*a);
                r2 = (-b-Math.Sqrt(delta))/(2*a);
                if (r1 == Double.NaN)
                {
                    Console.WriteLine("Impossivel calcular");
                }

                if (r1 != Double.NaN && r2 != Double.NaN)
                {
                    Console.WriteLine($"R1 = {r1.ToString("F5", CultureInfo.InvariantCulture)}");
                    Console.WriteLine($"R2 = {r2.ToString("F5", CultureInfo.InvariantCulture)}");
                }
                else
                {
                    Console.WriteLine("Impossivel calcular");
                }

            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}
