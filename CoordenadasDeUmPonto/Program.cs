using System;
using System.Globalization;

namespace CoordenadasDeUmPonto
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
            double[] valores = StringToDoubleVec(Console.ReadLine().Split(' '));
            double x, y;

            x = valores[0];
            y = valores[1];


            if(x == 0.0 && y == 0.0){
                Console.WriteLine("Origem");
            }
            else if(x != 0.0 && y == 0.0){
                Console.WriteLine("Eixo X");
            }
            else if(x == 0.0 && y != 0.0){
                Console.WriteLine("Eixo Y");
            }
            else if(x > 0.0){
                if(y > 0.0) Console.WriteLine("Q1");
                else Console.WriteLine("Q4");
            }
            else if(x < 0.0){
                if(y > 0.0) Console.WriteLine("Q2");
                else Console.WriteLine("Q3");
            }
        }
    }
}
